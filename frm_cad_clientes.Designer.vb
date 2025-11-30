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
        dgv_clientes = New DataGridView()
        fone = New DataGridViewTextBoxColumn()
        nome = New DataGridViewTextBoxColumn()
        endereco = New DataGridViewTextBoxColumn()
        bairro = New DataGridViewTextBoxColumn()
        taxa = New DataGridViewTextBoxColumn()
        btn_editar = New DataGridViewImageColumn()
        btn_excluir = New DataGridViewImageColumn()
        txt_taxa = New TextBox()
        btn_gravar = New Button()
        Label5 = New Label()
        Label4 = New Label()
        txt_bairro = New TextBox()
        Label3 = New Label()
        txt_endereco = New TextBox()
        Label2 = New Label()
        txt_fone = New MaskedTextBox()
        txt_nome = New TextBox()
        Label1 = New Label()
        CType(dgv_clientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_clientes
        ' 
        dgv_clientes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_clientes.Columns.AddRange(New DataGridViewColumn() {fone, nome, endereco, bairro, taxa, btn_editar, btn_excluir})
        dgv_clientes.Location = New Point(398, 12)
        dgv_clientes.Name = "dgv_clientes"
        dgv_clientes.ScrollBars = ScrollBars.None
        dgv_clientes.Size = New Size(606, 517)
        dgv_clientes.TabIndex = 15
        ' 
        ' fone
        ' 
        fone.HeaderText = "Telefone"
        fone.Name = "fone"
        ' 
        ' nome
        ' 
        nome.HeaderText = "Nome"
        nome.Name = "nome"
        ' 
        ' endereco
        ' 
        endereco.HeaderText = "Endereço"
        endereco.Name = "endereco"
        ' 
        ' bairro
        ' 
        bairro.HeaderText = "Bairro"
        bairro.Name = "bairro"
        ' 
        ' taxa
        ' 
        taxa.HeaderText = "Taxa"
        taxa.Name = "taxa"
        ' 
        ' btn_editar
        ' 
        btn_editar.HeaderText = "Editar"
        btn_editar.Image = My.Resources.Resources.editar
        btn_editar.Name = "btn_editar"
        btn_editar.Resizable = DataGridViewTriState.True
        btn_editar.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' btn_excluir
        ' 
        btn_excluir.HeaderText = "Excluir"
        btn_excluir.Image = My.Resources.Resources.deletar
        btn_excluir.Name = "btn_excluir"
        ' 
        ' txt_taxa
        ' 
        txt_taxa.Anchor = AnchorStyles.Left
        txt_taxa.Location = New Point(181, 295)
        txt_taxa.Name = "txt_taxa"
        txt_taxa.Size = New Size(109, 23)
        txt_taxa.TabIndex = 38
        ' 
        ' btn_gravar
        ' 
        btn_gravar.Anchor = AnchorStyles.Left
        btn_gravar.BackColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        btn_gravar.FlatStyle = FlatStyle.Flat
        btn_gravar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_gravar.Location = New Point(132, 342)
        btn_gravar.Name = "btn_gravar"
        btn_gravar.Size = New Size(105, 68)
        btn_gravar.TabIndex = 37
        btn_gravar.Text = "Gravar"
        btn_gravar.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Left
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label5.Location = New Point(181, 274)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 19)
        Label5.TabIndex = 36
        Label5.Text = "Taxa"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label4.Location = New Point(24, 274)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 19)
        Label4.TabIndex = 35
        Label4.Text = "Bairro"
        ' 
        ' txt_bairro
        ' 
        txt_bairro.Anchor = AnchorStyles.Left
        txt_bairro.Location = New Point(24, 295)
        txt_bairro.Name = "txt_bairro"
        txt_bairro.Size = New Size(141, 23)
        txt_bairro.TabIndex = 34
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label3.Location = New Point(24, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 19)
        Label3.TabIndex = 33
        Label3.Text = "Endereço"
        ' 
        ' txt_endereco
        ' 
        txt_endereco.Anchor = AnchorStyles.Left
        txt_endereco.Location = New Point(24, 229)
        txt_endereco.Name = "txt_endereco"
        txt_endereco.Size = New Size(346, 23)
        txt_endereco.TabIndex = 32
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label2.Location = New Point(153, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 19)
        Label2.TabIndex = 31
        Label2.Text = "Nome do Cliente"
        ' 
        ' txt_fone
        ' 
        txt_fone.Anchor = AnchorStyles.Left
        txt_fone.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_fone.Location = New Point(24, 166)
        txt_fone.Mask = "(99) 00000-0000"
        txt_fone.Name = "txt_fone"
        txt_fone.Size = New Size(100, 25)
        txt_fone.TabIndex = 30
        ' 
        ' txt_nome
        ' 
        txt_nome.Anchor = AnchorStyles.Left
        txt_nome.Location = New Point(153, 166)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(217, 23)
        txt_nome.TabIndex = 29
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label1.Location = New Point(24, 147)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 19)
        Label1.TabIndex = 28
        Label1.Text = "Telefone"
        ' 
        ' frm_cad_clientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(95), CByte(99), CByte(104))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1016, 541)
        Controls.Add(txt_taxa)
        Controls.Add(btn_gravar)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txt_bairro)
        Controls.Add(Label3)
        Controls.Add(txt_endereco)
        Controls.Add(Label2)
        Controls.Add(txt_fone)
        Controls.Add(txt_nome)
        Controls.Add(Label1)
        Controls.Add(dgv_clientes)
        Name = "frm_cad_clientes"
        Text = "Cadastro de Clientes"
        WindowState = FormWindowState.Maximized
        CType(dgv_clientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents fone As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents endereco As DataGridViewTextBoxColumn
    Friend WithEvents bairro As DataGridViewTextBoxColumn
    Friend WithEvents taxa As DataGridViewTextBoxColumn
    Friend WithEvents btn_editar As DataGridViewImageColumn
    Friend WithEvents btn_excluir As DataGridViewImageColumn
    Friend WithEvents txt_taxa As TextBox
    Friend WithEvents btn_gravar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_fone As MaskedTextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label1 As Label
End Class
