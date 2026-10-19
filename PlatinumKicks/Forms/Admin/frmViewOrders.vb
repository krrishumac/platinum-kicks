Imports System.Data
Public Class frmViewOrders
    Inherits BaseForm
    Private Sub LoadOrders()



        dgvOrders.DataSource = DatabaseHelper.GetOrders()

        dgvOrders.DefaultCellStyle.ForeColor = Color.Black
        dgvOrders.DefaultCellStyle.BackColor = Color.White

        dgvOrders.ColumnHeadersDefaultCellStyle.Font =
            New Font("Segoe UI", 10, FontStyle.Bold)

        dgvOrders.ColumnHeadersDefaultCellStyle.BackColor =
            Color.FromArgb(45, 45, 45)

        dgvOrders.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        dgvOrders.EnableHeadersVisualStyles = False

        dgvOrders.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        dgvOrders.RowTemplate.Height = 35



    End Sub
    Private Sub frmViewOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LoadOrders()

    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click


        Hide()

        frmAdminDashboard.Show()

    End Sub

    Private Sub dgvOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrders.CellContentClick

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadOrders()

        MessageBox.Show("Orders refreshed successfully.")
    End Sub
End Class