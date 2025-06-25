<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlunoForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvAlunos = New System.Windows.Forms.DataGridView()
        Me.txtNomeAluno = New System.Windows.Forms.TextBox()
        Me.dtpDataNascimento = New System.Windows.Forms.DateTimePicker()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.cboCursos = New System.Windows.Forms.ComboBox()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.lblNomeAluno = New System.Windows.Forms.Label()
        Me.lblDataNascimento = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        CType(Me.dgvAlunos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAlunos
        '
        Me.dgvAlunos.AllowUserToAddRows = False
        Me.dgvAlunos.AllowUserToDeleteRows = False
        Me.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlunos.Location = New System.Drawing.Point(12, 176)
        Me.dgvAlunos.MultiSelect = False
        Me.dgvAlunos.Name = "dgvAlunos"
        Me.dgvAlunos.ReadOnly = True
        Me.dgvAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlunos.Size = New System.Drawing.Size(560, 200)
        Me.dgvAlunos.TabIndex = 0
        '
        'txtNomeAluno
        '
        Me.txtNomeAluno.Location = New System.Drawing.Point(118, 38)
        Me.txtNomeAluno.Name = "txtNomeAluno"
        Me.txtNomeAluno.Size = New System.Drawing.Size(200, 20)
        Me.txtNomeAluno.TabIndex = 2
        '
        'dtpDataNascimento
        '
        Me.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataNascimento.Location = New System.Drawing.Point(118, 64)
        Me.dtpDataNascimento.Name = "dtpDataNascimento"
        Me.dtpDataNascimento.Size = New System.Drawing.Size(100, 20)
        Me.dtpDataNascimento.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(118, 90)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 20)
        Me.txtEmail.TabIndex = 4
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(118, 116)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(200, 20)
        Me.txtTelefone.TabIndex = 5

        'cboCursos
        '
        Me.cboCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCursos.FormattingEnabled = True
        Me.cboCursos.Location = New System.Drawing.Point(118, 142)
        Me.cboCursos.Name = "cboCursos"
        Me.cboCursos.Size = New System.Drawing.Size(200, 21)
        Me.cboCursos.TabIndex = 6

        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Location = New System.Drawing.Point(12, 145)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(34, 13)
        Me.lblCurso.TabIndex = 15
        Me.lblCurso.Text = "Curso"
        '
        'lblNomeAluno
        '
        Me.lblNomeAluno.AutoSize = True
        Me.lblNomeAluno.Location = New System.Drawing.Point(12, 41)
        Me.lblNomeAluno.Name = "lblNomeAluno"
        Me.lblNomeAluno.Size = New System.Drawing.Size(64, 13)
        Me.lblNomeAluno.TabIndex = 7
        Me.lblNomeAluno.Text = "NomeAluno"
        '
        'lblDataNascimento
        '
        Me.lblDataNascimento.AutoSize = True
        Me.lblDataNascimento.Location = New System.Drawing.Point(12, 67)
        Me.lblDataNascimento.Name = "lblDataNascimento"
        Me.lblDataNascimento.Size = New System.Drawing.Size(91, 13)
        Me.lblDataNascimento.TabIndex = 8
        Me.lblDataNascimento.Text = "Data Nascimento"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(12, 93)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(12, 119)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefone.TabIndex = 10
        Me.lblTelefone.Text = "Telefone"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(340, 38)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionar.TabIndex = 11
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(340, 64)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnAtualizar.TabIndex = 12
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(340, 90)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 13
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True

        'btnNovo
        Me.btnNovo.Location = New System.Drawing.Point(340, 116)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNovo.TabIndex = 14
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnVoltar
        '
        Me.btnVoltar.Location = New System.Drawing.Point(12, 386)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.btnVoltar.TabIndex = 15
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'AlunoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 415)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblTelefone)
        Me.Controls.Add(Me.lblDataNascimento)
        Me.Controls.Add(Me.lblNomeAluno)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.cboCursos)
        Me.Controls.Add(Me.lblCurso)
        Me.Controls.Add(Me.dtpDataNascimento)
        Me.Controls.Add(Me.txtNomeAluno)
        Me.Controls.Add(Me.dgvAlunos)
        Me.Name = "AlunoForm"
        Me.Text = "Alunos"
        CType(Me.dgvAlunos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAlunos As DataGridView
    Friend WithEvents txtNomeAluno As TextBox
    Friend WithEvents dtpDataNascimento As DateTimePicker
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents cboCursos As ComboBox
    Friend WithEvents lblCurso As Label
    Friend WithEvents lblNomeAluno As Label
    Friend WithEvents lblDataNascimento As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTelefone As Label
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnVoltar As Button
End Class
