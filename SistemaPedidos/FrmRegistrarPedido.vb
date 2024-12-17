Imports CapaLogicaNegocio
Imports Entidad
Public Class FrmRegistrarPedido
    Private detalles As New List(Of Tuple(Of Integer, String, Decimal))

    Private Sub btnCargarProductos_Click(sender As Object, e As EventArgs) Handles btnCargarProductos.Click
        Dim dt As DataTable = PedidoLN.ListarProductos()
        lstProductos.Items.Clear()

        For Each row As DataRow In dt.Rows
            lstProductos.Items.Add($"{row("id_producto")} - {row("nombre")} - {row("descripcion")}")
        Next
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        If lstProductos.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione un producto")
            Return
        End If

        Dim productoSeleccionado As String = lstProductos.SelectedItem.ToString()
        Dim idProducto As Integer = Convert.ToInt32(productoSeleccionado.Split("-")(0).Trim())
        Dim nombreProducto As String = productoSeleccionado.Split("-")(1).Trim()
        Dim cantidad As Decimal

        If Not Decimal.TryParse(txtCantidad.Text, cantidad) OrElse cantidad <= 0 Then
            MessageBox.Show("Ingrese una cantidad válida")
            Return
        End If

        Dim productoExistente = detalles.FirstOrDefault(Function(p) p.Item1 = idProducto)

        If productoExistente IsNot Nothing Then
            detalles.Remove(productoExistente)
            detalles.Add(New Tuple(Of Integer, String, Decimal)(idProducto, nombreProducto, productoExistente.Item3 + cantidad))
        Else
            detalles.Add(New Tuple(Of Integer, String, Decimal)(idProducto, nombreProducto, cantidad))
        End If

        ActualizarListaDetalle()
    End Sub

    Private Sub ActualizarListaDetalle()
        lstDetallePedido.Items.Clear()

        For Each detalle In detalles
            lstDetallePedido.Items.Add($"{detalle.Item1} - {detalle.Item2} - {detalle.Item3}")
        Next
    End Sub

    Private Sub btnRegistrarPedido_Click(sender As Object, e As EventArgs) Handles btnRegistrarPedido.Click
        If lstProductos.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione un producto")
            Return
        End If

        Dim nombre As String = txtCliente.Text
        Dim fechaPedido As Date = dtpFechaPedido.Value
        Dim Apellidos As String = txtApellidos.Text
        Dim DNI As String = txtDNI.Text

        If nombre = "" Or Apellidos = "" Or DNI = "" Then
            MessageBox.Show("Ingrese datos por favor")
        Else
            Try
                Dim idPedido As Integer = PedidoLN.InsertarPedido(fechaPedido, nombre, Apellidos, DNI)

                For Each detalle In detalles
                    PedidoLN.InsertarProductoPorPedido(idPedido, detalle.Item1, detalle.Item3)
                Next

                MessageBox.Show("Pedido registrado con éxito")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtEliminar_Click(sender As Object, e As EventArgs) Handles txtEliminar.Click

        If lstDetallePedido.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione un producto que quieres eliminar")
            Return
        End If


        Dim productoSeleccionado As String = lstDetallePedido.SelectedItem.ToString()
        Dim idProducto As Integer = Convert.ToInt32(productoSeleccionado.Split("-")(0).Trim())
        Dim nombreProducto As String = productoSeleccionado.Split("-")(1).Trim()
        Dim cantidad As Decimal = productoSeleccionado.Split("-")(2).Trim()

        Dim tuplaAEliminar As Tuple(Of Integer, String, Decimal) = Tuple.Create(idProducto, nombreProducto, cantidad)

        detalles.Remove(tuplaAEliminar)
        ActualizarListaDetalle()

    End Sub

    Private Sub lstDetallePedido_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDetallePedido.SelectedIndexChanged

    End Sub
End Class
