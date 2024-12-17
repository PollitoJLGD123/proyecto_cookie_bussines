Imports System.Data.SqlClient

Public Class ProductoAD
    Public Shared Function InsertarProducto(ByVal nombre As String, ByVal descripcion As String) As Integer
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")
        Dim cmd As New SqlCommand("sp_InsertarProducto", cn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@Nombre", nombre)
        cmd.Parameters.AddWithValue("@Descripcion", descripcion)
        cmd.Parameters.Add("@IdProducto", SqlDbType.Int).Direction = ParameterDirection.Output

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            Return Convert.ToInt32(cmd.Parameters("@IdProducto").Value)
        Catch ex As Exception
            Throw New Exception("Error al insertar el producto: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Function

    Public Shared Sub InsertarReceta(ByVal idProducto As Integer, ByVal idMaterial As Integer, ByVal cantidad As Decimal)
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")
        Dim cmd As New SqlCommand("sp_InsertarReceta", cn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@IdProducto", idProducto)
        cmd.Parameters.AddWithValue("@IdMaterial", idMaterial)
        cmd.Parameters.AddWithValue("@Cantidad", cantidad)

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al insertar la receta: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub
    'EDITAR PRODUCTO
    Public Shared Function ListarProductos() As DataTable
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")
        Dim cmd As New SqlCommand("sp_ListarProductos2", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable()
        Try
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar los productos: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Function

    ' Obtener los detalles de un producto y su receta
    Public Shared Function ObtenerProductoConReceta(ByVal idProducto As Integer) As DataSet
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")
        Dim cmd As New SqlCommand("sp_ObtenerProductoConReceta", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@IdProducto", idProducto)

        Dim ds As New DataSet()
        Try
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            Throw New Exception("Error al obtener el producto y su receta: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Function

    ' Actualizar un producto
    Public Shared Sub ActualizarProducto(ByVal idProducto As Integer, ByVal nuevoNombre As String, ByVal nuevaDescripcion As String)
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")
        Dim cmd As New SqlCommand("sp_ActualizarProducto", cn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@IdProducto", idProducto)
        cmd.Parameters.AddWithValue("@NuevoNombre", nuevoNombre)
        cmd.Parameters.AddWithValue("@NuevaDescripcion", nuevaDescripcion)

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al actualizar el producto: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' Actualizar la receta de un producto
    Public Shared Sub ActualizarReceta(ByVal idProducto As Integer, ByVal ingredientes As List(Of Tuple(Of Integer, Decimal)))
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")

        Try
            cn.Open()
            For Each ingrediente In ingredientes
                Dim cmd As New SqlCommand("sp_ActualizarReceta", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdProducto", idProducto)
                cmd.Parameters.AddWithValue("@IdMaterial", ingrediente.Item1)
                cmd.Parameters.AddWithValue("@Cantidad", ingrediente.Item2)
                cmd.ExecuteNonQuery()
            Next
        Catch ex As Exception
            Throw New Exception("Error al actualizar la receta: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub
    Public Shared Sub EliminarReceta(ByVal idProducto As Integer)
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")
        Dim cmd As New SqlCommand("sp_EliminarReceta", cn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@IdProducto", idProducto)

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al Eliminar la receta: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

End Class

