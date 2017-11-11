<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateAnswers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbUpdateAnswer = New System.Windows.Forms.TextBox()
        Me.btnAnswerSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbUpdateAnswer
        '
        Me.tbUpdateAnswer.Location = New System.Drawing.Point(12, 20)
        Me.tbUpdateAnswer.Multiline = True
        Me.tbUpdateAnswer.Name = "tbUpdateAnswer"
        Me.tbUpdateAnswer.Size = New System.Drawing.Size(689, 328)
        Me.tbUpdateAnswer.TabIndex = 2
        '
        'btnAnswerSubmit
        '
        Me.btnAnswerSubmit.Location = New System.Drawing.Point(316, 389)
        Me.btnAnswerSubmit.Name = "btnAnswerSubmit"
        Me.btnAnswerSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnAnswerSubmit.TabIndex = 3
        Me.btnAnswerSubmit.Text = "Submit"
        Me.btnAnswerSubmit.UseVisualStyleBackColor = True
        '
        'UpdateAnswers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 463)
        Me.Controls.Add(Me.btnAnswerSubmit)
        Me.Controls.Add(Me.tbUpdateAnswer)
        Me.Name = "UpdateAnswers"
        Me.Text = "UpdateAnswers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbUpdateAnswer As TextBox
    Friend WithEvents btnAnswerSubmit As Button
End Class
