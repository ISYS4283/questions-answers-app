<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createQuestion
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
        Me.TBQuestions = New System.Windows.Forms.RichTextBox()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBQuestions
        '
        Me.TBQuestions.Location = New System.Drawing.Point(12, 12)
        Me.TBQuestions.Name = "TBQuestions"
        Me.TBQuestions.Size = New System.Drawing.Size(780, 300)
        Me.TBQuestions.TabIndex = 0
        Me.TBQuestions.Text = ""
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(12, 318)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(780, 175)
        Me.submitButton.TabIndex = 1
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'createQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 505)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.TBQuestions)
        Me.Name = "createQuestion"
        Me.Text = "createQuestion"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TBQuestions As RichTextBox
    Friend WithEvents submitButton As Button
End Class
