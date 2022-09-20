Imports System.Data.SqlClient
Public Class maindesk


    Private Sub maindesk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Aseman_library_vbDataSet2.person' table. You can move, or remove it, as needed.
        Me.PersonTableAdapter2.Fill(Me.Aseman_library_vbDataSet2.person)
        'TODO: This line of code loads data into the 'Aseman_library_vbDataSet.person' table. You can move, or remove it, as needed.
        Me.PersonTableAdapter1.Fill(Me.Aseman_library_vbDataSet.person)
        'TODO: This line of code loads data into the 'MakepjDataSet.person' table. You can move, or remove it, as needed.
        Me.PersonTableAdapter.Fill(Me.MakepjDataSet.person)

    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim connection As SqlConnection = New sqlconnection()
        connection.ConnectionString = "Data Source=DESKTOP-P515RI8\SQLEXPRESS;Initial Catalog=aseman_library_vb;Integrated Security=True"
        connection.Open()

        Dim adp As SqlDataAdapter = New SqlDataAdapter("select * from person", connection)

        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btn_add_new_person_Click(sender As Object, e As EventArgs) Handles btn_add_new_person.Click
        form_add_new_person.Show()
        Me.Close()
    End Sub

    Private Sub maindesk_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub
End Class