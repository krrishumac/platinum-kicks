
Public Class frmLogin
    Inherits BaseForm

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()

        frmLanding.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        If txtUsername.Text = "" Or txtPassword.Text = "" Then

            MessageBox.Show("Please enter username and password.")
            Exit Sub

        End If

        Dim role As String

        role = DatabaseHelper.Login(
                txtUsername.Text,
                txtPassword.Text)

        If role = "" Then

            MessageBox.Show("Invalid Username or Password.")

        ElseIf role = "Admin" Then

            MessageBox.Show("Welcome Admin!")

            Me.Hide()

            frmAdminDashboard.Show()

        Else

            MessageBox.Show("Login Successful!")
            Me.Hide()

            frmShop.Show()

        End If

    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        Me.Hide()
        frmRegister.Show()
    End Sub
End Class