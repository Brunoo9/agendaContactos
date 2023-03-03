Imports MySql.Data.MySqlClient
Imports System.Configuration
Public Class Conexion

    Public ReadOnly _CadenaConexion As String

        Public Sub New()
            _CadenaConexion = ConfigurationManager.ConnectionStrings("MiCadena").ConnectionString
        End Sub

        Protected Function ObtenerConexion() As MySqlConnection
            Return New MySqlConnection(_CadenaConexion)
        End Function

End Class
