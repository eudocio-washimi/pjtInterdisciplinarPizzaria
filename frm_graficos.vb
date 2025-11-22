Imports System.IO

Public Class frm_graficos

    Private Sub frm_graficos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_status.Text = "Selecione uma análise."
    End Sub

    ' --- MOTOR DE INTEGRAÇÃO (VB -> PYTHON) ---
    Sub GerarGrafico(tipo As String, sql As String)
        lbl_status.Text = "Consultando dados e gerando gráfico..."
        Me.Refresh() ' Atualiza a interface

        Try
            ' 1. Executa SQL no Access
            rs = db.Execute(sql)

            If rs.EOF Then
                MsgBox("Sem dados suficientes para este gráfico.", MsgBoxStyle.Information)
                lbl_status.Text = "Sem dados."
                Exit Sub
            End If

            ' 2. Gera o CSV (Separador ponto e vírgula ;)
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
                    ' Remove quebras de linha e o próprio separador (;) para não quebrar o arquivo
                    valor = valor.Replace(";", ",").Replace(vbCrLf, " ").Replace(vbCr, "").Replace(vbLf, "")
                    csv.Append(valor & ";")
                Next
                csv.AppendLine()
                rs.MoveNext()
            Loop

            ' Salva CSV (Encoding Default é crucial para acentos no Windows)
            Dim pathCsv As String = Application.StartupPath & "\dados_temp.csv"
            File.WriteAllText(pathCsv, csv.ToString(), System.Text.Encoding.Default)

            ' 3. Chama o Python
            Dim p As New Process()
            p.StartInfo.FileName = "python"
            p.StartInfo.Arguments = $"graficos.py {tipo}"
            p.StartInfo.WorkingDirectory = Application.StartupPath
            p.StartInfo.CreateNoWindow = True
            p.StartInfo.UseShellExecute = False
            p.Start()
            p.WaitForExit() ' Espera o Python terminar

            ' 4. Carrega a Imagem
            Dim pathImg As String = Application.StartupPath & "\grafico_gerado.png"

            If File.Exists(pathImg) Then
                ' Usa FileStream para não travar o arquivo (permite gerar outro em seguida)
                Using fs As New FileStream(pathImg, FileMode.Open, FileAccess.Read)
                    pic_grafico.Image = Image.FromStream(fs)
                End Using
                lbl_status.Text = "Gráfico gerado com sucesso!"
            Else
                lbl_status.Text = "Erro na geração."
                MsgBox("O Python não gerou a imagem. Verifique se instalou: pip install pandas matplotlib")
            End If

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            lbl_status.Text = "Erro."
        End Try
    End Sub

    ' --- BOTÕES (SQLs Específicos) ---

    Private Sub btn_faturamento_Click(sender As Object, e As EventArgs) Handles btn_faturamento.Click
        ' Compara Meses/Anos
        Dim sql As String = "SELECT data_venda, valor_total FROM tb_vendas ORDER BY data_venda"
        GerarGrafico("FATURAMENTO", sql)
    End Sub

    Private Sub btn_pizzas_Click(sender As Object, e As EventArgs) Handles btn_pizzas.Click
        ' Produtos Mais Vendidos (Une as 3 tabelas)
        Dim sql As String = "SELECT p.nome as nome_produto, i.qtd FROM tb_itens_venda i INNER JOIN tb_pizzas p ON i.id_produto = p.id_pizza WHERE i.tipo_produto = 'Pizza' " &
                            "UNION ALL " &
                            "SELECT c.nome as nome_produto, i.qtd FROM tb_itens_venda i INNER JOIN tb_catitos c ON i.id_produto = c.id_catito WHERE i.tipo_produto = 'Catito' " &
                            "UNION ALL " &
                            "SELECT b.nome as nome_produto, i.qtd FROM tb_itens_venda i INNER JOIN tb_bebidas b ON i.id_produto = b.id_bebida WHERE i.tipo_produto = 'Bebida'"
        GerarGrafico("PIZZAS", sql)
    End Sub

    Private Sub btn_bairros_Click(sender As Object, e As EventArgs) Handles btn_bairros.Click
        ' Top Bairros
        Dim sql As String = "SELECT c.bairro FROM tb_vendas v INNER JOIN tb_clientes c ON v.id_cliente = c.id_cliente WHERE c.bairro IS NOT NULL AND c.bairro <> ''"
        GerarGrafico("BAIRROS", sql)
    End Sub

    Private Sub btn_motoboys_Click(sender As Object, e As EventArgs) Handles btn_motoboys.Click
        ' Produtividade Motoboys
        Dim sql As String = "SELECT m.nome as nome_motoboy FROM tb_vendas v INNER JOIN tb_motoboys m ON v.id_motoboy = m.id_motoboy WHERE v.tipo_pedido = 'Entrega'"
        GerarGrafico("MOTOBOYS", sql)
    End Sub

    Private Sub btn_tipo_Click(sender As Object, e As EventArgs) Handles btn_tipo.Click
        ' Salão vs Entrega
        Dim sql As String = "SELECT tipo_pedido FROM tb_vendas"
        GerarGrafico("TIPO", sql)
    End Sub

    Private Sub btn_dias_Click(sender As Object, e As EventArgs) Handles btn_dias.Click
        ' Dias da Semana
        Dim sql = "SELECT data_venda FROM tb_vendas"
        GerarGrafico("DIAS", sql)
    End Sub

    Private Sub frm_graficos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_menu.Show()
    End Sub
End Class