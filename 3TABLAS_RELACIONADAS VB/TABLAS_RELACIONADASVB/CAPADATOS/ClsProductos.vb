Imports System.Data.SqlClient

Public Class ClsProductos
    Private Conexion As ConexionBD = New ConexionBD()
    Private Comando As SqlCommand = New SqlCommand()
    Private LeerFilas As SqlDataReader

    Private idprod As Integer
    Private idCategoria As Integer
    Private idMarca As Integer
    Private descripcion As String
    Private precio As Double

    Public Property Idprod1 As Integer
        Get
            Return idprod
        End Get
        Set(value As Integer)
            idprod = value
        End Set
    End Property

    Public Property IdCategoria1 As Integer
        Get
            Return idCategoria
        End Get
        Set(value As Integer)
            idCategoria = value
        End Set
    End Property

    Public Property IdMarca1 As Integer
        Get
            Return idMarca
        End Get
        Set(value As Integer)
            idMarca = value
        End Set
    End Property

    Public Property Descripcion1 As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    Public Property Precio1 As Double
        Get
            Return precio
        End Get
        Set(value As Double)
            precio = value
        End Set
    End Property


    Public Function ListarCategorias() As DataTable
        Dim Tabla As DataTable = New DataTable()
        Comando.Connection = Conexion.AbrirConexion()
        Comando.CommandText = "ListarCategorias"
        Comando.CommandType = CommandType.StoredProcedure
        LeerFilas = Comando.ExecuteReader()
        Tabla.Load(LeerFilas)
        LeerFilas.Close()
        Conexion.CerrarConexion()
        Return Tabla
    End Function
    Public Function ListarMarcas() As DataTable
        Dim Tabla As DataTable = New DataTable()
        Comando.Connection = Conexion.AbrirConexion()
        Comando.CommandText = "ListarMarcas"
        Comando.CommandType = CommandType.StoredProcedure
        LeerFilas = Comando.ExecuteReader()
        Tabla.Load(LeerFilas)
        LeerFilas.Close()
        Conexion.CerrarConexion()
        Return Tabla
    End Function
    Public Function ListarProductos() As DataTable
        Dim Tabla As DataTable = New DataTable()
        Comando.Connection = Conexion.AbrirConexion()
        Comando.CommandText = "ListarProductos"
        Comando.CommandType = CommandType.StoredProcedure
        LeerFilas = Comando.ExecuteReader()
        Tabla.Load(LeerFilas)
        LeerFilas.Close()
        Conexion.CerrarConexion()
        Return Tabla
    End Function
    Public Sub InsertarProductos()
        Comando.Connection = Conexion.AbrirConexion()
        Comando.CommandText = "AgregarProducto"
        Comando.CommandType = CommandType.StoredProcedure
        Comando.Parameters.AddWithValue("@idcategoria", idCategoria)
        Comando.Parameters.AddWithValue("@idmarca", idMarca)
        Comando.Parameters.AddWithValue("@descrip", descripcion)
        Comando.Parameters.AddWithValue("@prec", precio)
        Comando.ExecuteNonQuery()
        Comando.Parameters.Clear()
    End Sub
    Public Sub EditarProductos()
        Comando.Connection = Conexion.AbrirConexion()
        Comando.CommandText = "update PRODUCTOS set IDCATEGORIA=" & idCategoria & ",IDMARCA=" & idMarca & ",DESCRIPCION='" & descripcion & "',PRECIO=" & precio & " WHERE IDPROD=" & idprod
        Comando.CommandType = CommandType.Text
        Comando.ExecuteNonQuery()
        Conexion.CerrarConexion()
    End Sub
    Public Sub EliminarProducto()
        Comando.Connection = Conexion.AbrirConexion()
        Comando.CommandText = "delete PRODUCTOS where IDPROD=" & idprod
        Comando.CommandType = CommandType.Text
        Comando.ExecuteNonQuery()
        Conexion.CerrarConexion()
    End Sub


    Public Function tablaproductos() As DataTable
        Dim Tabla As DataTable = New DataTable()
        Comando.Connection = Conexion.AbrirConexion()
        Comando.CommandText = "select *from PRODUCTOS"
        Comando.CommandType = CommandType.Text
        LeerFilas = Comando.ExecuteReader()
        Tabla.Load(LeerFilas)
        LeerFilas.Close()
        Conexion.CerrarConexion()
        Return Tabla
    End Function


End Class
