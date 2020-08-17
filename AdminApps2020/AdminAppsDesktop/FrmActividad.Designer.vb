<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActividad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActividad))
        Me.btnNuevoActividadDetalle = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblRegistroActividadDetalle = New System.Windows.Forms.ToolStripLabel()
        Me.dgvActividadDetalle = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnInsertar = New System.Windows.Forms.ToolStripButton()
        Me.btnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.btnExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblRegistro = New System.Windows.Forms.ToolStripLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.btnActualizarActividadDetalle = New System.Windows.Forms.ToolStripButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboBuscar = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.dgvActividad = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboAplicacion = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cboUsurio = New System.Windows.Forms.ComboBox()
        CType(Me.dgvActividadDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgvActividad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNuevoActividadDetalle
        '
        Me.btnNuevoActividadDetalle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnNuevoActividadDetalle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevoActividadDetalle.Name = "btnNuevoActividadDetalle"
        Me.btnNuevoActividadDetalle.Size = New System.Drawing.Size(46, 22)
        Me.btnNuevoActividadDetalle.Text = "Nuevo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(322, 13)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(51, 13)
        Me.lblFechaFin.TabIndex = 63
        Me.lblFechaFin.Text = "Fecha fin"
        Me.lblFechaFin.Visible = False
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(325, 28)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(131, 20)
        Me.dtpFechaFin.TabIndex = 61
        Me.dtpFechaFin.Visible = False
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(188, 28)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(131, 20)
        Me.dtpFechaInicio.TabIndex = 60
        Me.dtpFechaInicio.Visible = False
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(185, 12)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(64, 13)
        Me.lblFechaInicio.TabIndex = 62
        Me.lblFechaInicio.Text = "Fecha inicio"
        Me.lblFechaInicio.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(185, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Valor:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Buscar por:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(188, 28)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(351, 20)
        Me.txtBuscar.TabIndex = 43
        '
        'lblRegistroActividadDetalle
        '
        Me.lblRegistroActividadDetalle.Name = "lblRegistroActividadDetalle"
        Me.lblRegistroActividadDetalle.Size = New System.Drawing.Size(53, 22)
        Me.lblRegistroActividadDetalle.Text = "Registro:"
        '
        'dgvActividadDetalle
        '
        Me.dgvActividadDetalle.AllowUserToAddRows = False
        Me.dgvActividadDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividadDetalle.Location = New System.Drawing.Point(6, 6)
        Me.dgvActividadDetalle.Name = "dgvActividadDetalle"
        Me.dgvActividadDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActividadDetalle.Size = New System.Drawing.Size(1238, 315)
        Me.dgvActividadDetalle.TabIndex = 42
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnInsertar, Me.btnActualizar, Me.ToolStripSeparator1, Me.btnExcel, Me.lblRegistro})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 577)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1309, 25)
        Me.ToolStrip1.TabIndex = 72
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(46, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnInsertar
        '
        Me.btnInsertar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnInsertar.Enabled = False
        Me.btnInsertar.Image = CType(resources.GetObject("btnInsertar.Image"), System.Drawing.Image)
        Me.btnInsertar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(50, 22)
        Me.btnInsertar.Text = "Insertar"
        '
        'btnActualizar
        '
        Me.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(63, 22)
        Me.btnActualizar.Text = "Actualizar"
        '
        'btnExcel
        '
        Me.btnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1170, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "ESTADO"
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"CERRADA", "ABIERTA", "EJECUCION"})
        Me.cboEstado.Location = New System.Drawing.Point(1173, 159)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(120, 21)
        Me.cboEstado.TabIndex = 71
        '
        'btnActualizarActividadDetalle
        '
        Me.btnActualizarActividadDetalle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnActualizarActividadDetalle.Image = CType(resources.GetObject("btnActualizarActividadDetalle.Image"), System.Drawing.Image)
        Me.btnActualizarActividadDetalle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizarActividadDetalle.Name = "btnActualizarActividadDetalle"
        Me.btnActualizarActividadDetalle.Size = New System.Drawing.Size(63, 22)
        Me.btnActualizarActividadDetalle.Text = "Actualizar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(922, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "USUARIO"
        '
        'cboBuscar
        '
        Me.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {"FECHA", "TIPO ACTIVIDAD", "NOMBRE PROYECTO/REQUERIMIENTO", "APLICACION", "USUARIO", "DESCRIPCION"})
        Me.cboBuscar.Location = New System.Drawing.Point(9, 28)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(173, 21)
        Me.cboBuscar.TabIndex = 42
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ToolStrip2)
        Me.TabPage2.Controls.Add(Me.dgvActividadDetalle)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1274, 352)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DETALLE ACTIVIDAD"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoActividadDetalle, Me.btnActualizarActividadDetalle, Me.ToolStripSeparator2, Me.lblRegistroActividadDetalle})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 324)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1268, 25)
        Me.ToolStrip2.TabIndex = 57
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'dgvActividad
        '
        Me.dgvActividad.AllowUserToAddRows = False
        Me.dgvActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividad.Location = New System.Drawing.Point(9, 55)
        Me.dgvActividad.Name = "dgvActividad"
        Me.dgvActividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActividad.Size = New System.Drawing.Size(1259, 287)
        Me.dgvActividad.TabIndex = 41
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblFechaFin)
        Me.TabPage1.Controls.Add(Me.dtpFechaFin)
        Me.TabPage1.Controls.Add(Me.dtpFechaInicio)
        Me.TabPage1.Controls.Add(Me.lblFechaInicio)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtBuscar)
        Me.TabPage1.Controls.Add(Me.cboBuscar)
        Me.TabPage1.Controls.Add(Me.dgvActividad)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1274, 352)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ACTIVIDAD"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(15, 186)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1282, 378)
        Me.TabControl1.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(889, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "APLICACION"
        '
        'cboAplicacion
        '
        Me.cboAplicacion.FormattingEnabled = True
        Me.cboAplicacion.Location = New System.Drawing.Point(889, 25)
        Me.cboAplicacion.Name = "cboAplicacion"
        Me.cboAplicacion.Size = New System.Drawing.Size(404, 21)
        Me.cboAplicacion.TabIndex = 68
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(15, 74)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(1278, 56)
        Me.txtDescripcion.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "DESCRIPCION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(409, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "NOMBRE PROYECTO/REQUERIMIENTO"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(409, 26)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(474, 20)
        Me.txtNombre.TabIndex = 64
        '
        'cboTipo
        '
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"PROYECTO", "REQUERIMIENTO", "SOPORTE", "SOLICITUDES DE INFRAESTRUCTURA", "ACTIVIDADES DE GDH", "COMITE DE CAMBIOS", "ETHICAL HAKING", "AUDITORIA/REVISORIA", "TEMAS ADMINISTRATIVOS"})
        Me.cboTipo.Location = New System.Drawing.Point(141, 25)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(262, 21)
        Me.cboTipo.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "TIPO DE ACTIVIDAD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "FECHA"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(15, 26)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(120, 20)
        Me.dtpFecha.TabIndex = 60
        '
        'cboUsurio
        '
        Me.cboUsurio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboUsurio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboUsurio.FormattingEnabled = True
        Me.cboUsurio.Location = New System.Drawing.Point(925, 159)
        Me.cboUsurio.Name = "cboUsurio"
        Me.cboUsurio.Size = New System.Drawing.Size(242, 21)
        Me.cboUsurio.TabIndex = 76
        '
        'FrmActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1309, 602)
        Me.Controls.Add(Me.cboUsurio)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboAplicacion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Name = "FrmActividad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTIVIDAD"
        CType(Me.dgvActividadDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgvActividad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNuevoActividadDetalle As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblRegistroActividadDetalle As ToolStripLabel
    Friend WithEvents dgvActividadDetalle As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents btnInsertar As ToolStripButton
    Friend WithEvents btnActualizar As ToolStripButton
    Friend WithEvents btnExcel As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblRegistro As ToolStripLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents btnActualizarActividadDetalle As ToolStripButton
    Friend WithEvents Label7 As Label
    Friend WithEvents cboBuscar As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents dgvActividad As DataGridView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Label5 As Label
    Friend WithEvents cboAplicacion As ComboBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cboUsurio As ComboBox
End Class
