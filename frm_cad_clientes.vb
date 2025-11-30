Public Class frm_cad_clientes
    Dim isEditing As Boolean = False

    Private Sub frm_cad_clientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        carregar_dados()

        dgv_clientes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btn_gravar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
    End Sub

    Private Sub txt_taxa_TextChanged(sender As Object, e As EventArgs) Handles txt_taxa.TextChanged
        If isEditing Then Exit Sub
        isEditing = True
        Try
            Dim textoLimpo As String = System.Text.RegularExpressions.Regex.Replace(txt_taxa.Text, "[^0-9]", "")
            If textoLimpo = "" Then
                txt_taxa.Text = "R$ 0,00"
            Else
                Dim valor As Double = CDbl(textoLimpo) / 100
                txt_taxa.Text = FormatCurrency(valor)
            End If
            txt_taxa.SelectionStart = txt_taxa.Text.Length
        Catch ex As Exception
        End Try
        isEditing = False
    End Sub

    Private Sub txt_taxa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_taxa.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        If txt_fone.Text = "" Or txt_nome.Text = "" Then
            MsgBox("Preencha telefone e nome!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Try
            Dim taxaVal As Double = 0
            Dim textoLimpo As String = txt_taxa.Text.Replace("R$", "").Replace(" ", "").Trim()
            Try : taxaVal = CDbl(textoLimpo) : Catch : End Try
            Dim taxaSQL As String = taxaVal.ToString("0.00").Replace(",", ".")

            sql = $"SELECT * from tb_clientes where fone ='{txt_fone.Text}'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                sql = $"UPDATE tb_clientes SET nome='{txt_nome.Text}', endereco='{txt_endereco.Text}', bairro='{txt_bairro.Text}', taxa={taxaSQL} WHERE fone='{txt_fone.Text}'"
                db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information)
            Else
                sql = $"INSERT INTO tb_clientes (fone, nome, endereco, bairro, taxa) VALUES ('{txt_fone.Text}', '{txt_nome.Text}', '{txt_endereco.Text}', '{txt_bairro.Text}', {taxaSQL})"
                db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information)
            End If

            txt_fone.Clear()
            txt_nome.Clear()
            txt_endereco.Clear()
            txt_bairro.Clear()
            txt_taxa.Text = "R$ 0,00"
            txt_fone.Focus()
            carregar_dados()
        Catch ex As Exception
            MsgBox("Erro ao gravar: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub carregar_dados()
        Try
            dgv_clientes.Rows.Clear()
            sql = "SELECT * FROM tb_clientes ORDER BY nome ASC"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                Dim taxaExibir As String = "R$ 0,00"
                If Not IsDBNull(rs.Fields("taxa").Value) Then
                    taxaExibir = FormatCurrency(rs.Fields("taxa").Value)
                End If
                dgv_clientes.Rows.Add(rs.Fields("fone").Value, rs.Fields("nome").Value, rs.Fields("endereco").Value, rs.Fields("bairro").Value, taxaExibir)
                rs.MoveNext()
            Loop
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgv_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        If dgv_clientes.Columns(e.ColumnIndex).Name = "btn_editar" Then
            txt_fone.Text = dgv_clientes.Rows(e.RowIndex).Cells("fone").Value.ToString()
            txt_nome.Text = dgv_clientes.Rows(e.RowIndex).Cells("nome").Value.ToString()
            txt_endereco.Text = dgv_clientes.Rows(e.RowIndex).Cells("endereco").Value.ToString()
            txt_bairro.Text = dgv_clientes.Rows(e.RowIndex).Cells("bairro").Value.ToString()
            txt_taxa.Text = dgv_clientes.Rows(e.RowIndex).Cells("taxa").Value.ToString()
        End If
        If dgv_clientes.Columns(e.ColumnIndex).Name = "btn_excluir" Then
            If MsgBox("Excluir cliente?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = MsgBoxResult.Yes Then
                Dim fone As String = dgv_clientes.Rows(e.RowIndex).Cells("fone").Value.ToString()
                db.Execute($"DELETE FROM tb_clientes WHERE fone='{fone}'")
                carregar_dados()
            End If
        End If
    End Sub

End Class