Imports DataAccessLayer, MySql.Data.MySqlClient, System.Text.RegularExpressions

Public Class ModeloContacto
#Region "CAMPOS"
    Private _IdContacto As Int16
    Private _NombreCompleto As String
    Private _Apodo As String
    Private _NombreEmpresa As String
    Private _Correo As String
    Private _TelefonoFijo As String
    Private _TelefonoMovil As String
    Private _FechaNac As Date
    Private _Direccion As String
    Private _Prefijo As String
    Private _idPrefijo As Integer
    Private _Etiqueta As String
    Private _idEtiqueta As Integer
    Private _Provincia As String
    Private _IdProvincia As Integer
    Private _NombreCiudad As String
    Private _IdCiudad As Integer
    Private _DateSys As Date
    Private _Eliminado As Boolean
    Private _IdUsuario As Int16
    Private _Edad As Long

    Private _Estado As EstadoDeEntidad
    Private _ListaContacto As List(Of ModeloContacto)
    Private _RepositorioContacto As RepositorioContacto
#End Region

#Region "PROPIEDADES"
    Public Property IdContacto As Short
        Get
            Return _IdContacto
        End Get
        Set(value As Short)
            _IdContacto = value
        End Set
    End Property

    Public Property NombreCompleto As String
        Get
            Return _NombreCompleto
        End Get
        Set(value As String)
            If validarCadena("^[a-zA-ZñÑ\sÁÉÍÓÚ]+\,[a-zA-ZñÑ\sÁÉÍÓÚ]+$", value) And value.Length <= 35 Then
                _NombreCompleto = value
            ElseIf value.Length > 35 Then
                Throw New ArgumentException("El Nombre no debe superar los 35 caracteres")
            ElseIf value = "" Then
                Throw New ArgumentException("El Nombre y Apellido son campos obligatorios")
            ElseIf validarCadena("^[a-zA-ZñÑ\s]+\,[a-zA-ZñÑ\s]+$", value) = False Then
                Throw New ArgumentException("El Nombre y Apellido solo deben contener letras")
            End If
        End Set
    End Property

    Public Property Apodo As String
        Get
            Return _Apodo
        End Get
        Set(value As String)
            If validarCadena("^[a-zA-ZñÑ\s]+$", value) And value.Length <= 15 Or value = "" Then
                _Apodo = value
            ElseIf value.Length > 15 Then
                Throw New ArgumentException("El ápodo no puede superar los 15 caracteres")
            Else
                Throw New ArgumentException("El apodo solo deben contener letras")
            End If
        End Set
    End Property

    Public Property NombreEmpresa As String
        Get
            Return _NombreEmpresa
        End Get
        Set(value As String)

            If validarCadena("^[a-zA-ZñÑ\s'.']+$", value) And value.Length <= 21 Or value = "" Then
                _NombreEmpresa = value
            ElseIf (value.Length > 21) Then
                Throw New ArgumentException("El nombre del lugar de trabajo no puede superar los 21 caracteres")
            Else
                Throw New ArgumentException("El nombre del lugar de trabajo solo debe contener letras")
            End If

        End Set
    End Property


    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(value As String)
            If validarCadena("^[a-zA-Z]+((.|_)[a-zA-Z0-9]+)*((.|_)[a-zA-Z0-9]+)*@[a-zA-Z0-9]+\.\w\w\w(.\w\w)?$", value) Then
                _Correo = value
            ElseIf (value = "") Then
                Throw New ArgumentException("El campo email es obligatorio")
            Else
                Throw New ArgumentException("El mail debe ser valido(nombre@dominio.com)")
            End If

        End Set
    End Property

    Public Property TelefonoFijo As String
        Get
            Return _TelefonoFijo
        End Get
        Set(value As String)

            If validarCadena("^([0-9])+$", value) = True And (value.Length >= 9) And (value.Length <= 12) Or value = "" Then
                _TelefonoFijo = value
            ElseIf (value.Length < 9) And IsNumeric(value) = True Then
                Throw New ArgumentException("Número de Télefono Fijo inválido(Min 9 y máx 12 numeros)")
            Else
                Throw New ArgumentException("El Télefono Fijo solo debe contener numeros")
            End If

        End Set
    End Property

    Public Property TelefonoMovil As String
        Get
            Return _TelefonoMovil
        End Get
        Set(value As String)

            If validarCadena("^([0-9])+$", value) = True And (value.Length >= 9) And (value.Length <= 12) Then
                _TelefonoMovil = value
            ElseIf (value.Length < 9) And IsNumeric(value) = True Then
                Throw New ArgumentException("Número de Télefono Móvil inválido(Min 9 y máx 12 numeros)")
            ElseIf (value = "") Then

                _TelefonoMovil = value
            Else
                Throw New ArgumentException("El Télefono Móvil solo debe contener numeros")
            End If
        End Set
    End Property
    Public Property FechaNac As Date
        Get
            Return _FechaNac
        End Get
        Set(value As Date)
            If Date.Compare(value, Date.Now) < 0 Then
                _FechaNac = value
            Else
                Throw New ArgumentException("La fecha ingresada no puede ser mayor a la actual")
            End If
        End Set
    End Property
    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)

            If validarCadena("^[a-zA-ZñÑ\s0-9]+$", value) And value.Length <= 40 Then
                _Direccion = value
            ElseIf value.Length > 40 Then
                Throw New ArgumentException("El domicilio no puede superar los 40 caracteres")
            ElseIf value = "" Then
                Throw New ArgumentException("La direccion/domicilio es obligatorio")
            Else
                Throw New ArgumentException("El domicilio no puede contener caracteres especiales")
            End If
        End Set
    End Property

    Public Property Prefijo As String
        Get
            Return _Prefijo
        End Get
        Set(value As String)
            _Prefijo = value
        End Set
    End Property

    Public Property Etiqueta As String
        Get
            Return _Etiqueta
        End Get
        Set(value As String)
            _Etiqueta = value
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

    Public Property NombreCiudad As String
        Get
            Return _NombreCiudad
        End Get
        Set(value As String)
            _NombreCiudad = value
        End Set
    End Property

    Public Property IdCiudad As Integer
        Get
            Return _IdCiudad
        End Get
        Set(value As Integer)
            If value < 0 Or value = 0 Then
                Throw New ArgumentException("Debe seleccionar una ciudad")
            Else
                _IdCiudad = value
            End If

        End Set
    End Property

    Public Property IdProvincia As Integer
        Private Get
            Return _IdProvincia
        End Get
        Set(value As Integer)
            If value < 0 Or value = 0 Then
                Throw New ArgumentException("Debe seleccionar una Provincia")
            Else
                _IdProvincia = value
            End If

        End Set
    End Property

    Public Property IdEtiqueta As Integer
        Private Get
            Return _idEtiqueta
        End Get
        Set(value As Integer)
            _idEtiqueta = value
        End Set
    End Property

    Public Property IdPrefijo As Integer
        Private Get
            Return _idPrefijo
        End Get
        Set(value As Integer)
            _idPrefijo = value
        End Set
    End Property

    Public Property Edad As Long
        Get
            Return _Edad
        End Get
        Set(value As Long)
            _Edad = value
        End Set
    End Property


