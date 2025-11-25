Imports System.IO

Public Class frm_graficos

    Private Sub frm_graficos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_status.Text = "Selecione uma análise."
    End Sub

    ' --- MOTOR DE GERAÇÃO GENÉRICO ---
    ' Esta função recebe o TIPO de gráfico e o CONTEÚDO do CSV já pronto
    ' e faz a ponte com o Python.
    Sub ProcessarGrafico(tipo As String, dadosCSV As System.Text.StringBuilder)
        lbl_status.Text = "Gerando gráfico..."
        Me.Refresh()

        Try
            ' 1. Salva o arquivo CSV
            ' O encoding Default é usado para garantir que acentos (ç, ã) funcionem no Python/Excel
            Dim pathCsv As String = Application.StartupPath & "\dados_temp.csv"
            File.WriteAllText(pathCsv, dadosCSV.ToString(), System.Text.Encoding.Default)

            ' 2. Chama o script Python
            Dim p As New Process()
            p.StartInfo.FileName = "python"
            ' Passa o nome do script (graficos.py) e o tipo de gráfico como argumentos
            p.StartInfo.Arguments = $"graficos.py {tipo}"
            p.StartInfo.WorkingDirectory = Application.StartupPath
            p.StartInfo.CreateNoWindow = True
            p.StartInfo.UseShellExecute = False
            p.Start()
            p.WaitForExit() ' Espera o Python terminar de desenhar

            ' 3. Carrega a imagem gerada
            Dim pathImg As String = Application.StartupPath & "\grafico_gerado.png"

            If File.Exists(pathImg) Then
                ' Usa FileStream para não travar o arquivo (permite gerar outro em seguida sem erro de "arquivo em uso")
                Using fs As New FileStream(pathImg, FileMode.Open, FileAccess.Read)
                    pic_grafico.Image = Image.FromStream(fs)
                End Using
                lbl_status.Text = "Gráfico atualizado!"
            Else
                lbl_status.Text = "Erro na geração."
                MsgBox("Imagem não gerada. Verifique se o Python e as bibliotecas (pandas, matplotlib) estão instalados.")
            End If

        Catch ex As Exception
            MsgBox("Erro de Integração: " & ex.Message)
        End Try
    End Sub

    ' --- GERAÇÃO SIMPLES (SQL -> CSV) ---
    ' Esta função é usada para gráficos que dependem apenas de uma consulta SQL direta
    Sub GerarGraficoSQL(tipo As String, sql As String)
        Try
            rs = db.Execute(sql)
            If rs.EOF Then
                MsgBox("Sem dados para exibir.", MsgBoxStyle.Information)
                lbl_status.Text = "Sem dados."
                Exit Sub
            End If

            Dim csv As New System.Text.StringBuilder()

            ' Cabeçalho
            For i As Integer = 0 To rs.Fields.Count - 1
                csv.Append(rs.Fields(i).Name & ";")
            Next
            csv.AppendLine()

            ' Dados
            Do While Not rs.EOF
                For i As Integer = 0 To rs.Fields.Count - 1
                    Dim valor As String = rs.Fields(i).Value.ToString()
                    ' Remove ponto e vírgula e quebras de linha para não quebrar o formato CSV
                    valor = valor.Replace(";", ",").Replace(vbCrLf, "").Replace(vbCr, "").Replace(vbLf, "")
                    csv.Append(valor & ";")
                Next
                csv.AppendLine()
                rs.MoveNext()
            Loop

            ProcessarGrafico(tipo, csv)

        Catch ex As Exception
            MsgBox("Erro SQL: " & ex.Message)
        End Try
    End Sub

    ' ------------------------------------------
    ' BOTÕES DOS GRÁFICOS FINANCEIROS (V2.0)
    ' ------------------------------------------

    ' 1. FLUXO DE CAIXA (Lucro: Vendas vs Gastos)
    Private Sub btn_lucro_Click(sender As Object, e As EventArgs) Handles btn_lucro.Click
        Dim csv As New System.Text.StringBuilder()
        csv.AppendLine("data;tipo;valor") ' Cabeçalho padronizado para este gráfico

        Try
            ' Busca Vendas (Entradas)
            rs = db.Execute("SELECT data_venda, valor_total FROM tb_vendas")
            While Not rs.EOF
                csv.AppendLine($"{rs.Fields("data_venda").Value};Entrada;{rs.Fields("valor_total").Value}")
                rs.MoveNext()
            End While

            ' Busca Gastos (Saídas)
            rs = db.Execute("SELECT data_gasto, valor FROM tb_gastos")
            While Not rs.EOF
                csv.AppendLine($"{rs.Fields("data_gasto").Value};Saida;{rs.Fields("valor").Value}")
                rs.MoveNext()
            End While

            ProcessarGrafico("LUCRO", csv)

        Catch ex As Exception
            MsgBox("Erro ao consolidar dados: " & ex.Message)
        End Try
    End Sub

    ' 2. MEIOS DE PAGAMENTO (Pizza)
    Private Sub btn_pagamentos_Click(sender As Object, e As EventArgs) Handles btn_pagamentos.Click
        Dim sql As String = "SELECT forma_pagamento, valor_total FROM tb_vendas WHERE forma_pagamento IS NOT NULL"
        GerarGraficoSQL("PAGAMENTOS", sql)
    End Sub

    ' 3. TIPOS DE GASTOS (Fixo vs Variável)
    Private Sub btn_gastos_tipo_Click(sender As Object, e As EventArgs) Handles btn_gastos_tipo.Click
        Dim sql As String = "SELECT tipo_custo, valor FROM tb_gastos"
        GerarGraficoSQL("TIPO_GASTO", sql)
    End Sub

    ' 4. FATURAMENTO BRUTO (Evolução Mensal)
    Private Sub btn_faturamento_Click(sender As Object, e As EventArgs) Handles btn_faturamento.Click
        Dim sql As String = "SELECT data_venda, valor_total FROM tb_vendas ORDER BY data_venda"
        GerarGraficoSQL("FATURAMENTO", sql)
    End Sub

    ' ------------------------------------------
    ' BOTÕES OPERACIONAIS (V1.0)
    ' ------------------------------------------

    Private Sub btn_pizzas_Click(sender As Object, e As EventArgs) Handles btn_pizzas.Click
        ' Une as 3 tabelas de produtos para ver o top vendas geral
        Dim sql As String = "SELECT p.nome as nome_produto, i.qtd FROM tb_itens_venda i INNER JOIN tb_pizzas p ON i.id_produto = p.id_pizza WHERE i.tipo_produto = 'Pizza' " &
                            "UNION ALL " &
                            "SELECT c.nome as nome_produto, i.qtd FROM tb_itens_venda i INNER JOIN tb_catitos c ON i.id_produto = c.id_catito WHERE i.tipo_produto = 'Catito' " &
                            "UNION ALL " &
                            "SELECT b.nome as nome_produto, i.qtd FROM tb_itens_venda i INNER JOIN tb_bebidas b ON i.id_produto = b.id_bebida WHERE i.tipo_produto = 'Bebida'"
        GerarGraficoSQL("PIZZAS", sql)
    End Sub

    Private Sub btn_bairros_Click(sender As Object, e As EventArgs) Handles btn_bairros.Click
        Dim sql As String = "SELECT c.bairro FROM tb_vendas v INNER JOIN tb_clientes c ON v.id_cliente = c.id_cliente WHERE c.bairro IS NOT NULL AND c.bairro <> ''"
        GerarGraficoSQL("BAIRROS", sql)
    End Sub

    Private Sub btn_motoboys_Click(sender As Object, e As EventArgs) Handles btn_motoboys.Click
        Dim sql As String = "SELECT m.nome as nome_motoboy FROM tb_vendas v INNER JOIN tb_motoboys m ON v.id_motoboy = m.id_motoboy WHERE v.tipo_pedido = 'Entrega'"
        GerarGraficoSQL("MOTOBOYS", sql)
    End Sub

    Private Sub btn_tipo_Click(sender As Object, e As EventArgs) Handles btn_tipo.Click
        Dim sql As String = "SELECT tipo_pedido FROM tb_vendas"
        GerarGraficoSQL("TIPO", sql)
    End Sub

    Private Sub btn_dias_Click(sender As Object, e As EventArgs) Handles btn_dias.Click
        Dim sql As String = "SELECT data_venda FROM tb_vendas"
        GerarGraficoSQL("DIAS", sql)
    End Sub

    Private Sub frm_graficos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_menu.Show()
    End Sub
End Class