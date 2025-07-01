Imports System.Configuration
Imports System.Data.SqlClient

Public Class CursoForm
    Private cs As String = ConfigurationManager.ConnectionStrings("FormacaoDB").ConnectionString
    Private car As Boolean = False

    Private Sub CursoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCs()
        Clean()
    End Sub

    Private Sub LoadCs()
        car = True
        Using c As New SqlConnection(cs)
            Dim da As New SqlDataAdapter("SELECT CursoID, Nome, CargaHoraria, Area, DataInicio, DataFim FROM Cursos", c)
            Dim t As New DataTable()
            da.Fill(t)
            dgvCursos.DataSource = t
        End Using
        If dgvCursos.Columns.Contains("CursoID") Then
            dgvCursos.Columns("CursoID").Visible = False
        End If
        dgvCursos.ClearSelection()
        car = False
    End Sub

    Private Sub Clean()
        txtNome.Clear()
        txtCargaHoraria.Clear()
        txtArea.Clear()
        dtpDataInicio.Value = Date.Today
        dtpDataFim.Value = Date.Today
        btnAdicionar.Enabled = False
        btnAtualizar.Enabled = False
        btnExcluir.Enabled = False
        dgvCursos.ClearSelection()
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Using c As New SqlConnection(cs)
            Dim cmd As New SqlCommand("INSERT INTO Cursos (Nome, CargaHoraria, Area, DataInicio, DataFim) VALUES (@Nome, @CargaHoraria, @Area, @DataInicio, @DataFim)", c)
            cmd.Parameters.AddWithValue("@Nome", txtNome.Text)
            cmd.Parameters.AddWithValue("@CargaHoraria", txtCargaHoraria.Text)
            cmd.Parameters.AddWithValue("@Area", txtArea.Text)
            cmd.Parameters.AddWithValue("@DataInicio", dtpDataInicio.Value.Date)
            cmd.Parameters.AddWithValue("@DataFim", dtpDataFim.Value.Date)
            c.Open()
            cmd.ExecuteNonQuery()
        End Using
        LoadCs()
        Clean()
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        If dgvCursos.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(dgvCursos.SelectedRows(0).Cells("CursoID").Value)
            Using c As New SqlConnection(cs)
                Dim cmd As New SqlCommand("UPDATE Cursos SET Nome=@Nome, CargaHoraria=@CargaHoraria, Area=@Area, DataInicio=@DataInicio, DataFim=@DataFim WHERE CursoID=@ID", c)
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@CargaHoraria", txtCargaHoraria.Text)
                cmd.Parameters.AddWithValue("@Area", txtArea.Text)
                cmd.Parameters.AddWithValue("@DataInicio", dtpDataInicio.Value.Date)
                cmd.Parameters.AddWithValue("@DataFim", dtpDataFim.Value.Date)
                cmd.Parameters.AddWithValue("@ID", id)
                c.Open()
                cmd.ExecuteNonQuery()
            End Using
            LoadCs()
            Clean()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If dgvCursos.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(dgvCursos.SelectedRows(0).Cells("CursoID").Value)
            Try
                Using c As New SqlConnection(cs)
                    c.Open()
                    Dim delIns As New SqlCommand("DELETE FROM Inscricoes WHERE CursoID=@ID", c)
                    delIns.Parameters.AddWithValue("@ID", id)
                    delIns.ExecuteNonQuery()

                    Dim cmd As New SqlCommand("DELETE FROM Cursos WHERE CursoID=@ID", c)
                    cmd.Parameters.AddWithValue("@ID", id)
                    cmd.ExecuteNonQuery()
                End Using
                LoadCs()
                Clean()
            Catch ex As Exception
                MessageBox.Show("Erro ao excluir curso: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Clean()
        btnAdicionar.Enabled = True
    End Sub

    Private Sub dgvCursos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCursos.SelectionChanged
        If car Then
            Return
        End If

        If dgvCursos.SelectedRows.Count > 0 Then
            Dim row = dgvCursos.SelectedRows(0)
            txtNome.Text = row.Cells("Nome").Value.ToString()
            dtpDataInicio.Value = CDate(row.Cells("DataInicio").Value)
            dtpDataFim.Value = CDate(row.Cells("DataFim").Value)
            txtCargaHoraria.Text = row.Cells("CargaHoraria").Value.ToString()
            txtArea.Text = row.Cells("Area").Value.ToString()
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
