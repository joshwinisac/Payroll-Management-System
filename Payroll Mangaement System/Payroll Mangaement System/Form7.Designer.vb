<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form7))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(323, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 20)
        Label1.TabIndex = 0
        Label1.Text = "Time And Attendance"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(139, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 20)
        Label2.TabIndex = 1
        Label2.Text = "TimeID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(139, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 2
        Label3.Text = "EmployeeID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(139, 220)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 3
        Label4.Text = "ClockIn"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(139, 256)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 4
        Label5.Text = "ClockOut"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(139, 292)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 20)
        Label6.TabIndex = 5
        Label6.Text = "Leave"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.MistyRose
        TextBox1.Location = New Point(315, 179)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(263, 27)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.MistyRose
        TextBox2.Location = New Point(315, 213)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(263, 27)
        TextBox2.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(344, 367)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 11
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.MistyRose
        TextBox4.Location = New Point(315, 285)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(263, 27)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.MistyRose
        TextBox3.Location = New Point(315, 249)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(263, 27)
        TextBox3.TabIndex = 8
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.MistyRose
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1001", "1002", "1003", "1004", "1005"})
        ComboBox1.Location = New Point(315, 137)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(261, 28)
        ComboBox1.TabIndex = 12
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form7"
        Text = "TimeAndAttendance "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
