Imports BusinessLayer
Public Class frmAMContacto
#Region "CAMPOS"
    Private contacto As New ModeloContacto
    Private _idCiudad As Integer
    Private _Ciudad As String
    Private _TipoFormulario As TipoFormulario
    Private _idContacto As Int16
    Private ciudades As New ModeloCiudades
    Private nombrecompleto As String

#End Region


#Region "PROPIEDADES"
    Public Property IdContacto As Short
        Get
            Return _idContacto
        End Get
        Set(value As Short)
            _idContacto = value
        End Set
    End Property

    Public Property IdCiudad As Integer
        Get
            Return _idCiudad
        End Get
        Set(value As Integer)
            _idCiudad = value
        End Set
    End Property

    Public Property Ciudad As String
        Get
            Return _Ciudad
        End Get
        Set(value As String)
            _Ciudad = value
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

    Public Property Nombrecompleto1 As String
        Get
            Return nombrecompleto
        End Get
        Set(value As String)
            nombrecompleto = value
        End Set
    End Property
#End Region

#Region "METODOS"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        contacto = New ModeloContacto
        Try
            With contacto

                If (txtApellido.Text = "") Or (txtNombre.Text = "") Then
                    .NombreCompleto = ""
                Else
                    .NombreCompleto = txtApellido.Text.ToUpper & "," & txtNombre.Text.ToUpper
                End If
                .Apodo = txtApodo.Text.ToUpper
                .FechaNac = dtpFechaNac.Value
                .IdPrefijo = cbPrefijo.SelectedValue
                .IdEtiqueta = cbEtiqueta.SelectedValue
                .Direccion = txtDireccion.Text.ToUpper
                .IdProvincia = cbProvincia.SelectedValue
                If txtCiudad.Tag < 0 Then
                    MsgBox("TIENE QUE SELECCIONAR UNA CIUDAD")
                Else
                    .IdCiudad = (txtCiudad.Tag)
                End If
                If rbNo.Checked Then
                    .NombreEmpresa = ""
                Else
                    .NombreEmpresa = txtNombreEmpresa.Text.ToUpper
                End If
                .TelefonoMovil = txtTelefonoMovil.Text
                .TelefonoFijo = txtTelefonoFijo.Text
                .Correo = txtCorreo.Text.ToUpper

                If txtIdContacto.Text = "" Then
                    .Estado = EstadoDeEntidad.Agregar
                Else
                    .IdContacto = CInt(txtIdContacto.Text)
                    .Estado = EstadoDeEntidad.Editar
                End If

                MsgBox(contacto.GuardarCambios())
                If .Estado = 0 Then
                    limpiarTxt()
                ElseIf .Estado = 1 Then
                    Close()
                End If


            End With
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub frmAMContacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbNo.Checked = True

        Dim provincia As New ModeloProvincia
        cbProvincia.DataSource = provincia.ObtenerTodos
        cbProvincia.DisplayMember = "nombreProvincia"
        cbProvincia.ValueMember = "idProvincia"
        cbProvincia.Text = ""
        cbProvincia.SelectedValue = ""

        Dim prefijo As New ModeloPrefijo
        cbPrefijo.DataSource = prefijo.ObtenerTodos
        cbPrefijo.DisplayMember = "nombrePrefijo"
        cbPrefijo.ValueMember = "idprefijo"
        cbPrefijo.Text = ""
        cbPrefijo.SelectedValue = ""

        Dim etiqueta As New ModeloEtiqueta
        cbEtiqueta.DataSource = etiqueta.ObtenerTodos
        cbEtiqueta.DisplayMember = "nombreEtiqueta"
        cbEtiqueta.ValueMember = "idetiqueta"
        cbEtiqueta.Text = ""
        cbEtiqueta.SelectedValue = ""


        Select Case TipoFormulario
            Case TipoFormulario.Editar
                lblContactoId.Visible = True
                txtIdContacto.Visible = True
                contacto = New ModeloContacto
                contacto.ObtenerContacto(IdContacto)
                With contacto
                    Dim coma As Integer
                    coma = Nombrecompleto1.IndexOf(",")
                    txtApellido.Text = Nombrecompleto1.Substring(0, coma)
                    txtNombre.Text = Nombrecompleto1.Substring(coma + 1)
                    txtIdContacto.Text = contacto.IdContacto
                    txtApodo.Text = contacto.Apodo
                    txtNombreEmpresa.Text = contacto.NombreEmpresa
                    txtCorreo.Text = contacto.Correo
                    txtTelefonoFijo.Text = contacto.TelefonoFijo
                    txtTelefonoMovil.Text = contacto.TelefonoMovil
                    dtpFechaNac.Value = contacto.FechaNac
                    txtDireccion.Text = contacto.Direccion
                    cbPrefijo.Text = contacto.Prefijo
                    cbEtiqueta.Text = contacto.Etiqueta
                    cbProvincia.Text = contacto.Provincia
                    txtCiudad.Text = contacto.NombreCiudad
                    txtCiudad.Tag = contacto.IdCiudad
                    If txtNombreEmpresa.Text = "" Then
                        rbNo.Checked = True
                    Else
                        rbSi.Checked = True
                    End If
                End With
        End Select



    End Sub


    Private Sub cbProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProvincia.SelectedIndexChanged
        txtCiudad.Text = ""

    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub
    Private Sub btnProvincia_Click(sender As Object, e As EventArgs) Handles btnProvincia.Click

        If cbProvincia.Text = "" Then
            MsgBox("Debe seleccionar una provincia")
        Else
            Try
                Dim listaciudades As New frmLocalidades
                With listaciudades
                    .PkProvincia = cbProvincia.SelectedValue
                    .btnEditar.Visible = False
                    .btnEliminar.Visible = False
                    .btnNuevo.Visible = False
                    .btnActualizar.Visible = False
                    .Estado1 = True
                    'bajo el ancho y el alto del dgv
                    .dgvLocalidades.Width = 296
                    .dgvLocalidades.Height = 150
                    'oculto la columna 3 (provincia)
                    .dgvLocalidades.Columns(3).Visible = False
                    .ShowDialog()
                End With
                If listaciudades.DialogResult = DialogResult.OK Then
                    Me.IdCiudad = CInt(listaciudades.dgvLocalidades.CurrentRow.Cells(0).Value)
                    Me.Ciudad = listaciudades.dgvLocalidades.CurrentRow.Cells(1).Value
                    txtCiudad.Text = Me.Ciudad
                    txtCiudad.Tag = Me.IdCiudad
                End If
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub rbSi_CheckedChanged(sender As Object, e As EventArgs) Handles rbSi.CheckedChanged
        lblEmpresa.Visible = True
        txtNombreEmpresa.Visible = True

    End Sub

    Private Sub rbNo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNo.CheckedChanged
        lblEmpresa.Visible = False
        txtNombreEmpresa.Visible = False
    End Sub
    Public Sub limpiarTxt()

        txtApellido.Text = ""
        txtNombre.Text = ""
        txtIdContacto.Text = ""
        txtApodo.Text = ""
        txtNombreEmpresa.Text = ""
        txtCorreo.Text = ""
        txtTelefonoFijo.Text = ""
        txtTelefonoMovil.Text = ""
        dtpFechaNac.Value = Now
        txtDireccion.Text = ""
        cbPrefijo.SelectedValue = ""
        cbEtiqueta.SelectedValue = ""
        cbProvincia.SelectedValue = ""
        txtCiudad.Text = ""
        txtCiudad.Tag = ""

    End Sub
#End Region



End Class