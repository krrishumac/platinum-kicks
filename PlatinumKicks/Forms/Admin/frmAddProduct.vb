Imports System.IO
Public Class frmAddProduct
    Inherits BaseForm

    Public IsEdit As Boolean = False

    Private ProductID As Integer = 0

    Public Sub LoadProduct(id As Integer,
                       productName As String,
                       brand As String,
                       description As String,
                       price As Decimal,
                       stock As Integer,
                       imageBytes As Byte())

        ProductID = id

        txtProductName.Text = productName
        cmbBrand.Text = brand
        rtbDescription.Text = description
        txtPrice.Text = price.ToString()
        txtStock.Text = stock.ToString()

        If imageBytes IsNot Nothing Then

            Using ms As New MemoryStream(imageBytes)

                Using tempImage As Image = Image.FromStream(ms)

                    picProduct.Image = New Bitmap(tempImage)

                End Using

            End Using

        End If

        IsEdit = True

        btnSave.Text = "UPDATE PRODUCT"

    End Sub
    Private Sub frmAddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblImage.Click

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click


        If ofdImage.ShowDialog = DialogResult.OK Then

            picProduct.Image = Image.FromFile(ofdImage.FileName)

        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtProductName.Text = "" Or
       cmbBrand.Text = "" Or
       rtbDescription.Text = "" Or
       txtPrice.Text = "" Or
       txtStock.Text = "" Or
       picProduct.Image Is Nothing Then

            MessageBox.Show("Please fill all fields.")
            Exit Sub

        End If

        Dim imageBytes() As Byte

        Using ms As New MemoryStream()

            picProduct.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)

            imageBytes = ms.ToArray()

        End Using

        If IsEdit Then

            If DatabaseHelper.UpdateProduct(
        ProductID,
        txtProductName.Text,
        cmbBrand.Text,
        rtbDescription.Text,
        Decimal.Parse(txtPrice.Text),
        Integer.Parse(txtStock.Text),
        imageBytes) Then

                MessageBox.Show("Product Updated Successfully!")

                IsEdit = False

                btnSave.Text = "SAVE"

                Me.Hide()

                frmManageProducts.RefreshProducts()

                frmManageProducts.Show()

            Else

                MessageBox.Show("Update Failed.")

            End If

        Else

            If DatabaseHelper.AddProduct(
        txtProductName.Text,
        cmbBrand.Text,
        rtbDescription.Text,
        Decimal.Parse(txtPrice.Text),
        Integer.Parse(txtStock.Text),
        imageBytes) Then

                MessageBox.Show("Product Added Successfully!")

                btnClear.PerformClick()

            Else

                MessageBox.Show("Failed to Add Product.")

            End If

        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click


        txtProductName.Clear()

        cmbBrand.SelectedIndex = -1

        rtbDescription.Clear()

        txtPrice.Clear()

        txtStock.Clear()

        picProduct.Image = Nothing

        txtProductName.Focus()


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click


        Me.Hide()

        frmAdminDashboard.Show()

    End Sub

End Class