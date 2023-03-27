Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Data.SqlClient
Imports System.Collections.ObjectModel

Public Class Form8

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim selectedBenefitsID As Integer = Convert.ToInt32(ComboBox1.SelectedItem)

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joshwin Isac\OneDrive\Documents\employeedetails.mdf;Integrated Security=True"
        Dim query As String = "SELECT EmployeeID,BenefitsType,EnrollmentDate,ExpirationDate,BenefitsAmount FROM benefits WHERE BenefitsID = @BenefitsID"

        Using cn As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, cn)
                command.Parameters.AddWithValue("@BenefitsID", selectedBenefitsID)
                cn.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    TextBox1.Text = reader.GetString(0)
                    TextBox2.Text = reader.GetString(1)
                    DateTimePicker1.Value = reader.GetDateTime(2)
                    DateTimePicker2.Value = reader.GetDateTime(3)
                    TextBox3.Text = reader.GetString(4)
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