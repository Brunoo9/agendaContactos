<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAMContacto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTelefonoFijo = New System.Windows.Forms.TextBox()
        Me.txtTelefonoMovil = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.txtApodo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIdContacto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbProvincia = New System.Windows.Forms.ComboBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.cbPrefijo = New System.Windows.Forms.ComboBox()
        Me.cbEtiqueta = New System.Windows.Forms.ComboBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblContactoId = New System.Windows.Forms.Label()
        Me.lblContacto = New System.Windows.Forms.Label()
        Me.btnProvincia = New System.Windows.Forms.Button()
        Me.rbSi = New System.Windows.Forms.RadioButton()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpFechaNac.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.dtpFechaNac.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNac.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpFechaNac.Location = New System.Drawing.Point(301, 183)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(106, 20)
        Me.dtpFechaNac.TabIndex = 56
        '
        'txtCorreo
        '
        Me.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtCorreo.ForeColor = System.Drawing.Color.White
        Me.txtCorreo.Location = New System.Drawing.Point(430, 421)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(176, 20)
        Me.txtCorreo.TabIndex = 55
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(427, 405)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Correo"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(299, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Fecha Nacimiento"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(164, 307)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Provincia"
        '
        'txtTelefonoFijo
        '
        Me.txtTelefonoFijo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTelefonoFijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtTelefonoFijo.ForeColor = System.Drawing.Color.White
        Me.txtTelefonoFijo.Location = New System.Drawing.Point(299, 421)
        Me.txtTelefonoFijo.Name = "txtTelefonoFijo"
        Me.txtTelefonoFijo.Size = New System.Drawing.Size(113, 20)
        Me.txtTelefonoFijo.TabIndex = 50
        '
        'txtTelefonoMovil
        '
        Me.txtTelefonoMovil.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTelefonoMovil.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtTelefonoMovil.ForeColor = System.Drawing.Color.White
        Me.txtTelefonoMovil.Location = New System.Drawing.Point(166, 421)
        Me.txtTelefonoMovil.Name = "txtTelefonoMovil"
        Me.txtTelefonoMovil.Size = New System.Drawing.Size(112, 20)
        Me.txtTelefonoMovil.TabIndex = 49
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(166, 259)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Direccion"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(296, 405)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Telefono Fijo"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(163, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Prefijo"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(351, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(163, 405)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Telefono Movil"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(299, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Etiqueta"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.ForeColor = System.Drawing.Color.White
        Me.lblEmpresa.Location = New System.Drawing.Point(298, 357)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(143, 13)
        Me.lblEmpresa.TabIndex = 42
        Me.lblEmpresa.Text = "Nombre lugar de trabajo"
        Me.lblEmpresa.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(167, 366)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(164, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Apodo"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(164, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Nombres"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 3
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(430, 472)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 32)
        Me.btnCancelar.TabIndex = 38
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 3
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(262, 472)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(140, 32)
        Me.btnGuardar.TabIndex = 37
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtDireccion.ForeColor = System.Drawing.Color.White
        Me.txtDireccion.Location = New System.Drawing.Point(166, 275)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(220, 20)
        Me.txtDireccion.TabIndex = 34
        '
        'txtNombreEmpresa
        '
        Me.txtNombreEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNombreEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtNombreEmpresa.ForeColor = System.Drawing.Color.White
        Me.txtNombreEmpresa.Location = New System.Drawing.Point(300, 373)
        Me.txtNombreEmpresa.Name = "txtNombreEmpresa"
        Me.txtNombreEmpresa.Size = New System.Drawing.Size(195, 20)
        Me.txtNombreEmpresa.TabIndex = 33
        Me.txtNombreEmpresa.Visible = False
        '
        'txtApodo
        '
        Me.txtApodo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtApodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtApodo.ForeColor = System.Drawing.Color.White
        Me.txtApodo.Location = New System.Drawing.Point(166, 183)
        Me.txtApodo.Name = "txtApodo"
        Me.txtApodo.Size = New System.Drawing.Size(100, 20)
        Me.txtApodo.TabIndex = 32
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(167, 131)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(152, 20)
        Me.txtNombre.TabIndex = 31
        '
        'txtIdContacto
        '
        Me.txtIdContacto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtIdContacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtIdContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdContacto.Enabled = False
        Me.txtIdContacto.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtIdContacto.Location = New System.Drawing.Point(166, 84)
        Me.txtIdContacto.Name = "txtIdContacto"
        Me.txtIdContacto.Size = New System.Drawing.Size(42, 20)
        Me.txtIdContacto.TabIndex = 57
        Me.txtIdContacto.Visible = False
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(330, 308)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "Ciudad"
        '
        'cbProvincia
        '
        Me.cbProvincia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProvincia.ForeColor = System.Drawing.Color.White
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Location = New System.Drawing.Point(166, 325)
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(137, 21)
        Me.cbProvincia.TabIndex = 60
        '
        'txtCiudad
        '
        Me.txtCiudad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCiudad.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCiudad.Enabled = False
        Me.txtCiudad.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtCiudad.Location = New System.Drawing.Point(331, 326)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(140, 20)
        Me.txtCiudad.TabIndex = 63
        '
        'cbPrefijo
        '
        Me.cbPrefijo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbPrefijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cbPrefijo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPrefijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbPrefijo.ForeColor = System.Drawing.Color.White
        Me.cbPrefijo.FormattingEnabled = True
        Me.cbPrefijo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbPrefijo.Location = New System.Drawing.Point(166, 230)
        Me.cbPrefijo.Name = "cbPrefijo"
        Me.cbPrefijo.Size = New System.Drawing.Size(100, 21)
        Me.cbPrefijo.TabIndex = 64
        '
        'cbEtiqueta
        '
        Me.cbEtiqueta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbEtiqueta.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cbEtiqueta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEtiqueta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEtiqueta.ForeColor = System.Drawing.Color.White
        Me.cbEtiqueta.FormattingEnabled = True
        Me.cbEtiqueta.Location = New System.Drawing.Point(302, 230)
        Me.cbEtiqueta.Name = "cbEtiqueta"
        Me.cbEtiqueta.Size = New System.Drawing.Size(100, 21)
        Me.cbEtiqueta.TabIndex = 65
        '
        'txtApellido
        '
        Me.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtApellido.ForeColor = System.Drawing.Color.White
        Me.txtApellido.Location = New System.Drawing.Point(359, 131)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(136, 20)
        Me.txtApellido.TabIndex = 67
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(356, 115)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 69
        Me.Label16.Text = "Apellido"
        '
        'lblContactoId
        '
        Me.lblContactoId.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblContactoId.AutoSize = True
        Me.lblContactoId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactoId.ForeColor = System.Drawing.Color.White
        Me.lblContactoId.Location = New System.Drawing.Point(163, 68)
        Me.lblContactoId.Name = "lblContactoId"
        Me.lblContactoId.Size = New System.Drawing.Size(73, 13)
        Me.lblContactoId.TabIndex = 70
        Me.lblContactoId.Text = "Id Contacto"
        Me.lblContactoId.Visible = False
        '
        'lblContacto
        '
        Me.lblContacto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblContacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContacto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblContacto.Location = New System.Drawing.Point(101, 9)
        Me.lblContacto.MinimumSize = New System.Drawing.Size(260, 40)
        Me.lblContacto.Name = "lblContacto"
        Me.lblContacto.Size = New System.Drawing.Size(505, 40)
        Me.lblContacto.TabIndex = 71
        Me.lblContacto.Text = "Editar Contacto"
        Me.lblContacto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnProvincia
        '
        Me.btnProvincia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnProvincia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnProvincia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProvincia.FlatAppearance.BorderSize = 0
        Me.btnProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProvincia.ForeColor = System.Drawing.Color.White
        Me.btnProvincia.Location = New System.Drawing.Point(477, 323)
        Me.btnProvincia.Name = "btnProvincia"
        Me.btnProvincia.Size = New System.Drawing.Size(27, 23)
        Me.btnProvincia.TabIndex = 72
        Me.btnProvincia.Text = "..."
        Me.btnProvincia.UseVisualStyleBackColor = False
        '
        'rbSi
        '
        Me.rbSi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rbSi.AutoSize = True
        Me.rbSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSi.ForeColor = System.Drawing.Color.White
        Me.rbSi.Location = New System.Drawing.Point(169, 373)
        Me.rbSi.Name = "rbSi"
        Me.rbSi.Size = New System.Drawing.Size(35, 17)
        Me.rbSi.TabIndex = 74
        Me.rbSi.TabStop = True
        Me.rbSi.Text = "Si"
        Me.rbSi.UseVisualStyleBackColor = True
        '
        'rbNo
        '
        Me.rbNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rbNo.AutoSize = True
        Me.rbNo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbNo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.rbNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNo.ForeColor = System.Drawing.Color.White
        Me.rbNo.Location = New System.Drawing.Point(213, 373)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(40, 17)
        Me.rbNo.TabIndex = 75
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(166, 357)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 13)
        Me.Label18.TabIndex = 76
        Me.Label18.Text = "Trabaja?"
        '
        'frmAMContacto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(690, 551)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.rbNo)
        Me.Controls.Add(Me.rbSi)
        Me.Controls.Add(Me.btnProvincia)
        Me.Controls.Add(Me.lblContacto)
        Me.Controls.Add(Me.lblContactoId)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.cbEtiqueta)
        Me.Controls.Add(Me.cbPrefijo)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.cbProvincia)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtIdContacto)
        Me.Controls.Add(Me.dtpFechaNac)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTelefonoFijo)
        Me.Controls.Add(Me.txtTelefonoMovil)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombreEmpresa)
        Me.Controls.Add(Me.txtApodo)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "frmAMContacto"
        Me.Text = "frmAMContacto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTelefonoFijo As TextBox
    Friend WithEvents txtTelefonoMovil As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblEmpresa As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombreEmpresa As TextBox
    Friend WithEvents txtApodo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtIdContacto As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cbProvincia As ComboBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents cbPrefijo As ComboBox
    Friend WithEvents cbEtiqueta As ComboBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lblContactoId As Label
    Friend WithEvents lblContacto As Label
    Friend WithEvents btnProvincia As Button
    Friend WithEvents rbSi As RadioButton
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents Label18 As Label
End Class
