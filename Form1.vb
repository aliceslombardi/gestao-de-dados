Public Class Form1

    Private Sub btnAlunos_Click(sender As Object, e As EventArgs) Handles btnAlunos.Click
        Dim form As New AlunoForm()
        form.Show()
    End Sub

    Private Sub btnCursos_Click(sender As Object, e As EventArgs) Handles btnCursos.Click
        Dim form As New CursoForm()
        form.Show()
    End Sub

End Class
