<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoIngrediente
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
        Me.txtNombreIngrediente = New System.Windows.Forms.TextBox()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.btnGuardarIngrediente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNombreIngrediente
        '
        Me.txtNombreIngrediente.Location = New System.Drawing.Point(129, 86)
        Me.txtNombreIngrediente.Name = "txtNombreIngrediente"
        Me.txtNombreIngrediente.Size = New System.Drawing.Size(162, 20)
        Me.txtNombreIngrediente.TabIndex = 0
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(160, 161)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioUnitario.TabIndex = 1
        '
        'btnGuardarIngrediente
        '
        Me.btnGuardarIngrediente.Location = New System.Drawing.Point(159, 235)
        Me.btnGuardarIngrediente.Name = "btnGuardarIngrediente"
        Me.btnGuardarIngrediente.Size = New System.Drawing.Size(112, 48)
        Me.btnGuardarIngrediente.TabIndex = 2
        Me.btnGuardarIngrediente.Text = "Guardar ingrediente"
        Me.btnGuardarIngrediente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre del ingrediente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Precio Unitario"
        '
        'frmNuevoIngrediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 339)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuardarIngrediente)
        Me.Controls.Add(Me.txtPrecioUnitario)
        Me.Controls.Add(Me.txtNombreIngrediente)
        Me.Name = "frmNuevoIngrediente"
        Me.Text = "frmNuevoIngrediente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombreIngrediente As TextBox
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents btnGuardarIngrediente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
