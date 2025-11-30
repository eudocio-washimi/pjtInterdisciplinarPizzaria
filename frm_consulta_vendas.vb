Public Class frm_consulta_vendas

    Private Sub frm_consulta_vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hoje As Date = Date.Now
        dtp_inicio.Value = New Date(hoje.Year, hoje.Month, 1)
        dtp_fim.Value = hoje

        rdb_todos.Checked = True
    End Sub
    Private Sub btn_filtrar_Click(sender As Object, e As EventArgs) Handles btn_filtrar.Click
        CarregarExtrato()
    End Sub
    Private Sub rdb_todos_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_todos.CheckedChanged
        If rdb_todos.Checked Then CarregarExtrato()
    End Sub
    Private Sub rdb_entradas_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_entradas.CheckedChanged
        If rdb_entradas.Checked Then CarregarExtrato()
    End Sub
    Private Sub rdb_saidas_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_saidas.CheckedChanged
        If rdb_saidas.Checked Then CarregarExtrato()
    End Sub

    Private Sub chk_agrupar_data_CheckedChanged(sender As Object, e As EventArgs) Handles chk_agrupar_data.CheckedChanged
        CarregarExtrato()
    End Sub

    Sub CarregarExtrato()
        Dim totalEntradas As Double = 0
        Dim totalSaidas As Double = 0

        dgv_financeiro.Rows.Clear()

        Try
            Dim d1 As String = dtp_inicio.Value.ToString("MM/dd/yyyy")
            Dim d2 As String = dtp_fim.Value.ToString("MM/dd/yyyy")

            Dim listaTemp As New List(Of ItemFinanceiro)

            If rdb_todos.Checked Or rdb_entradas.Checked Then
                sql = "SELECT v.data_venda, c.nome, v.valor_total " &
                      "FROM tb_vendas v INNER JOIN tb_clientes c ON v.id_cliente = c.id_cliente " &
                      $"WHERE v.data_venda BETWEEN #{d1} 00:00:00# AND #{d2} 23:59:59#"

                rs = db.Execute(sql)
                While Not rs.EOF
                    Dim valor As Double = CDbl(rs.Fields("valor_total").Value)
                    Dim data As Date = rs.Fields("data_venda").Value

                    listaTemp.Add(New ItemFinanceiro With {
                        .Data = data.Date,
                        .Descricao = "Venda - " & rs.Fields("nome").Value,
                        .Tipo = "VENDA",
                        .Entrada = valor,
                        .Saida = 0
                    })
                    totalEntradas += valor
                    rs.MoveNext()
                End While
            End If

            If rdb_todos.Checked Or rdb_saidas.Checked Then
                sql = "SELECT g.data_gasto, f.nome, g.descricao, g.valor " &
                      "FROM tb_gastos g INNER JOIN tb_fornecedores f ON g.id_fornecedor = f.id_fornecedor " &
                      $"WHERE g.data_gasto BETWEEN #{d1} 00:00:00# AND #{d2} 23:59:59#"

                rs = db.Execute(sql)
                While Not rs.EOF
                    Dim valor As Double = CDbl(rs.Fields("valor").Value)
                    Dim data As Date = rs.Fields("data_gasto").Value

                    listaTemp.Add(New ItemFinanceiro With {
                        .Data = data.Date,
                        .Descricao = "Pgto: " & rs.Fields("nome").Value & " (" & rs.Fields("descricao").Value & ")",
                        .Tipo = "GASTO",
                        .Entrada = 0,
                        .Saida = valor
                    })
                    totalSaidas += valor
                    rs.MoveNext()
                End While
            End If

            listaTemp = listaTemp.OrderBy(Function(x) x.Data).ToList()

            If chk_agrupar_data.Checked Then
                Dim agrupado = listaTemp.GroupBy(Function(x) x.Data)

                For Each grupo In agrupado
                    Dim somaEntrada As Double = grupo.Sum(Function(x) x.Entrada)
                    Dim somaSaida As Double = grupo.Sum(Function(x) x.Saida)

                    dgv_financeiro.Rows.Add(
                        grupo.Key.ToString("dd/MM/yyyy"),
                        "RESUMO DO DIA (Consolidado)",
                        "TOTAL",
                        If(somaEntrada > 0, somaEntrada, Nothing),
                        If(somaSaida > 0, somaSaida, Nothing)
                    )
                Next
            Else
                For Each item In listaTemp
                    dgv_financeiro.Rows.Add(
                        item.Data.ToString("dd/MM/yyyy"),
                        item.Descricao,
                        item.Tipo,
                        If(item.Entrada > 0, item.Entrada, Nothing),
                        If(item.Saida > 0, item.Saida, Nothing)
                    )
                Next
            End If

            lbl_total_entradas.Text = FormatCurrency(totalEntradas)
            lbl_total_saidas.Text = FormatCurrency(totalSaidas)
            Dim saldo As Double = totalEntradas - totalSaidas
            lbl_saldo_final.Text = FormatCurrency(saldo)
            lbl_saldo_final.ForeColor = If(saldo >= 0, Color.Green, Color.Red)

        Catch ex As Exception
            MsgBox("Erro ao gerar extrato: " & ex.Message)
        End Try
    End Sub
    Private Class ItemFinanceiro
        Public Property Data As Date
        Public Property Descricao As String
        Public Property Tipo As String
        Public Property Entrada As Double
        Public Property Saida As Double
    End Class

End Class