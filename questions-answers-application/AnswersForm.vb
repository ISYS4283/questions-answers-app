Public Class AnswersForm
    Protected db As New db
    'Show recent answers
    Protected Sub LoadRecentAnswers()
        db.sql = "SELECT * FROM answers ORDER BY created_at DESC;"
        db.fill(dgvAnswer)
    End Sub
    Protected Sub LoadQ()
        db.sql = "SELECT * FROM questions ORDER BY created_at DESC;"
        db.fill(dgvAnswer)
    End Sub

    Private Sub LoadRecentAnsButton_Click(sender As Object, e As EventArgs) Handles LoadRecentAnsButton.Click
        LoadQ()
    End Sub

    Private Sub AnswersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecentAnswers()

    End Sub

    'For loading answer
    Protected Sub LoadAnswers()
        db.sql = "SELECT * FROM answers WHERE question_id = ''ORDER BY created_at DESC;"
        db.fill(dgvAnswer)
    End Sub
    Private Sub LoadAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadAnswerToolStripMenuItem.Click
        LoadRecentAnswers()
    End Sub

    'Update quetion using question id
    Private Sub UpdateAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAnswerToolStripMenuItem.Click
        ' Dim confirmed As Integer = MessageBox.Show("Please load answer first", "Update Answer", MessageBoxButtons.OK)
        Dim updateAnswerForm As New UpdateAnswerForm(getAnswerId())
        updateAnswerForm.ShowDialog()
        LoadRecentAnswers()

    End Sub


    'To get answer id on  valiable 
    Public Function getAnswerId() As Integer
        Return getAnswerValue("id")
    End Function

    'To get answer value from current row selected 
    Public Function getAnswerValue(ByVal column As String)
        Return dgvAnswer.Item(column, dgvAnswer.CurrentRow.Index).Value
    End Function

    Private Sub DeleteAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAnswerToolStripMenuItem.Click
        Dim confirmed As Integer = MessageBox.Show("Are you sure you want to delete this answer?", "Delete", MessageBoxButtons.YesNoCancel)
        If confirmed = DialogResult.Yes Then
            db.sql = "Delete FROM answers WHERE id = @answer_id"
            db.bind("@answer_id", getAnswerId())
            db.execute()
            LoadRecentAnswers()
            'MsgBox("Deleted")

        End If
    End Sub

    Private Sub GoToWelcomePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToWelcomePageToolStripMenuItem.Click
        Me.Hide()
        welcome.Show()

    End Sub
    'Loading valid answer only
    Protected Sub LoadValidAnswerOnly()
        db.sql = "select * from answers where invalid <> 1"
        db.fill(dgvAnswer)
    End Sub
    Private Sub FilterCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FilterCheckBox.CheckedChanged
        If FilterCheckBox.Checked = True Then
            LoadValidAnswerOnly()
        Else
            LoadRecentAnswers()
        End If

    End Sub
End Class