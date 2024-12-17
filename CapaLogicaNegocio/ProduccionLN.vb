Imports CapaAccesoDatos
Public Class ProduccionLN
    Public Shared Function ListarPedidos() As DataTable
        Return ProduccionAD.ListarPedidos()
    End Function

    Public Shared Function ObtenerPedidoPorId(ByVal idPedido As Integer) As DataSet
        Return ProduccionAD.ObtenerPedidoPorId(idPedido)
    End Function

    Public Shared Function ObtenerRecetaPorProducto(ByVal idProducto As Integer) As DataTable
        Return ProduccionAD.ObtenerRecetaPorProducto(idProducto)
    End Function

    Public Shared Function RegistrarProduccion(ByVal idProducto As Integer, ByVal cantidad As Decimal, ByVal fecha As Date, ByVal idPedido As Integer) As Integer
        Return ProduccionAD.RegistrarProduccion(idProducto, cantidad, fecha, idPedido)
    End Function

    Public Shared Sub AsignarEmpleadoAProduccion(ByVal idProduccion As Integer, ByVal idEmpleado As Integer)
        ProduccionAD.AsignarEmpleadoAProduccion(idProduccion, idEmpleado)
    End Sub

    Public Shared Function ListarEmpleados() As DataTable
        Return ProduccionAD.ListarEmpleados()
    End Function
End Class

