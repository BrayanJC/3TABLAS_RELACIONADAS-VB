Public Class PRODUCTOS
    Dim objproducto As ClsProductos = New ClsProductos()
    Dim Operacion = "Insertar"
    Dim idprod As String
    Private Sub btnVistaBD_Click(sender As Object, e As EventArgs) Handles btnVistaBD.Click
        If Me.Size.Height = 330 Then
            Me.Size = New Size(1000, 700)
        Else
            Me.Size = New Size(1000, 330)
        End If
    End Sub
    Private Sub VistaBaseDatos()
        Dim obj As ClsProductos = New ClsProductos()
        DGVProductos.DataSource = obj.tablaproductos()
        DGVCategorias.DataSource = obj.ListarCategorias()
        DGVMarcas.DataSource = obj.ListarMarcas()
    End Sub
    Private Sub ListarCategorias()
        Dim objProd As ClsProductos = New ClsProductos()
        CmbCategoria.DataSource = objProd.ListarCategorias()
        CmbCategoria.DisplayMember = "CATEGORIA"
        CmbCategoria.ValueMember = "IDCATEG"
    End Sub
    Private Sub ListarMarcas()
        Dim objProd As ClsProductos = New ClsProductos()
        CmbMarca.DataSource = objProd.ListarMarcas()
        CmbMarca.DisplayMember = "MARCA"
        CmbMarca.ValueMember = "IDMARCA"
    End Sub
    Private Sub ListarProductos()
        VistaBaseDatos()

        Dim objprod As ClsProductos = New ClsProductos()
        dataGridView1.DataSource = objprod.ListarProductos()
    End Sub
    Private Sub PRODUCTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarCategorias()
        ListarMarcas()
        ListarProductos()
    End Sub
    Private Sub LimpiarFormulario()
        txtDescripcion.Clear()
        txtPrecio.Clear()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Operacion = "Insertar" Then
            objproducto.IdCategoria1 = Convert.ToInt32(CmbCategoria.SelectedValue)
            objproducto.IdMarca1 = Convert.ToInt32(CmbMarca.SelectedValue)
            objproducto.Descripcion1 = txtDescripcion.Text
            objproducto.Precio1 = Convert.ToDouble(txtPrecio.Text)
            objproducto.InsertarProductos()

            MessageBox.Show("Se inserto correctamente")
        ElseIf Operacion = "Editar" Then
            objproducto.IdCategoria1 = Convert.ToInt32(CmbCategoria.SelectedValue)
            objproducto.IdMarca1 = Convert.ToInt32(CmbMarca.SelectedValue)
            objproducto.Descripcion1 = txtDescripcion.Text
            objproducto.Precio1 = Convert.ToDouble(txtPrecio.Text)
            objproducto.Idprod1 = Convert.ToInt32(idprod)

            objproducto.EditarProductos()
            Operacion = "Insertar"
            MessageBox.Show("Se edito correctamente")
        End If
        ListarProductos()
        'Limpiar texboxs
        LimpiarFormulario()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dataGridView1.SelectedRows.Count > 0 Then
            Operacion = "Editar"
            CmbCategoria.Text = dataGridView1.CurrentRow.Cells("CATEGORIA").Value.ToString()
            CmbMarca.Text = dataGridView1.CurrentRow.Cells(2).Value.ToString()
            txtDescripcion.Text = dataGridView1.CurrentRow.Cells("DESCRIPCION").Value.ToString()
            txtPrecio.Text = dataGridView1.CurrentRow.Cells(4).Value.ToString()
            idprod = dataGridView1.CurrentRow.Cells("ID").Value.ToString()
        Else
            MessageBox.Show("debe seleccionar una fila")
        End If
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dataGridView1.SelectedRows.Count > 0 Then
            objproducto.Idprod1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells(0).Value)
            objproducto.EliminarProducto()
            MessageBox.Show("Se elimino satisfactoriamente")
            ListarProductos()
        Else
            MessageBox.Show("Seleccione una fila")
        End If
    End Sub
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        If dataGridView1.SelectedRows.Count > 0 Then
            Dim frm As MantenimientoProd = New MantenimientoProd()
            frm.Operacion = "Editar"
            frm.ListarCategorias()
            frm.ListarMarcas()

            frm.idprod = dataGridView1.CurrentRow.Cells("ID").Value.ToString()
            frm.CmbCategoria.Text = dataGridView1.CurrentRow.Cells("CATEGORIA").Value.ToString()
            frm.CmbMarca.Text = dataGridView1.CurrentRow.Cells(2).Value.ToString()
            frm.txtDescripcion.Text = dataGridView1.CurrentRow.Cells("DESCRIPCION").Value.ToString()
            frm.txtPrecio.Text = dataGridView1.CurrentRow.Cells(4).Value.ToString()

            frm.ShowDialog()
            ListarProductos()
        Else
            MessageBox.Show("debe seleccionar una fila")
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim frm As MantenimientoProd = New MantenimientoProd()
        frm.Operacion = "Insertar"
        frm.ListarCategorias()
        frm.ListarMarcas()
        frm.ShowDialog()
        ListarProductos()
    End Sub
End Class
