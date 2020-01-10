Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Drawing
Public Class frame
    Dim dados As New DADOS.conecxao
#Region "LISTA colaboradores"
    Sub listaTotalColaborador()
        Try
            Dim conexao As MySqlConnection = dados.GetConnection()
            Dim sql As String = "Select * from colaboradores"
            Dim comando As New MySqlCommand(sql, conexao)
            Dim adaptador As New MySqlDataAdapter(comando)
            Dim ds As New DataSet()
            adaptador.Fill(ds, "id")
            Dim totalLinhas As Integer = ds.Tables("id").Rows.Count
            Dim linhaAtual As Integer
            Dim meuDataRow As DataRow
            For Each meuDataRow In ds.Tables("id").Rows
                Application.DoEvents()
                ' atualiza a label
                linhaAtual += 1
                totalcolabor.Text = String.Format("{0}% completo", linhaAtual * 100 \ totalLinhas)
                'totalcolabor.Refresh()
            Next
            'exibe o total de linhas
            totalcolabor.Text = "Atualmente com " & totalLinhas & " colaboradores :"
            conexao.Close()
        Catch ex As Exception
            listaTotalColaborador()
        End Try
    End Sub
    Private Sub totalcolboradorEfetivo()
        Try
            'define o objeto OledbConnection usando a string de conexão
            Dim conexao As MySqlConnection = dados.GetConnection()
            'define a instrução SQL que será usada para extrair as linhas da tabela Authors
            Dim sql As String = "Select * from colaboradores where (EFETIVO = 'ATIVADO')"
            'cria o objeto OleDbCommand
            Dim comando As New MySqlCommand(sql, conexao)
            'Cria o objeto DataAdapter
            Dim adaptador As New MySqlDataAdapter(comando)
            'Cria o objeto DataSet
            Dim ds As New DataSet()
            'preenche o dataset
            adaptador.Fill(ds, "id")
            'exibe os dados em um datagrid
            Dim totalLinhas As Integer = ds.Tables("id").Rows.Count
            Dim linhaAtual As Integer
            Dim meuDataRow As DataRow

            For Each meuDataRow In ds.Tables("id").Rows
                Application.DoEvents()
                ' atualiza a label
                linhaAtual += 1
                totalcolaborativo.Text = String.Format("{0}% completo", linhaAtual * 100 \ totalLinhas)
                totalcolaborativo.Refresh()
            Next
            'exibe o total de linhas
            totalcolaborativo.Text = "Onde que " & totalLinhas & " estão efetivos"
            conexao.Close()
        Catch ex As Exception
            totalcolboradorEfetivo()
        End Try
    End Sub
    Private Sub totalcolboradorDesativado()
        Try
            'define o objeto OledbConnection usando a string de conexão
            Dim conexao As MySqlConnection = dados.GetConnection()
            'define a instrução SQL que será usada para extrair as linhas da tabela Authors
            Dim sql As String = "Select * from colaboradores where (EFETIVO = 'DESATIVADO')"
            'cria o objeto OleDbCommand
            Dim comando As New MySqlCommand(sql, conexao)
            'Cria o objeto DataAdapter
            Dim adaptador As New MySqlDataAdapter(comando)
            'Cria o objeto DataSet
            Dim ds As New DataSet()
            'preenche o dataset
            adaptador.Fill(ds, "id")
            'exibe os dados em um datagrid
            Dim totalLinhas As Integer = ds.Tables("id").Rows.Count
            Dim linhaAtual As Integer
            Dim meuDataRow As DataRow

            For Each meuDataRow In ds.Tables("id").Rows
                Application.DoEvents()
                ' atualiza a label
                linhaAtual += 1
                totalcolaborinativo.Text = String.Format("{0}% completo", linhaAtual * 100 \ totalLinhas)
                totalcolaborinativo.Refresh()
            Next
            'exibe o total de linhas
            totalcolaborinativo.Text = "e infelizmente " & totalLinhas & " estão desativados"
            conexao.Close()
        Catch ex As Exception
            totalcolboradorDesativado()
        End Try
    End Sub
    Sub abreconn()
        Try
            dados.strConn.open()
        Catch ex As Exception
            abreconn()
        End Try
    End Sub
    Private Sub segundoP_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles segundoP.DoWork
        If dados.strConn.State = ConnectionState.Open Then
        Else
            abreconn()
            Return
        End If
    End Sub
    Private Sub segundoP_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles segundoP.RunWorkerCompleted
        listaTotalColaborador()
        totalcolboradorEfetivo()
        totalcolboradorDesativado()
    End Sub
#End Region
#Region "LISTA USUÁRIO PARA FTP"
    Sub listaUserFTP()
        Try
            Dim ds As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim conn As MySqlConnection = dados.GetConnection()
            Dim sql As String = "Select * from usuario where (STATUS = 'ATIVADO') order by NOME"
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            enviaPara.Items.Clear()
            adptr.Fill(ds, "NOME")
            dt = ds.Tables(0)
            For Each dr In dt.Rows
                enviaPara.Items.Add(dr.Item("Nome") + " " + dr.Item("sobrenome"))
            Next
            dados.strConn.Close()
        Finally
            dados.strConn.Close()
        End Try
    End Sub