#End Region
#Region "CONSTRUCTOR"
    Public Sub New()
        _RepositorioContacto = New RepositorioContacto
    End Sub
#End Region
#Region "METODOS"
    Public Function GuardarCambios() As String
        Dim mensaje = ""
        Dim contactoDM As New Contacto
        Try
            With contactoDM
                .IdContacto = Me.IdContacto
                .NombreCompleto = Me.NombreCompleto
                .Apodo = Me.Apodo
                .NombreEmpresa = Me.NombreEmpresa
                .Correo = Me.Correo
                .TelefonoFijo = Me.TelefonoFijo
                .TelefonoMovil = Me.TelefonoMovil
                .FechaNac = Me.FechaNac
                .Direccion = Me.Direccion
                .IdPrefijo = Me.IdPrefijo
                .IdEtiqueta = Me.IdEtiqueta
                .IdProvincia = Me.IdProvincia
                .IdCiudad = Me.IdCiudad
                .Eliminado = Me.Eliminado
            End With
            Select Case Estado
                Case EstadoDeEntidad.Agregar
                    _RepositorioContacto.Add(contactoDM)
                    mensaje = "Registro Exitoso"
                Case EstadoDeEntidad.Editar
                    _RepositorioContacto.Edit(contactoDM)
                    mensaje = "Actualizacion Exitosa"
                Case EstadoDeEntidad.Eliminar
                    _RepositorioContacto.Remove(contactoDM.IdContacto)
                    mensaje = "Eliminacion Satisfactoria"
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

    Public Function ObtenerTodos() As List(Of ModeloContacto)
        Dim contactoDM = _RepositorioContacto.GetAll
        _ListaContacto = New List(Of ModeloContacto)
        For Each Item As Contacto In contactoDM
            _ListaContacto.Add(New ModeloContacto With {
                .IdContacto = Item.IdContacto,
                .NombreCompleto = Item.NombreCompleto,
                .Apodo = Item.Apodo,
                .NombreEmpresa = Item.NombreEmpresa,
                .Correo = Item.Correo,
                .TelefonoFijo = Item.TelefonoFijo,
                .TelefonoMovil = Item.TelefonoMovil,
                .FechaNac = Item.FechaNac,
                .Direccion = Item.Direccion,
                .Prefijo = Item.Prefijo,
                .Etiqueta = Item.Etiqueta,
                .Provincia = Item.Provincia,
                .NombreCiudad = Item.NombreCiudad,
                .DateSys = Item.DateSys,
                .Eliminado = Item.Eliminado,
                .IdUsuario = Item.IdUsuario,
                .Edad = CalcularEdad(Item.FechaNac)
            })
        Next

        Return _ListaContacto
    End Function

    Public Function ObtenerContacto(idContacto As Int16) As ModeloContacto
        Dim contactoDM = _RepositorioContacto.ObtenerContacto(idContacto)
        With Me
            .IdContacto = contactoDM.IdContacto
            .NombreCompleto = contactoDM.NombreCompleto
            .Apodo = contactoDM.Apodo
            .NombreEmpresa = contactoDM.NombreEmpresa
            .Correo = contactoDM.Correo
            .TelefonoFijo = contactoDM.TelefonoFijo
            .TelefonoMovil = contactoDM.TelefonoMovil
            .FechaNac = contactoDM.FechaNac
            .Direccion = contactoDM.Direccion
            .Prefijo = contactoDM.Prefijo
            .Etiqueta = contactoDM.Etiqueta
            .Provincia = contactoDM.Provincia
            .NombreCiudad = contactoDM.NombreCiudad
            .IdCiudad = contactoDM.IdCiudad

        End With
        Return Me
    End Function

    Private Function CalcularEdad(FechNac As Date) As Long
        Dim fechaActual = Now
        Return DateDiff(DateInterval.Year, FechNac, fechaActual)
    End Function
    Public Function FiltrarContactos(Filtro As String) As List(Of ModeloContacto)
        Try
            Return _ListaContacto.FindAll(Function(e) e.NombreCompleto.ToLower.Contains(Filtro.ToLower))
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
