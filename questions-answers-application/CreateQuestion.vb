Public Class CreateQuestion
    Protected db As db = New db
    Private Sub BtnQuestionSubmit_Click(sender As Object, e As EventArgs) Handles BtnQuestionSubmit.Click
        db.sql = "INSERT INTO questions (question) VALUES (@question)"
        db.bind("@question", tbQuestion.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class