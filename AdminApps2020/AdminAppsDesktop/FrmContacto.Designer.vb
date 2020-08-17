<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContacto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContacto))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvBuscar = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cboBuscar = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.lblRegistro = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcel = New System.Windows.Forms.ToolStripButton()
        Me.btnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.btnInsertar = New System.Windows.Forms.ToolStripButton()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCelulares = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtExts = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefonos = New System.Windows.Forms.TextBox()
        Me.cboCargo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtVpn = New System.Windows.Forms.TextBox()
        CType(Me.dgvBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(185, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Valor:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Buscar por:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(188, 29)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(351, 20)
        Me.txtBuscar.TabIndex = 33
        '
        'dgvBuscar
        '
        Me.dgvBuscar.AllowUserToAddRows = False
        Me.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscar.Location = New System.Drawing.Point(6, 55)
        Me.dgvBuscar.Name = "dgvBuscar"
        Me.dgvBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBuscar.Size = New System.Drawing.Size(996, 203)
        Me.dgvBuscar.TabIndex = 31
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1008, 264)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CONTACTO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(6, 6)
        Me.dgv.Name = "dgv"
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(996, 252)
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
        Me.TabPage2.Size = New System.Drawing.Size(1008, 264)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BUSCAR CONTACTO"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cboBuscar
        '
        Me.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {"NOMBRES", "CARGO", "PROVEEDOR", "OBSERVACIONES"})
        Me.cboBuscar.Location = New System.Drawing.Point(6, 28)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(173, 21)
        Me.cboBuscar.TabIndex = 32
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(10, 259)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1016, 290)
        Me.TabControl1.TabIndex = 77
        '
        'lblRegistro
        '
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(53, 22)
        Me.lblRegistro.Text = "Registro:"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'btnActualizar
        '
        Me.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(63, 22)
        Me.btnActualizar.Text = "Actualizar"
        '
        'btnInsertar
        '
        Me.btnInsertar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnInsertar.Enabled = False
        Me.btnInsertar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(50, 22)
        Me.btnInsertar.Text = "Insertar"
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
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 564)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1038, 25)
        Me.ToolStrip1.TabIndex = 76
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(15, 121)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(935, 20)
        Me.txtCorreo.TabIndex = 75
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "CORREO"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(886, 236)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(65, 17)
        Me.chkEstado.TabIndex = 73
        Me.chkEstado.Text = "ACTIVO"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(640, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "PROVEEDOR"
        '
        'cboProveedor
        '
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(643, 72)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(308, 21)
        Me.cboProveedor.TabIndex = 71
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(12, 174)
        Me.txtObservaciones.MaxLength = 50
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(938, 56)
        Me.txtObservaciones.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "OBSERVACIONES"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(326, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "CELULAR"
        '
        'txtCelulares
        '
        Me.txtCelulares.Location = New System.Drawing.Point(329, 73)
        Me.txtCelulares.Name = "txtCelulares"
        Me.txtCelulares.Size = New System.Drawing.Size(308, 20)
        Me.txtCelulares.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "EXTENSION"
        '
        'txtExts
        '
        Me.txtExts.Location = New System.Drawing.Point(15, 73)
        Me.txtExts.Name = "txtExts"
        Me.txtExts.Size = New System.Drawing.Size(104, 20)
        Me.txtExts.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(640, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "TELEFONO"
        '
        'txtTelefonos
        '
        Me.txtTelefonos.Location = New System.Drawing.Point(643, 25)
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.Size = New System.Drawing.Size(307, 20)
        Me.txtTelefonos.TabIndex = 63
        '
        'cboCargo
        '
        Me.cboCargo.FormattingEnabled = True
        Me.cboCargo.Location = New System.Drawing.Point(329, 24)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Size = New System.Drawing.Size(308, 21)
        Me.cboCargo.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(329, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "CARGO"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(15, 25)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(308, 20)
        Me.txtNombres.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "NOMBRE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(122, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "VPN"
        '
        'txtVpn
        '
        Me.txtVpn.Location = New System.Drawing.Point(125, 73)
        Me.txtVpn.Name = "txtVpn"
        Me.txtVpn.Size = New System.Drawing.Size(198, 20)
        Me.txtVpn.TabIndex = 79
        '
        'FrmContacto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 589)
        Me.Controls.Add(Me.txtVpn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboProveedor)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCelulares)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtExts)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTelefonos)
        Me.Controls.Add(Me.cboCargo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmContacto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTACTO"
        CType(Me.dgvBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvBuscar As DataGridView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgv As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cboBuscar As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents lblRegistro As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnExcel As ToolStripButton
    Friend WithEvents btnActualizar As ToolStripButton
    Friend WithEvents btnInsertar As ToolStripButton
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboProveedor As ComboBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCelulares As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtExts As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTelefonos As TextBox
    Friend WithEvents cboCargo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtVpn As TextBox
End Class
