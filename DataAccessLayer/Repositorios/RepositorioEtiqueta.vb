Imports MySql.Data.MySqlClient
Public Class RepositorioEtiqueta
    Inherits RepositorioMaestro
    Implements iRepositorioEtiqueta
#Region "VARIABLES"
    Private SelectAll As String
    Private SelectOne As String
    Private Insert As String
    Private Update As String
    Private Delete As String
    Private SelectProvincia As String
#End Region

#Region "CONSTRUCTOR"
    Public Sub New()
        SelectAll = "SELECT idetiqueta,nombreEtiqueta from etiqueta where etiqueta.eliminado = 0;"
        SelectOne = ""
        Insert = "Insert INTO etiqueta(nombreEtiqueta)VALUES(@NombreEtiqueta);"
        Update = "UPDATE etiqueta SET nombreEtiqueta = @NombreEtiqueta WHERE idetiqueta = @IdEtiqueta"
        Delete = "UPDATE etiqueta SET eliminado = '1' WHERE idetiqueta = @IdEtiqueta;"
    End Sub
#End Region

#Region "METODOS"

    Public Function Add(Entidad As Etiqueta) As Short Implements iRepositorioGenerico(Of Etiqueta).Add
        Parametros = New List(Of MySqlParameter)

        Parametros.Add(New MySqlParameter("@NombreEtiqueta", Entidad.NombreEtiqueta))

        Return ExecuteNonQuery(Insert)
    End Function

    Public Function Edit(Entidad As Etiqueta) As Short Implements iRepositorioGenerico(Of Etiqueta).Edit
        Parametros = New List(Of MySqlParameter)
        Parametros.Add(New MySqlParameter("@IdEtiqueta", Entidad.IdEtiqueta))
        Parametros.Add(New MySqlParameter("@NombreEtiqueta", Entidad.NombreEtiqueta))
        Return ExecuteNonQuery(Update)
    End Function

    Public Function Remove(CP As Short) As Short Implements iRepositorioGenerico(Of Etiqueta).Remove
        Parametros = New List(Of MySqlParameter)
        Parametros.Add(New MySqlParameter("@IdEtiqueta", CP))
        Return ExecuteNonQuery(Delete)
    End Function

    Public Function GetAll() As IEnumerable(Of Etiqueta) Implements iRepositorioGenerico(Of Etiqueta).GetAll
        Dim tablaResultados = ExecuteReader(SelectAll)
        Dim listaEtiqueta = New List(Of Etiqueta)
        For Each fila As DataRow In tablaResultados.Rows
            Dim etiqueta As New Etiqueta
            With etiqueta
                .IdEtiqueta = CShort(fila.Item(0).ToString)
                .NombreEtiqueta = fila.Item(1).ToString
            End With
            listaEtiqueta.Add(etiqueta)
        Next
        Return listaEtiqueta


    End Function
#End Region



End Class
