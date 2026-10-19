Public Class frmAdminDashboard
    Inherits BaseForm
    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click


        Me.Hide()

        frmAddProduct.Show()


    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click


        Me.Hide()

        frmLogin.Show()

    End Sub

    Private Sub btnManageProducts_Click(sender As Object, e As EventArgs) Handles btnManageProducts.Click
        Me.Hide()

        frmManageProducts.Show()
    End Sub

    Private Sub btnViewOrders_Click(sender As Object, e As EventArgs) Handles btnViewOrders.Click


        Me.Hide()

        frmViewOrders.Show()


    End Sub
End Class