Imports AdminAppsDesktop.ServicioActividadDetalle
Imports AdminAppsDesktop.ServicioActividad
Imports Entidades

Public Class FrmActividadDetalleCU
    Dim actividadDetalleWcf As ActividadDetalleWcfClient
    Dim actividadDetalleENT As ActividadDetalleENT
    Dim res As Integer

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtDescripcion.Text = String.Empty Or txtObservaciones.Text = String.Empty Or cboUsurio.Text = String.Empty Then
            MessageBox.Show("Faltan datos por llenar: Descripcion, Observaciones, Responsable no pueden quedar vacios", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            actividadDetalleWcf = New ActividadDetalleWcfClient()
            actividadDetalleENT = New ActividadDetalleENT()

            actividadDetalleENT.Fecha = dtpFecha.Value
            actividadDetalleENT.Descripcion = txtDescripcion.Text
            actividadDetalleENT.Minutos = nudMinutos.Value
            actividadDetalleENT.Responsable = cboUsurio.Text
            actividadDetalleENT.Observaciones = txtObservaciones.Text
            actividadDetalleENT.ActividadId = FrmActividad.IdActividad.ToString()

            res = actividadDetalleWcf.Insertar(actividadDetalleENT)
            MessageBox.Show($"{res} Detalle de actividad guardada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
            FrmActividad.CargarActividadDetalle()
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtDescripcion.Text = String.Empty Or txtObservaciones.Text = String.Empty Or cboUsurio.Text = String.Empty Then
            MessageBox.Show("Faltan datos por llenar: Descripcion, Observaciones, Responsable no pueden quedar vacios", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            actividadDetalleWcf = New ActividadDetalleWcfClient()
            actividadDetalleENT = New ActividadDetalleENT()

            actividadDetalleENT.Fecha = dtpFecha.Value
            actividadDetalleENT.Descripcion = txtDescripcion.Text
            actividadDetalleENT.Minutos = nudMinutos.Value
            actividadDetalleENT.Responsable = cboUsurio.Text
            actividadDetalleENT.Observaciones = txtObservaciones.Text
            actividadDetalleENT.ActividadId = FrmActividad.IdActividad.ToString()
            actividadDetalleENT.Id = FrmActividad.dgvActividadDetalle.CurrentRow.Cells("id").Value

            res = actividadDetalleWcf.Actualizar(actividadDetalleENT)
            MessageBox.Show($"{res} Detalle de actividad actualizada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
            FrmActividad.CargarActividadDetalle()
        End If
    End Sub

    Private Sub FrmActividadDetalleCU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim actividadWcfClient As New ActividadWcfClient()

        cboUsurio.DataSource = actividadWcfClient.SeleccionarUsuario()
        cboUsurio.DisplayMember = "Usuario"
        cboUsurio.ValueMember = "Id"
    End Sub
End Class