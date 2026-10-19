Imports System.Data
Imports System.Linq
Public Class frmCart
    Inherits BaseForm

    Private Sub LoadCart()

        Dim dt As New DataTable()

        dt.Columns.Add("Product")
        dt.Columns.Add("Price")
        dt.Columns.Add("Quantity")
        dt.Columns.Add("Total")

        Dim grandTotal As Decimal = 0

        For Each item As CartItem In CartManager.Cart

            dt.Rows.Add(
            item.ProductName,
            item.Price.ToString("N2"),
            item.Quantity,
            item.Total.ToString("N2")
        )

            grandTotal += item.Total

        Next

        dgvCart.DataSource = dt

        dgvCart.DefaultCellStyle.ForeColor = Color.Black
        dgvCart.DefaultCellStyle.BackColor = Color.White

        dgvCart.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        dgvCart.AlternatingRowsDefaultCellStyle.BackColor = Color.White

        dgvCart.RowsDefaultCellStyle.ForeColor = Color.Black
        dgvCart.RowsDefaultCellStyle.BackColor = Color.White

        lblTotal.Text = "₹" & grandTotal.ToString("N2")

    End Sub

    Private Sub frmCart_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load



        LoadCart()

        txtUPI.Visible = False
        lblUPI.Visible = False

        txtCardNumber.Visible = False
        lblCardNumber.Visible = False

        txtExpiry.Visible = False
        lblExpiry.Visible = False

        txtCVV.Visible = False
        lblCVV.Visible = False

    End Sub
    Private Sub frmCart_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated

        LoadCart()

    End Sub


    Private Sub cmbPayment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbPayment.SelectedIndexChanged



        lblUPI.Visible = False
        txtUPI.Visible = False

        lblCardNumber.Visible = False
        txtCardNumber.Visible = False

        lblExpiry.Visible = False
        txtExpiry.Visible = False

        lblCVV.Visible = False
        txtCVV.Visible = False

        If cmbPayment.Text = "UPI" Then

            lblUPI.Visible = True
            txtUPI.Visible = True


        ElseIf cmbPayment.Text.Contains("Card") Then

            lblCardNumber.Visible = True
            txtCardNumber.Visible = True

            lblExpiry.Visible = True
            txtExpiry.Visible = True

            lblCVV.Visible = True
            txtCVV.Visible = True

        End If


    End Sub

    Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemove.Click


        If dgvCart.SelectedRows.Count = 0 Then

            MessageBox.Show("Please select an item.")

            Exit Sub

        End If

        Dim productName As String =
        dgvCart.SelectedRows(0).Cells("Product").Value.ToString()

        Dim item As CartItem =
        CartManager.Cart.FirstOrDefault(
            Function(x) x.ProductName = productName)

        If item IsNot Nothing Then

            CartManager.Cart.Remove(item)

        End If

        LoadCart()

    End Sub

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click

        Me.Hide()

        frmShop.Show()


    End Sub

    Private Sub btnCheckout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCheckout.Click



     

        If CartManager.Cart.Count = 0 Then

            MessageBox.Show("Your cart is empty.")

            Exit Sub

        End If


      

        If txtFullName.Text.Trim() = "" Or
       txtAddress.Text.Trim() = "" Or
       txtCity.Text.Trim() = "" Or
       txtState.Text.Trim() = "" Or
       txtPincode.Text.Trim() = "" Then

            MessageBox.Show("Please fill all delivery details.")

            Exit Sub

        End If


        If txtPincode.Text.Trim().Length <> 6 OrElse
       Not IsNumeric(txtPincode.Text.Trim()) Then

            MessageBox.Show("Please enter a valid 6-digit pincode.")

            Exit Sub

        End If


 

        If cmbPayment.SelectedIndex = -1 Then

            MessageBox.Show("Please select a payment method.")

            Exit Sub

        End If


   

        If cmbPayment.Text = "UPI" Then

            If txtUPI.Text.Trim() = "" Then

                MessageBox.Show("Please enter your UPI ID.")

                Exit Sub

            End If

        End If


 

        If cmbPayment.Text.Contains("Card") Then

            If txtCardNumber.Text.Trim() = "" Or
           txtExpiry.Text.Trim() = "" Or
           txtCVV.Text.Trim() = "" Then

                MessageBox.Show("Please enter all card details.")

                Exit Sub

            End If

        End If


  

        Dim totalAmount As Decimal = 0

        For Each item As CartItem In CartManager.Cart

            totalAmount += item.Total

        Next




        If cmbPayment.Text = "UPI" Then

            MessageBox.Show(
            "UPI payment successful!" & vbCrLf &
            "Payment ID: PK" & DateTime.Now.ToString("yyyyMMddHHmmss"),
            "Payment Successful",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

        ElseIf cmbPayment.Text.Contains("Card") Then

            MessageBox.Show(
            "Card payment successful!" & vbCrLf &
            "Transaction ID: PK" & DateTime.Now.ToString("yyyyMMddHHmmss"),
            "Payment Successful",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

        End If



        Dim success As Boolean =
        DatabaseHelper.PlaceOrder(
            Session.UserID,
            txtAddress.Text.Trim(),
            txtCity.Text.Trim(),
            txtState.Text.Trim(),
            txtPincode.Text.Trim(),
            cmbPayment.Text,
            CartManager.Cart,
            totalAmount)


        If success Then

            MessageBox.Show(
            "Order placed successfully!" & vbCrLf &
            "Thank you for shopping with PlatinumKicks.",
            "Order Confirmed",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

            CartManager.Cart.Clear()

            Me.Hide()

            frmShop.Show()

        Else

            MessageBox.Show(
            "Unable to place the order. Please try again.",
            "Order Failed",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End If

    End Sub


End Class