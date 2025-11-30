Module mod_global
    Public dir_banco = Application.StartupPath & "\banco\pizzariaGQR.mdb"
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public diretorio, sql, aux_cpf, resp As String  'Declaração de Variáveis
    Public cont As Integer

    Sub conectar_access()
        Try
            'db.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dir_banco)
            db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dir_banco)
            'MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

End Module
