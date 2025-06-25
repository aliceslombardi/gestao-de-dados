Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data

Public Class AlunoForm
    Private connectionString As String = ConfigurationManager.ConnectionStrings("FormacaoDB").ConnectionString
    Private carregando As Boolean = False

    Private Sub AlunoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarAlunos()
        CarregarCursosAtivos()
        LimparCampos()
    End Sub

    Private Sub LimparCampos()
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

    Private Sub CarregarAlunos()
        carregando = True
        Try
            Using conn As New SqlConnection(connectionString)
                Dim adapter As New SqlDataAdapter("SELECT f.FormandoID, f.Nome, f.Email, f.Telefone, f.DataNascimento, i.CursoID, c.Nome AS Curso " & _
                                                "FROM Formandos f " & _
                                                "LEFT JOIN Inscricoes i ON f.FormandoID = i.FormandoID " & _
                                                "LEFT JOIN Cursos c ON i.CursoID = c.CursoID", conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvAlunos.DataSource = table
            End Using
            If dgvAlunos.Columns.Contains("FormandoID") Then
                dgvAlunos.Columns("FormandoID").Visible = False
            End If
            If dgvAlunos.Columns.Contains("CursoID") Then
                dgvAlunos.Columns("CursoID").Visible = False
            End If
            dgvAlunos.ClearSelection()
        Catch ex As Exception
            MessageBox.Show($"Erro ao carregar alunos: {ex.Message}")
        Finally
            carregando = False
        End Try
    End Sub

    Private Sub CarregarCursosAtivos()
        Try
            Using conn As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("SELECT CursoID, Nome FROM Cursos WHERE DataFim >= @Hoje", conn)
                cmd.Parameters.AddWithValue("@Hoje", Date.Today)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                cboCursos.DisplayMember = "Nome"
                cboCursos.ValueMember = "CursoID"
                cboCursos.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show($"Erro ao carregar cursos: {ex.Message}")
        End Try
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        If String.IsNullOrWhiteSpace(txtNomeAluno.Text) Then
            MessageBox.Show("O nome do aluno é obrigatório.")
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("INSERT INTO Formandos (Nome, Email, Telefone, DataNascimento) OUTPUT INSERTED.FormandoID VALUES (@Nome, @Email, @Telefone, @DataNascimento)", conn)
                cmd.Parameters.AddWithValue("@Nome", txtNomeAluno.Text)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text)
                cmd.Parameters.AddWithValue("@DataNascimento", dtpDataNascimento.Value.Date)
                conn.Open()
                Dim formandoId As Integer = CInt(cmd.ExecuteScalar())

                If cboCursos.SelectedIndex >= 0 Then
                    Dim cmdIns As New SqlCommand("INSERT INTO Inscricoes (FormandoID, CursoID) VALUES (@FormandoID, @CursoID)", conn)
                    cmdIns.Parameters.AddWithValue("@FormandoID", formandoId)
                    cmdIns.Parameters.AddWithValue("@CursoID", CInt(cboCursos.SelectedValue))
                    cmdIns.ExecuteNonQuery()
                End If
            End Using
            CarregarAlunos()
            LimparCampos()
        Catch ex As Exception
            MessageBox.Show($"Erro ao adicionar aluno: {ex.Message}")
        End Try
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        If dgvAlunos.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecione um aluno para atualizar.")
            Return
        End If

        Try
            Dim id As Integer = CInt(dgvAlunos.SelectedRows(0).Cells("FormandoID").Value)
            Using conn As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("UPDATE Formandos SET Nome=@Nome, Email=@Email, Telefone=@Telefone, DataNascimento=@DataNascimento WHERE FormandoID=@ID", conn)
                cmd.Parameters.AddWithValue("@Nome", txtNomeAluno.Text)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text)
                cmd.Parameters.AddWithValue("@DataNascimento", dtpDataNascimento.Value.Date)
                cmd.Parameters.AddWithValue("@ID", id)
                conn.Open()
                cmd.ExecuteNonQuery()

                If cboCursos.SelectedIndex >= 0 Then
                    Dim cmdIns As New SqlCommand("IF EXISTS (SELECT 1 FROM Inscricoes WHERE FormandoID=@ID) " & _
                                                "UPDATE Inscricoes SET CursoID=@CursoID WHERE FormandoID=@ID " & _
                                                "ELSE INSERT INTO Inscricoes (FormandoID, CursoID) VALUES (@ID, @CursoID)", conn)
                    cmdIns.Parameters.AddWithValue("@ID", id)
                    cmdIns.Parameters.AddWithValue("@CursoID", CInt(cboCursos.SelectedValue))
                    cmdIns.ExecuteNonQuery()
                Else
                    Dim cmdDel As New SqlCommand("DELETE FROM Inscricoes WHERE FormandoID=@ID", conn)
                    cmdDel.Parameters.AddWithValue("@ID", id)
                    cmdDel.ExecuteNonQuery()
                End If
            End Using
            CarregarAlunos()
            LimparCampos()
        Catch ex As Exception
            MessageBox.Show($"Erro ao atualizar aluno: {ex.Message}")
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If dgvAlunos.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecione um aluno para excluir.")
            Return
        End If

        Try
            Dim id As Integer = CInt(dgvAlunos.SelectedRows(0).Cells("FormandoID").Value)
            Using conn As New SqlConnection(connectionString)
                Dim cmdDelIns As New SqlCommand("DELETE FROM Inscricoes WHERE FormandoID=@ID", conn)
                cmdDelIns.Parameters.AddWithValue("@ID", id)
                Dim cmd As New SqlCommand("DELETE FROM Formandos WHERE FormandoID=@ID", conn)
                cmd.Parameters.AddWithValue("@ID", id)
                conn.Open()
                cmdDelIns.ExecuteNonQuery()
                cmd.ExecuteNonQuery()
            End Using
            CarregarAlunos()
            LimparCampos()
        Catch ex As Exception
            MessageBox.Show($"Erro ao excluir aluno: {ex.Message}")
        End Try
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        LimparCampos()
        btnAdicionar.Enabled = True
    End Sub

    Private Sub dgvAlunos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAlunos.SelectionChanged
        If carregando Then
            Return
        End If

        If dgvAlunos.SelectedRows.Count > 0 Then
            Dim row = dgvAlunos.SelectedRows(0)
            txtNomeAluno.Text = row.Cells("Nome").Value.ToString()
            dtpDataNascimento.Value = CDate(row.Cells("DataNascimento").Value)
            txtEmail.Text = row.Cells("Email").Value.ToString()
            txtTelefone.Text = row.Cells("Telefone").Value.ToString()
            If row.Cells.Contains("CursoID") AndAlso Not IsDBNull(row.Cells("CursoID").Value) Then
                cboCursos.SelectedValue = CInt(row.Cells("CursoID").Value)
            Else
                cboCursos.SelectedIndex = -1
            End If
            btnAdicionar.Enabled = False
            btnAtualizar.Enabled = True
            btnExcluir.Enabled = True
        Else
            LimparCampos()
        End If
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub
End Class
