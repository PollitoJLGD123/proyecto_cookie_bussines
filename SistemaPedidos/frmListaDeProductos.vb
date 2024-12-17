Imports CapaLogicaNegocio
Public Class frmListaDeProductos
    Private Sub frmListaDeProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar los productos en el ComboBox
        Dim dtProductos As DataTable = ProductoLN.ListarProductos()
        cmbProductos.DataSource = dtProductos
        cmbProductos.DisplayMember = "nombre"
        cmbProductos.ValueMember = "id_producto"
        txtNombre.Enabled = False
        lstIngredientes.Enabled = False
        txtDescripcion.Enabled = False
    End Sub

    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        ' Mostrar los detalles del producto seleccionado
        If cmbProductos.SelectedValue IsNot Nothing Then
            Dim selectedRow As DataRowView = CType(cmbProductos.SelectedItem, DataRowView)
            Dim idProducto As Integer = Convert.ToInt32(selectedRow("id_Producto"))
            Dim dsProducto As DataSet = ProductoLN.ObtenerProductoConReceta(idProducto)

            ' Mostrar nombre y descripción
            txtNombre.Text = dsProducto.Tables(0).Rows(0)("nombre").ToString()
            txtDescripcion.Text = dsProducto.Tables(0).Rows(0)("descripcion").ToString()

            ' Mostrar la receta
            lstIngredientes.Items.Clear()
            For Each row As DataRow In dsProducto.Tables(1).Rows
                lstIngredientes.Items.Add($"{row("Ingrediente")} - {row("Cantidad")}")
            Next
        End If
    End Sub

    Private Sub btnEditarProducto_Click(sender As Object, e As EventArgs) Handles btnEditarProducto.Click
        ' Abrir el formulario para editar un producto
        Dim frmEditar As New frmEditarProducto(Convert.ToInt32(cmbProductos.SelectedValue))
        frmEditar.ShowDialog()

        ' Recargar productos después de la edición
        frmListaDeProductos_Load(sender, e)
    End Sub

    Private Sub btnRegistrarProductoNuevo_Click(sender As Object, e As EventArgs) Handles btnRegistrarProductoNuevo.Click
        ' Crear una instancia del formulario frmRegistrarPedido
        Dim frm As New frmRegistrarProducto()

        ' Mostrar el formulario
        frm.Show()

        ' Si deseas ocultar el formulario actual cuando se abre el nuevo formulario (opcional)
        Me.Hide()
    End Sub

End Class
