Public Class UpdateAnswerForm
    Protected answer_id As Integer
    Protected db As New db

    Public Sub New(ByVal aid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        answer_id = aid
        tbUpdateAnswerTextBox.Text = AnswersForm.getAnswerValue("answer").ToString()
    End Sub
    Private Sub SubmitUpAnswerButton_Click(sender As Object, e As EventArgs) Handles SubmitUpAnswerButton.Click
        db.sql = "UPDATE answers SET answer = @answer WHERE id = @answer_id"
        db.bind("@answer_id", answer_id)
        db.bind("@answer", tbUpdateAnswerTextBox.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class



