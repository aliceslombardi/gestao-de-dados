<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAlunos = New System.Windows.Forms.Button()
        Me.btnCursos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAlunos
        '
        Me.btnAlunos.Location = New System.Drawing.Point(12, 12)
        Me.btnAlunos.Name = "btnAlunos"
        Me.btnAlunos.Size = New System.Drawing.Size(120, 40)
        Me.btnAlunos.TabIndex = 0
        Me.btnAlunos.Text = "Gerir Alunos"
        Me.btnAlunos.UseVisualStyleBackColor = True
        '
        'btnCursos
        '
        Me.btnCursos.Location = New System.Drawing.Point(12, 58)
        Me.btnCursos.Name = "btnCursos"
        Me.btnCursos.Size = New System.Drawing.Size(120, 40)
        Me.btnCursos.TabIndex = 1
        Me.btnCursos.Text = "Gerir Cursos"
        Me.btnCursos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(148, 110)
        Me.Controls.Add(Me.btnCursos)
        Me.Controls.Add(Me.btnAlunos)
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAlunos As System.Windows.Forms.Button
    Friend WithEvents btnCursos As System.Windows.Forms.Button

End Class
