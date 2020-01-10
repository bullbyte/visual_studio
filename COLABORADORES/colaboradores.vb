Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Threading
Public Class colaboradores
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
            Dim sql As String = "select ID,NOME,SOBRENOME,ADMISSAO,SETOR,CLIENTE from colaboradores where (EFETIVO = 'ATIVADO') order by NOME " '+ campoOrdem
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
            Dim sql As String = "Select * from colaboradores where ID = " & id.ToString
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
        Dim nameCol As New DataGridTextBoxColumn
        nameCol.MappingName = "NOME"
        nameCol.HeaderText = "NOME"
        nameCol.Width = 100
        ts1.GridColumnStyles.Add(nameCol)
        'Inclua a terceira coluna estili (column style.)
        'define titulo o mapeamento para o campo e a largura
        Dim sobreNomecol As New DataGridTextBoxColumn
        sobreNomecol.MappingName = "SOBRENOME"
        sobreNomecol.HeaderText = "SOBRENOME"
        sobreNomecol.Width = 200
        ts1.GridColumnStyles.Add(sobreNomecol)
        Dim admissaocol As New DataGridTextBoxColumn
        admissaocol.MappingName = "ADMISSAO"
        admissaocol.HeaderText = "DATA DE ADMISSÃO"
        admissaocol.Width = 300
        ts1.GridColumnStyles.Add(admissaocol)
        Dim setorcol As New DataGridTextBoxColumn
        setorcol.MappingName = "SETOR"
        setorcol.HeaderText = "SETOR"
        setorcol.Width = 200
        ts1.GridColumnStyles.Add(setorcol)
        Dim clientecol As New DataGridTextBoxColumn
        clientecol.MappingName = "CLIENTE"
        clientecol.HeaderText = "CLIENTE"
        clientecol.Width = 200
        ts1.GridColumnStyles.Add(clientecol)
        'limpa qualquer estilo ja existente
        dgcolaboradores.TableStyles.Clear()
        ' Inclui uma instancia de DataGridTableStyle a GridTableStylesCollection. 
        dgcolaboradores.TableStyles.Add(ts1)
    End Sub
    Private Sub dgcolaboradores_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgcolaboradores.MouseUp
        Dim pt = New Point(e.X, e.Y)
        Dim hti As DataGrid.HitTestInfo = dgcolaboradores.HitTest(pt)

        If hti.Type = DataGrid.HitTestType.Cell Then
            dgcolaboradores.CurrentCell = New DataGridCell(hti.Row, hti.Column)
            dgcolaboradores.Select(hti.Row)
        End If
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
        frm.colaboradores = Me   ' define a referencia para este form, permite chamar a função CarregaDados
        frm.Text = " EDITAR DADOS DE " & frm.txtNome.Text & " " & frm.txtSobreNome.Text
        frm.carregaDados(dsColaborador)
        frm.ShowDialog()
    End Sub
    Public Function GetNovoColaborador() As DataSet
        'retorna um dataset representando um novo aluno
        Dim conn As MySqlConnection = dados.GetConnection()
        Try
            'cria a instrução sql para selecionar alunos da tabela alunos (não vai retornar nada)
            Dim sql As String = "Select * from colaboradores where ID = -1"
            'cria um dataadapter para ser usado com o dataset
            'um dataadapter representa um conjunto de comandos e uma conexão usaddasa para preencher um dataset e atualizar a fonte de dados
            Dim sa As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            'cria o objeto dataset
            Dim ds As New DataSet
            Try
                sa.Fill(ds, "colaboradores")                     'retorna um dataset vazio mas com a estrutura correta
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
        Dim dsColaborador As DataSet = GetNovoColaborador
        'cria um novo objeto formulário com base em frmAluno 
        Dim frm As New editar
        frm.colaboradores = Me   ' define a referencia para este form, permite chamar a função CarregaDados
        'inclui um titulo no formulário novo
        frm.Text = "Adicionar Novo Colaborador"
        'carrega o dataset com os dados do aluno
        frm.carregaDados(dsColaborador)
        'exibe o formulario
        frm.picFoto.Image = frm.picFoto.InitialImage
        frm.ShowDialog()
    End Sub
