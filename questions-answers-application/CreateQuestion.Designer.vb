<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateQuestion
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
        Me.btnQuestionSubmit = New System.Windows.Forms.Button()
        Me.tbQuestion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnQuestionSubmit
        '
        Me.btnQuestionSubmit.Location = New System.Drawing.Point(187, 249)
        Me.btnQuestionSubmit.Name = "btnQuestionSubmit"
        Me.btnQuestionSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuestionSubmit.TabIndex = 0
        Me.btnQuestionSubmit.Text = "Submit"
        Me.btnQuestionSubmit.UseVisualStyleBackColor = True
        '
        'tbQuestion
        '
        Me.tbQuestion.Location = New System.Drawing.Point(92, 118)
        Me.tbQuestion.Name = "tbQuestion"
        Me.tbQuestion.Size = New System.Drawing.Size(297, 20)
        Me.tbQuestion.TabIndex = 1
        '
        'CreateQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 384)
        Me.Controls.Add(Me.tbQuestion)
        Me.Controls.Add(Me.btnQuestionSubmit)
        Me.Name = "CreateQuestion"
        Me.Text = "CreateQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuestionSubmit As Button
    Friend WithEvents tbQuestion As TextBox
End Class
