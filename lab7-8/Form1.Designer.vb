<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Список = New ComboBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        TextBox1 = New TextBox()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(417, 21)
        Label1.TabIndex = 0
        Label1.Text = "Масив з 10 елементів, розташованих випадковим чином"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(25, 272)
        Label2.Name = "Label2"
        Label2.Size = New Size(282, 25)
        Label2.TabIndex = 1
        Label2.Text = "Значення суми парних елементів"' 
        ' Button1
        ' 
        Button1.Location = New Point(90, 370)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 40)
        Button1.TabIndex = 2
        Button1.Text = "Розрахунок"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(245, 370)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 40)
        Button2.TabIndex = 3
        Button2.Text = "Спочатку"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(397, 370)
        Button3.Name = "Button3"
        Button3.Size = New Size(102, 40)
        Button3.TabIndex = 4
        Button3.Text = "Вихід"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Список
        ' 
        Список.FormattingEnabled = True
        Список.Location = New Point(435, 50)
        Список.Name = "Список"
        Список.Size = New Size(121, 23)
        Список.TabIndex = 5
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(72, 137)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(172, 19)
        RadioButton1.TabIndex = 6
        RadioButton1.TabStop = True
        RadioButton1.Text = "Сортування за зростанням"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(72, 186)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(167, 19)
        RadioButton2.TabIndex = 7
        RadioButton2.TabStop = True
        RadioButton2.Text = "Сортування за спаданням"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(421, 274)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 9
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(207, 328)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 10
        Button4.Text = "Очистити"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(605, 450)
        Controls.Add(Button4)
        Controls.Add(TextBox1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Список)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Список As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
End Class
