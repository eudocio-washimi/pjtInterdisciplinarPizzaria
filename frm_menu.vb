Public Class frm_menu
    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        frm_cad_clientes.Show()
        Me.Hide()
    End Sub

    Private Sub btn_motoboys_Click(sender As Object, e As EventArgs) Handles btn_motoboys.Click
        frm_cad_motoboy.Show
        Hide
    End Sub

    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar_access()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_cad_produtos.Show
        Hide
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_pedidos.Show
        Hide
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_consulta_vendas.Show()
        Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frm_graficos.Show()
        Hide()
    End Sub
End Class