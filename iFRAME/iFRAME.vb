Imports System.Windows.Forms
Imports System.Threading
Imports MySql.Data.MySqlClient
Imports Microsoft.Win32
Imports System.Drawing

Public Class iFRAME
    Dim frame As New frame
    Dim dados As New DADOS.conecxao
    Public Sub iFRAME_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '-----------------------------------------------------
        definirEstado("nVer")
        frame.MdiParent = Me
        frame.Show()                                         ' 
        frame.Dock = System.Windows.Forms.DockStyle.Fill     '
        frame.SendToBack()                                   '
        '----------------------------------------------------'
    End Sub
#Region "LOGIN"
    Private Sub txtSenha_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSenha.KeyUp
        'Cryotografia da senha
        Dim cifrado As New DADOS.ClsCrypto()
        txtCifrado.Text = cifrado.clsCrypto(txtSenha.Text, True)
        Dim decifrado As New DADOS.ClsCrypto()
        txtDecifrado.Text = decifrado.clsCrypto(txtCifrado.Text, False)
    End Sub
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim Vnivel, Vnome, VsobreNome, vID
        Dim alerta As New CHAT.alerta
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM usuario WHERE usuario = '" & txtusuario.Text & "' AND SENHA= '" & txtCifrado.Text & "'", dados.strConn) 'NIVEL
        If dados.strConn.State = ConnectionState.Closed Then dados.strConn.Close()
        dados.strConn.Open()
        Dim sdr As MySqlDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            '-----------------------------------------------------------------------------------
            tim.Interval = 200
            AddHandler tim.Tick, AddressOf tim_Tick
            tim.Start()
            '-----------------------------------------------------------------------------------
            Vnome = sdr.Item("NOME")
            VsobreNome = sdr.Item("SOBRENOME")
            Vnivel = sdr.Item("NIVEL")
            vID = sdr.Item("ID")
            'iFRAME.hoje.Text = hoje.Text
            Vnivel = sdr.Item("NIVEL")
            '-----------------------------------------------------------------------------------
            lblID.Text = vID
            GBENVINDO.Visible = True
            lblnome.Text = "Nome : " & Vnome
            frame.lblNome.Text = Vnome + " " + VsobreNome
            statusNome.Text = Vnome + " " + VsobreNome
            frame.lblID.Text = statusNome.Text
            Me.BringToFront()
            If Vnivel = "ADMIN" Then
                definirEstado("aVer")
                lblnome.Text = Vnome
            End If
            If Vnivel = "USER" Then
                definirEstado("uVer")
                lblnome.Text = Vnome
            End If
            If txtusuario.Text = "" Then
                'Timera.Stop()
                dados.strConn.Close()
                GBENVINDO.Visible = False
                Exit Sub
            End If
            dados.strConn.Close()
            Me.GBLOGIN.Visible = False
            salvaUsermsn()
        Else
            dados.strConn.Close()
            txtusuario.Clear()
            txtSenha.Clear()
        End If
        'alerta o usuario on-line
        Dim alert As New CHAT.alerta
        alert.Show()
    End Sub
#End Region
#Region "NIVEL"
    Public Sub definirEstado(ByVal btn As String)
        'Dim iframe As iFRAME
        Select Case btn
            Case "nVer"
                btnConfig.Visible = False
                docRede.Visible = False
                btnusuarios.Visible = False
                btnColaborador.Visible = False
                'btnPonto.Visible = False
                btnlembrete.Visible = False
                btnSair.Visible = True
                frame.GBREDE.Visible = False
                frame.GBmsn.Visible = False
                frame.GB45DIAS.Visible = False
                frame.painellembrete.Visible = False
                frame.GBRELATORIO.Visible = False
                menuLinkRapido.Visible = False
            Case "aVer"
                btnConfig.Visible = True
                docRede.Visible = True
                btnusuarios.Visible = True
                btnColaborador.Visible = True
                'btnPonto.Visible = True
                btnlembrete.Visible = True
                btnSair.Visible = True
                frame.GBREDE.Visible = True
                frame.GBmsn.Visible = True
                frame.painellembrete.Visible = True
                frame.GB45DIAS.Visible = True
                frame.GBRELATORIO.Visible = True
                lembrete()
                menuLinkRapido.Visible = True
            Case "uVer"
                btnConfig.Visible = False
                docRede.Visible = True
                btnusuarios.Visible = False
                btnColaborador.Visible = True
                'btnPonto.Visible = False
                btnlembrete.Visible = True
                btnSair.Visible = True
                frame.GBREDE.Visible = True
                frame.GBmsn.Visible = True
                frame.painellembrete.Visible = True
                frame.GB45DIAS.Visible = True
                frame.GBRELATORIO.Visible = False
                lembrete()
                menuLinkRapido.Visible = False
        End Select
    End Sub
