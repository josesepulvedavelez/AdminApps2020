Imports Datos
Imports Entidades
Imports AdminAppsDesktop.ServicioAplicacion

Public Class FrmAplicacion
    Dim aplicacionWfcClient As AplicacionWcfClient
    Dim aplicacionENT As AplicacionENT
    Dim res As Integer
    Dim posicion As DataGridViewRow
    Dim Id As Integer

    Private Sub FrmAplicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aplicacionWfcClient = New AplicacionWcfClient()
        dgv.DataSource = aplicacionWfcClient.SeleccionarTodos()
        dgvBuscar.DataSource = aplicacionWfcClient.SeleccionarTodos()

        cboProveedor.DataSource = aplicacionWfcClient.SeleccionarProveedor()
        cboProveedor.DisplayMember = "proveedor"
        cboProveedor.ValueMember = "id"

        cboServidor.DataSource = aplicacionWfcClient.SeleccionarServidor()
        cboServidor.DisplayMember = "nombre"
        cboServidor.ValueMember = "id"

        dgv.Columns("proveedorId").Visible = False
        dgv.Columns("ServidorId").Visible = False
        dgv.Columns("Id").Visible = False

        dgvBuscar.Columns("proveedorId").Visible = False
        dgvBuscar.Columns("ServidorId").Visible = False
        dgvBuscar.Columns("Id").Visible = False

        Call CargarDatos()
        Call Registro()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Text = String.Empty
        txtAdministrador.Text = FrmMenu.lblUsuario.Text
        txtDescripcion.Text = String.Empty
        txtObservaciones.Text = "NINGUNA"
        chkEstado.Checked = True

        btnNuevo.Enabled = False
        btnInsertar.Enabled = True
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If txtNombre.Text = String.Empty Or cboTipo.Text = String.Empty Or txtAdministrador.Text = String.Empty Or txtDescripcion.Text = String.Empty Or txtObservaciones.Text = String.Empty Then
            MessageBox.Show("Faltan datos por llenar: Nombre, Tipo, Amdinistrador, Descripcion, Observaciones no pueden quedar vacios", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            aplicacionWfcClient = New AplicacionWcfClient()
            aplicacionENT = New AplicacionENT()

            aplicacionENT.Aplicacion = txtNombre.Text
            aplicacionENT.Descripcion = txtDescripcion.Text
            aplicacionENT.Tipo = cboTipo.Text
            aplicacionENT.Administrador = txtAdministrador.Text
            aplicacionENT.Observaciones = txtObservaciones.Text
            aplicacionENT.ProveedorId = cboProveedor.SelectedValue
            aplicacionENT.ServidorId = cboServidor.SelectedValue
            aplicacionENT.Estado = chkEstado.Checked

            res = aplicacionWfcClient.Insertar(aplicacionENT)

            MessageBox.Show($"{res} Aplicacion guardados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgv.DataSource = aplicacionWfcClient.SeleccionarTodos()

            btnNuevo.Enabled = True
            btnInsertar.Enabled = False
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtNombre.Text = String.Empty Or cboTipo.Text = String.Empty Or txtAdministrador.Text = String.Empty Or txtDescripcion.Text = String.Empty Or txtObservaciones.Text = String.Empty Then
            MessageBox.Show("Faltan datos por llenar: Nombre, Tipo, Amdinistrador, Descripcion, Observaciones no pueden quedar vacios", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            aplicacionWfcClient = New AplicacionWcfClient()
            aplicacionENT = New AplicacionENT()

            aplicacionENT.Aplicacion = txtNombre.Text
            aplicacionENT.Descripcion = txtDescripcion.Text
            aplicacionENT.Tipo = cboTipo.Text
            aplicacionENT.Administrador = txtAdministrador.Text
            aplicacionENT.Observaciones = txtObservaciones.Text
            aplicacionENT.ProveedorId = cboProveedor.SelectedValue
            aplicacionENT.ServidorId = cboServidor.SelectedValue
            aplicacionENT.Estado = chkEstado.Checked
            aplicacionENT.Id = Id

            res = aplicacionWfcClient.Actualizar(aplicacionENT)

            MessageBox.Show($"{res} Aplicacion guardados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgv.DataSource = aplicacionWfcClient.SeleccionarTodos()

            btnNuevo.Enabled = True
            btnInsertar.Enabled = False
        End If
    End Sub

    Public Sub Registro()
        If dgv.Rows.Count < 1 Then
            MessageBox.Show("No exiten registros en este momento, puede empezar agregarlos")
        Else
            posicion = dgv.CurrentRow
            lblRegistro.Text = "Registro: " & posicion.Index + 1 & " de " & dgv.Rows.Count
        End If
    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        Call CargarDatos()
        Call Registro()
    End Sub

    Private Sub CargarDatos()
        Try
            cboProveedor.Text = dgv.CurrentRow.Cells("Proveedor").Value
            cboServidor.Text = dgv.CurrentRow.Cells("Servidor").Value
            txtIp.Text = dgv.CurrentRow.Cells("Ip").Value
            txtAmbiente.Text = dgv.CurrentRow.Cells("ambiente").Value
            txtNombre.Text = dgv.CurrentRow.Cells("Aplicacion").Value
            txtDescripcion.Text = dgv.CurrentRow.Cells("Descripcion").Value
            cboTipo.Text = dgv.CurrentRow.Cells("Tipo").Value
            txtAdministrador.Text = dgv.CurrentRow.Cells("Administrador").Value
            txtObservaciones.Text = dgv.CurrentRow.Cells("Observaciones").Value
            chkEstado.Checked = dgv.CurrentRow.Cells("Estado").Value

            Id = dgv.CurrentRow.Cells("Id").Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvBuscar_SelectionChanged(sender As Object, e As EventArgs) Handles dgvBuscar.SelectionChanged
        cboProveedor.Text = dgvBuscar.CurrentRow.Cells("Proveedor").Value
        cboServidor.Text = dgvBuscar.CurrentRow.Cells("Servidor").Value
        txtIp.Text = dgvBuscar.CurrentRow.Cells("Ip").Value
        txtAmbiente.Text = dgvBuscar.CurrentRow.Cells("ambiente").Value
        txtNombre.Text = dgvBuscar.CurrentRow.Cells("Aplicacion").Value
        txtDescripcion.Text = dgvBuscar.CurrentRow.Cells("Descripcion").Value
        cboTipo.Text = dgvBuscar.CurrentRow.Cells("Tipo").Value
        txtAdministrador.Text = dgvBuscar.CurrentRow.Cells("Administrador").Value
        txtObservaciones.Text = dgvBuscar.CurrentRow.Cells("Observaciones").Value
        chkEstado.Checked = dgvBuscar.CurrentRow.Cells("Estado").Value

        Id = dgvBuscar.CurrentRow.Cells("Id").Value
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        aplicacionWfcClient = New AplicacionWcfClient()
        dgvBuscar.DataSource = aplicacionWfcClient.BuscarAplicacion(cboBuscar.Text, txtBuscar.Text)
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim exportarExcel As New ExportarExcel()

        If TabControl1.SelectedIndex = 0 Then
            If dgv.Rows.Count < 1 Then
                MessageBox.Show("No hay registros para exportar a excel", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                exportarExcel.ExportarExcel(dgv)
            End If
        ElseIf TabControl1.SelectedIndex = 1 Then
            If dgvBuscar.Rows.Count < 1 Then
                MessageBox.Show("No hay registros para exportar a excel", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                exportarExcel.ExportarExcel(dgvBuscar)
            End If
        End If
    End Sub
End Class