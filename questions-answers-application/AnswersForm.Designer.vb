﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnswersForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvAnswers = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoadAnswersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateAnswerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAnswerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.dgvAnswers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAnswers
        '
        Me.dgvAnswers.AllowUserToAddRows = False
        Me.dgvAnswers.AllowUserToDeleteRows = False
        Me.dgvAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnswers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAnswers.Location = New System.Drawing.Point(0, 24)
        Me.dgvAnswers.Name = "dgvAnswers"
        Me.dgvAnswers.ReadOnly = True
        Me.dgvAnswers.Size = New System.Drawing.Size(678, 517)
        Me.dgvAnswers.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadAnswersToolStripMenuItem, Me.CreateAnswerToolStripMenuItem, Me.UpdateAnswerToolStripMenuItem, Me.DeleteaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(678, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoadAnswersToolStripMenuItem
        '
        Me.LoadAnswersToolStripMenuItem.Name = "LoadAnswersToolStripMenuItem"
        Me.LoadAnswersToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.LoadAnswersToolStripMenuItem.Text = "Load Answers"
        '
        'CreateAnswerToolStripMenuItem
        '
        Me.CreateAnswerToolStripMenuItem.Name = "CreateAnswerToolStripMenuItem"
        Me.CreateAnswerToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.CreateAnswerToolStripMenuItem.Text = "Create Answer"
        '
        'UpdateAnswerToolStripMenuItem
        '
        Me.UpdateAnswerToolStripMenuItem.Name = "UpdateAnswerToolStripMenuItem"
        Me.UpdateAnswerToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.UpdateAnswerToolStripMenuItem.Text = "Update Answer"
        '
        'DeleteaToolStripMenuItem
        '
        Me.DeleteaToolStripMenuItem.Name = "DeleteaToolStripMenuItem"
        Me.DeleteaToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.DeleteaToolStripMenuItem.Text = "Delete Answer "
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'AnswersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 541)
        Me.Controls.Add(Me.dgvAnswers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AnswersForm"
        Me.Text = "AnswersForm"
        CType(Me.dgvAnswers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAnswers As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoadAnswersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CreateAnswerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateAnswerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteaToolStripMenuItem As ToolStripMenuItem
End Class
