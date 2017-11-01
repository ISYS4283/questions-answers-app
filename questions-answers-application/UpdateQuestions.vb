Public Class UpdateQuestion
    'Protected means the Class Is Not visible outside the form
    Protected db As db = New db
    Protected question_id As Integer
    Public Sub New(ByVal qid As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = qid

        tbUpdateQuestion.Text = welcome.getQuestionValue("question").ToString()
    End Sub

    Private Sub BtnUpdateQuestions_Click(sender As Object, e As EventArgs) Handles BtnUpdateQuestions.Click
        db.sql = "UPDATE questions SET question = @question WHERE id = @question_id"
        db.bind("@question_id", question_id)
        db.bind("@question", tbUpdateQuestion.Text)
        db.execute()
        Me.Dispose()

    End Sub
End Class