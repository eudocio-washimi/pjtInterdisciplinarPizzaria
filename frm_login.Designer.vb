<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Label1 = New Label()
        Label2 = New Label()
        txt_usuario = New TextBox()
        txt_senha = New TextBox()
        PictureBox1 = New PictureBox()
        btn_entrar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 18F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(120, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 29)
        Label1.TabIndex = 0
        Label1.Text = "Usuário"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 18F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(126, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 29)
        Label2.TabIndex = 1
        Label2.Text = "Senha"
        ' 
        ' txt_usuario
        ' 
        txt_usuario.Location = New Point(59, 104)
        txt_usuario.Name = "txt_usuario"
        txt_usuario.Size = New Size(217, 23)
        txt_usuario.TabIndex = 2
        ' 
        ' txt_senha
        ' 
        txt_senha.Location = New Point(58, 190)
        txt_senha.Name = "txt_senha"
        txt_senha.Size = New Size(217, 23)
        txt_senha.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.gatoFelixPizzaiolo
        PictureBox1.Location = New Point(282, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(246, 260)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' btn_entrar
        ' 
        btn_entrar.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btn_entrar.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_entrar.Location = New Point(110, 248)
        btn_entrar.Name = "btn_entrar"
        btn_entrar.Size = New Size(106, 38)
        btn_entrar.TabIndex = 5
        btn_entrar.Text = "ENTRAR"
        btn_entrar.UseVisualStyleBackColor = False
        ' 
        ' frm_login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        ClientSize = New Size(574, 327)
        Controls.Add(btn_entrar)
        Controls.Add(txt_senha)
        Controls.Add(txt_usuario)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "frm_login"
        Text = "LOGIN"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_entrar As Button
End Class
