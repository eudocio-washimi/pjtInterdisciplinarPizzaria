Public Class frm_cad_produtos
    ' Variável para controlar se estamos editando (contém o ID) ou inserindo (vazio)
    Dim id_editando As String = ""

    Private Sub frm_cad_produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrid()

        ' Preenche o Combo via código para garantir os nomes corretos
        cmb_tipo_produto.Items.Clear()
        cmb_tipo_produto.Items.Add("Pizza")
        cmb_tipo_produto.Items.Add("Catito")
        cmb_tipo_produto.Items.Add("Bebida")
    End Sub

    Sub ConfigurarGrid()
        dgv_produtos.Columns.Clear()

        ' Colunas de Dados
        dgv_produtos.Columns.Add("id", "Cód")
        dgv_produtos.Columns("id").Width = 40
        dgv_produtos.Columns.Add("nome", "Nome do Produto")
        dgv_produtos.Columns("nome").Width = 200
        dgv_produtos.Columns.Add("preco", "Preço")
        dgv_produtos.Columns("preco").Width = 80

        ' Botão EDITAR
        Dim btnEditar As New DataGridViewButtonColumn()
        btnEditar.HeaderText = "Editar"
        btnEditar.Text = "Editar"
        btnEditar.UseColumnTextForButtonValue = True
        btnEditar.Name = "btn_editar"
        dgv_produtos.Columns.Add(btnEditar)

        ' Botão EXCLUIR
        Dim btnExcluir As New DataGridViewButtonColumn()
        btnExcluir.HeaderText = "Excluir"
        btnExcluir.Text = "X"
        btnExcluir.UseColumnTextForButtonValue = True
        btnExcluir.Name = "btn_excluir"
        btnExcluir.Width = 30
        dgv_produtos.Columns.Add(btnExcluir)
    End Sub

    Private Sub cmb_tipo_produto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_produto.SelectedIndexChanged
        limpar_campos() ' Limpa se trocar de tabela
        carregar_lista()
    End Sub

    Sub limpar_campos()
        txt_nome_prod.Clear()
        txt_preco_prod.Clear()
        id_editando = ""
        cmb_tipo_produto.Enabled = True ' Destrava o combo caso estivesse editando
    End Sub

    ' --- Funções Auxiliares para saber Tabela e Campo ID ---
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
        Return "id" ' Fallback
    End Function
    ' -------------------------------------------------------

    Sub carregar_lista()
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

                ' O campo ID (index 0) é pego genericamente
                dgv_produtos.Rows.Add(rs.Fields(0).Value, rs.Fields("nome").Value, preco)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Erro ao listar: " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_produtos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produtos.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim id_selecionado As String = dgv_produtos.Rows(e.RowIndex).Cells("id").Value.ToString()
        Dim tabela As String = ObterTabela(cmb_tipo_produto.Text)
        Dim campo_id As String = ObterCampoID(cmb_tipo_produto.Text)

        ' --- AÇÃO: EDITAR ---
        If dgv_produtos.Columns(e.ColumnIndex).Name = "btn_editar" Then
            txt_nome_prod.Text = dgv_produtos.Rows(e.RowIndex).Cells("nome").Value.ToString()

            ' Tira o R$ para jogar no textbox
            Dim preco_limpo As String = dgv_produtos.Rows(e.RowIndex).Cells("preco").Value.ToString()
            preco_limpo = preco_limpo.Replace("R$", "").Trim()
            txt_preco_prod.Text = preco_limpo

            id_editando = id_selecionado
            cmb_tipo_produto.Enabled = False ' Trava o combo para não misturar tabelas
        End If

        ' --- AÇÃO: EXCLUIR ---
        If dgv_produtos.Columns(e.ColumnIndex).Name = "btn_excluir" Then
            If MsgBox($"Deseja excluir o item {id_selecionado}?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = MsgBoxResult.Yes Then
                sql = $"DELETE FROM {tabela} WHERE {campo_id} = {id_selecionado}"
                db.Execute(sql)
                carregar_lista()
                MsgBox("Excluído!")
            End If
        End If
    End Sub

    Private Sub btn_salvar_prod_Click(sender As Object, e As EventArgs) Handles btn_salvar_prod.Click
        Try
            Dim tabela As String = ObterTabela(cmb_tipo_produto.Text)
            If tabela = "" Then
                MsgBox("Selecione o Tipo de Produto!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' Tratamento de preço
            Dim preco As String = txt_preco_prod.Text.Replace("R$", "").Trim()
            preco = preco.Replace(",", ".") ' Access SQL prefere ponto para decimais

            If id_editando = "" Then
                ' --- INSERIR NOVO ---
                sql = $"INSERT INTO {tabela} (nome, preco) VALUES ('{txt_nome_prod.Text}', {preco})"
                db.Execute(sql)
                MsgBox("Cadastrado com sucesso!")
            Else
                ' --- ATUALIZAR EXISTENTE ---
                Dim campo_id As String = ObterCampoID(cmb_tipo_produto.Text)
                sql = $"UPDATE {tabela} SET nome='{txt_nome_prod.Text}', preco={preco} WHERE {campo_id}={id_editando}"
                db.Execute(sql)
                MsgBox("Atualizado com sucesso!")
            End If

            limpar_campos()
            carregar_lista()

        Catch ex As Exception
            MsgBox("Erro ao gravar: " & ex.Message & vbNewLine & "SQL: " & sql, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub frm_cad_produtos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_menu.Show()
    End Sub
End Class