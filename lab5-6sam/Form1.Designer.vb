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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Per = New Button()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(129, 140)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(75, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(247, 140)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(74, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(351, 140)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(75, 23)
        TextBox3.TabIndex = 2
        ' 
        ' Per
        ' 
        Per.Location = New Point(214, 201)
        Per.Name = "Per"
        Per.Size = New Size(140, 67)
        Per.TabIndex = 3
        Per.Text = "Перевірити"
        Per.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.IndianRed
        Label1.Location = New Point(181, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 28)
        Label1.TabIndex = 5
        Label1.Text = "Послідовність чисел"' 
        ' Button1
        ' 
        Button1.Location = New Point(214, 371)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 67)
        Button1.TabIndex = 6
        Button1.Text = "Завершити"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(214, 283)
        Button2.Name = "Button2"
        Button2.Size = New Size(140, 67)
        Button2.TabIndex = 7
        Button2.Text = "Очищення"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(531, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(Per)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Per As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
