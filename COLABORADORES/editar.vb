Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports System.Net
Imports Microsoft.Office.Interop
Public Class editar
#Region "CARREGA DADOS"
    Dim dados As New DADOS.conecxao
    Dim dsColaborador As DataSet
    Friend colaboradores As colaboradores
    Public Sub carregaDados(ByVal ds As DataSet)
        Me.dsColaborador = ds
        'NOME DOS colaboradores
        Me.txtNome.DataBindings.Add(New Binding("Text", ds, "colaboradores.NOME"))
        Me.txtSobreNome.DataBindings.Add(New Binding("Text", ds, "colaboradores.SOBRENOME"))
        'DATA DE NASCIMENTO
        Me.dtNascimento.DataBindings.Add(New Binding("Text", ds, "colaboradores.DATA_NASCIMENTO"))
        Me.cbSexo.DataBindings.Add(New Binding("Text", ds, "colaboradores.SEXO"))
        'ENDEREÇO
        Me.txtRua.DataBindings.Add(New Binding("Text", ds, "colaboradores.LOGRADOURO"))
        Me.txtNomeRua.DataBindings.Add(New Binding("Text", ds, "colaboradores.RUA"))
        Me.txtNumero.DataBindings.Add(New Binding("Text", ds, "colaboradores.NUMERO"))
        Me.txtComplemento.DataBindings.Add(New Binding("Text", ds, "colaboradores.COMPLEMENTO"))
        Me.txtBairro.DataBindings.Add(New Binding("Text", ds, "colaboradores.BAIRRO"))
        Me.txtCEP.DataBindings.Add(New Binding("Text", ds, "colaboradores.CEP"))
        Me.txtCidade.DataBindings.Add(New Binding("Text", ds, "colaboradores.CIDADE"))
        Me.txtEstado.DataBindings.Add(New Binding("Text", ds, "colaboradores.ESTADO"))
        'TELEFONE
        Me.txtDDDRES.DataBindings.Add(New Binding("Text", ds, "colaboradores.DDDRES"))
        Me.txtTELRES.DataBindings.Add(New Binding("Text", ds, "colaboradores.TELRES"))
        Me.txtdddCEL.DataBindings.Add(New Binding("Text", ds, "colaboradores.DDDCEL"))
        Me.txttelCEL.DataBindings.Add(New Binding("Text", ds, "colaboradores.CELRES"))
        Me.txtddCelParticular.DataBindings.Add(New Binding("Text", ds, "colaboradores.DDDCELPARTICULAR"))
        Me.txtCelParticular.DataBindings.Add(New Binding("Text", ds, "colaboradores.CELPARTICULAR"))
        'BANCO
        Me.cbBanco.DataBindings.Add(New Binding("Text", ds, "colaboradores.BANCO"))
        Me.txtAgemcia.DataBindings.Add(New Binding("Text", ds, "colaboradores.AGENCIA"))
        Me.txtConta.DataBindings.Add(New Binding("Text", ds, "colaboradores.CONTA"))
        Me.txtDigitoConta.DataBindings.Add(New Binding("Text", ds, "colaboradores.DIGITOCONTA"))
        'NATURALIDADE
        Me.txtNaturalidade.DataBindings.Add(New Binding("Text", ds, "colaboradores.CIDADENATURAL"))
        Me.txtEstadoNaturalidade.DataBindings.Add(New Binding("Text", ds, "colaboradores.ESTADONATURAL"))
        'FILIAÇÃO
        Me.txtNomePai.DataBindings.Add(New Binding("Text", ds, "colaboradores.NOMEPAI"))
        Me.txtNomeMae.DataBindings.Add(New Binding("Text", ds, "colaboradores.NOMEMAE"))
        'DOCUMENTOS
        Me.txtCTPS.DataBindings.Add(New Binding("Text", ds, "colaboradores.CTPS"))
        Me.txtPIS.DataBindings.Add(New Binding("Text", ds, "colaboradores.PIS"))
        Me.txtCPF.DataBindings.Add(New Binding("Text", ds, "colaboradores.CPF"))
        Me.txtRG.DataBindings.Add(New Binding("Text", ds, "colaboradores.RG"))
        Me.txtRgEmisao.DataBindings.Add(New Binding("Text", ds, "colaboradores.RG_EMISSAO"))
        Me.txtReservista.DataBindings.Add(New Binding("Text", ds, "colaboradores.RESERVISTA"))
        Me.txtTituloeleitoral.DataBindings.Add(New Binding("Text", ds, "colaboradores.TITULO_ELEITORAL"))
        Me.txtZona.DataBindings.Add(New Binding("Text", ds, "colaboradores.TITULO_ZONA"))
        Me.txtSecao.DataBindings.Add(New Binding("Text", ds, "colaboradores.TITULO_SECAO"))
        'MATRICULA
        Me.txtMatricula.DataBindings.Add(New Binding("Text", ds, "colaboradores.MATRICULA"))
        Me.cbContrato.DataBindings.Add(New Binding("Text", ds, "colaboradores.CONTRATO"))
        Me.txtEfetivo.DataBindings.Add(New Binding("Text", ds, "colaboradores.EFETIVO"))
        Me.txtCliente.DataBindings.Add(New Binding("Text", ds, "colaboradores.CLIENTE"))
        Me.dtadmissao.DataBindings.Add(New Binding("Text", ds, "colaboradores.ADMISSAO"))
        Me.cbSemanTrabalho.DataBindings.Add(New Binding("Text", ds, "colaboradores.SEMANA_TRABALHO"))
        Me.cbHoraTrabalho.DataBindings.Add(New Binding("Text", ds, "colaboradores.HORARIO_TRABALHO"))
        Me.cbCargo.DataBindings.Add(New Binding("Text", ds, "colaboradores.CARGO"))
        Me.cbSetor.DataBindings.Add(New Binding("Text", ds, "colaboradores.SETOR"))
        Me.txtLivro.DataBindings.Add(New Binding("Text", ds, "colaboradores.LIVRO"))
        Me.txtFolha.DataBindings.Add(New Binding("Text", ds, "colaboradores.FOLHA"))
        Me.cbSalario.DataBindings.Add(New Binding("Text", ds, "colaboradores.SALARIO"))
        Me.dtDemissao.DataBindings.Add(New Binding("Text", ds, "colaboradores.DEMISSAO"))
        Me.dtAso.DataBindings.Add(New Binding("Text", ds, "colaboradores.ASO"))
        Me.txtInfoAicional.DataBindings.Add(New Binding("Text", ds, "colaboradores.INFO_ADICIONAL"))
        'FOTO
        Me.lblfoto.DataBindings.Add(New Binding("Text", ds, "colaboradores.ID"))
        'AQUI VAI AS IMAGENS DAS CÓPIAS DOS DOCUMENTOS
    End Sub
    Private Sub cbSetor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSetor.Click
        Try
            Dim ds As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim conn As MySqlConnection = dados.GetConnection()
            Dim sql As String = "select SETOR from Setor order by setor"
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            cbSetor.Items.Clear()
            adptr.Fill(ds, "SETOR")
            dt = ds.Tables(0)
            For Each dr In dt.Rows
                cbSetor.Items.Add(dr.Item("SETOR"))
            Next
            dados.strConn.Close()
        Finally
            dados.strConn.Close()
        End Try
    End Sub
    Private Sub cbSalario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSalario.Click
        Try
            Dim ds As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim conn As MySqlConnection = dados.GetConnection()
            Dim sql As String = "select SALARIO from SALARIO order by SALARIO"
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            cbSalario.Items.Clear()
            adptr.Fill(ds, "SALARIO")
            dt = ds.Tables(0)
            For Each dr In dt.Rows
                cbSalario.Items.Add(dr.Item("SALARIO"))
            Next
            dados.strConn.Close()
        Finally
            dados.strConn.Close()
        End Try
    End Sub
#End Region
#Region "LISTA CLIENTE"
    Sub listaCliente()
        txtCliente.UseWaitCursor = True
        Try
            Dim ds As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim conn As MySqlConnection = dados.GetConnection()
            Dim sql As String = "Select * from clientes order by NOME_FANTAZIA"
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            txtCliente.Items.Clear()
            adptr.Fill(ds, "NOME_FANTAZIA")
            dt = ds.Tables(0)
            For Each dr In dt.Rows
                txtCliente.Items.Add(dr.Item("NOME_FANTAZIA"))
            Next
            dados.strConn.Close()
        Finally
            dados.strConn.Close()
            txtCliente.UseWaitCursor = False
        End Try
    End Sub
#End Region
#Region "SALVA COLABORADOR"
    Public Sub SalvaColaborador(ByVal ds As DataSet)
        If txtNome.TextLength <= 0 Then
            MsgBox("NÃO ESQUEÇA DE DIGITAR O NOME DO COLABORADOR")
            Return
        End If
        If txtSobreNome.TextLength <= 0 Then
            MsgBox("NÃO ESQUEÇA DE DIGITAR O SOBRENOME DO COLABORADOR")
            Return
        End If
        tbDocumentos.Visible = True
        If txtCPF.Text = "   .   .   -" Then
            MsgBox("NÃO ESQUEÇA DE DIGITAR DIGITE O CPF DO COLABORADOR")
            Return
        End If
        tbMatricula.Visible = True
        If txtEfetivo.Text = "" Then
            MsgBox("SELECIONE O CAMPO EFETIVO NA ABA MATRÍCULA ")
            Return
        End If
        Dim conn As MySqlConnection = dados.GetConnection()
        Try
            Dim sql As String = "Select * from colaboradores"
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            Try
                Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)
                If ds.HasChanges Then
                    da.Update(ds, "colaboradores")
                    ds.AcceptChanges()
                End If
            Finally
                da.Dispose()
            End Try
        Finally
            conn.Close()
            conn.Dispose()
            colaboradores.carrega()
        End Try
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Try
            'encerra a edição atual da operação - esta propriedade foi feita para ser usada com vinculação complexa de dados
            BindingContext(dsColaborador, "colaboradores").EndCurrentEdit()
            'chama o método SalvaAluno passando o dataset como parametro
            SalvaColaborador(dsColaborador)
            'chama o método carregaDados no formulario principal para atualizar dados
            'colaboradores.CarregaDados()
            'exibe mensagem ao usuário que os dados foram salvos
            salvar()
        Catch ex As Exception
            MsgBox("Erro ao salvar dados na tabela. " & vbCrLf & ex.Message, MsgBoxStyle.Information, "Erro ao salvar dados")
        End Try
        Me.BringToFront()
    End Sub
