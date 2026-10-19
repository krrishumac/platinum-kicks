# 👟 Platinum Kicks - Shoes Ecommerce

A VB.NET Windows Forms-based footwear e-commerce application developed as a college academic project. It provides user authentication, product browsing, shopping cart management, order processing, and administrator functionalities using a local SQL Server database.

## 📌 Project Overview

**Platinum Kicks - Shoes Ecommerce** is a desktop application designed to simulate an online footwear shopping experience. It provides separate functionalities for customers and administrators, allowing customers to browse products and place orders while administrators manage products and monitor orders.

## ✨ Features

### 👤 User Module
- User registration and login.
- Browse available footwear products.
- View product information and prices.
- Add products to the shopping cart.
- Manage cart items and quantities.
- Enter delivery details during checkout.
- Simulated payment options: Cash on Delivery (COD), UPI, and card.
- Place orders and update product stock.

### 🛠️ Admin Module
- Admin dashboard.
- Add new footwear products.
- View and manage existing products.
- Update product details.
- Delete products.
- View customer orders.

## 🧰 Technologies Used

| Component | Technology |
|---|---|
| Programming Language | VB.NET |
| Application Type | Windows Forms Desktop Application |
| Development Environment | Microsoft Visual Studio 2010 |
| Database | SQL Server Express Local Database (`.mdf`) |
| Database Connectivity | ADO.NET |

## 🗄️ Database Design

The application uses the following four database tables:

| Table Name | Purpose |
|---|---|
| `users` | Stores user account and authentication information. |
| `products` | Stores footwear product details, prices, and stock information. |
| `orders` | Stores customer order information. |
| `order_items` | Stores individual products associated with each order. |

The shopping cart is managed in memory and is not stored in a separate database table.

## 📸 Application Screenshots

Screenshots of the application's user and administrator interfaces are available in the [`Screenshots`](Screenshots/) directory.

### User Interface

| Screen | Preview |
|---|---|
| Landing Page | `frmLanding.vb.png` |
| Login Page | `frmLogin.vb.png` |
| Registration Page | `frmRegister.vb.png` |
| Shop Page | `frmShop.vb.png` |
| Shopping Cart | `frmCart.vb.png` |

### Admin Interface

| Screen | Preview |
|---|---|
| Admin Dashboard | `frmAdminDashboard.vb.png` |
| Add Product | `frmAddProduct.vb.png` |
| Manage Products | `frmManageProducts.vb.png` |
| View Orders | `frmViewOrders.vb.png` |

## 📄 Project Documentation

The complete project documentation is available in the [`Documentation`](Documentation/) directory.

It covers the project introduction, scope of work, existing and proposed systems, feasibility study, system features, hardware and software requirements, data flow diagrams, database layout, input and output screens, testing procedures, implementation phases, limitations, and conclusion.

## 🚀 Getting Started

### Prerequisites

- Windows operating system.
- Microsoft Visual Studio compatible with the project.
- Required SQL Server Express or LocalDB components.

### Installation and Execution

1. Clone or download this repository.
2. Open `PlatinumKicks.sln` in Microsoft Visual Studio.
3. Ensure the local SQL Server database file is available at the location expected by the application.
4. Verify the database connection settings if necessary.
5. Build the solution.
6. Run the application.

**Note:** Database file paths and SQL Server configuration may need to be adjusted according to your local environment.

## ⚠️ Limitations

- Developed primarily for academic learning and demonstration.
- UPI and card payments are simulated; real payment transactions are not processed.
- The shopping cart is maintained in memory.
- The application is designed as a local desktop application rather than a deployed online storefront.

## 🎯 Learning Outcomes

This project demonstrates practical implementation of:

- VB.NET Windows Forms application development.
- Database connectivity using ADO.NET.
- Create, Read, Update, and Delete (CRUD) operations.
- User authentication.
- Product and inventory management.
- Shopping cart functionality.
- Order placement and processing.
- Software testing and technical documentation.

## 👨‍💻 Project Information

**Project Name:** Platinum Kicks - Shoes Ecommerce  
**Project Type:** College Academic Project  
**Application Platform:** Windows Desktop  
**Technology Stack:** VB.NET, Windows Forms, SQL Server

---

*Developed for academic learning and demonstration purposes.*
