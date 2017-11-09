Public Class frmShowInvalid
    Protected db As New db
    Protected question_id As Integer

    Public Sub New(ByRef qid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = qid
    End Sub
    Protected Sub LoadAnswers()
        db.sql = "SELECT * FROM [isys4283-2017fa].[dbo].[questions] WHERE invalid = 1"
        db.fill(dgvInvalid)
        db.execute()
    End Sub



    Private Sub frmShowInvalid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAnswers()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