#End Region
#Region "INFORMAÇÕES NO BALÃO"
    Private Sub TipBalão(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        tip.SetToolTip(txtRua, "Somente Logradouro 'Rua, Avenida, etc...'!")
        tip.SetToolTip(txtNomeRua, "Somente o nome da Rua!")
        tip.SetToolTip(txtNumero, "Somente o Número da Casa!")
        tip.SetToolTip(txtComplemento, "Somente o Complemento da Casa!")
        tip.SetToolTip(txtBairro, "Bairro!")
        tip.SetToolTip(txtCEP, "CEP da rua ou cidade!")
        tip.SetToolTip(txtCidade, "Cidade ou Localidade!")
        tip.SetToolTip(txtEstado, "Estado ou Região!")
        tip.SetToolTip(txtDDDRES, "Somente o DDD do Residencial!")
        tip.SetToolTip(txtTELRES, "Somente o Número do Telefone Residencial!")
        tip.SetToolTip(txtdddCEL, "Somente o DDD do Celular!")
        tip.SetToolTip(txttelCEL, "Somente o Número do Telefone Celular!")
        tip.SetToolTip(txtNomePai, "Nome do Pai!")
        tip.SetToolTip(txtNomeMae, "Nome da Mãe!")
        tip.SetToolTip(dtNascimento, "Data de Nascimento por extenso!")
        tip.SetToolTip(cbSexo, "Selecione o sexo do Colaborador!")
        '--------------------------------------------------------------------
        tip.SetToolTip(txtMatricula, "Matrícula do Colaborador!")
        tip.SetToolTip(txtEfetivo, "Efetivo ou Desligado!")
        tip.SetToolTip(txtCliente, "Selicione o cliente")
        tip.SetToolTip(dtadmissao, "Data de Admissão do Colaborador!")
        tip.SetToolTip(dtDemissao, "Data de Demissão do Colaborador!")
        tip.SetToolTip(cbSemanTrabalho, "Semana de Trabalho do Colaborador!")
        tip.SetToolTip(cbHoraTrabalho, "Horário de Trabalho do Colaborador!")
        tip.SetToolTip(cbCargo, "Cargo do Colaborador!")
        tip.SetToolTip(cbSetor, "Setor do Colaborador!")
        tip.SetToolTip(cbSalario, "Salário do Colaborador!")
        tip.SetToolTip(txtLivro, "Número do Livro!")
        tip.SetToolTip(txtFolha, "Número da Folha!")
        '--------------------------------------------------------------------
        tip.SetToolTip(cbBanco, "Selecione o BANCO de uso do Colaborador!")
        tip.SetToolTip(txtAgemcia, "Agência!")
        tip.SetToolTip(txtConta, "Número da Conta!")
        tip.SetToolTip(txtDigitoConta, "Dígito da Conta!")
        '--------------------------------------------------------------------
    End Sub
#End Region
#Region "SALVA FOTO DO COLABORADOR"
    Function Tratar_imagem(ByVal img As Image) As Byte()
        Dim ms As New IO.MemoryStream
        img.Save(ms, Imaging.ImageFormat.Jpeg)
        Return ms.ToArray
    End Function
    Private Sub salvar()
        Dim conn As MySqlConnection
        Dim dr As MySqlDataReader
        Dim cmd As New MySqlCommand
        conn = New MySqlConnection()
        conn.ConnectionString = dados.mMySQLConnectionString
        Try
            conn.Open()
            cmd.CommandText = "UPDATE colaboradores SET foto =  (@Imagem)  WHERE ID = '" & lblfoto.Text & "'"
            cmd.Parameters.Add("@Imagem", MySql.Data.MySqlClient.MySqlDbType.Binary).Value = Tratar_imagem(picFoto.Image)
            cmd.Connection = conn
            dr = cmd.ExecuteReader
        Catch myerror As MySqlException
            MessageBox.Show("Database Error: " & myerror.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            'MessageBox.Show("Error: " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            cmd.Parameters.Clear()
            conn.Close()
            cmd.Dispose()
            conn.Dispose()
        End Try
    End Sub
    Dim retorno As Boolean = False
    Dim dbConexao As MySqlConnection
    Dim vComando As New MySqlCommand
    Dim Adapter As New MySqlDataAdapter
    Dim Tabela As New DataTable
    Dim pRegistro As DataRow
    Sub abre()
        dados.strConexaofoto()
        Try
            dbConexao = New MySqlConnection(dados.strConexao.ToString)
            dbConexao.Open()
        Catch ex As Exception
        End Try
        With vComando
            .CommandText = "select * from colaboradores WHERE ID = '" & lblfoto.Text & "'"
            .CommandType = CommandType.Text
        End With
        vComando.Connection = dbConexao
        With Adapter
            .SelectCommand = vComando
        End With
        Try
            Adapter.Fill(Tabela)
            pRegistro = Tabela.Rows(0)
            Dim FotoByte() As Byte = pRegistro.Item("foto")
            If FotoByte.Length > 0 Then
                Dim FotoStream As IO.MemoryStream = New IO.MemoryStream(FotoByte, True)
                FotoStream.Write(FotoByte, 0, FotoByte.Length)
                Me.picFoto.Image = New Bitmap(FotoStream)
                FotoStream.Close()
            End If
        Catch ex As Exception
        End Try
        Adapter = Nothing
    End Sub
#End Region
#Region "COMUNICAÇÃO DE ADMISSÃO"
    '====================================================================================================================
    'COMUNICAÇÃO DO COLABORADOR PARA CENTRAL
    '====================================================================================================================
    'o PainelAdmissao principal
    'Private PainelAdmissao As New Panel
    'o separador que fica visível
    Private WithEvents PainelAdmissaoSep As New Panel
    'o temporizador responsável por o deslize
    Private WithEvents DeslizadorAdmissao As New Timer

    'o valor da posição do PainelAdmissao quando recolhido
    Private PosicaoRecolhidaAdmissao As Integer
    'o valor da posição do PainelAdmissao quando extendido
    Private PosicaoEstendidaAdmissao As Integer
    'para determinar se o PainelAdmissao está aberto ou fechado
    Private PainelAdmissaoAberto As Boolean = False
    'a velocidade com que o PainelAdmissao se move
    '(na verdade é a velocidade com que a distância restante se atenua)
    Private Velocidade As Double = 0.2
    Private Sub Admissao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'definimos o tamanho da form
        'Me.Size = New Size(716, 461)

        Dim img As Image = Image.FromFile("d:\image.jpg")

        Clipboard.SetImage(img)
        Me.txtMensagem.Paste()

        'Clipboard.SetImage(My.Resources.SomeImage)
        'Me.txtMensagem.Paste()


        'definimos o tamanho dos paineis
        PainelAdmissao.Size = New Size(910, 630)
        PainelAdmissaoSep.Size = New Size(32, 32)

        'preparamos o PainelAdmissao separador para apresentar uma imagem
        PainelAdmissaoSep.BackgroundImageLayout = ImageLayout.Zoom
        'PainelAdmissaoSep.BackgroundImage = Me.Icon.ToBitmap.Clone

        'preparamos o PainelAdmissao principal para que o seu movimento se note
        PainelAdmissao.BackColor = Color.White
        PainelAdmissao.BorderStyle = BorderStyle.None

        'definimos os valores de funcionamento inicial do temporizador
        DeslizadorAdmissao.Interval = 1
        DeslizadorAdmissao.Enabled = False

        'definimos os valores das posições garantidas
        PosicaoRecolhidaAdmissao = 0 - PainelAdmissao.Width
        PosicaoEstendidaAdmissao = 0

        'adicionamos tudo ao form
        Me.Controls.Add(PainelAdmissao)
        Me.Controls.Add(PainelAdmissaoSep)

        'ajustamos as posições definitivas dos paineis
        PainelAdmissao.Top = 40
        PainelAdmissaoSep.Top = 40
        PainelAdmissao.Left = 0 - PainelAdmissao.Width
        PainelAdmissaoSep.Left = PainelAdmissao.Left + PainelAdmissao.Width

    End Sub
    Private Sub RecolocarSeparadorAdmissao()
        'posiciona o PainelAdmissao separador sempre na mesma posição, dependente da posição do PainelAdmissao principal
        PainelAdmissaoSep.Left = PainelAdmissao.Left + PainelAdmissao.Width
    End Sub
    Private Sub MenuTextoComunica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTextoComunica.Click
        'se o painel estiver aberto, marca como fechado
        If PainelAdmissaoAberto = True Then
            'trocamos a posição do painel para fechado
            Me.PainelAdmissao.BringToFront()
            PainelAdmissaoAberto = False
            'mas se o painel estiver fechado, marca como aberto
        ElseIf PainelAdmissaoAberto = False Then
            'trocamos a posição do painel para aberto
            Me.PainelAdmissao.BringToFront()
            PainelAdmissaoAberto = True
        End If

        'e por fim, activamos o temporizador para validar as novas ordens de posição
        DeslizadorAdmissao.Enabled = True
    End Sub
    Private Sub DeslizadorAdmissao_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeslizadorAdmissao.Tick
        'declaramos uma variável que possa lidar com valores decimais
        Dim TempX As Double = PainelAdmissao.Left

        'se o PainelAdmissao estiver definido para aberto e residir em qualquer ponto antes do seu máximo
        'significa que temos de abri-lo até ao máximo
        If PainelAdmissaoAberto = True And PainelAdmissao.Left < PosicaoEstendidaAdmissao Then
            'calculamos o novo número para a posição, sem arredondar (e isto é importante)
            TempX += Math.Ceiling((PosicaoEstendidaAdmissao - PainelAdmissao.Left) * Math.Abs(Velocidade))

            'se o valor calculado estiver para além do valor máximo...
            If TempX >= PosicaoEstendidaAdmissao Then
                'desligamos o temporizador para impedir mais movimento
                DeslizadorAdmissao.Enabled = False
                '...normalizamos o valor para o máximo
                TempX = PosicaoEstendidaAdmissao
            End If

            'depois do cálculo estar feito e validado, atribuímos o novo valor à posição do PainelAdmissao
            PainelAdmissao.Left = TempX

            'mandamos recolocar o separador, chamando o método
            RecolocarSeparadorAdmissao()
        End If

        'se o PainelAdmissao estiver definido para fechado e residir em qualquer ponto depois do seu mínimo
        'significa que temos de fechá-lo até ao mínimo
        If PainelAdmissaoAberto = False And PainelAdmissao.Left > PosicaoRecolhidaAdmissao Then
            'calculamos o novo número para a posição, sem arredondar (e isto é importante)
            TempX -= Math.Ceiling((Math.Abs(PosicaoRecolhidaAdmissao) - Math.Abs(PainelAdmissao.Left)) * Math.Abs(Velocidade))

            'se o valor calculado estiver para aquém do valor mínimo...
            If TempX <= PosicaoRecolhidaAdmissao Then
                'desligamos o temporizador para impedir mais movimento
                DeslizadorAdmissao.Enabled = False
                '...normalizamos o valor para o mínimo
                TempX = PosicaoRecolhidaAdmissao
            End If

            'depois do cálculo estar feito e validado, atribuímos o novo valor à posição do PainelAdmissao
            PainelAdmissao.Left = TempX

            'mandamos recolocar o separador, chamando o método
            RecolocarSeparadorAdmissao()
        End If
    End Sub
    '===========================================================================================================================================================
    Private Sub email(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbDocumentos.Visible = True
        tbMatricula.Visible = True
        'tbBanco.Visible = True
        tbOutros.Visible = True
        'E-MAIL ADMISSÃO==========================================================================================================================================
        txtAssunto.Text = "ADMISSÃO DE " & txtNome.Text & " " & txtSobreNome.Text
        txtMensagem.Text = "Bom dia" & Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        txtNome.Text & " " & txtSobreNome.Text & " esta sendo admitido na data de " & dtadmissao.Text & " para exercer a função de " & cbCargo.Text & " com remuneração especifica de " & cbSalario.Text & " no seguinte horário, " & cbHoraTrabalho.Text & " de " & cbSemanTrabalho.Text & "." & Environment.NewLine & _
        "RG: " & txtRG.Text & " Expedição: " & txtRgEmisao.Text & Environment.NewLine & _
        "CPF: " & txtCPF.Text & Environment.NewLine & _
        "CTPS: " & txtCTPS.Text & Environment.NewLine & _
        "PIS: " & txtPIS.Text & Environment.NewLine & _
        "Titulo de eleitor: " & txtTituloeleitoral.Text & " Zona: " & txtZona.Text & " seção: " & txtSecao.Text & Environment.NewLine & _
        "Reservista: " & txtReservista.Text & Environment.NewLine & _
        "Conta bancaria: " & Environment.NewLine & _
        "AG: " & txtAgemcia.Text & " Conta: " & txtConta.Text & " - " & txtDigitoConta.Text & " Banco: " & cbBanco.Text & Environment.NewLine & _
        "Pai: " & txtNomePai.Text & Environment.NewLine & _
        "Mãe: " & txtNomeMae.Text & Environment.NewLine & _
        "Naturalidade: " & txtNaturalidade.Text & " / " & txtEstadoNaturalidade.Text & Environment.NewLine & _
        "Data de nascimento: " & dtNascimento.Text & Environment.NewLine & _
        "Endereço: " & txtRua.Text & " " & txtNomeRua.Text & " Nº: " & txtNumero.Text & " Bairro: " & txtBairro.Text & " " & txtCidade.Text & " CEP: " & txtCEP.Text & " " & txtEstado.Text & Environment.NewLine & _
        "Livro de registro: " & txtLivro.Text & " folha: " & txtFolha.Text & Environment.NewLine & _
         Environment.NewLine & _
         Environment.NewLine & _
        "Qualquer informação que faltar, me avise ok."
        '=E-MAIL DEMISSÃO==========================================================================================================================================
        txtAssuntoDemissao.Text = "DEMISSÃO DE " & txtNome.Text & " " & txtSobreNome.Text
        txtMailDemissão.Text = "Bom dia" & Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        txtNome.Text & " " & txtSobreNome.Text & " esta sendo demitido na data de " & dtDemissao.Text & Environment.NewLine & _
        "função de " & cbCargo.Text & " com remuneração especifica de " & cbSalario.Text & " no seguinte horário, " & cbHoraTrabalho.Text & " de " & cbSemanTrabalho.Text & "." & Environment.NewLine & _
        "RG: " & txtRG.Text & " Expedição: " & txtRgEmisao.Text & Environment.NewLine & _
        "CPF: " & txtCPF.Text & Environment.NewLine & _
        "CTPS: " & txtCTPS.Text & Environment.NewLine & _
        "PIS: " & txtPIS.Text & Environment.NewLine & _
        "Titulo de eleitor: " & txtTituloeleitoral.Text & " Zona: " & txtZona.Text & " seção: " & txtSecao.Text & Environment.NewLine & _
        "Reservista: " & txtReservista.Text & Environment.NewLine & _
        "Conta bancaria: " & Environment.NewLine & _
        "AG: " & txtAgemcia.Text & " Conta: " & txtConta.Text & " - " & txtDigitoConta.Text & " Banco: " & cbBanco.Text & Environment.NewLine & _
        "Pai: " & txtNomePai.Text & Environment.NewLine & _
        "Mãe: " & txtNomeMae.Text & Environment.NewLine & _
        "Naturalidade: " & txtNaturalidade.Text & " / " & txtEstadoNaturalidade.Text & Environment.NewLine & _
        "Data de nascimento: " & dtNascimento.Text & Environment.NewLine & _
        "Endereço: " & txtRua.Text & " " & txtNomeRua.Text & " Nº " & txtNumero.Text & " " & txtCidade.Text & " " & txtEstado.Text & Environment.NewLine & _
        "Livro de registro: " & txtLivro.Text & " folha: " & txtFolha.Text & Environment.NewLine & _
         Environment.NewLine & _
         Environment.NewLine & _
        "Qualquer informação que faltar, me avise ok."
        '==========================================================================================================================================
        '=E-MAIL JUSTA CAUSA ======================================================================================================================
        txtAssuntoJustaCausa.Text = "JUSTA CAUSA DE " & txtNome.Text & " " & txtSobreNome.Text
        txtMailJustaCausa.Text = "Bom dia" & Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        txtNome.Text & " " & txtSobreNome.Text & " esta sendo demitido por justa causa na data de " & dtDemissao.Text & Environment.NewLine & _
        "função de " & cbCargo.Text & " com remuneração especifica de " & cbSalario.Text & " no seguinte horário, " & cbHoraTrabalho.Text & " de " & cbSemanTrabalho.Text & "." & Environment.NewLine & _
        "RG: " & txtRG.Text & " Expedição: " & txtRgEmisao.Text & Environment.NewLine & _
        "CPF: " & txtCPF.Text & Environment.NewLine & _
        "CTPS: " & txtCTPS.Text & Environment.NewLine & _
        "PIS: " & txtPIS.Text & Environment.NewLine & _
        "Titulo de eleitor: " & txtTituloeleitoral.Text & " Zona: " & txtZona.Text & " seção: " & txtSecao.Text & Environment.NewLine & _
        "Reservista: " & txtReservista.Text & Environment.NewLine & _
        "Conta bancaria: " & Environment.NewLine & _
        "AG: " & txtAgemcia.Text & " Conta: " & txtConta.Text & " - " & txtDigitoConta.Text & " Banco: " & cbBanco.Text & Environment.NewLine & _
        "Pai: " & txtNomePai.Text & Environment.NewLine & _
        "Mãe: " & txtNomeMae.Text & Environment.NewLine & _
        "Naturalidade: " & txtNaturalidade.Text & " / " & txtEstadoNaturalidade.Text & Environment.NewLine & _
        "Data de nascimento: " & dtNascimento.Text & Environment.NewLine & _
        "Endereço: " & txtRua.Text & " " & txtNomeRua.Text & " Nº " & txtNumero.Text & " " & txtCidade.Text & " " & txtEstado.Text & Environment.NewLine & _
        "Livro de registro: " & txtLivro.Text & " folha: " & txtFolha.Text & Environment.NewLine & _
         Environment.NewLine & _
         Environment.NewLine & _
        "Qualquer informação que faltar, me avise ok."
        '==========================================================================================================================================
        '=E-MAIL PEDIDO DE DEMISSÃO ===============================================================================================================
        txtAssuntoPedidoDemissao.Text = "PEDIDO DE DEMISSÃO DE " & txtNome.Text & " " & txtSobreNome.Text
        txtMailPedidoDemissao.Text = "Bom dia" & Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        txtNome.Text & " " & txtSobreNome.Text & " esta pedindo demissão na data de " & dtDemissao.Text & Environment.NewLine & _
        "função de " & cbCargo.Text & " com remuneração especifica de " & cbSalario.Text & " no seguinte horário, " & cbHoraTrabalho.Text & " de " & cbSemanTrabalho.Text & "." & Environment.NewLine & _
        "RG: " & txtRG.Text & " Expedição: " & txtRgEmisao.Text & Environment.NewLine & _
        "CPF: " & txtCPF.Text & Environment.NewLine & _
        "CTPS: " & txtCTPS.Text & Environment.NewLine & _
        "PIS: " & txtPIS.Text & Environment.NewLine & _
        "Titulo de eleitor: " & txtTituloeleitoral.Text & " Zona: " & txtZona.Text & " seção: " & txtSecao.Text & Environment.NewLine & _
        "Reservista: " & txtReservista.Text & Environment.NewLine & _
        "Conta bancaria: " & Environment.NewLine & _
        "AG: " & txtAgemcia.Text & " Conta: " & txtConta.Text & " - " & txtDigitoConta.Text & " Banco: " & cbBanco.Text & Environment.NewLine & _
        "Pai: " & txtNomePai.Text & Environment.NewLine & _
        "Mãe: " & txtNomeMae.Text & Environment.NewLine & _
        "Naturalidade: " & txtNaturalidade.Text & " / " & txtEstadoNaturalidade.Text & Environment.NewLine & _
        "Data de nascimento: " & dtNascimento.Text & Environment.NewLine & _
        "Endereço: " & txtRua.Text & " " & txtNomeRua.Text & " Nº " & txtNumero.Text & " " & txtCidade.Text & " " & txtEstado.Text & Environment.NewLine & _
        "Livro de registro: " & txtLivro.Text & " folha: " & txtFolha.Text & Environment.NewLine & _
         Environment.NewLine & _
         Environment.NewLine & _
        "Qualquer informação que faltar, me avise ok."
        '==========================================================================================================================================
    End Sub
    '==============================================================================================================================================
    Dim m_OutLook As Outlook.Application
    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Try
            '* Creamos un Objeto tipo Mail
            Dim objMail As Outlook.MailItem

            '* Inicializamos nuestra apliación OutLook
            m_OutLook = New Outlook.Application

            '* Creamos una instancia de un objeto tipo MailItem
            objMail = m_OutLook.CreateItem(Outlook.OlItemType.olMailItem)

            '* Asignamos las propiedades a nuestra Instancial del objeto
            '* MailItem
            objMail.To = "fabiano.souza@dipack.com.br" & ";" & txtPara.Text
            objMail.CC = "fernando.ganzarolli@dipack.com.br" & ";" & txtCC.Text
            objMail.Subject = "ADMISSÃO DE " & txtNome.Text & " " & txtSobreNome.Text 'txtAssunto.Text '"Prueba de integración con OutLook"
            objMail.Body = txtMensagem.Text '"Esto es una prueba de integración de WorkFlow con OutLook"

            '* Enviamos nuestro Mail y listo!
            objMail.Send()

            '* Desplegamos un mensaje indicando que todo fue exitoso
            MessageBox.Show("e-Mail Enviado pelo Microsoft Outlook", "e-Mail Enviado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            '* Si se produce algun Error Notificar al usuario
            MessageBox.Show("Provavelmente ete Computador não tem instalado o Microsoft Outlook." & Environment.NewLine & "     Contate o administrador de sistemas !", "Erro enviando mail", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            m_OutLook = Nothing
        End Try
    End Sub
    Private Sub btnEnviarDemissao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarDemissao.Click
        Try
            '* Creamos un Objeto tipo Mail
            Dim objMail As Outlook.MailItem

            '* Inicializamos nuestra apliación OutLook
            m_OutLook = New Outlook.Application

            '* Creamos una instancia de un objeto tipo MailItem
            objMail = m_OutLook.CreateItem(Outlook.OlItemType.olMailItem)

            '* Asignamos las propiedades a nuestra Instancial del objeto
            '* MailItem
            objMail.To = "fabiano.souza@dipack.com.br" & ";" & txtPara.Text
            objMail.CC = "fernando.ganzarolli@dipack.com.br" & ";" & txtCC.Text
            objMail.Subject = "DEMISSÃO DE " & txtNome.Text & " " & txtSobreNome.Text 'txtAssunto.Text '"Prueba de integración con OutLook"
            objMail.Body = txtMailDemissão.Text '"Esto es una prueba de integración de WorkFlow con OutLook"

            '* Enviamos nuestro Mail y listo!
            objMail.Send()

            '* Desplegamos un mensaje indicando que todo fue exitoso
            MessageBox.Show("e-Mail Enviado pelo Microsoft Outlook", "e-Mail Enviado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            '* Si se produce algun Error Notificar al usuario
            MessageBox.Show("Provavelmente ete Computador não tem instalado o Microsoft Outlook." & Environment.NewLine & "     Contate o administrador de sistemas !", "Erro enviando mail", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            m_OutLook = Nothing
        End Try
    End Sub
    Private Sub btnEnviarJustaCausa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarJustaCausa.Click
        Try
            '* Creamos un Objeto tipo Mail
            Dim objMail As Outlook.MailItem

            '* Inicializamos nuestra apliación OutLook
            m_OutLook = New Outlook.Application

            '* Creamos una instancia de un objeto tipo MailItem
            objMail = m_OutLook.CreateItem(Outlook.OlItemType.olMailItem)

            '* Asignamos las propiedades a nuestra Instancial del objeto
            '* MailItem
            objMail.To = "fabiano.souza@dipack.com.br" & ";" & txtPara.Text
            objMail.CC = "fernando.ganzarolli@dipack.com.br" & ";" & txtCC.Text
            objMail.Subject = "JUSTA CAUSA DE " & txtNome.Text & " " & txtSobreNome.Text 'txtAssunto.Text '"Prueba de integración con OutLook"
            objMail.Body = txtMailJustaCausa.Text '"Esto es una prueba de integración de WorkFlow con OutLook"

            '* Enviamos nuestro Mail y listo!
            objMail.Send()

            '* Desplegamos un mensaje indicando que todo fue exitoso
            MessageBox.Show("e-Mail Enviado pelo Microsoft Outlook", "e-Mail Enviado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            '* Si se produce algun Error Notificar al usuario
            MessageBox.Show("Provavelmente ete Computador não tem instalado o Microsoft Outlook." & Environment.NewLine & "     Contate o administrador de sistemas !", "Erro enviando mail", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            m_OutLook = Nothing
        End Try
    End Sub

    Private Sub btnEnviarPedidoDemissao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarPedidoDemissao.Click
        Try
            '* Creamos un Objeto tipo Mail
            Dim objMail As Outlook.MailItem

            '* Inicializamos nuestra apliación OutLook
            m_OutLook = New Outlook.Application

            '* Creamos una instancia de un objeto tipo MailItem
            objMail = m_OutLook.CreateItem(Outlook.OlItemType.olMailItem)

            '* Asignamos las propiedades a nuestra Instancial del objeto
            '* MailItem
            objMail.To = "fabiano.souza@dipack.com.br" & ";" & txtPara.Text
            objMail.CC = "fernando.ganzarolli@dipack.com.br" & ";" & txtCC.Text
            objMail.Subject = "PEDIDO DE DEMISSÃO DE " & txtNome.Text & " " & txtSobreNome.Text 'txtAssunto.Text '"Prueba de integración con OutLook"
            objMail.Body = txtMailPedidoDemissao.Text '"Esto es una prueba de integración de WorkFlow con OutLook"

            '* Enviamos nuestro Mail y listo!
            objMail.Send()

            '* Desplegamos un mensaje indicando que todo fue exitoso
            MessageBox.Show("e-Mail Enviado pelo Microsoft Outlook", "e-Mail Enviado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            '* Si se produce algun Error Notificar al usuario
            MessageBox.Show("Provavelmente ete Computador não tem instalado o Microsoft Outlook." & Environment.NewLine & "     Contate o administrador de sistemas !", "Erro enviando mail", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            m_OutLook = Nothing
        End Try
    End Sub
#End Region
#Region "ABERTURA DA CONTA"
    '====================================================================================================================
    'ADVERTÊNCIA DO COLABORADOR
    '====================================================================================================================
    'o PainelContaBanco principal
    'Private PainelContaBanco As New Panel
    'o separador que fica visível
    Private WithEvents PainelContaBancoSep As New Panel
    'o temporizador responsável por o deslize
    Private WithEvents DeslizadorAdvertencia As New Timer

    'o valor da posição do PainelContaBanco quando recolhido
    Private PosicaoRecolhidaAdvertencia As Integer
    'o valor da posição do PainelContaBanco quando extendido
    Private PosicaoEstendidaAdvertencia As Integer
    'para determinar se o PainelContaBanco está aberto ou fechado
    Private PainelContaBancoAberto As Boolean = False
    'a velocidade com que o PainelContaBanco se move
    '(na verdade é a velocidade com que a distância restante se atenua)
    Private Sub Advertencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'definimos o tamanho da form
        'Me.Size = New Size(716, 461)

        'definimos o tamanho dos paineis
        PainelContaBanco.Size = New Size(910, 630)
        PainelContaBancoSep.Size = New Size(32, 32)

        'preparamos o PainelContaBanco separador para apresentar uma imagem
        PainelContaBancoSep.BackgroundImageLayout = ImageLayout.Zoom
        'PainelContaBancoSep.BackgroundImage = Me.Icon.ToBitmap.Clone

        'preparamos o PainelContaBanco principal para que o seu movimento se note
        PainelContaBanco.BackColor = Color.White
        PainelContaBanco.BorderStyle = BorderStyle.None

        'definimos os valores de funcionamento inicial do temporizador
        DeslizadorAdvertencia.Interval = 1
        DeslizadorAdvertencia.Enabled = False

        'definimos os valores das posições garantidas
        PosicaoRecolhidaAdvertencia = 0 - PainelContaBanco.Width
        PosicaoEstendidaAdvertencia = 0

        'adicionamos tudo ao form
        Me.Controls.Add(PainelContaBanco)
        Me.Controls.Add(PainelContaBancoSep)

        'ajustamos as posições definitivas dos paineis
        PainelContaBanco.Top = 40
        PainelContaBancoSep.Top = 40
        PainelContaBanco.Left = 0 - PainelContaBanco.Width
        PainelContaBancoSep.Left = PainelContaBanco.Left + PainelContaBanco.Width

    End Sub
    Private Sub RecolocarSeparadorAdvertencia()
        'posiciona o PainelContaBanco separador sempre na mesma posição, dependente da posição do PainelContaBanco principal
        PainelContaBancoSep.Left = PainelContaBanco.Left + PainelContaBanco.Width
    End Sub
    Private Sub aberturaConta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aberturaConta.Click
        'se o painel estiver aberto, marca como fechado
        If PainelContaBancoAberto = True Then
            'trocamos a posição do painel para fechado
            Me.PainelContaBanco.BringToFront()
            PainelContaBancoAberto = False
            'mas se o painel estiver fechado, marca como aberto
        ElseIf PainelContaBancoAberto = False Then
            'trocamos a posição do painel para aberto
            Me.PainelContaBanco.BringToFront()
            PainelContaBancoAberto = True
        End If

        'e por fim, activamos o temporizador para validar as novas ordens de posição
        DeslizadorAdvertencia.Enabled = True
    End Sub
    Private Sub DeslizadorAdvertencia_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeslizadorAdvertencia.Tick
        'declaramos uma variável que possa lidar com valores decimais
        Dim TempX As Double = PainelContaBanco.Left

        'se o PainelContaBanco estiver definido para aberto e residir em qualquer ponto antes do seu máximo
        'significa que temos de abri-lo até ao máximo
        If PainelContaBancoAberto = True And PainelContaBanco.Left < PosicaoEstendidaAdvertencia Then
            'calculamos o novo número para a posição, sem arredondar (e isto é importante)
            TempX += Math.Ceiling((PosicaoEstendidaAdvertencia - PainelContaBanco.Left) * Math.Abs(Velocidade))

            'se o valor calculado estiver para além do valor máximo...
            If TempX >= PosicaoEstendidaAdvertencia Then
                'desligamos o temporizador para impedir mais movimento
                DeslizadorAdvertencia.Enabled = False
                '...normalizamos o valor para o máximo
                TempX = PosicaoEstendidaAdvertencia
            End If

            'depois do cálculo estar feito e validado, atribuímos o novo valor à posição do PainelContaBanco
            PainelContaBanco.Left = TempX

            'mandamos recolocar o separador, chamando o método
            RecolocarSeparadorAdvertencia()
        End If

        'se o PainelContaBanco estiver definido para fechado e residir em qualquer ponto depois do seu mínimo
        'significa que temos de fechá-lo até ao mínimo
        If PainelContaBancoAberto = False And PainelContaBanco.Left > PosicaoRecolhidaAdvertencia Then
            'calculamos o novo número para a posição, sem arredondar (e isto é importante)
            TempX -= Math.Ceiling((Math.Abs(PosicaoRecolhidaAdvertencia) - Math.Abs(PainelContaBanco.Left)) * Math.Abs(Velocidade))

            'se o valor calculado estiver para aquém do valor mínimo...
            If TempX <= PosicaoRecolhidaAdvertencia Then
                'desligamos o temporizador para impedir mais movimento
                DeslizadorAdvertencia.Enabled = False
                '...normalizamos o valor para o mínimo
                TempX = PosicaoRecolhidaAdvertencia
            End If

            'depois do cálculo estar feito e validado, atribuímos o novo valor à posição do PainelContaBanco
            PainelContaBanco.Left = TempX

            'mandamos recolocar o separador, chamando o método
            RecolocarSeparadorAdvertencia()
        End If
    End Sub
    Private Sub btnPrintAbreConta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAbreConta.Click
        PrintPreviewDialog.Document = PrintAberturaConta
        PrintPreviewDialog.WindowState = FormWindowState.Maximized
        PrintPreviewDialog.Document.DocumentName = "ABERTURA DA CONTA DE " & txtNome.Text & " " & txtSobreNome.Text
        PrintPreviewDialog.Text = "ABERTURA DA CONTA DE " & txtNome.Text & " " & txtSobreNome.Text
        'PrintPreviewDialog.ShowDialog()
        PrintAberturaConta.Print()
    End Sub
    Private Sub PrintAberturaConta_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintAberturaConta.PrintPage
        Dim g As Graphics = e.Graphics
        Dim Negrito As New Font("Verdana", 10, FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Dim Normal As New Font("Verdana", 10, System.Drawing.GraphicsUnit.Point)
        Dim pequena As New Font("Verdana", 10, System.Drawing.GraphicsUnit.Point)
        '--------------------------------------------------------------------------------------------------------------
        Dim Titulo As String = "                                      C.N.P.J.: 03.418.905/0001-74"
        Dim sublinhado As String = "                                    Inscrição Estadual: 116.041.955-110 "
        Dim banco As String = "     Ao Banco " & cbBanco.Text & " Ltda."
        Dim agencia As String = "             A/C Gerência."

        Dim data As String = "      " & Now()

        Dim texto As String = " Abertura de Conta Corrente." & Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
            txtNome.Text & " " & txtSobreNome.Text & " está sendo admitido para exercer a função de" & Environment.NewLine & _
            cbCargo.Text & Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
            "RG : " & txtRG.Text & Environment.NewLine & _
       Environment.NewLine & _
       Environment.NewLine & _
            "CPF : " & txtCPF.Text & Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
            "O salário mensal do funcionário é de " & cbSalario.Text & Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        Environment.NewLine & _
        "                                                                  __________________________" & Environment.NewLine & _
        "                                                                                Supervisor"




        g.DrawString(Titulo, Negrito, Brushes.Black, 160, 50)
        g.DrawString(sublinhado, Negrito, Brushes.Black, 100, 70)
        g.DrawString(banco, Normal, Brushes.Black, 100, 200)
        g.DrawString(data, Normal, Brushes.Black, 100, 220)

        g.DrawString(texto, Normal, Brushes.Black, 100, 280)
    End Sub
#End Region
#Region "CONTRATOS DO COLABORADOR"
    '=========================================================================================================================
    'CONTRATOS DO COLABORADOR
    '=========================================================================================================================
    'o Painelcontrato principal
    'Private Painelcontrato As New Panel
    'o separador que fica visível
    Private WithEvents PainelcontratoSep As New Panel
    'o temporizador responsável por o deslize
    Private WithEvents Deslizadorcontrato As New Timer

    'o valor da posição do Painelcontrato quando recolhido
    Private PosicaoRecolhidacontrato As Integer
    'o valor da posição do Painelcontrato quando extendido
    Private PosicaoEstendidacontrato As Integer
    'para determinar se o Painelcontrato está aberto ou fechado
    Private PainelcontratoAberto As Boolean = False
    'a velocidade com que o Painelcontrato se move
    '(na verdade é a velocidade com que a distância restante se atenua)
    'Private Velocidade As Double = 0.2
    Private Sub Contrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'definimos o tamanho da form
        'Me.Size = New Size(716, 461)

        'definimos o tamanho dos paineis
        Painelcontrato.Size = New Size(910, 630)
        PainelcontratoSep.Size = New Size(32, 32)

        'preparamos o Painelcontrato separador para apresentar uma imagem
        PainelcontratoSep.BackgroundImageLayout = ImageLayout.Zoom
        'PainelcontratoSep.BackgroundImage = Me.Icon.ToBitmap.Clone

        'preparamos o Painelcontrato principal para que o seu movimento se note
        Painelcontrato.BackColor = Color.White
        Painelcontrato.BorderStyle = BorderStyle.None

        'definimos os valores de funcionamento inicial do temporizador
        Deslizadorcontrato.Interval = 1
        Deslizadorcontrato.Enabled = False

        'definimos os valores das posições garantidas
        PosicaoRecolhidacontrato = 0 - Painelcontrato.Width
        PosicaoEstendidacontrato = 0

        'adicionamos tudo ao form
        Me.Controls.Add(Painelcontrato)
        Me.Controls.Add(PainelcontratoSep)

        'ajustamos as posições definitivas dos paineis
        Painelcontrato.Top = 40
        PainelcontratoSep.Top = 40
        Painelcontrato.Left = 0 - Painelcontrato.Width
        PainelcontratoSep.Left = Painelcontrato.Left + Painelcontrato.Width

    End Sub
    Private Sub RecolocarSeparadorcontrato()
        'posiciona o Painelcontrato separador sempre na mesma posição, dependente da posição do Painelcontrato principal
        PainelcontratoSep.Left = Painelcontrato.Left + Painelcontrato.Width
    End Sub
    Private Sub MenuTextocontrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTextoContrato.Click
        'se o painel estiver aberto, marca como fechado
        If PainelcontratoAberto = True Then
            'trocamos a posição do painel para fechado
            Me.Painelcontrato.BringToFront()
            PainelcontratoAberto = False
            'mas se o painel estiver fechado, marca como aberto
        ElseIf PainelcontratoAberto = False Then
            'trocamos a posição do painel para aberto
            Me.Painelcontrato.BringToFront()
            PainelcontratoAberto = True
        End If

        'e por fim, activamos o temporizador para validar as novas ordens de posição
        Deslizadorcontrato.Enabled = True
    End Sub
    Private Sub Deslizadorcontrato_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Deslizadorcontrato.Tick
        'declaramos uma variável que possa lidar com valores decimais
        Dim TempX As Double = Painelcontrato.Left

        'se o Painelcontrato estiver definido para aberto e residir em qualquer ponto antes do seu máximo
        'significa que temos de abri-lo até ao máximo
        If PainelcontratoAberto = True And Painelcontrato.Left < PosicaoEstendidacontrato Then
            'calculamos o novo número para a posição, sem arredondar (e isto é importante)
            TempX += Math.Ceiling((PosicaoEstendidacontrato - Painelcontrato.Left) * Math.Abs(Velocidade))

            'se o valor calculado estiver para além do valor máximo...
            If TempX >= PosicaoEstendidacontrato Then
                'desligamos o temporizador para impedir mais movimento
                Deslizadorcontrato.Enabled = False
                '...normalizamos o valor para o máximo
                TempX = PosicaoEstendidacontrato
            End If

            'depois do cálculo estar feito e validado, atribuímos o novo valor à posição do Painelcontrato
            Painelcontrato.Left = TempX

            'mandamos recolocar o separador, chamando o método
            RecolocarSeparadorcontrato()
        End If

        'se o Painelcontrato estiver definido para fechado e residir em qualquer ponto depois do seu mínimo
        'significa que temos de fechá-lo até ao mínimo
        If PainelcontratoAberto = False And Painelcontrato.Left > PosicaoRecolhidacontrato Then
            'calculamos o novo número para a posição, sem arredondar (e isto é importante)
            TempX -= Math.Ceiling((Math.Abs(PosicaoRecolhidacontrato) - Math.Abs(Painelcontrato.Left)) * Math.Abs(Velocidade))

            'se o valor calculado estiver para aquém do valor mínimo...
            If TempX <= PosicaoRecolhidacontrato Then
                'desligamos o temporizador para impedir mais movimento
                Deslizadorcontrato.Enabled = False
                '...normalizamos o valor para o mínimo
                TempX = PosicaoRecolhidacontrato
            End If

            'depois do cálculo estar feito e validado, atribuímos o novo valor à posição do Painelcontrato
            Painelcontrato.Left = TempX

            'mandamos recolocar o separador, chamando o método
            RecolocarSeparadorcontrato()
        End If
    End Sub
    Dim a As Integer = 0
    Private Sub PrintContrato_BeginPrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintContrato.BeginPrint
        Me._start = DateTime.Now
        Me.a = 1
    End Sub
    Private _start As DateTime
    Private _page As Integer = 0
    Private Sub PrintContrato_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintContrato.PrintPage
        PrintPreviewDialog.WindowState = FormWindowState.Maximized
        'PrintPreviewDialog.Document.DocumentName = "CONTRATO DE TRABLAHO DE " & txtNome.Text & " " & txtSobreNome.Text

        Dim g As Graphics = e.Graphics
        Dim Negrito As New Font("Verdana", 10, FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Dim Normal As New Font("Verdana", 10, System.Drawing.GraphicsUnit.Point)
        Dim pequena As New Font("Verdana", 8, System.Drawing.GraphicsUnit.Point)
        '------------------------------------------------------------------------------------------
        Dim sublinhado1 As String = " =================================================== "

        Dim empregadora As String = "E M P R E G A D O R A : "
        Dim empresa As String = "Nome : DIPACK LOGÍSTICA LTDA "
        Dim enederço As String = "Sede : Estr. de Itapecerica, 5048, Jardim Jerivá, Säo Paulo - SP "
        Dim cnpj As String = "CNPJ : 03.418.905/0001-74 "
        Dim empregado As String = "E M P R E G A D O :"
        Dim nome As String = "Nome: "
        Dim ctps As String = "CTPS: "
        Dim pis As String = "PIS: "

        Dim data As String = ""
        Dim sublinhado2 As String = "____________________________________   __________________________________"
        Dim sublinha1 As String = "DIPACK LOGÍSTICA LTDA"
        Dim sublinha2 As String = "" '"Nome do Colaborador"
        '------------------------------------------------------------------------------------------------------------------------------------
        nome = nome & Me.txtNome.Text & " " & Me.txtSobreNome.Text
        ctps = ctps & txtCTPS.Text
        pis = pis & txtPIS.Text
        data = data & dtadmissao.Text
        sublinha2 = sublinha2 & txtNome.Text & " " & txtSobreNome.Text
        '------------------------------------------------------------------------------------------------------------------------------------
        If a = 1 Then
            Dim titulo As String = " ACORDO  PARA  COMPENSAÇAO  DE  HORAS  DE  TRABALHO"
            '--------------------------------------------------------------------------------------------------------------------------------
            Dim linha1 As String = "Entre as partes acima qualificadas, fica convencionado, de acordo com o disposto no art. 59º"
            Dim linha2 As String = "e seu parágrafo 2º (aprovado pelo Decreto-lei nº 5.452 de 1º de maio de 1943 - Consolidação"
            Dim linha3 As String = "das Leis  do  Trabalho),  que  o Horário normal do trabalho será o seguinte:"
            Dim semanaTra As String = ""
            Dim horarioTra2 As String = "- Aos domingos - LIVRES"
            Dim horarioTra3 As String = "perfazendo um total de 42 horas semanais."
            Dim horarioTra4 As String = "perfazendo um total de 44 horas semanais."
            Dim linha5 As String = "E, por estarem de pleno acordo, as partes contratantes assinam o presente acordo em duas vias, "
            Dim linha6 As String = "o qual vigorará por tempo indeterminado."
            '-----------------------------------------------------------------------------------------------------------------------------
            semanaTra = semanaTra & "- De " & cbSemanTrabalho.Text & " Das " & cbHoraTrabalho.Text & " com intervalo de 1h00min p/ repouso/alimentação."
            '-----------------------------------------------------------------------------------------------------------------------------
            g.DrawString(titulo, Negrito, Brushes.Black, 160, 50)
            g.DrawString(sublinhado1, Normal, Brushes.Black, 100, 70)
            g.DrawString(empregadora, Negrito, Brushes.Black, 100, 200)
            g.DrawString(empresa, Negrito, Brushes.Green, 100, 220)
            g.DrawString(enederço, Normal, Brushes.Black, 100, 240)
            g.DrawString(cnpj, Normal, Brushes.Black, 100, 260)
            g.DrawString(empregado, Negrito, Brushes.Black, 100, 300)
            g.DrawString(nome, Normal, Brushes.Black, 100, 320)
            g.DrawString(ctps, Normal, Brushes.Black, 100, 340)
            g.DrawString(pis, Normal, Brushes.Black, 100, 360)
            g.DrawString(linha1, Normal, Brushes.Black, 50, 500)
            g.DrawString(linha2, Normal, Brushes.Black, 50, 520)
            g.DrawString(linha3, Normal, Brushes.Black, 50, 540)
            g.DrawString(semanaTra, Normal, Brushes.Black, 50, 580)
            g.DrawString(horarioTra2, Normal, Brushes.Black, 50, 600)
            If cbContrato.Text = "45 (quarenta e cinco dias)" Then
                g.DrawString(horarioTra3, Normal, Brushes.Black, 50, 640)
            End If
            If cbContrato.Text = "40 (quarenta dias)" Then
                g.DrawString(horarioTra4, Normal, Brushes.Black, 50, 640)
            End If
            g.DrawString(linha5, Normal, Brushes.Black, 50, 660)
            g.DrawString(linha6, Normal, Brushes.Black, 50, 680)
            g.DrawString(data, Normal, Brushes.Black, 100, 800)
            g.DrawString(sublinhado2, Normal, Brushes.Black, 100, 1000)
            g.DrawString(sublinha1, Normal, Brushes.Black, 160, 1020)
            g.DrawString(sublinha2, Normal, Brushes.Black, 440, 1020)
            a = a + 1
            e.HasMorePages = True
            Exit Sub
        End If
        '---------------------------------------------------------------------------------------------------------------------------
        If a = 2 Then
            Dim contrato As String = "C O N T R A T O       D E       E X P E R I Ê N C I A"

            Dim linha1 As String = "As partes acima qualificadas, firmam o presente contrato individual de trabalho,  EM CARATER DE EXPERIÊNCIA,"
            Dim linha2 As String = "conforme a letra ' c ', parágrafo 2º, do Artigo 443 da Consolidação das Leis do Trabalho, mediante as  seguin-"
            Dim linha3 As String = "tes cláusulas e condições:"
            Dim linha4 As String = "1) O Empregado trabalhará para a Empregadora, exercendo a função de " & cbCargo.Text
            Dim linha5 As String = "percebendo do salário de  ( " & cbSalario.Text & " ) por mês."
            Dim linha6 As String = "2) O horário a ser obedecido será o seguinte: " & cbHoraTrabalho.Text & " de " & cbSemanTrabalho.Text & ","
            Dim linha7 As String = "com intervalo  de 1h00mim para repouso e alimentação."
            Dim linha8 As String = "3) O empregado é admitido através do presente contrato em caráter experimental pelo prazo  de " & cbContrato.Text
            Dim linha9 As String = "podendo ser prorrogado até o limite do Art. 445 da CLT, sendo que, findo esse prazo, permanecendo o"
            Dim linha10 As String = "empregado a serviço da empregadora, passará a ser por tempo indeterminado."
            Dim linha11 As String = "4) O Empregado é contratado para prestação de serviço junto à PRIMO SCHINCARIOL IND. DE CERVEJAS E REFRIGERANTES S/A,"
            Dim linha12 As String = "sediada  na ROD. RS 115, 14.777, KM 14,5- ARROIO KAMPF, no município de IGREJINHA/RS."
            Dim linha13 As String = "5) O Empregado se compromete a trabalhar em regime de compensação e prorrogação de horas, inclusive  em  pe-"
            Dim linha14 As String = "ríodo noturno, sempre que as necessidades assim o exigirem, observadas as formalidades legais."
            Dim linha15 As String = "6) Obriga-se o Empregado, além de executar com dedicaçäo e lealdade o seu serviço, a cumprir  o  Regulamento"
            Dim linha16 As String = "Interno da Empregadora, as instruçöes de sua administração e as ordens de seus chefes e  superiores  hie-"
            Dim linha17 As String = "rárquicos, relativos às peculariedades dos serviços que lhe forem confiados."
            Dim linha18 As String = "7) O presente contrato reger-se-á pelas normas constituídas na Consolidação das Leis do Trabalho e na legis-"
            Dim linha19 As String = "lação trabalhista não consolidada."
            Dim linha20 As String = "8) Vencido o período experimental e continuando o empregado a prestar serviços à Empregadora, por tempo  in-"
            Dim linha21 As String = "determinado de trabalho."
            'DATA                 = "São Paulo, 02 de Junho de 2011"
            Dim linha23 As String = "E por estarem de pleno acordo, assinam ambas as partes, em duas vias de igual teor, na presença de duas tes-"
            Dim linha24 As String = "temunhas."
            'Dim sublinhado2 As String = "____________________________________   __________________________________"
            'Dim sublinha1 As String = "DIPACK LOGÍSTICA LTDA"
            'Dim sublinha2 As String = "Nome do Colaborador"
            Dim linha27 As String = "T E R M O       D E       P R O R R O G A Ç A O			 "
            'Dim sublinhado1 As String = " =================================================== "		 "
            Dim linha29 As String = "Por mútuo acordo entre as partes, fica o presente contrato de experiência, que deveria  vencer  nesta  data, 			 "
            Dim linha30 As String = "prorrogado até     de                de       .			"
            'Dim sublinhado2 As String = "____________________________________   __________________________________"
            'Dim sublinha1 As String = "DIPACK LOGÍSTICA LTDA"
            'Dim sublinha2 As String = "Nome do Colaborador"
            Dim linha33 As String = "T   E   S   T   E   M   U   N   H   A   S			"
            'Dim sublinhado2 As String = "____________________________________   __________________________________"


            g.DrawString(contrato, Negrito, Brushes.Black, 200, 50)
            g.DrawString(sublinhado1, Normal, Brushes.Black, 100, 70)

            g.DrawString(empregadora, Negrito, Brushes.Black, 100, 100)
            g.DrawString(empresa, Negrito, Brushes.Green, 100, 120)
            g.DrawString(enederço, Normal, Brushes.Black, 100, 140)
            g.DrawString(cnpj, Normal, Brushes.Black, 100, 160)
            g.DrawString(empregado, Negrito, Brushes.Black, 100, 200)
            g.DrawString(nome, Normal, Brushes.Black, 100, 220)
            g.DrawString(ctps, Normal, Brushes.Black, 100, 240)
            g.DrawString(pis, Normal, Brushes.Black, 100, 260)

            g.DrawString(linha1, pequena, Brushes.Black, 50, 300)
            g.DrawString(linha2, pequena, Brushes.Black, 50, 320)
            g.DrawString(linha3, pequena, Brushes.Black, 50, 340)
            g.DrawString(linha4, pequena, Brushes.Black, 50, 360)
            g.DrawString(linha5, pequena, Brushes.Black, 50, 380)
            g.DrawString(linha6, pequena, Brushes.Black, 50, 400)
            g.DrawString(linha7, pequena, Brushes.Black, 50, 420)
            g.DrawString(linha8, pequena, Brushes.Black, 50, 440)
            g.DrawString(linha9, pequena, Brushes.Black, 50, 460)
            g.DrawString(linha10, pequena, Brushes.Black, 50, 480)
            g.DrawString(linha11, pequena, Brushes.Black, 50, 500)
            g.DrawString(linha12, pequena, Brushes.Black, 50, 520)
            g.DrawString(linha13, pequena, Brushes.Black, 50, 540)
            g.DrawString(linha14, pequena, Brushes.Black, 50, 560)
            g.DrawString(linha15, pequena, Brushes.Black, 50, 580)
            g.DrawString(linha16, pequena, Brushes.Black, 50, 600)
            g.DrawString(linha17, pequena, Brushes.Black, 50, 620)
            g.DrawString(linha18, pequena, Brushes.Black, 50, 640)
            g.DrawString(linha19, pequena, Brushes.Black, 50, 660)
            g.DrawString(linha20, pequena, Brushes.Black, 50, 680)
            g.DrawString(linha21, pequena, Brushes.Black, 50, 700)
            'DATA
            g.DrawString(data, Normal, Brushes.Black, 100, 740)

            g.DrawString(linha23, pequena, Brushes.Black, 50, 780)
            g.DrawString(linha24, pequena, Brushes.Black, 50, 800)

            g.DrawString(sublinhado2, Normal, Brushes.Black, 100, 840)
            g.DrawString(sublinha1, Normal, Brushes.Black, 160, 860)
            g.DrawString(sublinha2, Normal, Brushes.Black, 440, 860)
            '"T E R M O       D E       P R O R R O G A Ç A O"
            g.DrawString(linha27, Negrito, Brushes.Black, 240, 900)
            g.DrawString(linha29, pequena, Brushes.Black, 50, 940)
            g.DrawString(linha30, pequena, Brushes.Black, 50, 960)
            g.DrawString(sublinhado2, Normal, Brushes.Black, 100, 1000)
            g.DrawString(sublinha1, Normal, Brushes.Black, 160, 1020)
            g.DrawString(sublinha2, Normal, Brushes.Black, 440, 1020)
            '"T   E   S   T   E   M   U   N   H   A   S
            g.DrawString(linha33, Negrito, Brushes.Black, 280, 1060)
            g.DrawString(sublinhado2, Normal, Brushes.Black, 100, 1100)

            a = a + 1
            e.HasMorePages = True
            Exit Sub
        End If
        '--------------------------------------------------------------------------------------------------------------
        If a = 3 Then
            Dim declaração As String = "D E C L A R A C Ã O    P /    V A L E     T R A N S P O R T E"
            Dim eu As String = ""
            Dim portador As String = ""
            Dim endereço As String = ""
            Dim linha1 As String = "funcionário(a) de empresa DIPACK LOGÍSTICA LTDA "
            Dim linha2 As String = "inscrita no CNPJ/MF sob nº 03.418.905/0001-74, estabelecida n/ Capital à Estr. "
            Dim linha3 As String = "de Itapecerica, 5048,"
            Dim linha4 As String = "prestando serviço junto à PRIMO SCHINCARIOL IND. DE CERVEJAS E REFRIGERANTES S/A.,"
            Dim linha5 As String = "sediada na ROD. RS 115 , 14.777, KM 14,5 ARROIO KAMPF,no município de IGREJINHA/RS,"
            Dim linha6 As String = "DECLARO"
            Dim linha7 As String = " que :"
            Dim linha8 As String = "(   ) NÃO NECESSITO DE VALE TRANSPORTE, TENDO EM VISTA QUE: _______________"
            Dim linha9 As String = "(   ) NECESSITO DIARIAMENTE DE ______ UNIDADES DE TARIFAS DO SERVICO DE"
            Dim linha10 As String = "TRANSPORTE COLETIVO,  CONFORME  DETALHAMENTO A SEGUIR :"
            Dim linha11 As String = "QUANTIDADE DE PASSES"
            Dim linha12 As String = "EMPRESAS DE ÔNIBUS             -------------------             TARIFA - R$"
            Dim linha13 As String = "CASA/TRABALHO                     TRABALHO/CASA"
            Dim linha14 As String = "___________________________________"
            Dim autorização As String = "A  U  T  O  R  I  Z  A  C  Ã  O        D  E         D  E  S  C  O  N  T  O"
            Dim linha15 As String = "AUTORIZO O DESCONTO DE 6% (SEIS POR CENTO) DO MEU SALÁRIO BÁSICO PARA"
            Dim linha16 As String = "PARTICIPAR COMO BENEFICIÁRIO DO PROGRAMA 'VALE TRANSPORTE', COMPROMETENDO-"
            Dim linha17 As String = "-ME A UTILIZAÇÃO DESSE BENEFÍCIO EXCLUSIVAMENTE NO MEU DESLOCAMENTO"
            Dim linha18 As String = "RESIDÊNCIA/TRABALHO E VICE-VERSA, SUJEITANDO-ME AS PENALIDADES PREVISTAS"
            Dim linha19 As String = "EM LEI."


            eu = eu & "Eu, " & Me.txtNome.Text & " " & Me.txtSobreNome.Text & " ,"
            portador = portador & "portador(a) da Carteira de Trabalho e Previd. Social Nº " & txtCTPS.Text
            endereço = endereço & "residente na " & txtRua.Text & " " & txtNomeRua.Text & " " & txtNumero.Text & " " & txtCidade.Text & " " & txtEstado.Text
            '

            g.DrawString(declaração, Negrito, Brushes.Black, 160, 50)
            g.DrawString(sublinhado1, Normal, Brushes.Black, 100, 70)

            g.DrawString(eu, Normal, Brushes.Black, 100, 100)
            g.DrawString(portador, Normal, Brushes.Black, 100, 120)
            g.DrawString(endereço, Normal, Brushes.Black, 100, 140)
            g.DrawString(linha1, Normal, Brushes.Black, 100, 160)
            g.DrawString(linha2, Normal, Brushes.Black, 100, 180)
            g.DrawString(linha3, Normal, Brushes.Black, 100, 200)
            g.DrawString(linha4, Normal, Brushes.Black, 100, 220)
            g.DrawString(linha5, Normal, Brushes.Black, 100, 240)
            g.DrawString(linha6, Negrito, Brushes.Black, 100, 260)
            g.DrawString(linha7, Normal, Brushes.Black, 200, 260)

            g.DrawString(linha8, Normal, Brushes.Black, 100, 360)
            g.DrawString(linha9, Normal, Brushes.Black, 100, 400)
            g.DrawString(linha10, Normal, Brushes.Black, 100, 420)

            g.DrawString(linha11, Negrito, Brushes.Black, 300, 520)

            g.DrawString(linha12, Normal, Brushes.Black, 150, 560)
            g.DrawString(linha13, Normal, Brushes.Black, 250, 600)

            g.DrawString(sublinhado2, Normal, Brushes.Black, 100, 640)

            g.DrawString(data, Normal, Brushes.Black, 100, 700)

            g.DrawString(linha14, Normal, Brushes.Black, 450, 740)
            g.DrawString(sublinha2, Normal, Brushes.Black, 450, 760)

            g.DrawString(declaração, Negrito, Brushes.Black, 200, 820)

            g.DrawString(linha15, Normal, Brushes.Black, 100, 860)
            g.DrawString(linha16, Normal, Brushes.Black, 100, 880)
            g.DrawString(linha17, Normal, Brushes.Black, 100, 900)
            g.DrawString(linha18, Normal, Brushes.Black, 100, 920)
            g.DrawString(linha19, Normal, Brushes.Black, 100, 940)

            g.DrawString(data, Normal, Brushes.Black, 100, 980)

            g.DrawString(linha14, Normal, Brushes.Black, 450, 1020)
            g.DrawString(sublinha2, Normal, Brushes.Black, 450, 1040)

            e.HasMorePages = False
            Exit Sub
        End If
    End Sub
    Private Sub btnPrinAdmissao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrinAdmissao.Click
        PrintPreviewDialog.Document = PrintContrato
        PrintPreviewDialog.WindowState = FormWindowState.Maximized
        PrintPreviewDialog.Document.DocumentName = "CONTRATO DE TRABLAHO DE " & txtNome.Text & " " & txtSobreNome.Text
        PrintPreviewDialog.Text = "CONTRATO DE TRABLAHO DE " & txtNome.Text & " " & txtSobreNome.Text
        'PrintPreviewDialog.ShowDialog()
        PrintContrato.Print()
    End Sub
#End Region
#Region "CRACHÁ"
    '====================================================================================================================
    'ADVERTÊNCIA DO COLABORADOR
    '====================================================================================================================
    'o PainelContaBanco principal
    'Private PainelContaBanco As New Panel
    'o separador que fica visível
    Private WithEvents PainelCrachaSep As New Panel
    'o temporizador responsável por o deslize
    Private WithEvents DeslizadorCracha As New Timer

    'o valor da posição do PainelContaBanco quando recolhido
    Private PosicaoRecolhidaCracha As Integer
    'o valor da posição do PainelContaBanco quando extendido
    Private PosicaoEstendidaCracha As Integer
    'para determinar se o PainelContaBanco está aberto ou fechado
    'a velocidade com que o PainelContaBanco se move
    Private PainelCrachaAberto As Boolean = False
    '(na verdade é a velocidade com que a distância restante se atenua)
    Private Sub Cracha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'definimos o tamanho da form
        'Me.Size = New Size(716, 461)

        'definimos o tamanho dos paineis
        PainelCracha.Size = New Size(910, 630)
        PainelCrachaSep.Size = New Size(32, 32)

        'preparamos o PainelContaBanco separador para apresentar uma imagem
        PainelCrachaSep.BackgroundImageLayout = ImageLayout.Zoom
        'PainelContaBancoSep.BackgroundImage = Me.Icon.ToBitmap.Clone

        'preparamos o PainelContaBanco principal para que o seu movimento se note
        PainelCracha.BackColor = Color.White
        PainelCracha.BorderStyle = BorderStyle.None

        'definimos os valores de funcionamento inicial do temporizador
        DeslizadorCracha.Interval = 1
        DeslizadorCracha.Enabled = False

        'definimos os valores das posições garantidas
        PosicaoRecolhidaCracha = 0 - PainelCracha.Width
        PosicaoEstendidaCracha = 0

        'adicionamos tudo ao form
        Me.Controls.Add(PainelCracha)
        Me.Controls.Add(PainelCrachaSep)

        'ajustamos as posições definitivas dos paineis
        PainelCracha.Top = 40
        PainelCrachaSep.Top = 40
        PainelCracha.Left = 0 - PainelCracha.Width
        PainelCrachaSep.Left = PainelCracha.Left + PainelCracha.Width

    End Sub
    Private Sub RecolocarSeparadorCracha()
        'posiciona o PainelContaBanco separador sempre na mesma posição, dependente da posição do PainelContaBanco principal
        PainelCrachaSep.Left = PainelCracha.Left + PainelCracha.Width
    End Sub
    Private Sub Cracha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCracha.Click
        'se o painel estiver aberto, marca como fechado
        If PainelCrachaAberto = True Then
            'trocamos a posição do painel para fechado
            Me.PainelCracha.BringToFront()
            PainelCrachaAberto = False
            'mas se o painel estiver fechado, marca como aberto
        ElseIf PainelCrachaAberto = False Then
            'trocamos a posição do painel para aberto
            Me.PainelCracha.BringToFront()
            PainelCrachaAberto = True
        End If

        'e por fim, activamos o temporizador para validar as novas ordens de posição
        DeslizadorCracha.Enabled = True
    End Sub
    Private Sub DeslizadorCracha_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeslizadorCracha.Tick
        'declaramos uma variável que possa lidar com valores decimais
        Dim TempX As Double = PainelCracha.Left

        'se o PainelContaBanco estiver definido para aberto e residir em qualquer ponto antes do seu máximo
        'significa que temos de abri-lo até ao máximo
        If PainelCrachaAberto = True And PainelCracha.Left < PosicaoEstendidaCracha Then
            'calculamos o novo número para a posição, sem arredondar (e isto é importante)
            TempX += Math.Ceiling((PosicaoEstendidaCracha - PainelCracha.Left) * Math.Abs(Velocidade))

            'se o valor calculado estiver para além do valor máximo...
            If TempX >= PosicaoEstendidaCracha Then
                'desligamos o temporizador para impedir mais movimento
                DeslizadorCracha.Enabled = False
                '...normalizamos o valor para o máximo
                TempX = PosicaoEstendidaCracha
            End If

            'depois do cálculo estar feito e validado, atribuímos o novo valor à posição do PainelContaBanco
            PainelCracha.Left = TempX

            'mandamos recolocar o separador, chamando o método
            RecolocarSeparadorCracha()
        End If

        'se o PainelContaBanco estiver definido para fechado e residir em qualquer ponto depois do seu mínimo
        'significa que temos de fechá-lo até ao mínimo
        If PainelCrachaAberto = False And PainelCracha.Left > PosicaoRecolhidaCracha Then
            'calculamos o novo número para a posição, sem arredondar (e isto é importante)
            TempX -= Math.Ceiling((Math.Abs(PosicaoRecolhidaCracha) - Math.Abs(PainelCracha.Left)) * Math.Abs(Velocidade))

            'se o valor calculado estiver para aquém do valor mínimo...
            If TempX <= PosicaoRecolhidaCracha Then
                'desligamos o temporizador para impedir mais movimento
                DeslizadorCracha.Enabled = False
                '...normalizamos o valor para o mínimo
                TempX = PosicaoRecolhidaCracha
            End If

            'depois do cálculo estar feito e validado, atribuímos o novo valor à posição do PainelContaBanco
            PainelCracha.Left = TempX

            'mandamos recolocar o separador, chamando o método
            RecolocarSeparadorCracha()
        End If
    End Sub
    Private Sub btnPrintCracha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintCracha.Click
        PrintPreviewDialog.Document = PrintCracha
        PrintPreviewDialog.WindowState = FormWindowState.Maximized
        PrintPreviewDialog.Document.DocumentName = "CRACHÁ DE " & txtNome.Text & " " & txtSobreNome.Text
        PrintPreviewDialog.Text = "CRACHÁ DE " & txtNome.Text & " " & txtSobreNome.Text
        'PrintPreviewDialog.ShowDialog()
        PrintCracha.Print()
    End Sub
    Private Sub PrintCracha_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintCracha.PrintPage
        'Variáveis das fontes
        Dim fonteNegrito As Font
        Dim fonteTitulo As Font
        Dim fonteSubtitulo As Font
        Dim fonteRodape As Font
        Dim fonteNormal As Font
        'define efeitos em fonte
        fonteNegrito = New Font("Arial", 10, FontStyle.Bold)
        fonteTitulo = New Font("Arial", 24, FontStyle.Bold)
        fonteSubtitulo = New Font("Arial", 10, FontStyle.Bold)
        fonteRodape = New Font("Arial", 10)
        fonteNormal = New Font("Arial", 9)

        'divide-se a área de impressão pelo tamanho da fonte subtraindo 10 valores
        Dim linhasporpagina = e.MarginBounds.Height / fonteNormal.GetHeight(e.Graphics) - 10
        'cabeçalho
        Try
            '=======================================================================
        'desenha a bordar
        Dim MyPen As Pen = New Pen(Color.Black, 3)
        e.Graphics.DrawRectangle(MyPen, e.MarginBounds.X, e.MarginBounds.Y, 390, 230)

        'posiciona a imagem
        e.Graphics.DrawImage(picFoto.Image, e.MarginBounds.X + 3, e.MarginBounds.Y + 7, 150, 210)
        e.HasMorePages = False

        'posiciona o logo
        e.Graphics.DrawImage(Image.FromFile(Application.StartupPath & "\LOGO_DIPACK.jpg"), 230, 140)

        'posiciona o nome
        e.Graphics.DrawString(txtNome.Text, fonteTitulo, Brushes.Black, 260, 260)
        e.Graphics.DrawString(txtSobreNome.Text, fonteNegrito, Brushes.Black, 260, 290)
        '=======================================================================
        Catch ex As Exception
            MsgBox("O COBABORADOROR : " & txtNome.Text & " NÃO TEM FOTO")
        End Try
    End Sub
#End Region
    Dim img As Image
    Private Sub dlgAbrir_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dlgAbrir.FileOk
        img = Image.FromFile(dlgAbrir.FileName)
        picFoto.Image = img
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.Image.Save(Application.StartupPath + "\temp.dat", Imaging.ImageFormat.Jpeg)
    End Sub
    Private Sub btnCarregaFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregaFoto.Click
        dlgAbrir.Title = "Selecione a FOTO do Colaborador"
        dlgAbrir.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" & "All files (*.*)|*.*"
        dlgAbrir.ShowDialog()
    End Sub
    Private Sub editar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            abre()
        Catch ex As Exception
            picFoto.Image = picFoto.InitialImage
        End Try
    End Sub
    Private Sub txtCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.Click
        Try
            listaCliente()
        Catch ex As Exception
            txtCliente.UseWaitCursor = False
        End Try
    End Sub
    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        colaboradores.carrega()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub picfotoComunica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class