Imports MySql.Data.MySqlClient
Public Class RepositorioPrefijo
    Inherits RepositorioMaestro
    Implements iRepositorioPrefijo
#Region "VARIABLE"
    Private SelectAll As String
    Private SelectOne As String
    Private Insert As String
    Private Update As String
    Private Delete As String
    Private SelectProvincia As String
#End Region

#Region "CONSTRUCTOR"
    Public Sub New()
        SelectAll = "SELECT idprefijo,nombrePrefijo from prefijo where prefijo.eliminado = 0;"
        Insert = "Insert INTO prefijo(nombrePrefijo)VALUES(@NombrePrefijo);"
        Update = "UPDATE prefijo SET nombrePrefijo = @NombrePrefijo WHERE idprefijo = @IdPrefijo"
        Delete = "UPDATE prefijo SET eliminado = '1' WHERE idprefijo = @IdPrefijo;"
    End Sub
#End Region

#Region "METODOS"
    Public Function ObtenerPrefijo(CP As Short) As Prefijo Implements iRepositorioPrefijo.ObtenerPrefijo
        Throw New NotImplementedException()
    End Function

    Public Function Add(Entidad As Prefijo) As Short Implements iRepositorioGenerico(Of Prefijo).Add
        Parametros = New List(Of MySqlParameter)
        Parametros.Add(New MySqlParameter("@NombrePrefijo", Entidad.NombrePrefijo))
        Return ExecuteNonQuery(Insert)
    End Function

    Public Function Edit(Entidad As Prefijo) As Short Implements iRepositorioGenerico(Of Prefijo).Edit
        Parametros = New List(Of MySqlParameter)
        Parametros.Add(New MySqlParameter("@IdPrefijo", Entidad.IdPrefijo))
        Parametros.Add(New MySqlParameter("@NombrePrefijo", Entidad.NombrePrefijo))
        Return ExecuteNonQuery(Update)
    End Function

    Public Function Remove(CP As Short) As Short Implements iRepositorioGenerico(Of Prefijo).Remove
        Parametros = New List(Of MySqlParameter)
        Parametros.Add(New MySqlParameter("@IdPrefijo", CP))
        Return ExecuteNonQuery(Delete)
    End Function

    Public Function GetAll() As IEnumerable(Of Prefijo) Implements iRepositorioGenerico(Of Prefijo).GetAll

        Dim tablaResultados = ExecuteReader(SelectAll)
        Dim listaPrefijo = New List(Of Prefijo)
        For Each fila As DataRow In tablaResultados.Rows
            Dim prefijo As New Prefijo
            With prefijo
                .IdPrefijo = CShort(fila.Item(0).ToString)
                .NombrePrefijo = fila.Item(1).ToString
            End With
            listaPrefijo.Add(prefijo)
        Next
        Return listaPrefijo

    End Function
#End Region

End Class
