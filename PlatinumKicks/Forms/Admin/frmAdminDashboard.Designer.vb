<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminDashboard
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnManageProducts = New System.Windows.Forms.Button()
        Me.btnViewOrders = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(285, 59)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(306, 40)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "ADMIN DASHBOARD"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(325, 117)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(214, 25)
        Me.lblWelcome.TabIndex = 4
        Me.lblWelcome.Text = "Welcome, Administrator"
        '
        'btnAddProduct
        '
        Me.btnAddProduct.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProduct.FlatAppearance.BorderSize = 0
        Me.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProduct.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduct.ForeColor = System.Drawing.Color.White
        Me.btnAddProduct.Location = New System.Drawing.Point(271, 195)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(320, 45)
        Me.btnAddProduct.TabIndex = 11
        Me.btnAddProduct.Text = "ADD PRODUCT"
        Me.btnAddProduct.UseVisualStyleBackColor = False
        '
        'btnManageProducts
        '
        Me.btnManageProducts.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnManageProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageProducts.FlatAppearance.BorderSize = 0
        Me.btnManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageProducts.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageProducts.ForeColor = System.Drawing.Color.White
        Me.btnManageProducts.Location = New System.Drawing.Point(271, 296)
        Me.btnManageProducts.Name = "btnManageProducts"
        Me.btnManageProducts.Size = New System.Drawing.Size(320, 45)
        Me.btnManageProducts.TabIndex = 12
        Me.btnManageProducts.Text = "MANAGE PRODUCTS"
        Me.btnManageProducts.UseVisualStyleBackColor = False
        '
        'btnViewOrders
        '
        Me.btnViewOrders.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnViewOrders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewOrders.FlatAppearance.BorderSize = 0
        Me.btnViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewOrders.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewOrders.ForeColor = System.Drawing.Color.White
        Me.btnViewOrders.Location = New System.Drawing.Point(271, 403)
        Me.btnViewOrders.Name = "btnViewOrders"
        Me.btnViewOrders.Size = New System.Drawing.Size(320, 45)
        Me.btnViewOrders.TabIndex = 13
        Me.btnViewOrders.Text = "VIEW ORDERS"
        Me.btnViewOrders.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.IndianRed
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(271, 508)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(320, 45)
        Me.btnLogout.TabIndex = 14
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'frmAdminDashboard
        '
        Me.ClientSize = New System.Drawing.Size(873, 668)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnViewOrders)
        Me.Controls.Add(Me.btnManageProducts)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmAdminDashboard"
        Me.Text = "  "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnManageProducts As Button
    Friend WithEvents btnViewOrders As Button
    Friend WithEvents btnLogout As Button
End Class
