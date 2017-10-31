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
        Me.btnUpdateQuestion = New System.Windows.Forms.Button()
        Me.tbUpdateQuestion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnUpdateQuestion
        '
        Me.btnUpdateQuestion.Location = New System.Drawing.Point(251, 389)
        Me.btnUpdateQuestion.Name = "btnUpdateQuestion"
        Me.btnUpdateQuestion.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateQuestion.TabIndex = 0
        Me.btnUpdateQuestion.Text = "Submit"
        Me.btnUpdateQuestion.UseVisualStyleBackColor = True
        '
        'tbUpdateQuestion
        '
        Me.tbUpdateQuestion.Location = New System.Drawing.Point(169, 207)
        Me.tbUpdateQuestion.Multiline = True
        Me.tbUpdateQuestion.Name = "tbUpdateQuestion"
        Me.tbUpdateQuestion.Size = New System.Drawing.Size(264, 20)
        Me.tbUpdateQuestion.TabIndex = 1
        '
        'UpdateQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 571)
        Me.Controls.Add(Me.tbUpdateQuestion)
        Me.Controls.Add(Me.btnUpdateQuestion)
        Me.Name = "UpdateQuestion"
        Me.Text = "UpdateQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdateQuestion As Button
    Friend WithEvents tbUpdateQuestion As TextBox
End Class
