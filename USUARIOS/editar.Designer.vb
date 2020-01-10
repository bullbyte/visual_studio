<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editar))
        Me.GBNOME = New System.Windows.Forms.GroupBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblSobreNome = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.txtDecifrado = New System.Windows.Forms.TextBox()
        Me.lblfoto = New System.Windows.Forms.Label()
        Me.txtCifrado = New System.Windows.Forms.TextBox()
        Me.GBusuario = New System.Windows.Forms.GroupBox()
        Me.lbsenha = New System.Windows.Forms.Label()
        Me.lbusuario = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.MaskedTextBox()
        Me.txtusuario = New System.Windows.Forms.MaskedTextBox()
        Me.GBFOTO = New System.Windows.Forms.GroupBox()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.cbNivel = New System.Windows.Forms.ComboBox()
        Me.dtCadUser = New System.Windows.Forms.DateTimePicker()
        Me.cbAtivado = New System.Windows.Forms.ComboBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.GBNOME.SuspendLayout()
        Me.GBusuario.SuspendLayout()
        Me.GBFOTO.SuspendLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBNOME
        '
        Me.GBNOME.Controls.Add(Me.lblID)
        Me.GBNOME.Controls.Add(Me.lblSobreNome)
        Me.GBNOME.Controls.Add(Me.lblNome)
        Me.GBNOME.Controls.Add(Me.cb1)
        Me.GBNOME.Controls.Add(Me.txtCPF)
        Me.GBNOME.Controls.Add(Me.txtDecifrado)
        Me.GBNOME.Controls.Add(Me.lblfoto)
        Me.GBNOME.Controls.Add(Me.txtCifrado)
        Me.GBNOME.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBNOME.ForeColor = System.Drawing.Color.DarkGreen
        Me.GBNOME.Location = New System.Drawing.Point(12, 12)
        Me.GBNOME.Name = "GBNOME"
        Me.GBNOME.Size = New System.Drawing.Size(263, 100)
        Me.GBNOME.TabIndex = 32
        Me.GBNOME.TabStop = False
        Me.GBNOME.Text = "NOME"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(6, 71)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 14)
        Me.lblID.TabIndex = 44
        Me.lblID.Text = "ID"
        '
        'lblSobreNome
        '
        Me.lblSobreNome.AutoSize = True
        Me.lblSobreNome.Location = New System.Drawing.Point(6, 49)
        Me.lblSobreNome.Name = "lblSobreNome"
        Me.lblSobreNome.Size = New System.Drawing.Size(75, 14)
        Me.lblSobreNome.TabIndex = 2
        Me.lblSobreNome.Text = "sobrenome"
        '
        'lblNome
        '
        Me.lblNome.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(6, 25)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(41, 14)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "nome"
        Me.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(294, 112)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(142, 22)
        Me.cb1.TabIndex = 42
        Me.cb1.Visible = False
        '
        'txtCPF
        '
        Me.txtCPF.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPF.Location = New System.Drawing.Point(361, 61)
        Me.txtCPF.Mask = "000,000,000-00"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(77, 21)
        Me.txtCPF.TabIndex = 43
        '
        'txtDecifrado
        '
        Me.txtDecifrado.Location = New System.Drawing.Point(294, 84)
        Me.txtDecifrado.Name = "txtDecifrado"
        Me.txtDecifrado.Size = New System.Drawing.Size(63, 22)
        Me.txtDecifrado.TabIndex = 40
        '
        'lblfoto
        '
        Me.lblfoto.AutoSize = True
        Me.lblfoto.Location = New System.Drawing.Point(363, 88)
        Me.lblfoto.Name = "lblfoto"
        Me.lblfoto.Size = New System.Drawing.Size(72, 14)
        Me.lblfoto.TabIndex = 35
        Me.lblfoto.Text = "NomeFOTO"
        '
        'txtCifrado
        '
        Me.txtCifrado.Location = New System.Drawing.Point(294, 61)
        Me.txtCifrado.Name = "txtCifrado"
        Me.txtCifrado.Size = New System.Drawing.Size(53, 22)
        Me.txtCifrado.TabIndex = 39
        '
        'GBusuario
        '
        Me.GBusuario.Controls.Add(Me.lbsenha)
        Me.GBusuario.Controls.Add(Me.lbusuario)
        Me.GBusuario.Controls.Add(Me.txtSenha)
        Me.GBusuario.Controls.Add(Me.txtusuario)
        Me.GBusuario.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBusuario.ForeColor = System.Drawing.Color.DarkGreen
        Me.GBusuario.Location = New System.Drawing.Point(13, 124)
        Me.GBusuario.Name = "GBusuario"
        Me.GBusuario.Size = New System.Drawing.Size(262, 91)
        Me.GBusuario.TabIndex = 33
        Me.GBusuario.TabStop = False
        Me.GBusuario.Text = "Nome de Usuário"
        '
        'lbsenha
        '
        Me.lbsenha.AutoSize = True
        Me.lbsenha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbsenha.Location = New System.Drawing.Point(134, 32)
        Me.lbsenha.Name = "lbsenha"
        Me.lbsenha.Size = New System.Drawing.Size(44, 13)
        Me.lbsenha.TabIndex = 3
        Me.lbsenha.Text = "Senha :"
        '
        'lbusuario
        '
        Me.lbusuario.AutoSize = True
        Me.lbusuario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbusuario.Location = New System.Drawing.Point(11, 32)
        Me.lbusuario.Name = "lbusuario"
        Me.lbusuario.Size = New System.Drawing.Size(95, 13)
        Me.lbusuario.TabIndex = 2
        Me.lbusuario.Text = "Nome de Usuário :"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(134, 51)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(117, 22)
        Me.txtSenha.TabIndex = 2
        Me.txtSenha.Text = "   Senha :"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(11, 51)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtusuario.Size = New System.Drawing.Size(117, 22)
        Me.txtusuario.TabIndex = 1
        Me.txtusuario.Text = "   Usuáuio :"
        '
        'GBFOTO
        '
        Me.GBFOTO.Controls.Add(Me.picFoto)
        Me.GBFOTO.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBFOTO.ForeColor = System.Drawing.Color.DarkGreen
        Me.GBFOTO.Location = New System.Drawing.Point(281, 12)
        Me.GBFOTO.Name = "GBFOTO"
        Me.GBFOTO.Size = New System.Drawing.Size(196, 203)
        Me.GBFOTO.TabIndex = 34
        Me.GBFOTO.TabStop = False
        Me.GBFOTO.Text = "FOTO"
        '
        'picFoto
        '
        Me.picFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFoto.Location = New System.Drawing.Point(6, 21)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(184, 171)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFoto.TabIndex = 0
        Me.picFoto.TabStop = False
        '
        'cbNivel
        '
        Me.cbNivel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbNivel.FormattingEnabled = True
        Me.cbNivel.Items.AddRange(New Object() {"USER", "ADMIN"})
        Me.cbNivel.Location = New System.Drawing.Point(13, 221)
        Me.cbNivel.Name = "cbNivel"
        Me.cbNivel.Size = New System.Drawing.Size(80, 21)
        Me.cbNivel.TabIndex = 40
        Me.cbNivel.Text = "Nível de Sistema:"
        '
        'dtCadUser
        '
        Me.dtCadUser.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtCadUser.Location = New System.Drawing.Point(257, 222)
        Me.dtCadUser.Name = "dtCadUser"
        Me.dtCadUser.Size = New System.Drawing.Size(220, 21)
        Me.dtCadUser.TabIndex = 39
        '
        'cbAtivado
        '
        Me.cbAtivado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbAtivado.FormattingEnabled = True
        Me.cbAtivado.Items.AddRange(New Object() {"ATIVADO", "DESATIVADO"})
        Me.cbAtivado.Location = New System.Drawing.Point(124, 221)
        Me.cbAtivado.Name = "cbAtivado"
        Me.cbAtivado.Size = New System.Drawing.Size(103, 21)
        Me.cbAtivado.TabIndex = 41
        Me.cbAtivado.Text = "   Ativado :"
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(12, 248)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(88, 28)
        Me.btnSalvar.TabIndex = 37
        Me.btnSalvar.Text = "&Salvar"
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(106, 248)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(96, 28)
        Me.btnFechar.TabIndex = 38
        Me.btnFechar.Text = "&Fechar"
        '
        'editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(489, 285)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbNivel)
        Me.Controls.Add(Me.dtCadUser)
        Me.Controls.Add(Me.cbAtivado)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.GBFOTO)
        Me.Controls.Add(Me.GBusuario)
        Me.Controls.Add(Me.GBNOME)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "editar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "editar"
        Me.GBNOME.ResumeLayout(False)
        Me.GBNOME.PerformLayout()
        Me.GBusuario.ResumeLayout(False)
        Me.GBusuario.PerformLayout()
        Me.GBFOTO.ResumeLayout(False)
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBNOME As System.Windows.Forms.GroupBox
    Friend WithEvents lblSobreNome As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents cb1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDecifrado As System.Windows.Forms.TextBox
    Friend WithEvents lblfoto As System.Windows.Forms.Label
    Friend WithEvents txtCifrado As System.Windows.Forms.TextBox
    Friend WithEvents GBusuario As System.Windows.Forms.GroupBox
    Friend WithEvents lbsenha As System.Windows.Forms.Label
    Friend WithEvents lbusuario As System.Windows.Forms.Label
    Friend WithEvents txtSenha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtusuario As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GBFOTO As System.Windows.Forms.GroupBox
    Friend WithEvents picFoto As System.Windows.Forms.PictureBox
    Friend WithEvents cbNivel As System.Windows.Forms.ComboBox
    Friend WithEvents dtCadUser As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbAtivado As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class
