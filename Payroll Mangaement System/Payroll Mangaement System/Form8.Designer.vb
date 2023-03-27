<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form8))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Label7 = New Label()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(354, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 20)
        Label1.TabIndex = 0
        Label1.Text = "Benefits"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(161, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 20)
        Label2.TabIndex = 1
        Label2.Text = "BenefitsID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(161, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 20)
        Label3.TabIndex = 2
        Label3.Text = "EmployeeID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(160, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 20)
        Label4.TabIndex = 3
        Label4.Text = "BenefitsType"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(160, 276)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 20)
        Label5.TabIndex = 4
        Label5.Text = "EnrollmentDate"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(160, 326)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 20)
        Label6.TabIndex = 5
        Label6.Text = "ExpirationDate"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.ActiveCaption
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"123", "234", "345", "456", "567"})
        ComboBox1.Location = New Point(341, 127)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(247, 28)
        ComboBox1.TabIndex = 6
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ActiveCaption
        TextBox1.Location = New Point(341, 172)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(247, 27)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ActiveCaption
        TextBox2.Location = New Point(341, 218)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(247, 27)
        TextBox2.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Location = New Point(497, 409)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 11
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(160, 365)
        Label7.Name = "Label7"
        Label7.Size = New Size(125, 20)
        Label7.TabIndex = 12
        Label7.Text = "BenefitsAmount"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarForeColor = SystemColors.ActiveCaption
        DateTimePicker1.CalendarMonthBackground = SystemColors.InactiveCaption
        DateTimePicker1.Location = New Point(341, 276)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 14
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarForeColor = SystemColors.ActiveCaption
        DateTimePicker2.Location = New Point(341, 321)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(250, 27)
        DateTimePicker2.TabIndex = 15
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ActiveCaption
        TextBox3.Location = New Point(341, 358)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(247, 27)
        TextBox3.TabIndex = 16
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox3)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form8"
        Text = "benefits"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
End Class
