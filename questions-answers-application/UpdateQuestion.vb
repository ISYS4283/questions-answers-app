Public Class UpdateQuestion
    Protected question_id As Integer
    Protected db As New db
    Public Sub New(ByVal qid As Integer)
        'This call is required by the designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call.
        question_id = qid
        TbUpdateQuestion.Text = welcome.getQuestionValue("question").ToString()

    End Sub


    Private Sub UpdateQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        db.sql = "UPDATe questions SET question = @question WHERE id = @question_id"
        db.bind("@question_id", question_id)
        db.bind("question", TbUpdateQuestion.Text)
        db.execute()
        Me.Dispose()
    End Sub
End Class