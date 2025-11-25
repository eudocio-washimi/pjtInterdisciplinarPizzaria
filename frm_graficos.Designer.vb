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
        btn_bairros = New Button()
        btn_pizzas = New Button()
        btn_motoboys = New Button()
        btn_tipo = New Button()
        btn_dias = New Button()
        lbl_status = New Label()
        pic_grafico = New PictureBox()
        btn_faturamento = New Button()
        btn_lucro = New Button()
        btn_pagamentos = New Button()
        btn_gastos_tipo = New Button()
        CType(pic_grafico, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_bairros
        ' 
        btn_bairros.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_bairros.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_bairros.Location = New Point(21, 12)
        btn_bairros.Name = "btn_bairros"
        btn_bairros.Size = New Size(105, 68)
        btn_bairros.TabIndex = 15
        btn_bairros.Text = "Top Bairros"
        btn_bairros.UseVisualStyleBackColor = False
        ' 
        ' btn_pizzas
        ' 
        btn_pizzas.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_pizzas.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_pizzas.Location = New Point(132, 12)
        btn_pizzas.Name = "btn_pizzas"
        btn_pizzas.Size = New Size(105, 68)
        btn_pizzas.TabIndex = 16
        btn_pizzas.Text = "Top Produtos"
        btn_pizzas.UseVisualStyleBackColor = False
        ' 
        ' btn_motoboys
        ' 
        btn_motoboys.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_motoboys.Font = New Font("Arial Black", 8.75F, FontStyle.Bold)
        btn_motoboys.Location = New Point(243, 12)
        btn_motoboys.Name = "btn_motoboys"
        btn_motoboys.Size = New Size(109, 68)
        btn_motoboys.TabIndex = 17
        btn_motoboys.Text = "Produtividade Motoboys"
        btn_motoboys.UseVisualStyleBackColor = False
        ' 
        ' btn_tipo
        ' 
        btn_tipo.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_tipo.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_tipo.Location = New Point(358, 12)
        btn_tipo.Name = "btn_tipo"
        btn_tipo.Size = New Size(105, 68)
        btn_tipo.TabIndex = 18
        btn_tipo.Text = "Entrega X Salão"
        btn_tipo.UseVisualStyleBackColor = False
        ' 
        ' btn_dias
        ' 
        btn_dias.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_dias.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_dias.Location = New Point(469, 12)
        btn_dias.Name = "btn_dias"
        btn_dias.Size = New Size(105, 68)
        btn_dias.TabIndex = 19
        btn_dias.Text = "Vendas por Dia"
        btn_dias.UseVisualStyleBackColor = False
        ' 
        ' lbl_status
        ' 
        lbl_status.AutoSize = True
        lbl_status.BackColor = Color.Transparent
        lbl_status.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_status.Location = New Point(775, 107)
        lbl_status.Name = "lbl_status"
        lbl_status.Size = New Size(322, 22)
        lbl_status.TabIndex = 47
        lbl_status.Text = "----------------------------------------------------"
        ' 
        ' pic_grafico
        ' 
        pic_grafico.BackgroundImageLayout = ImageLayout.None
        pic_grafico.Location = New Point(12, 168)
        pic_grafico.Name = "pic_grafico"
        pic_grafico.Size = New Size(1281, 619)
        pic_grafico.SizeMode = PictureBoxSizeMode.Zoom
        pic_grafico.TabIndex = 48
        pic_grafico.TabStop = False
        ' 
        ' btn_faturamento
        ' 
        btn_faturamento.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_faturamento.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_faturamento.Location = New Point(580, 12)
        btn_faturamento.Name = "btn_faturamento"
        btn_faturamento.Size = New Size(127, 68)
        btn_faturamento.TabIndex = 49
        btn_faturamento.Text = "Faturamento"
        btn_faturamento.UseVisualStyleBackColor = False
        ' 
        ' btn_lucro
        ' 
        btn_lucro.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_lucro.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_lucro.Location = New Point(713, 12)
        btn_lucro.Name = "btn_lucro"
        btn_lucro.Size = New Size(105, 68)
        btn_lucro.TabIndex = 50
        btn_lucro.Text = "Fluxo de Caixa"
        btn_lucro.UseVisualStyleBackColor = False
        ' 
        ' btn_pagamentos
        ' 
        btn_pagamentos.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_pagamentos.Font = New Font("Arial Black", 10F, FontStyle.Bold)
        btn_pagamentos.Location = New Point(824, 12)
        btn_pagamentos.Name = "btn_pagamentos"
        btn_pagamentos.Size = New Size(105, 68)
        btn_pagamentos.TabIndex = 51
        btn_pagamentos.Text = "Meios de Pagamento"
        btn_pagamentos.UseVisualStyleBackColor = False
        ' 
        ' btn_gastos_tipo
        ' 
        btn_gastos_tipo.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_gastos_tipo.Font = New Font("Arial Black", 10F, FontStyle.Bold)
        btn_gastos_tipo.Location = New Point(469, 86)
        btn_gastos_tipo.Name = "btn_gastos_tipo"
        btn_gastos_tipo.Size = New Size(105, 68)
        btn_gastos_tipo.TabIndex = 52
        btn_gastos_tipo.Text = "Despesas"
        btn_gastos_tipo.UseVisualStyleBackColor = False
        ' 
        ' frm_graficos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1305, 799)
        Controls.Add(btn_gastos_tipo)
        Controls.Add(btn_pagamentos)
        Controls.Add(btn_lucro)
        Controls.Add(btn_faturamento)
        Controls.Add(pic_grafico)
        Controls.Add(lbl_status)
        Controls.Add(btn_dias)
        Controls.Add(btn_tipo)
        Controls.Add(btn_motoboys)
        Controls.Add(btn_pizzas)
        Controls.Add(btn_bairros)
        Name = "frm_graficos"
        Text = "frm_graficos"
        WindowState = FormWindowState.Maximized
        CType(pic_grafico, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_bairros As Button
    Friend WithEvents btn_pizzas As Button
    Friend WithEvents btn_motoboys As Button
    Friend WithEvents btn_tipo As Button
    Friend WithEvents btn_dias As Button
    Friend WithEvents lbl_status As Label
    Friend WithEvents pic_grafico As PictureBox
    Friend WithEvents btn_faturamento As Button
    Friend WithEvents btn_lucro As Button
    Friend WithEvents btn_pagamentos As Button
    Friend WithEvents btn_gastos_tipo As Button
End Class
