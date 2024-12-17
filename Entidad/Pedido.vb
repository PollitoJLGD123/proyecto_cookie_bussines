Public Class Pedido
    Private m_IdPedido As Integer
    Private m_Cliente As String
    Private m_FechaPedido As Date
    Private m_Detalles As List(Of DetallePedido)
    Public Property Detalles() As List(Of DetallePedido)
        Get
            Return m_Detalles
        End Get
        Set(ByVal value As List(Of DetallePedido))
            m_Detalles = value
        End Set
    End Property
    Public Property FechaPedido() As Date
        Get
            Return m_FechaPedido
        End Get
        Set(ByVal value As Date)
            m_FechaPedido = value
        End Set
    End Property
    Public Property Cliente() As String
        Get
            Return m_Cliente
        End Get
        Set(ByVal value As String)
            m_Cliente = value
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
