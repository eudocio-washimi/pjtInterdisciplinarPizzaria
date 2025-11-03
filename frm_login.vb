Public Class frm_login
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Dim usuario As String = txt_usuario.Text
        Dim senha As String = txt_senha.Text

        Try
            If String.IsNullOrWhiteSpace(usuario) OrElse String.IsNullOrWhiteSpace(senha) Then
                MsgBox("Preencha usuário/e-mail e senha.", MsgBoxStyle.Exclamation) : Exit Sub
            End If
            If db Is Nothing OrElse db.State <> ADODB.ObjectStateEnum.adStateOpen Then
                MsgBox("Conexão não disponível.", MsgBoxStyle.Critical) : Exit Sub
            End If

            sql = $"SELECT * FROM tb_usuarios WHERE usuario = '{usuario}'"
            rs = New ADODB.Recordset
            rs.Open(sql, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            If Not rs.EOF Then
                If rs.Fields("senha").Value.ToString() = senha Then
                    rs.Close()
                    Me.Hide()
                    frm_menu.Show()
                Else
                    MsgBox("Senha inválida!", MsgBoxStyle.Exclamation)
                    rs.Close()
                    txt_senha.Clear()
                    txt_usuario.Focus()
                    txt_usuario.SelectAll()
                End If
            Else
                MsgBox("Usuário não encontrado!", MsgBoxStyle.Exclamation)
                rs.Close()
                txt_senha.Clear()
                txt_usuario.Focus()
                txt_usuario.SelectAll()
            End If

        Catch ex As Exception
            MsgBox("Erro no login: " & ex.Message, MsgBoxStyle.Critical)
            If rs IsNot Nothing AndAlso rs.State = ADODB.ObjectStateEnum.adStateOpen Then rs.Close()
        Finally
            rs = Nothing
        End Try
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_access()
    End Sub
End Class