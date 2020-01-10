<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frame
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
        Me.lblRede = New System.Windows.Forms.Label()
        Me.docNaRede = New System.Windows.Forms.Label()
        Me.enviaPara = New System.Windows.Forms.ComboBox()
        Me.dedoDuro = New System.IO.FileSystemWatcher()
        Me.totalcolaborinativo = New System.Windows.Forms.Label()
        Me.totalcolaborativo = New System.Windows.Forms.Label()
        Me.totalcolabor = New System.Windows.Forms.Label()
        Me.segundoP = New System.ComponentModel.BackgroundWorker()
        Me.GBCONTACOLABORADOR = New System.Windows.Forms.GroupBox()
        Me.picColabor = New System.Windows.Forms.PictureBox()
        Me.GBREDE = New System.Windows.Forms.GroupBox()
        Me.PicDocRede = New System.Windows.Forms.PictureBox()
        Me.GBmsn = New System.Windows.Forms.GroupBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.fraze = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.msn = New System.Windows.Forms.ComboBox()
        Me.lblUsermsn = New System.Windows.Forms.Label()
        Me.picMessenger = New System.Windows.Forms.PictureBox()
        Me.diahoje = New System.Windows.Forms.MonthCalendar()
        Me.GBCALENDARIO = New System.Windows.Forms.GroupBox()
        Me.GB45DIAS = New System.Windows.Forms.GroupBox()
        Me.lista45dias = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GBRELATORIO = New System.Windows.Forms.GroupBox()
        Me.dataRelatorio = New System.Windows.Forms.RichTextBox()
        Me.picRelatorioDiario = New System.Windows.Forms.PictureBox()
        Me.tituloRelatorioDiario = New System.Windows.Forms.Label()
        Me.painellembrete = New System.Windows.Forms.Panel()
        Me.rtlembretes = New System.Windows.Forms.ListBox()
        Me.lbllembrete = New System.Windows.Forms.Label()
        Me.pbFexarlembrete = New System.Windows.Forms.PictureBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.logoIso = New System.Windows.Forms.PictureBox()
        CType(Me.dedoDuro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBCONTACOLABORADOR.SuspendLayout()
        CType(Me.picColabor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBREDE.SuspendLayout()
        CType(Me.PicDocRede, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBmsn.SuspendLayout()
        CType(Me.picMessenger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBCALENDARIO.SuspendLayout()
        Me.GB45DIAS.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBRELATORIO.SuspendLayout()
        CType(Me.picRelatorioDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.painellembrete.SuspendLayout()
        CType(Me.pbFexarlembrete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoIso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRede
        '
        Me.lblRede.AutoSize = True
        Me.lblRede.Location = New System.Drawing.Point(85, 16)
        Me.lblRede.Name = "lblRede"
        Me.lblRede.Size = New System.Drawing.Size(136, 15)
        Me.lblRede.TabIndex = 3
        Me.lblRede.Text = "DOCUMENTOS NA REDE"
        '
        'docNaRede
        '
        Me.docNaRede.AutoSize = True
        Me.docNaRede.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.docNaRede.Location = New System.Drawing.Point(96, 36)
        Me.docNaRede.Name = "docNaRede"
        Me.docNaRede.Size = New System.Drawing.Size(138, 15)
        Me.docNaRede.TabIndex = 4
        Me.docNaRede.Text = "0 Arquivos Adicionados"
        '
        'enviaPara
        '
        Me.enviaPara.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enviaPara.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enviaPara.FormattingEnabled = True
        Me.enviaPara.Location = New System.Drawing.Point(97, 55)
        Me.enviaPara.Name = "enviaPara"
        Me.enviaPara.Size = New System.Drawing.Size(220, 23)
        Me.enviaPara.TabIndex = 3
        Me.enviaPara.Text = "Enviar arquivo para"
        '
        'dedoDuro
        '
        Me.dedoDuro.EnableRaisingEvents = True
        Me.dedoDuro.SynchronizingObject = Me
        '
        'totalcolaborinativo
        '
        Me.totalcolaborinativo.AutoSize = True
        Me.totalcolaborinativo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalcolaborinativo.Location = New System.Drawing.Point(99, 55)
        Me.totalcolaborinativo.Name = "totalcolaborinativo"
        Me.totalcolaborinativo.Size = New System.Drawing.Size(85, 15)
        Me.totalcolaborinativo.TabIndex = 26
        Me.totalcolaborinativo.Text = "Atualizando ..."
        '
        'totalcolaborativo
        '
        Me.totalcolaborativo.AutoSize = True
        Me.totalcolaborativo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalcolaborativo.Location = New System.Drawing.Point(99, 40)
        Me.totalcolaborativo.Name = "totalcolaborativo"
        Me.totalcolaborativo.Size = New System.Drawing.Size(85, 15)
        Me.totalcolaborativo.TabIndex = 25
        Me.totalcolaborativo.Text = "Atualizando ..."
        '
        'totalcolabor
        '
        Me.totalcolabor.AutoSize = True
        Me.totalcolabor.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalcolabor.Location = New System.Drawing.Point(90, 21)
        Me.totalcolabor.Name = "totalcolabor"
        Me.totalcolabor.Size = New System.Drawing.Size(83, 15)
        Me.totalcolabor.TabIndex = 24
        Me.totalcolabor.Text = "Atualizando ..."
        '
        'segundoP
        '
        '
        'GBCONTACOLABORADOR
        '
        Me.GBCONTACOLABORADOR.Controls.Add(Me.picColabor)
        Me.GBCONTACOLABORADOR.Controls.Add(Me.totalcolabor)
        Me.GBCONTACOLABORADOR.Controls.Add(Me.totalcolaborativo)
        Me.GBCONTACOLABORADOR.Controls.Add(Me.totalcolaborinativo)
        Me.GBCONTACOLABORADOR.Location = New System.Drawing.Point(12, 12)
        Me.GBCONTACOLABORADOR.Name = "GBCONTACOLABORADOR"
        Me.GBCONTACOLABORADOR.Size = New System.Drawing.Size(326, 84)
        Me.GBCONTACOLABORADOR.TabIndex = 30
        Me.GBCONTACOLABORADOR.TabStop = False
        '
        'picColabor
        '
        Me.picColabor.BackgroundImage = Global.iFRAME.My.Resources.Resources.COLABOR
        Me.picColabor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picColabor.Location = New System.Drawing.Point(6, 13)
        Me.picColabor.Name = "picColabor"
        Me.picColabor.Size = New System.Drawing.Size(67, 67)
        Me.picColabor.TabIndex = 0
        Me.picColabor.TabStop = False
        '
        'GBREDE
        '
        Me.GBREDE.Controls.Add(Me.PicDocRede)
        Me.GBREDE.Controls.Add(Me.lblRede)
        Me.GBREDE.Controls.Add(Me.docNaRede)
        Me.GBREDE.Controls.Add(Me.enviaPara)
        Me.GBREDE.Location = New System.Drawing.Point(12, 96)
        Me.GBREDE.Name = "GBREDE"
        Me.GBREDE.Size = New System.Drawing.Size(326, 83)
        Me.GBREDE.TabIndex = 31
        Me.GBREDE.TabStop = False
        '
        'PicDocRede
        '
        Me.PicDocRede.BackgroundImage = Global.iFRAME.My.Resources.Resources.docNaRede
        Me.PicDocRede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicDocRede.Location = New System.Drawing.Point(6, 13)
        Me.PicDocRede.Name = "PicDocRede"
        Me.PicDocRede.Size = New System.Drawing.Size(67, 67)
        Me.PicDocRede.TabIndex = 1
        Me.PicDocRede.TabStop = False
        '
        'GBmsn
        '
        Me.GBmsn.Controls.Add(Me.lblID)
        Me.GBmsn.Controls.Add(Me.fraze)
        Me.GBmsn.Controls.Add(Me.lblNome)
        Me.GBmsn.Controls.Add(Me.msn)
        Me.GBmsn.Controls.Add(Me.lblUsermsn)
        Me.GBmsn.Controls.Add(Me.picMessenger)
        Me.GBmsn.Location = New System.Drawing.Point(12, 181)
        Me.GBmsn.Name = "GBmsn"
        Me.GBmsn.Size = New System.Drawing.Size(326, 85)
        Me.GBmsn.TabIndex = 32
        Me.GBmsn.TabStop = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(87, 61)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(17, 15)
        Me.lblID.TabIndex = 8
        Me.lblID.Text = "id"
        Me.lblID.Visible = False
        '
        'fraze
        '
        Me.fraze.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fraze.Location = New System.Drawing.Point(88, 58)
        Me.fraze.Name = "fraze"
        Me.fraze.Size = New System.Drawing.Size(35, 16)
        Me.fraze.TabIndex = 7
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(129, 61)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(101, 15)
        Me.lblNome.TabIndex = 6
        Me.lblNome.Text = "NOME USER MSN"
        Me.lblNome.Visible = False
        '
        'msn
        '
        Me.msn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.msn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msn.FormattingEnabled = True
        Me.msn.Location = New System.Drawing.Point(88, 34)
        Me.msn.Name = "msn"
        Me.msn.Size = New System.Drawing.Size(229, 23)
        Me.msn.TabIndex = 5
        Me.msn.Text = "Selecione um usuário do chat"
        '
        'lblUsermsn
        '
        Me.lblUsermsn.AutoSize = True
        Me.lblUsermsn.Location = New System.Drawing.Point(85, 16)
        Me.lblUsermsn.Name = "lblUsermsn"
        Me.lblUsermsn.Size = New System.Drawing.Size(160, 15)
        Me.lblUsermsn.TabIndex = 5
        Me.lblUsermsn.Text = "USUÁRIOS DO MSN ON-LINE"
        '
        'picMessenger
        '
        Me.picMessenger.BackgroundImage = Global.iFRAME.My.Resources.Resources.Online
        Me.picMessenger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMessenger.Location = New System.Drawing.Point(6, 13)
        Me.picMessenger.Name = "picMessenger"
        Me.picMessenger.Size = New System.Drawing.Size(67, 67)
        Me.picMessenger.TabIndex = 2
        Me.picMessenger.TabStop = False
        '
        'diahoje
        '
        Me.diahoje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.diahoje.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.diahoje.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diahoje.Location = New System.Drawing.Point(5, 12)
        Me.diahoje.Name = "diahoje"
        Me.diahoje.TabIndex = 36
        Me.diahoje.TitleBackColor = System.Drawing.Color.DarkGreen
        '
        'GBCALENDARIO
        '
        Me.GBCALENDARIO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBCALENDARIO.Controls.Add(Me.diahoje)
        Me.GBCALENDARIO.Location = New System.Drawing.Point(543, 131)
        Me.GBCALENDARIO.Name = "GBCALENDARIO"
        Me.GBCALENDARIO.Size = New System.Drawing.Size(250, 248)
        Me.GBCALENDARIO.TabIndex = 37
        Me.GBCALENDARIO.TabStop = False
        '
        'GB45DIAS
        '
        Me.GB45DIAS.Controls.Add(Me.lista45dias)
        Me.GB45DIAS.Controls.Add(Me.Label1)
        Me.GB45DIAS.Controls.Add(Me.PictureBox1)
        Me.GB45DIAS.Location = New System.Drawing.Point(12, 268)
        Me.GB45DIAS.Name = "GB45DIAS"
        Me.GB45DIAS.Size = New System.Drawing.Size(326, 85)
        Me.GB45DIAS.TabIndex = 33
        Me.GB45DIAS.TabStop = False
        '
        'lista45dias
        '
        Me.lista45dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lista45dias.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lista45dias.FormattingEnabled = True
        Me.lista45dias.Location = New System.Drawing.Point(88, 39)
        Me.lista45dias.Name = "lista45dias"
        Me.lista45dias.Size = New System.Drawing.Size(229, 23)
        Me.lista45dias.TabIndex = 6
        Me.lista45dias.Text = "Lista os colaboradores nos 45"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "COLABORADORES NOS 45 DIAS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.iFRAME.My.Resources.Resources.contrato
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(6, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 67)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GBRELATORIO
        '
        Me.GBRELATORIO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBRELATORIO.Controls.Add(Me.dataRelatorio)
        Me.GBRELATORIO.Controls.Add(Me.picRelatorioDiario)
        Me.GBRELATORIO.Controls.Add(Me.tituloRelatorioDiario)
        Me.GBRELATORIO.Location = New System.Drawing.Point(344, 12)
        Me.GBRELATORIO.Name = "GBRELATORIO"
        Me.GBRELATORIO.Size = New System.Drawing.Size(193, 366)
        Me.GBRELATORIO.TabIndex = 31
        Me.GBRELATORIO.TabStop = False
        '
        'dataRelatorio
        '
        Me.dataRelatorio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataRelatorio.Location = New System.Drawing.Point(87, 48)
        Me.dataRelatorio.Name = "dataRelatorio"
        Me.dataRelatorio.Size = New System.Drawing.Size(96, 32)
        Me.dataRelatorio.TabIndex = 25
        Me.dataRelatorio.Text = "data do último envio :"
        '
        'picRelatorioDiario
        '
        Me.picRelatorioDiario.BackgroundImage = Global.iFRAME.My.Resources.Resources.relatorio
        Me.picRelatorioDiario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRelatorioDiario.Location = New System.Drawing.Point(6, 13)
        Me.picRelatorioDiario.Name = "picRelatorioDiario"
        Me.picRelatorioDiario.Size = New System.Drawing.Size(67, 67)
        Me.picRelatorioDiario.TabIndex = 0
        Me.picRelatorioDiario.TabStop = False
        '
        'tituloRelatorioDiario
        '
        Me.tituloRelatorioDiario.AutoSize = True
        Me.tituloRelatorioDiario.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloRelatorioDiario.Location = New System.Drawing.Point(84, 29)
        Me.tituloRelatorioDiario.Name = "tituloRelatorioDiario"
        Me.tituloRelatorioDiario.Size = New System.Drawing.Size(99, 15)
        Me.tituloRelatorioDiario.TabIndex = 24
        Me.tituloRelatorioDiario.Text = "Relatório Diário :"
        '
        'painellembrete
        '
        Me.painellembrete.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.painellembrete.BackgroundImage = Global.iFRAME.My.Resources.Resources.fundolembrete
        Me.painellembrete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.painellembrete.Controls.Add(Me.rtlembretes)
        Me.painellembrete.Controls.Add(Me.lbllembrete)
        Me.painellembrete.Controls.Add(Me.pbFexarlembrete)
        Me.painellembrete.Location = New System.Drawing.Point(117, 385)
        Me.painellembrete.Name = "painellembrete"
        Me.painellembrete.Size = New System.Drawing.Size(420, 89)
        Me.painellembrete.TabIndex = 35
        '
        'rtlembretes
        '
        Me.rtlembretes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtlembretes.BackColor = System.Drawing.Color.Yellow
        Me.rtlembretes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtlembretes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtlembretes.ForeColor = System.Drawing.Color.Black
        Me.rtlembretes.FormattingEnabled = True
        Me.rtlembretes.Location = New System.Drawing.Point(11, 24)
        Me.rtlembretes.Name = "rtlembretes"
        Me.rtlembretes.Size = New System.Drawing.Size(390, 39)
        Me.rtlembretes.TabIndex = 5
        '
        'lbllembrete
        '
        Me.lbllembrete.AutoSize = True
        Me.lbllembrete.BackColor = System.Drawing.Color.Transparent
        Me.lbllembrete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllembrete.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbllembrete.Location = New System.Drawing.Point(3, 5)
        Me.lbllembrete.Name = "lbllembrete"
        Me.lbllembrete.Size = New System.Drawing.Size(83, 18)
        Me.lbllembrete.TabIndex = 20
        Me.lbllembrete.Text = "lembrete :"
        '
        'pbFexarlembrete
        '
        Me.pbFexarlembrete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbFexarlembrete.BackColor = System.Drawing.Color.Transparent
        Me.pbFexarlembrete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbFexarlembrete.Image = Global.iFRAME.My.Resources.Resources.X
        Me.pbFexarlembrete.Location = New System.Drawing.Point(385, 6)
        Me.pbFexarlembrete.Name = "pbFexarlembrete"
        Me.pbFexarlembrete.Size = New System.Drawing.Size(16, 16)
        Me.pbFexarlembrete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFexarlembrete.TabIndex = 19
        Me.pbFexarlembrete.TabStop = False
        Me.pbFexarlembrete.Visible = False
        '
        'logo
        '
        Me.logo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logo.Image = Global.iFRAME.My.Resources.Resources.LOGO_DIPACK
        Me.logo.Location = New System.Drawing.Point(543, 391)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(250, 67)
        Me.logo.TabIndex = 34
        Me.logo.TabStop = False
        '
        'logoIso
        '
        Me.logoIso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.logoIso.Image = Global.iFRAME.My.Resources.Resources.ISO_9001
        Me.logoIso.Location = New System.Drawing.Point(12, 383)
        Me.logoIso.Name = "logoIso"
        Me.logoIso.Size = New System.Drawing.Size(99, 86)
        Me.logoIso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoIso.TabIndex = 33
        Me.logoIso.TabStop = False
        '
        'frame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(805, 481)
        Me.Controls.Add(Me.GBRELATORIO)
        Me.Controls.Add(Me.GB45DIAS)
        Me.Controls.Add(Me.GBCALENDARIO)
        Me.Controls.Add(Me.painellembrete)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.logoIso)
        Me.Controls.Add(Me.GBmsn)
        Me.Controls.Add(Me.GBREDE)
        Me.Controls.Add(Me.GBCONTACOLABORADOR)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frame"
        CType(Me.dedoDuro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBCONTACOLABORADOR.ResumeLayout(False)
        Me.GBCONTACOLABORADOR.PerformLayout()
        CType(Me.picColabor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBREDE.ResumeLayout(False)
        Me.GBREDE.PerformLayout()
        CType(Me.PicDocRede, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBmsn.ResumeLayout(False)
        Me.GBmsn.PerformLayout()
        CType(Me.picMessenger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBCALENDARIO.ResumeLayout(False)
        Me.GB45DIAS.ResumeLayout(False)
        Me.GB45DIAS.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBRELATORIO.ResumeLayout(False)
        Me.GBRELATORIO.PerformLayout()
        CType(Me.picRelatorioDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.painellembrete.ResumeLayout(False)
        Me.painellembrete.PerformLayout()
        CType(Me.pbFexarlembrete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoIso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picColabor As System.Windows.Forms.PictureBox
    Friend WithEvents PicDocRede As System.Windows.Forms.PictureBox
    Friend WithEvents picMessenger As System.Windows.Forms.PictureBox
    Friend WithEvents lblRede As System.Windows.Forms.Label
    Friend WithEvents docNaRede As System.Windows.Forms.Label
    Friend WithEvents enviaPara As System.Windows.Forms.ComboBox
    Friend WithEvents dedoDuro As System.IO.FileSystemWatcher
    Friend WithEvents totalcolaborinativo As System.Windows.Forms.Label
    Friend WithEvents totalcolaborativo As System.Windows.Forms.Label
    Friend WithEvents totalcolabor As System.Windows.Forms.Label
    Friend WithEvents segundoP As System.ComponentModel.BackgroundWorker
    Friend WithEvents GBCONTACOLABORADOR As System.Windows.Forms.GroupBox
    Friend WithEvents GBmsn As System.Windows.Forms.GroupBox
    Friend WithEvents GBREDE As System.Windows.Forms.GroupBox
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents logoIso As System.Windows.Forms.PictureBox
    Friend WithEvents pbFexarlembrete As System.Windows.Forms.PictureBox
    Friend WithEvents rtlembretes As System.Windows.Forms.ListBox
    Friend WithEvents lbllembrete As System.Windows.Forms.Label
    Friend WithEvents painellembrete As System.Windows.Forms.Panel
    Friend WithEvents diahoje As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblUsermsn As System.Windows.Forms.Label
    Friend WithEvents msn As System.Windows.Forms.ComboBox
    Friend WithEvents GBCALENDARIO As System.Windows.Forms.GroupBox
    Friend WithEvents GB45DIAS As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lista45dias As System.Windows.Forms.ComboBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents fraze As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents GBRELATORIO As System.Windows.Forms.GroupBox
    Friend WithEvents picRelatorioDiario As System.Windows.Forms.PictureBox
    Friend WithEvents tituloRelatorioDiario As System.Windows.Forms.Label
    Friend WithEvents dataRelatorio As System.Windows.Forms.RichTextBox
End Class
