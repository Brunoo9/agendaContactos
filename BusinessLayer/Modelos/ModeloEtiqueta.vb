Imports DataAccessLayer, MySql.Data.MySqlClient, System.Text.RegularExpressions
Public Class ModeloEtiqueta
#Region "CAMPOS"
    Private _IdEtiqueta As Int16
    Private _Descripcion As String
    Private _NombreEtiqueta As String
    Private _DateSys As Date
    Private _Eliminado As Boolean
    Private _IdUsuario As Int16

    Private _Estado As EstadoDeEntidad
    Private _ListaProvincia As List(Of ModeloEtiqueta)
    Private _RepositorioEtiqueta As RepositorioEtiqueta
#End Region

#Region "PROPIEDADES"
    Public Property IdEtiqueta As Short
        Get
            Return _IdEtiqueta
        End Get
        Set(value As Short)
            _IdEtiqueta = value
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

    Public Property NombreEtiqueta As String
        Get
            Return _NombreEtiqueta
        End Get
        Set(value As String)
            If validarCadena("^[a-zA-ZñÑ]+(['/'][a-zA-ZñÑ]*)*$", value) And value.Length <= 11 Then
                _NombreEtiqueta = value
            ElseIf value.Length > 11 Then
                Throw New ArgumentException("El nombre de la etiqueta no puede superar los 11 caracteres")
            ElseIf value = "" Then
                Throw New ArgumentException("El nombre de la etiqueta es obligatorio")
            ElseIf validarCadena("^[a-zA-Z]+(['/'][a-zA-Z]+)*$", value) = False Then
                Throw New ArgumentException("No puede contener números, y tampoco caracteres especiales salvo '/'")

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
        Private Get
            Return _Estado
        End Get
        Set(value As EstadoDeEntidad)
            _Estado = value
        End Set
    End Property
#End Region


#Region "CONSTRUCTOR"
    Public Sub New()
        _RepositorioEtiqueta = New RepositorioEtiqueta
    End Sub
#End Region


#Region "METODOS"
    Public Function ObtenerTodos() As List(Of ModeloEtiqueta)
        Dim etiquetaDM = _RepositorioEtiqueta.GetAll
        _ListaProvincia = New List(Of ModeloEtiqueta)
        For Each Item As Etiqueta In etiquetaDM
            _ListaProvincia.Add(New ModeloEtiqueta With {
                               .IdEtiqueta = Item.IdEtiqueta,
                               .NombreEtiqueta = Item.NombreEtiqueta,
                               .DateSys = Item.DateSys,
                               .Eliminado = Item.Eliminado,
                               .IdUsuario = Item.IdUsuario
            })
        Next

        Return _ListaProvincia
    End Function

    Public Function GuardarCambios() As String
        Dim mensaje = ""
        Dim etiquetaDM As New Etiqueta
        Try
            With etiquetaDM
                .IdEtiqueta = Me.IdEtiqueta
                .NombreEtiqueta = Me.NombreEtiqueta
                .Eliminado = Me.Eliminado

            End With
            Select Case Estado
                Case EstadoDeEntidad.Agregar
                    _RepositorioEtiqueta.Add(etiquetaDM)
                    mensaje = "Registro Exitoso"
                Case EstadoDeEntidad.Editar
                    _RepositorioEtiqueta.Edit(etiquetaDM)
                    mensaje = "Actualizacion Exitosa"
                Case EstadoDeEntidad.Eliminar
                    _RepositorioEtiqueta.Remove(etiquetaDM.IdEtiqueta)
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

    Public Function FiltrarEtiquetas(Filtro As String) As List(Of ModeloEtiqueta)
        Try
            Return _ListaProvincia.FindAll(Function(e) e.NombreEtiqueta.ToLower.Contains(Filtro.ToLower))
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
