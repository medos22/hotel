Imports System.Data.OleDb

Public Class sign
    Private Sub sign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hotel.mdb;" 'where your file is write it after source
        con.Open()


        Dim cmd As New OleDbCommand

        cmd.Connection = con
        cmd.CommandText = "select * from hotel"

        Dim dr As OleDbDataReader

        dr = cmd.ExecuteReader
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        Form1.Show()


    End Sub
End Class