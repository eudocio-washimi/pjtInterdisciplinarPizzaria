<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cad_fornecedores
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
        Label2 = New Label()
        txt_nome = New TextBox()
        Label5 = New Label()
        cmb_tipo = New ComboBox()
        btn_salvar = New Button()
        dgv_fornecedores = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        nome = New DataGridViewTextBoxColumn()
        tipo = New DataGridViewTextBoxColumn()
        btn_editar = New DataGridViewImageColumn()
        btn_excluir = New DataGridViewImageColumn()
        CType(dgv_fornecedores, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label2.Location = New Point(75, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 19)
        Label2.TabIndex = 19
        Label2.Text = "Nome do Fornecedor"
        ' 
        ' txt_nome
        ' 
        txt_nome.Location = New Point(75, 39)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(340, 23)
        txt_nome.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label5.Location = New Point(75, 74)
        Label5.Name = "Label5"
        Label5.Size = New Size(159, 19)
        Label5.TabIndex = 31
        Label5.Text = "Tipo de Fornecedor"
        ' 
        ' cmb_tipo
        ' 
        cmb_tipo.FormattingEnabled = True
        cmb_tipo.Items.AddRange(New Object() {"Mercado", "Serviço Público", "Funcionário", "Manutenção", "Outros"})
        cmb_tipo.Location = New Point(76, 93)
        cmb_tipo.Name = "cmb_tipo"
        cmb_tipo.Size = New Size(158, 23)
        cmb_tipo.TabIndex = 30
        ' 
        ' btn_salvar
        ' 
        btn_salvar.BackColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        btn_salvar.FlatStyle = FlatStyle.Flat
        btn_salvar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_salvar.Location = New Point(256, 68)
        btn_salvar.Name = "btn_salvar"
        btn_salvar.Size = New Size(109, 68)
        btn_salvar.TabIndex = 43
        btn_salvar.Text = "Salvar"
        btn_salvar.UseVisualStyleBackColor = False
        ' 
        ' dgv_fornecedores
        ' 
        dgv_fornecedores.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv_fornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_fornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_fornecedores.Columns.AddRange(New DataGridViewColumn() {id, nome, tipo, btn_editar, btn_excluir})
        dgv_fornecedores.Location = New Point(12, 151)
        dgv_fornecedores.Name = "dgv_fornecedores"
        dgv_fornecedores.RowHeadersWidth = 62
        dgv_fornecedores.Size = New Size(469, 287)
        dgv_fornecedores.TabIndex = 44
        ' 
        ' id
        ' 
        id.HeaderText = "ID"
        id.Name = "id"
        ' 
        ' nome
        ' 
        nome.HeaderText = "Nome"
        nome.Name = "nome"
        ' 
        ' tipo
        ' 
        tipo.HeaderText = "Tipo"
        tipo.Name = "tipo"
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
        btn_excluir.Resizable = DataGridViewTriState.True
        btn_excluir.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' frm_cad_fornecedores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(95), CByte(99), CByte(104))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(493, 450)
        Controls.Add(dgv_fornecedores)
        Controls.Add(btn_salvar)
        Controls.Add(Label5)
        Controls.Add(cmb_tipo)
        Controls.Add(Label2)
        Controls.Add(txt_nome)
        Name = "frm_cad_fornecedores"
        Text = "frm_cad_fornecedores"
        CType(dgv_fornecedores, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents btn_salvar As Button
    Friend WithEvents dgv_fornecedores As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents btn_editar As DataGridViewImageColumn
    Friend WithEvents btn_excluir As DataGridViewImageColumn
End Class
