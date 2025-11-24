Public Class frm_cad_fornecedores
    Dim id_editando As String = ""

    Private Sub frm_cad_fornecedores_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConfigurarGrid()
        CarregarLista()
    End Sub

    Sub ConfigurarGrid()
        dgv_fornecedores.Columns.Clear()
        dgv_fornecedores.Columns.Add("id", "ID")
        dgv_fornecedores.Columns("id").Width = 40
        dgv_fornecedores.Columns.Add("nome", "Nome")
        dgv_fornecedores.Columns("nome").Width = 200
        dgv_fornecedores.Columns.Add("tipo", "Tipo")

        Dim btnEditar As New DataGridViewButtonColumn()
        btnEditar.Name = "btn_editar"
        btnEditar.HeaderText = "Editar"
        btnEditar.Text = "Editar"
        btnEditar.UseColumnTextForButtonValue = True
        dgv_fornecedores.Columns.Add(btnEditar)

        Dim btnExcluir As New DataGridViewButtonColumn()
        btnExcluir.Name = "btn_excluir"
        btnExcluir.HeaderText = "Excluir"
        btnExcluir.Text = "X"
        btnExcluir.UseColumnTextForButtonValue = True
        btnExcluir.Width = 30
        dgv_fornecedores.Columns.Add(btnExcluir)
    End Sub

    Sub CarregarLista()
        Try
            sql = "SELECT * FROM tb_fornecedores ORDER BY nome"
            rs = db.Execute(sql)
            dgv_fornecedores.Rows.Clear()

            Do While Not rs.EOF
                dgv_fornecedores.Rows.Add(rs.Fields("id_fornecedor").Value, rs.Fields("nome").Value, rs.Fields("tipo").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Erro ao listar: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        If txt_nome.Text = "" Or cmb_tipo.Text = "" Then
            MsgBox("Preencha nome e tipo!")
            Exit Sub
        End If
        Try
            If id_editando = "" Then
                sql = $"INSERT INTO tb_fornecedores (nome, tipo) VALUES ('{txt_nome.Text}', `{cmb_tipo.Text}')"
            Else
                sql = $"UPDATE tb_fornecedores SET nome='{txt_nome.Text}', tipo='{cmb_tipo.Text}' WHERE id_fornecedor={id_editando}"
            End If

            db.Execute(sql)
            MsgBox("Salvo com sucesso!")

            txt_nome.Clear()
            cmb_tipo.SelectedIndex = -1
            id_editando = ""
            CarregarLista()
        Catch ex As Exception
            MsgBox("Erro ao salvar: " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_fornecedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_fornecedores.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim id As String = dgv_fornecedores.Rows(e.RowIndex).Cells("id").Value.ToString()

        If dgv_fornecedores.Columns(e.RowIndex).Name = "btn_editar" Then
            txt_nome.Text = dgv_fornecedores.Rows(e.RowIndex).Cells("nome").Value.ToString()
            cmb_tipo.Text = dgv_fornecedores.Rows(e.RowIndex).Cells("tipo").Value.ToString()
            id_editando = ""
        End If

        If dgv_fornecedores.Columns(e.ColumnIndex).Name = "btn_exluir" Then
            If MsgBox("Excluir este fornecedor?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = MsgBoxResult.Yes Then
                db.Execute($"DELETE FROM tb_fornecedores WHERE id_fornecedor = {id}")
                CarregarLista()
            End If
        End If
    End Sub

    Private Sub frm_cad_fornecedores_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_menu.Show()
    End Sub

    Private Sub cmb_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo.SelectedIndexChanged

    End Sub
End Class