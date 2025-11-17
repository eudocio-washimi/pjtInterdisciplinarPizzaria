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
        Label4 = New Label()
        txt_bairro = New TextBox()
        Label3 = New Label()
        txt_endereco = New TextBox()
        Label2 = New Label()
        txt_fone = New MaskedTextBox()
        txt_nome = New TextBox()
        Label1 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        MaskedTextBox1 = New MaskedTextBox()
        ComboBox1 = New ComboBox()
        Label5 = New Label()
        Label8 = New Label()
        ComboBox2 = New ComboBox()
        Label9 = New Label()
        TextBox1 = New TextBox()
        Label10 = New Label()
        ComboBox3 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label4.Location = New Point(489, 245)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 29)
        Label4.TabIndex = 21
        Label4.Text = "Bairro"
        ' 
        ' txt_bairro
        ' 
        txt_bairro.Location = New Point(489, 277)
        txt_bairro.Margin = New Padding(4, 5, 4, 5)
        txt_bairro.Name = "txt_bairro"
        txt_bairro.Size = New Size(200, 31)
        txt_bairro.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label3.Location = New Point(31, 242)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 29)
        Label3.TabIndex = 19
        Label3.Text = "Logradouro"
        ' 
        ' txt_endereco
        ' 
        txt_endereco.Location = New Point(31, 277)
        txt_endereco.Margin = New Padding(4, 5, 4, 5)
        txt_endereco.Name = "txt_endereco"
        txt_endereco.Size = New Size(434, 31)
        txt_endereco.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label2.Location = New Point(31, 135)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(203, 29)
        Label2.TabIndex = 17
        Label2.Text = "Nome do Cliente"
        ' 
        ' txt_fone
        ' 
        txt_fone.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_fone.Location = New Point(31, 65)
        txt_fone.Margin = New Padding(4, 5, 4, 5)
        txt_fone.Mask = "(99) 00000-0000"
        txt_fone.Name = "txt_fone"
        txt_fone.Size = New Size(141, 33)
        txt_fone.TabIndex = 16
        ' 
        ' txt_nome
        ' 
        txt_nome.Location = New Point(31, 167)
        txt_nome.Margin = New Padding(4, 5, 4, 5)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(434, 31)
        txt_nome.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label1.Location = New Point(31, 33)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 29)
        Label1.TabIndex = 14
        Label1.Text = "Telefone"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label6.Location = New Point(31, 343)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 29)
        Label6.TabIndex = 24
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label7.Location = New Point(489, 135)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 29)
        Label7.TabIndex = 22
        Label7.Text = "Taxa"
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaskedTextBox1.Location = New Point(489, 166)
        MaskedTextBox1.Margin = New Padding(4, 5, 4, 5)
        MaskedTextBox1.Mask = "$ 99,00"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(154, 33)
        MaskedTextBox1.TabIndex = 23
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(176, 375)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(203, 33)
        ComboBox1.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label5.Location = New Point(176, 343)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(167, 29)
        Label5.TabIndex = 26
        Label5.Text = "Tipo da Pizza"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label8.Location = New Point(386, 343)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(123, 29)
        Label8.TabIndex = 28
        Label8.Text = "Categoria"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(386, 375)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(203, 33)
        ComboBox2.TabIndex = 27
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label9.Location = New Point(31, 345)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 29)
        Label9.TabIndex = 30
        Label9.Text = "Qntd"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(31, 377)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(138, 31)
        TextBox1.TabIndex = 29
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label10.Location = New Point(31, 431)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(167, 29)
        Label10.TabIndex = 32
        Label10.Text = "Tipo da Pizza"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(31, 463)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(439, 33)
        ComboBox3.TabIndex = 31
        ' 
        ' frm_pedidos
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(746, 632)
        Controls.Add(Label10)
        Controls.Add(ComboBox3)
        Controls.Add(Label9)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(ComboBox2)
        Controls.Add(Label5)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(MaskedTextBox1)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(txt_bairro)
        Controls.Add(Label3)
        Controls.Add(txt_endereco)
        Controls.Add(Label2)
        Controls.Add(txt_fone)
        Controls.Add(txt_nome)
        Controls.Add(Label1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "frm_pedidos"
        Text = "Pedidos"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_fone As MaskedTextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox3 As ComboBox
End Class
