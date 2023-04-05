Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Lab1.Font = New Font("Times New Roman", 25)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lab1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Lab1.Font = New Font("Arial", 25)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Lab1.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Font = New Font("", 30)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.TextAlign = LeftRightAlignment.Right
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Top = 200
        TextBox1.Left = 220
    End Sub

    Private Sub ЖовтийToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЖовтийToolStripMenuItem.Click
        Me.BackColor = Color.Yellow
    End Sub

    Private Sub ЗеленийToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗеленийToolStripMenuItem.Click
        Lab1.BackColor = Color.Green
    End Sub

    Private Sub ФіолетовийToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ФіолетовийToolStripMenuItem.Click
        TextBox1.BackColor = Color.Purple
    End Sub
End Class
