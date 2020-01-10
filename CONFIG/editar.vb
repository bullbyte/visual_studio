Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class editar
    Dim dados As New DADOS.conecxao
    Friend cliente As cliente
    Dim dscliente As DataSet
    Public Sub carregaDados(ByVal ds As DataSet)
        Me.dscliente = ds
        'NOME DOS colaboradores
        Me.txtNome.DataBindings.Add(New Binding("Text", ds, "clientes.NOME_FANTAZIA"))
    End Sub
    Public Sub SalvaColaborador(ByVal ds As DataSet)
        Dim conn As MySqlConnection = dados.GetConnection()
        Try
            Dim sql As String = "Select * from clientes"
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            Try
                Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)
                If ds.HasChanges Then
                    da.Update(ds, "clientes")
                    ds.AcceptChanges()
                End If
            Finally
                da.Dispose()
            End Try
        Finally
            conn.Close()
            conn.Dispose()
            cliente.carrega()
            Me.Close()
        End Try
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Try
            'encerra a edição atual da operação - esta propriedade foi feita para ser usada com vinculação complexa de dados
            BindingContext(dscliente, "clientes").EndCurrentEdit()
            'chama o método SalvaAluno passando o dataset como parametro
            SalvaColaborador(dscliente)
            'chama o método carregaDados no formulario principal para atualizar dados
            'colaboradores.CarregaDados()
            'exibe mensagem ao usuário que os dados foram salvos
        Catch ex As Exception
            MsgBox("Erro ao salvar dados na tabela. " & vbCrLf & ex.Message, MsgBoxStyle.Information, "Erro ao salvar dados")
        End Try
        Me.BringToFront()
    End Sub
End Class