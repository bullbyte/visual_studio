Imports System.IO
Imports System.Net
Imports System.Threading
Imports System.Windows.Forms
Public Class docRede
    Dim dados As New DADOS.conecxao
    Dim TextArray As String() = New String() {"ftp://", dados.txtUsername, ":", dados.txtPassword, "@", dados.txtHost}
    Dim FileOpen As New System.Windows.Forms.OpenFileDialog
    Dim filename As String
    Private Sub docRede_Load() Handles MyBase.Load
        segundoPlano.RunWorkerAsync()
    End Sub
    Private Sub segundoPlano_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles segundoPlano.DoWork
        Me.ftpBrowser.Navigate(String.Concat(TextArray) + lblNome.Text)
    End Sub
    Private Sub btnAtualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualiza.Click
        Me.ftpBrowser.Navigate(String.Concat(TextArray))
    End Sub
    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        Try
            My.Computer.Network.UploadFile(txtFilename.Text, "ftp://" & dados.txtHost & txtFilename.Text, dados.txtUsername, dados.txtPassword, True, 200, FileIO.UICancelOption.ThrowException)
            ftpBrowser.Refresh()
        Catch Ex As Exception
            System.Windows.Forms.MessageBox.Show(Ex.Message)
            ftpBrowser.Refresh()
        End Try
    End Sub
    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        FileOpen.ShowDialog()
        filename = FileOpen.SafeFileName
        txtFilename.Text = filename
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Public Sub New(ByVal nomeUser As String)
        InitializeComponent()
        lblNome.Text = nomeUser
    End Sub
End Class