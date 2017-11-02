Public Class AnswersForm
    Protected db As New db
    Protected question_id As Integer
    Public Sub New(ByRef QID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = QID
    End Sub
    Protected Sub loadanswers()
        db.sql = "select * from answers where question_id = @question_id"
        db.bind("@question_id", question_id)
        db.fill(dgvAnswers)
    End Sub
    Private Sub LoadAnswersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadAnswersToolStripMenuItem.Click
        loadanswers()
    End Sub

End Class