Public Class UpdateAnswer
    Protected db As db = New db

    Private Sub tbAid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbAid.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
    Private Sub btnUpdateAnswerSubmit_Click(sender As Object, e As EventArgs) Handles btnUpdateAnswerSubmit.Click
        db.sql = "UPDATE answers SET answer = @answer WHERE id = @answer_id"
        db.bind("@answer_id", tbAid.Text)
        db.bind("@answer", tbUpdateAnswer.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class