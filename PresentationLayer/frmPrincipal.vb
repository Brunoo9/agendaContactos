Public Class frmPrincipal
    Private Sub ListaContactos_Click(sender As Object, e As EventArgs) Handles ListaContactos.Click
        For Each frm As Form In Me.MdiChildren
            If frm.Text = "ListaContactos" Then
                If frm.WindowState = FormWindowState.Minimized Then
                    frm.WindowState = FormWindowState.Maximized
                End If
                frm.Focus()
                Exit Sub
            End If
        Next
        Dim listaContactos As New frmContacto
        With listaContactos
            .MdiParent = Me
            .Text = "ListaContactos"
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ABMContactos_Click(sender As Object, e As EventArgs) Handles ABMContactos.Click
        For Each frm As Form In Me.MdiChildren
            If frm.Text = "ABMContactos" Then
                If frm.WindowState = FormWindowState.Minimized Then
                    frm.WindowState = FormWindowState.Maximized
                End If
                frm.Focus()
                Exit Sub
            End If
        Next
        Dim abmContactos As New frmAMContacto
        With abmContactos
            .MdiParent = Me
            .Text = "ABMContactos"
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ListaPrefijos_Click(sender As Object, e As EventArgs) Handles ListaPrefijos.Click
        For Each frm As Form In Me.MdiChildren
            If frm.Text = "ListaPrefijos" Then
                If frm.WindowState = FormWindowState.Minimized Then
                    frm.WindowState = FormWindowState.Maximized
                End If
                frm.Focus()
                Exit Sub
            End If
        Next
        Dim ListaPrefijos As New frmPrefijo
        With ListaPrefijos
            .MdiParent = Me
            .Text = "ListaPrefijos"
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ListaEtiquetas_Click(sender As Object, e As EventArgs) Handles ListaEtiquetas.Click
        For Each frm As Form In Me.MdiChildren
            If frm.Text = "ListaEtiquetas" Then
                If frm.WindowState = FormWindowState.Minimized Then
                    frm.WindowState = FormWindowState.Maximized
                End If
                frm.Focus()
                Exit Sub
            End If
        Next
        Dim ListaEtiquetas As New frmEtiqueta
        With ListaEtiquetas
            .MdiParent = Me
            .Text = "ListaEtiquetas"
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ListaProvincias_Click(sender As Object, e As EventArgs) Handles ListaProvincias.Click
        For Each frm As Form In Me.MdiChildren
            If frm.Text = "ListaProvincias" Then
                If frm.WindowState = FormWindowState.Minimized Then
                    frm.WindowState = FormWindowState.Maximized
                End If
                frm.Focus()
                Exit Sub
            End If
        Next
        Dim ListaProvincias As New frmProvincia
        With ListaProvincias
            .MdiParent = Me
            .Text = "ListaProvincias"
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ListaCiudades_Click(sender As Object, e As EventArgs) Handles ListaCiudades.Click
        For Each frm As Form In Me.MdiChildren
            If frm.Text = "ListaCiudades" Then
                If frm.WindowState = FormWindowState.Minimized Then
                    frm.WindowState = FormWindowState.Maximized
                End If
                frm.Focus()
                Exit Sub
            End If
        Next
        Dim ListaCiudades As New frmLocalidades
        With ListaCiudades
            .MdiParent = Me
            .Text = "ListaCiudades"
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

End Class
