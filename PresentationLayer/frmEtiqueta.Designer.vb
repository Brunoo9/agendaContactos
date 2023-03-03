<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtiqueta
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFiltroEtiqueta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dgvEtiqueta = New System.Windows.Forms.DataGridView()
        Me.idEtiqueta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreEtiqueta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtIdEtiqueta = New System.Windows.Forms.TextBox()
        Me.txtNombreEtiqueta = New System.Windows.Forms.TextBox()
        Me.lblEtiqueta = New System.Windows.Forms.Label()
        Me.panelEtiqueta = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvEtiqueta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEtiqueta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(64, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Buscar Etiqueta"
        '
        'txtFiltroEtiqueta
        '
        Me.txtFiltroEtiqueta.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtFiltroEtiqueta.ForeColor = System.Drawing.Color.White
        Me.txtFiltroEtiqueta.Location = New System.Drawing.Point(67, 82)
        Me.txtFiltroEtiqueta.Name = "txtFiltroEtiqueta"
        Me.txtFiltroEtiqueta.Size = New System.Drawing.Size(152, 20)
        Me.txtFiltroEtiqueta.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(43, 18)
        Me.Label4.MinimumSize = New System.Drawing.Size(260, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(302, 29)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Lista Etiquetas"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnEliminar.Location = New System.Drawing.Point(249, 264)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(78, 47)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(110, 130)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 35)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
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
        Me.btnEditar.Location = New System.Drawing.Point(67, 264)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(78, 47)
        Me.btnEditar.TabIndex = 13
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
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
        Me.btnNuevo.Location = New System.Drawing.Point(161, 264)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(78, 47)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
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
        Me.btnAceptar.Location = New System.Drawing.Point(29, 130)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(73, 35)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'dgvEtiqueta
        '
        Me.dgvEtiqueta.AllowUserToResizeColumns = False
        Me.dgvEtiqueta.AllowUserToResizeRows = False
        Me.dgvEtiqueta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEtiqueta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEtiqueta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEtiqueta.ColumnHeadersHeight = 25
        Me.dgvEtiqueta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEtiqueta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEtiqueta, Me.nombreEtiqueta})
        Me.dgvEtiqueta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvEtiqueta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvEtiqueta.EnableHeadersVisualStyles = False
        Me.dgvEtiqueta.GridColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.dgvEtiqueta.Location = New System.Drawing.Point(67, 108)
        Me.dgvEtiqueta.MultiSelect = False
        Me.dgvEtiqueta.Name = "dgvEtiqueta"
        Me.dgvEtiqueta.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(122, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgvEtiqueta.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEtiqueta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEtiqueta.Size = New System.Drawing.Size(268, 150)
        Me.dgvEtiqueta.TabIndex = 10
        '
        'idEtiqueta
        '
        Me.idEtiqueta.DataPropertyName = "IdEtiqueta"
        Me.idEtiqueta.HeaderText = "Id Etiqueta"
        Me.idEtiqueta.Name = "idEtiqueta"
        '
        'nombreEtiqueta
        '
        Me.nombreEtiqueta.DataPropertyName = "NombreEtiqueta"
        Me.nombreEtiqueta.HeaderText = "Nombre Etiqueta"
        Me.nombreEtiqueta.Name = "nombreEtiqueta"
        Me.nombreEtiqueta.Width = 160
        '
        'txtIdEtiqueta
        '
        Me.txtIdEtiqueta.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtIdEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdEtiqueta.Enabled = False
        Me.txtIdEtiqueta.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtIdEtiqueta.Location = New System.Drawing.Point(20, 40)
        Me.txtIdEtiqueta.Name = "txtIdEtiqueta"
        Me.txtIdEtiqueta.Size = New System.Drawing.Size(41, 20)
        Me.txtIdEtiqueta.TabIndex = 19
        '
        'txtNombreEtiqueta
        '
        Me.txtNombreEtiqueta.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtNombreEtiqueta.ForeColor = System.Drawing.Color.White
        Me.txtNombreEtiqueta.Location = New System.Drawing.Point(20, 89)
        Me.txtNombreEtiqueta.Name = "txtNombreEtiqueta"
        Me.txtNombreEtiqueta.Size = New System.Drawing.Size(147, 20)
        Me.txtNombreEtiqueta.TabIndex = 20
        '
        'lblEtiqueta
        '
        Me.lblEtiqueta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblEtiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtiqueta.ForeColor = System.Drawing.Color.White
        Me.lblEtiqueta.Location = New System.Drawing.Point(441, 18)
        Me.lblEtiqueta.MinimumSize = New System.Drawing.Size(260, 20)
        Me.lblEtiqueta.Name = "lblEtiqueta"
        Me.lblEtiqueta.Size = New System.Drawing.Size(289, 29)
        Me.lblEtiqueta.TabIndex = 21
        Me.lblEtiqueta.Text = "Editar Etiquetas"
        Me.lblEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEtiqueta.Visible = False
        '
        'panelEtiqueta
        '
        Me.panelEtiqueta.Controls.Add(Me.Label5)
        Me.panelEtiqueta.Controls.Add(Me.Label3)
        Me.panelEtiqueta.Controls.Add(Me.txtNombreEtiqueta)
        Me.panelEtiqueta.Controls.Add(Me.btnCancelar)
        Me.panelEtiqueta.Controls.Add(Me.txtIdEtiqueta)
        Me.panelEtiqueta.Controls.Add(Me.btnAceptar)
        Me.panelEtiqueta.Location = New System.Drawing.Point(473, 82)
        Me.panelEtiqueta.Name = "panelEtiqueta"
        Me.panelEtiqueta.Size = New System.Drawing.Size(209, 203)
        Me.panelEtiqueta.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(17, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Id Etiqueta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Nombre Etiqueta"
        '
        'frmEtiqueta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(793, 346)
        Me.Controls.Add(Me.panelEtiqueta)
        Me.Controls.Add(Me.lblEtiqueta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFiltroEtiqueta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvEtiqueta)
        Me.Name = "frmEtiqueta"
        Me.Text = "frmEtiqueta"
        CType(Me.dgvEtiqueta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEtiqueta.ResumeLayout(False)
        Me.panelEtiqueta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtFiltroEtiqueta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents dgvEtiqueta As DataGridView
    Friend WithEvents txtIdEtiqueta As TextBox
    Friend WithEvents txtNombreEtiqueta As TextBox
    Friend WithEvents lblEtiqueta As Label
    Friend WithEvents panelEtiqueta As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents idEtiqueta As DataGridViewTextBoxColumn
    Friend WithEvents nombreEtiqueta As DataGridViewTextBoxColumn
End Class
