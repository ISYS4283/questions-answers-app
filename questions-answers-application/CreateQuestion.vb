Public Class CreateQuestion
    Protected db As db = New db
    Private Sub btnQuestionSubmit_Click(sender As Object, e As EventArgs) Handles btnQuestionSubmit.Click

        db.sql = "Insert into questions (question) values (@question)"
        db.bind("@question", tbQuestion.Text)
        db.execute()
        Me.Dispose()

    End Sub
End Class