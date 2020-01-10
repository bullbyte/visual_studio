<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alerta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(alerta))
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.statusHost = New System.Windows.Forms.Label()
        Me.imgstatus = New System.Windows.Forms.ImageList(Me.components)
        Me.statusLoad = New System.Windows.Forms.Label()
        Me.picfoto = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logo.BackgroundImage = Global.CHAT.My.Resources.Resources.LOGO_DIPACK
        Me.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logo.Location = New System.Drawing.Point(1, 1)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(312, 79)
        Me.logo.TabIndex = 5
        Me.logo.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'statusHost
        '
        Me.statusHost.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.statusHost.AutoSize = True
        Me.statusHost.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusHost.ForeColor = System.Drawing.Color.White
        Me.statusHost.Location = New System.Drawing.Point(81, 119)
        Me.statusHost.Name = "statusHost"
        Me.statusHost.Size = New System.Drawing.Size(71, 18)
        Me.statusHost.TabIndex = 8
        Me.statusHost.Text = "STATUS"
        Me.statusHost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgstatus
        '
        Me.imgstatus.ImageStream = CType(resources.GetObject("imgstatus.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgstatus.TransparentColor = System.Drawing.Color.Transparent
        Me.imgstatus.Images.SetKeyName(0, "checkmark_32.png")
        Me.imgstatus.Images.SetKeyName(1, "warning_32.png")
        Me.imgstatus.Images.SetKeyName(2, "forbidden_32.png")
        '
        'statusLoad
        '
        Me.statusLoad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.statusLoad.AutoSize = True
        Me.statusLoad.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLoad.ForeColor = System.Drawing.Color.White
        Me.statusLoad.ImageList = Me.imgstatus
        Me.statusLoad.Location = New System.Drawing.Point(81, 90)
        Me.statusLoad.Name = "statusLoad"
        Me.statusLoad.Size = New System.Drawing.Size(43, 13)
        Me.statusLoad.TabIndex = 7
        Me.statusLoad.Text = "NOME"
        '
        'picfoto
        '
        Me.picfoto.BackColor = System.Drawing.Color.White
        Me.picfoto.Location = New System.Drawing.Point(12, 86)
        Me.picfoto.Name = "picfoto"
        Me.picfoto.Size = New System.Drawing.Size(63, 51)
        Me.picfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picfoto.TabIndex = 6
        Me.picfoto.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 50
        '
        'lblID
        '
        Me.lblID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(275, 114)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(27, 18)
        Me.lblID.TabIndex = 9
        Me.lblID.Text = "ID"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblID.Visible = False
        '
        'lblCargo
        '
        Me.lblCargo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargo.ForeColor = System.Drawing.Color.White
        Me.lblCargo.ImageList = Me.imgstatus
        Me.lblCargo.Location = New System.Drawing.Point(80, 106)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(50, 13)
        Me.lblCargo.TabIndex = 10
        Me.lblCargo.Text = "CARGO"
        '
        'alerta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(314, 143)
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.statusHost)
        Me.Controls.Add(Me.statusLoad)
        Me.Controls.Add(Me.picfoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "alerta"
        Me.Text = "alerta"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents statusHost As System.Windows.Forms.Label
    Friend WithEvents imgstatus As System.Windows.Forms.ImageList
    Friend WithEvents statusLoad As System.Windows.Forms.Label
    Friend WithEvents picfoto As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblCargo As System.Windows.Forms.Label
End Class
