<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarProducto
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
        Me.txtCantidadIngrediente = New System.Windows.Forms.TextBox()
        Me.btnAgregarIngrediente = New System.Windows.Forms.Button()
        Me.btnAgregarNuevoIngrediente = New System.Windows.Forms.Button()
        Me.btnRegistrarProducto = New System.Windows.Forms.Button()
        Me.txtDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.lstIngredientes = New System.Windows.Forms.ListBox()
        Me.lstReceta = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(22, 54)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(163, 20)
        Me.txtNombreProducto.TabIndex = 0
        '
        'txtCantidadIngrediente
        '
        Me.txtCantidadIngrediente.Location = New System.Drawing.Point(326, 378)
        Me.txtCantidadIngrediente.Name = "txtCantidadIngrediente"
        Me.txtCantidadIngrediente.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadIngrediente.TabIndex = 1
        '
        'btnAgregarIngrediente
        '
        Me.btnAgregarIngrediente.Location = New System.Drawing.Point(455, 357)
        Me.btnAgregarIngrediente.Name = "btnAgregarIngrediente"
        Me.btnAgregarIngrediente.Size = New System.Drawing.Size(105, 41)
        Me.btnAgregarIngrediente.TabIndex = 2
        Me.btnAgregarIngrediente.Text = "Rellenar Receta"
        Me.btnAgregarIngrediente.UseVisualStyleBackColor = True
        '
        'btnAgregarNuevoIngrediente
        '
        Me.btnAgregarNuevoIngrediente.Location = New System.Drawing.Point(78, 357)
        Me.btnAgregarNuevoIngrediente.Name = "btnAgregarNuevoIngrediente"
        Me.btnAgregarNuevoIngrediente.Size = New System.Drawing.Size(124, 51)
        Me.btnAgregarNuevoIngrediente.TabIndex = 3
        Me.btnAgregarNuevoIngrediente.Text = "Agregar Ingrediente Nuevo"
        Me.btnAgregarNuevoIngrediente.UseVisualStyleBackColor = True
        '
        'btnRegistrarProducto
        '
        Me.btnRegistrarProducto.Location = New System.Drawing.Point(391, 426)
        Me.btnRegistrarProducto.Name = "btnRegistrarProducto"
        Me.btnRegistrarProducto.Size = New System.Drawing.Size(135, 73)
        Me.btnRegistrarProducto.TabIndex = 4
        Me.btnRegistrarProducto.Text = "Registrar nuevo producto"
        Me.btnRegistrarProducto.UseVisualStyleBackColor = True
        '
        'txtDescripcionProducto
        '
        Me.txtDescripcionProducto.Location = New System.Drawing.Point(222, 54)
        Me.txtDescripcionProducto.Name = "txtDescripcionProducto"
        Me.txtDescripcionProducto.Size = New System.Drawing.Size(296, 20)
        Me.txtDescripcionProducto.TabIndex = 5
        '
        'lstIngredientes
        '
        Me.lstIngredientes.FormattingEnabled = True
        Me.lstIngredientes.Location = New System.Drawing.Point(22, 116)
        Me.lstIngredientes.Name = "lstIngredientes"
        Me.lstIngredientes.Size = New System.Drawing.Size(223, 225)
        Me.lstIngredientes.TabIndex = 6
        '
        'lstReceta
        '
        Me.lstReceta.FormattingEnabled = True
        Me.lstReceta.Location = New System.Drawing.Point(317, 116)
        Me.lstReceta.Name = "lstReceta"
        Me.lstReceta.Size = New System.Drawing.Size(243, 225)
        Me.lstReceta.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre del producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(314, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Descripcion del producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Lista de Ingredientes disponibles"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(402, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Receta Nueva"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(323, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Cantidad necesaria"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(180, 438)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(116, 48)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limpiar Datos"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 525)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstReceta)
        Me.Controls.Add(Me.lstIngredientes)
        Me.Controls.Add(Me.txtDescripcionProducto)
        Me.Controls.Add(Me.btnRegistrarProducto)
        Me.Controls.Add(Me.btnAgregarNuevoIngrediente)
        Me.Controls.Add(Me.btnAgregarIngrediente)
        Me.Controls.Add(Me.txtCantidadIngrediente)
        Me.Controls.Add(Me.txtNombreProducto)
        Me.Name = "frmProducto"
        Me.Text = "frmProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents txtCantidadIngrediente As TextBox
    Friend WithEvents btnAgregarIngrediente As Button
    Friend WithEvents btnAgregarNuevoIngrediente As Button
    Friend WithEvents btnRegistrarProducto As Button
    Friend WithEvents txtDescripcionProducto As TextBox
    Friend WithEvents lstIngredientes As ListBox
    Friend WithEvents lstReceta As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLimpiar As Button
End Class
