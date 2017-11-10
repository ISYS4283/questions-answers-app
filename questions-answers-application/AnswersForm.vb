Public Class AnswersForm
    Protected db As New db
    Protected question_id As Integer
    Protected answer_id As Integer


    Public Sub New(ByRef qid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = qid
    End Sub

    Protected Sub LoadAnswers()
        db.sql = "SELECT * FROM answers WHERE question_id = @question_id"
        db.bind("@question_id", question_id)
        db.fill(dgvAnswers)
    End Sub
    Private Sub LoadAnswersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadAnswersToolStripMenuItem.Click
        LoadAnswers()
    End Sub


    Private Sub AnswersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAnswers()
    End Sub

    Private Sub DeleteaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteaToolStripMenuItem.Click
        Dim confirmed As Integer = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNoCancel)

        If confirmed = DialogResult.Yes Then
            db.sql = "DELETE FROM answers WHERE id = @answer_id"
            db.bind("@answer_id", getAnswerValue("id"))
            db.execute()
            LoadAnswers()
        End If
    End Sub

    Public Function getAnswerId() As Integer
        Return getAnswerValue("id")
    End Function

    Public Function getAnswerValue(ByVal column As String)
        Return dgvAnswers.Item(column, dgvAnswers.CurrentRow.Index).Value
    End Function

    Private Sub CreateAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateAnswerToolStripMenuItem.Click
        Dim CreateAnswerForm As New CreateAnswer(question_id)
        CreateAnswerForm.ShowDialog()
        LoadAnswers()
    End Sub

    Private Sub UpdateAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAnswerToolStripMenuItem.Click
        'Dim UpdateAnswerForm As New UpdateAnswer(question_id)
        'UpdateAnswerForm.ShowDialog()
        'LoadAnswers()

        Dim updateAnswerForm As New UpdateAnswer(getAnswerId(), getAnswerValue("answer"))
        updateAnswerForm.ShowDialog()
        LoadAnswers()
    End Sub
End Class