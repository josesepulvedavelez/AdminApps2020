<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipalInforme
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
        Me.dgvServidorAplicacion = New System.Windows.Forms.DataGridView()
        Me.dgvContacto = New System.Windows.Forms.DataGridView()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvServidorAplicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContacto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvServidorAplicacion
        '
        Me.dgvServidorAplicacion.AllowUserToAddRows = False
        Me.dgvServidorAplicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServidorAplicacion.Location = New System.Drawing.Point(17, 304)
        Me.dgvServidorAplicacion.Name = "dgvServidorAplicacion"
        Me.dgvServidorAplicacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServidorAplicacion.Size = New System.Drawing.Size(1084, 227)
        Me.dgvServidorAplicacion.TabIndex = 7
        '
        'dgvContacto
        '
        Me.dgvContacto.AllowUserToAddRows = False
        Me.dgvContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContacto.Location = New System.Drawing.Point(17, 54)
        Me.dgvContacto.Name = "dgvContacto"
        Me.dgvContacto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContacto.Size = New System.Drawing.Size(1084, 227)
        Me.dgvContacto.TabIndex = 6
        '
        'cboProveedor
        '
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(17, 27)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(482, 21)
        Me.cboProveedor.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PROVEEDOR"
        '
        'FrmPrincipalInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 542)
        Me.Controls.Add(Me.dgvServidorAplicacion)
        Me.Controls.Add(Me.dgvContacto)
        Me.Controls.Add(Me.cboProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPrincipalInforme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROVEEDOR - CONTACTOS - APLICACIONES"
        CType(Me.dgvServidorAplicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContacto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvServidorAplicacion As DataGridView
    Friend WithEvents dgvContacto As DataGridView
    Friend WithEvents cboProveedor As ComboBox
    Friend WithEvents Label1 As Label
End Class
