<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usuarios))
        Me.segundoPlano = New System.ComponentModel.BackgroundWorker()
        Me.txtListaColaborsdores = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txListaColaborsdores = New System.Windows.Forms.Label()
        Me.menuusuario = New System.Windows.Forms.ToolStrip()
        Me.btnSair = New System.Windows.Forms.ToolStripButton()
        Me.btnDeleta = New System.Windows.Forms.ToolStripButton()
        Me.btnAdicionar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnCarregar = New System.Windows.Forms.ToolStripButton()
        Me.dgcolaboradores = New System.Windows.Forms.DataGrid()
        Me.LOGO = New System.Windows.Forms.PictureBox()
        Me.introUser = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.menuusuario.SuspendLayout()
        CType(Me.dgcolaboradores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.introUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtListaColaborsdores
        '
        Me.txtListaColaborsdores.AutoSize = True
        Me.txtListaColaborsdores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtListaColaborsdores.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtListaColaborsdores.Location = New System.Drawing.Point(3, 0)
        Me.txtListaColaborsdores.Name = "txtListaColaborsdores"
        Me.txtListaColaborsdores.Size = New System.Drawing.Size(264, 13)
        Me.txtListaColaborsdores.TabIndex = 6
        Me.txtListaColaborsdores.Text = "Aqui você encontra a lista dos colaboradores"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txListaColaborsdores, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtListaColaborsdores, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(7, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(327, 45)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'txListaColaborsdores
        '
        Me.txListaColaborsdores.AutoSize = True
        Me.txListaColaborsdores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txListaColaborsdores.ForeColor = System.Drawing.Color.DarkGreen
        Me.txListaColaborsdores.Location = New System.Drawing.Point(3, 22)
        Me.txListaColaborsdores.Name = "txListaColaborsdores"
        Me.txListaColaborsdores.Size = New System.Drawing.Size(291, 13)
        Me.txListaColaborsdores.TabIndex = 0
        Me.txListaColaborsdores.Text = "é fácil, apenas clicando no botão Carregar dados."
        '
        'menuusuario
        '
        Me.menuusuario.BackColor = System.Drawing.Color.Transparent
        Me.menuusuario.Dock = System.Windows.Forms.DockStyle.Right
        Me.menuusuario.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.menuusuario.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.menuusuario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSair, Me.btnDeleta, Me.btnAdicionar, Me.btnEditar, Me.btnCarregar})
        Me.menuusuario.Location = New System.Drawing.Point(801, 0)
        Me.menuusuario.Name = "menuusuario"
        Me.menuusuario.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menuusuario.Size = New System.Drawing.Size(71, 462)
        Me.menuusuario.TabIndex = 18
        '
        'btnSair
        '
        Me.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSair.Image = Global.usuarioS.My.Resources.Resources.SAIR
        Me.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(68, 83)
        Me.btnSair.Text = "SAIR"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnDeleta
        '
        Me.btnDeleta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnDeleta.Image = Global.usuarioS.My.Resources.Resources.DELETA
        Me.btnDeleta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeleta.Name = "btnDeleta"
        Me.btnDeleta.Size = New System.Drawing.Size(72, 83)
        Me.btnDeleta.Text = "EXCLUIR"
        Me.btnDeleta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleta.Visible = False
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAdicionar.Image = Global.usuarioS.My.Resources.Resources.ADD
        Me.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(72, 83)
        Me.btnAdicionar.Text = "ADICIONAR"
        Me.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAdicionar.Visible = False
        '
        'btnEditar
        '
        Me.btnEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEditar.Image = Global.usuarioS.My.Resources.Resources.EDITAR
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(68, 83)
        Me.btnEditar.Text = "EDITAR"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnCarregar
        '
        Me.btnCarregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCarregar.Image = Global.usuarioS.My.Resources.Resources.ATUALIZA
        Me.btnCarregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(68, 83)
        Me.btnCarregar.Text = "CARREGAR"
        Me.btnCarregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'dgcolaboradores
        '
        Me.dgcolaboradores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgcolaboradores.BackgroundColor = System.Drawing.Color.White
        Me.dgcolaboradores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgcolaboradores.CaptionBackColor = System.Drawing.Color.White
        Me.dgcolaboradores.DataMember = ""
        Me.dgcolaboradores.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgcolaboradores.Location = New System.Drawing.Point(504, 199)
        Me.dgcolaboradores.Name = "dgcolaboradores"
        Me.dgcolaboradores.Size = New System.Drawing.Size(289, 251)
        Me.dgcolaboradores.TabIndex = 17
        '
        'LOGO
        '
        Me.LOGO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LOGO.BackColor = System.Drawing.Color.Transparent
        Me.LOGO.BackgroundImage = Global.usuarioS.My.Resources.Resources.LOGO_DIPACK
        Me.LOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LOGO.Location = New System.Drawing.Point(525, 142)
        Me.LOGO.Name = "LOGO"
        Me.LOGO.Size = New System.Drawing.Size(252, 76)
        Me.LOGO.TabIndex = 20
        Me.LOGO.TabStop = False
        '
        'introUser
        '
        Me.introUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.introUser.Enabled = True
        Me.introUser.Location = New System.Drawing.Point(6, 114)
        Me.introUser.Name = "introUser"
        Me.introUser.OcxState = CType(resources.GetObject("introUser.OcxState"), System.Windows.Forms.AxHost.State)
        Me.introUser.Size = New System.Drawing.Size(492, 373)
        Me.introUser.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(6, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(492, 437)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(872, 462)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.introUser)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.menuusuario)
        Me.Controls.Add(Me.LOGO)
        Me.Controls.Add(Me.dgcolaboradores)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "usuarios"
        Me.Text = "usuarios"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.menuusuario.ResumeLayout(False)
        Me.menuusuario.PerformLayout()
        CType(Me.dgcolaboradores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.introUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents segundoPlano As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtListaColaborsdores As System.Windows.Forms.Label
    Friend WithEvents btnAdicionar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txListaColaborsdores As System.Windows.Forms.Label
    Friend WithEvents menuusuario As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDeleta As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCarregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents LOGO As System.Windows.Forms.PictureBox
    Friend WithEvents dgcolaboradores As System.Windows.Forms.DataGrid
    Friend WithEvents introUser As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
