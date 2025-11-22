Public Class frm_pedidos
    ' Variáveis Globais
    Dim total_produtos As Double = 0
    Dim total_final As Double = 0
    Dim id_cliente_atual As Integer = 0
    Dim endereco_original As String = ""

    Private Sub frm_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrid()
        CarregarCombosIniciais()
        ConfigurarAutocomplete()
        limpar_tela()

        ' --- CORREÇÃO 1: FORÇA O FOCO NO TELEFONE AO ABRIR ---
        Me.ActiveControl = txt_telefone
    End Sub

    Sub ConfigurarAutocomplete()
        cmb_produtos.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmb_produtos.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub

    ' Função Blindada para Converter Texto em Dinheiro
    Function TextoParaValor(texto As String) As Double
        If String.IsNullOrWhiteSpace(texto) Then Return 0
        ' Remove R$, espaços e traços e troca ponto por vírgula
        Dim limpo As String = texto.Replace("R$", "").Replace(" ", "").Replace("_", "").Trim()
        limpo = limpo.Replace(".", ",")
        Try
            Return CDbl(limpo)
        Catch
            Return 0
        End Try
    End Function

    Sub ConfigurarGrid()
        dgv_itens.Columns.Clear()
        dgv_itens.Columns.Add("id", "Cód")
        dgv_itens.Columns("id").Width = 40
        dgv_itens.Columns.Add("produto", "Produto")
        dgv_itens.Columns("produto").Width = 200
        dgv_itens.Columns.Add("qtd", "Qtd")
        dgv_itens.Columns.Add("unitario", "Unit")
        dgv_itens.Columns.Add("total", "Total")
        dgv_itens.Columns.Add("tipo", "Tipo")
        dgv_itens.Columns("tipo").Visible = False
    End Sub

    Sub CarregarCombosIniciais()
        Try
            rs = db.Execute("SELECT * FROM tb_motoboys ORDER BY nome")
            cmb_motoboy.Items.Clear()
            While Not rs.EOF
                cmb_motoboy.Items.Add(rs.Fields("nome").Value & " | " & rs.Fields("id_motoboy").Value)
                rs.MoveNext()
            End While
        Catch : End Try

        cmb_tipo_produto.Items.Clear()
        cmb_tipo_produto.Items.Add("Pizza")
        cmb_tipo_produto.Items.Add("Catito")
        cmb_tipo_produto.Items.Add("Bebida")
    End Sub

    Sub limpar_tela()
        txt_telefone.Clear()
        txt_nome_cliente.Clear()
        txt_endereco.Clear()
        txt_bairro.Clear()
        txt_taxa_entrega.Text = "00,00" ' Valor inicial zerado com formatação

        dgv_itens.Rows.Clear()
        lbl_subtotal.Text = "R$ 0,00"
        lbl_total_final.Text = "R$ 0,00"

        rdb_retirada.Checked = True
        id_cliente_atual = 0
        endereco_original = ""
        total_produtos = 0
        total_final = 0

        ' Garante foco no telefone ao limpar (para o próximo pedido)
        txt_telefone.Select()
    End Sub

    ' --- BUSCA CLIENTE ---
    Private Sub txt_telefone_Leave(sender As Object, e As EventArgs) Handles txt_telefone.Leave
        If txt_telefone.Text = "" Then Exit Sub

        Try
            sql = $"SELECT * FROM tb_clientes WHERE fone = '{txt_telefone.Text}'"
            rs = db.Execute(sql)

            If Not rs.EOF Then
                id_cliente_atual = rs.Fields("id_cliente").Value

                If Not IsDBNull(rs.Fields("nome").Value) Then txt_nome_cliente.Text = rs.Fields("nome").Value
                If Not IsDBNull(rs.Fields("endereco").Value) Then txt_endereco.Text = rs.Fields("endereco").Value
                If Not IsDBNull(rs.Fields("bairro").Value) Then txt_bairro.Text = rs.Fields("bairro").Value

                endereco_original = txt_endereco.Text

                ' --- CORREÇÃO 2: FORMATAÇÃO DA TAXA COM ZERO À ESQUERDA ---
                If Not IsDBNull(rs.Fields("taxa").Value) Then
                    Dim valTaxa As Double = rs.Fields("taxa").Value
                    ' .ToString("00.00") força aparecer "08,00" em vez de "8,00"
                    txt_taxa_entrega.Text = valTaxa.ToString("00.00")
                Else
                    txt_taxa_entrega.Text = "00,00"
                End If
            Else
                id_cliente_atual = 0
                txt_nome_cliente.Clear()
                txt_endereco.Clear()
                txt_bairro.Clear()
                txt_taxa_entrega.Text = "00,00"
                endereco_original = ""

                If MsgBox("Cliente não encontrado. Cadastrar agora?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    txt_nome_cliente.Focus()
                Else
                    txt_telefone.Focus()
                End If
            End If

            AtualizarCalculos()
        Catch ex As Exception
            MsgBox("Erro ao buscar cliente: " & ex.Message)
        End Try
    End Sub

    ' --- INTERFACE ---
    Private Sub rdb_entrega_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_entrega.CheckedChanged
        AtualizarInterface()
    End Sub
    Private Sub rdb_retirada_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_retirada.CheckedChanged
        AtualizarInterface()
    End Sub
    Private Sub rdb_salao_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_salao.CheckedChanged
        AtualizarInterface()
    End Sub

    Sub AtualizarInterface()
        cmb_motoboy.Enabled = rdb_entrega.Checked
        txt_taxa_entrega.Enabled = rdb_entrega.Checked
        AtualizarCalculos()
    End Sub

    Private Sub txt_taxa_entrega_TextChanged(sender As Object, e As EventArgs) Handles txt_taxa_entrega.TextChanged
        AtualizarCalculos()
    End Sub

    ' --- PRODUTOS ---
    Private Sub cmb_tipo_produto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_produto.SelectedIndexChanged
        cmb_produtos.Items.Clear()
        cmb_produtos.Text = ""

        Dim tabela As String = ""
        Dim campo_id As String = ""

        If cmb_tipo_produto.Text = "Pizza" Then
            tabela = "tb_pizzas" : campo_id = "id_pizza"
        ElseIf cmb_tipo_produto.Text = "Catito" Then
            tabela = "tb_catitos" : campo_id = "id_catito"
        ElseIf cmb_tipo_produto.Text = "Bebida" Then
            tabela = "tb_bebidas" : campo_id = "id_bebida"
        Else
            Exit Sub
        End If

        Try
            sql = $"SELECT * FROM {tabela} ORDER BY nome"
            rs = db.Execute(sql)
            While Not rs.EOF
                Dim nome As String = rs.Fields("nome").Value
                Dim preco As Double = rs.Fields("preco").Value
                Dim id As Integer = rs.Fields(campo_id).Value
                cmb_produtos.Items.Add($"{nome} | {preco} | {id}")
                rs.MoveNext()
            End While
        Catch : End Try
    End Sub

    Private Sub btn_adicionar_Click(sender As Object, e As EventArgs) Handles btn_adicionar.Click
        If cmb_produtos.SelectedIndex = -1 Or txt_qtd.Text = "" Then
            MsgBox("Selecione produto e quantidade!")
            Exit Sub
        End If

        Try
            Dim partes() As String = Split(cmb_produtos.Text, " | ")
            Dim nome As String = partes(0)
            Dim preco As Double = CDbl(partes(1))
            Dim id As Integer = CInt(partes(2))
            Dim qtd As Integer = CInt(txt_qtd.Text)
            Dim total_item As Double = preco * qtd
            Dim tipo As String = cmb_tipo_produto.Text

            dgv_itens.Rows.Add(id, nome, qtd, preco, total_item, tipo)
            AtualizarCalculos()

            ' Limpar campos de produto
            cmb_tipo_produto.SelectedIndex = -1
            cmb_produtos.Items.Clear()
            cmb_produtos.Text = ""
            txt_qtd.Text = ""

            ' Opcional: foca no combo de tipo para agilizar próximo item
            cmb_tipo_produto.Focus()

        Catch ex As Exception
            MsgBox("Erro ao adicionar item.")
        End Try
    End Sub

    ' --- CÁLCULOS ---
    Sub AtualizarCalculos()
        total_produtos = 0
        For Each row As DataGridViewRow In dgv_itens.Rows
            total_produtos += CDbl(row.Cells("total").Value)
        Next

        Dim valor_taxa As Double = 0
        If rdb_entrega.Checked Then
            valor_taxa = TextoParaValor(txt_taxa_entrega.Text)
        End If

        total_final = total_produtos + valor_taxa

        lbl_subtotal.Text = FormatCurrency(total_produtos)
        lbl_total_final.Text = FormatCurrency(total_final)
    End Sub

    ' --- FINALIZAR ---
    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        If txt_telefone.Text = "" Or txt_nome_cliente.Text = "" Then
            MsgBox("Preencha dados do cliente!") : Exit Sub
        End If
        If dgv_itens.Rows.Count = 0 Then
            MsgBox("Pedido vazio!") : Exit Sub
        End If
        If rdb_entrega.Checked And cmb_motoboy.SelectedIndex = -1 Then
            MsgBox("Selecione motoboy!") : Exit Sub
        End If

        Try
            SalvarOuAtualizarCliente()

            Dim tipo_pedido As String = ""
            If rdb_entrega.Checked Then tipo_pedido = "Entrega"
            If rdb_retirada.Checked Then tipo_pedido = "Retirada"
            If rdb_salao.Checked Then tipo_pedido = "Salão"

            Dim id_motoboy As String = "NULL"
            If rdb_entrega.Checked Then id_motoboy = Split(cmb_motoboy.Text, " | ")(1)

            Dim totalStr As String = total_final.ToString("0.00").Replace(",", ".")

            Dim valTaxa As Double = 0
            If rdb_entrega.Checked Then valTaxa = TextoParaValor(txt_taxa_entrega.Text)
            Dim taxaStr As String = valTaxa.ToString("0.00").Replace(",", ".")

            Dim data_hj As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

            sql = $"INSERT INTO tb_vendas (id_cliente, id_motoboy, data_venda, valor_total, taxa_entrega, tipo_pedido) " &
                  $"VALUES ({id_cliente_atual}, {id_motoboy}, '{data_hj}', {totalStr}, {taxaStr}, '{tipo_pedido}')"
            db.Execute(sql)

            rs = db.Execute("SELECT MAX(id_venda) as ult FROM tb_vendas")
            Dim id_venda As Integer = rs.Fields("ult").Value

            For Each row As DataGridViewRow In dgv_itens.Rows
                Dim id_prod As Integer = row.Cells("id").Value
                Dim qtd As Integer = row.Cells("qtd").Value
                Dim val_unit As String = CDbl(row.Cells("unitario").Value).ToString("0.00").Replace(",", ".")
                Dim tipo As String = row.Cells("tipo").Value

                sql = $"INSERT INTO tb_itens_venda (id_venda, id_produto, qtd, valor_unitario, tipo_produto) " &
                      $"VALUES ({id_venda}, {id_prod}, {qtd}, {val_unit}, '{tipo}')"
                db.Execute(sql)
            Next

            MsgBox($"Venda Nº {id_venda} realizada!", MsgBoxStyle.Information)
            limpar_tela()

        Catch ex As Exception
            MsgBox("Erro ao finalizar: " & ex.Message)
        End Try
    End Sub

    Sub SalvarOuAtualizarCliente()
        Dim nome As String = txt_nome_cliente.Text
        Dim fone As String = txt_telefone.Text
        Dim endereco As String = txt_endereco.Text
        Dim bairro As String = txt_bairro.Text

        Dim taxaVal As Double = TextoParaValor(txt_taxa_entrega.Text)
        Dim taxa_cli As String = taxaVal.ToString("0.00").Replace(",", ".")

        If id_cliente_atual > 0 Then
            If endereco <> endereco_original And endereco_original <> "" Then
                Dim resp = MsgBox("Endereço mudou. Atualizar cadastro definitivo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
                If resp = MsgBoxResult.Yes Then
                    sql = $"UPDATE tb_clientes SET nome='{nome}', endereco='{endereco}', bairro='{bairro}', taxa={taxa_cli} WHERE id_cliente={id_cliente_atual}"
                Else
                    sql = $"UPDATE tb_clientes SET nome='{nome}', bairro='{bairro}' WHERE id_cliente={id_cliente_atual}"
                End If
            Else
                sql = $"UPDATE tb_clientes SET nome='{nome}', bairro='{bairro}', taxa={taxa_cli} WHERE id_cliente={id_cliente_atual}"
            End If
            db.Execute(sql)
        Else
            sql = $"INSERT INTO tb_clientes (nome, fone, endereco, bairro, taxa) VALUES ('{nome}', '{fone}', '{endereco}', '{bairro}', {taxa_cli})"
            db.Execute(sql)
            rs = db.Execute("SELECT MAX(id_cliente) as novo_id FROM tb_clientes")
            id_cliente_atual = rs.Fields("novo_id").Value
        End If
    End Sub

    Private Sub frm_pedidos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_menu.Show()
    End Sub
End Class