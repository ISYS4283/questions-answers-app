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
        Me.components = New System.ComponentModel.Container()
        Me.tbupdatequestion = New System.Windows.Forms.TextBox()
        Me.dtnUpdateQuestionSubmit = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbupdatequestion
        '
        Me.tbupdatequestion.Location = New System.Drawing.Point(30, 25)
        Me.tbupdatequestion.Multiline = True
        Me.tbupdatequestion.Name = "tbupdatequestion"
        Me.tbupdatequestion.Size = New System.Drawing.Size(552, 278)
        Me.tbupdatequestion.TabIndex = 0
        '
        'dtnUpdateQuestionSubmit
        '
        Me.dtnUpdateQuestionSubmit.Location = New System.Drawing.Point(30, 335)
        Me.dtnUpdateQuestionSubmit.Name = "dtnUpdateQuestionSubmit"
        Me.dtnUpdateQuestionSubmit.Size = New System.Drawing.Size(552, 68)
        Me.dtnUpdateQuestionSubmit.TabIndex = 1
        Me.dtnUpdateQuestionSubmit.Text = "Submit"
        Me.dtnUpdateQuestionSubmit.UseVisualStyleBackColor = True
        '
        'UpdateQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 455)
        Me.Controls.Add(Me.dtnUpdateQuestionSubmit)
        Me.Controls.Add(Me.tbupdatequestion)
        Me.Name = "UpdateQuestion"
        Me.Text = "UpdateQuestion"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbupdatequestion As TextBox
    Friend WithEvents dtnUpdateQuestionSubmit As Button
    Friend WithEvents BindingSource1 As BindingSource
End Class
