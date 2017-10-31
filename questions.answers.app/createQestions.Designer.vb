<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createQestions
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
        Me.TBQuestion = New System.Windows.Forms.RichTextBox()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBQuestion
        '
        Me.TBQuestion.Location = New System.Drawing.Point(12, 12)
        Me.TBQuestion.Name = "TBQuestion"
        Me.TBQuestion.Size = New System.Drawing.Size(811, 309)
        Me.TBQuestion.TabIndex = 1
        Me.TBQuestion.Text = ""
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(12, 327)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(545, 138)
        Me.submitButton.TabIndex = 2
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'createQestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 605)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.TBQuestion)
        Me.Name = "createQestions"
        Me.Text = "createQestions"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TBQuestion As RichTextBox
    Friend WithEvents submitButton As Button
End Class
