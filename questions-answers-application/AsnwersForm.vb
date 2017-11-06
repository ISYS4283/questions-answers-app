Public Class dgvAsnwersForm
    Protected db As New db

    Protected Sub LoadAnswers()
        db.sql = "SELECT * FROM answers ORDER BY created_at DESC;"
        db.fill(dgvAnswer)
    End Sub
    Private Sub LoadAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadAnswerToolStripMenuItem.Click
        LoadAnswers()
    End Sub

    Private Sub dgvAsnwersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAnswers()
    End Sub


    'Public Function getQuestionId() As Integer
    '    Return getQuestionValue("id")
    'End Function

    'Public Function getQuestionValue(ByVal column As String)
    '    Return dgvQuestions.Item(column, dgvQuestions.CurrentRow.Index).Value
    'End Function






    Private Sub CreateAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateAnswerToolStripMenuItem.Click
        CreateAnswerForm.ShowDialog()
        LoadAnswers()
    End Sub
End Class