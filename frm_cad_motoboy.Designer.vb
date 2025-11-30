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
        id = New DataGridViewTextBoxColumn()
        nome = New DataGridViewTextBoxColumn()
        telefone = New DataGridViewTextBoxColumn()
        pix = New DataGridViewTextBoxColumn()
        btn_editar = New DataGridViewImageColumn()
        btn_excluir = New DataGridViewImageColumn()
        btn_salvar = New Button()
        label = New Label()
        txt_pix = New TextBox()
        Label2 = New Label()
        txt_telefone = New MaskedTextBox()
        txt_nome = New TextBox()
        Label1 = New Label()
        CType(dgv_motoboys, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_motoboys
        ' 
        dgv_motoboys.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv_motoboys.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_motoboys.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_motoboys.Columns.AddRange(New DataGridViewColumn() {id, nome, telefone, pix, btn_editar, btn_excluir})
        dgv_motoboys.Location = New Point(12, 244)
        dgv_motoboys.Name = "dgv_motoboys"
        dgv_motoboys.RowHeadersWidth = 62
        dgv_motoboys.ShowCellErrors = False
        dgv_motoboys.Size = New Size(488, 193)
        dgv_motoboys.TabIndex = 28
        ' 
        ' id
        ' 
        id.HeaderText = "ID"
        id.Name = "id"
        ' 
        ' nome
        ' 
        nome.HeaderText = "Nome"
        nome.MinimumWidth = 8
        nome.Name = "nome"
        ' 
        ' telefone
        ' 
        telefone.HeaderText = "Telefone"
        telefone.MinimumWidth = 8
        telefone.Name = "telefone"
        ' 
        ' pix
        ' 
        pix.HeaderText = "Chave Pix"
        pix.MinimumWidth = 8
        pix.Name = "pix"
        ' 
        ' btn_editar
        ' 
        btn_editar.HeaderText = "Editar"
        btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), Image)
        btn_editar.MinimumWidth = 8
        btn_editar.Name = "btn_editar"
        ' 
        ' btn_excluir
        ' 
        btn_excluir.HeaderText = "Deletar"
        btn_excluir.Image = CType(resources.GetObject("btn_excluir.Image"), Image)
        btn_excluir.MinimumWidth = 8
        btn_excluir.Name = "btn_excluir"
        ' 
        ' btn_salvar
        ' 
        btn_salvar.BackColor = Color.FromArgb(CByte(253), CByte(109), CByte(44))
        btn_salvar.FlatStyle = FlatStyle.Flat
        btn_salvar.Font = New Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_salvar.Location = New Point(206, 157)
        btn_salvar.Name = "btn_salvar"
        btn_salvar.Size = New Size(102, 68)
        btn_salvar.TabIndex = 27
        btn_salvar.Text = "Salvar"
        btn_salvar.UseVisualStyleBackColor = False
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Font = New Font("Arial", 12F, FontStyle.Bold)
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
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label2.Location = New Point(84, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 19)
        Label2.TabIndex = 20
        Label2.Text = "Nome do Cliente"
        ' 
        ' txt_telefone
        ' 
        txt_telefone.Font = New Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label1.Location = New Point(332, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 19)
        Label1.TabIndex = 17
        Label1.Text = "Telefone"
        ' 
        ' frm_cad_motoboy
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(95), CByte(99), CByte(104))
        ClientSize = New Size(513, 458)
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
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents telefone As DataGridViewTextBoxColumn
    Friend WithEvents pix As DataGridViewTextBoxColumn
    Friend WithEvents btn_editar As DataGridViewImageColumn
    Friend WithEvents btn_excluir As DataGridViewImageColumn
End Class
