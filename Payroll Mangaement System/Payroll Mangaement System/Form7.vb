Imports System.Data.SqlClient

Public Class Form7


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim selectedTimeID As Integer = Convert.ToInt32(ComboBox1.SelectedItem)

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joshwin Isac\OneDrive\Documents\employeedetails.mdf;Integrated Security=True"
        Dim query As String = "SELECT EmployeeId,ClockIn, ClockOut,leave  FROM TimeAndAttendance WHERE TimeID= @TimeID"

        Using cn As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, cn)
                command.Parameters.AddWithValue("@TimeID", selectedTimeID)
                cn.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    TextBox1.Text = reader.GetString(0)
                    TextBox2.Text = reader.GetTimeSpan(1).ToString()
                    TextBox3.Text = reader.GetTimeSpan(2).ToString()
                    TextBox4.Text = reader.GetDecimal(3).ToString()
                End If

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim home As New Form2
        home.Show()
        Me.Hide()
    End Sub
End Class