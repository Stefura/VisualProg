Public Class Form1
    Private Sub Per_Click(sender As Object, e As EventArgs) Handles Per.Click
        Dim num1, num2, num3 As Integer

        If Not Integer.TryParse(TextBox1.Text, num1) Then
            MessageBox.Show("Введіть коректне перше число!", "Помилка")
            TextBox1.Focus()
            Exit Sub
        End If

        If Not Integer.TryParse(TextBox2.Text, num2) Then
            MessageBox.Show("Введіть коректне друге число!", "Помилка")
            TextBox2.Focus()
            Exit Sub
        End If

        If Not Integer.TryParse(TextBox3.Text, num3) Then
            MessageBox.Show("Введіть коректне третє число!", "Помилка")
            TextBox3.Focus()
            Exit Sub
        End If

        If num1 < num2 AndAlso num2 < num3 Then
            MessageBox.Show("Числова послідовність, що збільшується!", "Результат")
        ElseIf num1 > num2 AndAlso num2 > num3 Then
            MessageBox.Show("Числова послідовність, що зменшується!", "Результат")
        Else
            MessageBox.Show("Невизначена числова послідовність!", "Результат")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
End Class
