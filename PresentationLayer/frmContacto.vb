Imports BusinessLayer
Public Class frmContacto
#Region "CAMPOS"
    Private contacto As New ModeloContacto

    Private IdContacto As Int16
#End Region

#Region "METODOS"
    Private Sub frmContacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarContacto()
    End Sub

    Private Sub ListarContacto()
        Try

            dgvContacto.DataSource = contacto.ObtenerTodos
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Not dgvContacto.SelectedRows.Count = 0 Then
                contacto.IdContacto = CInt(dgvContacto.CurrentRow.Cells(0).Value)
                contacto.Estado = EstadoDeEntidad.Eliminar
                MsgBox(contacto.GuardarCambios())
                ListarContacto()
            Else

                MsgBox("Debe seleccionar almenos un registro")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frmC As New frmAMContacto
        With frmC
            .lblContacto.Text = "Nuevo Contacto"
            .Show()
        End With
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If Not dgvContacto.SelectedRows.Count = 0 And dgvContacto.SelectedRows.Count < 2 Then

                Dim frmC As New frmAMContacto
                With frmC
                    .TipoFormulario = TipoFormulario.Editar
                    .IdContacto = dgvContacto.CurrentRow.Cells(0).Value
                    .Nombrecompleto1 = dgvContacto.CurrentRow.Cells(1).Value

                    .ShowDialog()
                End With
            ElseIf dgvContacto.SelectedRows.Count > 1 Then
                MsgBox("Debe seleccionar un registro a la vez para editar")
            Else
                MsgBox("Debe seleccionar al menos registro para editar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFiltroContacto_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroContacto.TextChanged
        dgvContacto.DataSource = contacto.FiltrarContactos(txtFiltroContacto.Text)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        ListarContacto()
    End Sub




#End Region

End Class