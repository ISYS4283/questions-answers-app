Public Class updateQuestion
    Protected db As db = New db
    Protected question_ID As Integer

    Public Sub New(ByVal qid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_ID = qid

        TBUpdateQuestion.Text = welcome.getquestionvalue("question").ToString
    End Sub
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        db.sql = "UPDATE Questions SET question = @question WHERE id = @question_id"
        db.bind("@question_id", question_ID)
        db.bind("@question", TBUpdateQuestion.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class