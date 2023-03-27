Imports System.Data.SqlClient
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form5

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim selectedSalaryID As Integer = Convert.ToInt32(ComboBox1.SelectedItem)

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joshwin Isac\OneDrive\Documents\employeedetails.mdf;Integrated Security=True"
        Dim query As String = "SELECT EmployeeId, SalaryAmount, Dept_name, SalaryDate FROM Salary WHERE SalaryID = @SalaryID"

        Using cn As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, cn)
                command.Parameters.AddWithValue("@SalaryID", selectedSalaryID)
                cn.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    TextBox1.Text = reader.GetString(0)
                    TextBox2.Text = reader.GetDecimal(1)
                    TextBox3.Text = reader.GetString(2)
                    TextBox4.Text = reader.GetDateTime(3).ToString("yyyy-MM-dd") ' convert the datetime value to string in a specific format
                End If

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim form2 As New Form2
        form2.Show()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class