Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1

    Private operationsCount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rnd As New Random()
        For i As Integer = 1 To 19
            ComboBox1.Items.Add(rnd.Next(1, 101))
        Next
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ComboBox1.BeginUpdate()
        Dim itemsArray As Integer() = ComboBox1.Items.OfType(Of Integer)().ToArray()
        Array.Sort(itemsArray)
        ComboBox1.Items.Clear()
        ComboBox1.Items.AddRange(Array.ConvertAll(itemsArray, Function(x) CObj(x)))
        ComboBox1.EndUpdate()
        Label1.Text = "Список відсортовано за зростанням"
        operationsCount += 1
        TextBox2.Text = operationsCount.ToString()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ComboBox1.Sorted = False
        Dim itemsList As List(Of Integer) = ComboBox1.Items.OfType(Of Integer)().ToList()
        itemsList.Sort()
        itemsList.Reverse()
        ComboBox1.Items.Clear()
        ComboBox1.Items.AddRange(Array.ConvertAll(itemsList.ToArray(), Function(x) CObj(x)))
        Label1.Text = "Список відсортовано за спаданням"
        operationsCount += 1
        TextBox2.Text = operationsCount.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer = 0
        For i As Integer = 0 To ComboBox1.Items.Count - 1
            If Convert.ToInt32(ComboBox1.Items(i)) Mod 2 = 0 Then
                sum += Convert.ToInt32(ComboBox1.Items(i))
            End If
        Next
        TextBox1.Text = (sum / 2).ToString()
        operationsCount += 1
        TextBox2.Text = operationsCount.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        ComboBox1.Items.Clear()
        operationsCount += 1
        TextBox2.Text = operationsCount.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class