Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Threading
Public Class usuarios
    Dim dados As New DADOS.conecxao
#Region "LISTA colaboradores"
    Private dscolaboradores As DataSet
    Public Overloads Function Getcolaboradores() As DataSet
        'retorna um dataset representando os alunos 
        Return Me.Getcolaboradores("ID")
    End Function
    Public Overloads Function Getcolaboradores(ByVal campoOrdem As String) As DataSet
        'obtem a conexao com o banco de dados
        Dim conn As MySqlConnection = dados.GetConnection()
        Try
            'cria o dataset novo
            Dim ds As New DataSet
            'define a string sql para selecionar os alunos da tabela alunos ordenados pelo campo definido
            Dim sql As String = "select ID,Nome,Sobrenome from colaboradores where (EFETIVO = 'ATIVADO') order by " + campoOrdem
            'cria um dataadapter para preencher o dataset
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            Try
                'preenche o dataset com os dados da tabela alunos
                da.Fill(ds, "colaboradores")
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
    Public Function GetColaborador(ByVal id As Integer) As DataSet
        'Retorna um datset repesentando um único aluno identificado pelo ID passado como parametro
        Dim conn As MySqlConnection = dados.GetConnection()
        Try
            'cria uma string sql para selecionar o aluno pelo id
            Dim sql As String = "Select * from colaboradores where id = " & id.ToString
            'cria um dataadapter para ser usado com o dataset
            'um dataadapter representa um conjunto de comandos e uma conexão usaddasa para preencher um dataset e atualizar a fonte de dados
            Dim sa As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            Dim ds As New DataSet
            Try
                'preenche o dataset com os dados da tabela alunos
                sa.Fill(ds, "colaboradores")
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
        dscolaboradores = Getcolaboradores()
        'define a fonte de dados como sendo o dataset
        Me.dgcolaboradores.DataSource = dscolaboradores
        'define o valor do datamember do controle
        Me.dgcolaboradores.DataMember = "colaboradores"
        'indica que o datagrid é somente leitura ,  não permite edição
        Me.dgcolaboradores.ReadOnly = True
        'desenha o grid 
        Dim ts1 As New DataGridTableStyle
        ts1.MappingName = "colaboradores"
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
        TextCol.MappingName = "NOME"
        TextCol.HeaderText = "NOME"
        TextCol.Width = 100
        ts1.GridColumnStyles.Add(TextCol)
        'Inclua a terceira coluna estili (column style.)
        'define titulo o mapeamento para o campo e a largura
        Dim namecol As New DataGridTextBoxColumn
        namecol.MappingName = "SOBRENOME"
        namecol.HeaderText = "SOBRENOME"
        namecol.Width = 200
        ts1.GridColumnStyles.Add(namecol)
        'limpa qualquer estilo ja existente
        dgcolaboradores.TableStyles.Clear()
        ' Inclui uma instancia de DataGridTableStyle a GridTableStylesCollection. 
        dgcolaboradores.TableStyles.Add(ts1)
    End Sub
    Sub carrega()
        Try
            Me.CarregaDados()
        Catch ex As Exception
            MsgBox("Erro ao conectar Dados." & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub edita()
        'define um CurrencyManager
        Dim cm As CurrencyManager
        'verifica se o dataset é nulo
        If IsNothing(dscolaboradores) Then Exit Sub
        'faz a conversão explicita para o CurrencyManager do dataset
        cm = CType(BindingContext(dscolaboradores, "colaboradores"), CurrencyManager)
        'obtem o ID do aluno
        Dim id As Integer
        Dim dr As DataRowView = CType(cm.Current, DataRowView)
        id = CType(dr.Item("ID"), Integer)
        'obtem o aluno selecionado pelo ID através do método getAluno()
        Dim dsColaborador As DataSet = GetColaborador(id)
        'cria um formulário do tipo frmALuno e exibe os dados
        Dim frm As New editar
        frm.usuarios = Me   ' define a referencia para este form, permite chamar a função CarregaDados
        frm.carregaDados(dsColaborador)
        'frm.MdiParent = iFRAME
        frm.ShowDialog()
    End Sub
#End Region
    Private Sub usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        introUser.Movie = (Application.StartupPath & "\artUser.swf")
        carrega()
        segundoPlano.RunWorkerAsync()
    End Sub
    Private Sub btnCarregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregar.Click
        carrega()
    End Sub
    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        edita()
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class