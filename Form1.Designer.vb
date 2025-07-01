<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer


    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnAlunos = New System.Windows.Forms.Button()
        Me.btnCursos = New System.Windows.Forms.Button()
        Me.lblVersao = New System.Windows.Forms.Label()
        Me.lblAlice = New System.Windows.Forms.Label()
        Me.lblRafaela = New System.Windows.Forms.Label()
        Me.lblVissolela = New System.Windows.Forms.Label()
        Me.lblPalmira = New System.Windows.Forms.Label()
        Me.lblTurma = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.lblTitulo.Size = New System.Drawing.Size(618, 55)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Gestão de Dados"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAlunos
        '
        Me.btnAlunos.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnAlunos.Location = New System.Drawing.Point(181, 120)
        Me.btnAlunos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAlunos.Name = "btnAlunos"
        Me.btnAlunos.Size = New System.Drawing.Size(213, 49)
        Me.btnAlunos.TabIndex = 1
        Me.btnAlunos.Text = "Gerir Alunos"
        Me.btnAlunos.UseVisualStyleBackColor = True
        '
        'btnCursos
        '
        Me.btnCursos.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCursos.Location = New System.Drawing.Point(181, 232)
        Me.btnCursos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCursos.Name = "btnCursos"
        Me.btnCursos.Size = New System.Drawing.Size(213, 49)
        Me.btnCursos.TabIndex = 2
        Me.btnCursos.Text = "Gerir Cursos"
        Me.btnCursos.UseVisualStyleBackColor = True
        '
        'lblVersao
        '
        Me.lblVersao.AutoSize = True
        Me.lblVersao.Location = New System.Drawing.Point(483, 437)
        Me.lblVersao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVersao.Name = "lblVersao"
        Me.lblVersao.Size = New System.Drawing.Size(122, 16)
        Me.lblVersao.TabIndex = 3
        Me.lblVersao.Text = "Versão do Sistema"
        '
        'lblAlice
        '
        Me.lblAlice.AutoSize = True
        Me.lblAlice.Location = New System.Drawing.Point(3, 351)
        Me.lblAlice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAlice.Name = "lblAlice"
        Me.lblAlice.Size = New System.Drawing.Size(156, 16)
        Me.lblAlice.TabIndex = 4
        Me.lblAlice.Text = "Alice Lombardi - 8211802"
        '
        'lblRafaela
        '
        Me.lblRafaela.AutoSize = True
        Me.lblRafaela.Location = New System.Drawing.Point(2, 410)
        Me.lblRafaela.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRafaela.Name = "lblRafaela"
        Me.lblRafaela.Size = New System.Drawing.Size(159, 16)
        Me.lblRafaela.TabIndex = 5
        Me.lblRafaela.Text = "Rafaela Cancio - 7151625"
        '
        'lblVissolela
        '
        Me.lblVissolela.AutoSize = True
        Me.lblVissolela.Location = New System.Drawing.Point(3, 437)
        Me.lblVissolela.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVissolela.Name = "lblVissolela"
        Me.lblVissolela.Size = New System.Drawing.Size(159, 16)
        Me.lblVissolela.TabIndex = 6
        Me.lblVissolela.Text = "Vissolela Cundi - 7790644"
        '
        'lblPalmira
        '
        Me.lblPalmira.AutoSize = True
        Me.lblPalmira.Location = New System.Drawing.Point(3, 383)
        Me.lblPalmira.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPalmira.Name = "lblPalmira"
        Me.lblPalmira.Size = New System.Drawing.Size(160, 16)
        Me.lblPalmira.TabIndex = 7
        Me.lblPalmira.Text = "Palmira Solochi - 7148400"
        '
        'lblTurma
        '
        Me.lblTurma.AutoSize = True
        Me.lblTurma.Location = New System.Drawing.Point(501, 453)
        Me.lblTurma.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTurma.Name = "lblTurma"
        Me.lblTurma.Size = New System.Drawing.Size(104, 16)
        Me.lblTurma.TabIndex = 8
        Me.lblTurma.Text = "TURMA 25.0082"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(618, 478)
        Me.Controls.Add(Me.lblTurma)
        Me.Controls.Add(Me.lblPalmira)
        Me.Controls.Add(Me.lblVissolela)
        Me.Controls.Add(Me.lblRafaela)
        Me.Controls.Add(Me.lblAlice)
        Me.Controls.Add(Me.lblVersao)
        Me.Controls.Add(Me.btnCursos)
        Me.Controls.Add(Me.btnAlunos)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAlunos As System.Windows.Forms.Button
    Friend WithEvents btnCursos As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblVersao As System.Windows.Forms.Label
    Friend WithEvents lblAlice As System.Windows.Forms.Label
    Friend WithEvents lblRafaela As System.Windows.Forms.Label
    Friend WithEvents lblVissolela As System.Windows.Forms.Label
    Friend WithEvents lblPalmira As System.Windows.Forms.Label
    Friend WithEvents lblTurma As System.Windows.Forms.Label

End Class
