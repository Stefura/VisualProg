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
        Цельсій = New TextBox()
        Фаренгейт = New TextBox()
        Вихід = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(110, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 21)
        Label1.TabIndex = 0
        Label1.Text = "Температура в градусах по Цельсію"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(401, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(291, 21)
        Label2.TabIndex = 1
        Label2.Text = "Температура в градусах по Фаренгейту"' 
        ' Цельсій
        ' 
        Цельсій.Location = New Point(158, 149)
        Цельсій.Multiline = True
        Цельсій.Name = "Цельсій"
        Цельсій.Size = New Size(157, 38)
        Цельсій.TabIndex = 2
        ' 
        ' Фаренгейт
        ' 
        Фаренгейт.Location = New Point(467, 149)
        Фаренгейт.Multiline = True
        Фаренгейт.Name = "Фаренгейт"
        Фаренгейт.Size = New Size(157, 38)
        Фаренгейт.TabIndex = 3
        ' 
        ' Вихід
        ' 
        Вихід.Location = New Point(299, 274)
        Вихід.Name = "Вихід"
        Вихід.Size = New Size(133, 70)
        Вихід.TabIndex = 4
        Вихід.Text = "Вихід"
        Вихід.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(101, 297)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 78)
        Button1.TabIndex = 5
        Button1.Text = "Очищення"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(Вихід)
        Controls.Add(Фаренгейт)
        Controls.Add(Цельсій)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Цельсій As TextBox
    Friend WithEvents Фаренгейт As TextBox
    Friend WithEvents Вихід As Button
    Friend WithEvents Button1 As Button
End Class
