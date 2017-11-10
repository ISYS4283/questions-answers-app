Public Class QuestionsandAnswers
    Protected db As New db

    Private Sub QuestionsandAnswers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.sql =
  "Select answers.question_id, questions.question, answers.answer
  From Answers
  INNER Join questions ON answers.question_id = questions.id"
        db.fill(DataGridView1)
    End Sub
End Class