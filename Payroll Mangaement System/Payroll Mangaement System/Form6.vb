Imports System.Data.SqlClient


Public Class Form6
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim selectedPayrollID As Integer = Convert.ToInt32(ComboBox1.SelectedItem)

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joshwin Isac\OneDrive\Documents\employeedetails.mdf;Integrated Security=True"
        Dim query As String = "SELECT EmployeeId, GrossPay, Deductions,NetPay,PaymentMethod FROM Payroll WHERE PayrollID = @PayrollID"

        Using cn As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, cn)
                command.Parameters.AddWithValue("@PayrollID", selectedPayrollID)
                cn.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    TextBox1.Text = reader.GetString(0)
                    TextBox2.Text = reader.GetDecimal(1)
                    TextBox3.Text = reader.GetDecimal(2)
                    TextBox4.Text = reader.GetDecimal(3)
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