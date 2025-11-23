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
        txt_telefone = New MaskedTextBox()
        txt_nome_cliente = New TextBox()
        Label1 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txt_taxa_entrega = New MaskedTextBox()
        rdb_entrega = New RadioButton()
        rdb_retirada = New RadioButton()
        rdb_salao = New RadioButton()
        cmb_motoboy = New ComboBox()
        Label5 = New Label()
        Label8 = New Label()
        cmb_tipo_produto = New ComboBox()
        Label9 = New Label()
        cmb_produtos = New ComboBox()
        Label10 = New Label()
        txt_qtd = New TextBox()
        btn_adicionar = New Button()
        dgv_itens = New DataGridView()
        lbl_subtotal = New Label()
        Label11 = New Label()
        Label12 = New Label()
        lbl_total_final = New Label()
        btn_finalizar = New Button()
        Label13 = New Label()
        cmb_pagamento = New ComboBox()
        CType(dgv_itens, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label4.Location = New Point(339, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 19)
        Label4.TabIndex = 21
        Label4.Text = "Bairro"
        ' 
        ' txt_bairro
        ' 
        txt_bairro.Location = New Point(339, 102)
        txt_bairro.Name = "txt_bairro"
        txt_bairro.Size = New Size(141, 23)
        txt_bairro.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label3.Location = New Point(22, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 19)
        Label3.TabIndex = 19
        Label3.Text = "Endereço"
        ' 
        ' txt_endereco
        ' 
        txt_endereco.Location = New Point(22, 102)
        txt_endereco.Name = "txt_endereco"
        txt_endereco.Size = New Size(305, 23)
        txt_endereco.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label2.Location = New Point(140, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 19)
        Label2.TabIndex = 17
        Label2.Text = "Nome do Cliente"
        ' 
        ' txt_telefone
        ' 
        txt_telefone.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_telefone.Location = New Point(22, 39)
        txt_telefone.Mask = "(99) 00000-0000"
        txt_telefone.Name = "txt_telefone"
        txt_telefone.Size = New Size(100, 25)
        txt_telefone.TabIndex = 16
        ' 
        ' txt_nome_cliente
        ' 
        txt_nome_cliente.Location = New Point(140, 40)
        txt_nome_cliente.Name = "txt_nome_cliente"
        txt_nome_cliente.Size = New Size(340, 23)
        txt_nome_cliente.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
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
        Label6.Size = New Size(0, 19)
        Label6.TabIndex = 24
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label7.Location = New Point(166, 207)
        Label7.Name = "Label7"
        Label7.Size = New Size(45, 19)
        Label7.TabIndex = 22
        Label7.Text = "Taxa"
        ' 
        ' txt_taxa_entrega
        ' 
        txt_taxa_entrega.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_taxa_entrega.Location = New Point(166, 226)
        txt_taxa_entrega.Mask = "$ 99,00"
        txt_taxa_entrega.Name = "txt_taxa_entrega"
        txt_taxa_entrega.Size = New Size(109, 25)
        txt_taxa_entrega.TabIndex = 23
        ' 
        ' rdb_entrega
        ' 
        rdb_entrega.AutoSize = True
        rdb_entrega.BackColor = Color.Transparent
        rdb_entrega.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdb_entrega.Location = New Point(22, 172)
        rdb_entrega.Name = "rdb_entrega"
        rdb_entrega.Size = New Size(82, 22)
        rdb_entrega.TabIndex = 25
        rdb_entrega.TabStop = True
        rdb_entrega.Text = "Entrega"
        rdb_entrega.UseVisualStyleBackColor = False
        ' 
        ' rdb_retirada
        ' 
        rdb_retirada.AutoSize = True
        rdb_retirada.BackColor = Color.Transparent
        rdb_retirada.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdb_retirada.Location = New Point(204, 172)
        rdb_retirada.Name = "rdb_retirada"
        rdb_retirada.Size = New Size(86, 22)
        rdb_retirada.TabIndex = 26
        rdb_retirada.TabStop = True
        rdb_retirada.Text = "Retirada"
        rdb_retirada.UseVisualStyleBackColor = False
        ' 
        ' rdb_salao
        ' 
        rdb_salao.AutoSize = True
        rdb_salao.BackColor = Color.Transparent
        rdb_salao.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdb_salao.Location = New Point(394, 172)
        rdb_salao.Name = "rdb_salao"
        rdb_salao.Size = New Size(65, 22)
        rdb_salao.TabIndex = 27
        rdb_salao.TabStop = True
        rdb_salao.Text = "Salão"
        rdb_salao.UseVisualStyleBackColor = False
        ' 
        ' cmb_motoboy
        ' 
        cmb_motoboy.FormattingEnabled = True
        cmb_motoboy.Location = New Point(22, 226)
        cmb_motoboy.Name = "cmb_motoboy"
        cmb_motoboy.Size = New Size(129, 23)
        cmb_motoboy.TabIndex = 28
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label5.Location = New Point(21, 207)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 19)
        Label5.TabIndex = 29
        Label5.Text = "Motoboy"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label8.Location = New Point(22, 293)
        Label8.Name = "Label8"
        Label8.Size = New Size(133, 19)
        Label8.TabIndex = 31
        Label8.Text = "Tipo do Produto"
        ' 
        ' cmb_tipo_produto
        ' 
        cmb_tipo_produto.FormattingEnabled = True
        cmb_tipo_produto.Location = New Point(23, 312)
        cmb_tipo_produto.Name = "cmb_tipo_produto"
        cmb_tipo_produto.Size = New Size(129, 23)
        cmb_tipo_produto.TabIndex = 30
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label9.Location = New Point(166, 293)
        Label9.Name = "Label9"
        Label9.Size = New Size(71, 19)
        Label9.TabIndex = 33
        Label9.Text = "Produto"
        ' 
        ' cmb_produtos
        ' 
        cmb_produtos.FormattingEnabled = True
        cmb_produtos.Location = New Point(167, 312)
        cmb_produtos.Name = "cmb_produtos"
        cmb_produtos.Size = New Size(313, 23)
        cmb_produtos.TabIndex = 32
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label10.Location = New Point(21, 349)
        Label10.Name = "Label10"
        Label10.Size = New Size(97, 19)
        Label10.TabIndex = 35
        Label10.Text = "Quantidade"
        ' 
        ' txt_qtd
        ' 
        txt_qtd.Location = New Point(21, 368)
        txt_qtd.Name = "txt_qtd"
        txt_qtd.Size = New Size(97, 23)
        txt_qtd.TabIndex = 34
        ' 
        ' btn_adicionar
        ' 
        btn_adicionar.BackColor = Color.Cyan
        btn_adicionar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_adicionar.Location = New Point(21, 413)
        btn_adicionar.Name = "btn_adicionar"
        btn_adicionar.Size = New Size(105, 68)
        btn_adicionar.TabIndex = 36
        btn_adicionar.Text = "Adicionar"
        btn_adicionar.UseVisualStyleBackColor = False
        ' 
        ' dgv_itens
        ' 
        dgv_itens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_itens.Location = New Point(519, 12)
        dgv_itens.Name = "dgv_itens"
        dgv_itens.Size = New Size(639, 494)
        dgv_itens.TabIndex = 37
        ' 
        ' lbl_subtotal
        ' 
        lbl_subtotal.AutoSize = True
        lbl_subtotal.BackColor = Color.Transparent
        lbl_subtotal.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_subtotal.Location = New Point(167, 368)
        lbl_subtotal.Name = "lbl_subtotal"
        lbl_subtotal.Size = New Size(73, 24)
        lbl_subtotal.TabIndex = 38
        lbl_subtotal.Text = "---------"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label11.Location = New Point(166, 349)
        Label11.Name = "Label11"
        Label11.Size = New Size(73, 19)
        Label11.TabIndex = 39
        Label11.Text = "Subtotal"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label12.Location = New Point(286, 349)
        Label12.Name = "Label12"
        Label12.Size = New Size(46, 19)
        Label12.TabIndex = 41
        Label12.Text = "Total"
        ' 
        ' lbl_total_final
        ' 
        lbl_total_final.AutoSize = True
        lbl_total_final.BackColor = Color.Transparent
        lbl_total_final.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_total_final.Location = New Point(287, 368)
        lbl_total_final.Name = "lbl_total_final"
        lbl_total_final.Size = New Size(73, 24)
        lbl_total_final.TabIndex = 40
        lbl_total_final.Text = "---------"
        ' 
        ' btn_finalizar
        ' 
        btn_finalizar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_finalizar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_finalizar.Location = New Point(140, 413)
        btn_finalizar.Name = "btn_finalizar"
        btn_finalizar.Size = New Size(109, 68)
        btn_finalizar.TabIndex = 42
        btn_finalizar.Text = "Finalizar"
        btn_finalizar.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label13.Location = New Point(261, 413)
        Label13.Name = "Label13"
        Label13.Size = New Size(172, 19)
        Label13.TabIndex = 44
        Label13.Text = "Forma de Pagamento"
        ' 
        ' cmb_pagamento
        ' 
        cmb_pagamento.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_pagamento.FormattingEnabled = True
        cmb_pagamento.Location = New Point(262, 432)
        cmb_pagamento.Name = "cmb_pagamento"
        cmb_pagamento.Size = New Size(197, 23)
        cmb_pagamento.TabIndex = 43
        ' 
        ' frm_pedidos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1170, 518)
        Controls.Add(Label13)
        Controls.Add(cmb_pagamento)
        Controls.Add(btn_finalizar)
        Controls.Add(Label12)
        Controls.Add(lbl_total_final)
        Controls.Add(Label11)
        Controls.Add(lbl_subtotal)
        Controls.Add(dgv_itens)
        Controls.Add(btn_adicionar)
        Controls.Add(Label10)
        Controls.Add(txt_qtd)
        Controls.Add(Label9)
        Controls.Add(cmb_produtos)
        Controls.Add(Label8)
        Controls.Add(cmb_tipo_produto)
        Controls.Add(Label5)
        Controls.Add(cmb_motoboy)
        Controls.Add(rdb_salao)
        Controls.Add(rdb_retirada)
        Controls.Add(rdb_entrega)
        Controls.Add(Label6)
        Controls.Add(txt_taxa_entrega)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(txt_bairro)
        Controls.Add(Label3)
        Controls.Add(txt_endereco)
        Controls.Add(Label2)
        Controls.Add(txt_telefone)
        Controls.Add(txt_nome_cliente)
        Controls.Add(Label1)
        Name = "frm_pedidos"
        Text = "Pedidos"
        CType(dgv_itens, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents txt_nome_cliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_taxa_entrega As MaskedTextBox
    Friend WithEvents rdb_entrega As RadioButton
    Friend WithEvents rdb_retirada As RadioButton
    Friend WithEvents rdb_salao As RadioButton
    Friend WithEvents cmb_motoboy As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_tipo_produto As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_produtos As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_qtd As TextBox
    Friend WithEvents btn_adicionar As Button
    Friend WithEvents dgv_itens As DataGridView
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_total_final As Label
    Friend WithEvents btn_finalizar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents cmb_pagamento As ComboBox
End Class
