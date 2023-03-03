Imports BusinessLayer
Public Class frmAMLocalidades

#Region "CAMPOS"
    Private ciudad As New ModeloCiudades
    Private _tipoFormulario As TipoFormulario
    Private idCiudad As Int16

#End Region
#Region "PROPIEDADES"
    Public Property TipoFormulario As TipoFormulario
        Get
            Return _tipoFormulario
        End Get
        Set(value As TipoFormulario)
            _tipoFormulario = value
        End Set
    End Property

    Public Property IdCiudad1 As Short
        Get
            Return idCiudad
        End Get
        Set(value As Short)
            idCiudad = value
        End Set
    End Property


#End Region

#Region "METODOS"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            With ciudad
                .NombreCiudad = txtLocalidad.Text.ToUpper
                .CodPostal = txtCodPostal.Text
                .IdProvincia = cbProvincia.SelectedValue
                If txtIdCiudad.Text = "" Then
                    .Estado = EstadoDeEntidad.Agregar
                Else
                    .IdCiudades = CInt(txtIdCiudad.Text)
                    .Estado = EstadoDeEntidad.Editar
                End If

                MsgBox(ciudad.GuardarCambios())

                If .Estado = 1 Then
                    Close()
                ElseIf .Estado = 0 Then
                    txtLocalidad.Text = ""
                    txtCodPostal.Text = ""
                    txtIdCiudad.Text = ""
                    cbProvincia.SelectedValue = ""
                End If
            End With
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub frmAMLocalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim provincia As New ModeloProvincia

        cbProvincia.DataSource = provincia.ObtenerTodos
        cbProvincia.DisplayMember = "nombreProvincia"
        cbProvincia.ValueMember = "idProvincia"
        cbProvincia.Text = ""
        cbProvincia.SelectedValue = ""

        Select Case TipoFormulario
            Case TipoFormulario.Editar
                ciudad.ObtenerCiudad(IdCiudad1)
                With ciudad
                    txtIdCiudad.Text = .IdCiudades
                    txtLocalidad.Text = .NombreCiudad
                    txtCodPostal.Text = .CodPostal
                    cbProvincia.Text = .Provincia
                End With
        End Select


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub
#End Region

End Class