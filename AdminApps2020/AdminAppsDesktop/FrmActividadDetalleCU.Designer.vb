<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActividadDetalleCU
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
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudMinutos = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cboUsurio = New System.Windows.Forms.ComboBox()
        CType(Me.nudMinutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(274, 366)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 23
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(274, 366)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 22
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "RESPONSABLE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "MINUTOS"
        '
        'nudMinutos
        '
        Me.nudMinutos.Location = New System.Drawing.Point(134, 25)
        Me.nudMinutos.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudMinutos.Name = "nudMinutos"
        Me.nudMinutos.Size = New System.Drawing.Size(120, 20)
        Me.nudMinutos.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "OBSERVACIONES"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(15, 229)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(592, 127)
        Me.txtObservaciones.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "DESCRIPCION"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(15, 73)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(592, 127)
        Me.txtDescripcion.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "FECHA"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(15, 25)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(113, 20)
        Me.dtpFecha.TabIndex = 12
        '
        'cboUsurio
        '
        Me.cboUsurio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboUsurio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboUsurio.FormattingEnabled = True
        Me.cboUsurio.Location = New System.Drawing.Point(260, 25)
        Me.cboUsurio.Name = "cboUsurio"
        Me.cboUsurio.Size = New System.Drawing.Size(347, 21)
        Me.cboUsurio.TabIndex = 77
        '
        'FrmActividadDetalleCU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 397)
        Me.Controls.Add(Me.cboUsurio)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nudMinutos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Name = "FrmActividadDetalleCU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTIVIDAD DETALLE - GUARDAR/ACTUALIZAR"
        CType(Me.nudMinutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nudMinutos As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cboUsurio As ComboBox
End Class
