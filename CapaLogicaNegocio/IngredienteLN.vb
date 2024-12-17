Imports CapaAccesoDatos
Public Class IngredienteLN
    Public Shared Function ListarIngredientes() As DataTable
        Return IngredienteAD.ListarIngredientes()
    End Function

    Public Shared Function InsertarIngrediente(ByVal nombre As String, ByVal precioUnitario As Decimal) As Integer
        Return IngredienteAD.InsertarIngrediente(nombre, precioUnitario)
    End Function
End Class
