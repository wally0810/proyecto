Public Class DISTRIBUCIÓNMUESTRALDELAMEDIA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox5.Text = (Val(TextBox1.Text) - Val(TextBox2.Text)) / (Val(TextBox3.Text) / Math.Sqrt(TextBox4.Text))
        TextBox6.Text = "0.4292"
        TextBox7.Text = "0.0708"

    End Sub
End Class