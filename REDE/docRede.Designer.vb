<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class docRede
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
        Me.ftpBrowser = New System.Windows.Forms.WebBrowser()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.segundoPlano = New System.ComponentModel.BackgroundWorker()
        Me.btnAtualiza = New System.Windows.Forms.Button()
        Me.dedoDuro = New System.IO.FileSystemWatcher()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.picFundo = New System.Windows.Forms.PictureBox()
        Me.lblNome = New System.Windows.Forms.Label()
        CType(Me.dedoDuro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFundo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ftpBrowser
        '
        Me.ftpBrowser.AllowWebBrowserDrop = False
        Me.ftpBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ftpBrowser.Location = New System.Drawing.Point(0, 36)
        Me.ftpBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.ftpBrowser.Name = "ftpBrowser"
        Me.ftpBrowser.Size = New System.Drawing.Size(651, 443)
        Me.ftpBrowser.TabIndex = 51
        '
        'txtFilename
        '
        Me.txtFilename.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilename.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFilename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFilename.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilename.Location = New System.Drawing.Point(94, 8)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(373, 20)
        Me.txtFilename.TabIndex = 49
        Me.txtFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Location = New System.Drawing.Point(473, 7)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(36, 23)
        Me.btnBrowse.TabIndex = 43
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpload.Location = New System.Drawing.Point(515, 7)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(88, 23)
        Me.btnUpload.TabIndex = 40
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'segundoPlano
        '
        '
        'btnAtualiza
        '
        Me.btnAtualiza.Location = New System.Drawing.Point(13, 6)
        Me.btnAtualiza.Name = "btnAtualiza"
        Me.btnAtualiza.Size = New System.Drawing.Size(75, 23)
        Me.btnAtualiza.TabIndex = 50
        Me.btnAtualiza.Text = "Atualizar"
        Me.btnAtualiza.UseVisualStyleBackColor = True
        '
        'dedoDuro
        '
        Me.dedoDuro.EnableRaisingEvents = True
        Me.dedoDuro.SynchronizingObject = Me
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.BackgroundImage = Global.REDE.My.Resources.Resources.X
        Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSair.Location = New System.Drawing.Point(609, 7)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(30, 23)
        Me.btnSair.TabIndex = 53
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'picFundo
        '
        Me.picFundo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picFundo.BackgroundImage = Global.REDE.My.Resources.Resources.Barra_menu
        Me.picFundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFundo.Location = New System.Drawing.Point(0, -1)
        Me.picFundo.Name = "picFundo"
        Me.picFundo.Size = New System.Drawing.Size(651, 37)
        Me.picFundo.TabIndex = 52
        Me.picFundo.TabStop = False
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(12, 457)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(54, 15)
        Me.lblNome.TabIndex = 54
        Me.lblNome.Text = "lblNome"
        Me.lblNome.Visible = False
        '
        'docRede
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(651, 481)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.ftpBrowser)
        Me.Controls.Add(Me.btnAtualiza)
        Me.Controls.Add(Me.txtFilename)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.picFundo)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "docRede"
        Me.Text = "docRede"
        CType(Me.dedoDuro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFundo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ftpBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents segundoPlano As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnAtualiza As System.Windows.Forms.Button
    Friend WithEvents dedoDuro As System.IO.FileSystemWatcher
    Friend WithEvents picFundo As System.Windows.Forms.PictureBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Public WithEvents lblNome As System.Windows.Forms.Label
End Class
