<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateQuestion
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
        Me.TbUpdateQuestion = New System.Windows.Forms.TextBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TbUpdateQuestion
        '
        Me.TbUpdateQuestion.Location = New System.Drawing.Point(60, 48)
        Me.TbUpdateQuestion.Multiline = True
        Me.TbUpdateQuestion.Name = "TbUpdateQuestion"
        Me.TbUpdateQuestion.Size = New System.Drawing.Size(508, 219)
        Me.TbUpdateQuestion.TabIndex = 0
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(60, 299)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(508, 47)
        Me.BtnUpdate.TabIndex = 1
        Me.BtnUpdate.Text = "Submit"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'UpdateQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 389)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.TbUpdateQuestion)
        Me.Name = "UpdateQuestion"
        Me.Text = "UpdateQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbUpdateQuestion As TextBox
    Friend WithEvents BtnUpdate As Button
End Class
