Imports MySql.Data.MySqlClient
Public Class setor
    Dim dados As New DADOS.conecxao
    Sub LISTARSETOR() Handles MyBase.Load
        Try
            Dim ds As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim conn As MySqlConnection = dados.GetConnection()
            Dim sql As String = "select SETOR from Setor order by setor"
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            listaSetor.Items.Clear()
            adptr.Fill(ds, "SETOR")
            dt = ds.Tables(0)
            For Each dr In dt.Rows
                listaSetor.Items.Add(dr.Item("SETOR"))
            Next
            dados.strConn.Close()
        Finally
            dados.strConn.Close()
        End Try
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If addSetor.Text = "   NOVO SETOR:" Then
            MsgBox("DIGITE O NOME DO NOVO SETOR !")
        Else
            If addSetor.TextLength > 0 Then
                If dados.strConn.State = ConnectionState.Open Then dados.strConn.Close()
                Dim st As String = "INSERT INTO setor(setor)VALUES('" & addSetor.Text & "')"
                Dim cmd As New MySqlCommand(st, dados.strConn)
                dados.strConn.Open()
                cmd.ExecuteNonQuery()
                listaSetor.Items.Clear()
                Call LISTARSETOR()
                dados.strConn.Close()
            Else
                MsgBox("DIGITE O NOME DO NOVO SETOR !")
            End If
        End If
    End Sub
End Class