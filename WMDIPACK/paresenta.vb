Public Class paresenta
    Private Sub apresenta_Load() Handles MyBase.Load
        intro.Movie = (Application.StartupPath & "\show.swf")
        segundoPlano.RunWorkerAsync()
    End Sub
    Private Sub paresenta_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        icone.Visible = False
    End Sub
    Private Sub segundoPlano_DoWork() Handles segundoPlano.DoWork
        ProgressBar_Click()
    End Sub
    Private Sub segundoPlano_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles segundoPlano.RunWorkerCompleted
        Tempo.Start()
    End Sub
    Public Sub Tempo_Tick() Handles Tempo.Tick
        If ProgressBar.Value >= 100 Then
            Tempo.Stop()
            ProgressBar.Value = 0
            Me.Hide()
            icone.Visible = True
        Else
            Application.DoEvents()
            Me.WindowState = FormWindowState.Normal
            Me.Visible = True
            'System.Threading.Thread.Sleep(100)
            ProgressBar.Value = ProgressBar.Value + 1
            icone.Visible = False
        End If
    End Sub
    Public Sub ProgressBar_Click() Handles ProgressBar.Click
    End Sub
    Private Sub WebMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebMail.Click
        Dim navegador As New NAVEGADOR.navegador
        navegador.ShowDialog()
        'System.Diagnostics.Process.Start("http://webmail.dipack.com.br/")
    End Sub
    Private Sub Dipackcom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dipackcom.Click
        System.Diagnostics.Process.Start("http://www.dipack.com.br")
    End Sub
    Private Sub Terminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Terminar.Click
        Application.Exit()
    End Sub
    Private Sub centralDipack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles centralDipack.Click
        Dim _found As Boolean = False
        For Each _openForm As Form In Application.OpenForms
            If TypeOf _openForm Is iFRAME.iFRAME Then
                _openForm.Focus()
                _found = True
            End If
        Next
        If Not _found Then
            Dim iFRAME As New iFRAME.iFRAME()
            iFRAME.ShowDialog()
            iFRAME.BringToFront()
        End If
    End Sub
    Private Sub _iFRAME(ByVal sender As Object, ByVal e As System.EventArgs) Handles icone.DoubleClick
        Dim _found As Boolean = False
        For Each _openForm As Form In Application.OpenForms
            If TypeOf _openForm Is iFRAME.iFRAME Then
                _openForm.Focus()
                _found = True
            End If
        Next
        If Not _found Then
            Dim iFRAME As New iFRAME.iFRAME()
            iFRAME.ShowDialog()
            iFRAME.BringToFront()
        End If
    End Sub
End Class
