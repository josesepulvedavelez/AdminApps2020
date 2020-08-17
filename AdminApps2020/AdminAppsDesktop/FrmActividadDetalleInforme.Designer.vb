<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActividadDetalleInforme
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
        Me.dgvActividad = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblRegistro = New System.Windows.Forms.ToolStripLabel()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cboBuscar = New System.Windows.Forms.ComboBox()
        CType(Me.dgvActividad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvActividad
        '
        Me.dgvActividad.AllowUserToAddRows = False
        Me.dgvActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividad.Location = New System.Drawing.Point(15, 62)
        Me.dgvActividad.Name = "dgvActividad"
        Me.dgvActividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActividad.Size = New System.Drawing.Size(1114, 391)
        Me.dgvActividad.TabIndex = 72
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExcel, Me.ToolStripSeparator1, Me.lblRegistro})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 465)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1145, 25)
        Me.ToolStrip1.TabIndex = 73
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnExcel
        '
        Me.btnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(38, 22)
        Me.btnExcel.Text = "Excel"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'lblRegistro
        '
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(53, 22)
        Me.lblRegistro.Text = "Registro:"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(328, 21)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(51, 13)
        Me.lblFechaFin.TabIndex = 81
        Me.lblFechaFin.Text = "Fecha fin"
        Me.lblFechaFin.Visible = False
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(331, 36)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(131, 20)
        Me.dtpFechaFin.TabIndex = 79
        Me.dtpFechaFin.Visible = False
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(194, 36)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(131, 20)
        Me.dtpFechaInicio.TabIndex = 78
        Me.dtpFechaInicio.Visible = False
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(191, 20)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(64, 13)
        Me.lblFechaInicio.TabIndex = 80
        Me.lblFechaInicio.Text = "Fecha inicio"
        Me.lblFechaInicio.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(191, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Valor:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Buscar por:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(194, 36)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(351, 20)
        Me.txtBuscar.TabIndex = 75
        '
        'cboBuscar
        '
        Me.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {"FECHA", "TIPO ACTIVIDAD", "NOMBRE PROYECTO/REQUERIMIENTO", "APLICACION", "USUARIO", "DESCRIPCION"})
        Me.cboBuscar.Location = New System.Drawing.Point(15, 36)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(173, 21)
        Me.cboBuscar.TabIndex = 74
        '
        'FrmActividadDetalleInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 490)
        Me.Controls.Add(Me.dgvActividad)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.cboBuscar)
        Me.Name = "FrmActividadDetalleInforme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTIVIDAD INFORME"
        CType(Me.dgvActividad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvActividad As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnExcel As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblRegistro As ToolStripLabel
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cboBuscar As ComboBox
End Class
