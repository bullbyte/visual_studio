Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Drawing

Public Class editar
    Dim dsColaborador As DataSet
    Friend usuarios As usuarios
    Dim dados As New DADOS.conecxao
    Dim dsusuario As New DataSet
    Dim user As Integer
    Sub abrefoto() Handles MyBase.Load
        Try
            abre()
            CARREGADADOSUSUARIO()
        Catch ex As Exception
            picFoto.Image = picFoto.InitialImage
        End Try
    End Sub
#Region "SALVA USUÁRIOS"
    Public Sub carregaDados(ByVal ds As DataSet)
        'atribui o datset ds ao dsAluno
        Me.dsColaborador = ds
        'vincula os dados do dataset aos campos do formulário
        Me.lblNome.DataBindings.Add(New Binding("Text", ds, "colaboradores.NOME"))
        Me.lblSobreNome.DataBindings.Add(New Binding("Text", ds, "colaboradores.SOBRENOME"))
        Me.lblID.DataBindings.Add(New Binding("Text", ds, "colaboradores.ID"))
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        'Cryptografia da senha
        Dim cifrado As New DADOS.ClsCrypto()
        txtCifrado.Text = cifrado.clsCrypto(txtSenha.Text, True)
        Dim decifrado As New DADOS.ClsCrypto()
        txtDecifrado.Text = decifrado.clsCrypto(txtCifrado.Text, False)
        '-----------------------------------------------------------------------------------------------------------------------------------------------------
        Dim cmdd As MySqlCommand = New MySqlCommand("SELECT * FROM usuario WHERE NOME = '" & lblNome.Text & "' and SOBRENOME= '" & lblSobreNome.Text & "'", dados.strConn)
        dados.strConn.Open()
        Dim sdr As MySqlDataReader = cmdd.ExecuteReader()
        If (sdr.Read() = True) Then
            If txtusuario.TextLength > 0 Then
                If dados.strConn.State = ConnectionState.Open Then dados.strConn.Close()
                Dim s1 As String = "UPDATE usuario SET NOME = '" & lblNome.Text & "' ,SOBRENOME = '" & lblSobreNome.Text & "', usuario = '" & txtusuario.Text & "', SENHA = '" & txtCifrado.Text & "', NIVEL = '" & cbNivel.Text & "', STATUS = '" & cbAtivado.Text & "', DATA_CADASTRO = '" & dtCadUser.Text & "'  WHERE  NOME = '" & lblNome.Text & "' and SOBRENOME = '" & lblSobreNome.Text & "'"
                Dim cmnd As New MySqlCommand(s1, dados.strConn)
                dados.strConn.Open()
                cmnd.ExecuteNonQuery()
                dados.strConn.Close()
            Else
                MsgBox("Nome Inválido a atualizar o usuario")
            End If
        Else
            Try
                If txtusuario.TextLength > 0 Then
                    If dados.strConn.State = ConnectionState.Open Then dados.strConn.Close()
                    Dim st As String = "INSERT INTO usuario(NOME,SOBRENOME,usuario,SENHA,NIVEL,STATUS,DATA_CADASTRO)VALUES('" & lblNome.Text & "','" & lblSobreNome.Text & "','" & txtusuario.Text & "','" & txtCifrado.Text & "','" & cbNivel.Text & "','" & cbAtivado.Text & "','" & dtCadUser.Text & "')"
                    Dim cmd As New MySqlCommand(st, dados.strConn)
                    dados.strConn.Open()
                    cmd.ExecuteNonQuery()
                    dados.strConn.Close()
                Else
                    MsgBox("nome invalido a salvar novo usuario")
                End If
            Catch ex As Exception
                MsgBox("Erro ao salvar dados na tabela. " & vbCrLf & ex.Message, MsgBoxStyle.Information, "Erro ao salvar dados")
            End Try
        End If
        '------------------------------------------
        'CRIA USER DO msn
        salvaUsermsn()
        'CRIA DIRETÓRIO NO FTP
        criarFTPDiretorio()
        'trás para frente o formulário frmPrincipal
        Me.BringToFront()
    End Sub
