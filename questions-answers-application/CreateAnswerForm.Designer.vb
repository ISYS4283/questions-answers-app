<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAnswerForm
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
        Me.SubmitAnswerButton = New System.Windows.Forms.Button()
        Me.tbCreateAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'SubmitAnswerButton
        '
        Me.SubmitAnswerButton.Location = New System.Drawing.Point(12, 286)
        Me.SubmitAnswerButton.Name = "SubmitAnswerButton"
        Me.SubmitAnswerButton.Size = New System.Drawing.Size(595, 143)
        Me.SubmitAnswerButton.TabIndex = 2
        Me.SubmitAnswerButton.Text = "Submit"
        Me.SubmitAnswerButton.UseVisualStyleBackColor = True
        '
        'tbCreateAnswerTextBox
        '
        Me.tbCreateAnswerTextBox.Location = New System.Drawing.Point(12, 28)
        Me.tbCreateAnswerTextBox.Multiline = True
        Me.tbCreateAnswerTextBox.Name = "tbCreateAnswerTextBox"
        Me.tbCreateAnswerTextBox.Size = New System.Drawing.Size(595, 221)
        Me.tbCreateAnswerTextBox.TabIndex = 3
        '
        'CreateAnswerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 441)
        Me.Controls.Add(Me.tbCreateAnswerTextBox)
        Me.Controls.Add(Me.SubmitAnswerButton)
        Me.Name = "CreateAnswerForm"
        Me.Text = "CreateAnswerForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SubmitAnswerButton As Button
    Friend WithEvents tbCreateAnswerTextBox As TextBox
End Class
