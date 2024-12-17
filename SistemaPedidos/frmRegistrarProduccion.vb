Imports CapaLogicaNegocio
Public Class frmRegistrarProduccion
    Private Sub frmProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar la lista de pedidos en cmbPedidos
        Dim dtPedidos As DataTable = ProduccionLN.ListarPedidos()

        cmbPedidos.DataSource = dtPedidos
        cmbPedidos.DisplayMember = "fecha_pedido"
        cmbPedidos.ValueMember = "id_pedido"

        ' Cargar la lista de empleados en lstEmpleados
        CargarEmpleados()
    End Sub
    Private Sub CargarEmpleados()
        Try
            ' Obtener los empleados desde la lógica de negocio
            Dim dtEmpleados As DataTable = ProduccionLN.ListarEmpleados()

            ' Limpiar el ListBox antes de cargar nuevos datos
            lstEmpleados.Items.Clear()

            ' Agregar cada empleado al ListBox
            For Each row As DataRow In dtEmpleados.Rows
                Dim idEmpleado As Integer = Convert.ToInt32(row("id_empleado"))
                Dim nombreCompleto As String = $"{row("nombre")} {row("apellidos")}"

                lstEmpleados.Items.Add($"{idEmpleado} - {nombreCompleto}")
            Next
        Catch ex As Exception
            MessageBox.Show("Error al cargar los empleados: " & ex.Message)
        End Try
    End Sub
    Private Sub cmbPedidos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPedidos.SelectedIndexChanged
        If cmbPedidos.SelectedValue IsNot Nothing Then
            Dim selectedRow As DataRowView = CType(cmbPedidos.SelectedItem, DataRowView)
            Dim idPedido As Integer = Convert.ToInt32(selectedRow("id_pedido"))
            Dim dsPedido As DataSet = ProduccionLN.ObtenerPedidoPorId(idPedido)

            ' Verificar que se obtuvieron datos válidos
            If dsPedido IsNot Nothing AndAlso dsPedido.Tables.Count > 1 Then
                ' Mostrar el cliente
                txtCliente.Text = dsPedido.Tables(0).Rows(0)("nombre").ToString()

                ' Cargar los productos relacionados con el pedido en cmbProductos
                cmbProductos.DataSource = dsPedido.Tables(1)
                cmbProductos.DisplayMember = "nombre"
                cmbProductos.ValueMember = "id_producto"
            Else
                MessageBox.Show("No se encontraron productos relacionados con este pedido.")
            End If
        End If
    End Sub
    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        If cmbProductos.SelectedValue IsNot Nothing Then
            Dim rowView As DataRowView = CType(cmbProductos.SelectedItem, DataRowView)
            txtCantidadPedida.Text = rowView("cantidad").ToString()
            btnComenzarProduccion.Enabled = True ' Habilitar el botón para comenzar la producción
        End If
    End Sub
    Private Sub btnComenzarProduccion_Click(sender As Object, e As EventArgs) Handles btnComenzarProduccion.Click
        Dim idProducto As Integer = Convert.ToInt32(cmbProductos.SelectedValue)
        Dim dtReceta As DataTable = ProduccionLN.ObtenerRecetaPorProducto(idProducto)

        ' Mostrar los ingredientes en lstIngredientes
        lstIngredientes.Items.Clear()
        Dim costoTotal As Decimal

        For Each row As DataRow In dtReceta.Rows
            Dim ingrediente As String = row("Ingrediente").ToString()
            Dim cantidadUsada As Decimal = Convert.ToDecimal(row("CantidadUsada"))
            Dim precioUnitario As Decimal = Convert.ToDecimal(row("PrecioUnitario"))
            Dim precioCalculado As Decimal = Convert.ToDecimal(row("PrecioCalculado"))

            ' Calcular el costo total unitario
            costoTotal += precioCalculado

            lstIngredientes.Items.Add($"Ingrediente: {ingrediente} - Medida: {cantidadUsada} - Precio unitario: {precioUnitario:C} - Costo de produccion: {precioCalculado:C}")
        Next

        txtCostoUnitario.Text = costoTotal.ToString("F2")
    End Sub
    Private Sub btnCalcularCosto_Click(sender As Object, e As EventArgs) Handles btnCalcularCosto.Click
        Dim costoUnitario As Decimal = Convert.ToDecimal(txtCostoUnitario.Text)
        Dim cantidadProduccion As Decimal = Convert.ToDecimal(txtCantidadPedida.Text)
        Dim costoTotalProduccion As Decimal = costoUnitario * cantidadProduccion

        txtCostoProduccion.Text = costoTotalProduccion.ToString("F2")
    End Sub
    Private Sub btnAsignarEmpleados_Click(sender As Object, e As EventArgs) Handles btnAsignarEmpleados.Click
        If lstEmpleados.SelectedItems.Count > 0 Then
            For Each item As String In lstEmpleados.SelectedItems
                ' Extraer el id_empleado y el nombre de la cadena en formato "id_empleado - Nombre"
                Dim partes() As String = item.Split("-"c)
                Dim idEmpleado As Integer = Convert.ToInt32(partes(0).Trim())
                Dim nombreEmpleado As String = partes(1).Trim()

                ' Agregar empleado a la lista de asignados si no está ya presente
                If Not lstEmpleadosAsignados.Items.Contains($"{idEmpleado} - {nombreEmpleado}") Then
                    lstEmpleadosAsignados.Items.Add($"{idEmpleado} - {nombreEmpleado}")
                End If
            Next
        Else
            MessageBox.Show("Seleccione al menos un empleado para asignar.")
        End If
    End Sub

    Private Sub btnRegistrarHoja_Click(sender As Object, e As EventArgs) Handles btnRegistrarHoja.Click
        Try
            ' Verificar si los campos necesarios están llenos
            If cmbPedidos.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar un pedido.")
                Return
            End If

            If cmbProductos.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar un producto.")
                Return
            End If

            If String.IsNullOrWhiteSpace(txtCantidadPedida.Text) Then
                MessageBox.Show("Debe ingresar la cantidad solicitada.")
                Return
            End If

            Dim fechaProduccion As Date = dtpFechaProduccion.Value
            Dim idPedido As Integer = Convert.ToInt32(cmbPedidos.SelectedValue)

            ' Registrar la producción
            Dim idProduccion As Integer = ProduccionLN.RegistrarProduccion(fechaProduccion, idPedido)

            ' Registrar empleados en la producción
            For Each item As String In lstEmpleadosAsignados.Items
                Dim idEmpleado As Integer = Convert.ToInt32(item.Split("-")(0).Trim())
                ProduccionLN.AsignarEmpleadoAProduccion(idProduccion, idEmpleado)
            Next

            MessageBox.Show("Hoja de producción registrada con éxito.")
            LimpiarFormulario()
        Catch ex As Exception
            MessageBox.Show("Error al registrar la producción: " & ex.Message)
        End Try
    End Sub

    Private Sub LimpiarFormulario()
        cmbPedidos.SelectedIndex = -1
        cmbProductos.DataSource = Nothing
        txtCliente.Clear()
        txtCantidadPedida.Clear()
        txtCostoUnitario.Clear()
        txtCostoProduccion.Clear()
        lstIngredientes.Items.Clear()
        lstEmpleadosAsignados.Items.Clear()
        btnComenzarProduccion.Enabled = False
    End Sub

End Class