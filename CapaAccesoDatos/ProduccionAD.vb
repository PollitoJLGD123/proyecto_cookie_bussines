Imports System.Data.SqlClient

Public Class ProduccionAD
    ' Listar pedidos
    Public Shared Function ListarPedidos() As DataTable
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")
        Dim cmd As New SqlCommand("sp_ListarPedidos", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable()
        Try
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar los pedidos: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Function

    ' Obtener cliente y productos del pedido
    Public Shared Function ObtenerPedidoPorId(ByVal idPedido As Integer) As DataSet
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")
        Dim cmd As New SqlCommand("sp_ObtenerPedidoPorId", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@IdPedido", idPedido)

        Dim ds As New DataSet()
        Try
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds)
            Return ds
        Catch ex As Exception
            Throw New Exception("Error al obtener los datos del pedido: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Function

    ' Obtener receta por producto
    Public Shared Function ObtenerRecetaPorProducto(ByVal idProducto As Integer) As DataTable
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")
        Dim cmd As New SqlCommand("sp_ObtenerRecetaPorProducto", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@IdProducto", idProducto)

        Dim dt As New DataTable()
        Try
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al obtener la receta: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Function

    ' Registrar producción
    Public Shared Function RegistrarProduccion(ByVal fecha As Date, ByVal idPedido As Integer) As Integer
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")
        Dim cmd As New SqlCommand("sp_RegistrarProduccion", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Fecha", fecha)
        cmd.Parameters.AddWithValue("@IdPedido", idPedido)
        cmd.Parameters.Add("@IdProduccion", SqlDbType.Int).Direction = ParameterDirection.Output

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            Return Convert.ToInt32(cmd.Parameters("@IdProduccion").Value)
        Catch ex As Exception
            Throw New Exception("Error al registrar la producción: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Function

    ' Asignar empleados a la producción
    Public Shared Sub AsignarEmpleadoAProduccion(ByVal idProduccion As Integer, ByVal idEmpleado As Integer)
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")
        Dim cmd As New SqlCommand("sp_AsignarEmpleadoAProduccion", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@IdProduccion", idProduccion)
        cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado)

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error al asignar el empleado a la producción: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub
    Public Shared Function ListarEmpleados() As DataTable
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")
        Dim cmd As New SqlCommand("sp_ListarEmpleados", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable()

        Try
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt) ' Llenar el DataTable con los datos obtenidos
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar los empleados: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Function

End Class
