Public Class frm_consulta_vendas

    Private Sub frm_consulta_vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrid()
        Dim hoje As Date = Date.Now
        dtp_inicio.Value = New Date(hoje.Year, hoje.Month, 1)
        dtp_fim.Value = hoje
        rdb_todos.Checked = True
    End Sub

    Sub ConfigurarGrid()
        dgv_financeiro.Columns.Clear()

        dgv_financeiro.Columns.Add("data", "Data")
        dgv_financeiro.Columns("data").Width = 80

        dgv_financeiro.Columns.Add("descricao", "Descrição / Cliente / Fornecedor")
        dgv_financeiro.Columns("descricao").Width = 250

        dgv_financeiro.Columns.Add("tipo", "Tipo")
        dgv_financeiro.Columns("tipo").Width = 80

        dgv_financeiro.Columns.Add("entrada", "Entrada (+)")
        dgv_financeiro.Columns("entrada").Width = 90
        dgv_financeiro.Columns("entrada").DefaultCellStyle.Format = "N2"
        dgv_financeiro.Columns("entrada").DefaultCellStyle.ForeColor = Color.Green

        dgv_financeiro.Columns.Add("saida", "Saída (-)")
        dgv_financeiro.Columns("saida").Width = 90
        dgv_financeiro.Columns("saida").DefaultCellStyle.Format = "N2"
        dgv_financeiro.Columns("saida").DefaultCellStyle.ForeColor = Color.Red
    End Sub

    ' Eventos de Filtro
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

    ' Novo evento do Checkbox
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

            ' Lista temporária para guardar os dados antes de exibir (usada para agrupar)
            Dim listaTemp As New List(Of ItemFinanceiro)

            ' --- 1. BUSCAR VENDAS ---
            If rdb_todos.Checked Or rdb_entradas.Checked Then
                sql = "SELECT v.data_venda, c.nome, v.valor_total " &
                      "FROM tb_vendas v INNER JOIN tb_clientes c ON v.id_cliente = c.id_cliente " &
                      $"WHERE v.data_venda BETWEEN #{d1} 00:00:00# AND #{d2} 23:59:59#"

                rs = db.Execute(sql)
                While Not rs.EOF
                    Dim valor As Double = CDbl(rs.Fields("valor_total").Value)
                    Dim data As Date = rs.Fields("data_venda").Value

                    listaTemp.Add(New ItemFinanceiro With {
                        .Data = data.Date, ' Pega só a data (sem hora) para agrupar
                        .Descricao = "Venda - " & rs.Fields("nome").Value,
                        .Tipo = "VENDA",
                        .Entrada = valor,
                        .Saida = 0
                    })
                    totalEntradas += valor
                    rs.MoveNext()
                End While
            End If

            ' --- 2. BUSCAR GASTOS ---
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

            ' --- 3. PROCESSAR LISTA (AGRUPAR OU NÃO) ---

            ' Ordena por data sempre
            listaTemp = listaTemp.OrderBy(Function(x) x.Data).ToList()

            If chk_agrupar_data.Checked Then
                ' MODO AGRUPADO: Soma tudo por dia
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
                ' MODO DETALHADO: Lista item a item
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

            ' 4. TOTAIS (Sempre iguais, independente da visão)
            lbl_total_entradas.Text = FormatCurrency(totalEntradas)
            lbl_total_saidas.Text = FormatCurrency(totalSaidas)
            Dim saldo As Double = totalEntradas - totalSaidas
            lbl_saldo_final.Text = FormatCurrency(saldo)
            lbl_saldo_final.ForeColor = If(saldo >= 0, Color.Green, Color.Red)

        Catch ex As Exception
            MsgBox("Erro ao gerar extrato: " & ex.Message)
        End Try
    End Sub

    ' Classe auxiliar interna para facilitar a manipulação dos dados
    Private Class ItemFinanceiro
        Public Property Data As Date
        Public Property Descricao As String
        Public Property Tipo As String
        Public Property Entrada As Double
        Public Property Saida As Double
    End Class


    Private Sub frm_consulta_vendas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_menu.Show()
    End Sub
End Class