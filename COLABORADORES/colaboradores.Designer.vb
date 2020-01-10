<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class colaboradores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(colaboradores))
        Me.menuusuario = New System.Windows.Forms.ToolStrip()
        Me.dgcolaboradores = New System.Windows.Forms.DataGrid()
        Me.GBPESQUISA = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.procuraImpime = New System.Windows.Forms.CheckedListBox()
        Me.dlgVisualiza = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnSair = New System.Windows.Forms.ToolStripButton()
        Me.btnAdicionar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnCarregar = New System.Windows.Forms.ToolStripButton()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.menuusuario.SuspendLayout()
        CType(Me.dgcolaboradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBPESQUISA.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuusuario
        '
        Me.menuusuario.BackColor = System.Drawing.Color.Transparent
        Me.menuusuario.Dock = System.Windows.Forms.DockStyle.Right
        Me.menuusuario.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.menuusuario.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.menuusuario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSair, Me.btnAdicionar, Me.btnEditar, Me.btnCarregar})
        Me.menuusuario.Location = New System.Drawing.Point(802, 0)
        Me.menuusuario.Name = "menuusuario"
        Me.menuusuario.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menuusuario.Size = New System.Drawing.Size(70, 462)
        Me.menuusuario.TabIndex = 28
        '
        'dgcolaboradores
        '
        Me.dgcolaboradores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgcolaboradores.BackgroundColor = System.Drawing.Color.White
        Me.dgcolaboradores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgcolaboradores.CaptionBackColor = System.Drawing.Color.White
        Me.dgcolaboradores.DataMember = ""
        Me.dgcolaboradores.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgcolaboradores.Location = New System.Drawing.Point(4, 119)
        Me.dgcolaboradores.Name = "dgcolaboradores"
        Me.dgcolaboradores.Size = New System.Drawing.Size(789, 331)
        Me.dgcolaboradores.TabIndex = 27
        '
        'GBPESQUISA
        '
        Me.GBPESQUISA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBPESQUISA.Controls.Add(Me.btnImprimir)
        Me.GBPESQUISA.Controls.Add(Me.DataGridView1)
        Me.GBPESQUISA.Controls.Add(Me.procuraImpime)
        Me.GBPESQUISA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPESQUISA.ForeColor = System.Drawing.Color.DarkGreen
        Me.GBPESQUISA.Location = New System.Drawing.Point(12, 12)
        Me.GBPESQUISA.Name = "GBPESQUISA"
        Me.GBPESQUISA.Size = New System.Drawing.Size(580, 119)
        Me.GBPESQUISA.TabIndex = 32
        Me.GBPESQUISA.TabStop = False
        Me.GBPESQUISA.Text = ": PESQUISA :"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(499, 83)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 30)
        Me.btnImprimir.TabIndex = 33
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkGreen
        Me.DataGridView1.Location = New System.Drawing.Point(262, 17)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(312, 96)
        Me.DataGridView1.TabIndex = 34
        '
        'procuraImpime
        '
        Me.procuraImpime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.procuraImpime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.procuraImpime.CheckOnClick = True
        Me.procuraImpime.FormattingEnabled = True
        Me.procuraImpime.Location = New System.Drawing.Point(7, 17)
        Me.procuraImpime.Name = "procuraImpime"
        Me.procuraImpime.Size = New System.Drawing.Size(249, 90)
        Me.procuraImpime.TabIndex = 0
        '
        'dlgVisualiza
        '
        Me.dlgVisualiza.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgVisualiza.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgVisualiza.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgVisualiza.Enabled = True
        Me.dlgVisualiza.Icon = CType(resources.GetObject("dlgVisualiza.Icon"), System.Drawing.Icon)
        Me.dlgVisualiza.Name = "dlgVisualiza"
        Me.dlgVisualiza.Visible = False
        '
        'btnSair
        '
        Me.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSair.Image = Global.COLABORADORES.My.Resources.Resources.SAIR
        Me.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(67, 81)
        Me.btnSair.Text = "SAIR"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAdicionar.Image = Global.COLABORADORES.My.Resources.Resources.ADD
        Me.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(67, 81)
        Me.btnAdicionar.Text = "ADICIONAR"
        Me.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEditar
        '
        Me.btnEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEditar.Image = Global.COLABORADORES.My.Resources.Resources.EDITAR
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(67, 81)
        Me.btnEditar.Text = "EDITAR"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnCarregar
        '
        Me.btnCarregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCarregar.Image = Global.COLABORADORES.My.Resources.Resources.ATUALIZA
        Me.btnCarregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(67, 81)
        Me.btnCarregar.Text = "CARREGAR"
        Me.btnCarregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'colaboradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(872, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.GBPESQUISA)
        Me.Controls.Add(Me.dgcolaboradores)
        Me.Controls.Add(Me.menuusuario)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "colaboradores"
        Me.Text = "colaboradores"
        Me.menuusuario.ResumeLayout(False)
        Me.menuusuario.PerformLayout()
        CType(Me.dgcolaboradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBPESQUISA.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAdicionar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCarregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuusuario As System.Windows.Forms.ToolStrip
    Friend WithEvents dgcolaboradores As System.Windows.Forms.DataGrid
    Friend WithEvents GBPESQUISA As System.Windows.Forms.GroupBox
    Friend WithEvents procuraImpime As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents dlgVisualiza As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
End Class
