Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()

        Const Mx As Integer = 327
        Dim i As Integer, Sum As Integer
        i = 0 : Sum = 0
        Do
            i = i + 1
            Sum = Sum + (i ^ 2)
            ListBox1.Items.Add("i: " & i & ", Sum: " & Sum)
        Loop While Sum < Mx - (i ^ 2)

        Label1.Text = "i: " & i
        Label2.Text = "Sum: " & Sum

    End Sub



End Class
