Imports System.Data.OleDb

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection
        con.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hotel.mdb;" 'where your file is write it after source
        con.Open()


        Dim cmd As New OleDbCommand

        cmd.Connection = con
        cmd.CommandText = "select * from hotel"

        Dim dr As OleDbDataReader

        dr = cmd.ExecuteReader
        dr.Read()
        MsgBox(dr.Item(0))
        MsgBox(dr.Item(0))
        dr.Read()
        MsgBox(dr.Item(1))

    End Sub
End Class
