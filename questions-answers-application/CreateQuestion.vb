Public Class CreateQuestion
    Protected db As db = New db
    Private Sub btnQuestionSubmit_Click(sender As Object, e As EventArgs) Handles btnQuestionSubmit.Click
        db.sql = "INSERT INTO questions (question) VALUES (@question)"
        db.bind("@question", tbCreateQuestion.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class