Public Class AnswersForm
    Protected db As New db
    Protected question_id As Integer

    Public Sub New(ByRef QID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = QID
    End Sub
    Protected Sub loadanswers()
        db.sql = "select * from answers where question_id = @question_id"
        db.bind("@question_id", question_id)
        db.fill(dgvAnswers)
    End Sub
    Private Sub LoadAnswersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadAnswersToolStripMenuItem.Click
        loadanswers()
    End Sub

    Private Sub AnswersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadanswers()
    End Sub

    Private Sub CreateAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateAnswerToolStripMenuItem.Click
        Dim createAnswerForm As New CreateAnswer(question_id)
        createAnswerForm.ShowDialog()
        loadanswers()
    End Sub

    Private Sub UpdateAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAnswerToolStripMenuItem.Click
        Dim updateAnswerForm As New Update_Answer(getAnswerId(), getAnswerValue("answer"))
        updateAnswerForm.ShowDialog()
        loadanswers()
    End Sub
    Public Function getAnswerId() As Integer
        Return getAnswerValue("id")
    End Function

    Public Function getAnswerValue(ByVal column As String)
        Return dgvAnswers.Item(column, dgvAnswers.CurrentRow.Index).Value
    End Function

    Private Sub DeleteAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAnswerToolStripMenuItem.Click
        Dim confirmed As Integer = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNoCancel)
        If confirmed = DialogResult.Yes Then
            db.sql = "DELETE FROM answers WHERE id = @answer_id"
            db.bind("@answer_id", getAnswerId)
            db.execute()
            loadanswers()
        End If
        Me.Dispose()
    End Sub
End Class