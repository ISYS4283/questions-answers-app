Public Class createQuestion
    Protected db As db = New db
    Private Sub TBQuestions_TextChanged(sender As Object, e As EventArgs) Handles TBQuestions.TextChanged

    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        db.sql = "INSERT INTO questions (question) VALUES (@question)"
        db.bind("@question", TBQuestions.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class