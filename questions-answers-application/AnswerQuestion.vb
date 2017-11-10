Public Class AnswerQuestion
    Protected db As db = New db

    Private Sub tbQid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbQid.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
    Private Sub btnQuestionSubmit_Click(sender As Object, e As EventArgs) Handles btnAnswerSubmit.Click


        db.sql = "INSERT INTO answers (question_id, answer) VALUES (@questionId, @answer)"
        db.bind("@questionId", tbQid.Text)
        db.bind("@answer", tbAnswer.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class