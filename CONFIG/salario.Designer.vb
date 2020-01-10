<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salario
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
        Me.GBSALARIO = New System.Windows.Forms.GroupBox()
        Me.listaSalario = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.addSalario = New System.Windows.Forms.TextBox()
        Me.GBSALARIO.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBSALARIO
        '
        Me.GBSALARIO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBSALARIO.Controls.Add(Me.listaSalario)
        Me.GBSALARIO.Controls.Add(Me.btnAdd)
        Me.GBSALARIO.Controls.Add(Me.addSalario)
        Me.GBSALARIO.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBSALARIO.ForeColor = System.Drawing.Color.DarkGreen
        Me.GBSALARIO.Location = New System.Drawing.Point(15, 19)
        Me.GBSALARIO.Name = "GBSALARIO"
        Me.GBSALARIO.Size = New System.Drawing.Size(566, 255)
        Me.GBSALARIO.TabIndex = 1
        Me.GBSALARIO.TabStop = False
        Me.GBSALARIO.Text = "   SALARIOS   "
        '
        'listaSalario
        '
        Me.listaSalario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listaSalario.FormattingEnabled = True
        Me.listaSalario.ItemHeight = 15
        Me.listaSalario.Location = New System.Drawing.Point(6, 55)
        Me.listaSalario.Name = "listaSalario"
        Me.listaSalario.Size = New System.Drawing.Size(554, 184)
        Me.listaSalario.TabIndex = 5
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
        'addSalario
        '
        Me.addSalario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addSalario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.addSalario.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addSalario.Location = New System.Drawing.Point(6, 22)
        Me.addSalario.Name = "addSalario"
        Me.addSalario.Size = New System.Drawing.Size(554, 27)
        Me.addSalario.TabIndex = 4
        '
        'salario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 293)
        Me.Controls.Add(Me.GBSALARIO)
        Me.Name = "salario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "salario"
        Me.GBSALARIO.ResumeLayout(False)
        Me.GBSALARIO.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBSALARIO As System.Windows.Forms.GroupBox
    Friend WithEvents listaSalario As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents addSalario As System.Windows.Forms.TextBox
End Class
