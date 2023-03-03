Imports BusinessLayer
Public Class frmEtiqueta
    Private etiqueta As New ModeloEtiqueta
    Private Sub frmEtiqueta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelEtiqueta.Visible = False
        lblEtiqueta.Visible = False
        ListarEtiquetas()
    End Sub
    Private Sub ListarEtiquetas()
        Try

            dgvEtiqueta.DataSource = etiqueta.ObtenerTodos


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        panelEtiqueta.Visible = True
        lblEtiqueta.Text = "Nueva Etiqueta"
        lblEtiqueta.Visible = True
        txtIdEtiqueta.Text = ""
        txtNombreEtiqueta.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Not dgvEtiqueta.SelectedRows.Count = 0 And dgvEtiqueta.SelectedRows.Count < 2 Then
                etiqueta.IdEtiqueta = CInt(dgvEtiqueta.CurrentRow.Cells(0).Value)
                etiqueta.Estado = EstadoDeEntidad.Eliminar
                MsgBox(etiqueta.GuardarCambios())
                ListarEtiquetas()
            ElseIf dgvEtiqueta.SelectedRows.Count > 2 Then
                MsgBox("Debe seleccionar un solo registro a la vez")
            Else
                MsgBox("Debe seleccionar algun registro para editar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        panelEtiqueta.Visible = False
        lblEtiqueta.Visible = False

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If Not dgvEtiqueta.SelectedRows.Count = 0 And dgvEtiqueta.SelectedRows.Count < 2 Then
                etiqueta.IdEtiqueta = dgvEtiqueta.CurrentRow.Cells(0).Value
                etiqueta.NombreEtiqueta = dgvEtiqueta.CurrentRow.Cells(1).Value
                txtIdEtiqueta.Text = etiqueta.IdEtiqueta
                txtNombreEtiqueta.Text = etiqueta.NombreEtiqueta
                panelEtiqueta.Visible = True
                lblEtiqueta.Text = "Editar Etiqueta"
                lblEtiqueta.Visible = True
            ElseIf dgvEtiqueta.SelectedRows.Count > 1 Then
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
            With etiqueta

                .NombreEtiqueta = txtNombreEtiqueta.Text.ToUpper
                If txtIdEtiqueta.Text = "" Then
                    .Estado = EstadoDeEntidad.Agregar
                Else
                    .IdEtiqueta = CInt(txtIdEtiqueta.Text)
                    .Estado = EstadoDeEntidad.Editar
                End If

                MsgBox(etiqueta.GuardarCambios())
                ListarEtiquetas()
                txtNombreEtiqueta.Text = ""
                txtIdEtiqueta.Text = ""
            End With
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub txtFiltroEtiqueta_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroEtiqueta.TextChanged
        dgvEtiqueta.DataSource = etiqueta.FiltrarEtiquetas(txtFiltroEtiqueta.Text)
    End Sub


End Class