#End Region
#Region "LEMBRETE"
    Public Sub lembrete()
        Try
            Dim ds As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim conn As MySqlConnection = dados.GetConnection()
            Dim sql As String = "select * from lembrete WHERE (PARA = '" & statusNome.Text & "') AND (DATA = '" & frame.diahoje.TodayDate & "')"
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            adptr.Fill(ds, "lembrete")
            dt = ds.Tables(0)
            frame.rtlembretes.Items.Clear()
            For Each dr In dt.Rows
                If Not dr.IsNull("para") Then
                    frame.rtlembretes.Items.Add(dr.Item("de") + " Diz" + " - " + dr.Item("lembrete"))
                Else
                    frame.painellembrete.Visible = False
                End If
            Next
            If frame.rtlembretes.Items.Count = 0 Then
                frame.painellembrete.Visible = False
            Else
                frame.painellembrete.Visible = True
            End If
        Finally
            dados.strConn.Close()
        End Try
    End Sub
#End Region
#Region "TEMPO LOGADO"
    Dim tim As New System.Windows.Forms.Timer
    Structure LASTINPUTINFO
        Public cbSize As Integer
        Public dwTime As Integer
    End Structure
    Private Declare Function GetLastInputInfo Lib "user32" (ByRef plii As LASTINPUTINFO) As Boolean
    Private Declare Function GetTickCount Lib "kernel32" () As Int32
    Public Sub tim_Tick(ByVal sender As Object, ByVal e As EventArgs)
        Dim lii As LASTINPUTINFO
        Dim Inatividade As Integer
        lii.cbSize = Len(lii)
        GetLastInputInfo(lii)
        lblCountdown.Text = ((GetTickCount() - lii.dwTime) / 1000.0).ToString
        Inatividade = Val(FormatNumber((GetTickCount() - lii.dwTime) / 1000, 0))
        '----------------------------------------------
        Dim relogio = DateTime.Now.ToLongTimeString
        lblHorario.Text = relogio
        '-----------------------------------------------
        If Inatividade = 300 Then    ' aqui entram os segundos de inatividade (60 segundos equivalem a 1 minuto)
            Me.GBENVINDO.Visible = False
            Me.GBLOGIN.Visible = True
            definirEstado("nVer")
            txtusuario.Clear()
            txtSenha.Clear()
            'painellembrete.Visible = False
            tim.Stop()
            Me.BringToFront()
            Me.Close()
        End If
    End Sub
#End Region
#Region "BOTÕES DE ACESSO"
    Private Sub docRede_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles docRede.Click
        Dim _found As Boolean = False
        For Each _openForm As Form In Application.OpenForms
            If TypeOf _openForm Is REDE.docRede Then
                _openForm.Focus()
                _found = True
            End If
        Next
        If Not _found Then
            Dim dockRede As New REDE.docRede(statusNome.Text)
            dockRede.lblNome.Text = statusNome.Text
            dockRede.MdiParent = Me
            dockRede.Show()
            dockRede.Dock = System.Windows.Forms.DockStyle.Fill
            dockRede.BringToFront()
        End If
    End Sub
    Private Sub btnusuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnusuarios.Click
        Dim _found As Boolean = False
        For Each _openForm As Form In Application.OpenForms
            If TypeOf _openForm Is USUARIOS.usuarios Then
                _openForm.Focus()
                _found = True
            End If
        Next
        If Not _found Then
            Dim user As New USUARIOS.usuarios
            user.MdiParent = Me
            user.Show()
            user.Dock = System.Windows.Forms.DockStyle.Fill
            user.BringToFront()
        End If
    End Sub
    Private Sub btnColaborador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColaborador.Click
        Dim _found As Boolean = False
        For Each _openForm As Form In Application.OpenForms
            If TypeOf _openForm Is COLABORADORES.colaboradores Then
                _openForm.Focus()
                _found = True
            End If
        Next
        If Not _found Then
            Dim colaborador As New COLABORADORES.colaboradores
            colaborador.MdiParent = Me
            colaborador.Show()
            colaborador.carrega()
            colaborador.Dock = DockStyle.Fill
            colaborador.BringToFront()
        End If
    End Sub
    Private Sub btnlembrete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlembrete.Click
        Dim _found As Boolean = False
        For Each _openForm As Form In Application.OpenForms
            If TypeOf _openForm Is LEMBRETE.lembrete Then
                _openForm.Focus()
                _found = True
            End If
        Next
        If Not _found Then
            Dim lembrete As New LEMBRETE.lembrete(statusNome.Text)
            lembrete.MdiParent = Me
            lembrete.Show()
            lembrete.carrega()
            lembrete.Dock = DockStyle.Fill
            lembrete.BringToFront()
        End If
    End Sub
    Private Sub menuClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuClientes.Click
        Dim _found As Boolean = False
        For Each _openForm As Form In Application.OpenForms
            If TypeOf _openForm Is CONFIG.cliente Then
                _openForm.Focus()
                _found = True
            End If
        Next
        If Not _found Then
            Dim clientes As New CONFIG.cliente()
            clientes.MdiParent = Me
            clientes.Show()
            clientes.Dock = DockStyle.Fill
            clientes.BringToFront()
        End If
    End Sub
    Private Sub addSetor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addSetor.Click
        Dim _found As Boolean = False
        For Each _openForm As Form In Application.OpenForms
            If TypeOf _openForm Is CONFIG.setor Then
                _openForm.Focus()
                _found = True
            End If
        Next
        If Not _found Then
            Dim setor As New CONFIG.setor()
            setor.ShowDialog()
            setor.BringToFront()
        End If
    End Sub
    Private Sub addSalario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addSalario.Click
        Dim _found As Boolean = False
        For Each _openForm As Form In Application.OpenForms
            If TypeOf _openForm Is CONFIG.salario Then
                _openForm.Focus()
                _found = True
            End If
        Next
        If Not _found Then
            Dim salario As New CONFIG.salario()
            salario.ShowDialog()
            salario.BringToFront()
        End If
    End Sub
