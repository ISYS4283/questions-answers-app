<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dgvAsnwersForm
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
        Me.CreateAnswerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvAnswer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAnswer
        '
        Me.dgvAnswer.AllowUserToAddRows = False
        Me.dgvAnswer.AllowUserToDeleteRows = False
        Me.dgvAnswer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnswer.Location = New System.Drawing.Point(2, 40)
        Me.dgvAnswer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvAnswer.Name = "dgvAnswer"
        Me.dgvAnswer.ReadOnly = True
        Me.dgvAnswer.Size = New System.Drawing.Size(1020, 520)
        Me.dgvAnswer.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadAnswerToolStripMenuItem, Me.CreateAnswerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1022, 35)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoadAnswerToolStripMenuItem
        '
        Me.LoadAnswerToolStripMenuItem.Name = "LoadAnswerToolStripMenuItem"
        Me.LoadAnswerToolStripMenuItem.Size = New System.Drawing.Size(126, 29)
        Me.LoadAnswerToolStripMenuItem.Text = "Load Answer"
        '
        'CreateAnswerToolStripMenuItem
        '
        Me.CreateAnswerToolStripMenuItem.Name = "CreateAnswerToolStripMenuItem"
        Me.CreateAnswerToolStripMenuItem.Size = New System.Drawing.Size(137, 29)
        Me.CreateAnswerToolStripMenuItem.Text = "Create Answer"
        '
        'dgvAsnwersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 617)
        Me.Controls.Add(Me.dgvAnswer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "dgvAsnwersForm"
        Me.Text = "AsnwersForm"
        CType(Me.dgvAnswer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAnswer As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoadAnswerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateAnswerToolStripMenuItem As ToolStripMenuItem
End Class