#End Region
#Region "PESQUISA"
    Sub LISTARSETOR() Handles MyBase.Load
        Try
            Dim ds As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim conn As MySqlConnection = dados.GetConnection()
            Dim sql As String = "select SETOR from setor order by setor"
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter(sql, conn)
            procuraImpime.Items.Clear()
            adptr.Fill(ds, "SETOR")
            dt = ds.Tables(0)
            For Each dr In dt.Rows
                procuraImpime.Items.Add(dr.Item("SETOR"))
            Next
            dados.strConn.Close()
        Finally
            dados.strConn.Close()
        End Try
    End Sub
    Public Function LinhasSelecionadas(ByVal dg As DataGrid) As System.Collections.ArrayList
        Dim al As New ArrayList
        Dim cm As CurrencyManager = Me.BindingContext(dg.DataSource, dg.DataMember)
        Dim dv As DataView = CType(cm.List, DataView)
        Dim i As Integer
        For i = 0 To dv.Count - 1
            If dg.IsSelected(i) Then
                al.Add(i)
            End If
        Next
        Return al
    End Function
#End Region
#Region "IMPRIMIR"
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim ds As New DataSet
        'cria o documento e dá o nome ao mesmo
        Dim medicosDocument = New Printing.PrintDocument
        'incluir o manipulador de eventos
        AddHandler medicosDocument.PrintPage, AddressOf Me.imprimirMedicos
        'modo de visualização
        'define algumas propriedades do projecto
        With dlgVisualiza
            'indica qual o documento a ser visualizado
            .Document = medicosDocument
            .WindowState = FormWindowState.Maximized
            .PrintPreviewControl.Zoom = 1
            .Text = "Listagem dos Colaboradores"
            .ShowDialog()
        End With
        'libertar o documento após imprimir
        medicosDocument.Dispose()
    End Sub
    Private leitor As MySqlDataReader
    Private paginaAtual As Integer = 1

    Private Sub imprimirMedicos(ByVal sender As Object, ByVal e As Drawing.Printing.PrintPageEventArgs)
        Dim cmd As MySqlCommand = dados.strConn.CreateCommand
        cmd.CommandText = "Select nome, sobrenome, setor, cliente from colaboradores where (EFETIVO = 'ATIVADO') order by nome"
        dados.strConn.Open()
        Dim leitor As MySqlDataReader = cmd.ExecuteReader()
        Try
            While leitor.Read()

                Dim margemEsq As Single = e.MarginBounds.Left
                Dim margemDir As Single = e.MarginBounds.Right
                Dim margemSup As Single = e.MarginBounds.Top
                Dim margemInf As Single = e.MarginBounds.Bottom
                Dim linhasLidas As Integer = 1
                Dim cont = 250
                Dim canetadaimpressora As Pen = New Pen(Color.DarkGreen, 2)
                'Variáveis das fontes
                Dim fonteNegrito As Font
                Dim fonteTitulo As Font
                Dim fonteSubtitulo As Font
                Dim fonteRodape As Font
                Dim fonteNormal As Font
                'define efeitos em fonte
                fonteNegrito = New Font("calibri", 9, FontStyle.Bold)
                fonteTitulo = New Font("calibri", 15, FontStyle.Bold)
                fonteSubtitulo = New Font("calibri", 10, FontStyle.Bold)
                fonteRodape = New Font("calibri", 10)
                fonteNormal = New Font("calibri", 10)
                'define-se o número de linhas por página
                'divide-se a área de impressão pelo tamanho da fonte subtraindo 10 valores
                Dim linhasporpagina = e.MarginBounds.Height / fonteNormal.GetHeight(e.Graphics) + 20
                'imagem
                e.Graphics.DrawImage(Image.FromFile("C:\Documents and Settings\Administrador\Desktop\Joao\Logo\LOGO_DIPACK.jpg"), 100, 20)
                'cabeçalho
                e.Graphics.DrawLine(canetadaimpressora, margemEsq, 15, margemDir, 15)
                e.Graphics.DrawLine(canetadaimpressora, margemEsq, 90, margemDir, 90)
                e.Graphics.DrawString("Listagem dos Colaboradores", fonteTitulo, Brushes.DarkGreen, margemEsq + 300, 30, New StringFormat())
                
                e.Graphics.DrawString(System.DateTime.Today, fonteSubtitulo, Brushes.Black, margemDir - 220, 60, New StringFormat())
                'campos a serem impressos
                e.Graphics.DrawString("NOME : ", fonteNegrito, Brushes.Black, margemEsq, 100, New StringFormat())
                e.Graphics.DrawString("SOBRENOME : ", fonteNegrito, Brushes.Black, margemEsq + 100, 100, New StringFormat())
                e.Graphics.DrawString("SETOR : ", fonteNegrito, Brushes.Black, margemEsq + 300, 100, New StringFormat())
                e.Graphics.DrawString("CLIENTE : ", fonteNegrito, Brushes.Black, margemEsq + 500, 100, New StringFormat())

                'cliente
                'para imprimir os dados da base de dados no relatório teremos que atribuir as variáveis os valores 
                'através do objeto OleDbDatareader
                Dim nome = leitor(0) 'codigo do produto
                Dim sobrenome = leitor(1) 'nome do produto
                Dim setor = leitor(2)
                Dim cliente = leitor(3)

                Dim linhaAtual = 1
                'dados a serem impressos
                While (linhaAtual < linhasporpagina And leitor.Read())
                    'acompanha a posição da linha atual
                    Dim posicaoDaLinha = margemSup + (linhaAtual * fonteNormal.GetHeight(e.Graphics))
                    'imprime os dados relativo ao codigo , nome do produto e preço do produto
                    e.Graphics.DrawString(nome, fonteNormal, Brushes.Black, margemEsq, posicaoDaLinha, New StringFormat())
                    e.Graphics.DrawString(sobrenome, fonteNormal, Brushes.Black, margemEsq + 100, posicaoDaLinha, New StringFormat())
                    e.Graphics.DrawString(setor, fonteNormal, Brushes.Black, margemEsq + 300, posicaoDaLinha, New StringFormat())
                    e.Graphics.DrawString(cliente, fonteNormal, Brushes.Black, margemEsq + 500, posicaoDaLinha, New StringFormat())
                    'faz o incremento no número de linha
                    linhaAtual += 1
                    'verifica se ainda podemos imprimir , ou seja , se a linha atual é menor que o número
                    'de linhas permitido pela página. Se for continuamos a atribuir os dados e a imprimir
                    If (linhaAtual < linhasporpagina) Then
                        nome = leitor(0) 'codigo do produto
                        sobrenome = leitor(1) 'nome do produto
                        setor = leitor(2)
                        cliente = leitor(3)
                    End If

                End While

                'rodapé
                Dim paginaactual = 1
                e.Graphics.DrawLine(canetadaimpressora, margemEsq, margemInf, margemDir, margemInf)
                e.Graphics.DrawString(System.DateTime.Now.ToString(), fonteRodape, Brushes.Black, margemEsq, margemInf, New StringFormat())
                e.Graphics.DrawString("Página." & paginaactual, fonteRodape, Brushes.Black, margemDir - 55, margemInf, New StringFormat())
            End While
            leitor.Close()
            dados.strConn.Close()
        Catch erro As Exception
            MsgBox("Erro " & vbCrLf & erro.ToString, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
#End Region
    Private Sub btnCarregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregar.Click
        carrega()
    End Sub
    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        edita()
    End Sub
    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        adiciona()
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class