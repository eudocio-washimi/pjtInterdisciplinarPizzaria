<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_graficos
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
        lbl_status = New Label()
        pnlStatus = New Panel()
        pnlMenu = New Panel()
        btn_tipo = New Button()
        btn_lucro = New Button()
        btn_bairros = New Button()
        btn_dias = New Button()
        btn_pizzas = New Button()
        btn_motoboys = New Button()
        btn_pagamentos = New Button()
        btn_gastos_tipo = New Button()
        btn_faturamento = New Button()
        pic_grafico = New PictureBox()
        pnlStatus.SuspendLayout()
        pnlMenu.SuspendLayout()
        CType(pic_grafico, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_status
        ' 
        lbl_status.AutoSize = True
        lbl_status.BackColor = Color.Transparent
        lbl_status.Dock = DockStyle.Top
        lbl_status.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_status.Location = New Point(0, 0)
        lbl_status.Name = "lbl_status"
        lbl_status.Size = New Size(442, 22)
        lbl_status.TabIndex = 47
        lbl_status.Text = "------------------------------------------------------------------------"
        lbl_status.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlStatus
        ' 
        pnlStatus.AutoSize = True
        pnlStatus.BackColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        pnlStatus.BackgroundImageLayout = ImageLayout.None
        pnlStatus.Controls.Add(lbl_status)
        pnlStatus.Dock = DockStyle.Top
        pnlStatus.Location = New Point(0, 0)
        pnlStatus.Name = "pnlStatus"
        pnlStatus.Size = New Size(1127, 22)
        pnlStatus.TabIndex = 54
        ' 
        ' pnlMenu
        ' 
        pnlMenu.BackColor = Color.Black
        pnlMenu.Controls.Add(btn_tipo)
        pnlMenu.Controls.Add(btn_lucro)
        pnlMenu.Controls.Add(btn_bairros)
        pnlMenu.Controls.Add(btn_dias)
        pnlMenu.Controls.Add(btn_pizzas)
        pnlMenu.Controls.Add(btn_motoboys)
        pnlMenu.Controls.Add(btn_pagamentos)
        pnlMenu.Controls.Add(btn_gastos_tipo)
        pnlMenu.Controls.Add(btn_faturamento)
        pnlMenu.Dock = DockStyle.Left
        pnlMenu.Location = New Point(0, 22)
        pnlMenu.Name = "pnlMenu"
        pnlMenu.Size = New Size(200, 616)
        pnlMenu.TabIndex = 55
        ' 
        ' btn_tipo
        ' 
        btn_tipo.AutoSize = True
        btn_tipo.BackColor = Color.Transparent
        btn_tipo.Dock = DockStyle.Top
        btn_tipo.FlatAppearance.BorderSize = 0
        btn_tipo.FlatStyle = FlatStyle.Flat
        btn_tipo.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        btn_tipo.ForeColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        btn_tipo.Location = New Point(0, 520)
        btn_tipo.Name = "btn_tipo"
        btn_tipo.Size = New Size(200, 65)
        btn_tipo.TabIndex = 18
        btn_tipo.Text = "Entrega X Salão"
        btn_tipo.UseVisualStyleBackColor = False
        ' 
        ' btn_lucro
        ' 
        btn_lucro.AutoSize = True
        btn_lucro.BackColor = Color.Transparent
        btn_lucro.Dock = DockStyle.Top
        btn_lucro.FlatAppearance.BorderSize = 0
        btn_lucro.FlatStyle = FlatStyle.Flat
        btn_lucro.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        btn_lucro.ForeColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        btn_lucro.Location = New Point(0, 455)
        btn_lucro.Name = "btn_lucro"
        btn_lucro.Size = New Size(200, 65)
        btn_lucro.TabIndex = 50
        btn_lucro.Text = "Fluxo de Caixa"
        btn_lucro.UseVisualStyleBackColor = False
        ' 
        ' btn_bairros
        ' 
        btn_bairros.AutoSize = True
        btn_bairros.BackColor = Color.Transparent
        btn_bairros.Dock = DockStyle.Top
        btn_bairros.FlatAppearance.BorderSize = 0
        btn_bairros.FlatStyle = FlatStyle.Flat
        btn_bairros.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        btn_bairros.ForeColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        btn_bairros.Location = New Point(0, 390)
        btn_bairros.Name = "btn_bairros"
        btn_bairros.Size = New Size(200, 65)
        btn_bairros.TabIndex = 15
        btn_bairros.Text = "Top Bairros"
        btn_bairros.UseVisualStyleBackColor = False
        ' 
        ' btn_dias
        ' 
        btn_dias.AutoSize = True
        btn_dias.BackColor = Color.Transparent
        btn_dias.Dock = DockStyle.Top
        btn_dias.FlatAppearance.BorderSize = 0
        btn_dias.FlatStyle = FlatStyle.Flat
        btn_dias.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        btn_dias.ForeColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        btn_dias.Location = New Point(0, 325)
        btn_dias.Name = "btn_dias"
        btn_dias.Size = New Size(200, 65)
        btn_dias.TabIndex = 19
        btn_dias.Text = "Vendas por Dia"
        btn_dias.UseVisualStyleBackColor = False
        ' 
        ' btn_pizzas
        ' 
        btn_pizzas.AutoSize = True
        btn_pizzas.BackColor = Color.Transparent
        btn_pizzas.Dock = DockStyle.Top
        btn_pizzas.FlatAppearance.BorderSize = 0
        btn_pizzas.FlatStyle = FlatStyle.Flat
        btn_pizzas.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        btn_pizzas.ForeColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        btn_pizzas.Location = New Point(0, 260)
        btn_pizzas.Name = "btn_pizzas"
        btn_pizzas.Size = New Size(200, 65)
        btn_pizzas.TabIndex = 16
        btn_pizzas.Text = "Top Produtos"
        btn_pizzas.UseVisualStyleBackColor = False
        ' 
        ' btn_motoboys
        ' 
        btn_motoboys.AutoSize = True
        btn_motoboys.BackColor = Color.Transparent
        btn_motoboys.Dock = DockStyle.Top
        btn_motoboys.FlatAppearance.BorderSize = 0
        btn_motoboys.FlatStyle = FlatStyle.Flat
        btn_motoboys.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        btn_motoboys.ForeColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        btn_motoboys.Location = New Point(0, 195)
        btn_motoboys.Name = "btn_motoboys"
        btn_motoboys.Size = New Size(200, 65)
        btn_motoboys.TabIndex = 17
        btn_motoboys.Text = "Produtividade Motoboys"
        btn_motoboys.UseVisualStyleBackColor = False
        ' 
        ' btn_pagamentos
        ' 
        btn_pagamentos.AutoSize = True
        btn_pagamentos.BackColor = Color.Transparent
        btn_pagamentos.Dock = DockStyle.Top
        btn_pagamentos.FlatAppearance.BorderSize = 0
        btn_pagamentos.FlatStyle = FlatStyle.Flat
        btn_pagamentos.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        btn_pagamentos.ForeColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        btn_pagamentos.Location = New Point(0, 130)
        btn_pagamentos.Name = "btn_pagamentos"
        btn_pagamentos.Size = New Size(200, 65)
        btn_pagamentos.TabIndex = 51
        btn_pagamentos.Text = "Meios de Pagamento"
        btn_pagamentos.UseVisualStyleBackColor = False
        ' 
        ' btn_gastos_tipo
        ' 
        btn_gastos_tipo.AutoSize = True
        btn_gastos_tipo.BackColor = Color.Transparent
        btn_gastos_tipo.Dock = DockStyle.Top
        btn_gastos_tipo.FlatAppearance.BorderSize = 0
        btn_gastos_tipo.FlatStyle = FlatStyle.Flat
        btn_gastos_tipo.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        btn_gastos_tipo.ForeColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        btn_gastos_tipo.Location = New Point(0, 65)
        btn_gastos_tipo.Name = "btn_gastos_tipo"
        btn_gastos_tipo.Size = New Size(200, 65)
        btn_gastos_tipo.TabIndex = 52
        btn_gastos_tipo.Text = "Despesas"
        btn_gastos_tipo.UseVisualStyleBackColor = False
        ' 
        ' btn_faturamento
        ' 
        btn_faturamento.AutoSize = True
        btn_faturamento.BackColor = Color.Transparent
        btn_faturamento.Dock = DockStyle.Top
        btn_faturamento.FlatAppearance.BorderSize = 0
        btn_faturamento.FlatStyle = FlatStyle.Flat
        btn_faturamento.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        btn_faturamento.ForeColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        btn_faturamento.Location = New Point(0, 0)
        btn_faturamento.Name = "btn_faturamento"
        btn_faturamento.Size = New Size(200, 65)
        btn_faturamento.TabIndex = 49
        btn_faturamento.Text = "Faturamento"
        btn_faturamento.UseVisualStyleBackColor = False
        ' 
        ' pic_grafico
        ' 
        pic_grafico.Dock = DockStyle.Fill
        pic_grafico.Location = New Point(200, 22)
        pic_grafico.Name = "pic_grafico"
        pic_grafico.Size = New Size(927, 616)
        pic_grafico.TabIndex = 56
        pic_grafico.TabStop = False
        ' 
        ' frm_graficos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(95), CByte(99), CByte(104))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1127, 638)
        Controls.Add(pic_grafico)
        Controls.Add(pnlMenu)
        Controls.Add(pnlStatus)
        Name = "frm_graficos"
        Text = "frm_graficos"
        pnlStatus.ResumeLayout(False)
        pnlStatus.PerformLayout()
        pnlMenu.ResumeLayout(False)
        pnlMenu.PerformLayout()
        CType(pic_grafico, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_status As Label
    Friend WithEvents pnlStatus As Panel
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btn_tipo As Button
    Friend WithEvents btn_dias As Button
    Friend WithEvents btn_pagamentos As Button
    Friend WithEvents btn_faturamento As Button
    Friend WithEvents btn_motoboys As Button
    Friend WithEvents btn_gastos_tipo As Button
    Friend WithEvents btn_bairros As Button
    Friend WithEvents btn_pizzas As Button
    Friend WithEvents btn_lucro As Button
    Friend WithEvents pic_grafico As PictureBox
End Class
