Imports MySql.Data.MySqlClient
Public Class RepositorioProvincia
    Inherits RepositorioMaestro
    Implements iRepositorioProvincia
#Region "CAMPOS"
    Private SelectAll As String
    Private SelectOne As String
    Private Insert As String
    Private Update As String
    Private Delete As String

#End Region
#Region "CONSTRUCTOR"
    Public Sub New()
        SelectAll = "SELECT * FROM agenda.vista_provincias;"
        SelectOne = "SELECT idprovincia,nombreProvincia from provincia where provincia.eliminado = 0 and idprovincia="
        Insert = "INSERT INTO provincia(nombreProvincia)VALUES(@NombreProvincia);"

        Update = "UPDATE provincia SET nombreProvincia = @NombreProvincia WHERE idprovincia = @IdProvincia;"
        Delete = "UPDATE provincia SET eliminado = '1' WHERE idprovincia = @IdProvincia;"
    End Sub
#End Region

#Region "METODOS"

    Public Function ObtenerProvincia(CP As Short) As Provincia Implements iRepositorioProvincia.ObtenerProvincia
        SelectOne = SelectOne & CP
        Dim tablaResultados = ExecuteReader(SelectOne)
        Dim provincia As New Provincia
        If tablaResultados.Rows.Count > 0 Then
            With provincia
                .IdProvincia = CShort(tablaResultados.Rows(0).Item(0).ToString)
                .NombreProvincia = tablaResultados.Rows(0).Item(1).ToString
            End With
        End If
        Return provincia
    End Function

    Public Function Add(Entidad As Provincia) As Short Implements iRepositorioGenerico(Of Provincia).Add
        Parametros = New List(Of MySqlParameter)
        With Parametros
            .Add(New MySqlParameter("@NombreProvincia", Entidad.NombreProvincia))
        End With
        Return ExecuteNonQuery(Insert)
    End Function

    Public Function Edit(Entidad As Provincia) As Short Implements iRepositorioGenerico(Of Provincia).Edit
        Parametros = New List(Of MySqlParameter)
        With Parametros
            .Add(New MySqlParameter("@IdProvincia", Entidad.IdProvincia))
            .Add(New MySqlParameter("@NombreProvincia", Entidad.NombreProvincia))
        End With
        Return ExecuteNonQuery(Update)
    End Function

    Public Function Remove(CP As Short) As Short Implements iRepositorioGenerico(Of Provincia).Remove
        Parametros = New List(Of MySqlParameter)
        Parametros.Add(New MySqlParameter("@IdProvincia", CP))
        Return ExecuteNonQuery(Delete)
    End Function

    Public Function GetAll() As IEnumerable(Of Provincia) Implements iRepositorioGenerico(Of Provincia).GetAll
        Dim tablaResultados = ExecuteReader(SelectAll)
        Dim listaProvincia = New List(Of Provincia)
        For Each fila As DataRow In tablaResultados.Rows
            Dim provincia As New Provincia
            With provincia
                .IdProvincia = CShort(fila.Item(0).ToString)
                .NombreProvincia = fila.Item(1).ToString
            End With
            listaProvincia.Add(provincia)
        Next
        Return listaProvincia
    End Function

#End Region


End Class
