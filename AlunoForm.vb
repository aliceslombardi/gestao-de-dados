Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data

Public Class AlunoForm
    Private cs As String = ConfigurationManager.ConnectionStrings("FormacaoDB").ConnectionString
    Private car As Boolean = False

    Private Sub AlunoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadA()
        LoadC()
        Clean()
    End Sub

    Private Sub Clean()
        txtNomeAluno.Clear()
        dtpDataNascimento.Value = Date.Today
        txtEmail.Clear()
        txtTelefone.Clear()
        cboCursos.SelectedIndex = -1
        btnAdicionar.Enabled = False
        btnAtualizar.Enabled = False
        btnExcluir.Enabled = False
        dgvAlunos.ClearSelection()
    End Sub

    Private Sub LoadA()
        car = True
        Try
            Using c As New SqlConnection(cs)
                Dim da As New SqlDataAdapter("SELECT FormandoID, Nome, Email, Telefone, DataNascimento FROM Formandos", c)
                Dim t As New DataTable()
                da.Fill(t)
                dgvAlunos.DataSource = t
            End Using
            If dgvAlunos.Columns.Contains("FormandoID") Then
                dgvAlunos.Columns("FormandoID").Visible = False
            End If
            dgvAlunos.ClearSelection()
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar alunos: " & ex.Message)
        Finally
            car = False
        End Try
    End Sub

    Private Sub LoadC()
        Try
            Using c As New SqlConnection(cs)
                Dim cmd As New SqlCommand("SELECT CursoID, Nome FROM Cursos WHERE DataFim >= @Hoje", c)
                cmd.Parameters.AddWithValue("@Hoje", Date.Today)
                Dim da As New SqlDataAdapter(cmd)
                Dim t As New DataTable()
                da.Fill(t)
                cboCursos.DisplayMember = "Nome"
                cboCursos.ValueMember = "CursoID"
                cboCursos.DataSource = t
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar cursos: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        If String.IsNullOrWhiteSpace(txtNomeAluno.Text) Then
            MessageBox.Show("O nome do aluno é obrigatório.")
            Return
        End If

        Try
            Using c As New SqlConnection(cs)
                Dim cmd As New SqlCommand("INSERT INTO Formandos (Nome, Email, Telefone, DataNascimento) VALUES (@Nome, @Email, @Telefone, @DataNascimento)", c)
                cmd.Parameters.AddWithValue("@Nome", txtNomeAluno.Text)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text)
                cmd.Parameters.AddWithValue("@DataNascimento", dtpDataNascimento.Value.Date)
                c.Open()
                cmd.ExecuteNonQuery()
            End Using
            LoadA()
            Clean()
        Catch ex As Exception
            MessageBox.Show("Erro ao adicionar aluno: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        If dgvAlunos.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecione um aluno para atualizar.")
            Return
        End If

        Try
            Dim id As Integer = CInt(dgvAlunos.SelectedRows(0).Cells("FormandoID").Value)
            Using c As New SqlConnection(cs)
                Dim cmd As New SqlCommand("UPDATE Formandos SET Nome=@Nome, Email=@Email, Telefone=@Telefone, DataNascimento=@DataNascimento WHERE FormandoID=@ID", c)
                cmd.Parameters.AddWithValue("@Nome", txtNomeAluno.Text)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text)
                cmd.Parameters.AddWithValue("@DataNascimento", dtpDataNascimento.Value.Date)
                cmd.Parameters.AddWithValue("@ID", id)
                c.Open()
                cmd.ExecuteNonQuery()
            End Using
            LoadA()
            Clean()
        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar aluno: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If dgvAlunos.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecione um aluno para excluir.")
            Return
        End If

        Try
            Dim id As Integer = CInt(dgvAlunos.SelectedRows(0).Cells("FormandoID").Value)
            Using c As New SqlConnection(cs)
                Dim cmd As New SqlCommand("DELETE FROM Formandos WHERE FormandoID=@ID", c)
                cmd.Parameters.AddWithValue("@ID", id)
                c.Open()
                cmd.ExecuteNonQuery()
            End Using
            LoadA()
            Clean()
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir aluno: " & ex.Message)
        End Try
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Clean()
        btnAdicionar.Enabled = True
    End Sub

    Private Sub dgvAlunos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAlunos.SelectionChanged
        If car Then
            Return
        End If

        If dgvAlunos.SelectedRows.Count > 0 Then
            Dim row = dgvAlunos.SelectedRows(0)
            txtNomeAluno.Text = row.Cells("Nome").Value.ToString()
            dtpDataNascimento.Value = CDate(row.Cells("DataNascimento").Value)
            txtEmail.Text = row.Cells("Email").Value.ToString()
            txtTelefone.Text = row.Cells("Telefone").Value.ToString()
            btnAdicionar.Enabled = False
            btnAtualizar.Enabled = True
            btnExcluir.Enabled = True
        Else
            Clean()
        End If
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub
End Class
