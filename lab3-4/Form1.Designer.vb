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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Вихід = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Гривня = New TextBox()
        Долар = New TextBox()
        Курс = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Вихід
        ' 
        Вихід.Location = New Point(298, 295)
        Вихід.Name = "Вихід"
        Вихід.Size = New Size(129, 64)
        Вихід.TabIndex = 0
        Вихід.Text = "Вихід"
        Вихід.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(125, 341)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 65)
        Button1.TabIndex = 1
        Button1.Text = "Очищення"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(319, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 15)
        Label1.TabIndex = 2
        Label1.Text = "Курс долара до гривні"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(174, 199)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 15)
        Label2.TabIndex = 3
        Label2.Text = "Сума в грвнях"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(456, 199)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 15)
        Label3.TabIndex = 4
        Label3.Text = "Сума в доларах"' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-3, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(801, 451)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Гривня
        ' 
        Гривня.Location = New Point(174, 229)
        Гривня.Name = "Гривня"
        Гривня.Size = New Size(100, 23)
        Гривня.TabIndex = 6
        ' 
        ' Долар
        ' 
        Долар.Location = New Point(449, 229)
        Долар.Name = "Долар"
        Долар.Size = New Size(100, 23)
        Долар.TabIndex = 7
        ' 
        ' Курс
        ' 
        Курс.Location = New Point(327, 160)
        Курс.Name = "Курс"
        Курс.Size = New Size(100, 23)
        Курс.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Курс)
        Controls.Add(Долар)
        Controls.Add(Гривня)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Вихід)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Вихід As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Гривня As TextBox
    Friend WithEvents Долар As TextBox
    Friend WithEvents Курс As TextBox
End Class
