Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form4

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joshwin Isac\OneDrive\Documents\employeedetails.mdf;Integrated Security=True"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        ' Get user input values
        Dim EmployeeId As String = TextBox1.Text
            Dim EnterPassword As String = TextBox2.Text

            ' Create a connection to the database
            Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joshwin Isac\OneDrive\Documents\employeedetails.mdf;Integrated Security=True"
        Using cn As New SqlConnection(connectionString)
            cn.Open()

            ' Insert the user's input values into the EmployeeLogin table
            Dim query As String = "INSERT INTO EmployeeLog(EmployeeID, [EnterPassword]) VALUES (@EmployeeId, @EnterPassword)"
            Using command As New SqlCommand(query, cn)
                command.Parameters.AddWithValue("@EmployeeId", EmployeeId)
                command.Parameters.AddWithValue("@EnterPassword", EnterPassword)
                command.ExecuteNonQuery()
            End Using
            cn.Close()
        End Using


        ' Display a message to the user indicating that the login was successful
        MessageBox.Show("Login successful!")
            Me.Hide()
            Dim empdet As New Form9
            MessageBox.Show("Successfully logged in")
            empdet.Show()


    End Sub
End Class