Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label1.Click, Label1.Click, Label1.Click, Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Фаренгейт_TextChanged(sender As Object, e As EventArgs) Handles Фаренгейт.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label2.Click

    End Sub
    Private Sub Цельсій_TextChanged(sender As Object, e As EventArgs) Handles Цельсій.TextChanged

    End Sub
    Private Sub Цельсій_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Цельсій.KeyPress
            Select Case Asc(e.KeyChar)
                Case 46, 48 To 57
                Case 13
                    Pererahunok()
                Case Else
                    e.KeyChar = ""
            End Select
        End Sub

        Private Sub Pererahunok()
            Dim celsius As Double = Val(Цельсій.Text)
            Dim fahrenheit As Double = celsius * 1.8 + 32
            Фаренгейт.Text = Format(fahrenheit, "0.##")
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Цельсій.Text = ""
            Фаренгейт.Text = ""
        End Sub

        Private Sub Вихід_Click(sender As Object, e As EventArgs) Handles Вихід.Click
            End
        End Sub
    End Class
