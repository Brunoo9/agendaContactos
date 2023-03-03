<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrefijo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvPrefijos = New System.Windows.Forms.DataGridView()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFiltroPrefijo = New System.Windows.Forms.TextBox()
        Me.panelPrefijo = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombrePrefijo = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdPrefijo = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblPrefijo = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.IdPrefijo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombrePrefijo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvPrefijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPrefijo.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPrefijos
        '
        Me.dgvPrefijos.AllowUserToResizeColumns = False
        Me.dgvPrefijos.AllowUserToResizeRows = False
        Me.dgvPrefijos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvPrefijos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPrefijos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrefijos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPrefijos.ColumnHeadersHeight = 25
        Me.dgvPrefijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPrefijos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPrefijo, Me.nombrePrefijo, Me.estado})
        Me.dgvPrefijos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPrefijos.EnableHeadersVisualStyles = False
        Me.dgvPrefijos.GridColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.dgvPrefijos.Location = New System.Drawing.Point(134, 126)
        Me.dgvPrefijos.MultiSelect = False
        Me.dgvPrefijos.Name = "dgvPrefijos"
        Me.dgvPrefijos.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(122, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPrefijos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPrefijos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrefijos.Size = New System.Drawing.Size(252, 150)
        Me.dgvPrefijos.TabIndex = 0
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnEditar.FlatAppearance.BorderSize = 3
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(134, 292)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(70, 47)
        Me.btnEditar.TabIndex = 3
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderSize = 3
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(316, 292)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(70, 47)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(98, 24)
        Me.Label4.MinimumSize = New System.Drawing.Size(260, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(302, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Lista Prefijos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(131, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Buscar Prefijo"
        '
        'txtFiltroPrefijo
        '
        Me.txtFiltroPrefijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtFiltroPrefijo.ForeColor = System.Drawing.Color.White
        Me.txtFiltroPrefijo.Location = New System.Drawing.Point(134, 101)
        Me.txtFiltroPrefijo.Name = "txtFiltroPrefijo"
        Me.txtFiltroPrefijo.Size = New System.Drawing.Size(152, 20)
        Me.txtFiltroPrefijo.TabIndex = 8
        '
        'panelPrefijo
        '
        Me.panelPrefijo.Controls.Add(Me.Label5)
        Me.panelPrefijo.Controls.Add(Me.Label3)
        Me.panelPrefijo.Controls.Add(Me.txtNombrePrefijo)
        Me.panelPrefijo.Controls.Add(Me.btnCancelar)
        Me.panelPrefijo.Controls.Add(Me.txtIdPrefijo)
        Me.panelPrefijo.Controls.Add(Me.btnAceptar)
        Me.panelPrefijo.Location = New System.Drawing.Point(560, 101)
        Me.panelPrefijo.Name = "panelPrefijo"
        Me.panelPrefijo.Size = New System.Drawing.Size(209, 223)
        Me.panelPrefijo.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(17, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Id Prefijo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Nombre Prefijo"
        '
        'txtNombrePrefijo
        '
        Me.txtNombrePrefijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtNombrePrefijo.ForeColor = System.Drawing.Color.White
        Me.txtNombrePrefijo.Location = New System.Drawing.Point(20, 87)
        Me.txtNombrePrefijo.Name = "txtNombrePrefijo"
        Me.txtNombrePrefijo.Size = New System.Drawing.Size(116, 20)
        Me.txtNombrePrefijo.TabIndex = 20
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 3
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(115, 141)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 36)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'txtIdPrefijo
        '
        Me.txtIdPrefijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtIdPrefijo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdPrefijo.Enabled = False
        Me.txtIdPrefijo.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtIdPrefijo.Location = New System.Drawing.Point(20, 28)
        Me.txtIdPrefijo.Name = "txtIdPrefijo"
        Me.txtIdPrefijo.Size = New System.Drawing.Size(41, 20)
        Me.txtIdPrefijo.TabIndex = 19
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 3
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(20, 141)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(76, 36)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'lblPrefijo
        '
        Me.lblPrefijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblPrefijo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrefijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrefijo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPrefijo.Location = New System.Drawing.Point(512, 24)
        Me.lblPrefijo.MinimumSize = New System.Drawing.Size(260, 20)
        Me.lblPrefijo.Name = "lblPrefijo"
        Me.lblPrefijo.Size = New System.Drawing.Size(299, 29)
        Me.lblPrefijo.TabIndex = 23
        Me.lblPrefijo.Text = "Editar Prefijo"
        Me.lblPrefijo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPrefijo.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnNuevo.FlatAppearance.BorderSize = 3
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(225, 292)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(70, 47)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'IdPrefijo
        '
        Me.IdPrefijo.DataPropertyName = "IdPrefijo"
        Me.IdPrefijo.HeaderText = "Id Prefijo"
        Me.IdPrefijo.Name = "IdPrefijo"
        '
        'nombrePrefijo
        '
        Me.nombrePrefijo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombrePrefijo.DataPropertyName = "NombrePrefijo"
        Me.nombrePrefijo.HeaderText = "Nombre Prefijo"
        Me.nombrePrefijo.Name = "nombrePrefijo"
        Me.nombrePrefijo.Width = 150
        '
        'estado
        '
        Me.estado.DataPropertyName = "Estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.Visible = False
        '
        'frmPrefijo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(841, 423)
        Me.Controls.Add(Me.panelPrefijo)
        Me.Controls.Add(Me.lblPrefijo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFiltroPrefijo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvPrefijos)
        Me.Name = "frmPrefijo"
        Me.Text = "frmPrefijo"
        CType(Me.dgvPrefijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPrefijo.ResumeLayout(False)
        Me.panelPrefijo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPrefijos As DataGridView
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFiltroPrefijo As TextBox
    Friend WithEvents panelPrefijo As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombrePrefijo As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdPrefijo As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblPrefijo As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents IdPrefijo As DataGridViewTextBoxColumn
    Friend WithEvents nombrePrefijo As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
End Class
