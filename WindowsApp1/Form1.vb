Imports System.Data.SqlClient
Imports System.Reflection.Emit


Public Class Form1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Me.Close()

    End Sub
    Dim cmd As New SqlCommand
    Dim adp As New SqlDataAdapter
    Dim ds As New DataSet

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            baglan.ConnectionString = "Data Source=DESKTOP-HNPHR2I,1453;Network Library=DBMSSOCN;MultipleActiveResultSets=True;  initial catalog=deneme;User ID=sa;Password=1453"

            baglan.Open()
            bilgi.Text = "baglantı yapıldı."

        Catch ex As Exception
            bilgi.Text = "baglantı yok"

        End Try
        Veri()

    End Sub
    Sub Veri()
        cmd.Parameters.Clear()
        ds.Reset()
        cmd.CommandText = "select * from deneme"
        cmd.Connection = baglan
        adp.SelectCommand = cmd
        adp.Fill(ds, "veri")
        DataGridView1.DataSource = ds.Tables("veri")
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        baglan.Close()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Form2.Show()



    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        Form3.Label5.Text = DataGridView1.CurrentRow.Cells("id").Value
        Form3.urun.Text = DataGridView1.CurrentRow.Cells("urun").Value
        Form3.marka.Text = DataGridView1.CurrentRow.Cells("marka").Value
        Form3.agırlık.Text = DataGridView1.CurrentRow.Cells("agırlık").Value

        Form3.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        cmd.Parameters.Clear()
        cmd.CommandText = "delete from deneme  where id=@id"
        cmd.Connection = baglan
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = DataGridView1.CurrentRow.Cells("id").Value
        cmd.ExecuteNonQuery()
        Veri()


    End Sub
End Class
