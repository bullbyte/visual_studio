<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iFRAME
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(iFRAME))
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.statusNome = New System.Windows.Forms.ToolStripStatusLabel()
        Me.hoje = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menuLinkRapido = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnMinimizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestaurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GBLOGIN = New System.Windows.Forms.GroupBox()
        Me.txtCifrado = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtDecifrado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.MaskedTextBox()
        Me.txtusuario = New System.Windows.Forms.MaskedTextBox()
        Me.pbLogin = New System.Windows.Forms.PictureBox()
        Me.GBENVINDO = New System.Windows.Forms.GroupBox()
        Me.lblHorario = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblCountdown = New System.Windows.Forms.Label()
        Me.lblcontador = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblnome = New System.Windows.Forms.Label()
        Me.pbLoginOn = New System.Windows.Forms.PictureBox()
        Me.menuIframe = New System.Windows.Forms.ToolStrip()
        Me.btnConfig = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menuBid = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuNovo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.add = New System.Windows.Forms.ToolStripMenuItem()
        Me.addSetor = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSair = New System.Windows.Forms.ToolStripButton()
        Me.docRede = New System.Windows.Forms.ToolStripButton()
        Me.btnusuarios = New System.Windows.Forms.ToolStripButton()
        Me.btnColaborador = New System.Windows.Forms.ToolStripButton()
        Me.btnlembrete = New System.Windows.Forms.ToolStripButton()
        Me.addSalario = New System.Windows.Forms.ToolStripMenuItem()
        Me.Status.SuspendLayout()
        Me.GBLOGIN.SuspendLayout()
        CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBENVINDO.SuspendLayout()
        CType(Me.pbLoginOn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuIframe.SuspendLayout()
        Me.SuspendLayout()
        '
        'Status
        '
        Me.Status.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusNome, Me.hoje, Me.menuLinkRapido})
        Me.Status.Location = New System.Drawing.Point(0, 579)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(864, 22)
        Me.Status.TabIndex = 37
        Me.Status.Text = "StatusStrip1"
        '
        'statusNome
        '
        Me.statusNome.Name = "statusNome"
        Me.statusNome.Size = New System.Drawing.Size(19, 17)
        Me.statusNome.Text = "    "
        '
        'hoje
        '
        Me.hoje.Name = "hoje"
        Me.hoje.Size = New System.Drawing.Size(801, 17)
        Me.hoje.Spring = True
        '
        'menuLinkRapido
        '
        Me.menuLinkRapido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.menuLinkRapido.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMinimizar, Me.RestaurarToolStripMenuItem})
        Me.menuLinkRapido.Image = Global.iFRAME.My.Resources.Resources.lupe
        Me.menuLinkRapido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuLinkRapido.Name = "menuLinkRapido"
        Me.menuLinkRapido.Size = New System.Drawing.Size(29, 20)
        Me.menuLinkRapido.Text = "ToolStripDropDownButton1"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.CheckOnClick = True
        Me.btnMinimizar.Image = Global.iFRAME.My.Resources.Resources.minimizar
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.btnMinimizar.Size = New System.Drawing.Size(177, 22)
        Me.btnMinimizar.Text = "Minimizar"
        '
        'RestaurarToolStripMenuItem
        '
        Me.RestaurarToolStripMenuItem.Name = "RestaurarToolStripMenuItem"
        Me.RestaurarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RestaurarToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RestaurarToolStripMenuItem.Text = "Restaurar"
        '
        'GBLOGIN
        '
        Me.GBLOGIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBLOGIN.Controls.Add(Me.txtCifrado)
        Me.GBLOGIN.Controls.Add(Me.btnOK)
        Me.GBLOGIN.Controls.Add(Me.txtDecifrado)
        Me.GBLOGIN.Controls.Add(Me.Label6)
        Me.GBLOGIN.Controls.Add(Me.Label4)
        Me.GBLOGIN.Controls.Add(Me.txtSenha)
        Me.GBLOGIN.Controls.Add(Me.txtusuario)
        Me.GBLOGIN.Controls.Add(Me.pbLogin)
        Me.GBLOGIN.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBLOGIN.ForeColor = System.Drawing.Color.DarkGreen
        Me.GBLOGIN.Location = New System.Drawing.Point(602, 99)
        Me.GBLOGIN.Name = "GBLOGIN"
        Me.GBLOGIN.Size = New System.Drawing.Size(250, 124)
        Me.GBLOGIN.TabIndex = 40
        Me.GBLOGIN.TabStop = False
        Me.GBLOGIN.Text = "LOGIN DE USUÁRIO"
        '
        'txtCifrado
        '
        Me.txtCifrado.Location = New System.Drawing.Point(222, 46)
        Me.txtCifrado.Name = "txtCifrado"
        Me.txtCifrado.Size = New System.Drawing.Size(22, 23)
        Me.txtCifrado.TabIndex = 20
        Me.txtCifrado.Visible = False
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(102, 90)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(36, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtDecifrado
        '
        Me.txtDecifrado.Location = New System.Drawing.Point(222, 20)
        Me.txtDecifrado.Name = "txtDecifrado"
        Me.txtDecifrado.Size = New System.Drawing.Size(22, 23)
        Me.txtDecifrado.TabIndex = 19
        Me.txtDecifrado.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Senha de Usuário :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nome de Usuário :"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(6, 90)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(90, 23)
        Me.txtSenha.TabIndex = 1
        Me.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(6, 40)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(132, 23)
        Me.txtusuario.TabIndex = 0
        Me.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbLogin
        '
        Me.pbLogin.BackgroundImage = Global.iFRAME.My.Resources.Resources.USER
        Me.pbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLogin.Location = New System.Drawing.Point(144, 19)
        Me.pbLogin.Name = "pbLogin"
        Me.pbLogin.Size = New System.Drawing.Size(100, 94)
        Me.pbLogin.TabIndex = 0
        Me.pbLogin.TabStop = False
        '
        'GBENVINDO
        '
        Me.GBENVINDO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBENVINDO.Controls.Add(Me.lblHorario)
        Me.GBENVINDO.Controls.Add(Me.lblID)
        Me.GBENVINDO.Controls.Add(Me.lblCountdown)
        Me.GBENVINDO.Controls.Add(Me.lblcontador)
        Me.GBENVINDO.Controls.Add(Me.Label9)
        Me.GBENVINDO.Controls.Add(Me.lblnome)
        Me.GBENVINDO.Controls.Add(Me.pbLoginOn)
        Me.GBENVINDO.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBENVINDO.ForeColor = System.Drawing.Color.DarkGreen
        Me.GBENVINDO.Location = New System.Drawing.Point(602, 99)
        Me.GBENVINDO.Name = "GBENVINDO"
        Me.GBENVINDO.Size = New System.Drawing.Size(250, 124)
        Me.GBENVINDO.TabIndex = 42
        Me.GBENVINDO.TabStop = False
        Me.GBENVINDO.Text = "BEM - VINDO"
        Me.GBENVINDO.Visible = False
        '
        'lblHorario
        '
        Me.lblHorario.AutoSize = True
        Me.lblHorario.Location = New System.Drawing.Point(8, 46)
        Me.lblHorario.Name = "lblHorario"
        Me.lblHorario.Size = New System.Drawing.Size(24, 15)
        Me.lblHorario.TabIndex = 4
        Me.lblHorario.Text = "TM"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(36, 70)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 15)
        Me.lblID.TabIndex = 3
        Me.lblID.Text = "ID"
        '
        'lblCountdown
        '
        Me.lblCountdown.AutoSize = True
        Me.lblCountdown.Location = New System.Drawing.Point(99, 91)
        Me.lblCountdown.Name = "lblCountdown"
        Me.lblCountdown.Size = New System.Drawing.Size(24, 15)
        Me.lblCountdown.TabIndex = 2
        Me.lblCountdown.Text = "TM"
        '
        'lblcontador
        '
        Me.lblcontador.AutoSize = True
        Me.lblcontador.Location = New System.Drawing.Point(9, 91)
        Me.lblcontador.Name = "lblcontador"
        Me.lblcontador.Size = New System.Drawing.Size(91, 15)
        Me.lblcontador.TabIndex = 0
        Me.lblcontador.Text = "Tempo Osioso :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ID :"
        '
        'lblnome
        '
        Me.lblnome.AutoSize = True
        Me.lblnome.Location = New System.Drawing.Point(9, 22)
        Me.lblnome.Name = "lblnome"
        Me.lblnome.Size = New System.Drawing.Size(46, 15)
        Me.lblnome.TabIndex = 0
        Me.lblnome.Text = "nome :"
        '
        'pbLoginOn
        '
        Me.pbLoginOn.BackgroundImage = Global.iFRAME.My.Resources.Resources.USER
        Me.pbLoginOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLoginOn.Location = New System.Drawing.Point(144, 19)
        Me.pbLoginOn.Name = "pbLoginOn"
        Me.pbLoginOn.Size = New System.Drawing.Size(100, 94)
        Me.pbLoginOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoginOn.TabIndex = 0
        Me.pbLoginOn.TabStop = False
        '
        'menuIframe
        '
        Me.menuIframe.BackgroundImage = Global.iFRAME.My.Resources.Resources.Barra_menu_up
        Me.menuIframe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menuIframe.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuIframe.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.menuIframe.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.menuIframe.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnConfig, Me.btnSair, Me.docRede, Me.btnusuarios, Me.btnColaborador, Me.btnlembrete})
        Me.menuIframe.Location = New System.Drawing.Point(0, 0)
        Me.menuIframe.Name = "menuIframe"
        Me.menuIframe.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.menuIframe.Size = New System.Drawing.Size(864, 86)
        Me.menuIframe.TabIndex = 0
        Me.menuIframe.Text = "ToolStrip1"
        '
        'btnConfig
        '
        Me.btnConfig.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuBid, Me.menuClientes, Me.add})
        Me.btnConfig.ForeColor = System.Drawing.Color.White
        Me.btnConfig.Image = Global.iFRAME.My.Resources.Resources.ConfigSistemaInfo
        Me.btnConfig.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(77, 83)
        Me.btnConfig.Text = "CONFIG"
        Me.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnConfig.ToolTipText = "CONFIGURAÇÃO DO SISTEMA"
        '
        'menuBid
        '
        Me.menuBid.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenuNovo})
        Me.menuBid.Name = "menuBid"
        Me.menuBid.Size = New System.Drawing.Size(221, 22)
        Me.menuBid.Text = "CONTRATO DE TRABALHO"
        '
        'subMenuNovo
        '
        Me.subMenuNovo.Name = "subMenuNovo"
        Me.subMenuNovo.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.subMenuNovo.Size = New System.Drawing.Size(218, 22)
        Me.subMenuNovo.Text = "NOVO CONTRATO"
        '
        'menuClientes
        '
        Me.menuClientes.Name = "menuClientes"
        Me.menuClientes.Size = New System.Drawing.Size(221, 22)
        Me.menuClientes.Text = "EMPRESA CLIENTE"
        '
        'add
        '
        Me.add.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addSetor, Me.addSalario})
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(221, 22)
        Me.add.Text = "ADD"
        '
        'addSetor
        '
        Me.addSetor.Name = "addSetor"
        Me.addSetor.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.addSetor.Size = New System.Drawing.Size(169, 22)
        Me.addSetor.Text = "SETORES"
        '
        'btnSair
        '
        Me.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSair.Image = Global.iFRAME.My.Resources.Resources._exit
        Me.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(68, 83)
        Me.btnSair.ToolTipText = "FECHAR JANELA"
        '
        'docRede
        '
        Me.docRede.ForeColor = System.Drawing.Color.White
        Me.docRede.Image = Global.iFRAME.My.Resources.Resources.REDE
        Me.docRede.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.docRede.Name = "docRede"
        Me.docRede.Size = New System.Drawing.Size(90, 83)
        Me.docRede.Text = "DOCUMENTOS"
        Me.docRede.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.docRede.ToolTipText = "DOCUMENTOS NA REDE"
        '
        'btnusuarios
        '
        Me.btnusuarios.ForeColor = System.Drawing.Color.White
        Me.btnusuarios.Image = Global.iFRAME.My.Resources.Resources.USER
        Me.btnusuarios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnusuarios.Name = "btnusuarios"
        Me.btnusuarios.Size = New System.Drawing.Size(68, 83)
        Me.btnusuarios.Text = "USUÁRIOS"
        Me.btnusuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnColaborador
        '
        Me.btnColaborador.ForeColor = System.Drawing.Color.White
        Me.btnColaborador.Image = Global.iFRAME.My.Resources.Resources.COLABOR
        Me.btnColaborador.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnColaborador.Name = "btnColaborador"
        Me.btnColaborador.Size = New System.Drawing.Size(108, 83)
        Me.btnColaborador.Text = "COLABORADORES"
        Me.btnColaborador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnColaborador.ToolTipText = "LISTA DOS colaboradores ATIVADOS"
        '
        'btnlembrete
        '
        Me.btnlembrete.ForeColor = System.Drawing.Color.White
        Me.btnlembrete.Image = Global.iFRAME.My.Resources.Resources.lembrete
        Me.btnlembrete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnlembrete.Name = "btnlembrete"
        Me.btnlembrete.Size = New System.Drawing.Size(68, 83)
        Me.btnlembrete.Text = "LEMBRETE"
        Me.btnlembrete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnlembrete.ToolTipText = "lembreteS"
        '
        'addSalario
        '
        Me.addSalario.Name = "addSalario"
        Me.addSalario.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.addSalario.Size = New System.Drawing.Size(169, 22)
        Me.addSalario.Text = "SALARIOS"
        '
        'iFRAME
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(864, 601)
        Me.ControlBox = False
        Me.Controls.Add(Me.GBENVINDO)
        Me.Controls.Add(Me.GBLOGIN)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.menuIframe)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MinimizeBox = False
        Me.Name = "iFRAME"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DIPACK Intralogística"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.GBLOGIN.ResumeLayout(False)
        Me.GBLOGIN.PerformLayout()
        CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBENVINDO.ResumeLayout(False)
        Me.GBENVINDO.PerformLayout()
        CType(Me.pbLoginOn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuIframe.ResumeLayout(False)
        Me.menuIframe.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuBid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents docRede As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnusuarios As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnColaborador As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnlembrete As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuIframe As System.Windows.Forms.ToolStrip
    Friend WithEvents btnConfig As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Status As System.Windows.Forms.StatusStrip
    Friend WithEvents GBLOGIN As System.Windows.Forms.GroupBox
    Friend WithEvents txtCifrado As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtDecifrado As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSenha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtusuario As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pbLogin As System.Windows.Forms.PictureBox
    Friend WithEvents hoje As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents statusNome As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GBENVINDO As System.Windows.Forms.GroupBox
    Friend WithEvents lblHorario As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblCountdown As System.Windows.Forms.Label
    Friend WithEvents lblcontador As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblnome As System.Windows.Forms.Label
    Friend WithEvents pbLoginOn As System.Windows.Forms.PictureBox
    Friend WithEvents menuLinkRapido As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnMinimizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestaurarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subMenuNovo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents addSetor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents addSalario As System.Windows.Forms.ToolStripMenuItem
End Class
