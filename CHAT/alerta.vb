Imports System.Windows.Forms
Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class alerta
    Dim dados As New DADOS.conecxao
    Sub UsuarioOnLine() Handles MyBase.Load
        status()
        Me.BringToFront()
    End Sub
    Sub status()
        Try
            verificaOnline()
            localizafoto()
        Catch ex As Exception
            verificaOnline()
            localizafoto()
        End Try
    End Sub
#Region "verifica on-line"
    Sub verificaOnline()
        Try
            Dim ds As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim conn As MySqlConnection = dados.GetConnection()
            Dim sql As String = "Select * from msn where (STATUS = 'ON-LINE') order by NOME"
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            adptr.Fill(ds, "NOME")
            dt = ds.Tables(0)
            For Each dr In dt.Rows
                statusLoad.Text = dr.Item("NOME")
                statusHost.Text = dr.Item("STATUS")
                lblID.Text = dr.Item("ID")
            Next
            dados.strConn.Close()
        Finally
            dados.strConn.Close()
        End Try
    End Sub
#End Region
#Region "localiza foto"
    Sub localizafoto()
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
            lblCargo.Text = pRegistro.Item("CARGO")
            If FotoByte.Length > 0 Then
                Dim FotoStream As IO.MemoryStream = New IO.MemoryStream(FotoByte, True)
                FotoStream.Write(FotoByte, 0, FotoByte.Length)
                Me.picfoto.Image = New Bitmap(FotoStream)
                FotoStream.Close()
            End If
        Catch ex As Exception
        End Try
        Adapter = Nothing
    End Sub
#End Region
#Region "ALERTA NO CANTO"
    Dim max As Integer = Screen.GetWorkingArea(Me).Height - Me.Height + 145
    Dim x As New Integer
    Dim y As Integer = Screen.GetWorkingArea(Me).Height
    Dim i As Integer = 100
    Private Sub Mensagem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        x = Screen.GetWorkingArea(Me).Width
        y = Screen.GetWorkingArea(Me).Height
        Me.Location = New Point(x, y)
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        x = Screen.GetWorkingArea(Me).Width - Me.Width
        If y = max Then
            Timer1.Enabled = False
            Timer2.Enabled = True
        Else
            Me.Location = New Point(x, y)
            y = y - 1
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If i = 30 Then
            Me.Hide()
        Else
            Me.Opacity = i
            i = i - 1
        End If
    End Sub
#End Region
End Class