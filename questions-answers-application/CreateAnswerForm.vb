
Public Class CreateAnswerForm
    Protected question_id As Integer
    Protected db As New db

    Public Sub New(ByVal qid As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = qid

        'tbCreateAnswerTextBox.Text = welcome.getQuestionValue("question").ToString()
        ShowQuestionTextBox.Text = welcome.getQuestionValue("question").ToString()
    End Sub

    Private Sub SubmitAnswerButton_Click(sender As Object, e As EventArgs) Handles SubmitAnswerButton.Click
        db.sql = "INSERT INTO answers (question_id,answer) VALUES (@question_id,@answer)"
        db.bind("@question_id", question_id)
        db.bind("@answer", tbCreateAnswerTextBox.Text)
        db.execute()
        Me.Dispose()


        welcome.Hide()


            AnswersForm.ShowDialog()

    End Sub

    Private Sub CreateAnswerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ShowQuestionTextBox.Text = 
        'Me.ShowQuestionTextBox.Text = "Test"
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Hide()
    End Sub
End Class


