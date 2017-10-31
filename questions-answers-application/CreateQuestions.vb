Public Class CreateQuestions
    Protected db As db = New db
    Private Sub btnQuestionSubmit_Click(sender As Object, e As EventArgs) Handles btnQuestionSubmit.Click

        db.sql = "INSERT INTO questions (question) VALUES (@question)"
        db.bind("@question", tbQuestion.Text)
        db.execute()
        Me.Dispose()
        'Me.Close() leaves the old one but Dispose erases the old question
    End Sub
End Class