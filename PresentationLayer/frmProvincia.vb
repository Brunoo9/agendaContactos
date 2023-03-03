Imports BusinessLayer
Public Class frmProvincia
#Region "CAMPOS"
    Private provincia As New ModeloProvincia
    Private ciudad As New ModeloCiudades
#End Region
#Region "METODOS"
    Private Sub frmProvincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarProvincia()

    End Sub

    Private Sub ListarProvincia()
        Try
            dgvProvincia.DataSource = provincia.ObtenerTodos
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnProvincia_Click(sender As Object, e As EventArgs) Handles btnProvincia.Click
        Dim frm As New frmAMProvincia
        With frm
            .lblProvincia.Text = "Nueva Provincia"
            .txtIdProvincia.Text = ""
            .txtNombreProvincia.Text = ""
            .Show()
        End With
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If Not dgvProvincia.SelectedRows.Count = 0 Then
                Dim frmprovincia As New frmAMProvincia
                With frmprovincia

                    .TipoFormulario = TipoFormulario.Editar
                    .Idprovincia1 = dgvProvincia.CurrentRow.Cells(0).Value

                    .ShowDialog()
                End With
            Else
                MsgBox("Debe seleccionar almenos un registro para editar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Not dgvProvincia.SelectedRows.Count = 0 And dgvProvincia.SelectedRows.Count < 2 Then
                provincia.IdProvincia = CInt(dgvProvincia.CurrentRow.Cells(0).Value)
                provincia.Estado = EstadoDeEntidad.Eliminar
                MsgBox(provincia.GuardarCambios())
                ListarProvincia()
            ElseIf dgvProvincia.SelectedRows.Count > 1 Then
                MsgBox("Debe seleccionar un solo registro a la vez")
            Else
                MsgBox("Debe seleccionar algun registro para editar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFiltroProvincia_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroProvincia.TextChanged
        dgvProvincia.DataSource = provincia.FiltrarProvincia(txtFiltroProvincia.Text)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ListarProvincia()
    End Sub

#End Region


End Class