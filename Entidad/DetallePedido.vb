Public Class DetallePedido
    Private m_IdPedido As Integer
    Private m_IdProducto As Integer
    Private m_Cantidad As Decimal
    Private m_NombreProducto As String
    Public Property NombreProducto() As String
        Get
            Return m_NombreProducto
        End Get
        Set(ByVal value As String)
            m_NombreProducto = value
        End Set
    End Property
    Public Property Cantidad() As Decimal
        Get
            Return m_Cantidad
        End Get
        Set(ByVal value As Decimal)
            m_Cantidad = value
        End Set
    End Property
    Public Property IdProducto() As Integer
        Get
            Return m_IdProducto
        End Get
        Set(ByVal value As Integer)
            m_IdProducto = value
        End Set
    End Property
    Public Property IdPedido() As Integer
        Get
            Return m_IdPedido
        End Get
        Set(ByVal value As Integer)
            m_IdPedido = value
        End Set
    End Property
End Class
