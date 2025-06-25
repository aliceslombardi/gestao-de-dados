Public Class AlunoForm
    Private alunosTable As New DataTable()
    Private nextId As Integer = 1

    Private Sub AlunoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Definindo colunas da tabela em memória
        With alunosTable.Columns
            .Add("IDFormando", GetType(Integer))
            .Add("NomeAluno", GetType(String))
            .Add("DataNascimento", GetType(Date))
            .Add("Email", GetType(String))
            Dim colCurso = .Add("IDCurso", GetType(Integer))
            colCurso.DefaultValue = 0
        End With

        dgvAlunos.DataSource = alunosTable
        dgvAlunos.Columns("IDFormando").Visible = False
        dgvAlunos.Columns("IDCurso").Visible = False
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        alunosTable.Rows.Add(
            nextId,
            txtNomeAluno.Text,
            dtpDataNascimento.Value,
            txtEmail.Text,
            0)
        nextId += 1
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        If dgvAlunos.SelectedRows.Count > 0 Then
            Dim row = dgvAlunos.SelectedRows(0)
            row.Cells("NomeAluno").Value = txtNomeAluno.Text
            row.Cells("DataNascimento").Value = dtpDataNascimento.Value
            row.Cells("Email").Value = txtEmail.Text
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If dgvAlunos.SelectedRows.Count > 0 Then
            dgvAlunos.Rows.Remove(dgvAlunos.SelectedRows(0))
        End If
    End Sub

    Private Sub dgvAlunos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAlunos.SelectionChanged
        If dgvAlunos.SelectedRows.Count > 0 Then
            Dim row = dgvAlunos.SelectedRows(0)
            txtNomeAluno.Text = row.Cells("NomeAluno").Value.ToString()
            dtpDataNascimento.Value = CDate(row.Cells("DataNascimento").Value)
            txtEmail.Text = row.Cells("Email").Value.ToString()
        End If
    End Sub
End Class
