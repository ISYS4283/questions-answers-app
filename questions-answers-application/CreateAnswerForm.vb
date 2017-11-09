
Public Class CreateAnswerForm
    Protected question_id As Integer
    Protected db As New db

    Public Sub New(ByVal qid As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = qid

        tbCreateAnswerTextBox.Text = welcome.getQuestionValue("question").ToString()
    End Sub

    Private Sub SubmitAnswerButton_Click(sender As Object, e As EventArgs) Handles SubmitAnswerButton.Click
        db.sql = "INSERT INTO answers (question_id,answer) VALUES (@question_id,@answer)"
        db.bind("@question_id", question_id)
        db.bind("@answer", tbCreateAnswerTextBox.Text)
        db.execute()
        Me.Dispose()
        AnswersForm.ShowDialog()
    End Sub

    Private Sub tbCreateAnswerTextBox_TextChanged(sender As Object, e As EventArgs) Handles tbCreateAnswerTextBox.TextChanged

    End Sub
End Class



'Protected question_id As Integer
'Protected db As New db

'Public Sub New(ByVal qid As Integer)
'    ' This call is required by the designer.
'    InitializeComponent()

'    ' Add any initialization after the InitializeComponent() call.
'    question_id = qid

'    tbUpdateQuestion.Text = welcome.getQuestionValue("question").ToString()
'End Sub

'Private Sub btnUpdateQuestionSubmit_Click(sender As Object, e As EventArgs) Handles btnUpdateQuestionSubmit.Click
'    db.sql = "UPDATE questions SET question = @question WHERE id = @question_id"
'    db.bind("@question_id", question_id)
'    db.bind("@question", tbUpdateQuestion.Text)
'    db.execute()
'    Me.Dispose()
'End Sub