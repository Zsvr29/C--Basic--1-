Imports System.Data.SqlClient
Public Class Form3
    Dim cmd1 As New SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cmd1.Parameters.Clear()
        cmd1.CommandText = "update deneme set urunad=@urun,marka=@marka, agırlık=@agırlık where id=@id"
        cmd1.Connection = baglan
        cmd1.Parameters.Add("@urun", SqlDbType.VarChar).Value = urun.Text
        cmd1.Parameters.Add("@marka", SqlDbType.VarChar).Value = marka.Text
        cmd1.Parameters.Add("@ağırlık", SqlDbType.Int).Value = agırlık.Text
        cmd1.Parameters.Add("@id", SqlDbType.Int).Value = Label5.Text
        cmd1.ExecuteNonQuery()
        Form1.Veri()
        Me.Close()
    End Sub
End Class