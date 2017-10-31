
Public Class UpdateQuestion
    Protected question_id As Integer
    Protected db As New db

    Public Sub New(ByVal qid As Integer)


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = qid

        tbupdatequestion.Text = welcome.getQuestionValue("question").ToString()

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbupdatequestion.TextChanged

    End Sub

    Private Sub UpdateQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dbnupdateQuestionsubmit_Click(sender As Object, e As EventArgs) Handles dtnUpdateQuestionSubmit.Click
        db.sql = "UPDATE questions SET question = @question WHERE id = @question_id"
        db.bind("@question_id", question_id)
        db.bind("question", tbupdatequestion.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class