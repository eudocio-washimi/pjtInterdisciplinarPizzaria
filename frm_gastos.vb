Public Class frm_gastos
    Dim id_editando As String = ""
    Dim isEditing As Boolean = False

    Private Sub frm_gastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarFornecedores()
        CarregarHistorico()
        rdb_variavel.Checked = True
        limpar_campos()
    End Sub

    Private Sub txt_valor_TextChanged(sender As Object, e As EventArgs) Handles txt_valor.TextChanged
        If isEditing Then Exit Sub
        isEditing = True

        Try
            Dim textoLimpo As String = System.Text.RegularExpressions.Regex.Replace(txt_valor.Text, "[^0-9]", "")

            If textoLimpo = "" Then
                txt_valor.Text = "R$ 0,00"
            Else
                Dim valor As Double = CDbl(textoLimpo) / 100
                txt_valor.Text = FormatCurrency(valor)
            End If

            txt_valor.SelectionStart = txt_valor.Text.Length

        Catch ex As Exception
        End Try

        isEditing = False
    End Sub

    Private Sub txt_valor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Sub CarregarFornecedores()
        Try
            rs = db.Execute("SELECT * FROM tb_fornecedores ORDER BY nome")
            cmb_fornecedor.Items.Clear()
            While Not rs.EOF
                cmb_fornecedor.Items.Add(rs.Fields("nome").Value & " | " & rs.Fields("id_fornecedor").Value)
                rs.MoveNext()
            End While
        Catch : End Try
    End Sub

    Sub CarregarHistorico()
        Try
            sql = "SELECT TOP 20 g.id_gasto, g.data_gasto, f.nome, g.descricao, g.valor, g.tipo_custo, g.id_fornecedor " &
                  "FROM tb_gastos g INNER JOIN tb_fornecedores f ON g.id_fornecedor = f.id_fornecedor " &
                  "ORDER BY g.data_gasto DESC"

            rs = db.Execute(sql)
            dgv_historico.Rows.Clear()

            While Not rs.EOF
                dgv_historico.Rows.Add(
                    rs.Fields("id_gasto").Value,
                    rs.Fields("data_gasto").Value,
                    rs.Fields("nome").Value,
                    rs.Fields("descricao").Value,
                    FormatCurrency(rs.Fields("valor").Value),
                    rs.Fields("tipo_custo").Value,
                    rs.Fields("id_fornecedor").Value
                )
                rs.MoveNext()
            End While
        Catch ex As Exception
        End Try
    End Sub

    Sub limpar_campos()
        txt_descricao.Clear()
        txt_valor.Text = "R$ 0,00"
        cmb_fornecedor.SelectedIndex = -1
        dtp_data.Value = Date.Now
        rdb_variavel.Checked = True
        id_editando = ""
        btn_lancar.Text = "Lançar Despesa"
    End Sub

    Function TextoParaValor(texto As String) As Double
        If String.IsNullOrWhiteSpace(texto) Then Return 0
        Dim limpo As String = texto.Replace("R$", "").Replace(" ", "").Trim()
        Try
            Return CDbl(limpo)
        Catch
            limpo = limpo.Replace(".", "").Replace(",", ".")
            Return Val(limpo)
        End Try
    End Function

    Private Sub btn_lancar_Click(sender As Object, e As EventArgs) Handles btn_lancar.Click
        If cmb_fornecedor.SelectedIndex = -1 Or txt_valor.Text = "" Or txt_valor.Text = "R$ 0,00" Then
            MsgBox("Selecione o fornecedor e o valor!")
            Exit Sub
        End If

        Try
            Dim id_fornecedor As Integer = Split(cmb_fornecedor.Text, " | ")(1)
            Dim tipo As String = If(rdb_fixo.Checked, "Fixo", "Variável")
            Dim valDouble As Double = TextoParaValor(txt_valor.Text)
            Dim valStr As String = valDouble.ToString("0.00").Replace(",", ".")

            Dim data As String = dtp_data.Value.ToString("yyyy-MM-dd HH:mm:ss")

            If id_editando = "" Then
                sql = $"INSERT INTO tb_gastos (descricao, valor, data_gasto, tipo_custo, id_fornecedor) " &
                      $"VALUES ('{txt_descricao.Text}', {valStr}, '{data}', '{tipo}', {id_fornecedor})"
                db.Execute(sql)
                MsgBox("Despesa lançada com sucesso!")
            Else
                sql = $"UPDATE tb_gastos SET descricao='{txt_descricao.Text}', valor={valStr}, data_gasto='{data}', " &
                      $"tipo_custo='{tipo}', id_fornecedor={id_fornecedor} WHERE id_gasto={id_editando}"
                db.Execute(sql)
                MsgBox("Despesa atualizada!")
            End If

            limpar_campos()
            CarregarHistorico()

        Catch ex As Exception
            MsgBox("Erro ao salvar: " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_historico_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_historico.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim id_gasto As String = dgv_historico.Rows(e.RowIndex).Cells("id").Value.ToString()

        If dgv_historico.Columns(e.ColumnIndex).Name = "btn_editar" Then
            txt_descricao.Text = dgv_historico.Rows(e.RowIndex).Cells("desc").Value.ToString()

            Dim valStr As String = dgv_historico.Rows(e.RowIndex).Cells("valor").Value.ToString()
            txt_valor.Text = valStr

            dtp_data.Value = CDate(dgv_historico.Rows(e.RowIndex).Cells("data").Value)

            Dim tipo As String = dgv_historico.Rows(e.RowIndex).Cells("tipo").Value.ToString()
            If tipo = "Fixo" Then rdb_fixo.Checked = True Else rdb_variavel.Checked = True

            Dim id_forn_alvo As String = dgv_historico.Rows(e.RowIndex).Cells("id_forn").Value.ToString()
            For i As Integer = 0 To cmb_fornecedor.Items.Count - 1
                Dim itemTexto As String = cmb_fornecedor.Items(i).ToString()
                If itemTexto.EndsWith(" | " & id_forn_alvo) Then
                    cmb_fornecedor.SelectedIndex = i
                    Exit For
                End If
            Next

            id_editando = id_gasto
            btn_lancar.Text = "Salvar Alterações"
        End If

        If dgv_historico.Columns(e.ColumnIndex).Name = "btn_excluir" Then
            If MsgBox($"Apagar lançamento #{id_gasto}?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = MsgBoxResult.Yes Then
                Try
                    db.Execute($"DELETE FROM tb_gastos WHERE id_gasto={id_gasto}")
                    CarregarHistorico()
                    limpar_campos()
                Catch ex As Exception
                    MsgBox("Erro ao excluir: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub frm_gastos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_menu.Show()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        limpar_campos()
    End Sub
End Class