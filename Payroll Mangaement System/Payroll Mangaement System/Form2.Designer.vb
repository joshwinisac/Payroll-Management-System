<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Button1 = New Button()
        FontDialog1 = New FontDialog()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        ComboBox1 = New ComboBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        TextBox5 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightGreen
        Button1.Location = New Point(101, 354)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.Text = "Salary"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(356, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 20)
        Label1.TabIndex = 1
        Label1.Text = "Employee Details"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.LemonChiffon
        Label2.Location = New Point(100, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 20)
        Label2.TabIndex = 2
        Label2.Text = "Employee ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.LemonChiffon
        Label3.Location = New Point(100, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 20)
        Label3.TabIndex = 3
        Label3.Text = "EmployeeName"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.LemonChiffon
        Label4.Location = New Point(101, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 20)
        Label4.TabIndex = 4
        Label4.Text = "EmployeeAddress"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.LemonChiffon
        Label5.Location = New Point(100, 215)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 20)
        Label5.TabIndex = 5
        Label5.Text = "EmployeePhone"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.LemonChiffon
        Label6.Location = New Point(101, 246)
        Label6.Name = "Label6"
        Label6.Size = New Size(112, 20)
        Label6.TabIndex = 6
        Label6.Text = "EmployeeEmail"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.LemonChiffon
        Label7.Location = New Point(101, 276)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 20)
        Label7.TabIndex = 7
        Label7.Text = "Dept_name"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AllowDrop = True
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"101", "102", "103", "104", "105"})
        ComboBox1.Location = New Point(256, 108)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(387, 28)
        ComboBox1.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(256, 176)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(387, 27)
        TextBox2.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(256, 209)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(387, 27)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(256, 242)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(387, 27)
        TextBox4.TabIndex = 13
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightGreen
        Button2.Location = New Point(256, 354)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 16
        Button2.Text = "Payroll"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.LightGreen
        Button3.Location = New Point(610, 354)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 17
        Button3.Text = "Benefits "
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.LightGreen
        Button4.Location = New Point(395, 354)
        Button4.Name = "Button4"
        Button4.Size = New Size(202, 29)
        Button4.TabIndex = 18
        Button4.Text = "TimeandAttendance "
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(256, 143)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(387, 27)
        TextBox1.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(256, 273)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(387, 27)
        TextBox5.TabIndex = 14
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Employee Details"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox5 As TextBox
End Class
