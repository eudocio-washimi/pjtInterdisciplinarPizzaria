Public Class frm_reservas
    Dim id_cliente_selecionado As Integer = 0
    Dim id_editando As String = "" ' Controle de edição

    Private Sub frm_reservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrid()

        ' Configura datas iniciais
        dtp_filtro.Value = Date.Now
        dtp_data.Value = Date.Now
        dtp_hora.Value = DateTime.Today.AddHours(18) ' Padrão 18:00

        CarregarReservas()
        limpar_campos()
    End Sub

    Sub ConfigurarGrid()
        dgv_reservas.Columns.Clear()

        dgv_reservas.Columns.Add("id", "ID")
        dgv_reservas.Columns("id").Width = 40

        dgv_reservas.Columns.Add("data_hora", "Data/Hora")
        dgv_reservas.Columns("data_hora").Width = 120

        dgv_reservas.Columns.Add("cliente", "Cliente")
        dgv_reservas.Columns("cliente").Width = 150

        dgv_reservas.Columns.Add("pessoas", "Pessoas")
        dgv_reservas.Columns("pessoas").Width = 60

        dgv_reservas.Columns.Add("status", "Status")
        dgv_reservas.Columns("status").Width = 80

        dgv_reservas.Columns.Add("obs", "Obs")
        dgv_reservas.Columns("obs").Width = 150

        ' Coluna Oculta para ajudar na edição (guardar ID cliente original)
        dgv_reservas.Columns.Add("id_cli", "ID_Cli")
        dgv_reservas.Columns("id_cli").Visible = False

        ' Botão Editar
        Dim btnEditar As New DataGridViewButtonColumn()
        btnEditar.Name = "btn_editar"
        btnEditar.HeaderText = "Editar"
        btnEditar.Text = "Editar"
        btnEditar.UseColumnTextForButtonValue = True
        dgv_reservas.Columns.Add(btnEditar)

        ' Botão Cancelar
        Dim btnCancelar As New DataGridViewButtonColumn()
        btnCancelar.Name = "btn_cancelar"
        btnCancelar.HeaderText = "Ação"
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseColumnTextForButtonValue = True
        dgv_reservas.Columns.Add(btnCancelar)
    End Sub

    Sub limpar_campos()
        txt_telefone_cliente.Clear()
        lbl_nome_cliente.Text = "Cliente: ..."
        lbl_nome_cliente.ForeColor = Color.Black
        id_cliente_selecionado = 0
        id_editando = ""

        txt_obs.Clear()
        nud_pessoas.Value = 2

        dtp_data.Value = Date.Now
        dtp_hora.Value = DateTime.Today.AddHours(18)

        btn_agendar.Text = "Confirmar Reserva"
        txt_telefone_cliente.Enabled = True ' Destrava caso estivesse editando
    End Sub

    ' --- 1. BUSCA CLIENTE ---
    Private Sub txt_telefone_cliente_Leave(sender As Object, e As EventArgs) Handles txt_telefone_cliente.Leave
        If txt_telefone_cliente.Text = "" Then Exit Sub

        Try
            sql = $"SELECT * FROM tb_clientes WHERE fone = '{txt_telefone_cliente.Text}'"
            rs = db.Execute(sql)

            If rs.EOF Then
                lbl_nome_cliente.Text = "Não encontrado"
                lbl_nome_cliente.ForeColor = Color.Red
                id_cliente_selecionado = 0
                MsgBox("Cliente não cadastrado! Cadastre-o antes de reservar.")
            Else
                id_cliente_selecionado = rs.Fields("id_cliente").Value
                lbl_nome_cliente.Text = "Cliente: " & rs.Fields("nome").Value
                lbl_nome_cliente.ForeColor = Color.Blue
            End If
        Catch ex As Exception
            MsgBox("Erro ao buscar cliente: " & ex.Message)
        End Try
    End Sub

    ' --- 2. VALIDAÇÃO E AGENDAMENTO ---
    Private Sub btn_agendar_Click(sender As Object, e As EventArgs) Handles btn_agendar.Click
        If id_cliente_selecionado = 0 Then
            MsgBox("Selecione um cliente válido pelo telefone!")
            Exit Sub
        End If

        ' Data e Hora Combinadas
        Dim dataReserva As DateTime = dtp_data.Value.Date + dtp_hora.Value.TimeOfDay

        ' --- REGRA 1: NÃO AGENDAR NO PASSADO ---
        If dataReserva < Date.Now Then
            MsgBox("A data/hora da reserva deve ser futura!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' --- REGRA 2: SEGUNDA-FEIRA FECHADO ---
        If dataReserva.DayOfWeek = DayOfWeek.Monday Then
            MsgBox("A pizzaria não abre às segundas-feiras!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' --- REGRA 3: HORÁRIO DE FUNCIONAMENTO ---
        Dim hora As TimeSpan = dataReserva.TimeOfDay
        Dim abertura As TimeSpan = New TimeSpan(18, 0, 0) ' 18:00
        Dim fechamento As TimeSpan

        ' Sexta (5) e Sábado (6) fecha 23:30, outros dias 22:30
        If dataReserva.DayOfWeek = DayOfWeek.Friday Or dataReserva.DayOfWeek = DayOfWeek.Saturday Then
            fechamento = New TimeSpan(23, 30, 0)
        Else
            fechamento = New TimeSpan(22, 30, 0)
        End If

        If hora < abertura Or hora > fechamento Then
            MsgBox($"Horário inválido! Hoje funcionamos das {abertura:hh\:mm} às {fechamento:hh\:mm}.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Dim dataSql As String = dataReserva.ToString("yyyy-MM-dd HH:mm:ss")

            If id_editando = "" Then
                ' --- INSERIR NOVA ---
                sql = $"INSERT INTO tb_reservas (id_cliente, data_reserva, qtd_pessoas, status, observacao) " &
                      $"VALUES ({id_cliente_selecionado}, '{dataSql}', {nud_pessoas.Value}, 'Agendada', '{txt_obs.Text}')"
                db.Execute(sql)
                MsgBox("Reserva Confirmada!")
            Else
                ' --- ATUALIZAR EXISTENTE ---
                ' Nota: id_cliente também é atualizado caso tenha trocado o telefone
                sql = $"UPDATE tb_reservas SET id_cliente={id_cliente_selecionado}, data_reserva='{dataSql}', " &
                      $"qtd_pessoas={nud_pessoas.Value}, observacao='{txt_obs.Text}' WHERE id_reserva={id_editando}"
                db.Execute(sql)
                MsgBox("Reserva atualizada com sucesso!")
            End If

            limpar_campos()
            CarregarReservas()

        Catch ex As Exception
            MsgBox("Erro ao salvar reserva: " & ex.Message)
        End Try
    End Sub

    ' --- 3. LISTAR ---
    Private Sub btn_filtrar_Click(sender As Object, e As EventArgs) Handles btn_filtrar.Click
        CarregarReservas()
    End Sub

    Sub CarregarReservas()
        Try
            Dim dia As String = dtp_filtro.Value.ToString("MM/dd/yyyy")

            ' Traz também o telefone e id_cliente para facilitar a edição
            sql = "SELECT r.id_reserva, r.data_reserva, c.nome, c.fone, c.id_cliente, r.qtd_pessoas, r.status, r.observacao " &
                  "FROM tb_reservas r INNER JOIN tb_clientes c ON r.id_cliente = c.id_cliente " &
                  $"WHERE r.data_reserva BETWEEN #{dia} 00:00:00# AND #{dia} 23:59:59# " &
                  "ORDER BY r.data_reserva"

            rs = db.Execute(sql)
            dgv_reservas.Rows.Clear()

            While Not rs.EOF
                Dim dataDb As DateTime = rs.Fields("data_reserva").Value

                dgv_reservas.Rows.Add(
                    rs.Fields("id_reserva").Value,
                    dataDb.ToString("dd/MM HH:mm"),
                    rs.Fields("nome").Value,
                    rs.Fields("qtd_pessoas").Value,
                    rs.Fields("status").Value,
                    rs.Fields("observacao").Value,
                    rs.Fields("id_cliente").Value ' Coluna oculta
                )

                ' Guarda o telefone na Tag da linha para recuperar fácil na edição
                dgv_reservas.Rows(dgv_reservas.Rows.Count - 1).Tag = rs.Fields("fone").Value

                rs.MoveNext()
            End While

        Catch ex As Exception
        End Try
    End Sub

    ' --- 4. AÇÕES DO GRID (EDITAR / CANCELAR) ---
    Private Sub dgv_reservas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_reservas.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim id_reserva As String = dgv_reservas.Rows(e.RowIndex).Cells("id").Value.ToString()

        ' --- EDITAR ---
        If dgv_reservas.Columns(e.ColumnIndex).Name = "btn_editar" Then
            Dim status As String = dgv_reservas.Rows(e.RowIndex).Cells("status").Value.ToString()
            If status = "Cancelada" Then
                MsgBox("Não é possível editar reservas canceladas.")
                Exit Sub
            End If

            ' Preenche campos
            Dim dataGrid As String = dgv_reservas.Rows(e.RowIndex).Cells("data_hora").Value.ToString()
            ' Reconverte string dd/MM HH:mm para Data completa (usando o ano do filtro ou atual)
            ' Truque simples: Pega a data exata do banco se possível, ou remonta
            ' Como temos dia/mês, assumimos ano atual.
            Try
                Dim dataHora As DateTime = DateTime.ParseExact(dataGrid, "dd/MM HH:mm", System.Globalization.CultureInfo.InvariantCulture)
                ' Ajusta para o ano atual, pois ParseExact pode pegar ano corrente
                dtp_data.Value = New DateTime(Date.Now.Year, dataHora.Month, dataHora.Day)
                dtp_hora.Value = dataHora
            Catch
                dtp_data.Value = Date.Now
            End Try

            nud_pessoas.Value = CInt(dgv_reservas.Rows(e.RowIndex).Cells("pessoas").Value)
            txt_obs.Text = dgv_reservas.Rows(e.RowIndex).Cells("obs").Value.ToString()

            ' Recupera cliente
            id_cliente_selecionado = CInt(dgv_reservas.Rows(e.RowIndex).Cells("id_cli").Value)
            lbl_nome_cliente.Text = "Cliente: " & dgv_reservas.Rows(e.RowIndex).Cells("cliente").Value.ToString()
            lbl_nome_cliente.ForeColor = Color.Blue

            ' Recupera telefone da TAG (guardado no CarregarReservas)
            If dgv_reservas.Rows(e.RowIndex).Tag IsNot Nothing Then
                txt_telefone_cliente.Text = dgv_reservas.Rows(e.RowIndex).Tag.ToString()
            End If

            id_editando = id_reserva
            btn_agendar.Text = "Salvar Alterações"
        End If

        ' --- CANCELAR ---
        If dgv_reservas.Columns(e.ColumnIndex).Name = "btn_cancelar" Then
            Dim statusAtual As String = dgv_reservas.Rows(e.RowIndex).Cells("status").Value.ToString()

            If statusAtual = "Cancelada" Then
                MsgBox("Esta reserva já está cancelada.")
                Exit Sub
            End If

            If MsgBox("Deseja realmente cancelar esta reserva?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                db.Execute($"UPDATE tb_reservas SET status='Cancelada' WHERE id_reserva={id_reserva}")
                CarregarReservas()
                If id_editando = id_reserva Then limpar_campos() ' Limpa se estava editando ela
            End If
        End If
    End Sub

    ' Botão auxiliar para cancelar edição (Crie esse botão no form se quiser)
    Private Sub btn_limpar_Click(sender As Object, e As EventArgs)
        limpar_campos()
    End Sub

    Private Sub frm_reservas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_menu.Show()
    End Sub
End Class