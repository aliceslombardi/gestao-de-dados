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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(250, 175)
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

End Class
