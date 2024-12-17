<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaDeProductos
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
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lstIngredientes = New System.Windows.Forms.ListBox()
        Me.btnEditarProducto = New System.Windows.Forms.Button()
        Me.btnRegistrarProductoNuevo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbProductos
        '
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(35, 36)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(187, 21)
        Me.cmbProductos.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(35, 86)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(175, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(35, 138)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(263, 20)
        Me.txtDescripcion.TabIndex = 2
        '
        'lstIngredientes
        '
        Me.lstIngredientes.FormattingEnabled = True
        Me.lstIngredientes.Location = New System.Drawing.Point(35, 188)
        Me.lstIngredientes.Name = "lstIngredientes"
        Me.lstIngredientes.Size = New System.Drawing.Size(336, 108)
        Me.lstIngredientes.TabIndex = 3
        '
        'btnEditarProducto
        '
        Me.btnEditarProducto.Location = New System.Drawing.Point(35, 335)
        Me.btnEditarProducto.Name = "btnEditarProducto"
        Me.btnEditarProducto.Size = New System.Drawing.Size(124, 60)
        Me.btnEditarProducto.TabIndex = 4
        Me.btnEditarProducto.Text = "Editar Producto"
        Me.btnEditarProducto.UseVisualStyleBackColor = True
        '
        'btnRegistrarProductoNuevo
        '
        Me.btnRegistrarProductoNuevo.Location = New System.Drawing.Point(235, 335)
        Me.btnRegistrarProductoNuevo.Name = "btnRegistrarProductoNuevo"
        Me.btnRegistrarProductoNuevo.Size = New System.Drawing.Size(116, 60)
        Me.btnRegistrarProductoNuevo.TabIndex = 5
        Me.btnRegistrarProductoNuevo.Text = "RegistrarProductoNuevo"
        Me.btnRegistrarProductoNuevo.UseVisualStyleBackColor = True
        '
        'frmListaDeProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 454)
        Me.Controls.Add(Me.btnRegistrarProductoNuevo)
        Me.Controls.Add(Me.btnEditarProducto)
        Me.Controls.Add(Me.lstIngredientes)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cmbProductos)
        Me.Name = "frmListaDeProductos"
        Me.Text = "frmListaDeProductos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lstIngredientes As ListBox
    Friend WithEvents btnEditarProducto As Button
    Friend WithEvents btnRegistrarProductoNuevo As Button
End Class
