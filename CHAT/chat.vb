Imports MySql.Data.MySqlClient
Imports System.Drawing
Public Class chat
    Dim dados As New DADOS.conecxao
#Region "LISTA DE IDS DO MSN"
    Sub listaContatoMSN() Handles MyBase.Load
        Try
            Dim ds As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim conn As MySqlConnection = dados.GetConnection()
            Dim sql As String = "Select * from msn where (NOME = '" & lblNome.Text & "') order by NOME"
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            adptr.Fill(ds, "NOME")
            dt = ds.Tables(0)
            For Each dr In dt.Rows
                lblID.Text = dr.Item("ID")
            Next
            dados.strConn.Close()
        Finally
            dados.strConn.Close()
        End Try
        listaFrasemsn()
        abreFoto()
        listaUserMSN()
        abreFotoUsuario()
        listaMensagens()
        atualiza()
    End Sub
    Sub listaUserMSN()
        Try
            Dim ds As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim conn As MySqlConnection = dados.GetConnection()
            Dim sql As String = "Select * from msn where (NOME = '" & lblUserNome.Text & "') order by NOME"
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            adptr.Fill(ds, "NOME")
            dt = ds.Tables(0)
            For Each dr In dt.Rows
                lblIDuser.Text = dr.Item("ID")
            Next
            dados.strConn.Close()
        Finally
            dados.strConn.Close()
        End Try
    End Sub
#End Region
#Region "LISTA DE FRASE DO COLABORADOR"
    Sub listaFrasemsn()
        Dim ID, CARGO
        Try
            Dim ds As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim conn As MySqlConnection = dados.GetConnection()
            Dim sql As String = "Select * from colaboradores where (ID = '" & lblID.Text & "') order by NOME"
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            adptr.Fill(ds, "NOME")
            dt = ds.Tables(0)
            For Each dr In dt.Rows
                ID = dr.Item("ID")
                CARGO = dr.Item("CARGO")
                txtFrase.Text = CARGO & " - Nº ID: " & ID
            Next
            dados.strConn.Close()
        Finally
            dados.strConn.Close()
        End Try
    End Sub
#End Region
#Region "FOTO"
    Sub abreFoto()
        Dim retorno As Boolean = False
        Dim dbConexao As MySqlConnection
        Dim vComando As New MySqlCommand
        Dim Adapter As New MySqlDataAdapter
        Dim Tabela As New DataTable
        Dim pRegistro As DataRow
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
                Me.fotoContato.Image = New Bitmap(FotoStream)
                FotoStream.Close()
            End If
        Catch ex As Exception
        End Try
        Adapter = Nothing
    End Sub
    Sub abreFotoUsuario()
        Dim retorno As Boolean = False
        Dim dbConexao As MySqlConnection
        Dim vComando As New MySqlCommand
        Dim Adapter As New MySqlDataAdapter
        Dim Tabela As New DataTable
        Dim pRegistro As DataRow
        dados.strConexaofoto()
        Try
            dbConexao = New MySqlConnection(dados.strConexao.ToString)
            dbConexao.Open()
        Catch ex As Exception
        End Try
        With vComando
            .CommandText = "select * from colaboradores WHERE ID = '" & lblIDuser.Text & "'"
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
                Me.fotoUser.Image = New Bitmap(FotoStream)
                FotoStream.Close()
            End If
        Catch ex As Exception
        End Try
        Adapter = Nothing
    End Sub
#End Region
#Region "LISTA MENSAGENS"
    Sub listaMensagens()
        Try
            Dim ds As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim conn As MySqlConnection = dados.GetConnection()
            Dim sql As String = "Select * from chat where (NOME = '" & lblUserNome.Text & "') AND (PARA = '" & lblNome.Text & "') AND (DIA = '" & data.Text & "') OR (NOME = '" & lblNome.Text & "') AND (PARA = '" & lblUserNome.Text & "') AND (DIA = '" & data.Text & "') order by HORA"
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            adptr.Fill(ds, "NOME")
            dt = ds.Tables(0)
            mensagem.Clear()
            For Each dr In dt.Rows
                mensagem.Text += dr.Item("NOME") & Environment.NewLine & _
                    dr.Item("MSG") & Environment.NewLine & _
                    Environment.NewLine
            Next
            dados.strConn.Close()
        Finally
            dados.strConn.Close()
        End Try
    End Sub
#Region "TEMPO DE ATUALIZAÇÃO DAS MSG'S"
    Dim tim As New System.Windows.Forms.Timer
    Structure LASTINPUTINFO
        Public cbSize As Integer
        Public dwTime As Integer
    End Structure
    Private Declare Function GetLastInputInfo Lib "user32" (ByRef plii As LASTINPUTINFO) As Boolean
    Private Declare Function GetTickCount Lib "kernel32" () As Int32
    Public Sub tim_Tick(ByVal sender As Object, ByVal e As EventArgs)
        Dim lii As LASTINPUTINFO
        Dim Inatividade As Integer
        lii.cbSize = Len(lii)
        GetLastInputInfo(lii)
        Inatividade = Val(FormatNumber((GetTickCount() - lii.dwTime) / 1000, 0))

        If Inatividade = 3 Then    ' aqui entram os segundos de inatividade (60 segundos equivalem a 1 minuto)
            listaMensagens()
            Me.BringToFront()
        End If
    End Sub
#End Region
    Sub atualiza()
        Try
            tim.Interval = 200
            AddHandler tim.Tick, AddressOf tim_Tick
            tim.Start()
            If tim.Interval = 3 Then
                atualiza()
            End If
        Catch ex As Exception
            atualiza()
        End Try
    End Sub
#End Region
    Sub msg()
        If digMensagem.TextLength > 0 Then

            Dim st As String = "INSERT INTO chat(NOME,PARA,MSG,DIA,HORA)VALUES('" & lblUserNome.Text & "','" & lblNome.Text & "','" & digMensagem.Text & "','" & data.Text & "','" & Now() & "')" 'data
            Dim cmd As New MySqlCommand(st, dados.strConn)
            dados.strConn.Open()
            cmd.ExecuteNonQuery()
            dados.strConn.Close()

            listaMensagens()

            digMensagem.ResetText()
            digMensagem.Focus()

        Else
            MsgBox("Digite a mensagem primeiro")
        End If
    End Sub
    Private Sub btnEnviaMsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviaMsg.Click
        msg()
    End Sub
    Private Sub digMensagem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles digMensagem.TextChanged
        If digMensagem.Text <> "" Then
            btnEnviaMsg.Enabled = True
        Else
            btnEnviaMsg.Enabled = False
        End If
    End Sub
End Class