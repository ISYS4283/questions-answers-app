<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateAnswer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbAid = New System.Windows.Forms.TextBox()
        Me.tbUpdateAnswer = New System.Windows.Forms.TextBox()
        Me.btnUpdateAnswerSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Answer ID No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Answer"
        '
        'tbAid
        '
        Me.tbAid.Location = New System.Drawing.Point(16, 51)
        Me.tbAid.Name = "tbAid"
        Me.tbAid.Size = New System.Drawing.Size(100, 20)
        Me.tbAid.TabIndex = 2
        '
        'tbUpdateAnswer
        '
        Me.tbUpdateAnswer.Location = New System.Drawing.Point(12, 115)
        Me.tbUpdateAnswer.Multiline = True
        Me.tbUpdateAnswer.Name = "tbUpdateAnswer"
        Me.tbUpdateAnswer.Size = New System.Drawing.Size(522, 85)
        Me.tbUpdateAnswer.TabIndex = 3
        '
        'btnUpdateAnswerSubmit
        '
        Me.btnUpdateAnswerSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateAnswerSubmit.Location = New System.Drawing.Point(12, 210)
        Me.btnUpdateAnswerSubmit.Name = "btnUpdateAnswerSubmit"
        Me.btnUpdateAnswerSubmit.Size = New System.Drawing.Size(522, 107)
        Me.btnUpdateAnswerSubmit.TabIndex = 4
        Me.btnUpdateAnswerSubmit.Text = "Submit"
        Me.btnUpdateAnswerSubmit.UseVisualStyleBackColor = True
        '
        'UpdateAnswer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 336)
        Me.Controls.Add(Me.btnUpdateAnswerSubmit)
        Me.Controls.Add(Me.tbUpdateAnswer)
        Me.Controls.Add(Me.tbAid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateAnswer"
        Me.Text = "UpdateAnswer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbAid As TextBox
    Friend WithEvents tbUpdateAnswer As TextBox
    Friend WithEvents btnUpdateAnswerSubmit As Button
End Class
