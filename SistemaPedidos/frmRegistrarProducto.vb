Imports CapaLogicaNegocio
Public Class frmRegistrarProducto
    Private receta As New List(Of Tuple(Of Integer, String, Decimal))

    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarIngredientes()
    End Sub

    Private Sub CargarIngredientes()
        Dim dt As DataTable = IngredienteLN.ListarIngredientes()
        lstIngredientes.Items.Clear()

        For Each row As DataRow In dt.Rows
            lstIngredientes.Items.Add($"{row("id_material")} - {row("nombre")}")
        Next
    End Sub

    Private Sub btnAgregarIngrediente_Click(sender As Object, e As EventArgs) Handles btnAgregarIngrediente.Click
        If lstIngredientes.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione un ingrediente")
            Return
        End If

        Dim ingredienteSeleccionado As String = lstIngredientes.SelectedItem.ToString()
        Dim idMaterial As Integer = Convert.ToInt32(ingredienteSeleccionado.Split("-")(0).Trim())
        Dim nombreMaterial As String = ingredienteSeleccionado.Split("-")(1).Trim()
        Dim cantidad As Decimal

        If Not Decimal.TryParse(txtCantidadIngrediente.Text, cantidad) OrElse cantidad <= 0 Then
            MessageBox.Show("Ingrese una cantidad válida")
            Return
        End If

        receta.Add(New Tuple(Of Integer, String, Decimal)(idMaterial, nombreMaterial, cantidad))
        ActualizarListaReceta()
        txtCantidadIngrediente.Clear()
    End Sub

    Private Sub ActualizarListaReceta()
        lstReceta.Items.Clear()

        For Each r In receta
            lstReceta.Items.Add($"{r.Item2} - {r.Item3:F2}")
        Next
    End Sub

    Private Sub btnRegistrarProducto_Click(sender As Object, e As EventArgs) Handles btnRegistrarProducto.Click
        Dim nombreProducto As String = txtNombreProducto.Text
        Dim descripcionProducto As String = txtDescripcionProducto.Text

        If String.IsNullOrWhiteSpace(nombreProducto) Then
            MessageBox.Show("Ingrese el nombre del producto.")
            Return
        End If

        If String.IsNullOrWhiteSpace(descripcionProducto) Then
            MessageBox.Show("Ingrese la descripción del producto.")
            Return
        End If

        Try
            Dim idProducto As Integer = ProductoLN.InsertarProducto(nombreProducto, descripcionProducto)

            For Each r In receta
                ProductoLN.InsertarReceta(idProducto, r.Item1, r.Item3)
            Next

            MessageBox.Show("Producto registrado con éxito")

            LimpiarControles()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnAgregarNuevoIngrediente_Click(sender As Object, e As EventArgs) Handles btnAgregarNuevoIngrediente.Click
        ' Abrir el formulario para agregar un nuevo ingrediente
        Dim nuevoIngredienteForm As New frmNuevoIngrediente()
        nuevoIngredienteForm.ShowDialog()

        ' Si se agregó un ingrediente, recargar la lista de ingredientes
        If nuevoIngredienteForm.IngredienteAgregado Then
            CargarIngredientes()
        End If
    End Sub
    Private Sub LimpiarControles()
        ' Limpiar las cajas de texto
        txtNombreProducto.Clear()
        txtDescripcionProducto.Clear()

        ' Limpiar la lista de la receta
        lstReceta.Items.Clear()

        ' Limpiar la lista interna de la receta
        receta.Clear()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarControles()
        txtCantidadIngrediente.Clear()
    End Sub
End Class
