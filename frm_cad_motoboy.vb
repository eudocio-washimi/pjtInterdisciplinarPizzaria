Public Class frm_cad_motoboy
    Private Sub frm_cad_motoboy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_motoboys()
    End Sub


    Sub carregar_motoboys()
        Try
            sql = "SELECT * FROM tb_motoboys ORDER BY nome"
            rs = db.Execute(sql)
            dgv_motoboys.Rows.Clear()
            Do While Not rs.EOF
                dgv_motoboys.Rows.Add(rs.Fields("id_motoboy").Value, rs.Fields("nome").Value, rs.Fields("telefone").Value, rs.Fields("pix").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Erro ao listar: " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_motoboys_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_motoboys.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim id As String = dgv_motoboys.Rows(e.RowIndex).Cells("id").Value.ToString()

        If dgv_motoboys.Columns(e.ColumnIndex).Name = "btn_editar" Then
            txt_nome.Text = dgv_motoboys.Rows(e.RowIndex).Cells("nome").Value.ToString()
            txt_telefone.Text = dgv_motoboys.Rows(e.RowIndex).Cells("telefone").Value.ToString()
            txt_pix.Text = dgv_motoboys.Rows(e.RowIndex).Cells("pix").Value.ToString()
            Tag = id
        End If

        If dgv_motoboys.Columns(e.ColumnIndex).Name = "btn_excluir" Then
            If MsgBox("Tem certeza que deseja excluir?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = MsgBoxResult.Yes Then
                db.Execute($"DELETE FROM tb_motoboys WHERE id_motoboy = {id}")
                carregar_motoboys()
                MsgBox("Excluído!")
            End If
        End If
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            If Tag Is Nothing OrElse Tag.ToString() = "" Then
                sql = $"INSERT INTO tb_motoboys (nome, telefone, pix) VALUES ('{txt_nome.Text}', '{txt_telefone.Text}', '{txt_pix.Text}')"
            Else
                sql = $"UPDATE tb_motoboys SET nome='{txt_nome.Text}', telefone='{txt_telefone.Text}', pix='{txt_pix.Text}' WHERE id_motoboy={Tag}"
                Tag = "" 
            End If

            db.Execute(sql)
            MsgBox("Salvo com sucesso!")
            txt_nome.Clear()
            txt_telefone.Clear()
            txt_pix.Clear()
            carregar_motoboys()
        Catch ex As Exception
            MsgBox("Erro ao gravar: " & ex.Message)
        End Try
    End Sub

    Private Sub frm_cad_motoboy_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_menu.Show()
    End Sub
End Class