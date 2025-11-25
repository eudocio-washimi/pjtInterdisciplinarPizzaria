<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        btn_gravar = New Button()
        btn_motoboys = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        btn_lancar = New Button()
        MenuStrip1 = New MenuStrip()
        CADASTRODECLIENTESToolStripMenuItem = New ToolStripMenuItem()
        CADASTRODEMOTOBOYSToolStripMenuItem = New ToolStripMenuItem()
        CADASTRODEPRODUTOSToolStripMenuItem = New ToolStripMenuItem()
        CAToolStripMenuItem = New ToolStripMenuItem()
        btn_agendar = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn_gravar
        ' 
        btn_gravar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_gravar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_gravar.Location = New Point(12, 49)
        btn_gravar.Name = "btn_gravar"
        btn_gravar.Size = New Size(111, 76)
        btn_gravar.TabIndex = 15
        btn_gravar.Text = "Cadastro de Clientes"
        btn_gravar.UseVisualStyleBackColor = False
        ' 
        ' btn_motoboys
        ' 
        btn_motoboys.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_motoboys.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_motoboys.Location = New Point(12, 131)
        btn_motoboys.Name = "btn_motoboys"
        btn_motoboys.Size = New Size(111, 76)
        btn_motoboys.TabIndex = 17
        btn_motoboys.Text = "Cadastro de Motoboys"
        btn_motoboys.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Button1.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(12, 213)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 76)
        Button1.TabIndex = 18
        Button1.Text = "Cadastro de Produtos"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Button2.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(140, 49)
        Button2.Name = "Button2"
        Button2.Size = New Size(111, 76)
        Button2.TabIndex = 19
        Button2.Text = "Pedidos"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Button3.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(140, 131)
        Button3.Name = "Button3"
        Button3.Size = New Size(111, 76)
        Button3.TabIndex = 20
        Button3.Text = "Relatórios/Consultar"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Button4.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(140, 213)
        Button4.Name = "Button4"
        Button4.Size = New Size(111, 76)
        Button4.TabIndex = 21
        Button4.Text = "Gráficos"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Button5.Font = New Font("Arial Black", 9F, FontStyle.Bold)
        Button5.Location = New Point(12, 295)
        Button5.Name = "Button5"
        Button5.Size = New Size(111, 76)
        Button5.TabIndex = 22
        Button5.Text = "Fornecedores"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' btn_lancar
        ' 
        btn_lancar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_lancar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_lancar.Location = New Point(140, 298)
        btn_lancar.Name = "btn_lancar"
        btn_lancar.Size = New Size(109, 73)
        btn_lancar.TabIndex = 47
        btn_lancar.Text = "Lançar Despesa"
        btn_lancar.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {CADASTRODECLIENTESToolStripMenuItem, CADASTRODEMOTOBOYSToolStripMenuItem, CADASTRODEPRODUTOSToolStripMenuItem, CAToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1864, 24)
        MenuStrip1.TabIndex = 48
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CADASTRODECLIENTESToolStripMenuItem
        ' 
        CADASTRODECLIENTESToolStripMenuItem.Name = "CADASTRODECLIENTESToolStripMenuItem"
        CADASTRODECLIENTESToolStripMenuItem.Size = New Size(151, 20)
        CADASTRODECLIENTESToolStripMenuItem.Text = "CADASTRO DE &CLIENTES"
        ' 
        ' CADASTRODEMOTOBOYSToolStripMenuItem
        ' 
        CADASTRODEMOTOBOYSToolStripMenuItem.Name = "CADASTRODEMOTOBOYSToolStripMenuItem"
        CADASTRODEMOTOBOYSToolStripMenuItem.Size = New Size(163, 20)
        CADASTRODEMOTOBOYSToolStripMenuItem.Text = "CADASTRO DE &MOTOBOYS"
        ' 
        ' CADASTRODEPRODUTOSToolStripMenuItem
        ' 
        CADASTRODEPRODUTOSToolStripMenuItem.Name = "CADASTRODEPRODUTOSToolStripMenuItem"
        CADASTRODEPRODUTOSToolStripMenuItem.Size = New Size(160, 20)
        CADASTRODEPRODUTOSToolStripMenuItem.Text = "CADASTRO DE &PRODUTOS"
        ' 
        ' CAToolStripMenuItem
        ' 
        CAToolStripMenuItem.Name = "CAToolStripMenuItem"
        CAToolStripMenuItem.Size = New Size(187, 20)
        CAToolStripMenuItem.Text = "CADASTRO DE FORNECEDORES"
        ' 
        ' btn_agendar
        ' 
        btn_agendar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_agendar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_agendar.Location = New Point(73, 386)
        btn_agendar.Name = "btn_agendar"
        btn_agendar.Size = New Size(109, 68)
        btn_agendar.TabIndex = 51
        btn_agendar.Text = "Agendar"
        btn_agendar.UseVisualStyleBackColor = False
        ' 
        ' frm_menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1864, 891)
        Controls.Add(btn_agendar)
        Controls.Add(btn_lancar)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btn_motoboys)
        Controls.Add(btn_gravar)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "frm_menu"
        Text = "menu"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_gravar As Button
    Friend WithEvents btn_motoboys As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btn_lancar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CADASTRODECLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CADASTRODEMOTOBOYSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CADASTRODEPRODUTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_agendar As Button
End Class
