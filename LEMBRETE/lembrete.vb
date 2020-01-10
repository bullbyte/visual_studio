Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Threading
Public Class lembrete
    Private dslembretes As DataSet
    Dim dados As New DADOS.conecxao
    Public Overloads Function Getlembrete() As DataSet
        'retorna um dataset representando os alunos 
        Return Me.GetLembrete("ID")
    End Function
    Public Overloads Function Getlembrete(ByVal campoOrdem As String) As DataSet
        'obtem a conexao com o banco de dados
        Dim conn As MySqlConnection = dados.GetConnection()
        Try
            'cria o dataset novo
            Dim ds As New DataSet
            'define a string sql para selecionar os alunos da tabela alunos ordenados pelo campo definido
            Dim sql As String = "SELECT * from lembrete where (DE = '" & lblNome.Text & "') OR (PARA = '" & lblNome.Text & "' ) order by " + campoOrdem
            'cria um dataadapter para preencher o dataset
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            Try
                'preenche o dataset com os dados da tabela alunos
                da.Fill(ds, "lembrete")
            Finally
                'libera recursos
                da.Dispose()
            End Try
            'retorna o dataset gerado
            Return ds
        Finally
            'estes comandos SEMPRE serão executados pois estao no bloco finally
            'fecha a conexão e libera objetos
            conn.Close()
            conn.Dispose()
        End Try
    End Function
    Friend Sub CarregaDados()
        'chama o método getAlunos para carregar o dataset dsalunos 
        dsLembretes = GetLembrete()
        'define a fonte de dados como sendo o dataset
        Me.dglembrete.DataSource = dsLembretes
        'define o valor do datamember do controle
        Me.dglembrete.DataMember = "lembrete"
        'indica que o datagrid é somente leitura ,  não permite edição
        Me.dglembrete.ReadOnly = True
        'desenha o grid 
        Dim ts1 As New DataGridTableStyle
        ts1.MappingName = "lembrete"
        ' define outras propriedades como cor do fundo
        ts1.AlternatingBackColor = Color.LightGray
        ' Inclui um GridColumnStyle e define seu MappingName 
        Dim idcol As New DataGridTextBoxColumn
        idcol.MappingName = "ID"
        idcol.HeaderText = "ID"
        idcol.Width = 30
        ts1.GridColumnStyles.Add(idcol)
        ' Inclua a segunda coluna estili (column style.)
        'define titulo o mapeamento para o campo e a largura
        Dim deCol As New DataGridTextBoxColumn
        deCol.MappingName = "DE"
        deCol.HeaderText = "DE"
        deCol.Width = 160
        ts1.GridColumnStyles.Add(deCol)
        ' Inclua a segunda coluna estili (column style.)
        'define titulo o mapeamento para o campo e a largura
        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "lembrete"
        TextCol.HeaderText = "lembrete"
        TextCol.Width = 200
        ts1.GridColumnStyles.Add(TextCol)
        'Inclua a terceira coluna estili (column style.)
        'define titulo o mapeamento para o campo e a largura
        Dim namecol As New DataGridTextBoxColumn
        namecol.MappingName = "PARA"
        namecol.HeaderText = "PARA"
        namecol.Width = 160
        ts1.GridColumnStyles.Add(namecol)
        'Inclua a terceira coluna estili (column style.)
        'define titulo o mapeamento para o campo e a largura
        Dim datacol As New DataGridTextBoxColumn
        datacol.MappingName = "DATA"
        datacol.HeaderText = "DATA"
        datacol.Width = 100
        ts1.GridColumnStyles.Add(datacol)
        'limpa qualquer estilo ja existente
        dglembrete.TableStyles.Clear()
        ' Inclui uma instancia de DataGridTableStyle a GridTableStylesCollection. 
        dglembrete.TableStyles.Add(ts1)
    End Sub
    Sub carrega()
        Try
            CarregaDados()
        Catch ex As Exception
            CarregaDados()
        End Try
    End Sub
    Public Sub New(ByVal nomeUser As String)
        InitializeComponent()
        lblNome.Text = nomeUser
    End Sub
    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        'cria um novo objeto formulário com base em
        Dim frm As New adicionar
        frm.lblNome.Text = lblNome.Text
        'inclui um titulo no formulário novo
        frm.Text = "Novo lembrete"
        'exibe o formulario
        frm.ShowDialog()
    End Sub
    Public Sub Salvalembrete(ByVal ds As DataSet)
        'pega um conexão com o banco de dados
        Dim conn As MySqlConnection = dados.GetConnection()
        Try
            'define a string sql para selecionar alunos da tabela alunos
            Dim sql As String = "select lembrete,para,data,id from lembrete"
            'cria um dataadapter para ser usado com o dataset
            'um dataadapter representa um conjunto de comandos e uma conexão usaddasa para preencher um dataset e atualizar a fonte de dados
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            Try
                'cria um objeto OledbCommandBuilder
                'este objeto fornece um meio de gerar automaticamente 
                'uma tabela unica de comandos usadas para reconciliar 
                'as mudanças feitas no dastaset com o banco de dados associado
                ' pois o OleDbDataAdapter não gera os comandos para efetuar esta conciliação
                Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                'se houve alterações no dataset então atualiza o dataset e aceita as alterações
                'O método acceptChanges faz o commit de todas as alterações feitas para a tabela
                'desde a última vez que acceptChanges foi chamado.
                If ds.HasChanges Then
                    da.Update(ds, "lembrete")
                    ds.AcceptChanges()
                End If
            Finally
                'libera o recursos
                da.Dispose()
            End Try
        Finally
            'estes comandos SEMPRE serão executados pois estao no bloco finally
            'fecha a conexão e libera o recursos
            conn.Close()
            conn.Dispose()
        End Try
    End Sub
    Private Sub btnCarregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregar.Click
        Try
            'carrega dados da tabela no dataset
            Me.CarregaDados()
        Catch ex As Exception
            'mensagem de erro
            MsgBox("Erro a carregar dados da tabela." & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Function GetNomeDoDataRow(ByVal dr As DataRow) As String
        ' pega onome do aluno de um datarow permtindo nulls
        Dim resultado As String
        'verifica se o nome e o sobrenome são null e converte explicitamente os valores 
        'concatenando na string resultado
        'isNull é a propriedade que retorna o valor que indica se uma coluna contem um valor null
        If Not dr.IsNull("lembrete") Then
            resultado = CType(dr.Item("lembrete"), String)
        End If
        If Not dr.IsNull("para") Then
            resultado += " do colaborador " + " "
        End If
        If Not dr.IsNull("para") Then
            resultado += CType(dr.Item("para"), String) + " "
        End If
        'retorna o resultado
        Return resultado
    End Function
    Private Sub btnDeleta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleta.Click
        'cria um objeto currencyManager
        'a classe gerencia uma lista de objetos vinculados
        Dim cm As CurrencyManager
        'verifica se o dataset esta vazio
        'isNothing - retorna um valor booleano indicando se a expressão possui ou nao um objeto associado a ela
        If IsNothing(dsLembretes) Then Exit Sub
        'converte o dataset para o tipo currencyManager
        'cType - retorna o resultado da conversão explicita para um tipo de dado especificado
        cm = CType(BindingContext(dsLembretes, "lembrete"), CurrencyManager)
        'obtem a linha atual do currencyManager
        Dim dr As DataRow = CType(cm.Current, DataRowView).Row
        'exibe a mensagem para excluir o aluno e salvar as alterações
        If MsgBox("Confirma a exclusão do lembrete : " + GetNomeDoDataRow(dr) + "?", MsgBoxStyle.OkCancel, "Dipack") = MsgBoxResult.Ok Then
            'delete a linha do dataset
            '(um datarow representa uma linha em um datatable)
            dr.Delete()
            'obtem os dados alterados e salva as alterações
            'getChanges - obtem uma copia do dataset contendo todas as 
            'alteracoes feitas deste a ultima vez que foi carregado ou 
            'da última chamada do AcceptChanges
            Dim dsChanged As DataSet = dsLembretes.GetChanges
            SalvaLembrete(dsLembretes)
        Else
            'reseta o dataset e rejeita as alterações
            'rejectChanges - rejeita todas as alterações feitas na linha
            ' desde a ultima chamada de acceptChanges
            dsLembretes.RejectChanges()
        End If
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class