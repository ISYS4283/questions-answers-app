﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateQuestions
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
        Me.tbQuestion.Location = New System.Drawing.Point(3, 12)
        Me.tbQuestion.Multiline = True
        Me.tbQuestion.Name = "tbQuestion"
        Me.tbQuestion.Size = New System.Drawing.Size(828, 253)
        Me.tbQuestion.TabIndex = 0
        '
        'btnQuestionSubmit
        '
        Me.btnQuestionSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuestionSubmit.Location = New System.Drawing.Point(3, 271)
        Me.btnQuestionSubmit.Name = "btnQuestionSubmit"
        Me.btnQuestionSubmit.Size = New System.Drawing.Size(828, 191)
        Me.btnQuestionSubmit.TabIndex = 1
        Me.btnQuestionSubmit.Text = "Submit"
        Me.btnQuestionSubmit.UseVisualStyleBackColor = True
        '
        'CreateQuestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 473)
        Me.Controls.Add(Me.btnQuestionSubmit)
        Me.Controls.Add(Me.tbQuestion)
        Me.Name = "CreateQuestions"
        Me.Text = "CreateQuestions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbQuestion As TextBox
    Friend WithEvents btnQuestionSubmit As Button
End Class
