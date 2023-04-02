<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MantenimientoProd
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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.CmbMarca = New System.Windows.Forms.ComboBox()
        Me.CmbCategoria = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(75, 150)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(324, 41)
        Me.btnAgregar.TabIndex = 27
        Me.btnAgregar.Text = "GUARDAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(43, 116)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(45, 15)
        Me.label4.TabIndex = 26
        Me.label4.Text = "Precio:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(43, 88)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(75, 15)
        Me.label3.TabIndex = 25
        Me.label3.Text = "Descripcion:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(140, 115)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(251, 21)
        Me.txtPrecio.TabIndex = 24
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(140, 88)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(251, 21)
        Me.txtDescripcion.TabIndex = 23
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(43, 61)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(45, 15)
        Me.label2.TabIndex = 22
        Me.label2.Text = "Marca:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(43, 34)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(63, 15)
        Me.label1.TabIndex = 21
        Me.label1.Text = "Categoria:"
        '
        'CmbMarca
        '
        Me.CmbMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMarca.FormattingEnabled = True
        Me.CmbMarca.Location = New System.Drawing.Point(140, 61)
        Me.CmbMarca.Name = "CmbMarca"
        Me.CmbMarca.Size = New System.Drawing.Size(251, 23)
        Me.CmbMarca.TabIndex = 20
        '
        'CmbCategoria
        '
        Me.CmbCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCategoria.FormattingEnabled = True
        Me.CmbCategoria.Location = New System.Drawing.Point(140, 34)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.Size = New System.Drawing.Size(251, 23)
        Me.CmbCategoria.TabIndex = 19
        '
        'MantenimientoProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 234)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.CmbMarca)
        Me.Controls.Add(Me.CmbCategoria)
        Me.Name = "MantenimientoProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MantenimientoProd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnAgregar As Button
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Public WithEvents txtPrecio As TextBox
    Public WithEvents txtDescripcion As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Public WithEvents CmbMarca As ComboBox
    Public WithEvents CmbCategoria As ComboBox
End Class
