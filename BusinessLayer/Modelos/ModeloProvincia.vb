Imports DataAccessLayer, MySql.Data.MySqlClient, System.Text.RegularExpressions
Public Class ModeloProvincia
#Region "CAMPOS"
    Private _IdProvincia As Int16
    Private _NombreProvincia As String
    Private _DateSys As Date
    Private _Eliminado As Boolean
    Private _IdUsuario As Int16

    Private _Estado As EstadoDeEntidad
    Private _ListaProvincia As List(Of ModeloProvincia)
    Private _RepositorioProvincia As RepositorioProvincia
#End Region
#Region "PROPIEDADES"
    Public Property IdProvincia As Short
        Get
            Return _IdProvincia
        End Get
        Set(value As Short)
            _IdProvincia = value
        End Set
    End Property

    Public Property NombreProvincia As String
        Get
            Return _NombreProvincia
        End Get
        Set(value As String)

            If validarCadena("^[a-zA-ZñÑ\s]+$", value) And value.Length <= 20 Then
                _NombreProvincia = value
            ElseIf value.Length > 20 Then
                Throw New ArgumentException("El Nombre no debe superar los 20 caracteres")
            ElseIf value = "" Then
                Throw New ArgumentException("El Nombre de la provincia es obligatorio")
            ElseIf validarCadena("^[a-zA-ZñÑ\s]+$", value) = False Then
                Throw New ArgumentException("La provincia no puede contener números y tampoco caracteres especiales")
            End If

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
#End Region

#Region "CONSTRUCTOR"
    Public Sub New()
        _RepositorioProvincia = New Repositorioprovincia
    End Sub
#End Region

#Region "METODOS"
    Public Function GuardarCambios() As String
        Dim mensaje = ""
        Dim provinciaDM As New Provincia
        Try
            With provinciaDM
                .IdProvincia = Me.IdProvincia
                .NombreProvincia = Me.NombreProvincia

                .Eliminado = Me.Eliminado
            End With
            Select Case Estado
                Case EstadoDeEntidad.Agregar
                    _RepositorioProvincia.Add(provinciaDM)
                    mensaje = "Registro exitoso"
                Case EstadoDeEntidad.Editar
                    _RepositorioProvincia.Edit(provinciaDM)
                    mensaje = "Actualizacion exitosa"
                Case EstadoDeEntidad.Eliminar
                    _RepositorioProvincia.Remove(provinciaDM.IdProvincia)
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

    Public Function ObtenerTodos() As List(Of ModeloProvincia)
        Dim provinciaDM = _RepositorioProvincia.GetAll
        _ListaProvincia = New List(Of ModeloProvincia)
        For Each Item As Provincia In provinciaDM
            _ListaProvincia.Add(New ModeloProvincia With {
                               .IdProvincia = Item.IdProvincia,
                               .NombreProvincia = Item.NombreProvincia,
                               .DateSys = Item.DateSys,
                               .Eliminado = Item.Eliminado,
                               .IdUsuario = Item.IdUsuario
            })
        Next

        Return _ListaProvincia
    End Function


    Public Function ObtenerProvincia(idProvincia As Int16) As ModeloProvincia
        Dim provinciaDM = _RepositorioProvincia.ObtenerProvincia(idProvincia)
        With Me
            .IdProvincia = provinciaDM.IdProvincia
            .NombreProvincia = provinciaDM.NombreProvincia
        End With
        Return Me
    End Function


    Public Function FiltrarProvincia(Filtro As String) As List(Of ModeloProvincia)
        Try
            Return _ListaProvincia.FindAll(Function(e) e.NombreProvincia.ToLower.Contains(Filtro.ToLower))
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
