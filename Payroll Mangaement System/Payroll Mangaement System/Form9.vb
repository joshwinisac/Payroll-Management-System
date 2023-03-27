Public Class Form9

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim login As New Login
        login.Show()
    End Sub
End Class