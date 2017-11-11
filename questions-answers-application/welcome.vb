Imports System.Data.SqlClient

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
            db.sql = "DELETE From questions Where id  = @question_id"
            db.bind("@question_id", getQuestionId())
            db.execute()
            LoadQuestions()
        End If
    End Sub

    Private Sub ShowAnswersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAnswersToolStripMenuItem.Click

        My.Forms.ShowAnswers.Show()

        'Dim id As String = dgvQuestions.Item("id", dgvQuestions.CurrentRow.Index).Value.ToString()
        'Dim AnswersForm = New AnswersForm(id)
        'AnswersForm.ShowDialog()

    End Sub

    Private Sub dgvQuestions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvQuestions.CellContentClick

    End Sub
End Class
