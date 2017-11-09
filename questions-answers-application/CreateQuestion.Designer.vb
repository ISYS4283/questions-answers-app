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
        Me.btnQuestionSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbQuestion
        '
        Me.tbQuestion.Location = New System.Drawing.Point(18, 18)
        Me.tbQuestion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbQuestion.Multiline = True
        Me.tbQuestion.Name = "tbQuestion"
        Me.tbQuestion.Size = New System.Drawing.Size(817, 318)
        Me.tbQuestion.TabIndex = 0
        '
        'btnQuestionSubmit
        '
        Me.btnQuestionSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuestionSubmit.Location = New System.Drawing.Point(18, 349)
        Me.btnQuestionSubmit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQuestionSubmit.Name = "btnQuestionSubmit"
        Me.btnQuestionSubmit.Size = New System.Drawing.Size(819, 165)
        Me.btnQuestionSubmit.TabIndex = 1
        Me.btnQuestionSubmit.Text = "Submit"
        Me.btnQuestionSubmit.UseVisualStyleBackColor = True
        '
        'CreateQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 529)
        Me.Controls.Add(Me.btnQuestionSubmit)
        Me.Controls.Add(Me.tbQuestion)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CreateQuestion"
        Me.Text = "CreateQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbQuestion As TextBox
    Friend WithEvents btnQuestionSubmit As Button
End Class
