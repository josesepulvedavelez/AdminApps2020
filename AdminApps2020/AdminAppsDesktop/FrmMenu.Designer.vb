<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ARCHIVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMPRESAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SERVIDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.APLICACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTACTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AADMINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACTIVIDADESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACTIVIDADDESINFORMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BUSQUEDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROVEEDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.APLICACIONToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblUsuario, Me.ToolStripStatusLabel2, Me.lblFecha, Me.ToolStripStatusLabel3, Me.lblHora})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 415)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(960, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(50, 17)
        Me.ToolStripStatusLabel1.Text = "Usuario:"
        '
        'lblUsuario
        '
        Me.lblUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(128, 17)
        Me.lblUsuario.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(41, 17)
        Me.ToolStripStatusLabel2.Text = "Fecha:"
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(128, 17)
        Me.lblFecha.Text = "ToolStripStatusLabel3"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(36, 17)
        Me.ToolStripStatusLabel3.Text = "Hora:"
        '
        'lblHora
        '
        Me.lblHora.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(128, 17)
        Me.lblHora.Text = "ToolStripStatusLabel4"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ARCHIVOToolStripMenuItem, Me.DATAToolStripMenuItem, Me.AADMINToolStripMenuItem, Me.BUSQUEDAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(960, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ARCHIVOToolStripMenuItem
        '
        Me.ARCHIVOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SALIRToolStripMenuItem})
        Me.ARCHIVOToolStripMenuItem.Name = "ARCHIVOToolStripMenuItem"
        Me.ARCHIVOToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ARCHIVOToolStripMenuItem.Text = "ARCHIVO"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'DATAToolStripMenuItem
        '
        Me.DATAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EMPRESAToolStripMenuItem, Me.SERVIDORToolStripMenuItem, Me.APLICACIONToolStripMenuItem, Me.CONTACTOToolStripMenuItem})
        Me.DATAToolStripMenuItem.Name = "DATAToolStripMenuItem"
        Me.DATAToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.DATAToolStripMenuItem.Text = "DATA"
        '
        'EMPRESAToolStripMenuItem
        '
        Me.EMPRESAToolStripMenuItem.Name = "EMPRESAToolStripMenuItem"
        Me.EMPRESAToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.EMPRESAToolStripMenuItem.Text = "PROVEEDOR"
        '
        'SERVIDORToolStripMenuItem
        '
        Me.SERVIDORToolStripMenuItem.Name = "SERVIDORToolStripMenuItem"
        Me.SERVIDORToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SERVIDORToolStripMenuItem.Text = "SERVIDOR"
        '
        'APLICACIONToolStripMenuItem
        '
        Me.APLICACIONToolStripMenuItem.Name = "APLICACIONToolStripMenuItem"
        Me.APLICACIONToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.APLICACIONToolStripMenuItem.Text = "APLICACION"
        '
        'CONTACTOToolStripMenuItem
        '
        Me.CONTACTOToolStripMenuItem.Name = "CONTACTOToolStripMenuItem"
        Me.CONTACTOToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CONTACTOToolStripMenuItem.Text = "CONTACTO"
        '
        'AADMINToolStripMenuItem
        '
        Me.AADMINToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACTIVIDADESToolStripMenuItem, Me.ACTIVIDADDESINFORMEToolStripMenuItem})
        Me.AADMINToolStripMenuItem.Name = "AADMINToolStripMenuItem"
        Me.AADMINToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.AADMINToolStripMenuItem.Text = "ADMIN"
        '
        'ACTIVIDADESToolStripMenuItem
        '
        Me.ACTIVIDADESToolStripMenuItem.Name = "ACTIVIDADESToolStripMenuItem"
        Me.ACTIVIDADESToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ACTIVIDADESToolStripMenuItem.Text = "ACTIVIDADES"
        '
        'ACTIVIDADDESINFORMEToolStripMenuItem
        '
        Me.ACTIVIDADDESINFORMEToolStripMenuItem.Name = "ACTIVIDADDESINFORMEToolStripMenuItem"
        Me.ACTIVIDADDESINFORMEToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ACTIVIDADDESINFORMEToolStripMenuItem.Text = "ACTIVIDADDES INFORME"
        '
        'BUSQUEDAToolStripMenuItem
        '
        Me.BUSQUEDAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PROVEEDORToolStripMenuItem, Me.APLICACIONToolStripMenuItem1})
        Me.BUSQUEDAToolStripMenuItem.Name = "BUSQUEDAToolStripMenuItem"
        Me.BUSQUEDAToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.BUSQUEDAToolStripMenuItem.Text = "BUSQUEDA"
        '
        'PROVEEDORToolStripMenuItem
        '
        Me.PROVEEDORToolStripMenuItem.Name = "PROVEEDORToolStripMenuItem"
        Me.PROVEEDORToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PROVEEDORToolStripMenuItem.Text = "PROVEEDOR"
        '
        'APLICACIONToolStripMenuItem1
        '
        Me.APLICACIONToolStripMenuItem1.Name = "APLICACIONToolStripMenuItem1"
        Me.APLICACIONToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.APLICACIONToolStripMenuItem1.Text = "APLICACION"
        '
        'Timer1
        '
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 437)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "FrmMenu"
        Me.Text = "FrmMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblUsuario As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lblFecha As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lblHora As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ARCHIVOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EMPRESAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SERVIDORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents APLICACIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONTACTOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AADMINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ACTIVIDADESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ACTIVIDADDESINFORMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BUSQUEDAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROVEEDORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents APLICACIONToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
End Class
