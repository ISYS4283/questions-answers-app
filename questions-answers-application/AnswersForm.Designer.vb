<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnswersForm
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
        Me.dgvAnswer = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoadAnswerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAnswerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAnswerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToWelcomePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadRecentAnsButton = New System.Windows.Forms.Button()
        Me.FilterCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.dgvAnswer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAnswer
        '
        Me.dgvAnswer.AllowUserToAddRows = False
        Me.dgvAnswer.AllowUserToDeleteRows = False
        Me.dgvAnswer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAnswer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnswer.Location = New System.Drawing.Point(2, 40)
        Me.dgvAnswer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvAnswer.Name = "dgvAnswer"
        Me.dgvAnswer.ReadOnly = True
        Me.dgvAnswer.Size = New System.Drawing.Size(1244, 517)
        Me.dgvAnswer.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadAnswerToolStripMenuItem, Me.UpdateAnswerToolStripMenuItem, Me.DeleteAnswerToolStripMenuItem, Me.GoToWelcomePageToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1246, 35)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoadAnswerToolStripMenuItem
        '
        Me.LoadAnswerToolStripMenuItem.Name = "LoadAnswerToolStripMenuItem"
        Me.LoadAnswerToolStripMenuItem.Size = New System.Drawing.Size(126, 29)
        Me.LoadAnswerToolStripMenuItem.Text = "Load Answer"
        '
        'UpdateAnswerToolStripMenuItem
        '
        Me.UpdateAnswerToolStripMenuItem.Name = "UpdateAnswerToolStripMenuItem"
        Me.UpdateAnswerToolStripMenuItem.Size = New System.Drawing.Size(145, 29)
        Me.UpdateAnswerToolStripMenuItem.Text = "Update Answer"
        '
        'DeleteAnswerToolStripMenuItem
        '
        Me.DeleteAnswerToolStripMenuItem.Name = "DeleteAnswerToolStripMenuItem"
        Me.DeleteAnswerToolStripMenuItem.Size = New System.Drawing.Size(137, 29)
        Me.DeleteAnswerToolStripMenuItem.Text = "Delete Answer"
        '
        'GoToWelcomePageToolStripMenuItem
        '
        Me.GoToWelcomePageToolStripMenuItem.Name = "GoToWelcomePageToolStripMenuItem"
        Me.GoToWelcomePageToolStripMenuItem.Size = New System.Drawing.Size(190, 29)
        Me.GoToWelcomePageToolStripMenuItem.Text = "Go to Welcome Page"
        '
        'LoadRecentAnsButton
        '
        Me.LoadRecentAnsButton.AutoSize = True
        Me.LoadRecentAnsButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.LoadRecentAnsButton.ForeColor = System.Drawing.Color.White
        Me.LoadRecentAnsButton.Location = New System.Drawing.Point(1009, 565)
        Me.LoadRecentAnsButton.Name = "LoadRecentAnsButton"
        Me.LoadRecentAnsButton.Size = New System.Drawing.Size(157, 43)
        Me.LoadRecentAnsButton.TabIndex = 2
        Me.LoadRecentAnsButton.Text = "Load Questions"
        Me.LoadRecentAnsButton.UseVisualStyleBackColor = False
        '
        'FilterCheckBox
        '
        Me.FilterCheckBox.AutoSize = True
        Me.FilterCheckBox.ForeColor = System.Drawing.Color.Blue
        Me.FilterCheckBox.Location = New System.Drawing.Point(12, 589)
        Me.FilterCheckBox.Name = "FilterCheckBox"
        Me.FilterCheckBox.Size = New System.Drawing.Size(196, 24)
        Me.FilterCheckBox.TabIndex = 3
        Me.FilterCheckBox.Text = "Remove invalid anwers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.FilterCheckBox.UseVisualStyleBackColor = True
        '
        'AnswersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 619)
        Me.Controls.Add(Me.FilterCheckBox)
        Me.Controls.Add(Me.LoadRecentAnsButton)
        Me.Controls.Add(Me.dgvAnswer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AnswersForm"
        Me.Text = "Answers"
        CType(Me.dgvAnswer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAnswer As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoadAnswerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateAnswerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAnswerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadRecentAnsButton As Button
    Friend WithEvents GoToWelcomePageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilterCheckBox As CheckBox
End Class
