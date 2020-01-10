<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adicionar
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
        Me.lblLembrete = New System.Windows.Forms.Label()
        Me.cbEnviarLembrete = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtLembrete = New System.Windows.Forms.RichTextBox()
        Me.dtLembrete = New System.Windows.Forms.DateTimePicker()
        Me.picLembrete = New System.Windows.Forms.PictureBox()
        CType(Me.picLembrete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNome.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(62, 85)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(72, 20)
        Me.lblNome.TabIndex = 31
        Me.lblNome.Text = "Nome :"
        '
        'lbllembrete
        '
        Me.lblLembrete.AutoSize = True
        Me.lblLembrete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblLembrete.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLembrete.Location = New System.Drawing.Point(24, 54)
        Me.lblLembrete.Name = "lbllembrete"
        Me.lblLembrete.Size = New System.Drawing.Size(106, 20)
        Me.lblLembrete.TabIndex = 30
        Me.lblLembrete.Text = "lembrete :"
        '
        'cbEnviarlembrete
        '
        Me.cbEnviarLembrete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEnviarLembrete.FormattingEnabled = True
        Me.cbEnviarLembrete.Location = New System.Drawing.Point(160, 333)
        Me.cbEnviarLembrete.Name = "cbEnviarlembrete"
        Me.cbEnviarLembrete.Size = New System.Drawing.Size(206, 23)
        Me.cbEnviarLembrete.TabIndex = 28
        Me.cbEnviarLembrete.Text = "   lembrete PARA:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(372, 332)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(67, 23)
        Me.btnCancelar.TabIndex = 26
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(65, 362)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(51, 23)
        Me.btnOK.TabIndex = 25
        Me.btnOK.Text = "Enviar"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtlembrete
        '
        Me.txtLembrete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtLembrete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLembrete.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLembrete.Location = New System.Drawing.Point(41, 110)
        Me.txtLembrete.Name = "txtlembrete"
        Me.txtLembrete.Size = New System.Drawing.Size(398, 213)
        Me.txtLembrete.TabIndex = 23
        Me.txtLembrete.Text = ""
        '
        'dtlembrete
        '
        Me.dtLembrete.CalendarFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtLembrete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtLembrete.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtLembrete.Location = New System.Drawing.Point(47, 333)
        Me.dtLembrete.Name = "dtlembrete"
        Me.dtLembrete.Size = New System.Drawing.Size(107, 23)
        Me.dtLembrete.TabIndex = 24
        '
        'piclembrete
        '
        Me.picLembrete.BackgroundImage = Global.LEMBRETE.My.Resources.Resources.Fundolembrete
        Me.picLembrete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLembrete.Location = New System.Drawing.Point(0, 0)
        Me.picLembrete.Name = "piclembrete"
        Me.picLembrete.Size = New System.Drawing.Size(477, 426)
        Me.picLembrete.TabIndex = 27
        Me.picLembrete.TabStop = False
        '
        'adicionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 428)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblLembrete)
        Me.Controls.Add(Me.cbEnviarLembrete)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtLembrete)
        Me.Controls.Add(Me.dtLembrete)
        Me.Controls.Add(Me.picLembrete)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "adicionar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adicionar"
        CType(Me.picLembrete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lbllembrete As System.Windows.Forms.Label
    Friend WithEvents cbEnviarlembrete As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtlembrete As System.Windows.Forms.RichTextBox
    Friend WithEvents dtlembrete As System.Windows.Forms.DateTimePicker
    Friend WithEvents piclembrete As System.Windows.Forms.PictureBox
End Class
