Public Class Form1
    Dim lastPoint As Point

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            Dim g As Graphics = Me.CreateGraphics()
            Dim pen As New Pen(Color.Black)

            If lastPoint <> Nothing Then
                g.DrawLine(pen, lastPoint, e.Location)
            End If

            lastPoint = e.Location
            g.Dispose()
        End If
    End Sub
End Class
