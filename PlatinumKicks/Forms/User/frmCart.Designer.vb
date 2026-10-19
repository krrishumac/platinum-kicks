<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCart
    Inherits BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.dgvCart = New System.Windows.Forms.DataGridView()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lblPincode = New System.Windows.Forms.Label()
        Me.txtPincode = New System.Windows.Forms.TextBox()
        Me.lblPayTitle = New System.Windows.Forms.Label()
        Me.cmbPayment = New System.Windows.Forms.ComboBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblUPI = New System.Windows.Forms.Label()
        Me.txtUPI = New System.Windows.Forms.TextBox()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.lblExpiry = New System.Windows.Forms.Label()
        Me.txtExpiry = New System.Windows.Forms.TextBox()
        Me.txtCVV = New System.Windows.Forms.TextBox()
        Me.lblCVV = New System.Windows.Forms.Label()
        Me.lblTotalTitle = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(400, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(144, 40)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "MY CART"
        '
        'dgvCart
        '
        Me.dgvCart.AllowUserToAddRows = False
        Me.dgvCart.AllowUserToDeleteRows = False
        Me.dgvCart.AllowUserToResizeRows = False
        Me.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCart.Location = New System.Drawing.Point(12, 64)
        Me.dgvCart.MultiSelect = False
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.ReadOnly = True
        Me.dgvCart.RowHeadersVisible = False
        Me.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCart.Size = New System.Drawing.Size(873, 213)
        Me.dgvCart.TabIndex = 6
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(403, 306)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(132, 36)
        Me.btnRemove.TabIndex = 12
        Me.btnRemove.Text = "REMOVE ITEM"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'lblDelivery
        '
        Me.lblDelivery.AutoSize = True
        Me.lblDelivery.BackColor = System.Drawing.Color.Transparent
        Me.lblDelivery.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelivery.ForeColor = System.Drawing.Color.White
        Me.lblDelivery.Location = New System.Drawing.Point(114, 413)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(197, 30)
        Me.lblDelivery.TabIndex = 13
        Me.lblDelivery.Text = "DELIVERY DETAILS"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.BackColor = System.Drawing.Color.Transparent
        Me.lblFullName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.White
        Me.lblFullName.Location = New System.Drawing.Point(37, 501)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(80, 20)
        Me.lblFullName.TabIndex = 14
        Me.lblFullName.Text = "Full Name"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(176, 500)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(210, 25)
        Me.txtFullName.TabIndex = 15
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.White
        Me.lblAddress.Location = New System.Drawing.Point(37, 578)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(66, 20)
        Me.lblAddress.TabIndex = 16
        Me.lblAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(176, 573)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(210, 79)
        Me.txtAddress.TabIndex = 17
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.BackColor = System.Drawing.Color.Transparent
        Me.lblCity.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.ForeColor = System.Drawing.Color.White
        Me.lblCity.Location = New System.Drawing.Point(37, 716)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(36, 20)
        Me.lblCity.TabIndex = 18
        Me.lblCity.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(176, 715)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(210, 25)
        Me.txtCity.TabIndex = 19
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.BackColor = System.Drawing.Color.Transparent
        Me.lblState.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.White
        Me.lblState.Location = New System.Drawing.Point(37, 792)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(45, 20)
        Me.lblState.TabIndex = 20
        Me.lblState.Text = "State"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(176, 791)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(210, 25)
        Me.txtState.TabIndex = 21
        '
        'lblPincode
        '
        Me.lblPincode.AutoSize = True
        Me.lblPincode.BackColor = System.Drawing.Color.Transparent
        Me.lblPincode.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPincode.ForeColor = System.Drawing.Color.White
        Me.lblPincode.Location = New System.Drawing.Point(37, 872)
        Me.lblPincode.Name = "lblPincode"
        Me.lblPincode.Size = New System.Drawing.Size(64, 20)
        Me.lblPincode.TabIndex = 22
        Me.lblPincode.Text = "Pincode"
        '
        'txtPincode
        '
        Me.txtPincode.Location = New System.Drawing.Point(176, 871)
        Me.txtPincode.Name = "txtPincode"
        Me.txtPincode.Size = New System.Drawing.Size(210, 25)
        Me.txtPincode.TabIndex = 23
        '
        'lblPayTitle
        '
        Me.lblPayTitle.AutoSize = True
        Me.lblPayTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblPayTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayTitle.ForeColor = System.Drawing.Color.White
        Me.lblPayTitle.Location = New System.Drawing.Point(548, 413)
        Me.lblPayTitle.Name = "lblPayTitle"
        Me.lblPayTitle.Size = New System.Drawing.Size(205, 30)
        Me.lblPayTitle.TabIndex = 24
        Me.lblPayTitle.Text = "PAYMENT SECTION"
        '
        'cmbPayment
        '
        Me.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayment.FormattingEnabled = True
        Me.cmbPayment.Items.AddRange(New Object() {"Cash on Delivery", "UPI", "Credit/Debit Card"})
        Me.cmbPayment.Location = New System.Drawing.Point(694, 500)
        Me.cmbPayment.Name = "cmbPayment"
        Me.cmbPayment.Size = New System.Drawing.Size(121, 25)
        Me.cmbPayment.TabIndex = 25
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.BackColor = System.Drawing.Color.Transparent
        Me.lblPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.ForeColor = System.Drawing.Color.White
        Me.lblPayment.Location = New System.Drawing.Point(450, 500)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(158, 21)
        Me.lblPayment.TabIndex = 26
        Me.lblPayment.Text = "PAYMENT METHOD"
        '
        'lblUPI
        '
        Me.lblUPI.AutoSize = True
        Me.lblUPI.BackColor = System.Drawing.Color.Transparent
        Me.lblUPI.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUPI.ForeColor = System.Drawing.Color.White
        Me.lblUPI.Location = New System.Drawing.Point(432, 663)
        Me.lblUPI.Name = "lblUPI"
        Me.lblUPI.Size = New System.Drawing.Size(54, 20)
        Me.lblUPI.TabIndex = 27
        Me.lblUPI.Text = "UPI ID"
        '
        'txtUPI
        '
        Me.txtUPI.Location = New System.Drawing.Point(592, 658)
        Me.txtUPI.Name = "txtUPI"
        Me.txtUPI.Size = New System.Drawing.Size(210, 25)
        Me.txtUPI.TabIndex = 28
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblCardNumber.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNumber.ForeColor = System.Drawing.Color.White
        Me.lblCardNumber.Location = New System.Drawing.Point(432, 579)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(103, 20)
        Me.lblCardNumber.TabIndex = 29
        Me.lblCardNumber.Text = "Card Number"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(592, 578)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(210, 25)
        Me.txtCardNumber.TabIndex = 30
        '
        'lblExpiry
        '
        Me.lblExpiry.AutoSize = True
        Me.lblExpiry.BackColor = System.Drawing.Color.Transparent
        Me.lblExpiry.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpiry.ForeColor = System.Drawing.Color.White
        Me.lblExpiry.Location = New System.Drawing.Point(432, 640)
        Me.lblExpiry.Name = "lblExpiry"
        Me.lblExpiry.Size = New System.Drawing.Size(122, 20)
        Me.lblExpiry.TabIndex = 31
        Me.lblExpiry.Text = "Expiry (MM/YY)"
        '
        'txtExpiry
        '
        Me.txtExpiry.Location = New System.Drawing.Point(592, 639)
        Me.txtExpiry.Name = "txtExpiry"
        Me.txtExpiry.Size = New System.Drawing.Size(210, 25)
        Me.txtExpiry.TabIndex = 32
        '
        'txtCVV
        '
        Me.txtCVV.Location = New System.Drawing.Point(592, 709)
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(210, 25)
        Me.txtCVV.TabIndex = 34
        '
        'lblCVV
        '
        Me.lblCVV.AutoSize = True
        Me.lblCVV.BackColor = System.Drawing.Color.Transparent
        Me.lblCVV.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCVV.ForeColor = System.Drawing.Color.White
        Me.lblCVV.Location = New System.Drawing.Point(432, 710)
        Me.lblCVV.Name = "lblCVV"
        Me.lblCVV.Size = New System.Drawing.Size(38, 20)
        Me.lblCVV.TabIndex = 33
        Me.lblCVV.Text = "CVV"
        '
        'lblTotalTitle
        '
        Me.lblTotalTitle.AutoSize = True
        Me.lblTotalTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTitle.ForeColor = System.Drawing.Color.White
        Me.lblTotalTitle.Location = New System.Drawing.Point(568, 842)
        Me.lblTotalTitle.Name = "lblTotalTitle"
        Me.lblTotalTitle.Size = New System.Drawing.Size(68, 25)
        Me.lblTotalTitle.TabIndex = 35
        Me.lblTotalTitle.Text = "TOTAL"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(671, 842)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(61, 25)
        Me.lblTotal.TabIndex = 36
        Me.lblTotal.Text = "₹0.00"
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckout.FlatAppearance.BorderSize = 0
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckout.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.ForeColor = System.Drawing.Color.White
        Me.btnCheckout.Location = New System.Drawing.Point(272, 961)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(132, 36)
        Me.btnCheckout.TabIndex = 37
        Me.btnCheckout.Text = "CHECKOUT"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.IndianRed
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(476, 961)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(132, 36)
        Me.btnBack.TabIndex = 38
        Me.btnBack.Text = "BACK TO SHOP"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmCart
        '
        Me.ClientSize = New System.Drawing.Size(948, 1044)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotalTitle)
        Me.Controls.Add(Me.txtCVV)
        Me.Controls.Add(Me.lblCVV)
        Me.Controls.Add(Me.txtExpiry)
        Me.Controls.Add(Me.lblExpiry)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.lblCardNumber)
        Me.Controls.Add(Me.txtUPI)
        Me.Controls.Add(Me.lblUPI)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.cmbPayment)
        Me.Controls.Add(Me.lblPayTitle)
        Me.Controls.Add(Me.txtPincode)
        Me.Controls.Add(Me.lblPincode)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.lblDelivery)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.dgvCart)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmCart"
        Me.Text = "PlatinumKicks - Cart"
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents btnRemove As Button
    Friend WithEvents lblDelivery As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblState As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents lblPincode As Label
    Friend WithEvents txtPincode As TextBox
    Friend WithEvents lblPayTitle As Label
    Friend WithEvents cmbPayment As ComboBox
    Friend WithEvents lblPayment As Label
    Friend WithEvents lblUPI As Label
    Friend WithEvents txtUPI As TextBox
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents lblExpiry As Label
    Friend WithEvents txtExpiry As TextBox
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents lblCVV As Label
    Friend WithEvents lblTotalTitle As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnBack As Button
End Class
