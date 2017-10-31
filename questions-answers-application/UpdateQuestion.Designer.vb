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
        Me.btnUpdateQuestion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbUpdateQuestion
        '
        Me.tbUpdateQuestion.Location = New System.Drawing.Point(12, 13)
        Me.tbUpdateQuestion.Multiline = True
        Me.tbUpdateQuestion.Name = "tbUpdateQuestion"
        Me.tbUpdateQuestion.Size = New System.Drawing.Size(244, 124)
        Me.tbUpdateQuestion.TabIndex = 0
        '
        'btnUpdateQuestion
        '
        Me.btnUpdateQuestion.Location = New System.Drawing.Point(91, 209)
        Me.btnUpdateQuestion.Name = "btnUpdateQuestion"
        Me.btnUpdateQuestion.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateQuestion.TabIndex = 1
        Me.btnUpdateQuestion.Text = "Submit"
        Me.btnUpdateQuestion.UseVisualStyleBackColor = True
        '
        'UpdateQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnUpdateQuestion)
        Me.Controls.Add(Me.tbUpdateQuestion)
        Me.Name = "UpdateQuestion"
        Me.Text = "UpdateQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbUpdateQuestion As TextBox
    Friend WithEvents btnUpdateQuestion As Button
End Class
