<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRegistrarPedido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lstProductos = New System.Windows.Forms.ListBox()
        Me.lstDetallePedido = New System.Windows.Forms.ListBox()
        Me.dtpFechaPedido = New System.Windows.Forms.DateTimePicker()
        Me.btnCargarProductos = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.btnRegistrarPedido = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(127, 54)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(289, 22)
        Me.txtCliente.TabIndex = 0
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(161, 511)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(132, 22)
        Me.txtCantidad.TabIndex = 1
        '
        'lstProductos
        '
        Me.lstProductos.FormattingEnabled = True
        Me.lstProductos.ItemHeight = 16
        Me.lstProductos.Location = New System.Drawing.Point(13, 237)
        Me.lstProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.lstProductos.Name = "lstProductos"
        Me.lstProductos.Size = New System.Drawing.Size(357, 244)
        Me.lstProductos.TabIndex = 2
        '
        'lstDetallePedido
        '
        Me.lstDetallePedido.FormattingEnabled = True
        Me.lstDetallePedido.ItemHeight = 16
        Me.lstDetallePedido.Location = New System.Drawing.Point(506, 221)
        Me.lstDetallePedido.Margin = New System.Windows.Forms.Padding(4)
        Me.lstDetallePedido.Name = "lstDetallePedido"
        Me.lstDetallePedido.Size = New System.Drawing.Size(273, 260)
        Me.lstDetallePedido.TabIndex = 3
        '
        'dtpFechaPedido
        '
        Me.dtpFechaPedido.Location = New System.Drawing.Point(506, 118)
        Me.dtpFechaPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaPedido.Name = "dtpFechaPedido"
        Me.dtpFechaPedido.Size = New System.Drawing.Size(265, 22)
        Me.dtpFechaPedido.TabIndex = 4
        '
        'btnCargarProductos
        '
        Me.btnCargarProductos.Location = New System.Drawing.Point(378, 237)
        Me.btnCargarProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCargarProductos.Name = "btnCargarProductos"
        Me.btnCargarProductos.Size = New System.Drawing.Size(111, 60)
        Me.btnCargarProductos.TabIndex = 5
        Me.btnCargarProductos.Text = "Cargar Productos"
        Me.btnCargarProductos.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(378, 322)
        Me.btnAgregarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(111, 62)
        Me.btnAgregarProducto.TabIndex = 6
        Me.btnAgregarProducto.Text = "Agregar Producto"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'btnRegistrarPedido
        '
        Me.btnRegistrarPedido.Location = New System.Drawing.Point(594, 496)
        Me.btnRegistrarPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegistrarPedido.Name = "btnRegistrarPedido"
        Me.btnRegistrarPedido.Size = New System.Drawing.Size(133, 52)
        Me.btnRegistrarPedido.TabIndex = 7
        Me.btnRegistrarPedido.Text = "Registrar Pedido"
        Me.btnRegistrarPedido.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ravie", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cliente: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ravie", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 511)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Cantidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "DNI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Apellidos"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(127, 120)
        Me.txtApellidos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(289, 22)
        Me.txtApellidos.TabIndex = 13
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(127, 182)
        Me.txtDNI.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(289, 22)
        Me.txtDNI.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ravie", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(513, 78)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 22)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Fecha"
        '
        'txtEliminar
        '
        Me.txtEliminar.Location = New System.Drawing.Point(378, 419)
        Me.txtEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEliminar.Name = "txtEliminar"
        Me.txtEliminar.Size = New System.Drawing.Size(111, 62)
        Me.txtEliminar.TabIndex = 16
        Me.txtEliminar.Text = "Eliminar Producto"
        Me.txtEliminar.UseVisualStyleBackColor = True
        '
        'FrmRegistrarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 576)
        Me.Controls.Add(Me.txtEliminar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegistrarPedido)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.btnCargarProductos)
        Me.Controls.Add(Me.dtpFechaPedido)
        Me.Controls.Add(Me.lstDetallePedido)
        Me.Controls.Add(Me.lstProductos)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtCliente)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmRegistrarPedido"
        Me.Text = "FrmPedido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lstProductos As ListBox
    Friend WithEvents lstDetallePedido As ListBox
    Friend WithEvents dtpFechaPedido As DateTimePicker
    Friend WithEvents btnCargarProductos As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents btnRegistrarPedido As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEliminar As Button
End Class
