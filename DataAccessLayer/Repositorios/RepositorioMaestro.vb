Imports MySql.Data.MySqlClient
Public Class RepositorioMaestro : Inherits Conexion

    Protected Parametros As List(Of MySqlParameter)

    Protected Function ExecuteNonQuery(ByVal ComandoSql As String) As Int16
        Using Conexion = ObtenerConexion()
            Conexion.Open()
            Using Comando = New MySqlCommand
                With Comando
                    .CommandText = ComandoSql
                    .Connection = Conexion
                    .CommandType = CommandType.Text
                End With
                For Each Parametro As MySqlParameter In Parametros
                    Comando.Parameters.Add(Parametro)
                Next
                Dim resultado As Int16
                resultado = Comando.ExecuteNonQuery
                Parametros.Clear()
                Return resultado
            End Using
        End Using
    End Function

    Protected Function ExecuteReader(ByVal ComandoSql As String) As DataTable
            Using Conexion = ObtenerConexion()
                Conexion.Open()
                Using Comando = New MySqlCommand
                    With Comando
                        .CommandText = ComandoSql
                        .Connection = Conexion
                        .CommandType = CommandType.Text
                    End With
                    Using Resultado As MySqlDataReader = Comando.ExecuteReader
                        Using Tabla As New DataTable
                            Tabla.Load(Resultado)
                            Return Tabla
                        End Using
                    End Using
                End Using
            End Using
        End Function


    End Class
