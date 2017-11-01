<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question
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
        Me.BTNSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBQuestion
        '
        Me.TBQuestion.Location = New System.Drawing.Point(68, 44)
        Me.TBQuestion.Name = "TBQuestion"
        Me.TBQuestion.Size = New System.Drawing.Size(582, 328)
        Me.TBQuestion.TabIndex = 1
        Me.TBQuestion.Text = ""
        '
        'BTNSubmit
        '
        Me.BTNSubmit.Location = New System.Drawing.Point(316, 403)
        Me.BTNSubmit.Name = "BTNSubmit"
        Me.BTNSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BTNSubmit.TabIndex = 2
        Me.BTNSubmit.Text = "Submit"
        Me.BTNSubmit.UseVisualStyleBackColor = True
        '
        'Question
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 483)
        Me.Controls.Add(Me.BTNSubmit)
        Me.Controls.Add(Me.TBQuestion)
        Me.Name = "Question"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TBQuestion As RichTextBox
    Friend WithEvents BTNSubmit As Button
End Class
