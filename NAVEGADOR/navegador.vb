Imports System.Threading
Public Class navegador
    Private Sub navegador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        segundoPlano.RunWorkerAsync()
    End Sub
    Private Sub WebBrowser_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WebBrowser.ProgressChanged
        Try
            If Progress.Value <= e.MaximumProgress Then
                Progress.Maximum = e.MaximumProgress
                If e.CurrentProgress >= Progress.Minimum Then
                    Progress.Value = e.CurrentProgress
                    Progress.Visible = True
                Else
                    Progress.Value = 0
                    Progress.Visible = False
                End If
            Else
                Progress.Value = 0
                Progress.Visible = False
                Progress.Maximum = e.MaximumProgress
            End If
        Catch ex As Exception
            Progress.Value = 0
            Progress.Visible = False
            Return
        End Try
    End Sub
    Private Sub segundoPlano_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles segundoPlano.DoWork
        'Progress.Value = 0
    End Sub
End Class
