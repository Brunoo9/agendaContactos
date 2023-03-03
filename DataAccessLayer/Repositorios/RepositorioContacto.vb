Imports MySql.Data.MySqlClient
Public Class RepositorioContacto
    Inherits RepositorioMaestro
    Implements iRepositorioContacto

#Region "CAMPOS"
    Private SelectAll As String
    Private SelectOne As String
    Private Insert As String
    Private Update As String
    Private Delete As String
    Private SelectProvincia As String
#End Region
#Region "CONSTRUCTOR"
    Public Sub New()
        SelectAll = "SELECT * FROM agenda.vista_contacto2;"
        SelectOne = "SELECT idcontacto,nombreCompleto,apodo,nombreEmpresa,correo,telefonoFijo,telefonoMovil,fechaNac,direccion,
                     nombrePrefijo,nombreEtiqueta,nombreProvincia,nombreCiudad,idciudades FROM contacto,prefijo,etiqueta,provincia,ciudades
                     WHERE contacto.prefijo = prefijo.idprefijo and contacto.etiqueta = etiqueta.idetiqueta and 
                     contacto.provincia2 = provincia.idprovincia and contacto.idCiudad = ciudades.idciudades and idcontacto ="
        Insert = "Insert INTO contacto(nombreCompleto,apodo,nombreEmpresa,correo,telefonoFijo,telefonoMovil,
                    fechaNac,direccion,prefijo,etiqueta,provincia2,idCiudad)VALUES (@NombreCompleto,@Apodo,@NombreEmpresa,
                    @Correo,@TelefonoFijo,@TelefonoMovil,@FechaNac,@Direccion,@Prefijo,@Etiqueta,@Provincia,@NombreCiudad);"

        Update = "UPDATE contacto SET nombreCompleto = @NombreCompleto,apodo = @Apodo,nombreEmpresa = @NombreEmpresa,
                correo = @Correo,telefonoFijo = @TelefonoFijo ,telefonoMovil = @TelefonoMovil ,fechaNac = @FechaNac,
                direccion = @Direccion,prefijo = @IdPrefijo,etiqueta = @IdEtiqueta ,provincia2 = @IdProvincia ,idCiudad = @IdCiudad WHERE idcontacto = @IdContacto"

        Delete = "UPDATE contacto SET eliminado = '1' WHERE idcontacto = @IdContacto;"
    End Sub
