Public Class frmGalletera

    ' Control PictureBox para mostrar el GIF
    Private WithEvents pictureBox As New PictureBox()

    Private Sub frmGalletera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar PictureBox
        pictureBox.Dock = DockStyle.Fill  ' Asegura que ocupe todo el formulario
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage  ' Hace que el GIF se ajuste al tamaño del PictureBox

        ' Ruta del archivo GIF
        Dim rutaGif As String = "E:\UNT\Ciclo 06\DATOS\Recuperacion\SistemaPedidos\Imagenes\Galletera.gif"

        ' Cargar el GIF desde la ruta
        pictureBox.Image = Image.FromFile(rutaGif)

        ' Añadir PictureBox al formulario
        Me.Controls.Add(pictureBox)


    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        ' Crear una instancia del formulario frmListaDeProductos
        Dim frm As New frmListaDeProductos()

        ' Mostrar el formulario
        frm.Show()

        ' Si deseas ocultar el formulario actual cuando se abre el nuevo formulario (opcional)
        ' Me.Hide()
    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click
        ' Crear una instancia del formulario frmListaDeProductos
        Dim frm As New FrmRegistrarPedido()

        ' Mostrar el formulario
        frm.Show()

        ' Si deseas ocultar el formulario actual cuando se abre el nuevo formulario (opcional)
        ' Me.Hide()
    End Sub

    Private Sub ProduccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduccionToolStripMenuItem.Click
        ' Crear una instancia del formulario frmListaDeProductos
        Dim frm As New frmRegistrarProduccion()

        ' Mostrar el formulario
        frm.Show()

        ' Si deseas ocultar el formulario actual cuando se abre el nuevo formulario (opcional)
        ' Me.Hide()
    End Sub
End Class

