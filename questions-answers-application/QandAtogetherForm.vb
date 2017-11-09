Public Class QandAtogetherForm
    Protected db As New db

    Protected Sub LoadQandAtogether()
        db.sql = "SELECT question_id,question, answer ,a.created_at 
                  FROM questions q JOIN answers a 
                  ON q.id = a.question_id
                  ORDER BY q.created_at DESC;"
        db.fill(dgvQandA)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadQandAtogether()
    End Sub

    Private Sub CloseButtonButton_Click(sender As Object, e As EventArgs) Handles CloseButtonButton.Click
        Me.Dispose()
        welcome.Show()

    End Sub

    Private Sub QandAtogetherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQandAtogether()
    End Sub
End Class