Imports CapaLogicaNegocio
Public Class frmEditarProducto
    Private IdProducto As Integer
    Private NuevaReceta As New List(Of Tuple(Of Integer, Decimal))

    Public Sub New(ByVal idProductoSeleccionado As Integer)
        InitializeComponent()
        IdProducto = idProductoSeleccionado
    End Sub

    Private Sub frmEditarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Obtener los detalles del producto seleccionado
            Dim dsProducto As DataSet = ProductoLN.ObtenerProductoConReceta(IdProducto)

            ' Mostrar el nombre y la descripción del producto
            txtNombreProducto.Text = dsProducto.Tables(0).Rows(0)("nombre").ToString()
            txtDescripcionProducto.Text = dsProducto.Tables(0).Rows(0)("descripcion").ToString()

            ' Cargar la receta actual en la lista no editable
            lstRecetaActual.Items.Clear()
            For Each row As DataRow In dsProducto.Tables(1).Rows
                lstRecetaActual.Items.Add($"{row("Ingrediente")} - {row("Cantidad")}")
            Next

            ' Cargar la lista de ingredientes disponibles
            Dim dtIngredientes As DataTable = IngredienteLN.ListarIngredientes()
            lstIngredientes.Items.Clear()
            For Each row As DataRow In dtIngredientes.Rows
                lstIngredientes.Items.Add($"{row("id_material")} - {row("nombre")}")
            Next
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos del producto: " & ex.Message)
        End Try
    End Sub


    ' Botón para agregar un nuevo ingrediente a la receta
    Private Sub btnAgregarIngrediente_Click(sender As Object, e As EventArgs) Handles btnAgregarIngrediente.Click
        Try
            ' Validar que se haya seleccionado un ingrediente
            If lstIngredientes.SelectedItem Is Nothing Then
                MessageBox.Show("Seleccione un ingrediente.")
                Return
            End If

            ' Validar que la cantidad ingresada sea válida
            Dim cantidad As Decimal
            If Not Decimal.TryParse(txtCantidadIngrediente.Text, cantidad) OrElse cantidad <= 0 Then
                MessageBox.Show("Ingrese una cantidad válida.")
                Return
            End If

            ' Obtener los datos del ingrediente seleccionado
            Dim ingredienteSeleccionado As String = lstIngredientes.SelectedItem.ToString()
            Dim idMaterial As Integer = Convert.ToInt32(ingredienteSeleccionado.Split("-")(0).Trim())
            Dim nombreMaterial As String = ingredienteSeleccionado.Split("-")(1).Trim()

            ' Agregar el ingrediente a la nueva receta
            NuevaReceta.Add(New Tuple(Of Integer, Decimal)(idMaterial, cantidad))
            lstNuevaReceta.Items.Add($"{nombreMaterial} - {cantidad}")

            ' Limpiar el campo de cantidad
            txtCantidadIngrediente.Clear()
        Catch ex As Exception
            MessageBox.Show("Error al agregar el ingrediente: " & ex.Message)
        End Try
    End Sub
    'Agregar un nuevo ingrediente
    Private Sub btnAgregarNuevoIngrediente_Click(sender As Object, e As EventArgs) Handles btnAgregarNuevoIngrediente.Click
        Dim frmNuevoIngrediente As New frmNuevoIngrediente()
        frmNuevoIngrediente.ShowDialog()

        ' Actualizar la lista de ingredientes si se agregó uno nuevo
        If frmNuevoIngrediente.IngredienteAgregado Then
            Dim dtIngredientes As DataTable = IngredienteLN.ListarIngredientes()
            lstIngredientes.Items.Clear()
            For Each row As DataRow In dtIngredientes.Rows
                lstIngredientes.Items.Add($"{row("id_material")} - {row("nombre")}")
            Next
        End If
    End Sub
    'Registrar Cambios del producto y la nueva receta
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            ' Validar que se haya ingresado un nombre y una descripción
            Dim nuevoNombre As String = txtNombreProducto.Text.Trim()
            Dim nuevaDescripcion As String = txtDescripcionProducto.Text.Trim()

            If String.IsNullOrWhiteSpace(nuevoNombre) OrElse String.IsNullOrWhiteSpace(nuevaDescripcion) Then
                MessageBox.Show("Ingrese el nombre y la descripción del producto.")
                Return
            End If

            ProductoLN.EliminarReceta(IdProducto)
            ' Actualizar el producto
            ProductoLN.ActualizarProducto(IdProducto, nuevoNombre, nuevaDescripcion)

            ' Actualizar la receta del producto

            ProductoLN.ActualizarReceta(IdProducto, NuevaReceta)



            MessageBox.Show("Producto y receta actualizados con éxito.")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al registrar los cambios: " & ex.Message)
        End Try
    End Sub


    ' Botón para cancelar la edición
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
