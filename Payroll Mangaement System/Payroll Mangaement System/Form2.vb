Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.ComponentModel.DataAnnotations

Public Class Form2
    Private connection As Object

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim selectedEmployeeID As Integer = Convert.ToInt32(ComboBox1.SelectedItem)

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joshwin Isac\OneDrive\Documents\employeedetails.mdf;Integrated Security=True"
        Dim query As String = "SELECT EmployeeName, EmployeeAddress, EmployeePhone ,EmployeeEmail,Dept_name FROM Employees WHERE EmployeeID = @EmployeeID"

        Using cn As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, cn)
                command.Parameters.AddWithValue("@EmployeeID", selectedEmployeeID)
                cn.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    TextBox1.Text = reader.GetString(0)
                    TextBox2.Text = reader.GetString(1)
                    TextBox3.Text = reader.GetString(2)
                    TextBox4.Text = reader.GetString(3)
                    TextBox5.Text = reader.GetString(4)

                End If

                reader.Close()
            End Using
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sal As New Form5
        sal.Show()
        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pay As New Form6
        pay.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim time As New Form7
        time.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ben As New Form8
        ben.Show()
        Me.Hide()
    End Sub


End Class