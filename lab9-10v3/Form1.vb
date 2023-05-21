Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim newline, space As String
            Dim x, xp, xk, dx As Single
            Dim y As Double
            xp = Val(TextBox1.Text)
            xk = Val(TextBox2.Text)
            dx = Val(TextBox3.Text)
            newline = Chr(13) + Chr(10)
            space = Chr(9)
            RichTextBox1.Text = " x" + space + " y" + newline
            For x = xp To xk Step dx
                y = x ^ 2 + 10
                RichTextBox1.Text = RichTextBox1.Text + Str(Format$(x, "0.000")) + space + Str(Format$(y, "0.0000")) + newline
            Next
        End Sub


End Class
