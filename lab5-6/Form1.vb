Imports System.Buffers

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Int(Rnd() * 10) + 1
        TextBox2.Text = Int(Rnd() * 10) + 1
        TextBox3.Text = ""
        Rez.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Val(TextBox1.Text) * Val(TextBox2.Text) = TextBox3.Text) Then
            Rez.Text = "Вірно"
        Else
            Rez.Text = "Невірно"
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 13
                If (Val(TextBox1.Text) * Val(TextBox2.Text) = TextBox3.Text) Then
                    Rez.Text = "Вірно"
                Else
                    Rez.Text = "Невірно"
                End If
            Case Else
                e.KeyChar = ""
        End Select
    End Sub
End Class
