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
        Lab1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        TextBox1 = New TextBox()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        MenuStrip1 = New MenuStrip()
        ЖовтийToolStripMenuItem = New ToolStripMenuItem()
        ЗеленийToolStripMenuItem = New ToolStripMenuItem()
        ФіолетовийToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Lab1
        ' 
        Lab1.Location = New Point(10, 26)
        Lab1.Name = "Lab1"
        Lab1.Size = New Size(679, 64)
        Lab1.TabIndex = 0
        Lab1.Text = "Де є життя, там є й надія"
        Lab1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(10, 93)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(99, 33)
        Button1.TabIndex = 1
        Button1.Text = "Розмір"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(115, 93)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 33)
        Button2.TabIndex = 2
        Button2.Text = "Шрифт"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(228, 93)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(108, 33)
        Button3.TabIndex = 3
        Button3.Text = "Вирівнювання"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(115, 171)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(456, 23)
        TextBox1.TabIndex = 4
        TextBox1.Text = "Я навчаюсь у К-ПНУ"' 
        ' Button4
        ' 
        Button4.Location = New Point(10, 234)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(99, 33)
        Button4.TabIndex = 5
        Button4.Text = "Розмір"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(115, 234)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(108, 33)
        Button5.TabIndex = 6
        Button5.Text = "Вирівнювання"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(228, 234)
        Button6.Margin = New Padding(3, 2, 3, 2)
        Button6.Name = "Button6"
        Button6.Size = New Size(108, 33)
        Button6.TabIndex = 7
        Button6.Text = "Переміщення"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ЖовтийToolStripMenuItem, ЗеленийToolStripMenuItem, ФіолетовийToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(700, 24)
        MenuStrip1.TabIndex = 8
        MenuStrip1.Text = "MenuStrip1"' 
        ' ЖовтийToolStripMenuItem
        ' 
        ЖовтийToolStripMenuItem.Name = "ЖовтийToolStripMenuItem"
        ЖовтийToolStripMenuItem.Size = New Size(62, 20)
        ЖовтийToolStripMenuItem.Text = "Жовтий"' 
        ' ЗеленийToolStripMenuItem
        ' 
        ЗеленийToolStripMenuItem.Name = "ЗеленийToolStripMenuItem"
        ЗеленийToolStripMenuItem.Size = New Size(66, 20)
        ЗеленийToolStripMenuItem.Text = "Зелений"' 
        ' ФіолетовийToolStripMenuItem
        ' 
        ФіолетовийToolStripMenuItem.Name = "ФіолетовийToolStripMenuItem"
        ФіолетовийToolStripMenuItem.Size = New Size(83, 20)
        ФіолетовийToolStripMenuItem.Text = "Фіолетовий"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(TextBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Lab1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lab1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ЖовтийToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЗеленийToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ФіолетовийToolStripMenuItem As ToolStripMenuItem
End Class
