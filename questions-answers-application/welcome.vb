
Public Class welcome
    Protected db As New db
    Protected Sub LoadAnswers()
        db.sql = "SELECT * FROM answers ORDER BY created_at DESC;"
        db.fill(dgvQuestions)
    End Sub
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

    Private Sub CreateQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateQuestionToolStripMenuItem.Click
        CreateQuestion.ShowDialog()
        LoadQuestions()
    End Sub

    Private Sub UpdateQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateQuestionToolStripMenuItem.Click
        Dim updateQuestionForm As New UpdateQuestion(getQuestionId())
        updateQuestionForm.ShowDialog()
        LoadQuestions()
    End Sub

    Public Function getQuestionId() As Integer
        Return getQuestionValue("id")
    End Function

    Public Function getQuestionValue(ByVal column As String)
        Return dgvQuestions.Item(column, dgvQuestions.CurrentRow.Index).Value
    End Function

    Private Sub DeleteQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteQuestionToolStripMenuItem.Click
        Dim confirmed As Integer = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNoCancel)

        If confirmed = DialogResult.Yes Then
            db.sql = "DELETE FROM questions WHERE id = @question_id"
            db.bind("@question_id", getQuestionId())
            db.execute()
            LoadQuestions()
        End If



    End Sub

    Private Sub ShowAnswersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAnswersToolStripMenuItem.Click
        Dim updateAnswerForm As New AnswersForm(getQuestionId())
        updateAnswerForm.ShowDialog()
        LoadAnswers()
    End Sub

    Private Sub FilterInvalidCheckboxesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilterInvalidCheckboxesToolStripMenuItem.Click
        Dim checked As Integer = MessageBox.Show("Are you sure you want to filter?", "Filter", MessageBoxButtons.YesNoCancel)

        If checked = DialogResult.Yes Then
            dgvQuestions.Sort(dgvQuestions.Columns(5), System.ComponentModel.ListSortDirection.Ascending)
        End If
    End Sub
End Class
