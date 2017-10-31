<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateQuestion
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
        Me.updateButton = New System.Windows.Forms.Button()
        Me.TBUpdateQuestion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'updateButton
        '
        Me.updateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateButton.Location = New System.Drawing.Point(12, 310)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(612, 192)
        Me.updateButton.TabIndex = 1
        Me.updateButton.Text = "Submit Update"
        Me.updateButton.UseVisualStyleBackColor = True
        '
        'TBUpdateQuestion
        '
        Me.TBUpdateQuestion.Location = New System.Drawing.Point(12, 12)
        Me.TBUpdateQuestion.Multiline = True
        Me.TBUpdateQuestion.Name = "TBUpdateQuestion"
        Me.TBUpdateQuestion.Size = New System.Drawing.Size(612, 292)
        Me.TBUpdateQuestion.TabIndex = 2
        '
        'updateQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 514)
        Me.Controls.Add(Me.TBUpdateQuestion)
        Me.Controls.Add(Me.updateButton)
        Me.Name = "updateQuestion"
        Me.Text = "updateQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents updateButton As Button
    Friend WithEvents TBUpdateQuestion As TextBox
End Class
