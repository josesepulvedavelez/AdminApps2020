<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProveedor))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnInsertar = New System.Windows.Forms.ToolStripButton()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(182, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Valor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Buscar por:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(185, 22)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(351, 20)
        Me.txtBuscar.TabIndex = 28
        '
        'dgvBuscar
        '
        Me.dgvBuscar.AllowUserToAddRows = False
        Me.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscar.Location = New System.Drawing.Point(6, 49)
        Me.dgvBuscar.Name = "dgvBuscar"
        Me.dgvBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBuscar.Size = New System.Drawing.Size(530, 210)
        Me.dgvBuscar.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(542, 265)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PROVEEDOR"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(6, 6)
        Me.dgv.Name = "dgv"
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(530, 253)
        Me.dgv.TabIndex = 25
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtBuscar)
        Me.TabPage2.Controls.Add(Me.cboBuscar)
        Me.TabPage2.Controls.Add(Me.dgvBuscar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(542, 265)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BUSCAR PROVEEDOR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cboBuscar
        '
        Me.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.Items.AddRange(New Object() {"PROVEEDOR", "OBSERVACIONES"})
        Me.cboBuscar.Location = New System.Drawing.Point(6, 22)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(173, 21)
        Me.cboBuscar.TabIndex = 27
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 145)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(550, 291)
        Me.TabControl1.TabIndex = 37
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
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(63, 22)
        Me.btnActualizar.Text = "Actualizar"
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
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 448)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(574, 25)
        Me.ToolStrip1.TabIndex = 36
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(467, 131)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(65, 17)
        Me.chkEstado.TabIndex = 33
        Me.chkEstado.Text = "ACTIVO"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(12, 69)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(550, 56)
        Me.txtObservaciones.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "OBSERVACIONES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(320, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "NIT"
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(323, 20)
        Me.txtNit.MaxLength = 50
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(239, 20)
        Me.txtNit.TabIndex = 31
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(12, 20)
        Me.txtProveedor.MaxLength = 255
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(305, 20)
        Me.txtProveedor.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "PROVEEDOR"
        '
        'FrmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 473)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNit)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROVEEDOR"
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

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
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
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnInsertar As ToolStripButton
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNit As TextBox
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents Label1 As Label
End Class
