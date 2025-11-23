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
        PictureBox1 = New PictureBox()
        btn_motoboys = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        btn_lancar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.gatoFelixPizzaiolo
        PictureBox1.Location = New Point(257, 49)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(286, 276)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
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
        ' frm_menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(545, 443)
        Controls.Add(btn_lancar)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btn_motoboys)
        Controls.Add(PictureBox1)
        Controls.Add(btn_gravar)
        Name = "frm_menu"
        Text = "menu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_gravar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_motoboys As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btn_lancar As Button
End Class
