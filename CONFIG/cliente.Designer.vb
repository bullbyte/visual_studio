<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cliente
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
        Me.LOGO = New System.Windows.Forms.PictureBox()
        Me.menuCliente = New System.Windows.Forms.ToolStrip()
        Me.btnSair = New System.Windows.Forms.ToolStripButton()
        Me.btnDeleta = New System.Windows.Forms.ToolStripButton()
        Me.btnAdicionar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnCarregar = New System.Windows.Forms.ToolStripButton()
        Me.dgClientes = New System.Windows.Forms.DataGrid()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuCliente.SuspendLayout()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LOGO
        '
        Me.LOGO.BackColor = System.Drawing.Color.Transparent
        Me.LOGO.BackgroundImage = Global.CONFIG.My.Resources.Resources.LOGO_DIPACK
        Me.LOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LOGO.Location = New System.Drawing.Point(12, 12)
        Me.LOGO.Name = "LOGO"
        Me.LOGO.Size = New System.Drawing.Size(252, 76)
        Me.LOGO.TabIndex = 34
        Me.LOGO.TabStop = False
        '
        'menuCliente
        '
        Me.menuCliente.BackColor = System.Drawing.Color.Transparent
        Me.menuCliente.Dock = System.Windows.Forms.DockStyle.Right
        Me.menuCliente.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.menuCliente.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.menuCliente.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSair, Me.btnDeleta, Me.btnAdicionar, Me.btnEditar, Me.btnCarregar})
        Me.menuCliente.Location = New System.Drawing.Point(802, 0)
        Me.menuCliente.Name = "menuCliente"
        Me.menuCliente.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menuCliente.Size = New System.Drawing.Size(70, 462)
        Me.menuCliente.TabIndex = 33
        '
        'btnSair
        '
        Me.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSair.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.Red
        Me.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(67, 19)
        Me.btnSair.Text = "SAIR"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnDeleta
        '
        Me.btnDeleta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnDeleta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeleta.Name = "btnDeleta"
        Me.btnDeleta.Size = New System.Drawing.Size(67, 17)
        Me.btnDeleta.Text = "EXCLUIR"
        Me.btnDeleta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(67, 17)
        Me.btnAdicionar.Text = "ADICIONAR"
        Me.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEditar
        '
        Me.btnEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(67, 17)
        Me.btnEditar.Text = "EDITAR"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnCarregar
        '
        Me.btnCarregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCarregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(67, 17)
        Me.btnCarregar.Text = "CARREGAR"
        Me.btnCarregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'dgClientes
        '
        Me.dgClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgClientes.BackgroundColor = System.Drawing.Color.White
        Me.dgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgClientes.CaptionBackColor = System.Drawing.Color.White
        Me.dgClientes.DataMember = ""
        Me.dgClientes.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgClientes.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgClientes.Location = New System.Drawing.Point(12, 70)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.Size = New System.Drawing.Size(787, 392)
        Me.dgClientes.TabIndex = 32
        '
        'cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(872, 462)
        Me.Controls.Add(Me.LOGO)
        Me.Controls.Add(Me.menuCliente)
        Me.Controls.Add(Me.dgClientes)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cliente"
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuCliente.ResumeLayout(False)
        Me.menuCliente.PerformLayout()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LOGO As System.Windows.Forms.PictureBox
    Friend WithEvents menuCliente As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDeleta As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAdicionar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCarregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgClientes As System.Windows.Forms.DataGrid
End Class
