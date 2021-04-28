Public Class Ladistribuciónmuestraldeproporciones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        r1txt.Text = Math.Sqrt(Val(ptxt.Text) * (1 - Val(ptxt.Text)) / Val(ntxt.Text))

        TextBox1.Text = ((Val(TextBox2.Text) - Val(ptxt.Text)) / Val(r1txt.Text))

        TextBox3.Text = 1 - 0.9957
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class