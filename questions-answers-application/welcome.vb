
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

    'Update quetion using question id
    Private Sub UpdateQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateQuestionToolStripMenuItem.Click
        Dim updateQuestionForm As New UpdateQuestion(getQuestionId())
        updateQuestionForm.ShowDialog()
        LoadQuestions()
    End Sub

    'To get quetion id on getQuestionId valiable 
    Public Function getQuestionId() As Integer
        Return getQuestionValue("id")
    End Function

    'To get question if value from current row selected yo update question 
    Public Function getQuestionValue(ByVal column As String)
        Return dgvQuestions.Item(column, dgvQuestions.CurrentRow.Index).Value
    End Function

    Private Sub DeleteQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteQuestionToolStripMenuItem.Click
        Dim confirmed As Integer = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNoCancel)
        If confirmed = DialogResult.Yes Then
            db.sql = "Delete FROM questions WHERE id = @question_id"
            db.bind("@question_id", getQuestionId())
            db.execute()
            LoadQuestions()
            'MsgBox("Deleted")
        End If
    End Sub


    Protected Sub LoadAnswers()
        db.sql = "SELECT * FROM answers ORDER BY created_at DESC;"
        db.fill(dgvQuestions)
    End Sub

    Private Sub ShowAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAnswerToolStripMenuItem.Click
        Me.Hide()
        'My.Forms.AnswersForm.Show()
        AnswersForm.ShowDialog()
        LoadAnswers()
    End Sub

    Private Sub CreateAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateAnswerToolStripMenuItem.Click
        Dim CreateAnswerForm As New CreateAnswerForm(getQuestionId())
        CreateAnswerForm.ShowDialog()
        LoadQuestions()
    End Sub

    'Get qustions with anwers

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim QandAtogetherForm As New QandAtogetherForm()
        'QandAtogetherForm.ShowDialog()
        'LoadQandAtogether()
        Me.Hide()
        QandAtogetherForm.ShowDialog()

    End Sub

    'Exit from application
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim confirmed As Integer = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNoCancel)
        If confirmed = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub
End Class
