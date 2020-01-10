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
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.menuColaborador = New System.Windows.Forms.ToolStrip()
        Me.btnFechar = New System.Windows.Forms.ToolStripButton()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.menuColaborador.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(13, 13)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(100, 20)
        Me.txtNome.TabIndex = 0
        '
        'menuColaborador
        '
        Me.menuColaborador.BackColor = System.Drawing.Color.Transparent
        Me.menuColaborador.Dock = System.Windows.Forms.DockStyle.Right
        Me.menuColaborador.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.menuColaborador.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.menuColaborador.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFechar, Me.btnSalvar})
        Me.menuColaborador.Location = New System.Drawing.Point(740, 0)
        Me.menuColaborador.Name = "menuColaborador"
        Me.menuColaborador.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menuColaborador.Size = New System.Drawing.Size(50, 451)
        Me.menuColaborador.TabIndex = 8
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(47, 17)
        Me.btnFechar.Text = "SAIR"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(47, 17)
        Me.btnSalvar.Text = "SALVAR"
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'editar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 451)
        Me.Controls.Add(Me.menuColaborador)
        Me.Controls.Add(Me.txtNome)
        Me.Name = "editar"
        Me.Text = "editar"
        Me.menuColaborador.ResumeLayout(False)
        Me.menuColaborador.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents menuColaborador As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalvar As System.Windows.Forms.ToolStripButton
End Class
