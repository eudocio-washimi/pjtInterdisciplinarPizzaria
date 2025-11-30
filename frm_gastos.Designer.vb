<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gastos
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
        Label5 = New Label()
        cmb_fornecedor = New ComboBox()
        Label2 = New Label()
        txt_descricao = New TextBox()
        Label7 = New Label()
        Label1 = New Label()
        dtp_data = New DateTimePicker()
        rdb_fixo = New RadioButton()
        rdb_variavel = New RadioButton()
        btn_lancar = New Button()
        dgv_historico = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        data = New DataGridViewTextBoxColumn()
        fornecedor = New DataGridViewTextBoxColumn()
        desc = New DataGridViewTextBoxColumn()
        valor = New DataGridViewTextBoxColumn()
        tipo = New DataGridViewTextBoxColumn()
        id_forn = New DataGridViewTextBoxColumn()
        btn_editar = New DataGridViewImageColumn()
        btn_excluir = New DataGridViewImageColumn()
        btn_cancelar = New Button()
        txt_valor = New TextBox()
        CType(dgv_historico, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Left
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label5.Location = New Point(11, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 19)
        Label5.TabIndex = 33
        Label5.Text = "Fornecedor"
        ' 
        ' cmb_fornecedor
        ' 
        cmb_fornecedor.Anchor = AnchorStyles.Left
        cmb_fornecedor.FormattingEnabled = True
        cmb_fornecedor.Items.AddRange(New Object() {"Mercado", "Serviço Público", "Funcionário", "Manutenção", "Outros"})
        cmb_fornecedor.Location = New Point(12, 37)
        cmb_fornecedor.Name = "cmb_fornecedor"
        cmb_fornecedor.Size = New Size(158, 23)
        cmb_fornecedor.TabIndex = 32
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label2.Location = New Point(12, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 19)
        Label2.TabIndex = 35
        Label2.Text = "Descrição"
        ' 
        ' txt_descricao
        ' 
        txt_descricao.Anchor = AnchorStyles.Left
        txt_descricao.Location = New Point(12, 92)
        txt_descricao.Name = "txt_descricao"
        txt_descricao.Size = New Size(267, 23)
        txt_descricao.TabIndex = 34
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Left
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label7.Location = New Point(12, 132)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 19)
        Label7.TabIndex = 36
        Label7.Text = "Valor"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label1.Location = New Point(139, 131)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 19)
        Label1.TabIndex = 43
        Label1.Text = "Data"
        ' 
        ' dtp_data
        ' 
        dtp_data.Anchor = AnchorStyles.Left
        dtp_data.Format = DateTimePickerFormat.Short
        dtp_data.Location = New Point(139, 153)
        dtp_data.Name = "dtp_data"
        dtp_data.Size = New Size(140, 23)
        dtp_data.TabIndex = 42
        ' 
        ' rdb_fixo
        ' 
        rdb_fixo.Anchor = AnchorStyles.Left
        rdb_fixo.AutoSize = True
        rdb_fixo.BackColor = Color.Transparent
        rdb_fixo.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdb_fixo.Location = New Point(11, 199)
        rdb_fixo.Name = "rdb_fixo"
        rdb_fixo.Size = New Size(102, 22)
        rdb_fixo.TabIndex = 44
        rdb_fixo.TabStop = True
        rdb_fixo.Text = "Gasto Fixo"
        rdb_fixo.UseVisualStyleBackColor = False
        ' 
        ' rdb_variavel
        ' 
        rdb_variavel.Anchor = AnchorStyles.Left
        rdb_variavel.AutoSize = True
        rdb_variavel.BackColor = Color.Transparent
        rdb_variavel.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdb_variavel.Location = New Point(151, 199)
        rdb_variavel.Name = "rdb_variavel"
        rdb_variavel.Size = New Size(128, 22)
        rdb_variavel.TabIndex = 45
        rdb_variavel.TabStop = True
        rdb_variavel.Text = "Gasto Variável"
        rdb_variavel.UseVisualStyleBackColor = False
        ' 
        ' btn_lancar
        ' 
        btn_lancar.Anchor = AnchorStyles.Left
        btn_lancar.BackColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        btn_lancar.FlatStyle = FlatStyle.Flat
        btn_lancar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_lancar.Location = New Point(34, 237)
        btn_lancar.Name = "btn_lancar"
        btn_lancar.Size = New Size(109, 68)
        btn_lancar.TabIndex = 46
        btn_lancar.Text = "Lançar Despesa"
        btn_lancar.UseVisualStyleBackColor = False
        ' 
        ' dgv_historico
        ' 
        dgv_historico.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv_historico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_historico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_historico.Columns.AddRange(New DataGridViewColumn() {id, data, fornecedor, desc, valor, tipo, id_forn, btn_editar, btn_excluir})
        dgv_historico.Location = New Point(311, 18)
        dgv_historico.Name = "dgv_historico"
        dgv_historico.Size = New Size(469, 287)
        dgv_historico.TabIndex = 47
        ' 
        ' id
        ' 
        id.HeaderText = "ID"
        id.Name = "id"
        ' 
        ' data
        ' 
        data.HeaderText = "Data"
        data.Name = "data"
        ' 
        ' fornecedor
        ' 
        fornecedor.HeaderText = "Fornecedor"
        fornecedor.Name = "fornecedor"
        ' 
        ' desc
        ' 
        desc.HeaderText = "Descrição"
        desc.Name = "desc"
        ' 
        ' valor
        ' 
        valor.HeaderText = "Valor"
        valor.Name = "valor"
        ' 
        ' tipo
        ' 
        tipo.HeaderText = "Tipo"
        tipo.Name = "tipo"
        ' 
        ' id_forn
        ' 
        id_forn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        id_forn.HeaderText = "ID_Forn"
        id_forn.Name = "id_forn"
        id_forn.Visible = False
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
        ' btn_cancelar
        ' 
        btn_cancelar.Anchor = AnchorStyles.Left
        btn_cancelar.BackColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        btn_cancelar.FlatStyle = FlatStyle.Flat
        btn_cancelar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_cancelar.Location = New Point(149, 237)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(109, 68)
        btn_cancelar.TabIndex = 48
        btn_cancelar.Text = "Cancelar"
        btn_cancelar.UseVisualStyleBackColor = False
        ' 
        ' txt_valor
        ' 
        txt_valor.Anchor = AnchorStyles.Left
        txt_valor.Location = New Point(11, 153)
        txt_valor.Name = "txt_valor"
        txt_valor.Size = New Size(113, 23)
        txt_valor.TabIndex = 49
        ' 
        ' frm_gastos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(95), CByte(99), CByte(104))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(792, 319)
        Controls.Add(txt_valor)
        Controls.Add(btn_cancelar)
        Controls.Add(dgv_historico)
        Controls.Add(btn_lancar)
        Controls.Add(rdb_variavel)
        Controls.Add(rdb_fixo)
        Controls.Add(Label1)
        Controls.Add(dtp_data)
        Controls.Add(Label7)
        Controls.Add(Label2)
        Controls.Add(txt_descricao)
        Controls.Add(Label5)
        Controls.Add(cmb_fornecedor)
        Name = "frm_gastos"
        Text = "frm_gastos"
        CType(dgv_historico, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_fornecedor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_descricao As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_data As DateTimePicker
    Friend WithEvents rdb_fixo As RadioButton
    Friend WithEvents rdb_variavel As RadioButton
    Friend WithEvents btn_lancar As Button
    Friend WithEvents dgv_historico As DataGridView
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents data As DataGridViewTextBoxColumn
    Friend WithEvents fornecedor As DataGridViewTextBoxColumn
    Friend WithEvents desc As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents id_forn As DataGridViewTextBoxColumn
    Friend WithEvents btn_editar As DataGridViewImageColumn
    Friend WithEvents btn_excluir As DataGridViewImageColumn
End Class
