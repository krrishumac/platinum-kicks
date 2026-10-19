Public Class frmLanding
    Inherits BaseForm
    Private Sub lblSubtitle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblSubtitle.Click

    End Sub

    Private Sub frmLanding_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub btnRegister_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        frmRegister.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub pnlRight_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pnlRight.Paint

    End Sub
End Class
