Imports Datos
Imports Entidades
Imports AdminAppsDesktop.ServicioProveedor

Public Class FrmProveedor
    Dim proveedorWcfClient As ProveedorWcfClient
    Dim proveedorENt As ProveedorENT
    Dim res As Integer
    Dim posicion As DataGridViewRow
    Dim Id As Integer

    Private Sub FrmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        proveedorWcfClient = New ProveedorWcfClient()
        dgv.DataSource = proveedorWcfClient.SeleccionarTodos()
        dgvBuscar.DataSource = proveedorWcfClient.SeleccionarTodos()

        dgv.Columns("Id").Visible = False
        dgvBuscar.Columns("Id").Visible = False

        Call Registro()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtProveedor.Text = String.Empty
        txtNit.Text = String.Empty
        txtObservaciones.Text = "NINGUNA"
        chkEstado.Checked = True

        btnNuevo.Enabled = False
        btnInsertar.Enabled = True
        txtProveedor.Focus()
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If txtProveedor.Text = String.Empty Or txtObservaciones.Text = String.Empty Then
            MessageBox.Show("Faltan datos por llenar: Proveedor, observaciones no pueden quedar vacios", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            proveedorWcfClient = New ProveedorWcfClient()
            proveedorENt = New ProveedorENT()

            proveedorENt.Proveedor = txtProveedor.Text
            proveedorENt.Nit = txtNit.Text
            proveedorENt.Observaciones = txtObservaciones.Text
            proveedorENt.Estado = chkEstado.Checked

            res = proveedorWcfClient.Insertar(proveedorENt)

            MessageBox.Show($"{res} Proveedor guardados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgv.DataSource = proveedorWcfClient.SeleccionarTodos()

            btnNuevo.Enabled = True
            btnInsertar.Enabled = False
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtProveedor.Text = String.Empty Or txtObservaciones.Text = String.Empty Then
            MessageBox.Show("Faltan datos por llenar: Proveedor, observaciones no pueden quedar vacios", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            proveedorWcfClient = New ProveedorWcfClient()
            proveedorENt = New ProveedorENT()

            proveedorENt.Proveedor = txtProveedor.Text
            proveedorENt.Nit = txtNit.Text
            proveedorENt.Observaciones = txtObservaciones.Text
            proveedorENt.Estado = chkEstado.Checked
            proveedorENt.Id = Id

            res = proveedorWcfClient.Actualizar(proveedorENt)

            MessageBox.Show($"{res} Proveedor actualizados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgv.DataSource = proveedorWcfClient.SeleccionarTodos()
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
        txtProveedor.Text = dgv.CurrentRow.Cells("Proveedor").Value
        txtNit.Text = dgv.CurrentRow.Cells("Nit").Value
        txtObservaciones.Text = dgv.CurrentRow.Cells("Observaciones").Value
        chkEstado.Checked = dgv.CurrentRow.Cells("Estado").Value
        Id = dgv.CurrentRow.Cells("Id").Value

        Call Registro()
    End Sub

    Private Sub dgvBuscar_SelectionChanged(sender As Object, e As EventArgs) Handles dgvBuscar.SelectionChanged
        txtProveedor.Text = dgvBuscar.CurrentRow.Cells("Proveedor").Value
        txtNit.Text = dgvBuscar.CurrentRow.Cells("Nit").Value
        txtObservaciones.Text = dgvBuscar.CurrentRow.Cells("Observaciones").Value
        chkEstado.Checked = dgvBuscar.CurrentRow.Cells("Estado").Value

        Id = dgvBuscar.CurrentRow.Cells("Id").Value
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        proveedorWcfClient = New ProveedorWcfClient()
        dgvBuscar.DataSource = proveedorWcfClient.BuscarProveedor(cboBuscar.Text, txtBuscar.Text)
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