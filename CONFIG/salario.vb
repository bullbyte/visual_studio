Imports MySql.Data.MySqlClient
Public Class salario
    Dim dados As New DADOS.conecxao
    Sub LISTARSALARIO() Handles MyBase.Load
        Try
            Dim ds As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim conn As MySqlConnection = dados.GetConnection()
            Dim sql As String = "select SALARIO from SALARIO order by SALARIO"
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            listaSalario.Items.Clear()
            adptr.Fill(ds, "SALARIO")
            dt = ds.Tables(0)
            For Each dr In dt.Rows
                listaSalario.Items.Add(dr.Item("SALARIO"))
            Next
            dados.strConn.Close()
        Finally
            dados.strConn.Close()
        End Try
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If addSalario.Text = "   NOVO SALARIO:" Then
            MsgBox("DIGITE O NOME DO NOVO SALARIO !")
        Else
            If addSalario.TextLength > 0 Then
                If dados.strConn.State = ConnectionState.Open Then dados.strConn.Close()
                Dim st As String = "INSERT INTO SALARIO(SALARIO)VALUES('" & addSalario.Text & "')"
                Dim cmd As New MySqlCommand(st, dados.strConn)
                dados.strConn.Open()
                cmd.ExecuteNonQuery()
                listaSalario.Items.Clear()
                Call LISTARSALARIO()
                dados.strConn.Close()
            Else
                MsgBox("DIGITE O NOME DO NOVO SALARIO !")
            End If
        End If
    End Sub
End Class