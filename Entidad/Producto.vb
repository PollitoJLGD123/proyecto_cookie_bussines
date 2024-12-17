Public Class Producto
    Private m_IdProducto As Integer
    Private m_Nombre As String
    Private m_Descripcion As String
    Public Property Descripcion() As String
        Get
            Return m_Descripcion
        End Get
        Set(ByVal value As String)
            m_Descripcion = value
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
    Public Property IdProducto() As Integer
        Get
            Return m_IdProducto
        End Get
        Set(ByVal value As Integer)
            m_IdProducto = value
        End Set
    End Property
End Class
