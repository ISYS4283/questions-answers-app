Imports System.Data.SqlClient
Public Class db
    Dim sqlcon As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283-2017fa;Trusted_Connection=yes;"}
    Dim sqlcmd As New SqlCommand With {.Connection = sqlcon}
    Public Property sql() As String
        Get
            Return sqlcmd.CommandText
        End Get
        Set(value As String)
            sqlcmd.CommandText = value

        End Set
    End Property
    Public Sub fill(ByRef dgv As DataGridView)
        Dim sqlda As SqlDataAdapter
        Dim sqldataset As DataSet

        Dim query As String
        query = "SELECT * FROM questions ORDER BY created_at DESC;"

        Try
            sqlcon.Open()
            sqlda = New SqlDataAdapter(sqlcmd)
            sqldataset = New DataSet
            sqlda.Fill(sqldataset)
            If sqldataset.Tables.Count > 0 Then
                dgv.Refresh()
                dgv.DataSource = sqldataset.Tables(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        Finally
            If sqlcon.State = ConnectionState.Open Then
                sqlcon.Close()
            End If
        End Try
    End Sub
    ''Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
    ' LoadQuestions()
    ' End Sub



    ' Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '  LoadQuestions()
    ' End Sub
End Class
