<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadclientes
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
        txt_fone = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txt_fone
        ' 
        txt_fone.Location = New Point(26, 78)
        txt_fone.Name = "txt_fone"
        txt_fone.Size = New Size(217, 23)
        txt_fone.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 18)
        Label1.TabIndex = 3
        Label1.Text = "Telefone"
        ' 
        ' frm_cadclientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(681, 377)
        Controls.Add(txt_fone)
        Controls.Add(Label1)
        Name = "frm_cadclientes"
        Text = "Cadastro de Clientes"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_fone As TextBox
    Friend WithEvents Label1 As Label
End Class
