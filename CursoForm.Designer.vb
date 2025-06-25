<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CursoForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvCursos = New System.Windows.Forms.DataGridView()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.dtpDataInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataFim = New System.Windows.Forms.DateTimePicker()
        Me.txtCargaHoraria = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.lblDataFim = New System.Windows.Forms.Label()
        Me.lblCargaHoraria = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCursos
        '
        Me.dgvCursos.AllowUserToAddRows = False
        Me.dgvCursos.AllowUserToDeleteRows = False
        Me.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCursos.Location = New System.Drawing.Point(12, 176)
        Me.dgvCursos.MultiSelect = False
        Me.dgvCursos.Name = "dgvCursos"
        Me.dgvCursos.ReadOnly = True
        Me.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCursos.Size = New System.Drawing.Size(560, 200)
        Me.dgvCursos.TabIndex = 0
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(118, 38)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(200, 20)
        Me.txtNome.TabIndex = 2
        '
        'dtpDataInicio
        '
        Me.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicio.Location = New System.Drawing.Point(118, 64)
        Me.dtpDataInicio.Name = "dtpDataInicio"
        Me.dtpDataInicio.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataInicio.TabIndex = 3
        '
        'txtCargaHoraria
        '
        Me.txtCargaHoraria.Location = New System.Drawing.Point(118, 90)
        Me.txtCargaHoraria.Name = "txtCargaHoraria"
        Me.txtCargaHoraria.Size = New System.Drawing.Size(200, 20)
        Me.txtCargaHoraria.TabIndex = 4
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(118, 116)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(200, 20)
        Me.txtArea.TabIndex = 5
        '
'dtpDataFim
        Me.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFim.Location = New System.Drawing.Point(118, 142)
        Me.dtpDataFim.Name = "dtpDataFim"
        Me.dtpDataFim.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataFim.TabIndex = 6
        '
        'lblDataFim
        Me.lblDataFim.AutoSize = True
        Me.lblDataFim.Location = New System.Drawing.Point(12, 145)
        Me.lblDataFim.Name = "lblDataFim"
        Me.lblDataFim.Size = New System.Drawing.Size(55, 13)
        Me.lblDataFim.TabIndex = 11
        Me.lblDataFim.Text = "Data Fim"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(12, 41)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(64, 13)
        Me.lblNome.TabIndex = 7
        Me.lblNome.Text = "Nome"
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.Location = New System.Drawing.Point(12, 67)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(91, 13)
        Me.lblDataInicio.TabIndex = 8
        Me.lblDataInicio.Text = "Data Início"
        '
        'lblCargaHoraria
        '
        Me.lblCargaHoraria.AutoSize = True
        Me.lblCargaHoraria.Location = New System.Drawing.Point(12, 93)
        Me.lblCargaHoraria.Name = "lblCargaHoraria"
        Me.lblCargaHoraria.Size = New System.Drawing.Size(32, 13)
        Me.lblCargaHoraria.TabIndex = 9
        Me.lblCargaHoraria.Text = "Carga Horária"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(12, 119)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(49, 13)
        Me.lblArea.TabIndex = 10
        Me.lblArea.Text = "Área"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(340, 38)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionar.TabIndex = 12
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(340, 64)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnAtualizar.TabIndex = 13
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(340, 90)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 14
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True

        'btnNovo
        Me.btnNovo.Location = New System.Drawing.Point(340, 116)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNovo.TabIndex = 15
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'CursoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 379)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.lblDataFim)
        Me.Controls.Add(Me.lblCargaHoraria)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblDataInicio)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.dtpDataFim)
        Me.Controls.Add(Me.txtCargaHoraria)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.dtpDataInicio)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.dgvCursos)
        Me.Name = "CursoForm"
        Me.Text = "Cursos"
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCursos As DataGridView
    Friend WithEvents txtNome As TextBox
    Friend WithEvents dtpDataFim As DateTimePicker
    Friend WithEvents lblDataFim As Label
    Friend WithEvents dtpDataInicio As DateTimePicker
    Friend WithEvents txtCargaHoraria As TextBox
    Friend WithEvents txtArea As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents lblDataInicio As Label
    Friend WithEvents lblCargaHoraria As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnNovo As Button
End Class
