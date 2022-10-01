Imports System.Data.SqlClient



Public Class Form2
    Dim cmd1 As New SqlCommand
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        cmd1.Parameters.Clear()
        cmd1.CommandText = "insert into deneme (urunad,marka,agırlık) values (@urunad,@marka,@agırlık)"
        cmd1.Connection = baglan
        cmd1.Parameters.Add("@urun", SqlDbType.VarChar).Value = urun.Text
        cmd1.Parameters.Add("@marka", SqlDbType.VarChar).Value = marka.Text
        cmd1.Parameters.Add("@agırlık", SqlDbType.Int).Value = agırlık.Text


        cmd1.ExecuteNonQuery()
        Form1.Veri()

        Me.Close()

    End Sub
End Class