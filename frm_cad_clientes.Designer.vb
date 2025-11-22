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
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewImageColumn()
        Column6 = New DataGridViewImageColumn()
        CType(dgv_clientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_nome
        ' 
        txt_nome.Location = New Point(175, 150)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(217, 23)
        txt_nome.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label1.Location = New Point(46, 131)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 19)
        Label1.TabIndex = 3
        Label1.Text = "Telefone"
        ' 
        ' txt_fone
        ' 
        txt_fone.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_fone.Location = New Point(46, 150)
        txt_fone.Mask = "(99) 00000-0000"
        txt_fone.Name = "txt_fone"
        txt_fone.Size = New Size(100, 25)
        txt_fone.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label2.Location = New Point(175, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 19)
        Label2.TabIndex = 6
        Label2.Text = "Nome do Cliente"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label3.Location = New Point(46, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 19)
        Label3.TabIndex = 8
        Label3.Text = "Endereço"
        ' 
        ' txt_endereco
        ' 
        txt_endereco.Location = New Point(46, 213)
        txt_endereco.Name = "txt_endereco"
        txt_endereco.Size = New Size(346, 23)
        txt_endereco.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label4.Location = New Point(46, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 19)
        Label4.TabIndex = 10
        Label4.Text = "Bairro"
        ' 
        ' txt_bairro
        ' 
        txt_bairro.Location = New Point(46, 279)
        txt_bairro.Name = "txt_bairro"
        txt_bairro.Size = New Size(141, 23)
        txt_bairro.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label5.Location = New Point(203, 258)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 19)
        Label5.TabIndex = 12
        Label5.Text = "Taxa"
        ' 
        ' txt_taxa
        ' 
        txt_taxa.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_taxa.Location = New Point(203, 279)
        txt_taxa.Mask = "$ 99,00"
        txt_taxa.Name = "txt_taxa"
        txt_taxa.Size = New Size(109, 25)
        txt_taxa.TabIndex = 13
        ' 
        ' btn_gravar
        ' 
        btn_gravar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_gravar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_gravar.Location = New Point(153, 329)
        btn_gravar.Name = "btn_gravar"
        btn_gravar.Size = New Size(105, 68)
        btn_gravar.TabIndex = 14
        btn_gravar.Text = "Gravar"
        btn_gravar.UseVisualStyleBackColor = False
        ' 
        ' dgv_clientes
        ' 
        dgv_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_clientes.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        dgv_clientes.Location = New Point(414, 35)
        dgv_clientes.Name = "dgv_clientes"
        dgv_clientes.RowHeadersWidth = 62
        dgv_clientes.ShowCellErrors = False
        dgv_clientes.Size = New Size(590, 494)
        dgv_clientes.TabIndex = 16
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Telefone"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 77
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nome"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 65
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Endereço"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 81
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Bairro"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 63
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Editar"
        Column5.Image = CType(resources.GetObject("Column5.Image"), Image)
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 43
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Deletar"
        Column6.Image = CType(resources.GetObject("Column6.Image"), Image)
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.Width = 50
        ' 
        ' frm_cad_clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1016, 541)
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
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
End Class
