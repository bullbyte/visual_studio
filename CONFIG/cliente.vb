Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Drawing

Public Class cliente
    Dim dados As New DADOS.conecxao
#Region "LISTA clientes"
    Private dsclientes As DataSet
    Public Overloads Function Getclientes() As DataSet
        'retorna um dataset representando os alunos 
        Return Me.Getclientes("ID")
    End Function
    Public Overloads Function Getclientes(ByVal campoOrdem As String) As DataSet
        'obtem a conexao com o banco de dados
        Dim conn As MySqlConnection = dados.GetConnection()
        Try
            'cria o dataset novo
            Dim ds As New DataSet
            'define a string sql para selecionar os alunos da tabela alunos ordenados pelo campo definido
            Dim sql As String = "select ID,NOME_FANTAZIA from clientes order by NOME_FANTAZIA " '+ campoOrdem
            'cria um dataadapter para preencher o dataset
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            Try
                'preenche o dataset com os dados da tabela alunos
                da.Fill(ds, "clientes")
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
    Public Function Getcliente(ByVal id As Integer) As DataSet
        'Retorna um datset repesentando um único aluno identificado pelo ID passado como parametro
        Dim conn As MySqlConnection = dados.GetConnection()
        Try
            'cria uma string sql para selecionar o aluno pelo id
            Dim sql As String = "Select * from clientes where ID = " & id.ToString
            'cria um dataadapter para ser usado com o dataset
            'um dataadapter representa um conjunto de comandos e uma conexão usaddasa para preencher um dataset e atualizar a fonte de dados
            Dim sa As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            Dim ds As New DataSet
            Try
                'preenche o dataset com os dados da tabela alunos
                sa.Fill(ds, "clientes")
            Finally
                'estes comandos SEMPRE serão executados pois estao no bloco finally
                'libera o dataadapter 
                sa.Dispose()
            End Try
            'retorna o dataset gerado com os dados do aluno selecionado
            Return ds
        Finally
            'estes comandos SEMPRE serão executados pois estao no bloco finally
            'fecha a conexão e libera o recursos
            conn.Close()
            conn.Dispose()
        End Try
    End Function
    Friend Sub CarregaDados()
        'chama o método getAlunos para carregar o dataset dsalunos 
        dsclientes = Getclientes()
        'define a fonte de dados como sendo o dataset
        Me.dgClientes.DataSource = dsclientes
        'define o valor do datamember do controle
        Me.dgClientes.DataMember = "clientes"
        'indica que o datagrid é somente leitura ,  não permite edição
        Me.dgClientes.ReadOnly = True
        'desenha o grid 
        Dim ts1 As New DataGridTableStyle
        ts1.MappingName = "clientes"
        ' define outras propriedades como cor do fundo
        ts1.AlternatingBackColor = Color.LightGray
        ' Inclui um GridColumnStyle e define seu MappingName 
        Dim idcol As New DataGridTextBoxColumn
        idcol.MappingName = "ID"
        idcol.HeaderText = "ID"
        idcol.Width = 1
        ts1.GridColumnStyles.Add(idcol)
        ' Inclua a segunda coluna estili (column style.)
        'define titulo o mapeamento para o campo e a largura
        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "NOME_FANTAZIA"
        TextCol.HeaderText = "NOME FANTAZIA"
        TextCol.Width = 200
        ts1.GridColumnStyles.Add(TextCol)
        'limpa qualquer estilo ja existente
        dgClientes.TableStyles.Clear()
        ' Inclui uma instancia de DataGridTableStyle a GridTableStylesCollection. 
        dgClientes.TableStyles.Add(ts1)
    End Sub
    Sub carrega()
        Try
            CarregaDados()
        Catch ex As Exception
            'MsgBox("Erro ao conectar Dados." & vbCrLf & ex.Message)
            CarregaDados()
        End Try
    End Sub
    Sub edita()
        'define um CurrencyManager
        Dim cm As CurrencyManager
        'verifica se o dataset é nulo
        If IsNothing(dsclientes) Then Exit Sub
        'faz a conversão explicita para o CurrencyManager do dataset
        cm = CType(BindingContext(dsclientes, "clientes"), CurrencyManager)
        'obtem o ID do aluno
        Dim id As Integer
        Dim dr As DataRowView = CType(cm.Current, DataRowView)
        id = CType(dr.Item("ID"), Integer)
        'obtem o aluno selecionado pelo ID através do método getAluno()
        Dim dsColaborador As DataSet = Getcliente(id)
        'cria um formulário do tipo frmALuno e exibe os dados
        Dim frm As New editar
        frm.cliente = Me   ' define a referencia para este form, permite chamar a função CarregaDados
        frm.Text = " EDITAR DADOS DE " & frm.txtNome.Text & ""
        frm.carregaDados(dsColaborador)
        frm.ShowDialog()
    End Sub
    Public Function GetNovoColaborador() As DataSet
        'retorna um dataset representando um novo aluno
        Dim conn As MySqlConnection = dados.GetConnection()
        Try
            'cria a instrução sql para selecionar alunos da tabela alunos (não vai retornar nada)
            Dim sql As String = "Select * from clientes where ID = -1"
            'cria um dataadapter para ser usado com o dataset
            'um dataadapter representa um conjunto de comandos e uma conexão usaddasa para preencher um dataset e atualizar a fonte de dados
            Dim sa As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            'cria o objeto dataset
            Dim ds As New DataSet
            Try
                sa.Fill(ds, "clientes")                     'retorna um dataset vazio mas com a estrutura correta
                Dim dr As DataRow = ds.Tables(0).NewRow   'cria uma nova linha em branco na tabela
                ds.Tables(0).Rows.Add(dr)                 'inclui a linha em branco no dataset
            Finally
                'estes comandos SEMPRE serão executados pois estao no bloco finally
                'libera o recursos
                sa.Dispose()
            End Try
            'retorna o datasete contendo uma nova linha em branco para um novo aluno
            Return ds
        Finally
            'fecha a conexão e libera o recursos
            'estes comandos SEMPRE serão executados pois estao no bloco finally
            conn.Close()
            conn.Dispose()
        End Try
    End Function
    Sub adiciona()
        'obtem o aluno selecionado
        Dim dsColaborador As DataSet = GetNovoColaborador()
        'cria um novo objeto formulário com base em frmAluno 
        Dim frm As New editar
        frm.cliente = Me   ' define a referencia para este form, permite chamar a função CarregaDados
        'inclui um titulo no formulário novo
        frm.Text = "Adicionar Novo cliente"
        'carrega o dataset com os dados do aluno
        frm.carregaDados(dsColaborador)
        'exibe o formulario
        frm.ShowDialog()
    End Sub
#End Region
    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        adiciona()
    End Sub
    Private Sub cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaDados()
    End Sub
End Class