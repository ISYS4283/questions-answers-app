Public Class Filterbydate
    Protected db As New db
    Protected question_id As Integer

    Public Sub New(ByRef qid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = qid
    End Sub
    Protected Sub LoadFilteredQuests()


        db.sql = "SELECT * FROM questions WHERE created_at > @beginDate ORDER BY id DESC"
        db.bind("@beginDate", TextBox1.Text)
        db.fill(DataGridView1)

    End Sub



    Private Sub LoadQuestionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadQuestionsToolStripMenuItem.Click
        If TextBox1.Text = Nothing Then
            MessageBox.Show("Make sure you input a beginning date!", "Requirement Not Filled", MessageBoxButtons.OK)
            Me.Close()
        End If
        LoadFilteredQuests()
    End Sub


End Class