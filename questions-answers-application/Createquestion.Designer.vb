﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Createquestion
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
        Me.TBQuestion = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBQuestion
        '
        Me.TBQuestion.Location = New System.Drawing.Point(116, 105)
        Me.TBQuestion.Name = "TBQuestion"
        Me.TBQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TBQuestion.Size = New System.Drawing.Size(230, 20)
        Me.TBQuestion.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(184, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Createquestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 452)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TBQuestion)
        Me.Name = "Createquestion"
        Me.Text = "Createquestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBQuestion As TextBox
    Friend WithEvents Button1 As Button
End Class
