Public Class Form1

    Private Sub btnAlunos_Click(sender As Object, e As EventArgs) Handles btnAlunos.Click
        Dim f As New AlunoForm()
        f.Show()
    End Sub

    Private Sub btnCursos_Click(sender As Object, e As EventArgs) Handles btnCursos.Click
        Dim f As New CursoForm()
        f.Show()
    End Sub

End Class
