Public Class CartItem

    Public Property ProductID As Integer
    Public Property ProductName As String
    Public Property Price As Decimal
    Public Property Quantity As Integer

    Public ReadOnly Property Total As Decimal
        Get
            Return Price * Quantity
        End Get
    End Property

End Class