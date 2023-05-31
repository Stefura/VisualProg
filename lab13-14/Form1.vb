Public Class Form1
    Dim startTime As DateTime
    Dim countdownInterval As Integer = 30

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Multiline = True '
        TextBox1.ScrollBars = ScrollBars.Vertical
        startTime = DateTime.Now
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim timeLeft As TimeSpan = TimeSpan.FromSeconds(countdownInterval) - (DateTime.Now - startTime)
        If timeLeft.TotalSeconds <= 0 Then
            Timer1.Stop()
            MessageBox.Show("Час вичерпано. Програма завершує роботу.")
            Me.Close()
        Else
            Label1.Text = "Поточний час: " & DateTime.Now.ToString("HH:mm:ss")
            Label2.Text = "Зворотний відлік: " & timeLeft.ToString("mm\:ss")
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.Shift Then
            Select Case e.KeyCode
                Case Keys.D3 ' Shift + 3
                    MessageBox.Show("Програму розробив студент групи KN1-B21 - Стефура Юрій Олегович")
            End Select
        Else
            Select Case e.KeyCode
                Case Keys.F11
                    MessageBox.Show("день тижня")
                Case Keys.F12
                    MessageBox.Show("місто Одеса")
                Case Keys.F1
                    MessageBox.Show("Україна")
                Case Keys.F2
                    MessageBox.Show("національність")
                Case Keys.F3
                    MessageBox.Show("Академія зв’язку")
                Case Keys.F4
                    MessageBox.Show("комп'ютер")
                Case Keys.F5
                    MessageBox.Show("Internet")
                Case Keys.F6
                    MessageBox.Show("понеділок")
                Case Keys.F7
                    MessageBox.Show("Microsoft Access")
                Case Keys.F8
                    MessageBox.Show("вівторок")
            End Select
        End If
    End Sub

End Class




