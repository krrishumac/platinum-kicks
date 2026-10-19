Imports System.Data
Imports System.Data.SqlClient

Public Class DatabaseHelper



    Private Shared ReadOnly connectionString As String =
        "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\PlatinumKicks.mdf;Integrated Security=True;User Instance=True"

    Public Shared Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function




    Public Shared Function RegisterUser(ByVal fullName As String,
                                        ByVal username As String,
                                        ByVal email As String,
                                        ByVal password As String) As Boolean

        Using con As SqlConnection = GetConnection()

            con.Open()

            Dim query As String =
                "INSERT INTO users(full_name, username, email, password) " &
                "VALUES(@full, @user, @email, @pass)"

            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@full", fullName)
                cmd.Parameters.AddWithValue("@user", username)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@pass", password)

                Return cmd.ExecuteNonQuery() > 0

            End Using

        End Using

    End Function


   

    Public Shared Function UsernameExists(ByVal username As String) As Boolean

        Using con As SqlConnection = GetConnection()

            con.Open()

            Dim query As String =
                "SELECT COUNT(*) FROM users WHERE username=@user"

            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@user", username)

                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0

            End Using

        End Using

    End Function



    Public Shared Function EmailExists(ByVal email As String) As Boolean

        Using con As SqlConnection = GetConnection()

            con.Open()

            Dim query As String =
                "SELECT COUNT(*) FROM users WHERE email=@email"

            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@email", email)

                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0

            End Using

        End Using

    End Function



    Public Shared Function Login(ByVal username As String,
                                 ByVal password As String) As String

        Using con As SqlConnection = GetConnection()

            con.Open()

            Dim query As String =
                "SELECT user_id, username, role FROM users " &
                "WHERE username=@user AND password=@pass"

            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@user", username)
                cmd.Parameters.AddWithValue("@pass", password)

                Using reader As SqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then

                        Session.UserID = CInt(reader("user_id"))
                        Session.Username = reader("username").ToString()
                        Session.Role = reader("role").ToString()

                        Return Session.Role

                    Else

                        Return ""

                    End If

                End Using

            End Using

        End Using

    End Function



    Public Shared Function AddProduct(ByVal name As String,
                                      ByVal brand As String,
                                      ByVal description As String,
                                      ByVal price As Decimal,
                                      ByVal stock As Integer,
                                      ByVal image() As Byte) As Boolean

        Using con As SqlConnection = GetConnection()

            con.Open()

            Dim query As String =
                "INSERT INTO products(name, brand, description, price, stock, image) " &
                "VALUES(@name, @brand, @desc, @price, @stock, @image)"

            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@brand", brand)
                cmd.Parameters.AddWithValue("@desc", description)
                cmd.Parameters.AddWithValue("@price", price)
                cmd.Parameters.AddWithValue("@stock", stock)

                If image Is Nothing Then
                    cmd.Parameters.AddWithValue("@image", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@image", image)
                End If

                Return cmd.ExecuteNonQuery() > 0

            End Using

        End Using

    End Function



    Public Shared Function GetProducts() As DataTable

        Dim dt As New DataTable()

        Using con As SqlConnection = GetConnection()

            con.Open()

            Dim query As String =
                "SELECT * FROM products"

            Using da As New SqlDataAdapter(query, con)

                da.Fill(dt)

            End Using

        End Using

        Return dt

    End Function




    Public Shared Function UpdateProduct(ByVal id As Integer,
                                         ByVal name As String,
                                         ByVal brand As String,
                                         ByVal description As String,
                                         ByVal price As Decimal,
                                         ByVal stock As Integer,
                                         ByVal image() As Byte) As Boolean

        Using con As SqlConnection = GetConnection()

            con.Open()

            Dim query As String =
                "UPDATE products SET " &
                "name=@name, " &
                "brand=@brand, " &
                "description=@desc, " &
                "price=@price, " &
                "stock=@stock, " &
                "image=@image " &
                "WHERE product_id=@id"

            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@brand", brand)
                cmd.Parameters.AddWithValue("@desc", description)
                cmd.Parameters.AddWithValue("@price", price)
                cmd.Parameters.AddWithValue("@stock", stock)

                If image Is Nothing Then
                    cmd.Parameters.AddWithValue("@image", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@image", image)
                End If

                Return cmd.ExecuteNonQuery() > 0

            End Using

        End Using

    End Function




    Public Shared Function DeleteProduct(ByVal id As Integer) As Boolean

        Using con As SqlConnection = GetConnection()

            con.Open()

            Dim query As String =
                "DELETE FROM products WHERE product_id=@id"

            Using cmd As New SqlCommand(query, con)

                cmd.Parameters.AddWithValue("@id", id)

                Return cmd.ExecuteNonQuery() > 0

            End Using

        End Using

    End Function


    Public Shared Function PlaceOrder(ByVal userID As Integer,
                                      ByVal address As String,
                                      ByVal city As String,
                                      ByVal state As String,
                                      ByVal pincode As String,
                                      ByVal paymentMethod As String,
                                      ByVal cartItems As List(Of CartItem),
                                      ByVal totalAmount As Decimal) As Boolean

        Using con As SqlConnection = GetConnection()

            con.Open()

            Using transaction As SqlTransaction = con.BeginTransaction()

                Try

               

                    Dim orderQuery As String =
                        "INSERT INTO orders " &
                        "(user_id, address, city, state, pincode, payment_method, total_amount, status) " &
                        "VALUES " &
                        "(@userID, @address, @city, @state, @pincode, @payment, @total, 'Pending'); " &
                        "SELECT CAST(SCOPE_IDENTITY() AS INT);"

                    Dim orderID As Integer

                    Using cmd As New SqlCommand(orderQuery, con, transaction)

                        cmd.Parameters.AddWithValue("@userID", userID)
                        cmd.Parameters.AddWithValue("@address", address)
                        cmd.Parameters.AddWithValue("@city", city)
                        cmd.Parameters.AddWithValue("@state", state)
                        cmd.Parameters.AddWithValue("@pincode", pincode)
                        cmd.Parameters.AddWithValue("@payment", paymentMethod)
                        cmd.Parameters.AddWithValue("@total", totalAmount)

                        orderID = Convert.ToInt32(cmd.ExecuteScalar())

                    End Using


                   

                    For Each item As CartItem In cartItems

                        Dim itemQuery As String =
                            "INSERT INTO order_items " &
                            "(order_id, product_id, quantity, price) " &
                            "VALUES " &
                            "(@orderID, @productID, @quantity, @price)"

                        Using cmd As New SqlCommand(itemQuery, con, transaction)

                            cmd.Parameters.AddWithValue("@orderID", orderID)
                            cmd.Parameters.AddWithValue("@productID", item.ProductID)
                            cmd.Parameters.AddWithValue("@quantity", item.Quantity)
                            cmd.Parameters.AddWithValue("@price", item.Price)

                            cmd.ExecuteNonQuery()

                        End Using


                        Dim stockQuery As String =
                            "UPDATE products " &
                            "SET stock = stock - @quantity " &
                            "WHERE product_id = @productID " &
                            "AND stock >= @quantity"

                        Using cmd As New SqlCommand(stockQuery, con, transaction)

                            cmd.Parameters.AddWithValue("@quantity", item.Quantity)
                            cmd.Parameters.AddWithValue("@productID", item.ProductID)

                            If cmd.ExecuteNonQuery() = 0 Then

                                Throw New Exception(
                                    "Insufficient stock for " & item.ProductName)

                            End If

                        End Using

                    Next


                    transaction.Commit()

                    Return True

                Catch

                    transaction.Rollback()

                    Return False

                End Try

            End Using

        End Using

    End Function


  

    Public Shared Function GetOrders() As DataTable

        Dim dt As New DataTable()

        Using con As SqlConnection = GetConnection()

            con.Open()

            Dim query As String =
                "SELECT " &
                "o.order_id AS [Order ID], " &
                "u.username AS [Customer], " &
                "o.address AS [Address], " &
                "o.city AS [City], " &
                "o.state AS [State], " &
                "o.pincode AS [Pincode], " &
                "o.payment_method AS [Payment], " &
                "o.total_amount AS [Total], " &
                "o.order_date AS [Order Date] " &
                "FROM orders o " &
                "INNER JOIN users u " &
                "ON o.user_id = u.user_id " &
                "ORDER BY o.order_id ASC"

            Using da As New SqlDataAdapter(query, con)

                da.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

End Class