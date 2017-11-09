Public Class CreateAnswer
    Protected question_id As Integer
    Protected db As New db

    Public Sub New(ByRef qid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = qid
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        db.sql = "INSERT INTO answers (question_id, answer) VALUES (@question_id, @answer)"
        db.bind("@question_id", question_id)
        db.bind("@answer", TextBox1.Text)
        db.execute()
        Me.Dispose()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class