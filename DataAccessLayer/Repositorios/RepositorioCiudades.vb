Imports MySql.Data.MySqlClient
Public Class RepositorioCiudades
    Inherits RepositorioMaestro
    Implements iRepositorioCiudades

#Region "CAMPOS"
    Private SelectAll As String
    Private SelectOne As String
    Private Insert As String
    Private Update As String
    Private Delete As String
    Private SelectAllByProvincia As String


#End Region

#Region "CONSTRUCTOR"
    Public Sub New()
        SelectAll = "SELECT ciudades.idciudades,ciudades.nombreCiudad,codPostal,provincia.nombreProvincia FROM ciudades,provincia where ciudades.provincia = provincia.idprovincia and ciudades.eliminado = 0;"
        SelectAllByProvincia = "SELECT idciudades,nombreCiudad,codPostal from agenda.ciudades where provincia ="
        SelectOne = "SELECT ciudades.idciudades,ciudades.nombreCiudad,ciudades.codPostal,provincia.nombreProvincia FROM ciudades,provincia WHERE ciudades.provincia =  provincia.idprovincia   AND  idciudades ="
        Insert = "INSERT INTO ciudades(nombreCiudad,codPostal,provincia)VALUES(@NombreCiudad,@CodPostal,@IdProvincia);"
        Update = "UPDATE ciudades SET nombreCiudad = @NombreCiudad,codPostal = @CodPostal,provincia = @IdProvincia WHERE idciudades = @IdCiudades;"
        Delete = "UPDATE ciudades SET eliminado = '1' WHERE idciudades = @IdCiudades;"

    End Sub
#End Region

#Region "METODOS"
    Public Function ObtenerCiudad(CP As Short) As Ciudades Implements iRepositorioCiudades.ObtenerCiudad
        SelectOne = SelectOne & CP
        Dim tablaResultados = ExecuteReader(SelectOne)
        Dim ciudad As New Ciudades
        If tablaResultados.Rows.Count > 0 Then
            With ciudad
                .IdCiudades = CShort(tablaResultados.Rows(0).Item(0).ToString)
                .NombreCiudad = tablaResultados.Rows(0).Item(1).ToString
                .CodPostal = tablaResultados.Rows(0).Item(2).ToString
                .Provincia = tablaResultados.Rows(0).Item(3).ToString
            End With
        End If
        Return ciudad
    End Function

    Public Function Add(Entidad As Ciudades) As Short Implements iRepositorioGenerico(Of Ciudades).Add
        Parametros = New List(Of MySqlParameter)
        With Parametros

            .Add(New MySqlParameter("@NombreCiudad", Entidad.NombreCiudad))
            .Add(New MySqlParameter("@CodPostal", Entidad.CodPostal))
            .Add(New MySqlParameter("@IdProvincia", Entidad.IdProvincia))
        End With
        Return ExecuteNonQuery(Insert)
    End Function

    Public Function Edit(Entidad As Ciudades) As Short Implements iRepositorioGenerico(Of Ciudades).Edit
        Parametros = New List(Of MySqlParameter)
        With Parametros
            .Add(New MySqlParameter("@IdCiudades", Entidad.IdCiudades))
            .Add(New MySqlParameter("@NombreCiudad", Entidad.NombreCiudad))
            .Add(New MySqlParameter("@CodPostal", Entidad.CodPostal))
            .Add(New MySqlParameter("@IdProvincia", Entidad.IdProvincia))
        End With
        Return ExecuteNonQuery(Update)
    End Function

    Public Function Remove(CP As Short) As Short Implements iRepositorioGenerico(Of Ciudades).Remove
        Parametros = New List(Of MySqlParameter)
        Parametros.Add(New MySqlParameter("@IdCiudades", CP))
        Return ExecuteNonQuery(Delete)
    End Function

    Public Function GetAll() As IEnumerable(Of Ciudades) Implements iRepositorioGenerico(Of Ciudades).GetAll
        Dim tablaResultados = ExecuteReader(SelectAll)
        Dim listaCiudad = New List(Of Ciudades)
        For Each fila As DataRow In tablaResultados.Rows
            Dim ciudad As New Ciudades
            With ciudad
                .IdCiudades = CShort(fila.Item(0).ToString)
                .NombreCiudad = fila.Item(1).ToString
                .CodPostal = fila.Item(2).ToString
                .Provincia = fila.Item(3).ToString
            End With
            listaCiudad.Add(ciudad)
        Next
        Return listaCiudad
    End Function

    Function GetAllByProvincia(pkProvincia As Integer) As IEnumerable(Of Ciudades) Implements iRepositorioCiudades.GetAllByProvincia
        Dim tablaResultados = ExecuteReader(SelectAllByProvincia & pkProvincia)
        Dim listaCiudad = New List(Of Ciudades)
        For Each fila As DataRow In tablaResultados.Rows
            Dim ciudad As New Ciudades
            With ciudad
                .IdCiudades = CShort(fila.Item(0).ToString)
                .NombreCiudad = fila.Item(1).ToString
                .CodPostal = fila.Item(2).ToString
            End With
            listaCiudad.Add(ciudad)
        Next
        Return listaCiudad
    End Function

#End Region


End Class
