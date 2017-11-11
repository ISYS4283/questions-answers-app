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
        Me.ShowQuestionTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SubmitAnswerButton
        '
        Me.SubmitAnswerButton.Location = New System.Drawing.Point(12, 334)
        Me.SubmitAnswerButton.Name = "SubmitAnswerButton"
        Me.SubmitAnswerButton.Size = New System.Drawing.Size(595, 95)
        Me.SubmitAnswerButton.TabIndex = 2
        Me.SubmitAnswerButton.Text = "Submit"
        Me.SubmitAnswerButton.UseVisualStyleBackColor = True
        '
        'tbCreateAnswerTextBox
        '
        Me.tbCreateAnswerTextBox.Location = New System.Drawing.Point(12, 151)
        Me.tbCreateAnswerTextBox.Multiline = True
        Me.tbCreateAnswerTextBox.Name = "tbCreateAnswerTextBox"
        Me.tbCreateAnswerTextBox.Size = New System.Drawing.Size(595, 177)
        Me.tbCreateAnswerTextBox.TabIndex = 3
        '
        'ShowQuestionTextBox
        '
        Me.ShowQuestionTextBox.Location = New System.Drawing.Point(12, 49)
        Me.ShowQuestionTextBox.Multiline = True
        Me.ShowQuestionTextBox.Name = "ShowQuestionTextBox"
        Me.ShowQuestionTextBox.ReadOnly = True
        Me.ShowQuestionTextBox.Size = New System.Drawing.Size(595, 45)
        Me.ShowQuestionTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Question:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Type your answer here:"
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(517, 5)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(90, 38)
        Me.CloseButton.TabIndex = 7
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'CreateAnswerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 441)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShowQuestionTextBox)
        Me.Controls.Add(Me.tbCreateAnswerTextBox)
        Me.Controls.Add(Me.SubmitAnswerButton)
        Me.Name = "CreateAnswerForm"
        Me.Text = "Create Answer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SubmitAnswerButton As Button
    Friend WithEvents tbCreateAnswerTextBox As TextBox
    Friend WithEvents ShowQuestionTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CloseButton As Button
End Class
