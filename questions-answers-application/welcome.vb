
Public Class welcome
    Protected db As New db
    Protected Sub LoadQuestions()
        db.sql = "SELECT * FROM questions ORDER BY created_at DESC;"

        db.fill(dgvQuestions)
    End Sub
    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        LoadQuestions()
    End Sub

    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQuestions()
    End Sub

    Private Sub CreateQuestionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateQuestionsToolStripMenuItem.Click
        CreateQuestions.ShowDialog()
        LoadQuestions()
    End Sub

    Private Sub UpdateQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateQuestionToolStripMenuItem.Click
        Dim updateQuestionForm As New UpdateQuestion(getQeustionId())
        updateQuestionForm.ShowDialog()
        LoadQuestions()
    End Sub
    ' below function shows the original question so we can see and change it
    Public Function getQeustionId() As Integer
        ' Return dgvQuestions.Item("id", dgvQuestions.CurrentRow.Index).Value
        Return getQuestionValue("id")

    End Function

    Public Function getQuestionValue(ByVal column As String)
        Return dgvQuestions.Item(column, dgvQuestions.CurrentRow.Index).Value

    End Function
End Class
