Imports System.Data.SqlClient

Public Class IngredienteAD
    Public Shared Function ListarIngredientes() As DataTable
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")
        Dim cmd As New SqlCommand("sp_ListarIngredientes", cn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable()

        Try
            cn.Open()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al listar los ingredientes: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Function

    Public Shared Function InsertarIngrediente(ByVal nombre As String, ByVal precioUnitario As Decimal) As Integer
        Dim cn As New SqlConnection("server=.; integrated security=true; database=Galletera")
        Dim cmd As New SqlCommand("sp_InsertarIngrediente", cn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@Nombre", nombre)
        cmd.Parameters.AddWithValue("@PrecioUnitario", precioUnitario)
        cmd.Parameters.Add("@IdMaterial", SqlDbType.Int).Direction = ParameterDirection.Output

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            Return Convert.ToInt32(cmd.Parameters("@IdMaterial").Value)
        Catch ex As Exception
            Throw New Exception("Error al insertar el ingrediente: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Function
End Class
