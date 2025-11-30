<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_reservas
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
        lbl_nome_cliente = New Label()
        txt_telefone_cliente = New MaskedTextBox()
        Label1 = New Label()
        Label2 = New Label()
        dtp_data = New DateTimePicker()
        Label3 = New Label()
        dtp_hora = New DateTimePicker()
        nud_pessoas = New NumericUpDown()
        Label4 = New Label()
        txt_obs = New TextBox()
        Label5 = New Label()
        btn_agendar = New Button()
        Label6 = New Label()
        dtp_filtro = New DateTimePicker()
        btn_filtrar = New Button()
        dgv_reservas = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        data_hora = New DataGridViewTextBoxColumn()
        cliente = New DataGridViewTextBoxColumn()
        pessoas = New DataGridViewTextBoxColumn()
        status = New DataGridViewTextBoxColumn()
        obs = New DataGridViewTextBoxColumn()
        id_cli = New DataGridViewTextBoxColumn()
        btn_editar = New DataGridViewImageColumn()
        btn_cancelar = New DataGridViewImageColumn()
        CType(nud_pessoas, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_reservas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_nome_cliente
        ' 
        lbl_nome_cliente.Anchor = AnchorStyles.Left
        lbl_nome_cliente.AutoSize = True
        lbl_nome_cliente.BackColor = Color.Transparent
        lbl_nome_cliente.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_nome_cliente.Location = New Point(156, 95)
        lbl_nome_cliente.Name = "lbl_nome_cliente"
        lbl_nome_cliente.Size = New Size(175, 24)
        lbl_nome_cliente.TabIndex = 10
        lbl_nome_cliente.Text = "Nome do Cliente"
        ' 
        ' txt_telefone_cliente
        ' 
        txt_telefone_cliente.Anchor = AnchorStyles.Left
        txt_telefone_cliente.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_telefone_cliente.Location = New Point(36, 105)
        txt_telefone_cliente.Mask = "(99) 00000-0000"
        txt_telefone_cliente.Name = "txt_telefone_cliente"
        txt_telefone_cliente.Size = New Size(100, 25)
        txt_telefone_cliente.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label1.Location = New Point(36, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 19)
        Label1.TabIndex = 7
        Label1.Text = "Telefone"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label2.Location = New Point(36, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 19)
        Label2.TabIndex = 43
        Label2.Text = "Data da reserva"
        ' 
        ' dtp_data
        ' 
        dtp_data.Anchor = AnchorStyles.Left
        dtp_data.Format = DateTimePickerFormat.Short
        dtp_data.Location = New Point(36, 164)
        dtp_data.Name = "dtp_data"
        dtp_data.Size = New Size(120, 23)
        dtp_data.TabIndex = 42
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label3.Location = New Point(170, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 19)
        Label3.TabIndex = 45
        Label3.Text = "Horário da reserva"
        ' 
        ' dtp_hora
        ' 
        dtp_hora.Anchor = AnchorStyles.Left
        dtp_hora.Format = DateTimePickerFormat.Time
        dtp_hora.Location = New Point(170, 164)
        dtp_hora.Name = "dtp_hora"
        dtp_hora.ShowUpDown = True
        dtp_hora.Size = New Size(140, 23)
        dtp_hora.TabIndex = 44
        ' 
        ' nud_pessoas
        ' 
        nud_pessoas.Anchor = AnchorStyles.Left
        nud_pessoas.Location = New Point(36, 224)
        nud_pessoas.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        nud_pessoas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nud_pessoas.Name = "nud_pessoas"
        nud_pessoas.Size = New Size(120, 23)
        nud_pessoas.TabIndex = 46
        nud_pessoas.Value = New Decimal(New Integer() {2, 0, 0, 0})
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label4.Location = New Point(36, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 19)
        Label4.TabIndex = 47
        Label4.Text = "Qtd de pessoas"
        ' 
        ' txt_obs
        ' 
        txt_obs.Anchor = AnchorStyles.Left
        txt_obs.Location = New Point(170, 224)
        txt_obs.Multiline = True
        txt_obs.Name = "txt_obs"
        txt_obs.Size = New Size(207, 127)
        txt_obs.TabIndex = 48
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Left
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label5.Location = New Point(170, 202)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 19)
        Label5.TabIndex = 49
        Label5.Text = "Observações"
        ' 
        ' btn_agendar
        ' 
        btn_agendar.Anchor = AnchorStyles.Left
        btn_agendar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_agendar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_agendar.Location = New Point(40, 272)
        btn_agendar.Name = "btn_agendar"
        btn_agendar.Size = New Size(109, 68)
        btn_agendar.TabIndex = 50
        btn_agendar.Text = "Agendar"
        btn_agendar.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label6.Location = New Point(584, 16)
        Label6.Name = "Label6"
        Label6.Size = New Size(132, 19)
        Label6.TabIndex = 52
        Label6.Text = "Verificar agenda"
        ' 
        ' dtp_filtro
        ' 
        dtp_filtro.Anchor = AnchorStyles.Top
        dtp_filtro.Format = DateTimePickerFormat.Short
        dtp_filtro.Location = New Point(584, 38)
        dtp_filtro.Name = "dtp_filtro"
        dtp_filtro.Size = New Size(120, 23)
        dtp_filtro.TabIndex = 51
        ' 
        ' btn_filtrar
        ' 
        btn_filtrar.Anchor = AnchorStyles.Top
        btn_filtrar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_filtrar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_filtrar.Location = New Point(736, 16)
        btn_filtrar.Name = "btn_filtrar"
        btn_filtrar.Size = New Size(128, 45)
        btn_filtrar.TabIndex = 53
        btn_filtrar.Text = "Ver agenda"
        btn_filtrar.UseVisualStyleBackColor = False
        ' 
        ' dgv_reservas
        ' 
        dgv_reservas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv_reservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_reservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_reservas.Columns.AddRange(New DataGridViewColumn() {id, data_hora, cliente, pessoas, status, obs, id_cli, btn_editar, btn_cancelar})
        dgv_reservas.Location = New Point(431, 67)
        dgv_reservas.Name = "dgv_reservas"
        dgv_reservas.Size = New Size(598, 363)
        dgv_reservas.TabIndex = 54
        ' 
        ' id
        ' 
        id.HeaderText = "ID"
        id.Name = "id"
        ' 
        ' data_hora
        ' 
        data_hora.HeaderText = "Data/Hora"
        data_hora.Name = "data_hora"
        ' 
        ' cliente
        ' 
        cliente.HeaderText = "Cliente"
        cliente.Name = "cliente"
        ' 
        ' pessoas
        ' 
        pessoas.HeaderText = "Pessoas"
        pessoas.Name = "pessoas"
        ' 
        ' status
        ' 
        status.HeaderText = "Status"
        status.Name = "status"
        ' 
        ' obs
        ' 
        obs.HeaderText = "Obs"
        obs.Name = "obs"
        ' 
        ' id_cli
        ' 
        id_cli.HeaderText = "ID_Cli"
        id_cli.Name = "id_cli"
        id_cli.Visible = False
        ' 
        ' btn_editar
        ' 
        btn_editar.HeaderText = "Editar"
        btn_editar.Image = My.Resources.Resources.editar
        btn_editar.Name = "btn_editar"
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.HeaderText = "Cancelar"
        btn_cancelar.Image = My.Resources.Resources.deletar
        btn_cancelar.Name = "btn_cancelar"
        ' 
        ' frm_reservas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(95), CByte(99), CByte(104))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1041, 442)
        Controls.Add(dgv_reservas)
        Controls.Add(btn_filtrar)
        Controls.Add(Label6)
        Controls.Add(dtp_filtro)
        Controls.Add(btn_agendar)
        Controls.Add(Label5)
        Controls.Add(txt_obs)
        Controls.Add(Label4)
        Controls.Add(nud_pessoas)
        Controls.Add(Label3)
        Controls.Add(dtp_hora)
        Controls.Add(Label2)
        Controls.Add(dtp_data)
        Controls.Add(lbl_nome_cliente)
        Controls.Add(txt_telefone_cliente)
        Controls.Add(Label1)
        Name = "frm_reservas"
        Text = "frm_reservas"
        CType(nud_pessoas, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_reservas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_nome_cliente As Label
    Friend WithEvents txt_telefone_cliente As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_data As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_hora As DateTimePicker
    Friend WithEvents nud_pessoas As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_obs As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_agendar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dtp_filtro As DateTimePicker
    Friend WithEvents btn_filtrar As Button
    Friend WithEvents dgv_reservas As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents data_hora As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents pessoas As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents obs As DataGridViewTextBoxColumn
    Friend WithEvents id_cli As DataGridViewTextBoxColumn
    Friend WithEvents btn_editar As DataGridViewImageColumn
    Friend WithEvents btn_cancelar As DataGridViewImageColumn
End Class
