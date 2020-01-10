<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class navegador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.segundoPlano = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'WebBrowser
        '
        Me.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(1020, 491)
        Me.WebBrowser.TabIndex = 0
        Me.WebBrowser.Url = New System.Uri("http://webmail.dipack.com.br/", System.UriKind.Absolute)
        '
        'Progress
        '
        Me.Progress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Progress.ForeColor = System.Drawing.Color.DarkGreen
        Me.Progress.Location = New System.Drawing.Point(50, 481)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(885, 10)
        Me.Progress.TabIndex = 1
        '
        'segundoPlano
        '
        '
        'navegador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1020, 491)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.WebBrowser)
        Me.Name = "navegador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WEB DIPACK"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents Progress As System.Windows.Forms.ProgressBar
    Friend WithEvents segundoPlano As System.ComponentModel.BackgroundWorker

End Class
