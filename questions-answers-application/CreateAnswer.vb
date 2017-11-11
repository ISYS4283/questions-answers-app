Public Class CreateAnswer
    Protected db As New db
    Protected question_id As Integer
    Public Sub New(ByRef QID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = QID

        TextBox2.Text = question_id


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        db.sql = "INSERT INTO answers (question_id, answer) VALUES (@question_id, @answer)"
        db.bind("@question_id", TextBox2.Text)
        db.bind("@answer", TextBox1.Text)
        db.execute()
        Me.Dispose()

    End Sub



End Class