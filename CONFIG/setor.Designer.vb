<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setor
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
        Me.GBSETOR = New System.Windows.Forms.GroupBox()
        Me.listaSetor = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.addSetor = New System.Windows.Forms.TextBox()
        Me.GBSETOR.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBSETOR
        '
        Me.GBSETOR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBSETOR.Controls.Add(Me.listaSetor)
        Me.GBSETOR.Controls.Add(Me.btnAdd)
        Me.GBSETOR.Controls.Add(Me.addSetor)
        Me.GBSETOR.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBSETOR.ForeColor = System.Drawing.Color.DarkGreen
        Me.GBSETOR.Location = New System.Drawing.Point(15, 15)
        Me.GBSETOR.Name = "GBSETOR"
        Me.GBSETOR.Size = New System.Drawing.Size(566, 255)
        Me.GBSETOR.TabIndex = 0
        Me.GBSETOR.TabStop = False
        Me.GBSETOR.Text = "   SETORES   "
        '
        'listaSetor
        '
        Me.listaSetor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listaSetor.FormattingEnabled = True
        Me.listaSetor.ItemHeight = 15
        Me.listaSetor.Location = New System.Drawing.Point(6, 55)
        Me.listaSetor.Name = "listaSetor"
        Me.listaSetor.Size = New System.Drawing.Size(554, 184)
        Me.listaSetor.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.Honeydew
        Me.btnAdd.BackgroundImage = Global.CONFIG.My.Resources.Resources.add
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Location = New System.Drawing.Point(534, 24)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(24, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'addSetor
        '
        Me.addSetor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addSetor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.addSetor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addSetor.Location = New System.Drawing.Point(6, 22)
        Me.addSetor.Name = "addSetor"
        Me.addSetor.Size = New System.Drawing.Size(554, 27)
        Me.addSetor.TabIndex = 4
        '
        'setor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(596, 293)
        Me.Controls.Add(Me.GBSETOR)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "setor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDITAR SETOR"
        Me.GBSETOR.ResumeLayout(False)
        Me.GBSETOR.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBSETOR As System.Windows.Forms.GroupBox
    Friend WithEvents listaSetor As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents addSetor As System.Windows.Forms.TextBox
End Class
