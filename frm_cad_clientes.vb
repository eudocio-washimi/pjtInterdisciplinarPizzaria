Public Class frm_cad_clientes
    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            sql = $"SELECT * from tb_clientes where fone ='{txt_fone.Text}'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = $"UPDATE tb_clientes set nome='{txt_nome.Text}' where fone='{txt_fone.Text}'"
                db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                Dim taxa As String = txt_taxa.Text.Replace("R$", "").Replace("$", "").Replace("_", "").Trim()
                taxa = taxa.Replace(".", ",")

                sql = $"INSERT INTO tb_clientes (fone, nome, endereco, bairro, taxa) VALUES 
                        ('{txt_fone.Text}', '{txt_nome.Text}', '{txt_endereco.Text}', '{txt_bairro.Text}', '{taxa}')"
                db.Execute(UCase(sql))

                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
            txt_fone.Clear()
            txt_nome.Clear()
            txt_endereco.Clear()
            txt_bairro.Clear()
            txt_taxa.Clear()
            txt_fone.Focus()

        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO!")

        End Try
    End Sub

    Private Sub frm_cad_clientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_access()
    End Sub
End Class