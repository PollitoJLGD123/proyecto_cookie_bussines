Imports CapaLogicaNegocio
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

        detalles.Add(New Tuple(Of Integer, String, Decimal)(idProducto, nombreProducto, cantidad))
        ActualizarListaDetalle()
    End Sub

    Private Sub ActualizarListaDetalle()
        lstDetallePedido.Items.Clear()

        For Each detalle In detalles
            lstDetallePedido.Items.Add($"{detalle.Item1} - {detalle.Item2} - {detalle.Item3}")
        Next
    End Sub

    Private Sub btnRegistrarPedido_Click(sender As Object, e As EventArgs) Handles btnRegistrarPedido.Click
        If detalles.Count = 0 Then
            MessageBox.Show("Agregue al menos un producto al pedido")
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
End Class
