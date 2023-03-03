Imports DataAccessLayer, MySql.Data.MySqlClient, System.Text.RegularExpressions
Public Class ModeloPrefijo
#Region "CAMPOS"
    Private _IdPrefijo As Int16
    Private _Descripcion As String
    Private _NombrePrefijo As String
    Private _DateSys As Date
    Private _Eliminado As Boolean
    Private _IdUsuario As Int16

    Private _Estado As EstadoDeEntidad
    Private _ListaPrefijo As List(Of ModeloPrefijo)
    Private _RepositorioPrefijo As RepositorioPrefijo

#End Region


#Region "PROPIEDADES"
    Public Property IdPrefijo As Short
        Get
            Return _IdPrefijo
        End Get
        Set(value As Short)
            _IdPrefijo = value
        End Set
    End Property

    Public Property Descripcion As String
        Private Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property
    Public Property NombrePrefijo As String
        Get
            Return _NombrePrefijo
        End Get
        Set(value As String)
            If validarCadena("^[a-zA-Z ]+$", value) And value.Length <= 12 Then
                _NombrePrefijo = value
            ElseIf value.Length > 12 Then
                Throw New ArgumentException("El Nombre no debe superar los 12 caracteres")
            ElseIf value = "" Then
                Throw New ArgumentException("El nombre del prefijo es obligatorio")
            ElseIf validarCadena("^[a-zA-Z ]+$", value) = False Then
                Throw New ArgumentException("El nombre puede tener números y tampoco caracteres especiales")
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
        _RepositorioPrefijo = New RepositorioPrefijo
    End Sub
#End Region

#Region "METODOS"
    Public Function ObtenerTodos() As List(Of ModeloPrefijo)
        Dim prefijoDM = _RepositorioPrefijo.GetAll
        _ListaPrefijo = New List(Of ModeloPrefijo)
        For Each Item As Prefijo In prefijoDM
            _ListaPrefijo.Add(New ModeloPrefijo With {
                               .IdPrefijo = Item.IdPrefijo,
                               .NombrePrefijo = Item.NombrePrefijo,
                               .DateSys = Item.DateSys,
                               .Eliminado = Item.Eliminado,
                               .IdUsuario = Item.IdUsuario
            })
        Next

        Return _ListaPrefijo
    End Function
    Public Function GuardarCambios() As String
        Dim mensaje = ""
        Dim prefijoDM As New Prefijo
        Try
            With prefijoDM
                .IdPrefijo = Me.IdPrefijo
                .NombrePrefijo = Me.NombrePrefijo
                .Eliminado = Me.Eliminado
            End With
            Select Case Estado
                Case EstadoDeEntidad.Agregar
                    _RepositorioPrefijo.Add(prefijoDM)
                    mensaje = "Registro Exitoso"
                Case EstadoDeEntidad.Editar
                    _RepositorioPrefijo.Edit(prefijoDM)
                    mensaje = "Actualizacion Exitosa"
                Case EstadoDeEntidad.Eliminar
                    _RepositorioPrefijo.Remove(prefijoDM.IdPrefijo)
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


    Public Function FiltrarPrefijos(Filtro As String) As List(Of ModeloPrefijo)
        Try
            Return _ListaPrefijo.FindAll(Function(e) e.NombrePrefijo.ToLower.Contains(Filtro.ToLower))
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
