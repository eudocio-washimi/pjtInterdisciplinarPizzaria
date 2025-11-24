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
        CType(dgv_fornecedores, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label2.Location = New Point(107, 33)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(255, 29)
        Label2.TabIndex = 19
        Label2.Text = "Nome do Fornecedor"
        ' 
        ' txt_nome
        ' 
        txt_nome.Location = New Point(107, 65)
        txt_nome.Margin = New Padding(4, 5, 4, 5)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(484, 31)
        txt_nome.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label5.Location = New Point(107, 123)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(239, 29)
        Label5.TabIndex = 31
        Label5.Text = "Tipo de Fornecedor"
        ' 
        ' cmb_tipo
        ' 
        cmb_tipo.FormattingEnabled = True
        cmb_tipo.Items.AddRange(New Object() {"Mercado", "Serviço Público", "Funcionário", "Manutenção", "Outros"})
        cmb_tipo.Location = New Point(109, 155)
        cmb_tipo.Margin = New Padding(4, 5, 4, 5)
        cmb_tipo.Name = "cmb_tipo"
        cmb_tipo.Size = New Size(224, 33)
        cmb_tipo.TabIndex = 30
        ' 
        ' btn_salvar
        ' 
        btn_salvar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_salvar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_salvar.Location = New Point(366, 113)
        btn_salvar.Margin = New Padding(4, 5, 4, 5)
        btn_salvar.Name = "btn_salvar"
        btn_salvar.Size = New Size(156, 113)
        btn_salvar.TabIndex = 43
        btn_salvar.Text = "Salvar"
        btn_salvar.UseVisualStyleBackColor = False
        ' 
        ' dgv_fornecedores
        ' 
        dgv_fornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_fornecedores.Location = New Point(17, 252)
        dgv_fornecedores.Margin = New Padding(4, 5, 4, 5)
        dgv_fornecedores.Name = "dgv_fornecedores"
        dgv_fornecedores.RowHeadersWidth = 62
        dgv_fornecedores.Size = New Size(670, 478)
        dgv_fornecedores.TabIndex = 44
        ' 
        ' frm_cad_fornecedores
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(704, 750)
        Controls.Add(dgv_fornecedores)
        Controls.Add(btn_salvar)
        Controls.Add(Label5)
        Controls.Add(cmb_tipo)
        Controls.Add(Label2)
        Controls.Add(txt_nome)
        Margin = New Padding(4, 5, 4, 5)
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
End Class
