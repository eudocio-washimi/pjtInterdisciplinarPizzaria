<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_consulta_vendas
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btn_filtrar = New Button()
        Label2 = New Label()
        dtp_fim = New DateTimePicker()
        Label1 = New Label()
        dtp_inicio = New DateTimePicker()
        lbl_total_entradas = New Label()
        dgv_financeiro = New DataGridView()
        lbl_saldo_final = New Label()
        lbl_total_saidas = New Label()
        rdb_entradas = New RadioButton()
        rdb_saidas = New RadioButton()
        rdb_todos = New RadioButton()
        chk_agrupar_data = New CheckBox()
        data = New DataGridViewTextBoxColumn()
        descricao = New DataGridViewTextBoxColumn()
        tipo = New DataGridViewTextBoxColumn()
        entrada = New DataGridViewTextBoxColumn()
        saida = New DataGridViewTextBoxColumn()
        CType(dgv_financeiro, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_filtrar
        ' 
        btn_filtrar.Anchor = AnchorStyles.Top
        btn_filtrar.BackColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        btn_filtrar.FlatStyle = FlatStyle.Flat
        btn_filtrar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_filtrar.Location = New Point(391, 25)
        btn_filtrar.Name = "btn_filtrar"
        btn_filtrar.Size = New Size(227, 43)
        btn_filtrar.TabIndex = 44
        btn_filtrar.Text = "Pesquisar Vendas"
        btn_filtrar.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label2.Location = New Point(236, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 19)
        Label2.TabIndex = 43
        Label2.Text = "Data Final"
        ' 
        ' dtp_fim
        ' 
        dtp_fim.Anchor = AnchorStyles.Top
        dtp_fim.Format = DateTimePickerFormat.Short
        dtp_fim.Location = New Point(236, 44)
        dtp_fim.Name = "dtp_fim"
        dtp_fim.Size = New Size(140, 23)
        dtp_fim.TabIndex = 42
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label1.Location = New Point(79, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 19)
        Label1.TabIndex = 41
        Label1.Text = "Data Inicial"
        ' 
        ' dtp_inicio
        ' 
        dtp_inicio.Anchor = AnchorStyles.Top
        dtp_inicio.Format = DateTimePickerFormat.Short
        dtp_inicio.Location = New Point(79, 44)
        dtp_inicio.Name = "dtp_inicio"
        dtp_inicio.Size = New Size(140, 23)
        dtp_inicio.TabIndex = 40
        ' 
        ' lbl_total_entradas
        ' 
        lbl_total_entradas.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbl_total_entradas.AutoSize = True
        lbl_total_entradas.BackColor = Color.Transparent
        lbl_total_entradas.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_total_entradas.Location = New Point(731, 240)
        lbl_total_entradas.Name = "lbl_total_entradas"
        lbl_total_entradas.Size = New Size(163, 32)
        lbl_total_entradas.TabIndex = 46
        lbl_total_entradas.Text = "R$ 9.999,99"
        ' 
        ' dgv_financeiro
        ' 
        dgv_financeiro.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv_financeiro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_financeiro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_financeiro.Columns.AddRange(New DataGridViewColumn() {data, descricao, tipo, entrada, saida})
        dgv_financeiro.Location = New Point(12, 120)
        dgv_financeiro.Name = "dgv_financeiro"
        dgv_financeiro.Size = New Size(662, 401)
        dgv_financeiro.TabIndex = 45
        ' 
        ' lbl_saldo_final
        ' 
        lbl_saldo_final.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbl_saldo_final.AutoSize = True
        lbl_saldo_final.BackColor = Color.Transparent
        lbl_saldo_final.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_saldo_final.Location = New Point(731, 304)
        lbl_saldo_final.Name = "lbl_saldo_final"
        lbl_saldo_final.Size = New Size(163, 32)
        lbl_saldo_final.TabIndex = 47
        lbl_saldo_final.Text = "R$ 9.999,99"
        ' 
        ' lbl_total_saidas
        ' 
        lbl_total_saidas.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbl_total_saidas.AutoSize = True
        lbl_total_saidas.BackColor = Color.Transparent
        lbl_total_saidas.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_total_saidas.Location = New Point(731, 272)
        lbl_total_saidas.Name = "lbl_total_saidas"
        lbl_total_saidas.Size = New Size(163, 32)
        lbl_total_saidas.TabIndex = 48
        lbl_total_saidas.Text = "R$ 9.999,99"
        ' 
        ' rdb_entradas
        ' 
        rdb_entradas.Anchor = AnchorStyles.Top
        rdb_entradas.AutoSize = True
        rdb_entradas.BackColor = Color.Transparent
        rdb_entradas.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdb_entradas.Location = New Point(32, 83)
        rdb_entradas.Name = "rdb_entradas"
        rdb_entradas.Size = New Size(89, 22)
        rdb_entradas.TabIndex = 49
        rdb_entradas.TabStop = True
        rdb_entradas.Text = "Entradas"
        rdb_entradas.UseVisualStyleBackColor = False
        ' 
        ' rdb_saidas
        ' 
        rdb_saidas.Anchor = AnchorStyles.Top
        rdb_saidas.AutoSize = True
        rdb_saidas.BackColor = Color.Transparent
        rdb_saidas.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdb_saidas.Location = New Point(294, 83)
        rdb_saidas.Name = "rdb_saidas"
        rdb_saidas.Size = New Size(73, 22)
        rdb_saidas.TabIndex = 50
        rdb_saidas.TabStop = True
        rdb_saidas.Text = "Saídas"
        rdb_saidas.UseVisualStyleBackColor = False
        ' 
        ' rdb_todos
        ' 
        rdb_todos.Anchor = AnchorStyles.Top
        rdb_todos.AutoSize = True
        rdb_todos.BackColor = Color.Transparent
        rdb_todos.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdb_todos.Location = New Point(537, 83)
        rdb_todos.Name = "rdb_todos"
        rdb_todos.Size = New Size(117, 22)
        rdb_todos.TabIndex = 51
        rdb_todos.TabStop = True
        rdb_todos.Text = "Mostrar tudo"
        rdb_todos.UseVisualStyleBackColor = False
        ' 
        ' chk_agrupar_data
        ' 
        chk_agrupar_data.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chk_agrupar_data.AutoSize = True
        chk_agrupar_data.BackColor = Color.Transparent
        chk_agrupar_data.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        chk_agrupar_data.Location = New Point(718, 194)
        chk_agrupar_data.Name = "chk_agrupar_data"
        chk_agrupar_data.Size = New Size(188, 22)
        chk_agrupar_data.TabIndex = 52
        chk_agrupar_data.Text = "Agrupar totais por data"
        chk_agrupar_data.UseVisualStyleBackColor = False
        ' 
        ' data
        ' 
        data.HeaderText = "Data"
        data.Name = "data"
        ' 
        ' descricao
        ' 
        descricao.HeaderText = "Descrição / Cliente / Fornecedor"
        descricao.Name = "descricao"
        ' 
        ' tipo
        ' 
        tipo.HeaderText = "Tipo"
        tipo.Name = "tipo"
        ' 
        ' entrada
        ' 
        DataGridViewCellStyle1.ForeColor = Color.Green
        DataGridViewCellStyle1.Format = "N2"
        entrada.DefaultCellStyle = DataGridViewCellStyle1
        entrada.HeaderText = "Entrada (+)"
        entrada.Name = "entrada"
        ' 
        ' saida
        ' 
        DataGridViewCellStyle2.ForeColor = Color.Red
        DataGridViewCellStyle2.Format = "N2"
        saida.DefaultCellStyle = DataGridViewCellStyle2
        saida.HeaderText = "Saída (-)"
        saida.Name = "saida"
        ' 
        ' frm_consulta_vendas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(95), CByte(99), CByte(104))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(937, 533)
        Controls.Add(chk_agrupar_data)
        Controls.Add(rdb_todos)
        Controls.Add(rdb_saidas)
        Controls.Add(rdb_entradas)
        Controls.Add(lbl_total_saidas)
        Controls.Add(lbl_saldo_final)
        Controls.Add(lbl_total_entradas)
        Controls.Add(dgv_financeiro)
        Controls.Add(btn_filtrar)
        Controls.Add(Label2)
        Controls.Add(dtp_fim)
        Controls.Add(Label1)
        Controls.Add(dtp_inicio)
        Name = "frm_consulta_vendas"
        Text = "frm_consulta_vendas"
        CType(dgv_financeiro, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_filtrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_fim As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_inicio As DateTimePicker
    Friend WithEvents lbl_total_entradas As Label
    Friend WithEvents dgv_financeiro As DataGridView
    Friend WithEvents lbl_saldo_final As Label
    Friend WithEvents lbl_total_saidas As Label
    Friend WithEvents rdb_entradas As RadioButton
    Friend WithEvents rdb_saidas As RadioButton
    Friend WithEvents rdb_todos As RadioButton
    Friend WithEvents chk_agrupar_data As CheckBox
    Friend WithEvents data As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents entrada As DataGridViewTextBoxColumn
    Friend WithEvents saida As DataGridViewTextBoxColumn
End Class
