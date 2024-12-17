Imports CapaAccesoDatos
Public Class PedidoLN
    Public Shared Function InsertarPedido(ByVal cliente As String, ByVal fechaPedido As Date) As Integer
        Return PedidoAD.InsertarPedido(cliente, fechaPedido)
    End Function

    Public Shared Sub InsertarProductoPorPedido(ByVal idPedido As Integer, ByVal idProducto As Integer, ByVal cantidad As Decimal)
        PedidoAD.InsertarProductoPorPedido(idPedido, idProducto, cantidad)
    End Sub

    Public Shared Function ListarProductos() As DataTable
        Return PedidoAD.ListarProductos()
    End Function
End Class

