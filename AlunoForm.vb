Imports System.Configuration
Imports System.Data.SqlClient

Public Class AlunoForm
    Private connectionString As String = ConfigurationManager.ConnectionStrings("FormacaoDB").ConnectionString

    Private Sub AlunoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarAlunos()
    End Sub

    Private Sub CarregarAlunos()
        Using conn As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter("SELECT FormandoID, Nome, Email, Telefone, DataNascimento FROM Formandos", conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvAlunos.DataSource = table
        End Using
        If dgvAlunos.Columns.Contains("FormandoID") Then
            dgvAlunos.Columns("FormandoID").Visible = False
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("INSERT INTO Formandos (Nome, Email, Telefone, DataNascimento) VALUES (@Nome, @Email, @Telefone, @DataNascimento)", conn)
            cmd.Parameters.AddWithValue("@Nome", txtNomeAluno.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text)
            cmd.Parameters.AddWithValue("@DataNascimento", dtpDataNascimento.Value.Date)
            conn.Open()
            cmd.ExecuteNonQuery()
        End Using
        CarregarAlunos()
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        If dgvAlunos.SelectedRows.Count > 0 Then
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
            End Using
            CarregarAlunos()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If dgvAlunos.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(dgvAlunos.SelectedRows(0).Cells("FormandoID").Value)
            Using conn As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("DELETE FROM Formandos WHERE FormandoID=@ID", conn)
                cmd.Parameters.AddWithValue("@ID", id)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            CarregarAlunos()
        End If
    End Sub

    Private Sub dgvAlunos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAlunos.SelectionChanged
        If dgvAlunos.SelectedRows.Count > 0 Then
            Dim row = dgvAlunos.SelectedRows(0)
            txtNomeAluno.Text = row.Cells("Nome").Value.ToString()
            dtpDataNascimento.Value = CDate(row.Cells("DataNascimento").Value)
            txtEmail.Text = row.Cells("Email").Value.ToString()
            txtTelefone.Text = row.Cells("Telefone").Value.ToString()
        End If
    End Sub
End Class
