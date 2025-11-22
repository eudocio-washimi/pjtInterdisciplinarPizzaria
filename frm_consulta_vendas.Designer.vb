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
        dtp_inicio = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        dtp_fim = New DateTimePicker()
        btn_filtrar = New Button()
        dgv_vendas = New DataGridView()
        lbl_total_periodo = New Label()
        CType(dgv_vendas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtp_inicio
        ' 
        dtp_inicio.Format = DateTimePickerFormat.Short
        dtp_inicio.Location = New Point(14, 31)
        dtp_inicio.Name = "dtp_inicio"
        dtp_inicio.Size = New Size(140, 23)
        dtp_inicio.TabIndex = 40
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label1.Location = New Point(14, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 19)
        Label1.TabIndex = 41
        Label1.Text = "Data Inicial"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label2.Location = New Point(171, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 19)
        Label2.TabIndex = 43
        Label2.Text = "Data Final"
        ' 
        ' dtp_fim
        ' 
        dtp_fim.Format = DateTimePickerFormat.Short
        dtp_fim.Location = New Point(171, 31)
        dtp_fim.Name = "dtp_fim"
        dtp_fim.Size = New Size(140, 23)
        dtp_fim.TabIndex = 42
        ' 
        ' btn_filtrar
        ' 
        btn_filtrar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_filtrar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_filtrar.Location = New Point(326, 12)
        btn_filtrar.Name = "btn_filtrar"
        btn_filtrar.Size = New Size(227, 43)
        btn_filtrar.TabIndex = 44
        btn_filtrar.Text = "Pesquisar Vendas"
        btn_filtrar.UseVisualStyleBackColor = False
        ' 
        ' dgv_vendas
        ' 
        dgv_vendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_vendas.Location = New Point(14, 83)
        dgv_vendas.Name = "dgv_vendas"
        dgv_vendas.Size = New Size(539, 341)
        dgv_vendas.TabIndex = 45
        ' 
        ' lbl_total_periodo
        ' 
        lbl_total_periodo.AutoSize = True
        lbl_total_periodo.BackColor = Color.Transparent
        lbl_total_periodo.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_total_periodo.Location = New Point(57, 438)
        lbl_total_periodo.Name = "lbl_total_periodo"
        lbl_total_periodo.Size = New Size(441, 32)
        lbl_total_periodo.TabIndex = 46
        lbl_total_periodo.Text = "Faturamento do Período: R$0,00"
        ' 
        ' frm_consulta_vendas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(570, 490)
        Controls.Add(lbl_total_periodo)
        Controls.Add(dgv_vendas)
        Controls.Add(btn_filtrar)
        Controls.Add(Label2)
        Controls.Add(dtp_fim)
        Controls.Add(Label1)
        Controls.Add(dtp_inicio)
        Name = "frm_consulta_vendas"
        Text = "frm_consulta_vendas"
        CType(dgv_vendas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtp_inicio As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_fim As DateTimePicker
    Friend WithEvents btn_filtrar As Button
    Friend WithEvents dgv_vendas As DataGridView
    Friend WithEvents lbl_total_periodo As Label
End Class
