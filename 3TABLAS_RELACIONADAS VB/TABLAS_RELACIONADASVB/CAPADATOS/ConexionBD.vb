Imports System.Data.SqlClient

Public Class ConexionBD
    Private Shared CadenaConexion As String = "Server=(local);DataBase=PRACTICA_TABLAS;Integrated Security=true"
    Private Conexion As SqlConnection = New SqlConnection(CadenaConexion)

    Public Function AbrirConexion() As SqlConnection
        If Conexion.State = ConnectionState.Closed Then Conexion.Open()
        Return Conexion
    End Function

    Public Function CerrarConexion() As SqlConnection
        If Conexion.State = ConnectionState.Open Then Conexion.Close()
        Return Conexion
    End Function
End Class
