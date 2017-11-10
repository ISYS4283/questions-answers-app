<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnswerQuestion
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
        Me.tbAnswer = New System.Windows.Forms.TextBox()
        Me.btnAnswerSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbQid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbAnswer
        '
        Me.tbAnswer.Location = New System.Drawing.Point(12, 147)
        Me.tbAnswer.Multiline = True
        Me.tbAnswer.Name = "tbAnswer"
        Me.tbAnswer.Size = New System.Drawing.Size(522, 85)
        Me.tbAnswer.TabIndex = 1
        '
        'btnAnswerSubmit
        '
        Me.btnAnswerSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswerSubmit.Location = New System.Drawing.Point(-2, 249)
        Me.btnAnswerSubmit.Name = "btnAnswerSubmit"
        Me.btnAnswerSubmit.Size = New System.Drawing.Size(546, 107)
        Me.btnAnswerSubmit.TabIndex = 2
        Me.btnAnswerSubmit.Text = "Submit"
        Me.btnAnswerSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter QuestionID No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter Answer"
        '
        'tbQid
        '
        Me.tbQid.Location = New System.Drawing.Point(12, 53)
        Me.tbQid.Multiline = True
        Me.tbQid.Name = "tbQid"
        Me.tbQid.Size = New System.Drawing.Size(97, 26)
        Me.tbQid.TabIndex = 3
        '
        'AnswerQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 394)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbQid)
        Me.Controls.Add(Me.btnAnswerSubmit)
        Me.Controls.Add(Me.tbAnswer)
        Me.Name = "AnswerQuestion"
        Me.Text = "AnswerQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbAnswer As TextBox
    Friend WithEvents btnAnswerSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbQid As TextBox
End Class
