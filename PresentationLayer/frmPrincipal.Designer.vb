<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContactosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaContactos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMContactos = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrefijosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaPrefijos = New System.Windows.Forms.ToolStripMenuItem()
        Me.EtiquetasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaEtiquetas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvinciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaProvincias = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiudadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaCiudades = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactosToolStripMenuItem, Me.PrefijosToolStripMenuItem, Me.EtiquetasToolStripMenuItem, Me.ProvinciaToolStripMenuItem, Me.CiudadesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(820, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContactosToolStripMenuItem
        '
        Me.ContactosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaContactos, Me.ABMContactos})
        Me.ContactosToolStripMenuItem.Name = "ContactosToolStripMenuItem"
        Me.ContactosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ContactosToolStripMenuItem.Text = "Contactos"
        '
        'ListaContactos
        '
        Me.ListaContactos.Name = "ListaContactos"
        Me.ListaContactos.Size = New System.Drawing.Size(157, 22)
        Me.ListaContactos.Text = "Lista Contactos"
        '
        'ABMContactos
        '
        Me.ABMContactos.Name = "ABMContactos"
        Me.ABMContactos.Size = New System.Drawing.Size(157, 22)
        Me.ABMContactos.Text = "ABM Contactos"
        '
        'PrefijosToolStripMenuItem
        '
        Me.PrefijosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaPrefijos})
        Me.PrefijosToolStripMenuItem.Name = "PrefijosToolStripMenuItem"
        Me.PrefijosToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.PrefijosToolStripMenuItem.Text = "Prefijos"
        '
        'ListaPrefijos
        '
        Me.ListaPrefijos.Name = "ListaPrefijos"
        Me.ListaPrefijos.Size = New System.Drawing.Size(140, 22)
        Me.ListaPrefijos.Text = "Lista Prefijos"
        '
        'EtiquetasToolStripMenuItem
        '
        Me.EtiquetasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaEtiquetas})
        Me.EtiquetasToolStripMenuItem.Name = "EtiquetasToolStripMenuItem"
        Me.EtiquetasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.EtiquetasToolStripMenuItem.Text = "Etiquetas"
        '
        'ListaEtiquetas
        '
        Me.ListaEtiquetas.Name = "ListaEtiquetas"
        Me.ListaEtiquetas.Size = New System.Drawing.Size(149, 22)
        Me.ListaEtiquetas.Text = "Lista Etiquetas"
        '
        'ProvinciaToolStripMenuItem
        '
        Me.ProvinciaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaProvincias})
        Me.ProvinciaToolStripMenuItem.Name = "ProvinciaToolStripMenuItem"
        Me.ProvinciaToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProvinciaToolStripMenuItem.Text = "Provincias"
        '
        'ListaProvincias
        '
        Me.ListaProvincias.Name = "ListaProvincias"
        Me.ListaProvincias.Size = New System.Drawing.Size(155, 22)
        Me.ListaProvincias.Text = "Lista Provincias"
        '
        'CiudadesToolStripMenuItem
        '
        Me.CiudadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaCiudades})
        Me.CiudadesToolStripMenuItem.Name = "CiudadesToolStripMenuItem"
        Me.CiudadesToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.CiudadesToolStripMenuItem.Text = "Ciudades"
        '
        'ListaCiudades
        '
        Me.ListaCiudades.Name = "ListaCiudades"
        Me.ListaCiudades.Size = New System.Drawing.Size(150, 22)
        Me.ListaCiudades.Text = "Lista Ciudades"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(820, 575)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "AGENDA CONTACTOS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContactosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaContactos As ToolStripMenuItem
    Friend WithEvents ABMContactos As ToolStripMenuItem
    Friend WithEvents PrefijosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EtiquetasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProvinciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CiudadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaPrefijos As ToolStripMenuItem
    Friend WithEvents ListaEtiquetas As ToolStripMenuItem
    Friend WithEvents ListaProvincias As ToolStripMenuItem
    Friend WithEvents ListaCiudades As ToolStripMenuItem
End Class
