Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim i As Integer
        For i = 0 To 100 Step 20
            ListBox1.Items.Add(i)
        Next i
    End Sub

End Class
