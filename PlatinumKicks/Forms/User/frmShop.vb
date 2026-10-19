Imports System.IO
Imports System.Linq

Public Class frmShop
    Inherits BaseForm

    Private Sub LoadProducts()

        dgvProducts.DataSource = DatabaseHelper.GetProducts()

        dgvProducts.Columns("description").DefaultCellStyle.WrapMode =
    DataGridViewTriState.True

        dgvProducts.Columns("description").Width = 300

        dgvProducts.AutoSizeRowsMode =
    DataGridViewAutoSizeRowsMode.AllCells

        If dgvProducts.Columns.Contains("image") Then
            dgvProducts.Columns("image").Visible = False
        End If

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

        dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        dgvProducts.EnableHeadersVisualStyles = False

        dgvProducts.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill

        dgvProducts.RowTemplate.Height = 35

    End Sub

    Private Sub frmShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadProducts()

        lblProductName.Text = "-"
        lblPriceValue.Text = "₹0"

        nudQuantity.Value = 1

        picProduct.Image = Nothing

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picProduct.Click

    End Sub

Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)

        lblProductName.Text = row.Cells("name").Value.ToString()

        lblPriceValue.Text =
            "₹" & Convert.ToDecimal(row.Cells("price").Value).ToString("N2")

        If Not IsDBNull(row.Cells("image").Value) Then

            Dim imageBytes() As Byte =
                CType(row.Cells("image").Value, Byte())

            Using ms As New MemoryStream(imageBytes)

                Using tempImage As Image = Image.FromStream(ms)

                    picProduct.Image = New Bitmap(tempImage)

                End Using

            End Using

        Else

            picProduct.Image = Nothing

        End If

    End Sub

    Private Sub nudQuantity_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity.ValueChanged

    End Sub

    Private Sub btnAddToCart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddToCart.Click

        If dgvProducts.CurrentRow Is Nothing Then

            MessageBox.Show("Please select a product.")

            Exit Sub

        End If

        Dim row As DataGridViewRow = dgvProducts.CurrentRow

        If row.IsNewRow Then

            MessageBox.Show("Please select a product.")

            Exit Sub

        End If

        Dim productID As Integer =
            CInt(row.Cells("product_id").Value)

        Dim productName As String =
            row.Cells("name").Value.ToString()

        Dim price As Decimal =
            CDec(row.Cells("price").Value)

        Dim stock As Integer =
            CInt(row.Cells("stock").Value)

        Dim quantity As Integer =
            CInt(nudQuantity.Value)

        If stock <= 0 Then

            MessageBox.Show("This product is out of stock.")

            Exit Sub

        End If

        If quantity > stock Then

            MessageBox.Show("Not enough stock available.")

            Exit Sub

        End If

        Dim existingItem As CartItem = Nothing

        For Each item As CartItem In CartManager.Cart

            If item.ProductID = productID Then

                existingItem = item

                Exit For

            End If

        Next

        If existingItem IsNot Nothing Then

            If existingItem.Quantity + quantity > stock Then

                MessageBox.Show("Not enough stock available.")

                Exit Sub

            End If

            existingItem.Quantity += quantity

        Else

            CartManager.Cart.Add(
                New CartItem With {
                    .ProductID = productID,
                    .ProductName = productName,
                    .Price = price,
                    .Quantity = quantity
                })

        End If

        MessageBox.Show(
            productName & " added to cart!",
            "Cart",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadProducts()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        CartManager.Cart.Clear()

        Me.Hide()

        frmLogin.Show()
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Me.Hide()

        frmCart.Show()
    End Sub

    Private Sub frmShop_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        LoadProducts()

        dgvProducts.ClearSelection()

        lblProductName.Text = "-"
        lblPriceValue.Text = "₹0"

        nudQuantity.Value = 1

        picProduct.Image = Nothing

    End Sub

End Class