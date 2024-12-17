Public Class Receta
    Private m_IdReceta As Integer
    Private m_IdProducto As Integer
    Private m_IdMaterial As Integer
    Private m_Cantidad As Decimal
    Private m_NombreMaterial As String ' Campo adicional para mostrar el nombre del material en la interfaz
    Private m_PrecioCalculado As Decimal

    Public Property IdReceta() As Integer
        Get
            Return m_IdReceta
        End Get
        Set(ByVal value As Integer)
            m_IdReceta = value
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

    Public Property IdMaterial() As Integer
        Get
            Return m_IdMaterial
        End Get
        Set(ByVal value As Integer)
            m_IdMaterial = value
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

    ' Propiedad para NombreMaterial (campo opcional para la interfaz)
    Public Property NombreMaterial() As String
        Get
            Return m_NombreMaterial
        End Get
        Set(ByVal value As String)
            m_NombreMaterial = value
        End Set
    End Property
    ' Propiedad para PrecioCalculado
    Public Property PrecioCalculado() As Decimal
        Get
            Return m_PrecioCalculado
        End Get
        Set(ByVal value As Decimal)
            m_PrecioCalculado = value
        End Set
    End Property

End Class

