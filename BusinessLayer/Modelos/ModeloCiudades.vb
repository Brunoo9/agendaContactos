Imports DataAccessLayer, MySql.Data.MySqlClient, System.Text.RegularExpressions
Public Class ModeloCiudades
#Region "CAMPOS"
    Private _IdCiudades As Int16
    Private _NombreCiudad As String
    Private _CodPostal As String
    Private _Provincia As String
    Private _IdProvincia As Int16
    Private _DateSys As Date
    Private _Eliminado As Boolean
    Private _IdUsuario As Int16

    Private _Estado As EstadoDeEntidad
    Private _ListaCiudad As List(Of ModeloCiudades)
    Private _RepositorioCiudades As RepositorioCiudades
#End Region
#Region "PROPIEDADES"
    Public Property IdCiudades As Short
        Get
            Return _IdCiudades
        End Get
        Set(value As Short)
            _IdCiudades = value
        End Set
    End Property
    Public Property NombreCiudad As String 'LISTO PAAAA
        Get
            Return _NombreCiudad
        End Get
        Set(value As String)
            If validarCadena("^([0-9]*\s)*[a-zA-ZñÑ\s]+$", value) And value.Length <= 25 Then
                _NombreCiudad = value
            ElseIf value.Length > 25 Then
                Throw New ArgumentException("El nombre no debe superar los 25 caracteres")
            ElseIf value = "" Then
                Throw New ArgumentException("El campo Nombre de la ciudad es obligatorio")
            ElseIf IsNumeric(value) Then
                Throw New ArgumentException("El nombre de la ciudad no puede tener solo números")
            ElseIf validarCadena("^[0-9]*\s*[a-zA-ZñÑ\s]+$", value) = False Then
                Throw New ArgumentException("El nombre de la ciudad no puede tener caracteres especiales")
            End If
        End Set
    End Property
    Public Property CodPostal As String 'LISTO PAAA
        Get
            Return _CodPostal
        End Get
        Set(value As String)
            If validarCadena("^([0-9])+$", value) And value.Length <= 5 Then
                _CodPostal = value
            ElseIf value.Length > 5 Then
                Throw New ArgumentException("Código postal invalido(Max 5 números)")
            ElseIf value = "" Then
                Throw New ArgumentException("El código postal es obligatorio")
            ElseIf validarCadena("^([0-9])+$", value) = False Then
                Throw New ArgumentException("Código postal inválido(sólo debe contener números)")
            End If
        End Set
    End Property

    Public Property Provincia As String
        Get
            Return _Provincia
        End Get
        Set(value As String)
            _Provincia = value
        End Set
    End Property

    Public Property DateSys As Date
        Private Get
            Return _DateSys
        End Get
        Set(value As Date)
            _DateSys = value
        End Set
    End Property

    Public Property Eliminado As Boolean
        Private Get
            Return _Eliminado
        End Get
        Set(value As Boolean)
            _Eliminado = value
        End Set
    End Property

    Public Property IdUsuario As Short
        Private Get
            Return _IdUsuario
        End Get
        Set(value As Short)
            _IdUsuario = value
        End Set
    End Property

    Public Property Estado As EstadoDeEntidad
        Get
            Return _Estado
        End Get
        Set(value As EstadoDeEntidad)
            _Estado = value
        End Set
    End Property

    Public Property IdProvincia As Short
        Private Get
            Return _IdProvincia
        End Get
        Set(value As Short)
            If value <= 0 Then
                Throw New ArgumentException("Debe seleccionar una provincia")

            Else
                _IdProvincia = value
            End If

        End Set
    End Property
#End Region

#Region "CONSTRUCTOR"
    Public Sub New()
        _RepositorioCiudades = New RepositorioCiudades
    End Sub
#End Region

#Region "METODOS"
    Public Function GuardarCambios() As String
        Dim mensaje = ""
        Dim ciudadDM As New Ciudades
        Try
            With ciudadDM
                .IdCiudades = Me.IdCiudades
                .NombreCiudad = Me.NombreCiudad
                .CodPostal = Me.CodPostal
                .IdProvincia = Me.IdProvincia
                .Eliminado = Me.Eliminado
            End With
            Select Case Estado
                Case EstadoDeEntidad.Agregar
                    _RepositorioCiudades.Add(ciudadDM)
                    mensaje = "Registro exitoso"
                Case EstadoDeEntidad.Editar
                    _RepositorioCiudades.Edit(ciudadDM)
                    mensaje = "Actualizacion exitosa"
                Case EstadoDeEntidad.Eliminar
                    _RepositorioCiudades.Remove(ciudadDM.IdCiudades)
                    mensaje = "Eliminacion satisfactoria"
            End Select
        Catch ErrSql As MySqlException
            If ErrSql.ErrorCode = 1062 Then
                mensaje = "Dato Duplicado"
            Else
                mensaje = ErrSql.Message
            End If
        Catch ex As Exception
            mensaje = ex.Message
        End Try
        Return mensaje
    End Function

    Public Function ObtenerTodos(Optional idprovincia As Integer = 0) As List(Of ModeloCiudades)
        Dim ciudadDM As List(Of Ciudades)
        If idprovincia = 0 Then
            ciudadDM = _RepositorioCiudades.GetAll
            _ListaCiudad = New List(Of ModeloCiudades)
        Else
            ciudadDM = _RepositorioCiudades.GetAllByProvincia(idprovincia)
            _ListaCiudad = New List(Of ModeloCiudades)

        End If
        For Each Item As Ciudades In ciudadDM
            _ListaCiudad.Add(New ModeloCiudades With {
                                   .IdCiudades = Item.IdCiudades,
                                   .NombreCiudad = Item.NombreCiudad,
                                   .CodPostal = Item.CodPostal,
                                   .Provincia = Item.Provincia,
                                   .DateSys = Item.DateSys,
                                   .Eliminado = Item.Eliminado,
                                   .IdUsuario = Item.IdUsuario
                })
        Next
        Return _ListaCiudad
    End Function

    Public Function ObtenerCiudad(idciudades As Int16) As ModeloCiudades
        Dim ciudadDM = _RepositorioCiudades.ObtenerCiudad(idciudades)
        With Me
            .IdCiudades = ciudadDM.IdCiudades
            .NombreCiudad = ciudadDM.NombreCiudad
            .CodPostal = ciudadDM.CodPostal
            .Provincia = ciudadDM.Provincia
        End With
        Return Me
    End Function




    Public Function FiltrarCiudad(Filtro As String) As List(Of ModeloCiudades)
        Try
            Return _ListaCiudad.FindAll(Function(e) e.NombreCiudad.ToLower.Contains(Filtro.ToLower))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function validarCadena(expresion As String, dato As String) As Boolean
        Dim RegExp As Regex = New Regex(expresion)
        Dim m As Match

        m = RegExp.Match(dato)
        If m.Captures.Count = 1 Then
            Return True
        Else
            Return False
        End If

    End Function
#End Region
End Class
