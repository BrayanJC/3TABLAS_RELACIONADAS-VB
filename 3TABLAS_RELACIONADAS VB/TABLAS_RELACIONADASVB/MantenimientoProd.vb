Public Class MantenimientoProd
    Private objproducto As ClsProductos = New ClsProductos()
    Public Operacion As String = ""
    Public idprod As String
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

            MessageBox.Show("Se edito correctamente")
            Me.Close()
        End If
    End Sub
    Public Sub ListarCategorias()
        Dim objProd As ClsProductos = New ClsProductos()
        CmbCategoria.DataSource = objProd.ListarCategorias()
        CmbCategoria.DisplayMember = "CATEGORIA"
        CmbCategoria.ValueMember = "IDCATEG"
    End Sub
    Public Sub ListarMarcas()
        Dim objProd As ClsProductos = New ClsProductos()
        CmbMarca.DataSource = objProd.ListarMarcas()
        CmbMarca.DisplayMember = "MARCA"
        CmbMarca.ValueMember = "IDMARCA"
    End Sub

End Class