#End Region
#Region "LISTA DE USUARIOS DO MSN"
    Sub listaUserMSN()
        Try
            Dim ds As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim conn As MySqlConnection = dados.GetConnection()
            Dim sql As String = "Select * from msn where (STATUS = 'ON-LINE') order by NOME"
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            adptr.Fill(ds, "NOME")
            dt = ds.Tables(0)
            msn.Items.Clear()
            For Each dr In dt.Rows
                msn.Items.Add(dr.Item("NOME"))
            Next
            dados.strConn.Close()
        Finally
            dados.strConn.Close()
        End Try
    End Sub
#Region "VERIFICA MEU NOME"
    Sub meunome()
        Dim Vnome
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM msn WHERE NOME = '" & lblID.Text & "'", dados.strConn) 'NIVEL
        If dados.strConn.State = ConnectionState.Closed Then dados.strConn.Close()
        dados.strConn.Open()
        Dim sdr As MySqlDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            Vnome = sdr.Item("NOME")
            msn.Items.Remove(Vnome)
        End If
    End Sub
#End Region
    Private Sub msn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msn.SelectedIndexChanged
        Dim chat As New CHAT.chat
        Dim iframe As New iFRAME
        chat.lblNome.Text = msn.SelectedItem
        chat.lblUserNome.Text = lblNome.Text
        chat.ShowDialog()
    End Sub
#End Region
#Region "COLABORADORES NOS 90 DIAS"
    Sub lista90()
        Dim dias
        Dim agora As DateTime
        Try
            Dim ds As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim conn As MySqlConnection = dados.GetConnection()
            Dim sql As String = "Select * from colaboradores where (EFETIVO = 'ATIVADO') order by NOME"
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            lista45dias.Items.Clear()
            adptr.Fill(ds, "NOME")
            dt = ds.Tables(0)
            For Each dr In dt.Rows

                agora = dr.Item("ADMISSAO")
                dias = agora.Day

                Dim inicio As New DateTime 'ano, mês, dia 
                inicio = agora
                Dim fim As New DateTime 'ano, mês, dia (Now().ToShortDateString)
                fim = Now()
                Dim dif As TimeSpan = fim.Subtract(inicio)
                Dim dia As Integer = dif.Days

                If dia <= 90 Then
                    lista45dias.Items.Add(dr.Item("NOME"))
                End If
            Next
            dados.strConn.Close()
        Finally
            dados.strConn.Close()
        End Try
    End Sub
    Private Sub contaDias()
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM colaboradores WHERE NOME = '" & lista45dias.SelectedItem & "'", dados.strConn) 'NIVEL
        If dados.strConn.State = ConnectionState.Closed Then dados.strConn.Close()
        dados.strConn.Open()
        Dim sdr As MySqlDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then

            Dim nome, admissao
            Dim dia, mes, ano As Single
            Dim Data As Date
            Dim Msg

            nome = sdr.Item("NOME")
            admissao = sdr.Item("ADMISSAO")

            Data = admissao

            dia = DateDiff("d", Data, Now)
            mes = DateDiff("m", Data, Now)
            ano = DateDiff("yyyy", Data, Now)

            Msg = " Tempo de trabalho de  " & nome & "   é : " & vbCrLf
            Msg = Msg & " ============================== " & vbCrLf
            Msg = Msg & " Em dias : " & dia & " dias " & vbCrLf
            Msg = Msg & " Em meses : " & mes & " meses " & vbCrLf
            Msg = Msg & " Em anos : " & ano & " anos " & vbCrLf
            'Msg = Msg & " Em segundos : " & d4 & " segundos " & vbCrLf
            MsgBox(Msg, vbOKOnly, " Tempo de trabalho !")

        End If

    End Sub
#End Region
    Public Sub inicia(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        segundoP.RunWorkerAsync()
    End Sub
    Private Sub painellembrete_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles painellembrete.MouseEnter
        pbFexarlembrete.Visible = True
    End Sub
    Private Sub lembrete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.MouseEnter
        pbFexarlembrete.Visible = False
    End Sub
    Private Sub pbFexarlembrete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbFexarlembrete.Click
        painellembrete.Visible = False
    End Sub
    Private Sub enviaPara_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles enviaPara.Click
        listaUserFTP()
    End Sub
    Private Sub enviaPara_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enviaPara.SelectedIndexChanged
        Dim upload As New upLoad
        upload.Text = enviaPara.SelectedItem
        upload.ShowDialog()
    End Sub
    Private Sub msn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles msn.Click
        listaUserMSN()
        meunome()
    End Sub
    Private Sub lista45dias_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lista45dias.Click
        lista90()
    End Sub
    Private Sub lista45dias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lista45dias.SelectedIndexChanged
        contaDias()
    End Sub

    Private Sub dedoDuro_Changed(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles dedoDuro.Changed

    End Sub

    Private Sub GBREDE_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GBREDE.Enter

    End Sub
End Class