Public Class CreateQuestion
    Protected db As db = New db
    Private Sub btnCreateQuetionSubmit_Click(sender As Object, e As EventArgs) Handles btnCreateQuetionSubmit.Click
        db.sql = "INSERT INTO questions (question) VALUES (@question)"
        db.bind("@question", tbCreateQuestion.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class