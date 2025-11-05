<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pedidos
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
        txt_taxa = New MaskedTextBox()
        Label5 = New Label()
        Label4 = New Label()
        txt_bairro = New TextBox()
        Label3 = New Label()
        txt_endereco = New TextBox()
        Label2 = New Label()
        txt_fone = New MaskedTextBox()
        txt_nome = New TextBox()
        Label1 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' txt_taxa
        ' 
        txt_taxa.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_taxa.Location = New Point(342, 227)
        txt_taxa.Mask = "$ 99,00"
        txt_taxa.Name = "txt_taxa"
        txt_taxa.Size = New Size(109, 25)
        txt_taxa.TabIndex = 23
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label5.Location = New Point(342, 206)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 19)
        Label5.TabIndex = 22
        Label5.Text = "Taxa"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label4.Location = New Point(342, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 19)
        Label4.TabIndex = 21
        Label4.Text = "Bairro"
        ' 
        ' txt_bairro
        ' 
        txt_bairro.Location = New Point(342, 166)
        txt_bairro.Name = "txt_bairro"
        txt_bairro.Size = New Size(141, 23)
        txt_bairro.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label3.Location = New Point(22, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 19)
        Label3.TabIndex = 19
        Label3.Text = "Logradouro"
        ' 
        ' txt_endereco
        ' 
        txt_endereco.Location = New Point(22, 166)
        txt_endereco.Name = "txt_endereco"
        txt_endereco.Size = New Size(305, 23)
        txt_endereco.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label2.Location = New Point(22, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 19)
        Label2.TabIndex = 17
        Label2.Text = "Nome do Cliente"
        ' 
        ' txt_fone
        ' 
        txt_fone.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_fone.Location = New Point(22, 39)
        txt_fone.Mask = "(99) 00000-0000"
        txt_fone.Name = "txt_fone"
        txt_fone.Size = New Size(100, 25)
        txt_fone.TabIndex = 16
        ' 
        ' txt_nome
        ' 
        txt_nome.Location = New Point(22, 100)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(305, 23)
        txt_nome.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label1.Location = New Point(22, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 19)
        Label1.TabIndex = 14
        Label1.Text = "Telefone"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label6.Location = New Point(22, 206)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 19)
        Label6.TabIndex = 24
        Label6.Text = "Logradouro"
        ' 
        ' frm_pedidos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background
        ClientSize = New Size(544, 348)
        Controls.Add(Label6)
        Controls.Add(txt_taxa)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txt_bairro)
        Controls.Add(Label3)
        Controls.Add(txt_endereco)
        Controls.Add(Label2)
        Controls.Add(txt_fone)
        Controls.Add(txt_nome)
        Controls.Add(Label1)
        Name = "frm_pedidos"
        Text = "Pedidos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_taxa As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_fone As MaskedTextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