#End Region
#Region "DEFINE USUÁRIO DO msn ON-LINE"
    Sub salvaUsermsn()
        Dim cmdd As MySqlCommand = New MySqlCommand("SELECT * FROM msn WHERE NOME = '" & statusNome.Text & "'", dados.strConn)
        dados.strConn.Open()
        Dim sdr As MySqlDataReader = cmdd.ExecuteReader()
        If (sdr.Read() = True) Then
            If txtusuario.TextLength > 0 Then
                If dados.strConn.State = ConnectionState.Open Then dados.strConn.Close()
                Dim s1 As String = "UPDATE msn SET STATUS = 'ON-LINE' WHERE  NOME = '" & statusNome.Text & "'"
                Dim cmnd As New MySqlCommand(s1, dados.strConn)
                dados.strConn.Open()
                cmnd.ExecuteNonQuery()
                dados.strConn.Close()
                '============
                'RegKeyUser()
                SaveSetting("SyberTEC", "DIPACK Intralogística", "usuario", statusNome.Text) 'Salva entrada no registro
                SaveSetting("SyberTEC", "DIPACK Intralogística", "DATA", frame.diahoje.TodayDate) 'Salva entrada no registro
                '============
            Else
                MsgBox("Nome Inválido a atualizar o usuario msn")
            End If
        End If
    End Sub
#End Region
#Region "DEFINE USUÁRIO DO msn OFF-LINE"
    Sub salvaUsermsnoff()
        If statusNome.Text = "    " Then
        Else
            Dim cmdd As MySqlCommand = New MySqlCommand("SELECT * FROM msn WHERE NOME = '" & statusNome.Text & "'", dados.strConn)
            dados.strConn.Open()
            Dim sdr As MySqlDataReader = cmdd.ExecuteReader()
            If (sdr.Read() = True) Then
                If txtusuario.TextLength > 0 Then
                    If dados.strConn.State = ConnectionState.Open Then dados.strConn.Close()
                    Dim s1 As String = "UPDATE msn SET STATUS = 'OFF-LINE' WHERE  NOME = '" & statusNome.Text & "'"
                    Dim cmnd As New MySqlCommand(s1, dados.strConn)
                    dados.strConn.Open()
                    cmnd.ExecuteNonQuery()
                    dados.strConn.Close()
                Else
                    MsgBox("Nome Inválido a atualizar o usuario msn")
                End If
            End If
        End If
    End Sub
#End Region
#Region "SALVA O NOME DO USUÁRIO NO REGISTRO"
    Sub regkeyPasta()
        Dim regKey As RegistryKey
        regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
        regKey.CreateSubKey("SyberTEC")
        regKey.Close()
    End Sub
    Sub RegKeyUser()
        regkeyPasta()
        Dim regKey As RegistryKey
        Dim ver As Decimal
        regKey = Registry.LocalMachine.OpenSubKey("Software\SyberTEC", True)
        regKey.SetValue("usuario", statusNome.Text)
        regKey.SetValue("ULTIMO ACESSO", frame.diahoje.TodayDate)
        ver = regKey.GetValue("Versão", 0.0)
        If ver < 1.1 Then
            regKey.SetValue("Versão", 1.1)
        End If
        regKey.Close()
    End Sub
    Private Sub iFRAME_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dim usuariologado As New TextBox
        If statusNome.Text = "    " Then
        Else
            usuariologado.Text = GetSetting("SyberTEC", "DIPACK Intralogística", "usuario")
            Dim cmdd As MySqlCommand = New MySqlCommand("SELECT * FROM msn WHERE NOME = '" & usuariologado.Text & "'", dados.strConn)
            dados.strConn.Open()
            Dim sdr As MySqlDataReader = cmdd.ExecuteReader()
            If (sdr.Read() = True) Then
                If dados.strConn.State = ConnectionState.Open Then dados.strConn.Close()
                Dim s1 As String = "UPDATE msn SET STATUS = 'OFF-LINE' WHERE  NOME = '" & usuariologado.Text & "'"
                Dim cmnd As New MySqlCommand(s1, dados.strConn)
                dados.strConn.Open()
                cmnd.ExecuteNonQuery()
                dados.strConn.Close()
            Else
                MsgBox("Nome Inválido a atualizar o usuario msn")
            End If
        End If
    End Sub
#End Region
    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub RestaurarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestaurarToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class