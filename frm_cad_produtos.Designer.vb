<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cad_produtos
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
        cmb_tipo_produto = New ComboBox()
        Label3 = New Label()
        txt_nome_prod = New TextBox()
        Label4 = New Label()
        btn_salvar_prod = New Button()
        txt_preco_prod = New MaskedTextBox()
        dgv_produtos = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        nome = New DataGridViewTextBoxColumn()
        preco = New DataGridViewTextBoxColumn()
        btn_editar = New DataGridViewImageColumn()
        btn_excluir = New DataGridViewImageColumn()
        txt_id_produto = New TextBox()
        CType(dgv_produtos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label2.Location = New Point(67, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 19)
        Label2.TabIndex = 21
        Label2.Text = "Tipo do Produto"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cmb_tipo_produto
        ' 
        cmb_tipo_produto.Anchor = AnchorStyles.Left
        cmb_tipo_produto.FormattingEnabled = True
        cmb_tipo_produto.Items.AddRange(New Object() {"Pizza", "Catito", "Bebida"})
        cmb_tipo_produto.Location = New Point(22, 108)
        cmb_tipo_produto.Name = "cmb_tipo_produto"
        cmb_tipo_produto.Size = New Size(233, 23)
        cmb_tipo_produto.TabIndex = 22
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label3.Location = New Point(64, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 19)
        Label3.TabIndex = 23
        Label3.Text = "Nome do Produto"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txt_nome_prod
        ' 
        txt_nome_prod.Anchor = AnchorStyles.Left
        txt_nome_prod.Location = New Point(22, 188)
        txt_nome_prod.Name = "txt_nome_prod"
        txt_nome_prod.Size = New Size(233, 23)
        txt_nome_prod.TabIndex = 24
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label4.Location = New Point(64, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 19)
        Label4.TabIndex = 25
        Label4.Text = "Preço do Produto"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btn_salvar_prod
        ' 
        btn_salvar_prod.Anchor = AnchorStyles.Left
        btn_salvar_prod.BackColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        btn_salvar_prod.FlatStyle = FlatStyle.Flat
        btn_salvar_prod.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_salvar_prod.Location = New Point(81, 324)
        btn_salvar_prod.Name = "btn_salvar_prod"
        btn_salvar_prod.Size = New Size(109, 68)
        btn_salvar_prod.TabIndex = 28
        btn_salvar_prod.Text = "Salvar"
        btn_salvar_prod.UseVisualStyleBackColor = False
        ' 
        ' txt_preco_prod
        ' 
        txt_preco_prod.Anchor = AnchorStyles.Left
        txt_preco_prod.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_preco_prod.Location = New Point(81, 265)
        txt_preco_prod.Mask = "$ 99,00"
        txt_preco_prod.Name = "txt_preco_prod"
        txt_preco_prod.Size = New Size(109, 25)
        txt_preco_prod.TabIndex = 29
        txt_preco_prod.TextAlign = HorizontalAlignment.Center
        ' 
        ' dgv_produtos
        ' 
        dgv_produtos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv_produtos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_produtos.Columns.AddRange(New DataGridViewColumn() {id, nome, preco, btn_editar, btn_excluir})
        dgv_produtos.Location = New Point(276, 27)
        dgv_produtos.Name = "dgv_produtos"
        dgv_produtos.RowHeadersWidth = 62
        dgv_produtos.ShowCellErrors = False
        dgv_produtos.Size = New Size(488, 398)
        dgv_produtos.TabIndex = 30
        ' 
        ' id
        ' 
        id.HeaderText = "Cód"
        id.Name = "id"
        ' 
        ' nome
        ' 
        nome.HeaderText = "Nome do Produto"
        nome.Name = "nome"
        ' 
        ' preco
        ' 
        preco.HeaderText = "Preço"
        preco.Name = "preco"
        ' 
        ' btn_editar
        ' 
        btn_editar.HeaderText = "Editar"
        btn_editar.Image = My.Resources.Resources.editar
        btn_editar.Name = "btn_editar"
        ' 
        ' btn_excluir
        ' 
        btn_excluir.HeaderText = "Excluir"
        btn_excluir.Image = My.Resources.Resources.deletar
        btn_excluir.Name = "btn_excluir"
        ' 
        ' txt_id_produto
        ' 
        txt_id_produto.Anchor = AnchorStyles.Left
        txt_id_produto.Location = New Point(1, 1)
        txt_id_produto.Name = "txt_id_produto"
        txt_id_produto.Size = New Size(79, 23)
        txt_id_produto.TabIndex = 31
        txt_id_produto.Text = "0"
        txt_id_produto.Visible = False
        ' 
        ' frm_cad_produtos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(95), CByte(99), CByte(104))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(794, 450)
        Controls.Add(txt_id_produto)
        Controls.Add(dgv_produtos)
        Controls.Add(txt_preco_prod)
        Controls.Add(btn_salvar_prod)
        Controls.Add(Label4)
        Controls.Add(txt_nome_prod)
        Controls.Add(Label3)
        Controls.Add(cmb_tipo_produto)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frm_cad_produtos"
        Text = "frm_cad_produtos"
        CType(dgv_produtos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_tipo_produto As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nome_prod As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_salvar_prod As Button
    Friend WithEvents txt_preco_prod As MaskedTextBox
    Friend WithEvents dgv_produtos As DataGridView
    Friend WithEvents txt_id_produto As TextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents preco As DataGridViewTextBoxColumn
    Friend WithEvents btn_editar As DataGridViewImageColumn
    Friend WithEvents btn_excluir As DataGridViewImageColumn
End Class
