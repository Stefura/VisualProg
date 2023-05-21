Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim costPerKWh As Double = Double.Parse(TextBox1.Text)
        Dim initialReadings As Double = Double.Parse(TextBox2.Text)
        Dim currentReadings As Double = Double.Parse(TextBox3.Text)


        Dim energyConsumed As Double = currentReadings - initialReadings
        Dim totalPayment As Double = costPerKWh * energyConsumed


        Label4.Text = "Сума оплати: " & totalPayment.ToString("0.00")
        Label5.Text = "Спожита енергія: " & energyConsumed.ToString("0.00") & " кВт-год"
    End Sub

End Class
