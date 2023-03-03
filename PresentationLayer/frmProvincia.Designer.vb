<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProvincia
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvProvincia = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFiltroProvincia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnProvincia = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.idprovincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreProvincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProvincia
        '
        Me.dgvProvincia.AllowUserToResizeColumns = False
        Me.dgvProvincia.AllowUserToResizeRows = False
        Me.dgvProvincia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProvincia.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgvProvincia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProvincia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(87, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProvincia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProvincia.ColumnHeadersHeight = 26
        Me.dgvProvincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProvincia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idprovincia, Me.nombreProvincia, Me.estado})
        Me.dgvProvincia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvProvincia.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProvincia.EnableHeadersVisualStyles = False
        Me.dgvProvincia.GridColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.dgvProvincia.Location = New System.Drawing.Point(268, 140)
        Me.dgvProvincia.MultiSelect = False
        Me.dgvProvincia.Name = "dgvProvincia"
        Me.dgvProvincia.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(122, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProvincia.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProvincia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProvincia.Size = New System.Drawing.Size(267, 150)
        Me.dgvProvincia.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(265, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar Provincia:"
        '
        'txtFiltroProvincia
        '
        Me.txtFiltroProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.txtFiltroProvincia.ForeColor = System.Drawing.Color.White
        Me.txtFiltroProvincia.Location = New System.Drawing.Point(268, 108)
        Me.txtFiltroProvincia.Name = "txtFiltroProvincia"
        Me.txtFiltroProvincia.Size = New System.Drawing.Size(152, 20)
        Me.txtFiltroProvincia.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(182, 21)
        Me.Label3.MinimumSize = New System.Drawing.Size(241, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(454, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Lista Provincias"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnEditar.Location = New System.Drawing.Point(227, 315)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(71, 44)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnProvincia
        '
        Me.btnProvincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnProvincia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProvincia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnProvincia.FlatAppearance.BorderSize = 3
        Me.btnProvincia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProvincia.ForeColor = System.Drawing.Color.White
        Me.btnProvincia.Location = New System.Drawing.Point(321, 315)
        Me.btnProvincia.Name = "btnProvincia"
        Me.btnProvincia.Size = New System.Drawing.Size(76, 44)
        Me.btnProvincia.TabIndex = 9
        Me.btnProvincia.Text = "Nueva Provincia"
        Me.btnProvincia.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 3
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(506, 315)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(77, 44)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Actualizar"
        Me.btnCancelar.UseVisualStyleBackColor = False
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
        Me.btnEliminar.Location = New System.Drawing.Point(415, 315)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 44)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'idprovincia
        '
        Me.idprovincia.DataPropertyName = "IdProvincia"
        Me.idprovincia.HeaderText = "Id Provincia"
        Me.idprovincia.Name = "idprovincia"
        '
        'nombreProvincia
        '
        Me.nombreProvincia.DataPropertyName = "NombreProvincia"
        Me.nombreProvincia.HeaderText = "Provincia"
        Me.nombreProvincia.Name = "nombreProvincia"
        '
        'estado
        '
        Me.estado.DataPropertyName = "Estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.Visible = False
        '
        'frmProvincia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(801, 490)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtFiltroProvincia)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.dgvProvincia)
        Me.Controls.Add(Me.btnProvincia)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.Label3)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frmProvincia"
        Me.Text = "frmProvincia"
        CType(Me.dgvProvincia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProvincia As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFiltroProvincia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnProvincia As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents idprovincia As DataGridViewTextBoxColumn
    Friend WithEvents nombreProvincia As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
End Class
