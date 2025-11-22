Public Class frm_cad_motoboy
    Private Sub frm_cad_motoboy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_access()
        ConfigurarGrid()
        carregar_motoboys()
    End Sub

    Sub ConfigurarGrid()
        dgv_motoboys.Columns.Clear()
        ' Adiciona colunas de dados
        dgv_motoboys.Columns.Add("id", "ID")
        dgv_motoboys.Columns.Add("nome", "Nome")
        dgv_motoboys.Columns.Add("telefone", "Telefone")
        dgv_motoboys.Columns.Add("pix", "Chave Pix")

        ' Adiciona colunas de Botão
        Dim btnEditar As New DataGridViewButtonColumn()
        btnEditar.HeaderText = "Editar"
        btnEditar.Text = "Editar"
        btnEditar.UseColumnTextForButtonValue = True
        btnEditar.Name = "btn_editar"
        dgv_motoboys.Columns.Add(btnEditar)

        Dim btnExcluir As New DataGridViewButtonColumn()
        btnExcluir.HeaderText = "Excluir"
        btnExcluir.Text = "X"
        btnExcluir.UseColumnTextForButtonValue = True
        btnExcluir.Name = "btn_excluir"
        dgv_motoboys.Columns.Add(btnExcluir)
    End Sub

    Sub carregar_motoboys()
        Try
            sql = "SELECT * FROM tb_motoboys ORDER BY nome"
            rs = db.Execute(sql)
            dgv_motoboys.Rows.Clear()
            Do While Not rs.EOF
                dgv_motoboys.Rows.Add(rs.Fields("id_motoboy").Value, rs.Fields("nome").Value, rs.Fields("telefone").Value, rs.Fields("pix").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Erro ao listar: " & ex.Message)
        End Try
    End Sub

    ' Lógica dos Botões Editar e Excluir
    Private Sub dgv_motoboys_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_motoboys.CellContentClick
        ' Verifica se clicou na linha válida
        If e.RowIndex < 0 Then Exit Sub

        Dim id As String = dgv_motoboys.Rows(e.RowIndex).Cells("id").Value.ToString()

        ' --- Lógica do EDITAR ---
        If dgv_motoboys.Columns(e.ColumnIndex).Name = "btn_editar" Then
            txt_nome.Text = dgv_motoboys.Rows(e.RowIndex).Cells("nome").Value.ToString()
            txt_telefone.Text = dgv_motoboys.Rows(e.RowIndex).Cells("telefone").Value.ToString()
            txt_pix.Text = dgv_motoboys.Rows(e.RowIndex).Cells("pix").Value.ToString()
            ' Dica: Você pode usar uma variável global 'id_editando' para saber que é um update ao clicar em Salvar
            Tag = id ' Usamos a propriedade Tag do formulário para guardar o ID temporariamente
        End If

        ' --- Lógica do EXCLUIR ---
        If dgv_motoboys.Columns(e.ColumnIndex).Name = "btn_excluir" Then
            If MsgBox("Tem certeza que deseja excluir?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = MsgBoxResult.Yes Then
                db.Execute($"DELETE FROM tb_motoboys WHERE id_motoboy = {id}")
                carregar_motoboys()
                MsgBox("Excluído!")
            End If
        End If
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            If Tag Is Nothing OrElse Tag.ToString() = "" Then
                ' INSERT (Novo)
                sql = $"INSERT INTO tb_motoboys (nome, telefone, pix) VALUES ('{txt_nome.Text}', '{txt_telefone.Text}', '{txt_pix.Text}')"
            Else
                ' UPDATE (Editando)
                sql = $"UPDATE tb_motoboys SET nome='{txt_nome.Text}', telefone='{txt_telefone.Text}', pix='{txt_pix.Text}' WHERE id_motoboy={Tag}"
                Tag = "" ' Limpa o ID após editar
            End If

            db.Execute(sql)
            MsgBox("Salvo com sucesso!")
            txt_nome.Clear()
            txt_telefone.Clear()
            txt_pix.Clear()
            carregar_motoboys()
        Catch ex As Exception
            MsgBox("Erro ao gravar: " & ex.Message)
        End Try
    End Sub

    Private Sub frm_cad_motoboy_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_menu.Show()
    End Sub
End Class