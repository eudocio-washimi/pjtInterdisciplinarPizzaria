<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cad_motoboy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cad_motoboy))
        dgv_motoboys = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewImageColumn()
        Column6 = New DataGridViewImageColumn()
        btn_salvar = New Button()
        label = New Label()
        txt_pix = New TextBox()
        Label2 = New Label()
        txt_telefone = New MaskedTextBox()
        txt_nome = New TextBox()
        Label1 = New Label()
        btn_excluir = New Button()
        CType(dgv_motoboys, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_motoboys
        ' 
        dgv_motoboys.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_motoboys.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_motoboys.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        dgv_motoboys.Location = New Point(12, 244)
        dgv_motoboys.Name = "dgv_motoboys"
        dgv_motoboys.RowHeadersWidth = 62
        dgv_motoboys.ShowCellErrors = False
        dgv_motoboys.Size = New Size(488, 193)
        dgv_motoboys.TabIndex = 28
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "id_motoboy"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 96
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nome"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 65
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Telefone"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 77
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Chave Pix"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 83
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Editar"
        Column5.Image = CType(resources.GetObject("Column5.Image"), Image)
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 43
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Deletar"
        Column6.Image = CType(resources.GetObject("Column6.Image"), Image)
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.Width = 50
        ' 
        ' btn_salvar
        ' 
        btn_salvar.BackColor = Color.FromArgb(0, 192, 0)
        btn_salvar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btn_salvar.Location = New Point(272, 156)
        btn_salvar.Name = "btn_salvar"
        btn_salvar.Size = New Size(102, 68)
        btn_salvar.TabIndex = 27
        btn_salvar.Text = "Salvar"
        btn_salvar.UseVisualStyleBackColor = False
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        label.Location = New Point(84, 97)
        label.Name = "label"
        label.Size = New Size(86, 19)
        label.TabIndex = 22
        label.Text = "Chave Pix"
        ' 
        ' txt_pix
        ' 
        txt_pix.Location = New Point(84, 118)
        txt_pix.Name = "txt_pix"
        txt_pix.Size = New Size(343, 23)
        txt_pix.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        Label2.Location = New Point(84, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 19)
        Label2.TabIndex = 20
        Label2.Text = "Nome do Cliente"
        ' 
        ' txt_telefone
        ' 
        txt_telefone.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txt_telefone.Location = New Point(332, 55)
        txt_telefone.Mask = "(99) 00000-0000"
        txt_telefone.Name = "txt_telefone"
        txt_telefone.Size = New Size(97, 25)
        txt_telefone.TabIndex = 19
        ' 
        ' txt_nome
        ' 
        txt_nome.Location = New Point(84, 55)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(214, 23)
        txt_nome.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        Label1.Location = New Point(332, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 19)
        Label1.TabIndex = 17
        Label1.Text = "Telefone"
        ' 
        ' btn_excluir
        ' 
        btn_excluir.BackColor = Color.Red
        btn_excluir.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btn_excluir.Location = New Point(115, 156)
        btn_excluir.Name = "btn_excluir"
        btn_excluir.Size = New Size(102, 68)
        btn_excluir.TabIndex = 29
        btn_excluir.Text = "Excluir"
        btn_excluir.UseVisualStyleBackColor = False
        ' 
        ' frm_cad_motoboy
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background
        ClientSize = New Size(513, 458)
        Controls.Add(btn_excluir)
        Controls.Add(dgv_motoboys)
        Controls.Add(btn_salvar)
        Controls.Add(label)
        Controls.Add(txt_pix)
        Controls.Add(Label2)
        Controls.Add(txt_telefone)
        Controls.Add(txt_nome)
        Controls.Add(Label1)
        Name = "frm_cad_motoboy"
        Text = "frm_cad_motoboy"
        CType(dgv_motoboys, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgv_motoboys As DataGridView
    Friend WithEvents btn_salvar As Button
    Friend WithEvents label As Label
    Friend WithEvents txt_pix As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_excluir As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
End Class
