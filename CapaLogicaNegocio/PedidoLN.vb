Imports CapaAccesoDatos
Public Class PedidoLN
    Public Shared Function InsertarPedido(ByVal fechaPedido As Date, ByVal nombre As String, ByVal apellido As String, ByVal DNI As String) As Integer
        Return PedidoAD.InsertarPedido(fechaPedido, nombre, apellido, DNI)
    End Function

    Public Shared Sub InsertarProductoPorPedido(ByVal idPedido As Integer, ByVal idProducto As Integer, ByVal cantidad As Decimal)
        PedidoAD.InsertarProductoPorPedido(idPedido, idProducto, cantidad)
    End Sub

    Public Shared Function ListarProductos() As DataTable
        Return PedidoAD.ListarProductos()
    End Function
End Class