#End Region
#Region "METODOS"
    Public Function ObtenerContacto(CP As Short) As Contacto Implements iRepositorioContacto.ObtenerContacto
        SelectOne = SelectOne & CP
        Dim tablaResultados = ExecuteReader(SelectOne)
        Dim contacto As New Contacto
        If tablaResultados.Rows.Count > 0 Then
            With contacto
                .IdContacto = CShort(tablaResultados.Rows(0).Item(0).ToString)
                .NombreCompleto = tablaResultados.Rows(0).Item(1).ToString
                .Apodo = tablaResultados.Rows(0).Item(2).ToString
                .NombreEmpresa = tablaResultados.Rows(0).Item(3).ToString
                .Correo = tablaResultados.Rows(0).Item(4).ToString
                .TelefonoFijo = tablaResultados.Rows(0).Item(5).ToString
                .TelefonoMovil = tablaResultados.Rows(0).Item(6).ToString
                .FechaNac = CDate(tablaResultados.Rows(0).Item(7).ToString)
                .Direccion = tablaResultados.Rows(0).Item(8).ToString
                .Prefijo = tablaResultados.Rows(0).Item(9).ToString
                .Etiqueta = tablaResultados.Rows(0).Item(10).ToString
                .Provincia = tablaResultados.Rows(0).Item(11).ToString
                .NombreCiudad = tablaResultados.Rows(0).Item(12).ToString
                .IdCiudad = tablaResultados.Rows(0).Item(13).ToString

            End With
        End If
        Return contacto
    End Function

    Public Function Add(Entidad As Contacto) As Short Implements iRepositorioGenerico(Of Contacto).Add
        Parametros = New List(Of MySqlParameter)
        With Parametros
            .Add(New MySqlParameter("@NombreCompleto", Entidad.NombreCompleto))
            .Add(New MySqlParameter("@Apodo", Entidad.Apodo))
            .Add(New MySqlParameter("@NombreEmpresa", Entidad.NombreEmpresa))
            .Add(New MySqlParameter("@Correo", Entidad.Correo))
            .Add(New MySqlParameter("@TelefonoFijo", Entidad.TelefonoFijo))
            .Add(New MySqlParameter("@TelefonoMovil", Entidad.TelefonoMovil))
            .Add(New MySqlParameter("@FechaNac", Entidad.FechaNac))
            .Add(New MySqlParameter("@Direccion", Entidad.Direccion))
            .Add(New MySqlParameter("@Prefijo", Entidad.IdPrefijo))
            .Add(New MySqlParameter("@Etiqueta", Entidad.IdEtiqueta))
            .Add(New MySqlParameter("@Provincia", Entidad.IdProvincia))
            .Add(New MySqlParameter("@NombreCiudad", Entidad.IdCiudad))

        End With
        Return ExecuteNonQuery(Insert)
    End Function

    Public Function Edit(Entidad As Contacto) As Short Implements iRepositorioGenerico(Of Contacto).Edit

        Parametros = New List(Of MySqlParameter)
        With Parametros
            .Add(New MySqlParameter("@IdContacto", Entidad.IdContacto))
            .Add(New MySqlParameter("@NombreCompleto", Entidad.NombreCompleto))
            .Add(New MySqlParameter("@Apodo", Entidad.Apodo))
            .Add(New MySqlParameter("@NombreEmpresa", Entidad.NombreEmpresa))
            .Add(New MySqlParameter("@Correo", Entidad.Correo))
            .Add(New MySqlParameter("@TelefonoFijo", Entidad.TelefonoFijo))
            .Add(New MySqlParameter("@TelefonoMovil", Entidad.TelefonoMovil))
            .Add(New MySqlParameter("@FechaNac", Entidad.FechaNac))
            .Add(New MySqlParameter("@Direccion", Entidad.Direccion))
            .Add(New MySqlParameter("@IdPrefijo", Entidad.IdPrefijo))
            .Add(New MySqlParameter("@IdEtiqueta", Entidad.IdEtiqueta))
            .Add(New MySqlParameter("@IdProvincia", Entidad.IdProvincia))
            .Add(New MySqlParameter("@IdCiudad", Entidad.IdCiudad))
        End With
        Return ExecuteNonQuery(Update)

    End Function

    Public Function Remove(CP As Short) As Short Implements iRepositorioGenerico(Of Contacto).Remove
        Parametros = New List(Of MySqlParameter)
        Parametros.Add(New MySqlParameter("@IdContacto", CP))
        Return ExecuteNonQuery(Delete)
    End Function

    Public Function GetAll() As IEnumerable(Of Contacto) Implements iRepositorioGenerico(Of Contacto).GetAll

        Dim tablaResultados = ExecuteReader(SelectAll)
        Dim listaContacto = New List(Of Contacto)
        For Each fila As DataRow In tablaResultados.Rows
            Dim contacto As New Contacto
            With contacto
                .IdContacto = CShort(fila.Item(0).ToString)
                .NombreCompleto = fila.Item(1).ToString
                .Apodo = fila.Item(2).ToString
                .NombreEmpresa = fila.Item(3).ToString
                .Correo = fila.Item(4).ToString
                .TelefonoFijo = fila.Item(5).ToString
                .TelefonoMovil = fila.Item(6).ToString
                .FechaNac = fila.Item(7).ToString
                .Direccion = fila.Item(8).ToString
                .Prefijo = fila.Item(9).ToString
                .Etiqueta = fila.Item(10).ToString
                .Provincia = fila.Item(11).ToString
                .NombreCiudad = fila.Item(12).ToString
            End With
            listaContacto.Add(contacto)
        Next
        Return listaContacto



    End Function
#End Region

End Class
