<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarProducto
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
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.txtCantidadIngrediente = New System.Windows.Forms.TextBox()
        Me.lstIngredientes = New System.Windows.Forms.ListBox()
        Me.lstRecetaActual = New System.Windows.Forms.ListBox()
        Me.lstNuevaReceta = New System.Windows.Forms.ListBox()
        Me.btnAgregarNuevoIngrediente = New System.Windows.Forms.Button()
        Me.btnAgregarIngrediente = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(41, 57)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(167, 20)
        Me.txtNombreProducto.TabIndex = 0
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(41, 100)
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(220, 20)
        Me.txtDescripcionProducto.TabIndex = 1
        '
        'txtCantidadIngrediente
        '
        Me.txtCantidadIngrediente.Location = New System.Drawing.Point(557, 211)
        Me.txtCantidadIngrediente.Name = "txtCantidadIngrediente"
        Me.txtCantidadIngrediente.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadIngrediente.TabIndex = 2
        '
        'lstIngredientes
        '
        Me.lstIngredientes.FormattingEnabled = True
        Me.lstIngredientes.Location = New System.Drawing.Point(327, 48)
        Me.lstIngredientes.Name = "lstIngredientes"
        Me.lstIngredientes.Size = New System.Drawing.Size(209, 264)
        Me.lstIngredientes.TabIndex = 3
        '
        'lstRecetaActual
        '
        Me.lstRecetaActual.FormattingEnabled = True
        Me.lstRecetaActual.Location = New System.Drawing.Point(46, 202)
        Me.lstRecetaActual.Name = "lstRecetaActual"
        Me.lstRecetaActual.Size = New System.Drawing.Size(215, 173)
        Me.lstRecetaActual.TabIndex = 4
        '
        'lstNuevaReceta
        '
        Me.lstNuevaReceta.FormattingEnabled = True
        Me.lstNuevaReceta.Location = New System.Drawing.Point(669, 57)
        Me.lstNuevaReceta.Name = "lstNuevaReceta"
        Me.lstNuevaReceta.Size = New System.Drawing.Size(244, 186)
        Me.lstNuevaReceta.TabIndex = 5
        '
        'btnAgregarNuevoIngrediente
        '
        Me.btnAgregarNuevoIngrediente.Location = New System.Drawing.Point(327, 330)
        Me.btnAgregarNuevoIngrediente.Name = "btnAgregarNuevoIngrediente"
        Me.btnAgregarNuevoIngrediente.Size = New System.Drawing.Size(209, 59)
        Me.btnAgregarNuevoIngrediente.TabIndex = 6
        Me.btnAgregarNuevoIngrediente.Text = "Registrar un nuevo Ingrediente"
        Me.btnAgregarNuevoIngrediente.UseVisualStyleBackColor = True
        '
        'btnAgregarIngrediente
        '
        Me.btnAgregarIngrediente.Location = New System.Drawing.Point(557, 100)
        Me.btnAgregarIngrediente.Name = "btnAgregarIngrediente"
        Me.btnAgregarIngrediente.Size = New System.Drawing.Size(93, 68)
        Me.btnAgregarIngrediente.TabIndex = 7
        Me.btnAgregarIngrediente.Text = "Agregar Producto a la receta"
        Me.btnAgregarIngrediente.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(649, 434)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(202, 88)
        Me.btnRegistrar.TabIndex = 8
        Me.btnRegistrar.Text = "Registrar Cambios"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(60, 434)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(180, 95)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(574, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(324, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Lista de ingredientes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(666, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Nueva receta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Receta actual"
        '
        'frmEditarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 588)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnAgregarIngrediente)
        Me.Controls.Add(Me.btnAgregarNuevoIngrediente)
        Me.Controls.Add(Me.lstNuevaReceta)
        Me.Controls.Add(Me.lstRecetaActual)
        Me.Controls.Add(Me.lstIngredientes)
        Me.Controls.Add(Me.txtCantidadIngrediente)
        Me.Controls.Add(Me.txtDescripcionProducto)
        Me.Controls.Add(Me.txtNombreProducto)
        Me.Name = "frmEditarProducto"
        Me.Text = "frmEditarProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtDescripcionProducto As TextBox
    Friend WithEvents txtCantidadIngrediente As TextBox
    Friend WithEvents lstIngredientes As ListBox
    Friend WithEvents lstRecetaActual As ListBox
    Friend WithEvents lstNuevaReceta As ListBox
    Friend WithEvents btnAgregarNuevoIngrediente As Button
    Friend WithEvents btnAgregarIngrediente As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
