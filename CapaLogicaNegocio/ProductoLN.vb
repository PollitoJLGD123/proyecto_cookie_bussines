Imports CapaAccesoDatos

Public Class ProductoLN
    Public Shared Function InsertarProducto(ByVal nombre As String, ByVal descripcion As String) As Integer
        Return ProductoAD.InsertarProducto(nombre, descripcion)
    End Function

    Public Shared Sub InsertarReceta(ByVal idProducto As Integer, ByVal idMaterial As Integer, ByVal cantidad As Decimal)
        ProductoAD.InsertarReceta(idProducto, idMaterial, cantidad)
    End Sub
    'EDITAR PRODUCTO
    Public Shared Function ListarProductos() As DataTable
        Return ProductoAD.ListarProductos()
    End Function

    ' Obtener los detalles de un producto y su receta
    Public Shared Function ObtenerProductoConReceta(ByVal idProducto As Integer) As DataSet
        Return ProductoAD.ObtenerProductoConReceta(idProducto)
    End Function

    ' Actualizar un producto
    Public Shared Sub ActualizarProducto(ByVal idProducto As Integer, ByVal nuevoNombre As String, ByVal nuevaDescripcion As String)
        ProductoAD.ActualizarProducto(idProducto, nuevoNombre, nuevaDescripcion)
    End Sub

    ' Actualizar la receta de un producto
    Public Shared Sub ActualizarReceta(ByVal idProducto As Integer, ByVal ingredientes As List(Of Tuple(Of Integer, Decimal)))
        ProductoAD.ActualizarReceta(idProducto, ingredientes)
    End Sub
    'eliminar receta
    Public Shared Sub EliminarReceta(ByVal idProducto As Integer)
        ProductoAD.EliminarReceta(idProducto)
    End Sub

End Class

