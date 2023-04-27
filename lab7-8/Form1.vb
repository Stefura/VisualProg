Imports System.IO.Compression

Public Class Form1
    Dim i, j, c, s, temp As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 1 To 10
            c = Int(Rnd() * 100)
            Список.Items.Add(c)
        Next i
        Label1.Text = "Список заповнено"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        For i = 0 To Список.Items.Count - 1
            For j = i + 1 To Список.Items.Count - 1
                If Val(Список.Items(j)) < Val(Список.Items(i)) Then
                    temp = Val(Список.Items(i))
                    Список.Items(i) = Список.Items(j)
                    Список.Items(j) = temp
                End If
            Next
        Next
        Label1.Text = "Список відсортовано за зростанням"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        For i = 0 To Список.Items.Count - 1
            For j = i + 1 To Список.Items.Count - 1
                If Val(Список.Items(j)) > Val(Список.Items(i)) Then
                    temp = Val(Список.Items(i))
                    Список.Items(i) = Список.Items(j)
                    Список.Items(j) = temp
                End If
            Next
        Next
        Label1.Text = "Список відсортовано за спаданням"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        s = 0
        For i = 0 To Список.Items.Count - 1
            If Val(Список.Items(i)) Mod 2 = 0 Then
                s += Val(Список.Items(i))
            End If
        Next
        TextBox1.Text = s
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Список.Items.Clear()
        Список.Enabled = False
        TextBox1.Text = ""
        Label1.Text = "Масив з 10 елементів, розташованих випадковим чином"
    End Sub
End Class
