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
        Me.lblTitulo.AutoSize = False
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.lblTitulo.Size = New System.Drawing.Size(250, 45)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Gestão de Dados"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAlunos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAlunos.Location = New System.Drawing.Point(45, 60)
        Me.btnAlunos.Name = "btnAlunos"
        Me.btnAlunos.Size = New System.Drawing.Size(160, 40)
        Me.btnAlunos.TabIndex = 1
        Me.btnAlunos.Text = "Gerir Alunos"
        Me.btnAlunos.UseVisualStyleBackColor = True
        Me.btnCursos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCursos.Location = New System.Drawing.Point(45, 110)
        Me.btnCursos.Name = "btnCursos"
        Me.btnCursos.Size = New System.Drawing.Size(160, 40)
        Me.btnCursos.TabIndex = 2
        Me.btnCursos.Text = "Gerir Cursos"
        Me.btnCursos.UseVisualStyleBackColor = True
        Me.lblVersao.AutoSize = True
        Me.lblVersao.Location = New System.Drawing.Point(10, 160)
        Me.lblVersao.Name = "lblVersao"
        Me.lblVersao.Size = New System.Drawing.Size(97, 13)
        Me.lblVersao.TabIndex = 3
        Me.lblVersao.Text = "Versão do Sistema"
        Me.lblAlice.AutoSize = True
        Me.lblAlice.Location = New System.Drawing.Point(10, 180)
        Me.lblAlice.Name = "lblAlice"
        Me.lblAlice.Size = New System.Drawing.Size(137, 13)
        Me.lblAlice.TabIndex = 4
        Me.lblAlice.Text = "alice lombardi - 8211802"
        Me.lblRafaela.AutoSize = True
        Me.lblRafaela.Location = New System.Drawing.Point(10, 200)
        Me.lblRafaela.Name = "lblRafaela"
        Me.lblRafaela.Size = New System.Drawing.Size(138, 13)
        Me.lblRafaela.TabIndex = 5
        Me.lblRafaela.Text = "Rafaela cancio - 7151625"
        Me.lblVissolela.AutoSize = True
        Me.lblVissolela.Location = New System.Drawing.Point(10, 220)
        Me.lblVissolela.Name = "lblVissolela"
        Me.lblVissolela.Size = New System.Drawing.Size(150, 13)
        Me.lblVissolela.TabIndex = 6
        Me.lblVissolela.Text = "VISSOLELA CUNDI - 7790644"
        Me.lblPalmira.AutoSize = True
        Me.lblPalmira.Location = New System.Drawing.Point(10, 240)
        Me.lblPalmira.Name = "lblPalmira"
        Me.lblPalmira.Size = New System.Drawing.Size(148, 13)
        Me.lblPalmira.TabIndex = 7
        Me.lblPalmira.Text = "PALMIRA SOLOchi - 7148400"
        Me.lblTurma.AutoSize = True
        Me.lblTurma.Location = New System.Drawing.Point(10, 260)
        Me.lblTurma.Name = "lblTurma"
        Me.lblTurma.Size = New System.Drawing.Size(89, 13)
        Me.lblTurma.TabIndex = 8
        Me.lblTurma.Text = "turma 25.0082"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(250, 290)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

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
