Public Class DeleteAnswer
    Protected db As db = New db

    Private Sub tbDAid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbDAid.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
    Private Sub btnDeleteAnswerSubmit_Click(sender As Object, e As EventArgs) Handles btnDeleteAnswerSubmit.Click
        db.sql = "DELETE FROM answers WHERE id = @answer_id"
        db.bind("@answer_id", tbDAid.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class