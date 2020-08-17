<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmServidor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmServidor))
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcel = New System.Windows.Forms.ToolStripButton()
        Me.btnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.btnInsertar = New System.Windows.Forms.ToolStripButton()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.cboAmbiente = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIp = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Label8.Location = New System.Drawing.Point(182, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Valor:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Buscar por:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(185, 20)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(351, 20)
        Me.txtBuscar.TabIndex = 33
        '
        'dgvBuscar
        '
        Me.dgvBuscar.AllowUserToAddRows = False
        Me.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscar.Location = New System.Drawing.Point(6, 46)
        Me.dgvBuscar.Name = "dgvBuscar"
        Me.dgvBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBuscar.Size = New System.Drawing.Size(1056, 229)
        Me.dgvBuscar.TabIndex = 31
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1068, 281)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "SERVIDOR"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(6, 6)
        Me.dgv.Name = "dgv"
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1056, 269)
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
        Me.TabPage2.Size = New System.Drawing.Size(1068, 281)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BUSCAR SERVIDOR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cboBuscar
        '
        Me.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {"AMBIENTE", "TIPO", "NOMBRE", "IP", "USUARIO", "DESCRIPCION", "OBSERVACIONES"})
        Me.cboBuscar.Location = New System.Drawing.Point(6, 19)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(173, 21)
        Me.cboBuscar.TabIndex = 32
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(16, 245)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1076, 307)
        Me.TabControl1.TabIndex = 53
        '
        'lblRegistro
        '
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(53, 22)
        Me.lblRegistro.Text = "Registro:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "DESCRIPCION"
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
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(63, 22)
        Me.btnActualizar.Text = "Actualizar"
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
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 569)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1104, 25)
        Me.ToolStrip1.TabIndex = 52
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(15, 76)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(1072, 56)
        Me.txtDescripcion.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(191, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "TIPO"
        '
        'cboTipo
        '
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"WINDOWS SERVER", "LINUX", "SOLARIS"})
        Me.cboTipo.Location = New System.Drawing.Point(194, 26)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(173, 21)
        Me.cboTipo.TabIndex = 40
        '
        'cboAmbiente
        '
        Me.cboAmbiente.FormattingEnabled = True
        Me.cboAmbiente.Items.AddRange(New Object() {"DESARROLLO", "PRUEBAS", "PRODUCCCION", "OTRO"})
        Me.cboAmbiente.Location = New System.Drawing.Point(15, 27)
        Me.cboAmbiente.Name = "cboAmbiente"
        Me.cboAmbiente.Size = New System.Drawing.Size(173, 21)
        Me.cboAmbiente.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "AMBIENTE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(911, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "CONTRASEÑA"
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(914, 27)
        Me.txtContraseña.MaxLength = 50
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(173, 20)
        Me.txtContraseña.TabIndex = 38
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(735, 27)
        Me.txtUsuario.MaxLength = 255
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(173, 20)
        Me.txtUsuario.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(732, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "USUARIO"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(1022, 222)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(65, 17)
        Me.chkEstado.TabIndex = 41
        Me.chkEstado.Text = "ACTIVO"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(15, 160)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(1072, 56)
        Me.txtObservaciones.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "OBSERVACIONES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(553, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "IP"
        '
        'txtIp
        '
        Me.txtIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIp.Location = New System.Drawing.Point(556, 27)
        Me.txtIp.MaxLength = 50
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(173, 20)
        Me.txtIp.TabIndex = 36
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(377, 27)
        Me.txtNombre.MaxLength = 255
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(173, 20)
        Me.txtNombre.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(374, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "NOMBRE"
        '
        'FrmServidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 594)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.cboAmbiente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIp)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmServidor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SERVIDOR"
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
    Friend WithEvents Label9 As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnExcel As ToolStripButton
    Friend WithEvents btnActualizar As ToolStripButton
    Friend WithEvents btnInsertar As ToolStripButton
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents cboAmbiente As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIp As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
End Class
