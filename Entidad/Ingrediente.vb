Public Class Ingrediente
    Private m_IdMaterial As Integer
    Private m_Nombre As String
    Private m_PrecioUnitario As Decimal

    Public Property IdMaterial() As Integer
        Get
            Return m_IdMaterial
        End Get
        Set(ByVal value As Integer)
            m_IdMaterial = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return m_Nombre
        End Get
        Set(ByVal value As String)
            m_Nombre = value
        End Set
    End Property

    Public Property PrecioUnitario() As Decimal
        Get
            Return m_PrecioUnitario
        End Get
        Set(ByVal value As Decimal)
            m_PrecioUnitario = value
        End Set
    End Property
End Class

