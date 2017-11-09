<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QandAtogetherForm
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
        Me.dgvQandA = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CloseButtonButton = New System.Windows.Forms.Button()
        CType(Me.dgvQandA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvQandA
        '
        Me.dgvQandA.AllowUserToAddRows = False
        Me.dgvQandA.AllowUserToDeleteRows = False
        Me.dgvQandA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvQandA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQandA.Location = New System.Drawing.Point(0, 3)
        Me.dgvQandA.Name = "dgvQandA"
        Me.dgvQandA.ReadOnly = True
        Me.dgvQandA.RowTemplate.Height = 28
        Me.dgvQandA.Size = New System.Drawing.Size(1222, 639)
        Me.dgvQandA.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(403, 648)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(340, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Load Questions and Answers"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CloseButtonButton
        '
        Me.CloseButtonButton.Location = New System.Drawing.Point(1078, 654)
        Me.CloseButtonButton.Name = "CloseButtonButton"
        Me.CloseButtonButton.Size = New System.Drawing.Size(123, 32)
        Me.CloseButtonButton.TabIndex = 2
        Me.CloseButtonButton.Text = "Close"
        Me.CloseButtonButton.UseVisualStyleBackColor = True
        '
        'QandAtogetherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 689)
        Me.Controls.Add(Me.CloseButtonButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvQandA)
        Me.Name = "QandAtogetherForm"
        Me.Text = "Questions with Answers"
        CType(Me.dgvQandA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvQandA As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents CloseButtonButton As Button
End Class
