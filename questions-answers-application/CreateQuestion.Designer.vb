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
        Me.tbCreateQuestion = New System.Windows.Forms.TextBox()
        Me.btnCreateQuetionSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbCreateQuestion
        '
        Me.tbCreateQuestion.Location = New System.Drawing.Point(13, 13)
        Me.tbCreateQuestion.Multiline = True
        Me.tbCreateQuestion.Name = "tbCreateQuestion"
        Me.tbCreateQuestion.Size = New System.Drawing.Size(622, 337)
        Me.tbCreateQuestion.TabIndex = 0
        '
        'btnCreateQuetionSubmit
        '
        Me.btnCreateQuetionSubmit.Location = New System.Drawing.Point(13, 357)
        Me.btnCreateQuetionSubmit.Name = "btnCreateQuetionSubmit"
        Me.btnCreateQuetionSubmit.Size = New System.Drawing.Size(622, 31)
        Me.btnCreateQuetionSubmit.TabIndex = 1
        Me.btnCreateQuetionSubmit.Text = "Submit"
        Me.btnCreateQuetionSubmit.UseVisualStyleBackColor = True
        '
        'CreateQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 400)
        Me.Controls.Add(Me.btnCreateQuetionSubmit)
        Me.Controls.Add(Me.tbCreateQuestion)
        Me.Name = "CreateQuestion"
        Me.Text = "CreateQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbCreateQuestion As TextBox
    Friend WithEvents btnCreateQuetionSubmit As Button
End Class
