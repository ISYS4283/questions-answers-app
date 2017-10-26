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
        Me.tbQuestion = New System.Windows.Forms.TextBox()
        Me.BtnQuestionSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbQuestion
        '
        Me.tbQuestion.Location = New System.Drawing.Point(12, 12)
        Me.tbQuestion.Multiline = True
        Me.tbQuestion.Name = "tbQuestion"
        Me.tbQuestion.Size = New System.Drawing.Size(516, 199)
        Me.tbQuestion.TabIndex = 0
        '
        'BtnQuestionSubmit
        '
        Me.BtnQuestionSubmit.Location = New System.Drawing.Point(21, 217)
        Me.BtnQuestionSubmit.Name = "BtnQuestionSubmit"
        Me.BtnQuestionSubmit.Size = New System.Drawing.Size(491, 120)
        Me.BtnQuestionSubmit.TabIndex = 1
        Me.BtnQuestionSubmit.Text = "Submit"
        Me.BtnQuestionSubmit.UseVisualStyleBackColor = True
        '
        'CreateQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 360)
        Me.Controls.Add(Me.BtnQuestionSubmit)
        Me.Controls.Add(Me.tbQuestion)
        Me.Name = "CreateQuestion"
        Me.Text = "CreateQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbQuestion As TextBox
    Friend WithEvents BtnQuestionSubmit As Button
End Class
