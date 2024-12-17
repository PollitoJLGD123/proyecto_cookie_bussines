Public Class Empleado
    Private m_IdEmpleado As Integer
    Private m_Nombre As String
    Private m_Apellidos As String
    Private m_Puesto As String
    Private m_FechaIngreso As Date

    ' Propiedad para IdEmpleado
    Public Property IdEmpleado() As Integer
        Get
            Return m_IdEmpleado
        End Get
        Set(ByVal value As Integer)
            m_IdEmpleado = value
        End Set
    End Property

    ' Propiedad para Nombre
    Public Property Nombre() As String
        Get
            Return m_Nombre
        End Get
        Set(ByVal value As String)
            m_Nombre = value
        End Set
    End Property

    ' Propiedad para Apellidos
    Public Property Apellidos() As String
        Get
            Return m_Apellidos
        End Get
        Set(ByVal value As String)
            m_Apellidos = value
        End Set
    End Property

    ' Propiedad para Puesto
    Public Property Puesto() As String
        Get
            Return m_Puesto
        End Get
        Set(ByVal value As String)
            m_Puesto = value
        End Set
    End Property

    ' Propiedad para FechaIngreso
    Public Property FechaIngreso() As Date
        Get
            Return m_FechaIngreso
        End Get
        Set(ByVal value As Date)
            m_FechaIngreso = value
        End Set
    End Property

    ' Propiedad calculada para obtener el Nombre Completo (Opcional, para interfaz)
    Public ReadOnly Property NombreCompleto() As String
        Get
            Return $"{Nombre} {Apellidos}"
        End Get
    End Property
End Class

