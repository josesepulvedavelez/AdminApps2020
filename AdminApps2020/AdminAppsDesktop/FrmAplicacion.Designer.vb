<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAplicacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAplicacion))
        Me.txtAmbiente = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.btnExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblRegistro = New System.Windows.Forms.ToolStripLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cboBuscar = New System.Windows.Forms.ComboBox()
        Me.dgvBuscar = New System.Windows.Forms.DataGridView()
        Me.btnInsertar = New System.Windows.Forms.ToolStripButton()
        Me.txtIp = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboServidor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.txtAdministrador = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAmbiente
        '
        Me.txtAmbiente.Enabled = False
        Me.txtAmbiente.Location = New System.Drawing.Point(458, 27)
        Me.txtAmbiente.Name = "txtAmbiente"
        Me.txtAmbiente.Size = New System.Drawing.Size(125, 20)
        Me.txtAmbiente.TabIndex = 81
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(15, 248)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1146, 302)
        Me.TabControl1.TabIndex = 78
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1138, 276)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "APLICACION"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(6, 6)
        Me.dgv.Name = "dgv"
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1126, 263)
        Me.dgv.TabIndex = 20
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtBuscar)
        Me.TabPage2.Controls.Add(Me.cboBuscar)
        Me.TabPage2.Controls.Add(Me.dgvBuscar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1138, 276)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BUSCAR APLICACION"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(185, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Valor:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Buscar por:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(188, 29)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(351, 20)
        Me.txtBuscar.TabIndex = 38
        '
        'cboBuscar
        '
        Me.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {"PROVEEDOR", "SERVIDOR", "IP", "APLICACION", "ADMINISTRADOR", "DESCRIPCION", "OBSERVACIONES"})
        Me.cboBuscar.Location = New System.Drawing.Point(9, 28)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(173, 21)
        Me.cboBuscar.TabIndex = 37
        '
        'dgvBuscar
        '
        Me.dgvBuscar.AllowUserToAddRows = False
        Me.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscar.Location = New System.Drawing.Point(6, 55)
        Me.dgvBuscar.Name = "dgvBuscar"
        Me.dgvBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBuscar.Size = New System.Drawing.Size(1126, 215)
        Me.dgvBuscar.TabIndex = 36
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
        'txtIp
        '
        Me.txtIp.Enabled = False
        Me.txtIp.Location = New System.Drawing.Point(330, 27)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(125, 20)
        Me.txtIp.TabIndex = 80
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(327, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 13)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "IP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(455, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "AMBIENTE"
        '
        'btnNuevo
        '
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(46, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnInsertar, Me.btnActualizar, Me.btnExcel, Me.ToolStripSeparator1, Me.lblRegistro})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 565)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1175, 25)
        Me.ToolStrip1.TabIndex = 77
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cboProveedor
        '
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(15, 27)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(178, 21)
        Me.cboProveedor.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "SERVIDOR"
        '
        'cboServidor
        '
        Me.cboServidor.FormattingEnabled = True
        Me.cboServidor.Location = New System.Drawing.Point(199, 27)
        Me.cboServidor.Name = "cboServidor"
        Me.cboServidor.Size = New System.Drawing.Size(125, 21)
        Me.cboServidor.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "PROVEEDOR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(819, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "TIPO"
        '
        'cboTipo
        '
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"CONSOLA", "ESCRITORIO", "WEB", "MOVIL", "SERVICIO WINDOWS", "ETL", "BASE DE DATOS", "OTRO"})
        Me.cboTipo.Location = New System.Drawing.Point(822, 26)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(147, 21)
        Me.cboTipo.TabIndex = 71
        '
        'txtAdministrador
        '
        Me.txtAdministrador.Location = New System.Drawing.Point(975, 26)
        Me.txtAdministrador.MaxLength = 255
        Me.txtAdministrador.Name = "txtAdministrador"
        Me.txtAdministrador.Size = New System.Drawing.Size(186, 20)
        Me.txtAdministrador.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(972, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "ADMINISTRADOR"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(1096, 225)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(65, 17)
        Me.chkEstado.TabIndex = 68
        Me.chkEstado.Text = "ACTIVO"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(15, 79)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(1146, 56)
        Me.txtDescripcion.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "DESCRIPCION"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(14, 163)
        Me.txtObservaciones.MaxLength = 50
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(1147, 56)
        Me.txtObservaciones.TabIndex = 64
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(589, 27)
        Me.txtNombre.MaxLength = 255
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(227, 20)
        Me.txtNombre.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(586, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "NOMBRE APP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "OBSERVACIONES"
        '
        'FrmAplicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 590)
        Me.Controls.Add(Me.txtAmbiente)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtIp)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cboProveedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboServidor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.txtAdministrador)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmAplicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APLICACION"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAmbiente As TextBox
    Friend WithEvents btnActualizar As ToolStripButton
    Friend WithEvents btnExcel As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblRegistro As ToolStripLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgv As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cboBuscar As ComboBox
    Friend WithEvents dgvBuscar As DataGridView
    Friend WithEvents btnInsertar As ToolStripButton
    Friend WithEvents txtIp As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cboProveedor As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboServidor As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents txtAdministrador As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
