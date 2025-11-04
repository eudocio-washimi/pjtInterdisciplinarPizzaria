Module mod_global
    Public dir_banco = Application.StartupPath & "\banco\pizzariaGQR.mdb"
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public diretorio, sql, aux_cpf, resp As String  'Declaração de Variáveis
    Public cont As Integer

    Sub conectar_access()
        Try
            ' 1. Removi o CreateObject. "As New" na declaração já cria a instância.
            ' 2. Mudei o Provider para o ACE.OLEDB.12.0
            db.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dir_banco)
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            ' Isso dará uma mensagem de erro mais útil
            MsgBox("Erro ao Conectar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub


End Module
