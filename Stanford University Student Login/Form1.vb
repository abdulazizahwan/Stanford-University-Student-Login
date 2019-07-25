Public Class Form1
    Private Sub txtIDNumber_MouseEnter(sender As Object, e As EventArgs) Handles txtIDNumber.MouseEnter
        Dim colorText As Color
        colorText = Color.FromArgb(54, 60, 72)
        If txtIDNumber.Text = "Student ID Number" Then
            txtIDNumber.Text = ""
            txtIDNumber.ForeColor = colorText
        End If
    End Sub

    Private Sub txtIDNumber_MouseLeave(sender As Object, e As EventArgs) Handles txtIDNumber.MouseLeave
        Dim colorHint As Color
        colorHint = Color.FromArgb(118, 132, 158)
        If txtIDNumber.Text = "" Then
            txtIDNumber.Text = "Student ID Number"
            txtIDNumber.ForeColor = colorHint
        End If
    End Sub

    Private Sub txtPassword_MouseEnter(sender As Object, e As EventArgs) Handles txtPassword.MouseEnter
        Dim colorText As Color
        colorText = Color.FromArgb(54, 60, 72)
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "*"
            txtPassword.ForeColor = colorText
        End If
    End Sub

    Private Sub txtPassword_MouseLeave(sender As Object, e As EventArgs) Handles txtPassword.MouseLeave
        Dim colorHint As Color
        colorHint = Color.FromArgb(118, 132, 158)
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.PasswordChar = ""
            txtPassword.ForeColor = colorHint
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        Dim Form2 As New Form2
        Form2.Show()
    End Sub
End Class
