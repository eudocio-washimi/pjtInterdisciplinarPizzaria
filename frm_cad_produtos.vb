Public Class frm_cad_produtos
    Dim id_editando As String = ""

    Private Sub frm_cad_produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If cmb_tipo_produto.Items.Count = 0 Then
            cmb_tipo_produto.Items.Add("Pizza")
            cmb_tipo_produto.Items.Add("Catito")
            cmb_tipo_produto.Items.Add("Bebida")
        End If
    End Sub

    Function ObterTabela(tipo As String) As String
        If tipo = "Pizza" Then Return "tb_pizzas"
        If tipo = "Catito" Then Return "tb_catitos"
        If tipo = "Bebida" Then Return "tb_bebidas"
        Return ""
    End Function

    Function ObterCampoID(tipo As String) As String
        If tipo = "Pizza" Then Return "id_pizza"
        If tipo = "Catito" Then Return "id_catito"
        If tipo = "Bebida" Then Return "id_bebida"
        Return "id"
    End Function

    Private Sub cmb_tipo_produto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_produto.SelectedIndexChanged
        CarregarLista()
        limpar_campos()
    End Sub

    Sub CarregarLista()
        Try
            Dim tabela As String = ObterTabela(cmb_tipo_produto.Text)
            If tabela = "" Then Exit Sub

            sql = $"SELECT * FROM {tabela} ORDER BY nome"
            rs = db.Execute(sql)

            dgv_produtos.Rows.Clear()

            Do While Not rs.EOF
                Dim preco As String = "0,00"
                If Not IsDBNull(rs.Fields("preco").Value) Then
                    preco = FormatCurrency(rs.Fields("preco").Value)
                End If

                dgv_produtos.Rows.Add(rs.Fields(0).Value, rs.Fields("nome").Value, preco)
                rs.MoveNext()
            Loop
        Catch ex As Exception
        End Try
    End Sub

    Sub limpar_campos()
        txt_nome_prod.Clear()
        txt_preco_prod.Clear()
        id_editando = ""
        btn_salvar_prod.Text = "Salvar"
        cmb_tipo_produto.Enabled = True
    End Sub

    Private Sub btn_salvar_prod_Click(sender As Object, e As EventArgs) Handles btn_salvar_prod.Click
        Dim tabela As String = ObterTabela(cmb_tipo_produto.Text)

        If tabela = "" Then
            MsgBox("Selecione o Tipo de Produto!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If txt_nome_prod.Text = "" Or txt_preco_prod.Text = "" Then
            MsgBox("Preencha nome e preço!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Dim precoLimpo As String = txt_preco_prod.Text.Replace("R$", "").Replace(" ", "").Trim()
            Dim precoVal As Double = CDbl(precoLimpo)
            Dim precoSQL As String = precoVal.ToString("0.00").Replace(",", ".")

            If id_editando = "" Then
                sql = $"INSERT INTO {tabela} (nome, preco) VALUES ('{txt_nome_prod.Text}', {precoSQL})"
                db.Execute(sql)
                MsgBox("Produto cadastrado com sucesso!")
            Else
                Dim campoId As String = ObterCampoID(cmb_tipo_produto.Text)
                sql = $"UPDATE {tabela} SET nome='{txt_nome_prod.Text}', preco={precoSQL} WHERE {campoId}={id_editando}"
                db.Execute(sql)
                MsgBox("Produto atualizado com sucesso!")
            End If

            limpar_campos()
            CarregarLista()

        Catch ex As Exception
            MsgBox("Erro ao gravar: " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_produtos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produtos.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim id_selecionado As String = dgv_produtos.Rows(e.RowIndex).Cells("id").Value.ToString()
        Dim tabela As String = ObterTabela(cmb_tipo_produto.Text)
        Dim campoId As String = ObterCampoID(cmb_tipo_produto.Text)

        If dgv_produtos.Columns(e.ColumnIndex).Name = "btn_editar" Then
            txt_nome_prod.Text = dgv_produtos.Rows(e.RowIndex).Cells("nome").Value.ToString()

            Dim precoStr As String = dgv_produtos.Rows(e.RowIndex).Cells("preco").Value.ToString()
            txt_preco_prod.Text = precoStr.Replace("R$", "").Trim()

            id_editando = id_selecionado
            btn_salvar_prod.Text = "Salvar Alterações"

            cmb_tipo_produto.Enabled = False
        End If

        If dgv_produtos.Columns(e.ColumnIndex).Name = "btn_excluir" Then
            If MsgBox($"Excluir '{dgv_produtos.Rows(e.RowIndex).Cells("nome").Value}'?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = MsgBoxResult.Yes Then
                Try
                    db.Execute($"DELETE FROM {tabela} WHERE {campoId}={id_selecionado}")
                    CarregarLista()
                    limpar_campos()
                Catch ex As Exception
                    MsgBox("Erro ao excluir: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub txt_preco_prod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_preco_prod.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> ","c AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If
    End Sub
End Class