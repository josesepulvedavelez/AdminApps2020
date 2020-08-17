Imports Entidades
Imports AdminAppsDesktop.ServicioActividad
Imports AdminAppsDesktop.ServicioActividadDetalle
Imports AdminAppsDesktop.ServicioLogin

Public Class FrmActividad
    Dim actividadWcfClient As ActividadWcfClient
    Dim actividadDetalleWcfClient As ActividadDetalleWcfClient
    Dim actividadENT As ActividadENT
    Dim actividadDetalleENT As ActividadDetalleENT
    Dim res As Integer
    Dim posicion As DataGridViewRow

    Friend IdActividad As Integer

    Private Sub FrmActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actividadWcfClient = New ActividadWcfClient()

        cboUsurio.DataSource = actividadWcfClient.SeleccionarUsuario()
        cboUsurio.DisplayMember = "Usuario"
        cboUsurio.ValueMember = "Id"

        dgvActividad.DataSource = actividadWcfClient.SeleccionarTodos()

        dgvActividad.Columns("id").Visible = False

        Call Registro()

        'For Each r As DataGridViewRow In dgvActividad.Rows
        '    If r.Cells("Estado").Value = "ABIERTA" Then
        '        r.DefaultCellStyle.BackColor = Color.Red
        '    Else
        '        r.DefaultCellStyle.BackColor = Color.Green
        '    End If
        'Next
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dtpFecha.Value = DateTime.Now.ToShortDateString()
        txtNombre.Text = String.Empty
        txtDescripcion.Text = String.Empty
        cboUsurio.Text = String.Empty

        btnNuevo.Enabled = False
        btnInsertar.Enabled = True
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If txtNombre.Text = String.Empty Or cboTipo.Text = String.Empty Or txtDescripcion.Text = String.Empty Or cboUsurio.Text = String.Empty Then
            MessageBox.Show("Faltan datos por llenar: Nombre, Tipo, Descripcion, usuario, no pueden quedar vacios", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            actividadWcfClient = New ActividadWcfClient()
            actividadENT = New ActividadENT()

            actividadENT.Fecha = dtpFecha.Value
            actividadENT.Tipo = cboTipo.Text
            actividadENT.Nombre = txtNombre.Text
            actividadENT.Descripcion = txtDescripcion.Text
            actividadENT.Aplicacion = cboAplicacion.Text
            actividadENT.Usuario = cboUsurio.Text
            actividadENT.Estado = cboEstado.Text

            res = actividadWcfClient.Insertar(actividadENT)

            MessageBox.Show($"{res} Actividades guardados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvActividad.DataSource = actividadWcfClient.SeleccionarTodos()

            btnNuevo.Enabled = True
            btnInsertar.Enabled = False
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtNombre.Text = String.Empty Or cboTipo.Text = String.Empty Or txtDescripcion.Text = String.Empty Or cboUsurio.Text = String.Empty Then
            MessageBox.Show("Datos incompletos: nombre, ip, ambiente, tipo, descripcion y observaciones no pueden estar vacios", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            actividadWcfClient = New ActividadWcfClient()
            actividadENT = New ActividadENT()

            actividadENT.Fecha = dtpFecha.Value
            actividadENT.Tipo = cboTipo.Text
            actividadENT.Nombre = txtNombre.Text
            actividadENT.Descripcion = txtDescripcion.Text
            actividadENT.Aplicacion = cboAplicacion.Text
            actividadENT.Usuario = cboUsurio.Text
            actividadENT.Estado = cboEstado.Text
            actividadENT.Id = dgvActividad.CurrentRow.Cells("id").Value

            res = actividadWcfClient.Actualizar(actividadENT)

            MessageBox.Show($"{res} Actividades guardados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvActividad.DataSource = actividadWcfClient.SeleccionarTodos()

            btnNuevo.Enabled = True
            btnInsertar.Enabled = False
        End If
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
        dtpFecha.Value = dgvActividad.CurrentRow.Cells("Fecha").Value.ToString()
        cboTipo.Text = dgvActividad.CurrentRow.Cells("Tipo").Value.ToString()
        txtNombre.Text = dgvActividad.CurrentRow.Cells("Nombre").Value.ToString()
        txtDescripcion.Text = dgvActividad.CurrentRow.Cells("Descripcion").Value.ToString()
        cboAplicacion.Text = dgvActividad.CurrentRow.Cells("Aplicacion").Value.ToString()
        cboUsurio.Text = dgvActividad.CurrentRow.Cells("Usuario").Value.ToString()
        cboEstado.Text = dgvActividad.CurrentRow.Cells("Estado").Value.ToString()
        IdActividad = dgvActividad.CurrentRow.Cells("Id").Value.ToString()

        Call CargarActividadDetalle()
        Call Registro()
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

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim campo As String = cboBuscar.Text
        Dim texto As String = txtBuscar.Text

        If cboBuscar.Text = "TIPO ACTIVIDAD" Then
            campo = "TIPO"
        ElseIf cboBuscar.Text = "NOMBRE PROYECTO/REQUERIMIENTO" Then
            campo = "NOMBRE"
        End If

        actividadWcfClient = New ActividadWcfClient()
        dgvActividad.DataSource = actividadWcfClient.BuscarActividad(campo, texto)
    End Sub

    Private Sub dtpFechaFin_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFin.ValueChanged
        actividadWcfClient = New ActividadWcfClient()

        Dim fechaInicio As DateTime = dtpFechaInicio.Value.ToShortDateString()
        Dim fechaFinal As DateTime = dtpFechaFin.Value.ToShortDateString()

        dgvActividad.DataSource = actividadWcfClient.BuscarActividadFecha(fechaInicio, fechaFinal)
    End Sub

    Private Sub RegistroDetalle()
        If dgvActividadDetalle.Rows.Count < 1 Then
            MessageBox.Show("No exiten registros en este momento, puede empezar agregarlos")
        Else
            posicion = dgvActividadDetalle.CurrentRow
            lblRegistroActividadDetalle.Text = "Registro: " & posicion.Index + 1 & " de " & dgvActividadDetalle.Rows.Count
        End If
    End Sub

    Friend Sub CargarActividadDetalle()
        actividadDetalleWcfClient = New ActividadDetalleWcfClient()
        actividadDetalleENT = New ActividadDetalleENT()

        actividadDetalleENT.ActividadId = dgvActividad.CurrentRow.Cells("id").Value
        dgvActividadDetalle.DataSource = actividadDetalleWcfClient.SeleccionarTodos(actividadDetalleENT)
    End Sub

    Private Sub dgvActividadDetalle_SelectionChanged(sender As Object, e As EventArgs) Handles dgvActividadDetalle.SelectionChanged
        Call RegistroDetalle()
    End Sub

    Private Sub btnNuevoActividadDetalle_Click(sender As Object, e As EventArgs) Handles btnNuevoActividadDetalle.Click
        FrmActividadDetalleCU.MdiParent = FrmMenu
        FrmActividadDetalleCU.Show()
        FrmActividadDetalleCU.btnAgregar.Visible = True
        FrmActividadDetalleCU.btnActualizar.Visible = False

        IdActividad = dgvActividad.CurrentRow.Cells("Id").Value.ToString()
    End Sub

    Private Sub btnActualizarActividadDetalle_Click(sender As Object, e As EventArgs) Handles btnActualizarActividadDetalle.Click
        If dgvActividadDetalle.Rows.Count < 1 Then
            MessageBox.Show("No existen detalles para modificar en esta actividad", Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                FrmActividadDetalleCU.MdiParent = FrmMenu
                FrmActividadDetalleCU.Show()

                FrmActividadDetalleCU.dtpFecha.Value = dgvActividadDetalle.CurrentRow.Cells("Fecha").Value.ToString()
                FrmActividadDetalleCU.nudMinutos.Value = dgvActividadDetalle.CurrentRow.Cells("Minutos").Value.ToString()
                FrmActividadDetalleCU.cboUsurio.Text = dgvActividadDetalle.CurrentRow.Cells("Responsable").Value.ToString()
                FrmActividadDetalleCU.txtDescripcion.Text = dgvActividadDetalle.CurrentRow.Cells("Descripcion").Value.ToString()
                FrmActividadDetalleCU.txtObservaciones.Text = dgvActividadDetalle.CurrentRow.Cells("Observaciones").Value.ToString()
                IdActividad = dgvActividad.CurrentRow.Cells("Id").Value.ToString()

                FrmActividadDetalleCU.btnAgregar.Visible = False
                FrmActividadDetalleCU.btnActualizar.Visible = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim exportarExcel As New ExportarExcel()

        If TabControl1.SelectedIndex = 0 Then
            If dgvActividad.Rows.Count < 1 Then
                MessageBox.Show("No hay registros para exportar a excel", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                exportarExcel.ExportarExcel(dgvActividad)
            End If
        End If
    End Sub

End Class