Imports BusinessLayer
Public Class frmAMProvincia
#Region "CAMPOS"
    Private provincia As New ModeloProvincia
    Private idprovincia As Int16
    Private _TipoFormulario As TipoFormulario
#End Region

#Region "PROPIEDADES"
    Public Property Idprovincia1 As Short
        Get
            Return idprovincia
        End Get
        Set(value As Short)
            idprovincia = value
        End Set
    End Property

    Public Property TipoFormulario As TipoFormulario
        Get
            Return _TipoFormulario
        End Get
        Set(value As TipoFormulario)
            _TipoFormulario = value
        End Set
    End Property
#End Region

#Region "METODOS"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            With provincia
                .NombreProvincia = txtNombreProvincia.Text.ToUpper
                If txtIdProvincia.Text = "" Then
                    .Estado = EstadoDeEntidad.Agregar
                Else
                    .IdProvincia = CInt(txtIdProvincia.Text)
                    .Estado = EstadoDeEntidad.Editar
                End If
                MsgBox(provincia.GuardarCambios())
                If .Estado = 0 Then
                    txtNombreProvincia.Text = ""
                    txtIdProvincia.Text = ""

                End If



            End With
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub frmAMProvincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case TipoFormulario
            Case TipoFormulario.Editar
                provincia.ObtenerProvincia(Idprovincia1)
                With provincia
                    txtIdProvincia.Text = .IdProvincia
                    txtNombreProvincia.Text = .NombreProvincia
                End With
        End Select

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub
#End Region




End Class