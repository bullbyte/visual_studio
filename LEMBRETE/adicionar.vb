Imports MySql.Data.MySqlClient
Public Class adicionar
    Dim dados As New DADOS.conecxao
    Private Sub cbEnviarlembrete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbEnviarLembrete.Click
        Try
            Dim ds As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim conn As MySqlConnection = dados.GetConnection()
            Dim sql As String = "Select * from usuario where (STATUS = 'ATIVADO') order by NOME"
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            cbEnviarLembrete.Items.Clear()
            adptr.Fill(ds, "NOME")
            dt = ds.Tables(0)
            For Each dr In dt.Rows
                cbEnviarLembrete.Items.Add(dr.Item("Nome") + " " + dr.Item("sobrenome"))
            Next
            dados.strConn.Close()
        Finally
            dados.strConn.Close()
        End Try
    End Sub
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If cbEnviarLembrete.Text = "   lembrete PARA:" Then
            MsgBox("Escolha para quem vai enviar !")
        Else
            If txtLembrete.TextLength > 0 Then
                If dados.strConn.State = ConnectionState.Open Then dados.strConn.Close()
                Dim st As String = "INSERT INTO lembrete(DE,lembrete,DATA,PARA)VALUES('" & lblNome.Text & "','" & txtLembrete.Text & "','" & dtLembrete.Text & "','" & cbEnviarLembrete.Text & "')"
                Dim cmd As New MySqlCommand(st, dados.strConn)
                dados.strConn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("lembrete enviado com sucesso")
                dados.strConn.Close()
            Else
                MsgBox("Digite o lembrete !")
            End If
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class