Imports System.Configuration
Imports System.Data.SqlClient

Public Class CursoForm
    Private connectionString As String = ConfigurationManager.ConnectionStrings("FormacaoDB").ConnectionString
    Private carregando As Boolean = False

    Private Sub CursoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarCursos()
        LimparCampos()
    End Sub

    Private Sub CarregarCursos()
        carregando = True
        Using conn As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter("SELECT CursoID, Nome, CargaHoraria, Area, DataInicio, DataFim FROM Cursos", conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvCursos.DataSource = table
        End Using
        If dgvCursos.Columns.Contains("CursoID") Then
            dgvCursos.Columns("CursoID").Visible = False
        End If
        dgvCursos.ClearSelection()
        carregando = False
    End Sub

    Private Sub LimparCampos()
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
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("INSERT INTO Cursos (Nome, CargaHoraria, Area, DataInicio, DataFim) VALUES (@Nome, @CargaHoraria, @Area, @DataInicio, @DataFim)", conn)
            cmd.Parameters.AddWithValue("@Nome", txtNome.Text)
            cmd.Parameters.AddWithValue("@CargaHoraria", txtCargaHoraria.Text)
            cmd.Parameters.AddWithValue("@Area", txtArea.Text)
            cmd.Parameters.AddWithValue("@DataInicio", dtpDataInicio.Value.Date)
            cmd.Parameters.AddWithValue("@DataFim", dtpDataFim.Value.Date)
            conn.Open()
            cmd.ExecuteNonQuery()
        End Using
        CarregarCursos()
        LimparCampos()
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        If dgvCursos.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(dgvCursos.SelectedRows(0).Cells("CursoID").Value)
            Using conn As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("UPDATE Cursos SET Nome=@Nome, CargaHoraria=@CargaHoraria, Area=@Area, DataInicio=@DataInicio, DataFim=@DataFim WHERE CursoID=@ID", conn)
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@CargaHoraria", txtCargaHoraria.Text)
                cmd.Parameters.AddWithValue("@Area", txtArea.Text)
                cmd.Parameters.AddWithValue("@DataInicio", dtpDataInicio.Value.Date)
                cmd.Parameters.AddWithValue("@DataFim", dtpDataFim.Value.Date)
                cmd.Parameters.AddWithValue("@ID", id)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            CarregarCursos()
            LimparCampos()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If dgvCursos.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(dgvCursos.SelectedRows(0).Cells("CursoID").Value)
            Using conn As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("DELETE FROM Cursos WHERE CursoID=@ID", conn)
                cmd.Parameters.AddWithValue("@ID", id)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            CarregarCursos()
            LimparCampos()
        End If
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        LimparCampos()
        btnAdicionar.Enabled = True
    End Sub

    Private Sub dgvCursos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCursos.SelectionChanged
        If carregando Then
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
            LimparCampos()
        End If
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub
End Class
