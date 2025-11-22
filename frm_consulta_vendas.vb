Public Class frm_consulta_vendas
    Private Sub frm_consulta_vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrid()
        ' Define as datas para pegar o mês atual inteiro automaticamente
        Dim hoje As Date = Date.Now
        dtp_inicio.Value = New Date(hoje.Year, hoje.Month, 1) ' Dia 1 do mês
        dtp_fim.Value = hoje
    End Sub

    Sub ConfigurarGrid()
        dgv_vendas.Columns.Clear()

        dgv_vendas.Columns.Add("id", "Cód. Venda")
        dgv_vendas.Columns("id").Width = 60

        dgv_vendas.Columns.Add("data", "Data/Hora")
        dgv_vendas.Columns("data").Width = 120

        dgv_vendas.Columns.Add("cliente", "Cliente")
        dgv_vendas.Columns("cliente").Width = 200

        dgv_vendas.Columns.Add("tipo", "Tipo")
        dgv_vendas.Columns("tipo").Width = 80

        dgv_vendas.Columns.Add("total", "Valor")
        dgv_vendas.Columns("total").DefaultCellStyle.Format = "C2" ' Formato Moeda
        dgv_vendas.Columns("total").Width = 90
    End Sub

    Private Sub btn_filtrar_Click(sender As Object, e As EventArgs) Handles btn_filtrar.Click
        CarregarVendas()
    End Sub

    Sub CarregarVendas()
        Try
            ' Formatação de data segura para o Access (#mm/dd/yyyy#)
            Dim d1 As String = dtp_inicio.Value.ToString("MM/dd/yyyy")
            Dim d2 As String = dtp_fim.Value.ToString("MM/dd/yyyy")

            ' SQL AVANÇADO: Traz a venda e o NOME do cliente correspondente
            sql = "SELECT v.id_venda, v.data_venda, c.nome, v.tipo_pedido, v.valor_total " &
                  "FROM tb_vendas as v " &
                  "INNER JOIN tb_clientes as c ON v.id_cliente = c.id_cliente " &
                  $"WHERE v.data_venda BETWEEN #{d1} 00:00:00# AND #{d2} 23:59:59# " &
                  "ORDER BY v.data_venda DESC"

            rs = db.Execute(sql)

            dgv_vendas.Rows.Clear()
            Dim soma_total As Double = 0

            While Not rs.EOF
                dgv_vendas.Rows.Add(
                    rs.Fields("id_venda").Value,
                    rs.Fields("data_venda").Value,
                    rs.Fields("nome").Value,
                    rs.Fields("tipo_pedido").Value,
                    rs.Fields("valor_total").Value
                )

                ' Soma para o totalizador no rodapé
                soma_total += CDbl(rs.Fields("valor_total").Value)
                rs.MoveNext()
            End While

            lbl_total_periodo.Text = "Faturamento do Período: " & FormatCurrency(soma_total)

            If dgv_vendas.Rows.Count = 0 Then
                MsgBox("Nenhuma venda encontrada nestas datas.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Erro ao consultar relatório: " & ex.Message)
        End Try
    End Sub

    Private Sub frm_consulta_vendas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_menu.Show()
    End Sub
End Class