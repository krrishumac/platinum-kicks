
Public Class frmRegister
    Inherits BaseForm
    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If txtFullName.Text = "" Or
       txtUsername.Text = "" Or
       txtEmail.Text = "" Or
       txtPassword.Text = "" Or
       txtConfirmPassword.Text = "" Then

            MessageBox.Show("Please fill all fields.")
            Exit Sub

        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then

            MessageBox.Show("Passwords do not match.")
            Exit Sub

        End If

        If DatabaseHelper.UsernameExists(txtUsername.Text) Then

            MessageBox.Show("Username already exists.")
            Exit Sub

        End If

        If DatabaseHelper.EmailExists(txtEmail.Text) Then

            MessageBox.Show("Email already exists.")
            Exit Sub

        End If

        If DatabaseHelper.RegisterUser(
        txtFullName.Text,
        txtUsername.Text,
        txtEmail.Text,
        txtPassword.Text) Then

            MessageBox.Show("Registration Successful!")

            Me.Hide()
            frmLogin.Show()

        Else

            MessageBox.Show("Registration Failed.")

        End If

    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
        txtConfirmPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmLanding.Show()
    End Sub

    Private Sub lnkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLogin.LinkClicked
        Me.Hide()
        frmLogin.Show()

    End Sub
End Class