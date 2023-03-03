Imports BusinessLayer
Public Class frmLocalidades
#Region "CAMPOS"
    Private ciudad As New ModeloCiudades

    Private _pkProvincia As Integer
    Private _Estado1 As Boolean
#End Region

#Region "PROPIEDADES"
    Public Property PkProvincia As Integer
        Get
            Return _pkProvincia
        End Get
        Set(value As Integer)
            _pkProvincia = value
        End Set
    End Property

    Public Property Estado1 As Boolean
        Get
            Return _Estado1
        End Get
        Set(value As Boolean)
            _Estado1 = value
        End Set
    End Property

#End Region

#Region "METODOS"
    Private Sub frmLocalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarCiudades()
    End Sub

    Private Sub ListarCiudades()
        Try
            If Estado1 = "false" Then
                dgvLocalidades.DataSource = ciudad.ObtenerTodos
            Else
                btnAceptar.Visible = True
                btnCancelar.Visible = True
                dgvLocalidades.DataSource = ciudad.ObtenerTodos(PkProvincia)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Not dgvLocalidades.SelectedRows.Count = 0 And dgvLocalidades.SelectedRows.Count < 2 Then
                ciudad.IdCiudades = CInt(dgvLocalidades.CurrentRow.Cells(0).Value)
                ciudad.Estado = EstadoDeEntidad.Eliminar
                MsgBox(ciudad.GuardarCambios())
                ListarCiudades()
            ElseIf dgvLocalidades.SelectedRows.Count > 1 Then
                MsgBox("Debe seleccionar un solo registro a la vez")
            Else
                MsgBox("Debe seleccionar algun registro para editar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frm As New frmAMLocalidades
        With frm
            .lblLocalidad.Text = "Nueva Localidad"
            .txtCodPostal.Text = ""
            .txtIdCiudad.Text = ""
            .txtLocalidad.Text = ""
            .Show()
        End With
    End Sub


    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If Not dgvLocalidades.SelectedRows.Count = 0 Then
                Dim frmLocalidad As New frmAMLocalidades
                With frmLocalidad
                    .lblLocalidad.Text = "Editar Localidad"
                    .TipoFormulario = TipoFormulario.Editar
                    .IdCiudad1 = dgvLocalidades.CurrentRow.Cells(0).Value
                    '.MdiParent = frmPrincipal
                    .ShowDialog()
                End With
            Else
                MsgBox("Debe seleccionar un registro para editar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFiltroLocalidad_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroLocalidad.TextChanged
        dgvLocalidades.DataSource = ciudad.FiltrarCiudad(txtFiltroLocalidad.Text)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        ListarCiudades()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If dgvLocalidades.SelectedRows.Count > 0 Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MsgBox("Debe seleccionar una localidad")
            'Me.DialogResult = DialogResult.Cancel
            'Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub








#End Region

End Class