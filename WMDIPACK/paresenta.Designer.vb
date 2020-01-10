<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paresenta
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(paresenta))
        Me.Dipackcom = New System.Windows.Forms.ToolStripMenuItem()
        Me.separador = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfigSistema = New System.Windows.Forms.ToolStripMenuItem()
        Me.Acesse = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebMail = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tempo = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.segundoPlano = New System.ComponentModel.BackgroundWorker()
        Me.icone = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.menuPrincipal = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.centralDipack = New System.Windows.Forms.ToolStripMenuItem()
        Me.Rede = New System.Windows.Forms.ToolStripMenuItem()
        Me.Terminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.intro = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.menuPrincipal.SuspendLayout()
        CType(Me.intro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dipackcom
        '
        Me.Dipackcom.Name = "Dipackcom"
        Me.Dipackcom.Size = New System.Drawing.Size(190, 26)
        Me.Dipackcom.Text = "dipack.com.br"
        '
        'separador
        '
        Me.separador.BackColor = System.Drawing.Color.DarkGreen
        Me.separador.ForeColor = System.Drawing.Color.DarkGreen
        Me.separador.Name = "separador"
        Me.separador.Size = New System.Drawing.Size(206, 6)
        '
        'ConfigSistema
        '
        Me.ConfigSistema.Name = "ConfigSistema"
        Me.ConfigSistema.Size = New System.Drawing.Size(209, 26)
        Me.ConfigSistema.Text = "Confg. Sistema"
        '
        'Acesse
        '
        Me.Acesse.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WebMail, Me.Dipackcom})
        Me.Acesse.Name = "Acesse"
        Me.Acesse.Size = New System.Drawing.Size(209, 26)
        Me.Acesse.Text = "Acesse Aqui "
        Me.Acesse.ToolTipText = "Acesse o nossso site da web !"
        '
        'WebMail
        '
        Me.WebMail.Image = Global.WMDIPACK.My.Resources.Resources.webMail
        Me.WebMail.Name = "WebMail"
        Me.WebMail.Size = New System.Drawing.Size(190, 26)
        Me.WebMail.Text = "WebMail"
        '
        'Tempo
        '
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.ForeColor = System.Drawing.Color.DarkOrange
        Me.ProgressBar.Location = New System.Drawing.Point(2, 202)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(839, 10)
        Me.ProgressBar.TabIndex = 0
        '
        'segundoPlano
        '
        '
        'icone
        '
        Me.icone.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.icone.ContextMenuStrip = Me.menuPrincipal
        Me.icone.Icon = CType(resources.GetObject("icone.Icon"), System.Drawing.Icon)
        Me.icone.Tag = ""
        Me.icone.Text = "DIPACK Intralogística"
        Me.icone.Visible = True
        '
        'menuPrincipal
        '
        Me.menuPrincipal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuPrincipal.ImageScalingSize = New System.Drawing.Size(25, 20)
        Me.menuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.centralDipack, Me.Acesse, Me.separador, Me.Rede, Me.ConfigSistema, Me.Terminar})
        Me.menuPrincipal.Name = "CMS"
        Me.menuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menuPrincipal.Size = New System.Drawing.Size(210, 162)
        '
        'centralDipack
        '
        Me.centralDipack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.centralDipack.Image = Global.WMDIPACK.My.Resources.Resources.DIPCAK
        Me.centralDipack.Name = "centralDipack"
        Me.centralDipack.Size = New System.Drawing.Size(209, 26)
        Me.centralDipack.Text = "Central DIPACK"
        '
        'Rede
        '
        Me.Rede.Name = "Rede"
        Me.Rede.Size = New System.Drawing.Size(209, 26)
        Me.Rede.Text = "Rede"
        '
        'Terminar
        '
        Me.Terminar.Image = Global.WMDIPACK.My.Resources.Resources._exit
        Me.Terminar.Name = "Terminar"
        Me.Terminar.Size = New System.Drawing.Size(209, 26)
        Me.Terminar.Text = "Terminar"
        '
        'intro
        '
        Me.intro.Enabled = True
        Me.intro.Location = New System.Drawing.Point(1, 1)
        Me.intro.Name = "intro"
        Me.intro.OcxState = CType(resources.GetObject("intro.OcxState"), System.Windows.Forms.AxHost.State)
        Me.intro.Size = New System.Drawing.Size(840, 213)
        Me.intro.TabIndex = 3
        '
        'paresenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(843, 213)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.intro)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "paresenta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.menuPrincipal.ResumeLayout(False)
        CType(Me.intro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebMail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Dipackcom As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents separador As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Rede As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigSistema As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Acesse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents centralDipack As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents Tempo As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents segundoPlano As System.ComponentModel.BackgroundWorker
    Friend WithEvents icone As System.Windows.Forms.NotifyIcon
    Friend WithEvents menuPrincipal As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Terminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents intro As AxShockwaveFlashObjects.AxShockwaveFlash

End Class
