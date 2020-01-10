Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net
Public Class conecxao
    '-------------------------------------------------------------------------------------------------------------------------
    '  FTP  ------------------------------------------------------------------------------------------------------------------
    Public txtUsername = "radiovid"
    Public txtHost = "radiovidanovafm.com/DIPACK/"
    Public txtPassword = "super007"
    '-------------------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------------------
    '  ENDEREÇO SERVIDOR MySQL   ---------------------------------------------------------------------------------------------
    Public strConn = GetConnection()
    Public conn As New MySqlConnection
    Public myCommand As New MySqlCommand
    Public myAdapter As New MySqlDataAdapter
    Public myData As New DataTable
    Public SQL As String
    '--------------------------------------------------------------------------------------------------------------------------
    '  LISTA colaboradores   --------------------------------------------------------------------------------------------------
    Public Shared DataModule As conecxao
    Public Function GetConnection() As MySqlConnection
        'retorna uma nova conexão com o banco de dados
        Return New MySqlConnection("server=radiovidanovafm.com;user id=radiovid;password=super007;database=radiovid_dipack")
        'Return New MySqlConnection("server=localhost;user id=root;password=super007;database=radiovid_dipack")
    End Function
    '--------------------------------------------------------------------------------------------------------------------------
    Public mMySQLConnectionString As String = "server=radiovidanovafm.com;user id=radiovid;password=super007;database=radiovid_dipack"
    'Public mMySQLConnectionString As String = "server=localhost;user id=root;password=super007;database=radiovid_dipack"
    Public strConexao As New System.Text.StringBuilder
    Public Function strConexaofoto()
        Return strConexao.Append("server=radiovidanovafm.com;user id=radiovid;password=super007;database=radiovid_dipack")
        'Return strConexao.Append("server=localhost;user id=root;password=super007;database=radiovid_dipack")
    End Function
End Class