#End Region
#Region "CRIA USUARIO FTP"
    Sub criarFTPDiretorio()
        Dim directoryPath As String
        Dim request As WebRequest
        Dim webResp As WebResponse
        Dim USER As String = dados.txtUsername
        Dim PASS As String = dados.txtPassword
        Try
            'Seta o caminho do ftp onde deve ser criado a pasta
            'Note que voce deve passar o caminho completo do ftp
            'mais o nome da pasta que deseja criar
            directoryPath = "ftp://ftp." + dados.txtHost + lblNome.Text + " " + lblSobreNome.Text
            'Cria uma nova requisição com a url do diretório a ser criado
            request = WebRequest.Create(directoryPath)
            'Define o tipo de método que sera utilizado
            'Neste caso MakeDirectory (criar diretorio)
            request.Method = WebRequestMethods.Ftp.MakeDirectory
            'Seta as credenciais para login no ftp
            'user : nome de usuario
            'pass : senha
            request.Credentials = New NetworkCredential(USER, PASS)
            'Realiza o comando no ftp e obtém o codigo de retorno
            webResp = request.GetResponse
        Catch ex As WebException
            'Aqui voce pode utilizar o enum WebExceptionStatus
            'para validar qual o erro ocorreu como no exemplo abaixo
            'Criando diretório no ftp via aplicação desktop – VB.NET « 
            If ex.Status = WebExceptionStatus.ConnectFailure Then
                MessageBox.Show("Houve um erro ao Realizar a Conexão")
            End If
            Me.Close()
        End Try
    End Sub
#End Region
#Region "CARREGA DADOS DO USUARIO"
    Sub CARREGADADOSUSUARIO()
        Try
            Dim ds As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim conn As MySqlConnection = dados.GetConnection()
            Dim sql As String = "Select * from usuario where (ID = '" & lblID.Text & "') order by NOME"
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            adptr.Fill(ds, "NOME")
            dt = ds.Tables(0)
            For Each dr In dt.Rows
                txtusuario.Text = dr.Item("USUARIO")
                txtCifrado.Text = dr.Item("SENHA")
                txtSenha.Text = txtCifrado.Text
                cbNivel.Text = dr.Item("NIVEL")
                cbAtivado.Text = dr.Item("STATUS")
                dtCadUser.Text = dr.Item("DATA_CADASTRO")
            Next
            dados.strConn.Close()
        Catch ex As Exception
            txtusuario.Text = ""
            txtSenha.Text = ""
            cbNivel.Text = ""
            cbAtivado.Text = ""
            dtCadUser.Text = ""
        Finally
            dados.strConn.Close()
        End Try
    End Sub
#End Region
#Region "CRIA USUÁRIO DO msn"
    Sub salvaUsermsn()
        Dim NOME = lblNome.Text + " " + lblSobreNome.Text
        Dim cmdd As MySqlCommand = New MySqlCommand("SELECT * FROM msn WHERE NOME = '" & NOME & "'", dados.strConn)
        dados.strConn.Open()
        Dim sdr As MySqlDataReader = cmdd.ExecuteReader()
        If (sdr.Read() = True) Then
            If txtusuario.TextLength > 0 Then
                If dados.strConn.State = ConnectionState.Open Then dados.strConn.Close()
                Dim s1 As String = "UPDATE msn SET ID = '" & lblID.Text & "', NOME = '" & NOME & "' WHERE  NOME = '" & NOME & "'"
                Dim cmnd As New MySqlCommand(s1, dados.strConn)
                dados.strConn.Open()
                cmnd.ExecuteNonQuery()
                dados.strConn.Close()
            Else
                MsgBox("Nome Inválido a atualizar o usuario msn")
            End If
        Else
            Try
                If txtusuario.TextLength > 0 Then
                    If dados.strConn.State = ConnectionState.Open Then dados.strConn.Close()
                    Dim st As String = "INSERT INTO msn(ID,NOME)VALUES('" & lblID.Text & "','" & NOME & "')"
                    Dim cmd As New MySqlCommand(st, dados.strConn)
                    dados.strConn.Open()
                    cmd.ExecuteNonQuery()
                    dados.strConn.Close()
                Else
                    MsgBox("nome invalido a salvar novo usuario msn")
                End If
            Catch ex As Exception
                MsgBox("Erro ao salvar dados na tabela. " & vbCrLf & ex.Message, MsgBoxStyle.Information, "Erro ao salvar dados")
            End Try
        End If
    End Sub
#End Region
#Region "FOTO"
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
            .CommandText = "select * from colaboradores WHERE ID = '" & lblID.Text & "'"
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
    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class