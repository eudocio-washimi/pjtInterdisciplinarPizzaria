Public Class frm_menu

    Private currentChildForm As Form = Nothing
    Private currentBtn As Button = Nothing
    Private colorOrange As Color = Color.FromArgb(253, 109, 44)
    Private colorDefault As Color = Color.Transparent

    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_access()
        lblTitulo.Text = "Menu Principal"
    End Sub

    Private Sub ActivateButton(senderBtn As Object)
        If senderBtn IsNot Nothing Then
            DisableButton()

            currentBtn = CType(senderBtn, Button)
            currentBtn.BackColor = colorOrange
            currentBtn.ForeColor = Color.Black

        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = colorDefault
            currentBtn.ForeColor = Color.Black
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form, btnSender As Object, titulo As String)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        ActivateButton(btnSender)

        lblTitulo.Text = titulo

        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        childForm.BackColor = panelConteudo.BackColor
        childForm.ForeColor = Color.Black

        panelConteudo.Controls.Add(childForm)
        panelConteudo.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub


    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        OpenChildForm(New frm_pedidos(), sender, "Gerenciar Pedidos")
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        OpenChildForm(New frm_cad_clientes(), sender, "Cadastro de Clientes")
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btn_produtos_Click(sender As Object, e As EventArgs) Handles btn_produtos.Click
        OpenChildForm(New frm_cad_produtos(), sender, "Cardápio de Produtos")
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btn_motoboys_Click(sender As Object, e As EventArgs) Handles btn_motoboys.Click
        OpenChildForm(New frm_cad_motoboy(), sender, "Equipe de Entregas")
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btn_fornecedores_Click(sender As Object, e As EventArgs) Handles btn_fornecedores.Click
        OpenChildForm(New frm_cad_fornecedores(), sender, "Cadastro de Fornecedores")
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btn_gastos_Click(sender As Object, e As EventArgs) Handles btn_gastos.Click
        OpenChildForm(New frm_gastos(), sender, "Controle de Despesas")
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btn_reservas_Click(sender As Object, e As EventArgs) Handles btn_reservas.Click
        OpenChildForm(New frm_reservas(), sender, "Agendamento de Mesas")
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btn_relatorios_Click(sender As Object, e As EventArgs) Handles btn_relatorios.Click
        OpenChildForm(New frm_consulta_vendas(), sender, "Painel Financeiro")
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btn_graficos_Click(sender As Object, e As EventArgs) Handles btn_graficos.Click
        OpenChildForm(New frm_graficos(), sender, "Dashboard de Indicadores")
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub panelConteudo_Paint(sender As Object, e As PaintEventArgs) Handles panelConteudo.Paint

    End Sub
End Class
