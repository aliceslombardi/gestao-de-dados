Public Class AlunoForm
    Private alunosTable As New DataTable()

    Private Sub AlunoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Definindo colunas da tabela em memória
        With alunosTable.Columns
            .Add("IDFormando", GetType(Integer))
            .Add("NomeAluno", GetType(String))
            .Add("DataNascimento", GetType(Date))
            .Add("Email", GetType(String))
            .Add("IDCurso", GetType(Integer))
        End With

        dgvAlunos.DataSource = alunosTable
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        alunosTable.Rows.Add(
            CInt(txtIDFormando.Text),
            txtNomeAluno.Text,
            dtpDataNascimento.Value,
            txtEmail.Text,
            CInt(txtIDCurso.Text))
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        If dgvAlunos.SelectedRows.Count > 0 Then
            Dim row = dgvAlunos.SelectedRows(0)
            row.Cells("IDFormando").Value = CInt(txtIDFormando.Text)
            row.Cells("NomeAluno").Value = txtNomeAluno.Text
            row.Cells("DataNascimento").Value = dtpDataNascimento.Value
            row.Cells("Email").Value = txtEmail.Text
            row.Cells("IDCurso").Value = CInt(txtIDCurso.Text)
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
            txtIDFormando.Text = row.Cells("IDFormando").Value.ToString()
            txtNomeAluno.Text = row.Cells("NomeAluno").Value.ToString()
            dtpDataNascimento.Value = CDate(row.Cells("DataNascimento").Value)
            txtEmail.Text = row.Cells("Email").Value.ToString()
            txtIDCurso.Text = row.Cells("IDCurso").Value.ToString()
        End If
    End Sub
End Class
