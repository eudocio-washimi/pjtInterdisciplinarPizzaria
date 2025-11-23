Imports System.Drawing.Printing

Public Class frm_pedidos
    ' Variáveis Globais
    Dim total_produtos As Double = 0
    Dim total_final As Double = 0
    Dim id_cliente_atual As Integer = 0
    Dim endereco_original As String = ""
    Dim bairro_original As String = ""
    ' Variável para guardar o ID da venda para a nota
    Dim id_venda_recem_criada As Integer = 0

    ' Objeto de Impressão
    WithEvents pd As New PrintDocument

    Private Sub frm_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrid()
        CarregarCombosIniciais()
        ConfigurarAutocomplete()
        limpar_tela()
        Me.ActiveControl = txt_telefone
    End Sub

    Sub ConfigurarAutocomplete()
        cmb_produtos.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmb_produtos.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub

    Function TextoParaValor(texto As String) As Double
        If String.IsNullOrWhiteSpace(texto) Then Return 0
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

        ' Carrega Formas de Pagamento
        cmb_pagamento.Items.Clear()
        cmb_pagamento.Items.Add("DINHEIRO")
        cmb_pagamento.Items.Add("PIX")
        cmb_pagamento.Items.Add("CARTÃO DÉBITO")
        cmb_pagamento.Items.Add("CARTÃO CRÉDITO")
    End Sub

    Sub limpar_tela()
        txt_telefone.Clear()
        txt_nome_cliente.Clear()
        txt_endereco.Clear()
        txt_bairro.Clear()
        txt_taxa_entrega.Text = "00,00"

        dgv_itens.Rows.Clear()
        lbl_subtotal.Text = "R$ 0,00"
        lbl_total_final.Text = "R$ 0,00"

        cmb_pagamento.SelectedIndex = -1

        rdb_retirada.Checked = True
        id_cliente_atual = 0
        endereco_original = ""
        total_produtos = 0
        total_final = 0
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

                ' Carrega dados em MAIÚSCULO para garantir padrão
                If Not IsDBNull(rs.Fields("nome").Value) Then txt_nome_cliente.Text = rs.Fields("nome").Value.ToString().ToUpper()
                If Not IsDBNull(rs.Fields("endereco").Value) Then txt_endereco.Text = rs.Fields("endereco").Value.ToString().ToUpper()
                If Not IsDBNull(rs.Fields("bairro").Value) Then txt_bairro.Text = rs.Fields("bairro").Value.ToString().ToUpper()

                endereco_original = txt_endereco.Text
                bairro_original = txt_bairro.Text

                If Not IsDBNull(rs.Fields("taxa").Value) Then
                    Dim valTaxa As Double = rs.Fields("taxa").Value
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
                Dim nome As String = rs.Fields("nome").Value.ToString().ToUpper()
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
            Dim nome As String = partes(0).ToUpper()
            Dim preco As Double = CDbl(partes(1))
            Dim id As Integer = CInt(partes(2))
            Dim qtd As Integer = CInt(txt_qtd.Text)
            Dim total_item As Double = preco * qtd
            Dim tipo As String = cmb_tipo_produto.Text

            dgv_itens.Rows.Add(id, nome, qtd, preco, total_item, tipo)
            AtualizarCalculos()

            cmb_tipo_produto.SelectedIndex = -1
            cmb_produtos.Items.Clear()
            cmb_produtos.Text = ""
            txt_qtd.Text = ""
            cmb_tipo_produto.Focus()

        Catch ex As Exception
            MsgBox("Erro ao adicionar item.")
        End Try
    End Sub

    Sub AtualizarCalculos()
        total_produtos = 0
        For Each row As DataGridViewRow In dgv_itens.Rows
            If row.IsNewRow Then Continue For
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

    ' --- FINALIZAR E IMPRIMIR ---
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
        If cmb_pagamento.SelectedIndex = -1 Then
            MsgBox("Selecione a forma de pagamento!") : Exit Sub
        End If

        Try
            ' 1. Tenta Salvar/Atualizar Cliente
            ' Se o usuário disser NÃO, o banco não muda, mas os dados da tela continuam lá para a venda
            SalvarOuAtualizarCliente()

            Dim tipo_pedido As String = ""
            If rdb_entrega.Checked Then tipo_pedido = "ENTREGA"
            If rdb_retirada.Checked Then tipo_pedido = "RETIRADA"
            If rdb_salao.Checked Then tipo_pedido = "SALAO"

            Dim id_motoboy As String = "NULL"
            If rdb_entrega.Checked Then id_motoboy = Split(cmb_motoboy.Text, " | ")(1)

            Dim bairro As String = ""
            If rdb_entrega.Checked Then bairro = txt_bairro.Text.ToUpper()

            Dim totalStr As String = total_final.ToString("0.00").Replace(",", ".")
            Dim valTaxa As Double = 0
            If rdb_entrega.Checked Then valTaxa = TextoParaValor(txt_taxa_entrega.Text)
            Dim taxaStr As String = valTaxa.ToString("0.00").Replace(",", ".")

            Dim data_hj As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim forma_pagto As String = cmb_pagamento.Text.ToUpper()

            ' 2. Grava Venda
            sql = $"INSERT INTO tb_vendas (id_cliente, id_motoboy, data_venda, valor_total, taxa_entrega, tipo_pedido, bairro_entrega, forma_pagamento) " &
                  $"VALUES ({id_cliente_atual}, {id_motoboy}, '{data_hj}', {totalStr}, {taxaStr}, '{tipo_pedido}', '{bairro}', '{forma_pagto}')"
            db.Execute(sql)

            rs = db.Execute("SELECT MAX(id_venda) as ult FROM tb_vendas")
            id_venda_recem_criada = rs.Fields("ult").Value

            ' 3. Grava Itens
            For Each row As DataGridViewRow In dgv_itens.Rows
                If row.IsNewRow Then Continue For

                Dim id_prod As Integer = row.Cells("id").Value
                Dim qtd As Integer = row.Cells("qtd").Value
                Dim val_unit As String = CDbl(row.Cells("unitario").Value).ToString("0.00").Replace(",", ".")
                Dim tipo As String = row.Cells("tipo").Value

                sql = $"INSERT INTO tb_itens_venda (id_venda, id_produto, qtd, valor_unitario, tipo_produto) " &
                      $"VALUES ({id_venda_recem_criada}, {id_prod}, {qtd}, {val_unit}, '{tipo}')"
                db.Execute(sql)
            Next

            ' 4. Pergunta Impressão
            Dim resp = MsgBox($"Venda Nº {id_venda_recem_criada} Finalizada!" & vbNewLine & "Deseja imprimir a comanda?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
            If resp = MsgBoxResult.Yes Then
                pd.Print()
            End If

            limpar_tela()

        Catch ex As Exception
            MsgBox("Erro ao finalizar: " & ex.Message)
        End Try
    End Sub

    ' --- LÓGICA DE IMPRESSÃO (CORRIGIDA E ÚNICA) ---
    Private Sub pd_PrintPage(sender As Object, e As PrintPageEventArgs) Handles pd.PrintPage
        Try
            ' Configurações da Fonte
            Dim fonteNormal As New Font("Courier New", 9, FontStyle.Regular)
            Dim fonteNegrito As New Font("Courier New", 9, FontStyle.Bold)
            Dim fonteTitulo As New Font("Courier New", 12, FontStyle.Bold)

            Dim y As Integer = 10
            Dim larguraUtil As Integer = 280
            Dim margemEsq As Integer = 5

            Dim fmtCentro As New StringFormat()
            fmtCentro.Alignment = StringAlignment.Center

            Dim fmtEsq As New StringFormat()
            fmtEsq.Alignment = StringAlignment.Near

            ' Função para desenhar texto com quebra de linha automática (usando RectangleF)
            Dim PrintText = Sub(texto As String, fonte As Font, formato As StringFormat)
                                ' Converte texto para MAIÚSCULO na hora de imprimir
                                Dim textoUpper As String = texto.ToUpper()
                                Dim size As SizeF = e.Graphics.MeasureString(textoUpper, fonte, larguraUtil)
                                Dim rect As New RectangleF(margemEsq, y, larguraUtil, size.Height)
                                e.Graphics.DrawString(textoUpper, fonte, Brushes.Black, rect, formato)
                                y += CInt(size.Height)
                            End Sub

            ' --- CABEÇALHO ---
            PrintText("PIZZARIA GATO Q RICO", fonteTitulo, fmtCentro)
            PrintText("RUA DAS TURMALINAS, 123 - DIADEMA, CENTRO", fonteNormal, fmtCentro) ' Endereço da pizzaria

            PrintText("----------------------------------------", fonteNormal, fmtCentro)
            PrintText($"PEDIDO: #{id_venda_recem_criada}", fonteNegrito, fmtCentro)
            PrintText(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fonteNormal, fmtCentro)
            PrintText("----------------------------------------", fonteNormal, fmtCentro)

            ' --- DADOS DO CLIENTE ---
            PrintText($"CLIENTE: {txt_nome_cliente.Text}", fonteNegrito, fmtEsq)
            PrintText($"TEL: {txt_telefone.Text}", fonteNormal, fmtEsq)

            Dim tipo As String = ""
            If rdb_entrega.Checked Then tipo = "ENTREGA"
            If rdb_retirada.Checked Then tipo = "RETIRADA"
            If rdb_salao.Checked Then tipo = "SALÃO"

            PrintText($"TIPO: {tipo}", fonteNegrito, fmtEsq)

            If rdb_entrega.Checked Then
                ' IMPRESSÃO USA DADOS DA TELA (txt_endereco), independente se salvou no banco ou não
                Dim enderecoCompleto As String = $"{txt_endereco.Text}, {txt_bairro.Text}"
                PrintText(enderecoCompleto, fonteNormal, fmtEsq)

                If cmb_motoboy.SelectedIndex <> -1 Then
                    PrintText($"MOTOBOY: {Split(cmb_motoboy.Text, " | ")(0)}", fonteNormal, fmtEsq)
                End If
            End If

            PrintText("----------------------------------------", fonteNormal, fmtCentro)

            ' --- ITENS ---
            e.Graphics.DrawString("ITEM            QTD   UNIT    TOTAL", fonteNegrito, Brushes.Black, margemEsq, y)
            y += 15

            For Each row As DataGridViewRow In dgv_itens.Rows
                If row.IsNewRow Then Continue For

                Dim produto As String = If(row.Cells("produto").Value, "").ToString().ToUpper()
                If produto.Length > 15 Then produto = produto.Substring(0, 15)

                Dim qtd As String = If(row.Cells("qtd").Value, "0").ToString()
                Dim unitVal As Double = 0
                Double.TryParse(row.Cells("unitario").Value.ToString(), unitVal)
                Dim unit As String = unitVal.ToString("0.00")

                Dim totVal As Double = 0
                Double.TryParse(row.Cells("total").Value.ToString(), totVal)
                Dim tot As String = totVal.ToString("0.00")

                Dim linha As String = String.Format("{0,-15} {1,3} {2,6} {3,6}", produto, qtd, unit, tot)
                e.Graphics.DrawString(linha, fonteNormal, Brushes.Black, margemEsq, y)
                y += 15
            Next

            PrintText("----------------------------------------", fonteNormal, fmtCentro)

            ' --- TOTAIS ---
            PrintText($"SUBTOTAL:       {lbl_subtotal.Text}", fonteNormal, fmtEsq)

            If rdb_entrega.Checked Then
                PrintText($"TAXA ENTREGA:   {FormatCurrency(TextoParaValor(txt_taxa_entrega.Text))}", fonteNormal, fmtEsq)
            End If

            y += 5
            PrintText($"TOTAL FINAL:    {lbl_total_final.Text}", fonteTitulo, fmtEsq)

            PrintText($"PAGAMENTO:      {cmb_pagamento.Text}", fonteNormal, fmtEsq)
            y += 10

            ' Rodapé
            PrintText("OBRIGADO PELA PREFERÊNCIA!", fonteNormal, fmtCentro)

        Catch ex As Exception
            e.Graphics.DrawString("ERRO IMPRESSÃO: " & ex.Message, New Font("Arial", 8), Brushes.Red, 10, 10)
        End Try
    End Sub

    Sub SalvarOuAtualizarCliente()
        ' Converte tudo para maiúsculo antes de salvar
        Dim nome As String = txt_nome_cliente.Text.ToUpper()
        Dim fone As String = txt_telefone.Text
        Dim endereco As String = txt_endereco.Text.ToUpper()
        Dim bairro As String = txt_bairro.Text.ToUpper()

        Dim taxaVal As Double = TextoParaValor(txt_taxa_entrega.Text)
        Dim taxa_cli As String = taxaVal.ToString("0.00").Replace(",", ".")

        If id_cliente_atual > 0 Then
            If endereco <> endereco_original.ToUpper() And endereco_original <> "" Or bairro <> bairro_original.ToUpper() And bairro_original <> "" Then
                Dim resp = MsgBox("Endereço mudou. Atualizar cadastro definitivo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
                If resp = MsgBoxResult.Yes Then
                    ' Se SIM, atualiza o banco com o novo endereço
                    sql = $"UPDATE tb_clientes SET nome='{nome}', endereco='{endereco}', bairro='{bairro}', taxa={taxa_cli} WHERE id_cliente={id_cliente_atual}"
                    db.Execute(sql)
                Else
                    ' Se NÃO, não faz update de endereço no banco.
                    ' Mas o endereço novo continua na tela (txt_endereco) e será usado na impressão.
                End If
            Else
                ' Endereço igual, atualiza outros dados para garantir o UpperCase
                sql = $"UPDATE tb_clientes SET nome='{nome}', bairro='{bairro}', taxa={taxa_cli} WHERE id_cliente={id_cliente_atual}"
                db.Execute(sql)
            End If
        Else
            ' Novo Cliente
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