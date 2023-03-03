Imports BusinessLayer
Public Class frmPrefijo
    Private prefijo As New ModeloPrefijo
    Private Sub frmPrefijo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarPrefijos()
        panelPrefijo.Visible = False
        lblPrefijo.Visible = False
    End Sub
    Private Sub ListarPrefijos()
        Try
            dgvPrefijos.DataSource = prefijo.ObtenerTodos

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        panelPrefijo.Visible = True
        lblPrefijo.Text = "Nuevo Prefijo"
        lblPrefijo.Visible = True
        txtIdPrefijo.Text = ""
        txtNombrePrefijo.Text = ""
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If Not dgvPrefijos.SelectedRows.Count = 0 And dgvPrefijos.SelectedRows.Count < 2 Then

                prefijo.IdPrefijo = dgvPrefijos.CurrentRow.Cells(0).Value
                prefijo.NombrePrefijo = dgvPrefijos.CurrentRow.Cells(1).Value
                txtIdPrefijo.Text = prefijo.IdPrefijo
                txtNombrePrefijo.Text = prefijo.NombrePrefijo
                panelPrefijo.Visible = True
                lblPrefijo.Text = "Editar Prefijo"
                lblPrefijo.Visible = True

            ElseIf dgvPrefijos.SelectedRows.Count > 1 Then
                MsgBox("Debe seleccionar un solo registro a la vez para editar")

            Else
                MsgBox("Debe seleccionar almenos un registro para editar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            With prefijo

                .NombrePrefijo = txtNombrePrefijo.Text.ToUpper
                If txtIdPrefijo.Text = "" Then
                    .Estado = EstadoDeEntidad.Agregar
                Else
                    .IdPrefijo = CInt(txtIdPrefijo.Text)
                    .Estado = EstadoDeEntidad.Editar
                End If
                MsgBox(prefijo.GuardarCambios())

                If .Estado = 0 Then
                    ListarPrefijos()
                    txtNombrePrefijo.Text = ""
                    txtIdPrefijo.Text = ""
                End If
            End With
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        panelPrefijo.Visible = False
        lblPrefijo.Visible = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Not dgvPrefijos.SelectedRows.Count = 0 And dgvPrefijos.SelectedRows.Count < 2 Then
                prefijo.IdPrefijo = CInt(dgvPrefijos.CurrentRow.Cells(0).Value)
                prefijo.Estado = EstadoDeEntidad.Eliminar
                MsgBox(prefijo.GuardarCambios())
                ListarPrefijos()
            ElseIf dgvPrefijos.SelectedRows.Count > 1 Then
                MsgBox("Debe seleccionar un solo registro a la vez")
            Else
                MsgBox("Debe seleccionar algun registro para editar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtFiltroPrefijo_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroPrefijo.TextChanged
        dgvPrefijos.DataSource = prefijo.FiltrarPrefijos(txtFiltroPrefijo.Text)
    End Sub
End Class