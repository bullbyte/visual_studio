<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chat
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(chat))
        Me.fotoContato = New System.Windows.Forms.PictureBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.GBNOME = New System.Windows.Forms.GroupBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.data = New System.Windows.Forms.DateTimePicker()
        Me.txtFrase = New System.Windows.Forms.TextBox()
        Me.mensagem = New System.Windows.Forms.RichTextBox()
        Me.digMensagem = New System.Windows.Forms.RichTextBox()
        Me.GBMSG = New System.Windows.Forms.GroupBox()
        Me.GBENVIAMSG = New System.Windows.Forms.GroupBox()
        Me.fotoUser = New System.Windows.Forms.PictureBox()
        Me.btnEnviaMsg = New Glass.GlassButton()
        Me.lblIDuser = New System.Windows.Forms.Label()
        Me.lblUserNome = New System.Windows.Forms.Label()
        Me.tempo = New System.Windows.Forms.Timer(Me.components)
        CType(Me.fotoContato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBNOME.SuspendLayout()
        Me.GBMSG.SuspendLayout()
        Me.GBENVIAMSG.SuspendLayout()
        CType(Me.fotoUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fotoContato
        '
        Me.fotoContato.Location = New System.Drawing.Point(6, 14)
        Me.fotoContato.Name = "fotoContato"
        Me.fotoContato.Size = New System.Drawing.Size(130, 120)
        Me.fotoContato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoContato.TabIndex = 0
        Me.fotoContato.TabStop = False
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.ForeColor = System.Drawing.Color.Teal
        Me.lblNome.Location = New System.Drawing.Point(142, 40)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(37, 15)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "nome"
        '
        'GBNOME
        '
        Me.GBNOME.Controls.Add(Me.lblID)
        Me.GBNOME.Controls.Add(Me.data)
        Me.GBNOME.Controls.Add(Me.txtFrase)
        Me.GBNOME.Controls.Add(Me.lblNome)
        Me.GBNOME.Controls.Add(Me.fotoContato)
        Me.GBNOME.Location = New System.Drawing.Point(12, 2)
        Me.GBNOME.Name = "GBNOME"
        Me.GBNOME.Size = New System.Drawing.Size(493, 140)
        Me.GBNOME.TabIndex = 2
        Me.GBNOME.TabStop = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.ForeColor = System.Drawing.Color.Teal
        Me.lblID.Location = New System.Drawing.Point(143, 117)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(19, 15)
        Me.lblID.TabIndex = 4
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'data
        '
        Me.data.CalendarForeColor = System.Drawing.SystemColors.Desktop
        Me.data.Enabled = False
        Me.data.Location = New System.Drawing.Point(142, 87)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(341, 23)
        Me.data.TabIndex = 3
        '
        'txtFrase
        '
        Me.txtFrase.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFrase.Enabled = False
        Me.txtFrase.ForeColor = System.Drawing.Color.Teal
        Me.txtFrase.Location = New System.Drawing.Point(145, 62)
        Me.txtFrase.Name = "txtFrase"
        Me.txtFrase.Size = New System.Drawing.Size(338, 16)
        Me.txtFrase.TabIndex = 2
        Me.txtFrase.Text = "Digite sua frase de apresentação :"
        '
        'mensagem
        '
        Me.mensagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mensagem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mensagem.Location = New System.Drawing.Point(9, 14)
        Me.mensagem.Name = "mensagem"
        Me.mensagem.ReadOnly = True
        Me.mensagem.Size = New System.Drawing.Size(475, 262)
        Me.mensagem.TabIndex = 3
        Me.mensagem.Text = ""
        '
        'digMensagem
        '
        Me.digMensagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.digMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.digMensagem.Location = New System.Drawing.Point(72, 15)
        Me.digMensagem.Name = "digMensagem"
        Me.digMensagem.Size = New System.Drawing.Size(290, 58)
        Me.digMensagem.TabIndex = 4
        Me.digMensagem.Text = ""
        '
        'GBMSG
        '
        Me.GBMSG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBMSG.Controls.Add(Me.mensagem)
        Me.GBMSG.Location = New System.Drawing.Point(12, 148)
        Me.GBMSG.Name = "GBMSG"
        Me.GBMSG.Size = New System.Drawing.Size(493, 282)
        Me.GBMSG.TabIndex = 5
        Me.GBMSG.TabStop = False
        '
        'GBENVIAMSG
        '
        Me.GBENVIAMSG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBENVIAMSG.Controls.Add(Me.fotoUser)
        Me.GBENVIAMSG.Controls.Add(Me.digMensagem)
        Me.GBENVIAMSG.Location = New System.Drawing.Point(12, 436)
        Me.GBENVIAMSG.Name = "GBENVIAMSG"
        Me.GBENVIAMSG.Size = New System.Drawing.Size(368, 80)
        Me.GBENVIAMSG.TabIndex = 6
        Me.GBENVIAMSG.TabStop = False
        '
        'fotoUser
        '
        Me.fotoUser.Location = New System.Drawing.Point(9, 14)
        Me.fotoUser.Name = "fotoUser"
        Me.fotoUser.Size = New System.Drawing.Size(57, 60)
        Me.fotoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoUser.TabIndex = 4
        Me.fotoUser.TabStop = False
        '
        'btnEnviaMsg
        '
        Me.btnEnviaMsg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviaMsg.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEnviaMsg.Enabled = False
        Me.btnEnviaMsg.Location = New System.Drawing.Point(391, 445)
        Me.btnEnviaMsg.Name = "btnEnviaMsg"
        Me.btnEnviaMsg.Size = New System.Drawing.Size(114, 71)
        Me.btnEnviaMsg.TabIndex = 5
        Me.btnEnviaMsg.Text = "enviar"
        '
        'lblIDuser
        '
        Me.lblIDuser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIDuser.AutoSize = True
        Me.lblIDuser.Location = New System.Drawing.Point(332, 519)
        Me.lblIDuser.Name = "lblIDuser"
        Me.lblIDuser.Size = New System.Drawing.Size(42, 15)
        Me.lblIDuser.TabIndex = 7
        Me.lblIDuser.Text = "meuID"
        Me.lblIDuser.Visible = False
        '
        'lblUserNome
        '
        Me.lblUserNome.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUserNome.AutoSize = True
        Me.lblUserNome.Location = New System.Drawing.Point(18, 519)
        Me.lblUserNome.Name = "lblUserNome"
        Me.lblUserNome.Size = New System.Drawing.Size(38, 15)
        Me.lblUserNome.TabIndex = 8
        Me.lblUserNome.Text = "Nome"
        '
        'tempo
        '
        Me.tempo.Enabled = True
        '
        'chat
        '
        Me.AcceptButton = Me.btnEnviaMsg
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(517, 550)
        Me.Controls.Add(Me.lblUserNome)
        Me.Controls.Add(Me.lblIDuser)
        Me.Controls.Add(Me.btnEnviaMsg)
        Me.Controls.Add(Me.GBENVIAMSG)
        Me.Controls.Add(Me.GBMSG)
        Me.Controls.Add(Me.GBNOME)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "chat"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "chat Dipack"
        CType(Me.fotoContato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBNOME.ResumeLayout(False)
        Me.GBNOME.PerformLayout()
        Me.GBMSG.ResumeLayout(False)
        Me.GBENVIAMSG.ResumeLayout(False)
        CType(Me.fotoUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fotoContato As System.Windows.Forms.PictureBox
    Friend WithEvents GBNOME As System.Windows.Forms.GroupBox
    Friend WithEvents txtFrase As System.Windows.Forms.TextBox
    Friend WithEvents mensagem As System.Windows.Forms.RichTextBox
    Friend WithEvents digMensagem As System.Windows.Forms.RichTextBox
    Friend WithEvents GBMSG As System.Windows.Forms.GroupBox
    Friend WithEvents GBENVIAMSG As System.Windows.Forms.GroupBox
    Public WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents btnEnviaMsg As Glass.GlassButton
    Friend WithEvents data As System.Windows.Forms.DateTimePicker
    Friend WithEvents fotoUser As System.Windows.Forms.PictureBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblIDuser As System.Windows.Forms.Label
    Public WithEvents lblUserNome As System.Windows.Forms.Label
    Friend WithEvents tempo As System.Windows.Forms.Timer
End Class
