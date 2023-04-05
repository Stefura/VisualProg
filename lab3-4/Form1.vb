Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Долар.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Гривня.TextChanged

    End Sub

    Private Sub Курс_TextChanged(sender As Object, e As EventArgs) Handles Курс.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    Private Sub Курс_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Курс.KeyPress
        Select Case Asc(e.KeyChar)
            Case 46, 48 To 57
            Case 13
                Call Pererahunok()
            Case Else
                e.KeyChar = ""
        End Select

    End Sub

    Private Sub Гривня_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Гривня.KeyPress
        Select Case Asc(e.KeyChar)
            Case 46, 48 To 57
            Case 13
                Call Pererahunok()
            Case Else
                e.KeyChar = ""
        End Select

    End Sub
    Private Sub Pererahunok()
        Долар.Text = Format(Val(Гривня.Text) / Val(Курс.Text), "######.##")
    End Sub

    Private Sub Вихід_Click(sender As Object, e As EventArgs) Handles Вихід.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Гривня.Text = ""
        Долар.Text = ""
        Курс.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
