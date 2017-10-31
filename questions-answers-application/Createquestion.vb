Public Class Createquestion
    Protected db As db = New db


    Private Sub btnQuestionSubmit_Click(sender As Object, e As EventArgs) Handles btnQuestionSubmit.Click
        db.sql = "Insert Into questions (question) Values (@question)"
        db.bind("@question", TBQuestion.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class