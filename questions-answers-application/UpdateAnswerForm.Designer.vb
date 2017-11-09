<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateAnswerForm
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
        Me.tbUpdateAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SubmitUpAnswerButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbUpdateAnswerTextBox
        '
        Me.tbUpdateAnswerTextBox.Location = New System.Drawing.Point(4, 0)
        Me.tbUpdateAnswerTextBox.Multiline = True
        Me.tbUpdateAnswerTextBox.Name = "tbUpdateAnswerTextBox"
        Me.tbUpdateAnswerTextBox.Size = New System.Drawing.Size(874, 271)
        Me.tbUpdateAnswerTextBox.TabIndex = 5
        '
        'SubmitUpAnswerButton
        '
        Me.SubmitUpAnswerButton.Location = New System.Drawing.Point(93, 305)
        Me.SubmitUpAnswerButton.Name = "SubmitUpAnswerButton"
        Me.SubmitUpAnswerButton.Size = New System.Drawing.Size(664, 141)
        Me.SubmitUpAnswerButton.TabIndex = 4
        Me.SubmitUpAnswerButton.Text = "Submit"
        Me.SubmitUpAnswerButton.UseVisualStyleBackColor = True
        '
        'UpdateAnswerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 546)
        Me.Controls.Add(Me.tbUpdateAnswerTextBox)
        Me.Controls.Add(Me.SubmitUpAnswerButton)
        Me.Name = "UpdateAnswerForm"
        Me.Text = "UpdateAnswerForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbUpdateAnswerTextBox As TextBox
    Friend WithEvents SubmitUpAnswerButton As Button
End Class
