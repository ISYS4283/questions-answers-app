<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteAnswer
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
        Me.tbDAid = New System.Windows.Forms.TextBox()
        Me.btnDeleteAnswerSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Answer ID No."
        '
        'tbDAid
        '
        Me.tbDAid.Location = New System.Drawing.Point(16, 57)
        Me.tbDAid.Name = "tbDAid"
        Me.tbDAid.Size = New System.Drawing.Size(100, 20)
        Me.tbDAid.TabIndex = 3
        '
        'btnDeleteAnswerSubmit
        '
        Me.btnDeleteAnswerSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAnswerSubmit.Location = New System.Drawing.Point(16, 97)
        Me.btnDeleteAnswerSubmit.Name = "btnDeleteAnswerSubmit"
        Me.btnDeleteAnswerSubmit.Size = New System.Drawing.Size(132, 38)
        Me.btnDeleteAnswerSubmit.TabIndex = 5
        Me.btnDeleteAnswerSubmit.Text = "Submit"
        Me.btnDeleteAnswerSubmit.UseVisualStyleBackColor = True
        '
        'DeleteAnswer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(175, 157)
        Me.Controls.Add(Me.btnDeleteAnswerSubmit)
        Me.Controls.Add(Me.tbDAid)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DeleteAnswer"
        Me.Text = "DeleteAnswer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbDAid As TextBox
    Friend WithEvents btnDeleteAnswerSubmit As Button
End Class
