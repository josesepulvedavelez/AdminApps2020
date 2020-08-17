Public Class FrmMenu
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If MessageBox.Show("Esta seguro de salir de " & Application.ProductName, Application.ProductName & "" & Application.ProductVersion, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.Text = "MENU PRINCIPAL" & " - " & Application.ProductName
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = DateTime.Now.ToLongTimeString()
        lblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub EMPRESAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMPRESAToolStripMenuItem.Click
        FrmProveedor.MdiParent = Me
        FrmProveedor.Show()
    End Sub

    Private Sub SERVIDORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERVIDORToolStripMenuItem.Click
        FrmServidor.MdiParent = Me
        FrmServidor.Show()
    End Sub

    Private Sub APLICACIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles APLICACIONToolStripMenuItem.Click
        FrmAplicacion.MdiParent = Me
        FrmAplicacion.Show()
    End Sub

    Private Sub CONTACTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTACTOToolStripMenuItem.Click
        FrmContacto.MdiParent = Me
        FrmContacto.Show()
    End Sub

    Private Sub ACTIVIDADESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTIVIDADESToolStripMenuItem.Click
        FrmActividad.MdiParent = Me
        FrmActividad.Show()
    End Sub

    Private Sub ACTIVIDADDESINFORMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTIVIDADDESINFORMEToolStripMenuItem.Click
        FrmActividadDetalleInforme.MdiParent = Me
        FrmActividadDetalleInforme.Show()
    End Sub

    Private Sub PROVEEDORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROVEEDORToolStripMenuItem.Click
        FrmPrincipalInforme.MdiParent = Me
        FrmPrincipalInforme.Show()
    End Sub
End Class