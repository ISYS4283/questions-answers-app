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

    'bind sql parmeters
    Public Sub bind(ByVal parameter As String, ByRef value As Object)
        sqlcmd.Parameters.AddWithValue(parameter, value)

    End Sub

    'populate a data gridview
    Public Sub fill(ByRef dgv As DataGridView)
        Dim adapter As SqlDataAdapter
        Dim dataset As DataSet

        Try
            sqlcon.Open()

            adapter = New SqlDataAdapter(sqlcmd)
            dataset = New DataSet
            adapter.Fill(dataset)
            If dataset.Tables.Count > 0 Then
                dgv.Refresh()
                dgv.DataSource = dataset.Tables(0)
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

    'execute a DLM statement'

    Public Sub Execute()

        Try
            sqlcon.Open()
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        Finally
            If sqlcon.State = ConnectionState.Open Then
                sqlcon.Close()

            End If
        End Try
    End Sub
End Class

