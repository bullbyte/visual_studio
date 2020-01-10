<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lembrete
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
        Me.lblNome = New System.Windows.Forms.Label()
        Me.menuusuario = New System.Windows.Forms.ToolStrip()
        Me.btnSair = New System.Windows.Forms.ToolStripButton()
        Me.btnDeleta = New System.Windows.Forms.ToolStripButton()
        Me.btnAdicionar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnCarregar = New System.Windows.Forms.ToolStripButton()
        Me.dglembrete = New System.Windows.Forms.DataGrid()
        Me.txListaColaborsdores = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtListaColaborsdores = New System.Windows.Forms.Label()
        Me.LOGO = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menuusuario.SuspendLayout()
        CType(Me.dglembrete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(372, 31)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(110, 13)
        Me.lblNome.TabIndex = 33
        Me.lblNome.Text = "Nome do Colaborador"
        '
        'menuusuario
        '
        Me.menuusuario.BackColor = System.Drawing.Color.Transparent
        Me.menuusuario.Dock = System.Windows.Forms.DockStyle.Right
        Me.menuusuario.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.menuusuario.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.menuusuario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSair, Me.btnDeleta, Me.btnAdicionar, Me.btnEditar, Me.btnCarregar})
        Me.menuusuario.Location = New System.Drawing.Point(797, 0)
        Me.menuusuario.Name = "menuusuario"
        Me.menuusuario.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menuusuario.Size = New System.Drawing.Size(75, 462)
        Me.menuusuario.TabIndex = 29
        '
        'btnSair
        '
        Me.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSair.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.Red
        Me.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(72, 19)
        Me.btnSair.Text = "SAIR"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnDeleta
        '
        Me.btnDeleta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnDeleta.Image = Global.lembrete.My.Resources.Resources.EXCLUIR
        Me.btnDeleta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeleta.Name = "btnDeleta"
        Me.btnDeleta.Size = New System.Drawing.Size(72, 83)
        Me.btnDeleta.Text = "EXCLUIR"
        Me.btnDeleta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAdicionar.Image = Global.lembrete.My.Resources.Resources.ADICIONAR
        Me.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(72, 83)
        Me.btnAdicionar.Text = "ADICIONAR"
        Me.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEditar
        '
        Me.btnEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(72, 19)
        Me.btnEditar.Text = "EDITAR"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEditar.Visible = False
        '
        'btnCarregar
        '
        Me.btnCarregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCarregar.Image = Global.lembrete.My.Resources.Resources.ATUALIZA
        Me.btnCarregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(72, 83)
        Me.btnCarregar.Text = "CARREGAR"
        Me.btnCarregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'dglembrete
        '
        Me.dglembrete.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dglembrete.BackgroundColor = System.Drawing.Color.White
        Me.dglembrete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dglembrete.CaptionBackColor = System.Drawing.Color.White
        Me.dglembrete.DataMember = ""
        Me.dglembrete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dglembrete.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dglembrete.Location = New System.Drawing.Point(93, 115)
        Me.dglembrete.Name = "dglembrete"
        Me.dglembrete.Size = New System.Drawing.Size(650, 335)
        Me.dglembrete.TabIndex = 28
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txListaColaborsdores, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtListaColaborsdores, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(327, 45)
        Me.TableLayoutPanel1.TabIndex = 32
        '
        'txtListaColaborsdores
        '
        Me.txtListaColaborsdores.AutoSize = True
        Me.txtListaColaborsdores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtListaColaborsdores.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtListaColaborsdores.Location = New System.Drawing.Point(3, 0)
        Me.txtListaColaborsdores.Name = "txtListaColaborsdores"
        Me.txtListaColaborsdores.Size = New System.Drawing.Size(238, 13)
        Me.txtListaColaborsdores.TabIndex = 6
        Me.txtListaColaborsdores.Text = "Aqui você encontra a lista dos lembretes"
        '
        'LOGO
        '
        Me.LOGO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LOGO.BackColor = System.Drawing.Color.Transparent
        Me.LOGO.BackgroundImage = Global.lembrete.My.Resources.Resources.LOGO_DIPACK
        Me.LOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LOGO.Location = New System.Drawing.Point(304, 47)
        Me.LOGO.Name = "LOGO"
        Me.LOGO.Size = New System.Drawing.Size(252, 76)
        Me.LOGO.TabIndex = 31
        Me.LOGO.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 437)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'lembrete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(872, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.LOGO)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.menuusuario)
        Me.Controls.Add(Me.dglembrete)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "lembrete"
        Me.menuusuario.ResumeLayout(False)
        Me.menuusuario.PerformLayout()
        CType(Me.dglembrete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents menuusuario As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDeleta As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAdicionar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCarregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dglembrete As System.Windows.Forms.DataGrid
    Friend WithEvents txListaColaborsdores As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtListaColaborsdores As System.Windows.Forms.Label
    Friend WithEvents LOGO As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
