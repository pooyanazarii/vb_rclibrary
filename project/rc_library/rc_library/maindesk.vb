Imports System.Data.SqlClient
Public Class maindesk


    Private Sub maindesk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MakepjDataSet.person' table. You can move, or remove it, as needed.
        Me.PersonTableAdapter.Fill(Me.MakepjDataSet.person)
        input_form.Hide()
    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim connection As SqlConnection = New sqlconnection()
        connection.ConnectionString = "Data Source=DESKTOP-P515RI8\SQLEXPRESS;Initial Catalog=makepj;Integrated Security=True"
        connection.Open()

        Dim adp As SqlDataAdapter = New SqlDataAdapter("select * from person", connection)

        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class