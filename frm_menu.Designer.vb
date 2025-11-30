<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        panelMenu = New Panel()
        btn_produtos = New Button()
        btn_motoboys = New Button()
        btn_fornecedores = New Button()
        btn_clientes = New Button()
        btn_relatorios = New Button()
        btn_gastos = New Button()
        btn_graficos = New Button()
        btn_reservas = New Button()
        btn_pedidos = New Button()
        panelLogo = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        lblTitulo = New Label()
        panelConteudo = New Panel()
        panelMenu.SuspendLayout()
        panelLogo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelMenu
        ' 
        panelMenu.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        panelMenu.Controls.Add(btn_produtos)
        panelMenu.Controls.Add(btn_motoboys)
        panelMenu.Controls.Add(btn_fornecedores)
        panelMenu.Controls.Add(btn_clientes)
        panelMenu.Controls.Add(btn_relatorios)
        panelMenu.Controls.Add(btn_gastos)
        panelMenu.Controls.Add(btn_graficos)
        panelMenu.Controls.Add(btn_reservas)
        panelMenu.Controls.Add(btn_pedidos)
        panelMenu.Controls.Add(panelLogo)
        panelMenu.Dock = DockStyle.Left
        panelMenu.Location = New Point(0, 0)
        panelMenu.Name = "panelMenu"
        panelMenu.Size = New Size(220, 741)
        panelMenu.TabIndex = 0
        ' 
        ' btn_produtos
        ' 
        btn_produtos.BackColor = Color.Transparent
        btn_produtos.Dock = DockStyle.Top
        btn_produtos.FlatAppearance.BorderSize = 0
        btn_produtos.FlatStyle = FlatStyle.Flat
        btn_produtos.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_produtos.ForeColor = Color.Black
        btn_produtos.Image = My.Resources.Resources.bottle_icon
        btn_produtos.ImageAlign = ContentAlignment.MiddleLeft
        btn_produtos.Location = New Point(0, 672)
        btn_produtos.Name = "btn_produtos"
        btn_produtos.Padding = New Padding(6, 0, 0, 0)
        btn_produtos.Size = New Size(220, 70)
        btn_produtos.TabIndex = 9
        btn_produtos.Text = "  Produtos"
        btn_produtos.TextAlign = ContentAlignment.MiddleLeft
        btn_produtos.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_produtos.UseVisualStyleBackColor = False
        ' 
        ' btn_motoboys
        ' 
        btn_motoboys.BackColor = Color.Transparent
        btn_motoboys.Dock = DockStyle.Top
        btn_motoboys.FlatAppearance.BorderSize = 0
        btn_motoboys.FlatStyle = FlatStyle.Flat
        btn_motoboys.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_motoboys.ForeColor = Color.Black
        btn_motoboys.Image = My.Resources.Resources.moto_icon
        btn_motoboys.ImageAlign = ContentAlignment.MiddleLeft
        btn_motoboys.Location = New Point(0, 602)
        btn_motoboys.Name = "btn_motoboys"
        btn_motoboys.Padding = New Padding(12, 0, 0, 0)
        btn_motoboys.Size = New Size(220, 70)
        btn_motoboys.TabIndex = 8
        btn_motoboys.Text = "  Cadastrar Motoboy"
        btn_motoboys.TextAlign = ContentAlignment.MiddleLeft
        btn_motoboys.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_motoboys.UseVisualStyleBackColor = False
        ' 
        ' btn_fornecedores
        ' 
        btn_fornecedores.BackColor = Color.Transparent
        btn_fornecedores.Dock = DockStyle.Top
        btn_fornecedores.FlatAppearance.BorderSize = 0
        btn_fornecedores.FlatStyle = FlatStyle.Flat
        btn_fornecedores.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        btn_fornecedores.ForeColor = Color.Black
        btn_fornecedores.Image = My.Resources.Resources.Pictogrammers_Material_Store_48
        btn_fornecedores.ImageAlign = ContentAlignment.MiddleLeft
        btn_fornecedores.Location = New Point(0, 532)
        btn_fornecedores.Name = "btn_fornecedores"
        btn_fornecedores.Padding = New Padding(12, 0, 0, 0)
        btn_fornecedores.Size = New Size(220, 70)
        btn_fornecedores.TabIndex = 7
        btn_fornecedores.Text = "  Fornecedores"
        btn_fornecedores.TextAlign = ContentAlignment.MiddleLeft
        btn_fornecedores.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_fornecedores.UseVisualStyleBackColor = False
        ' 
        ' btn_clientes
        ' 
        btn_clientes.BackColor = Color.Transparent
        btn_clientes.Dock = DockStyle.Top
        btn_clientes.FlatAppearance.BorderSize = 0
        btn_clientes.FlatStyle = FlatStyle.Flat
        btn_clientes.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_clientes.ForeColor = Color.Black
        btn_clientes.Image = My.Resources.Resources.customer_icon
        btn_clientes.ImageAlign = ContentAlignment.MiddleLeft
        btn_clientes.Location = New Point(0, 462)
        btn_clientes.Name = "btn_clientes"
        btn_clientes.Padding = New Padding(12, 0, 0, 0)
        btn_clientes.Size = New Size(220, 70)
        btn_clientes.TabIndex = 6
        btn_clientes.Text = "  Cadastrar Cliente"
        btn_clientes.TextAlign = ContentAlignment.MiddleLeft
        btn_clientes.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_clientes.UseVisualStyleBackColor = False
        ' 
        ' btn_relatorios
        ' 
        btn_relatorios.BackColor = Color.Transparent
        btn_relatorios.Dock = DockStyle.Top
        btn_relatorios.FlatAppearance.BorderSize = 0
        btn_relatorios.FlatStyle = FlatStyle.Flat
        btn_relatorios.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_relatorios.ForeColor = Color.Black
        btn_relatorios.Image = My.Resources.Resources.finances_icon
        btn_relatorios.ImageAlign = ContentAlignment.MiddleLeft
        btn_relatorios.Location = New Point(0, 392)
        btn_relatorios.Name = "btn_relatorios"
        btn_relatorios.Padding = New Padding(12, 0, 0, 0)
        btn_relatorios.Size = New Size(220, 70)
        btn_relatorios.TabIndex = 5
        btn_relatorios.Text = "  Visualizar Finanças"
        btn_relatorios.TextAlign = ContentAlignment.MiddleLeft
        btn_relatorios.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_relatorios.UseVisualStyleBackColor = False
        ' 
        ' btn_gastos
        ' 
        btn_gastos.BackColor = Color.Transparent
        btn_gastos.Dock = DockStyle.Top
        btn_gastos.FlatAppearance.BorderSize = 0
        btn_gastos.FlatStyle = FlatStyle.Flat
        btn_gastos.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_gastos.ForeColor = Color.Black
        btn_gastos.Image = My.Resources.Resources.bills_icon
        btn_gastos.ImageAlign = ContentAlignment.MiddleLeft
        btn_gastos.Location = New Point(0, 322)
        btn_gastos.Name = "btn_gastos"
        btn_gastos.Padding = New Padding(12, 0, 0, 0)
        btn_gastos.Size = New Size(220, 70)
        btn_gastos.TabIndex = 4
        btn_gastos.Text = "  Cadastrar Gastos"
        btn_gastos.TextAlign = ContentAlignment.MiddleLeft
        btn_gastos.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_gastos.UseVisualStyleBackColor = False
        ' 
        ' btn_graficos
        ' 
        btn_graficos.BackColor = Color.Transparent
        btn_graficos.Dock = DockStyle.Top
        btn_graficos.FlatAppearance.BorderSize = 0
        btn_graficos.FlatStyle = FlatStyle.Flat
        btn_graficos.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_graficos.ForeColor = Color.Black
        btn_graficos.Image = My.Resources.Resources.chart
        btn_graficos.ImageAlign = ContentAlignment.MiddleLeft
        btn_graficos.Location = New Point(0, 252)
        btn_graficos.Name = "btn_graficos"
        btn_graficos.Padding = New Padding(12, 0, 0, 0)
        btn_graficos.Size = New Size(220, 70)
        btn_graficos.TabIndex = 3
        btn_graficos.Text = "  Visualizar Gráficos"
        btn_graficos.TextAlign = ContentAlignment.MiddleLeft
        btn_graficos.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_graficos.UseVisualStyleBackColor = False
        ' 
        ' btn_reservas
        ' 
        btn_reservas.BackColor = Color.Transparent
        btn_reservas.Dock = DockStyle.Top
        btn_reservas.FlatAppearance.BorderSize = 0
        btn_reservas.FlatStyle = FlatStyle.Flat
        btn_reservas.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_reservas.ForeColor = Color.Black
        btn_reservas.Image = My.Resources.Resources.reserva
        btn_reservas.ImageAlign = ContentAlignment.MiddleLeft
        btn_reservas.Location = New Point(0, 182)
        btn_reservas.Name = "btn_reservas"
        btn_reservas.Padding = New Padding(12, 0, 0, 0)
        btn_reservas.Size = New Size(220, 70)
        btn_reservas.TabIndex = 2
        btn_reservas.Text = "  Cadastrar Reserva"
        btn_reservas.TextAlign = ContentAlignment.MiddleLeft
        btn_reservas.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_reservas.UseVisualStyleBackColor = False
        ' 
        ' btn_pedidos
        ' 
        btn_pedidos.BackColor = Color.Transparent
        btn_pedidos.Dock = DockStyle.Top
        btn_pedidos.FlatAppearance.BorderSize = 0
        btn_pedidos.FlatStyle = FlatStyle.Flat
        btn_pedidos.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_pedidos.ForeColor = Color.Black
        btn_pedidos.Image = My.Resources.Resources.pizza_icon1
        btn_pedidos.ImageAlign = ContentAlignment.MiddleLeft
        btn_pedidos.Location = New Point(0, 112)
        btn_pedidos.Name = "btn_pedidos"
        btn_pedidos.Padding = New Padding(12, 0, 0, 0)
        btn_pedidos.Size = New Size(220, 70)
        btn_pedidos.TabIndex = 1
        btn_pedidos.Text = "  Cadastrar Pedidos"
        btn_pedidos.TextAlign = ContentAlignment.MiddleLeft
        btn_pedidos.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_pedidos.UseVisualStyleBackColor = False
        ' 
        ' panelLogo
        ' 
        panelLogo.BackColor = Color.FromArgb(CByte(204), CByte(86), CByte(0))
        panelLogo.Controls.Add(Label1)
        panelLogo.Controls.Add(PictureBox1)
        panelLogo.Dock = DockStyle.Top
        panelLogo.Location = New Point(0, 0)
        panelLogo.Name = "panelLogo"
        panelLogo.Size = New Size(220, 112)
        panelLogo.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(87, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 22)
        Label1.TabIndex = 0
        Label1.Text = "Pizza System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.food_delivery_1_
        PictureBox1.Location = New Point(3, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(82, 83)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        Panel1.Controls.Add(lblTitulo)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(220, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1129, 112)
        Panel1.TabIndex = 1
        ' 
        ' lblTitulo
        ' 
        lblTitulo.Anchor = AnchorStyles.None
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = Color.White
        lblTitulo.Location = New Point(460, 45)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(183, 24)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "MENU PRINCIPAL"
        ' 
        ' panelConteudo
        ' 
        panelConteudo.BackColor = Color.Gray
        panelConteudo.Dock = DockStyle.Fill
        panelConteudo.ForeColor = Color.White
        panelConteudo.Location = New Point(220, 112)
        panelConteudo.Name = "panelConteudo"
        panelConteudo.Size = New Size(1129, 629)
        panelConteudo.TabIndex = 3
        ' 
        ' frm_menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(95), CByte(99), CByte(104))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1349, 741)
        Controls.Add(panelConteudo)
        Controls.Add(Panel1)
        Controls.Add(panelMenu)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frm_menu"
        Text = "Pizza System"
        panelMenu.ResumeLayout(False)
        panelLogo.ResumeLayout(False)
        panelLogo.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents btn_pedidos As Button
    Friend WithEvents btn_fornecedores As Button
    Friend WithEvents btn_clientes As Button
    Friend WithEvents btn_relatorios As Button
    Friend WithEvents btn_gastos As Button
    Friend WithEvents btn_graficos As Button
    Friend WithEvents btn_reservas As Button
    Friend WithEvents btn_motoboys As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btn_produtos As Button
    Friend WithEvents panelLogo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelConteudo As Panel
End Class
