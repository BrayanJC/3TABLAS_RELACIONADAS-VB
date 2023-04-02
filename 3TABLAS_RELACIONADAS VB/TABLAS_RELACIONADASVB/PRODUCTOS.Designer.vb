<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRODUCTOS
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
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.label9 = New System.Windows.Forms.Label()
        Me.btnVistaBD = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.CmbMarca = New System.Windows.Forms.ComboBox()
        Me.CmbCategoria = New System.Windows.Forms.ComboBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label7 = New System.Windows.Forms.Label()
        Me.DGVCategorias = New System.Windows.Forms.DataGridView()
        Me.DGVMarcas = New System.Windows.Forms.DataGridView()
        Me.DGVProductos = New System.Windows.Forms.DataGridView()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.DGVCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(12, 223)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(122, 28)
        Me.btnEliminar.TabIndex = 36
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(140, 223)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(122, 28)
        Me.btnEditar.TabIndex = 35
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(12, 1)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(219, 15)
        Me.label9.TabIndex = 34
        Me.label9.Text = "Listado de productos / VISTA USUARIO"
        '
        'btnVistaBD
        '
        Me.btnVistaBD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVistaBD.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnVistaBD.FlatAppearance.BorderSize = 0
        Me.btnVistaBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVistaBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVistaBD.ForeColor = System.Drawing.Color.White
        Me.btnVistaBD.Location = New System.Drawing.Point(0, 257)
        Me.btnVistaBD.Name = "btnVistaBD"
        Me.btnVistaBD.Size = New System.Drawing.Size(987, 35)
        Me.btnVistaBD.TabIndex = 32
        Me.btnVistaBD.Text = "VISTA TABLAS BASE DE DATOS"
        Me.btnVistaBD.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(627, 159)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(324, 41)
        Me.btnAgregar.TabIndex = 31
        Me.btnAgregar.Text = "GUARDAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(595, 125)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(45, 15)
        Me.label4.TabIndex = 30
        Me.label4.Text = "Precio:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(595, 97)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(75, 15)
        Me.label3.TabIndex = 29
        Me.label3.Text = "Descripcion:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(692, 124)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(251, 21)
        Me.txtPrecio.TabIndex = 28
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(692, 97)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(251, 21)
        Me.txtDescripcion.TabIndex = 27
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(595, 70)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(45, 15)
        Me.label2.TabIndex = 26
        Me.label2.Text = "Marca:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(595, 43)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(63, 15)
        Me.label1.TabIndex = 25
        Me.label1.Text = "Categoria:"
        '
        'CmbMarca
        '
        Me.CmbMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMarca.FormattingEnabled = True
        Me.CmbMarca.Location = New System.Drawing.Point(692, 70)
        Me.CmbMarca.Name = "CmbMarca"
        Me.CmbMarca.Size = New System.Drawing.Size(251, 23)
        Me.CmbMarca.TabIndex = 24
        '
        'CmbCategoria
        '
        Me.CmbCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCategoria.FormattingEnabled = True
        Me.CmbCategoria.Location = New System.Drawing.Point(692, 43)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.Size = New System.Drawing.Size(251, 23)
        Me.CmbCategoria.TabIndex = 23
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(12, 19)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(555, 198)
        Me.dataGridView1.TabIndex = 22
        '
        'panel1
        '
        Me.panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.panel1.Controls.Add(Me.label7)
        Me.panel1.Controls.Add(Me.DGVCategorias)
        Me.panel1.Controls.Add(Me.DGVMarcas)
        Me.panel1.Controls.Add(Me.DGVProductos)
        Me.panel1.Controls.Add(Me.label6)
        Me.panel1.Controls.Add(Me.label5)
        Me.panel1.Location = New System.Drawing.Point(0, 289)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(990, 372)
        Me.panel1.TabIndex = 33
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.White
        Me.label7.Location = New System.Drawing.Point(12, 6)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(122, 15)
        Me.label7.TabIndex = 16
        Me.label7.Text = "TABLA PRODUCTOS"
        '
        'DGVCategorias
        '
        Me.DGVCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCategorias.Location = New System.Drawing.Point(667, 30)
        Me.DGVCategorias.Name = "DGVCategorias"
        Me.DGVCategorias.Size = New System.Drawing.Size(305, 155)
        Me.DGVCategorias.TabIndex = 12
        '
        'DGVMarcas
        '
        Me.DGVMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMarcas.Location = New System.Drawing.Point(667, 212)
        Me.DGVMarcas.Name = "DGVMarcas"
        Me.DGVMarcas.Size = New System.Drawing.Size(305, 155)
        Me.DGVMarcas.TabIndex = 13
        '
        'DGVProductos
        '
        Me.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductos.Location = New System.Drawing.Point(12, 22)
        Me.DGVProductos.Name = "DGVProductos"
        Me.DGVProductos.Size = New System.Drawing.Size(589, 325)
        Me.DGVProductos.TabIndex = 11
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(664, 194)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(96, 15)
        Me.label6.TabIndex = 15
        Me.label6.Text = "TABLA MARCAS"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.Transparent
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.White
        Me.label5.Location = New System.Drawing.Point(664, 12)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(121, 15)
        Me.label5.TabIndex = 14
        Me.label5.Text = "TABLA CATEGORIAS"
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(302, 223)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(137, 28)
        Me.button2.TabIndex = 38
        Me.button2.Text = "Pasara Datos"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(445, 223)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(122, 28)
        Me.button1.TabIndex = 37
        Me.button1.Text = "Nuevo"
        Me.button1.UseVisualStyleBackColor = True
        '
        'PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 291)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.btnVistaBD)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.CmbMarca)
        Me.Controls.Add(Me.CmbCategoria)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "PRODUCTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCTOS"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.DGVCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnEliminar As Button
    Private WithEvents btnEditar As Button
    Private WithEvents label9 As Label
    Private WithEvents btnVistaBD As Button
    Private WithEvents btnAgregar As Button
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents txtPrecio As TextBox
    Private WithEvents txtDescripcion As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents CmbMarca As ComboBox
    Private WithEvents CmbCategoria As ComboBox
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents panel1 As Panel
    Private WithEvents label7 As Label
    Private WithEvents DGVCategorias As DataGridView
    Private WithEvents DGVMarcas As DataGridView
    Private WithEvents DGVProductos As DataGridView
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
End Class
