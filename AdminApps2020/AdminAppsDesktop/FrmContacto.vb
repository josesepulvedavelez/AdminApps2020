Imports Entidades
Imports AdminAppsDesktop.ServicioContacto

Public Class FrmContacto
    Dim contactoWcfClient As ContactoWcfClient
    Dim contactoENT As ContactoENT
    Dim res As Integer
    Dim posicion As DataGridViewRow
    Dim Id As Integer

    Private Sub FrmContacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contactoWcfClient = New ContactoWcfClient()
        dgv.DataSource = contactoWcfClient.SeleccionarTodos()
        dgvBuscar.DataSource = contactoWcfClient.SeleccionarTodos()

        cboProveedor.DataSource = contactoWcfClient.SeleccionarProveedor()
        cboProveedor.DisplayMember = "proveedor"
        cboProveedor.ValueMember = "id"

        dgv.Columns("id").Visible = False
        dgv.Columns("proveedorId").Visible = False

        dgvBuscar.Columns("ProveedorId").Visible = False
        dgvBuscar.Columns("Id").Visible = False

        Call Registro()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombres.Text = String.Empty
        txtTelefonos.Text = String.Empty
        txtExts.Text = String.Empty
        txtCelulares.Text = String.Empty
        txtCorreo.Text = String.Empty
        txtVpn.Text = String.Empty
        txtObservaciones.Text = "NINGUNA"
        chkEstado.Checked = True

        btnNuevo.Enabled = False
        btnInsertar.Enabled = True
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If txtNombres.Text = String.Empty Or txtTelefonos.Text = String.Empty Or cboProveedor.Text = String.Empty Or txtObservaciones.Text = String.Empty Then
            MessageBox.Show("Faltan datos por llenar: nombres, telefonos, proveedor, observaciones no pueden estar vacios", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            contactoWcfClient = New ContactoWcfClient()
            contactoENT = New ContactoENT()

            contactoENT.Nombres = txtNombres.Text
            contactoENT.Cargo = cboCargo.Text
            contactoENT.Telefonos = txtTelefonos.Text
            contactoENT.Ext = txtExts.Text
            contactoENT.Celulares = txtCelulares.Text
            contactoENT.Observaciones = txtObservaciones.Text
            contactoENT.Correos = txtCorreo.Text
            contactoENT.Vpn = txtVpn.Text
            contactoENT.ProveedorId = cboProveedor.SelectedValue
            contactoENT.Estado = chkEstado.Checked

            res = contactoWcfClient.Insertar(contactoENT)

            MessageBox.Show($"{res} Contactos guardados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgv.DataSource = contactoWcfClient.SeleccionarTodos()

            btnNuevo.Enabled = True
            btnInsertar.Enabled = False
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtNombres.Text = String.Empty Or txtTelefonos.Text = String.Empty Or cboProveedor.Text = String.Empty Or txtObservaciones.Text = String.Empty Then
            MessageBox.Show("Faltan datos por llenar: Nombre, Tipo, Amdinistrador, Descripcion, Observaciones no pueden quedar vacios", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            contactoWcfClient = New ContactoWcfClient()
            contactoENT = New ContactoENT()

            contactoENT.Nombres = txtNombres.Text
            contactoENT.Cargo = cboCargo.Text
            contactoENT.Telefonos = txtTelefonos.Text
            contactoENT.Ext = txtExts.Text
            contactoENT.Celulares = txtCelulares.Text
            contactoENT.Observaciones = txtObservaciones.Text
            contactoENT.Correos = txtCorreo.Text
            contactoENT.Vpn = txtVpn.Text
            contactoENT.ProveedorId = cboProveedor.SelectedValue
            contactoENT.Estado = chkEstado.Checked
            contactoENT.Id = Id

            res = contactoWcfClient.Actualizar(contactoENT)

            MessageBox.Show($"{res} Contactos actualizados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgv.DataSource = contactoWcfClient.SeleccionarTodos()

            btnNuevo.Enabled = True
            btnInsertar.Enabled = False
        End If
    End Sub

    Private Sub Registro()
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
        txtNombres.Text = dgv.CurrentRow.Cells("nombres").Value
        cboCargo.Text = dgv.CurrentRow.Cells("cargo").Value
        txtTelefonos.Text = dgv.CurrentRow.Cells("Telefonos").Value
        txtExts.Text = dgv.CurrentRow.Cells("ext").Value
        txtCelulares.Text = dgv.CurrentRow.Cells("celulares").Value
        cboProveedor.Text = dgv.CurrentRow.Cells("proveedor").Value
        txtCorreo.Text = dgv.CurrentRow.Cells("correos").Value
        txtVpn.Text = dgv.CurrentRow.Cells("Vpn").Value
        txtObservaciones.Text = dgv.CurrentRow.Cells("Observaciones").Value
        chkEstado.Checked = dgv.CurrentRow.Cells("estado").Value
        Id = dgv.CurrentRow.Cells("Id").Value
    End Sub

    Private Sub dgvBuscar_SelectionChanged(sender As Object, e As EventArgs) Handles dgvBuscar.SelectionChanged
        txtNombres.Text = dgvBuscar.CurrentRow.Cells("nombres").Value
        cboCargo.Text = dgvBuscar.CurrentRow.Cells("cargo").Value
        txtTelefonos.Text = dgvBuscar.CurrentRow.Cells("Telefonos").Value
        txtExts.Text = dgvBuscar.CurrentRow.Cells("ext").Value
        txtCelulares.Text = dgvBuscar.CurrentRow.Cells("celulares").Value
        cboProveedor.Text = dgvBuscar.CurrentRow.Cells("proveedor").Value
        txtCorreo.Text = dgvBuscar.CurrentRow.Cells("correos").Value
        txtVpn.Text = dgvBuscar.CurrentRow.Cells("Vpn").Value
        txtObservaciones.Text = dgvBuscar.CurrentRow.Cells("Observaciones").Value
        chkEstado.Checked = dgvBuscar.CurrentRow.Cells("estado").Value
        Id = dgvBuscar.CurrentRow.Cells("Id").Value
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        contactoWcfClient = New ContactoWcfClient()
        dgvBuscar.DataSource = contactoWcfClient.BuscarContacto(cboBuscar.Text, txtBuscar.Text)
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