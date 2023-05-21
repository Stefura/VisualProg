Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Dim p(11) As Point
        Dim a As Integer
        Dim i As Integer
        Const pi As Double = 3.14159265
        Const r As Integer = 10
        a = 18
        For i = 1 To 10
            If (i Mod 2 = 0) Then
                p(i).X = e.X + Math.Round(r / 2.75 * Math.Cos(a * 2 * pi / 360))
                p(i).Y = e.Y - Math.Round(r / 2.75 * Math.Sin(a * 2 * pi / 360))
            Else
                p(i).X = e.X + Math.Round(r * Math.Cos(a * 2 * pi / 360))
                p(i).Y = e.Y - Math.Round(r * Math.Sin(a * 2 * pi / 360))
            End If
            a = a + 36
        Next i
        p(11).X = p(1).X : p(11).Y = p(1).Y
        Dim g As Graphics = Me.CreateGraphics()
        Dim penColor As Pen
        Select Case e.Button
            Case MouseButtons.Left
                penColor = Pens.Blue
            Case MouseButtons.Right
                penColor = Pens.Red
            Case Else
                Return
        End Select
        For i = 1 To 10
            g.DrawLine(penColor, p(i).X, p(i).Y, p(i + 1).X, p(i + 1).Y)
        Next i
        g.Dispose()

    End Sub


End Class
