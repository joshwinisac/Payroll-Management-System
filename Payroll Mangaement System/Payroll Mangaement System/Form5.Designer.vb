<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form5))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Label4 = New Label()
        ComboBox1 = New ComboBox()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ScrollBar
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(337, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Salary"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(116, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 1
        Label2.Text = "SalaryID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(107, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 2
        Label3.Text = "EmployeeID"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(435, 168)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(170, 27)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(435, 220)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(170, 27)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(435, 272)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(170, 27)
        TextBox3.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(107, 270)
        Button1.Name = "Button1"
        Button1.Size = New Size(198, 29)
        Button1.TabIndex = 8
        Button1.Text = "salary computed"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(107, 227)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 20)
        Label4.TabIndex = 11
        Label4.Text = "Dept_name"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"11", "12", "13", "14", "15"})
        ComboBox1.Location = New Point(436, 104)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(169, 28)
        ComboBox1.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(116, 368)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 20)
        Label5.TabIndex = 14
        Label5.Text = "SalaryDate"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(435, 361)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(170, 27)
        TextBox4.TabIndex = 15
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(315, 409)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 27
        Button3.Text = "back"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "salary"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button3 As Button
End Class
