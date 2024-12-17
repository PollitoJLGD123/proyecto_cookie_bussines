Imports CapaLogicaNegocio

Public Class frmNuevoIngrediente
    Public IngredienteAgregado As Boolean = False ' Indicador para saber si se agregó un ingrediente

    Private Sub btnGuardarIngrediente_Click(sender As Object, e As EventArgs) Handles btnGuardarIngrediente.Click
        Dim nombreIngrediente As String = txtNombreIngrediente.Text
        Dim precioUnitario As Decimal

        ' Validar los campos ingresados
        If String.IsNullOrWhiteSpace(nombreIngrediente) Then
            MessageBox.Show("Ingrese el nombre del ingrediente.")
            Return
        End If

        If Not Decimal.TryParse(txtPrecioUnitario.Text, precioUnitario) OrElse precioUnitario <= 0 Then
            MessageBox.Show("Ingrese un precio unitario válido.")
            Return
        End If

        Try
            ' Llamar a la lógica de negocios para registrar el ingrediente
            IngredienteLN.InsertarIngrediente(nombreIngrediente, precioUnitario)

            MessageBox.Show("Ingrediente agregado con éxito.")
            IngredienteAgregado = True ' Marcar que se agregó un nuevo ingrediente
            Me.Close() ' Cerrar el formulario
        Catch ex As Exception
            MessageBox.Show("Error al agregar el ingrediente: " & ex.Message)
        End Try
    End Sub
End Class
