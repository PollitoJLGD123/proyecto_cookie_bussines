Imports System.Data.SqlClient
Imports Entidad

Public Class PedidoAD
    Public Shared Function InsertarPedido(ByVal fechaPedido As Date, ByVal nombre As String, ByVal apellido As String, ByVal dni As String) As Integer
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")
        Dim cmd As New SqlCommand("sp_InsertarPedido", cn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@FechaPedido", fechaPedido)
        cmd.Parameters.AddWithValue("@nombre", nombre)
        cmd.Parameters.AddWithValue("@apellido", apellido)
        cmd.Parameters.AddWithValue("@dni", dni)
        cmd.Parameters.Add("@IdPedido", SqlDbType.Int).Direction = ParameterDirection.Output

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            Return Convert.ToInt32(cmd.Parameters("@IdPedido").Value)
        Catch ex As Exception
            Throw New Exception("Error al insertar el pedido: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Function

    Public Shared Sub InsertarProductoPorPedido(ByVal idPedido As Integer, ByVal idProducto As Integer, ByVal cantidad As Decimal)
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")
        Dim cmd As New SqlCommand("sp_InsertarProductosPorPedido", cn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@IdPedido", idPedido)
        cmd.Parameters.AddWithValue("@IdProducto", idProducto)
        cmd.Parameters.AddWithValue("@Cantidad", cantidad)

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al insertar el producto en el pedido: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Public Shared Function ListarProductos() As DataTable
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")
        Dim cmd As New SqlCommand("sp_ListarProductos", cn)
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
End Class

