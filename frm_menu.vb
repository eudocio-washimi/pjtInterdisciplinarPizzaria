Public Class frm_menu
    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        frm_cad_clientes.Show()
        Me.Hide()
    End Sub

End Class