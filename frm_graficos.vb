Imports System.IO
Imports System.Text

Public Class frm_graficos

    Private Sub frm_graficos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_status.Text = "Selecione uma análise para visualizar."
    End Sub

    Sub ProcessarGrafico(tipo As String, dadosCSV As System.Text.StringBuilder)
        lbl_status.Text = "Gerando gráfico..."
        Me.Refresh()

        Dim nomeArquivoImg As String = $"grafico_{tipo}.png"
        Dim pathImg As String = Application.StartupPath & "\" & nomeArquivoImg
        Dim pathCsv As String = Application.StartupPath & "\dados_temp.csv"

        Try
            If File.Exists(pathImg) Then
                pic_grafico.Image = Nothing
                GC.Collect()
                Try : File.Delete(pathImg) : Catch : End Try
            End If

            File.WriteAllText(pathCsv, dadosCSV.ToString(), Encoding.UTF8)

            Dim p As New Process()
            p.StartInfo.FileName = "python"
            p.StartInfo.Arguments = $"graficos.py {tipo} {nomeArquivoImg}"
            p.StartInfo.WorkingDirectory = Application.StartupPath
            p.StartInfo.CreateNoWindow = True
            p.StartInfo.UseShellExecute = False
            p.Start()
            p.WaitForExit()

            If File.Exists(pathImg) Then
                Using fs As New FileStream(pathImg, FileMode.Open, FileAccess.Read)
                    pic_grafico.Image = Image.FromStream(fs)
                End Using
                lbl_status.Text = $"Análise: {tipo}"
            Else
                lbl_status.Text = "Erro na geração."
                MsgBox("Imagem não gerada.", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Sub GerarGraficoSQL(tipo As String, sql As String)
        Try
            rs = db.Execute(sql)
            If rs.EOF Then
                MsgBox("Sem dados.", MsgBoxStyle.Information)
                lbl_status.Text = "Vazio."
                Exit Sub
            End If

            Dim csv As New System.Text.StringBuilder()
            For i As Integer = 0 To rs.Fields.Count - 1
                csv.Append(rs.Fields(i).Name & ";")
            Next
            csv.AppendLine()

            Do While Not rs.EOF
                For i As Integer = 0 To rs.Fields.Count - 1
                    Dim valor As String = rs.Fields(i).Value.ToString()
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

    Private Sub btn_lucro_Click(sender As Object, e As EventArgs) Handles btn_lucro.Click
        Dim csv As New System.Text.StringBuilder()
        csv.AppendLine("data;tipo;valor")
        Try
            rs = db.Execute("SELECT data_venda, valor_total FROM tb_vendas")
            While Not rs.EOF
                csv.AppendLine($"{rs.Fields("data_venda").Value};Entrada;{rs.Fields("valor_total").Value}")
                rs.MoveNext()
            End While
            rs = db.Execute("SELECT data_gasto, valor FROM tb_gastos")
            While Not rs.EOF
                csv.AppendLine($"{rs.Fields("data_gasto").Value};Saida;{rs.Fields("valor").Value}")
                rs.MoveNext()
            End While
            ProcessarGrafico("LUCRO", csv)
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_pagamentos_Click(sender As Object, e As EventArgs) Handles btn_pagamentos.Click
        GerarGraficoSQL("PAGAMENTOS", "SELECT forma_pagamento, valor_total FROM tb_vendas WHERE forma_pagamento IS NOT NULL")
    End Sub

    Private Sub btn_gastos_tipo_Click(sender As Object, e As EventArgs) Handles btn_gastos_tipo.Click
        GerarGraficoSQL("TIPO_GASTO", "SELECT tipo_custo, valor FROM tb_gastos")
    End Sub

    Private Sub btn_faturamento_Click(sender As Object, e As EventArgs) Handles btn_faturamento.Click
        GerarGraficoSQL("FATURAMENTO", "SELECT data_venda, valor_total FROM tb_vendas ORDER BY data_venda")
    End Sub

    Private Sub btn_pizzas_Click(sender As Object, e As EventArgs) Handles btn_pizzas.Click
        Dim sql As String = "SELECT p.nome as nome_produto, i.qtd FROM tb_itens_venda i INNER JOIN tb_pizzas p ON i.id_produto = p.id_pizza WHERE i.tipo_produto = 'Pizza' " &
                            "UNION ALL SELECT c.nome as nome_produto, i.qtd FROM tb_itens_venda i INNER JOIN tb_catitos c ON i.id_produto = c.id_catito WHERE i.tipo_produto = 'Catito' " &
                            "UNION ALL SELECT b.nome as nome_produto, i.qtd FROM tb_itens_venda i INNER JOIN tb_bebidas b ON i.id_produto = b.id_bebida WHERE i.tipo_produto = 'Bebida'"
        GerarGraficoSQL("PIZZAS", sql)
    End Sub

    Private Sub btn_bairros_Click(sender As Object, e As EventArgs) Handles btn_bairros.Click
        GerarGraficoSQL("BAIRROS", "SELECT c.bairro FROM tb_vendas v INNER JOIN tb_clientes c ON v.id_cliente = c.id_cliente WHERE c.bairro IS NOT NULL AND c.bairro <> ''")
    End Sub

    Private Sub btn_motoboys_Click(sender As Object, e As EventArgs) Handles btn_motoboys.Click
        GerarGraficoSQL("MOTOBOYS", "SELECT m.nome as nome_motoboy FROM tb_vendas v INNER JOIN tb_motoboys m ON v.id_motoboy = m.id_motoboy WHERE v.tipo_pedido = 'Entrega'")
    End Sub

    Private Sub btn_tipo_Click(sender As Object, e As EventArgs) Handles btn_tipo.Click
        GerarGraficoSQL("TIPO", "SELECT tipo_pedido FROM tb_vendas")
    End Sub

    Private Sub btn_dias_Click(sender As Object, e As EventArgs) Handles btn_dias.Click
        GerarGraficoSQL("DIAS", "SELECT data_venda FROM tb_vendas")
    End Sub

    Private Sub pic_grafico_Click(sender As Object, e As EventArgs) Handles pic_grafico.Click

    End Sub
End Class