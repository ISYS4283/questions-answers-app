<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateQuestion
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
        Me.tbUpdateQuestion = New System.Windows.Forms.TextBox()
        Me.BtnUpdateQuestions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbUpdateQuestion
        '
        Me.tbUpdateQuestion.Location = New System.Drawing.Point(24, 24)
        Me.tbUpdateQuestion.Multiline = True
        Me.tbUpdateQuestion.Name = "tbUpdateQuestion"
        Me.tbUpdateQuestion.Size = New System.Drawing.Size(235, 123)
        Me.tbUpdateQuestion.TabIndex = 0
        '
        'BtnUpdateQuestions
        '
        Me.BtnUpdateQuestions.Location = New System.Drawing.Point(24, 186)
        Me.BtnUpdateQuestions.Name = "BtnUpdateQuestions"
        Me.BtnUpdateQuestions.Size = New System.Drawing.Size(235, 23)
        Me.BtnUpdateQuestions.TabIndex = 1
        Me.BtnUpdateQuestions.Text = "Update Questions"
        Me.BtnUpdateQuestions.UseVisualStyleBackColor = True
        '
        'UpdateQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BtnUpdateQuestions)
        Me.Controls.Add(Me.tbUpdateQuestion)
        Me.Name = "UpdateQuestion"
        Me.Text = "UpdateQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbUpdateQuestion As TextBox
    Friend WithEvents BtnUpdateQuestions As Button
End Class
