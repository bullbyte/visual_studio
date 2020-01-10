Public Class upLoad
    Dim FileOpen As New System.Windows.Forms.OpenFileDialog
    Dim filename As String
    Dim dados As New DADOS.conecxao
    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        Try
            My.Computer.Network.UploadFile(txtFilename.Text, "ftp://" & dados.txtHost & Me.Text & "/" & txtFilename.Text, dados.txtUsername, dados.txtPassword, True, 200, FileIO.UICancelOption.ThrowException)
            Me.Close()
        Catch Ex As Exception
            System.Windows.Forms.MessageBox.Show(Ex.Message)
        End Try
    End Sub
    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        FileOpen.ShowDialog()
        filename = FileOpen.SafeFileName
        txtFilename.Text = filename
    End Sub
End Class