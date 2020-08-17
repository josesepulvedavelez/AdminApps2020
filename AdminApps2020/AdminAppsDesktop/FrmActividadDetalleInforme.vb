Imports AdminAppsDesktop.ServicioActividadDetalleInforme
Imports Entidades

Public Class FrmActividadDetalleInforme
    Dim actividadDetalleInformeWcf As ActividadDetalleInformeWcfClient
    Dim actividadDetalleInformeENT As ActividadDetalleInformeENT
    Dim posicion As DataGridViewRow

    Private Sub FrmActividadDetalleInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actividadDetalleInformeWcf = New ActividadDetalleInformeWcfClient()
        dgvActividad.DataSource = actividadDetalleInformeWcf.SeleccionarTodos()

        dgvActividad.Columns("Id").Visible = False

        Call Registro()
    End Sub

    Private Sub Registro()
        If dgvActividad.Rows.Count < 1 Then
            MessageBox.Show("No exiten registros en este momento, puede empezar agregarlos")
        Else
            posicion = dgvActividad.CurrentRow
            lblRegistro.Text = "Registro: " & posicion.Index + 1 & " de " & dgvActividad.Rows.Count
        End If
    End Sub

    Private Sub dgvActividad_SelectionChanged(sender As Object, e As EventArgs) Handles dgvActividad.SelectionChanged
        Call Registro()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim campo As String = cboBuscar.Text
        Dim texto As String = txtBuscar.Text

        If cboBuscar.Text = "TIPO ACTIVIDAD" Then
            campo = "TIPO"
        ElseIf cboBuscar.Text = "NOMBRE PROYECTO/REQUERIMIENTO" Then
            campo = "NOMBRE"
        End If

        actividadDetalleInformeWcf = New ActividadDetalleInformeWcfClient()
        dgvActividad.DataSource = actividadDetalleInformeWcf.BuscarActividadDetalleInforme(campo, texto)
    End Sub

    Private Sub cboBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBuscar.SelectedIndexChanged
        If cboBuscar.Text = "FECHA" Then
            dtpFechaInicio.Visible = True
            dtpFechaFin.Visible = True
            txtBuscar.Visible = False
        Else
            dtpFechaInicio.Visible = False
            dtpFechaFin.Visible = False
            txtBuscar.Visible = True
        End If
    End Sub

    Private Sub dtpFechaFin_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFin.ValueChanged
        actividadDetalleInformeWcf = New ActividadDetalleInformeWcfClient()

        Dim fechaInicio As DateTime = dtpFechaInicio.Value.ToShortDateString()
        Dim fechaFinal As DateTime = dtpFechaFin.Value.ToShortDateString()

        dgvActividad.DataSource = actividadDetalleInformeWcf.BuscarActividadFecha(fechaInicio, fechaFinal)
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim exportarExcel As New ExportarExcel()

        If dgvActividad.Rows.Count < 1 Then
            MessageBox.Show("No hay registros para exportar a excel", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            exportarExcel.ExportarExcel(dgvActividad)
        End If

    End Sub
End Class