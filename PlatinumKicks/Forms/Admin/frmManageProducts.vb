Imports System.Data
Imports System.Drawing

Public Class frmManageProducts
    Inherits BaseForm
    Private Sub LoadProducts()


        dgvProducts.DataSource = DatabaseHelper.GetProducts()

        dgvProducts.Columns("image").Visible = False

        dgvProducts.Columns("product_id").HeaderText = "ID"
        dgvProducts.Columns("name").HeaderText = "Product"
        dgvProducts.Columns("brand").HeaderText = "Brand"
        dgvProducts.Columns("description").HeaderText = "Description"
        dgvProducts.Columns("price").HeaderText = "Price (₹)"
        dgvProducts.Columns("stock").HeaderText = "Stock"

        dgvProducts.DefaultCellStyle.ForeColor = Color.Black
        dgvProducts.DefaultCellStyle.BackColor = Color.White

        dgvProducts.ColumnHeadersDefaultCellStyle.Font =
            New Font("Segoe UI", 10, FontStyle.Bold)

        dgvProducts.ColumnHeadersDefaultCellStyle.BackColor =
            Color.FromArgb(45, 45, 45)

        dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor =
            Color.White

        dgvProducts.EnableHeadersVisualStyles = False

        dgvProducts.RowTemplate.Height = 35

        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvProducts.Columns("product_id").FillWeight = 15
        dgvProducts.Columns("name").FillWeight = 35
        dgvProducts.Columns("brand").FillWeight = 20
        dgvProducts.Columns("description").FillWeight = 45
        dgvProducts.Columns("price").FillWeight = 20
        dgvProducts.Columns("stock").FillWeight = 15



    End Sub
    Private Sub frmManageProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
        dgvProducts.Columns("image").Visible = False
    End Sub
    Public Sub RefreshProducts()

        LoadProducts()

    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        LoadProducts()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click


        If dgvProducts.SelectedRows.Count = 0 Then

            MessageBox.Show("Please select a product.")

            Exit Sub

        End If

        Dim id As Integer

        id = CInt(dgvProducts.SelectedRows(0).Cells("product_id").Value)

        If MessageBox.Show("Delete selected product?",
                       "Confirm",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) = DialogResult.Yes Then

            If DatabaseHelper.DeleteProduct(id) Then

                MessageBox.Show("Product Deleted.")

                LoadProducts()

            Else

                MessageBox.Show("Delete Failed.")

            End If

        End If


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click


        Me.Hide()

        frmAdminDashboard.Show()


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        If dgvProducts.SelectedRows.Count = 0 Then

            MessageBox.Show("Please select a product.")

            Exit Sub

        End If

        Dim id As Integer =
            CInt(dgvProducts.SelectedRows(0).Cells("product_id").Value)

        Dim productName As String =
            dgvProducts.SelectedRows(0).Cells("name").Value.ToString()

        Dim brand As String =
            dgvProducts.SelectedRows(0).Cells("brand").Value.ToString()

        Dim description As String =
            dgvProducts.SelectedRows(0).Cells("description").Value.ToString()

        Dim price As Decimal =
            CDec(dgvProducts.SelectedRows(0).Cells("price").Value)

        Dim stock As Integer =
            CInt(dgvProducts.SelectedRows(0).Cells("stock").Value)

        Dim image() As Byte =
            CType(dgvProducts.SelectedRows(0).Cells("image").Value, Byte())

        frmAddProduct.LoadProduct(
            id,
            productName,
            brand,
            description,
            price,
            stock,
            image)

        Me.Hide()

        frmAddProduct.Show()


    End Sub
End Class