Public Class CreateAnswerForm
    Protected db As db = New db

    Private Sub SubmitAnswerButton_Click(sender As Object, e As EventArgs) Handles SubmitAnswerButton.Click
        db.sql = "INSERT INTO answers (id,answers) VALUES (@id,@answer)"
        db.bind("@id", tbrAnswerTextBox.Text)
        db.bind("@answer", tbrAnswerTextBox.Text)
    End Sub
End Class



'Public Class CreateQuestion
'    Protected db As db = New db

'    Private Sub btnQuestionSubmit_Click(sender As Object, e As EventArgs) Handles btnQuestionSubmit.Click
'        db.sql = "INSERT INTO questions (question) VALUES (@question)"
'        db.bind("@question", tbQuestion.Text)
'        db.execute()
'        Me.Dispose()
'    End Sub
'End Class