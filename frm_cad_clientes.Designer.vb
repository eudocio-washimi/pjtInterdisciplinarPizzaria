<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cad_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cad_clientes))
        txt_nome = New TextBox()
        Label1 = New Label()
        txt_fone = New MaskedTextBox()
        Label2 = New Label()
        Label3 = New Label()
        txt_endereco = New TextBox()
        Label4 = New Label()
        txt_bairro = New TextBox()
        Label5 = New Label()
        txt_taxa = New MaskedTextBox()
        btn_gravar = New Button()
        dgv_clientes = New DataGridView()
        CType(dgv_clientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_nome
        ' 
        txt_nome.Location = New Point(155, 76)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(217, 23)
        txt_nome.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label1.Location = New Point(26, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 19)
        Label1.TabIndex = 3
        Label1.Text = "Telefone"
        ' 
        ' txt_fone
        ' 
        txt_fone.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_fone.Location = New Point(26, 76)
        txt_fone.Mask = "(99) 00000-0000"
        txt_fone.Name = "txt_fone"
        txt_fone.Size = New Size(100, 25)
        txt_fone.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label2.Location = New Point(155, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 19)
        Label2.TabIndex = 6
        Label2.Text = "Nome do Cliente"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label3.Location = New Point(26, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 19)
        Label3.TabIndex = 8
        Label3.Text = "Logradouro"
        ' 
        ' txt_endereco
        ' 
        txt_endereco.Location = New Point(26, 139)
        txt_endereco.Name = "txt_endereco"
        txt_endereco.Size = New Size(346, 23)
        txt_endereco.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label4.Location = New Point(26, 184)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 19)
        Label4.TabIndex = 10
        Label4.Text = "Bairro"
        ' 
        ' txt_bairro
        ' 
        txt_bairro.Location = New Point(26, 205)
        txt_bairro.Name = "txt_bairro"
        txt_bairro.Size = New Size(141, 23)
        txt_bairro.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label5.Location = New Point(183, 184)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 19)
        Label5.TabIndex = 12
        Label5.Text = "Taxa"
        ' 
        ' txt_taxa
        ' 
        txt_taxa.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_taxa.Location = New Point(183, 205)
        txt_taxa.Mask = "$ 99,00"
        txt_taxa.Name = "txt_taxa"
        txt_taxa.Size = New Size(109, 25)
        txt_taxa.TabIndex = 13
        ' 
        ' btn_gravar
        ' 
        btn_gravar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_gravar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_gravar.Location = New Point(141, 267)
        btn_gravar.Name = "btn_gravar"
        btn_gravar.Size = New Size(105, 68)
        btn_gravar.TabIndex = 14
        btn_gravar.Text = "Gravar"
        btn_gravar.UseVisualStyleBackColor = False
        ' 
        ' dgv_clientes
        ' 
        dgv_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_clientes.Location = New Point(12, 352)
        dgv_clientes.Name = "dgv_clientes"
        dgv_clientes.Size = New Size(372, 193)
        dgv_clientes.TabIndex = 16
        ' 
        ' frm_cad_clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(397, 557)
        Controls.Add(dgv_clientes)
        Controls.Add(btn_gravar)
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
        Name = "frm_cad_clientes"
        Text = "Cadastro de Clientes"
        CType(dgv_clientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_fone As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_taxa As MaskedTextBox
    Friend WithEvents btn_gravar As Button
    Friend WithEvents dgv_clientes As DataGridView
End Class
