<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarProduccion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbPedidos = New System.Windows.Forms.ComboBox()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtCantidadPedida = New System.Windows.Forms.TextBox()
        Me.txtCostoUnitario = New System.Windows.Forms.TextBox()
        Me.txtCostoProduccion = New System.Windows.Forms.TextBox()
        Me.lstIngredientes = New System.Windows.Forms.ListBox()
        Me.lstEmpleados = New System.Windows.Forms.ListBox()
        Me.lstEmpleadosAsignados = New System.Windows.Forms.ListBox()
        Me.btnComenzarProduccion = New System.Windows.Forms.Button()
        Me.btnCalcularCosto = New System.Windows.Forms.Button()
        Me.btnAsignarEmpleados = New System.Windows.Forms.Button()
        Me.btnRegistrarHoja = New System.Windows.Forms.Button()
        Me.dtpFechaProduccion = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbPedidos
        '
        Me.cmbPedidos.FormattingEnabled = True
        Me.cmbPedidos.Location = New System.Drawing.Point(36, 37)
        Me.cmbPedidos.Name = "cmbPedidos"
        Me.cmbPedidos.Size = New System.Drawing.Size(161, 21)
        Me.cmbPedidos.TabIndex = 0
        '
        'cmbProductos
        '
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(254, 37)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(176, 21)
        Me.cmbProductos.TabIndex = 1
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(36, 104)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(185, 20)
        Me.txtCliente.TabIndex = 2
        '
        'txtCantidadPedida
        '
        Me.txtCantidadPedida.Location = New System.Drawing.Point(254, 104)
        Me.txtCantidadPedida.Name = "txtCantidadPedida"
        Me.txtCantidadPedida.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadPedida.TabIndex = 3
        '
        'txtCostoUnitario
        '
        Me.txtCostoUnitario.Location = New System.Drawing.Point(36, 323)
        Me.txtCostoUnitario.Name = "txtCostoUnitario"
        Me.txtCostoUnitario.Size = New System.Drawing.Size(100, 20)
        Me.txtCostoUnitario.TabIndex = 4
        '
        'txtCostoProduccion
        '
        Me.txtCostoProduccion.Location = New System.Drawing.Point(158, 417)
        Me.txtCostoProduccion.Name = "txtCostoProduccion"
        Me.txtCostoProduccion.Size = New System.Drawing.Size(100, 20)
        Me.txtCostoProduccion.TabIndex = 5
        '
        'lstIngredientes
        '
        Me.lstIngredientes.FormattingEnabled = True
        Me.lstIngredientes.Location = New System.Drawing.Point(12, 156)
        Me.lstIngredientes.Name = "lstIngredientes"
        Me.lstIngredientes.Size = New System.Drawing.Size(482, 134)
        Me.lstIngredientes.TabIndex = 6
        '
        'lstEmpleados
        '
        Me.lstEmpleados.FormattingEnabled = True
        Me.lstEmpleados.Location = New System.Drawing.Point(607, 37)
        Me.lstEmpleados.Name = "lstEmpleados"
        Me.lstEmpleados.Size = New System.Drawing.Size(176, 212)
        Me.lstEmpleados.TabIndex = 7
        '
        'lstEmpleadosAsignados
        '
        Me.lstEmpleadosAsignados.FormattingEnabled = True
        Me.lstEmpleadosAsignados.Location = New System.Drawing.Point(598, 364)
        Me.lstEmpleadosAsignados.Name = "lstEmpleadosAsignados"
        Me.lstEmpleadosAsignados.Size = New System.Drawing.Size(193, 108)
        Me.lstEmpleadosAsignados.TabIndex = 8
        '
        'btnComenzarProduccion
        '
        Me.btnComenzarProduccion.Location = New System.Drawing.Point(455, 57)
        Me.btnComenzarProduccion.Name = "btnComenzarProduccion"
        Me.btnComenzarProduccion.Size = New System.Drawing.Size(121, 52)
        Me.btnComenzarProduccion.TabIndex = 9
        Me.btnComenzarProduccion.Text = "Cargar Receta"
        Me.btnComenzarProduccion.UseVisualStyleBackColor = True
        '
        'btnCalcularCosto
        '
        Me.btnCalcularCosto.Location = New System.Drawing.Point(217, 323)
        Me.btnCalcularCosto.Name = "btnCalcularCosto"
        Me.btnCalcularCosto.Size = New System.Drawing.Size(90, 48)
        Me.btnCalcularCosto.TabIndex = 10
        Me.btnCalcularCosto.Text = "Calcular Costo Total"
        Me.btnCalcularCosto.UseVisualStyleBackColor = True
        '
        'btnAsignarEmpleados
        '
        Me.btnAsignarEmpleados.Location = New System.Drawing.Point(627, 285)
        Me.btnAsignarEmpleados.Name = "btnAsignarEmpleados"
        Me.btnAsignarEmpleados.Size = New System.Drawing.Size(141, 56)
        Me.btnAsignarEmpleados.TabIndex = 11
        Me.btnAsignarEmpleados.Text = "Asignar Empleado"
        Me.btnAsignarEmpleados.UseVisualStyleBackColor = True
        '
        'btnRegistrarHoja
        '
        Me.btnRegistrarHoja.Location = New System.Drawing.Point(715, 504)
        Me.btnRegistrarHoja.Name = "btnRegistrarHoja"
        Me.btnRegistrarHoja.Size = New System.Drawing.Size(94, 41)
        Me.btnRegistrarHoja.TabIndex = 12
        Me.btnRegistrarHoja.Text = "Registrar Hoja de Produccion"
        Me.btnRegistrarHoja.UseVisualStyleBackColor = True
        '
        'dtpFechaProduccion
        '
        Me.dtpFechaProduccion.Location = New System.Drawing.Point(343, 414)
        Me.dtpFechaProduccion.Name = "dtpFechaProduccion"
        Me.dtpFechaProduccion.Size = New System.Drawing.Size(218, 20)
        Me.dtpFechaProduccion.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Lista de Pedidos por Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Productos Asignados al pedido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Nombre del Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Cantidad Pedida"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Lista de Ingredientes de la receta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(604, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Lista total de empleados"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(595, 348)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(199, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Empleados Asignados a esta produccion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 420)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Costo total de Produccion"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 307)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Costo de produccion unitario"
        '
        'frmRegistrarProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 572)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFechaProduccion)
        Me.Controls.Add(Me.btnRegistrarHoja)
        Me.Controls.Add(Me.btnAsignarEmpleados)
        Me.Controls.Add(Me.btnCalcularCosto)
        Me.Controls.Add(Me.btnComenzarProduccion)
        Me.Controls.Add(Me.lstEmpleadosAsignados)
        Me.Controls.Add(Me.lstEmpleados)
        Me.Controls.Add(Me.lstIngredientes)
        Me.Controls.Add(Me.txtCostoProduccion)
        Me.Controls.Add(Me.txtCostoUnitario)
        Me.Controls.Add(Me.txtCantidadPedida)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.cmbProductos)
        Me.Controls.Add(Me.cmbPedidos)
        Me.Name = "frmRegistrarProduccion"
        Me.Text = "frmProduccion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbPedidos As ComboBox
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtCantidadPedida As TextBox
    Friend WithEvents txtCostoUnitario As TextBox
    Friend WithEvents txtCostoProduccion As TextBox
    Friend WithEvents lstIngredientes As ListBox
    Friend WithEvents lstEmpleados As ListBox
    Friend WithEvents lstEmpleadosAsignados As ListBox
    Friend WithEvents btnComenzarProduccion As Button
    Friend WithEvents btnCalcularCosto As Button
    Friend WithEvents btnAsignarEmpleados As Button
    Friend WithEvents btnRegistrarHoja As Button
    Friend WithEvents dtpFechaProduccion As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
