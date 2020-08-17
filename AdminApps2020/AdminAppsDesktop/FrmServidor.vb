
Imports Entidades
Imports AdminAppsDesktop.ServicioServidor

Public Class FrmServidor
    Dim servidorWcfClient As ServidorWcfClient
    Dim servidorENT As ServidorENT
    Dim res As Integer
    Dim posicion As DataGridViewRow
    Dim Id As Integer

    Private Sub FrmServidor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        servidorWcfClient = New ServidorWcfClient()
        dgv.DataSource = servidorWcfClient.SeleccionarTodos()
        dgvBuscar.DataSource = servidorWcfClient.SeleccionarTodos()

        dgv.Columns("id").Visible = False
        dgvBuscar.Columns("id").Visible = False
        Call Registro()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Text = String.Empty
        txtIp.Text = String.Empty
        txtUsuario.Text = String.Empty
        txtContraseña.Text = String.Empty
        txtDescripcion.Text = "NINGUNA"
        txtObservaciones.Text = "NINGUNA"

        chkEstado.Checked = True

        btnNuevo.Enabled = False
        btnInsertar.Enabled = True
        txtNombre.Focus()
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If (txtNombre.Text = String.Empty And txtIp.Text = String.Empty) Or cboAmbiente.Text = String.Empty Or cboTipo.Text = String.Empty Or txtDescripcion.Text = String.Empty Or txtObservaciones.Text = String.Empty Then
            MessageBox.Show("Datos incompletos: nombre, ip, ambiente, tipo, descripcion y observaciones no pueden estar vacios", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            servidorWcfClient = New ServidorWcfClient()
            servidorENT = New ServidorENT()

            servidorENT.Nombre = txtNombre.Text
            servidorENT.Ip = txtIp.Text
            servidorENT.Usuario = txtUsuario.Text
            servidorENT.Pw = txtContraseña.Text
            servidorENT.Ambiente = cboAmbiente.Text
            servidorENT.Descripcion = txtDescripcion.Text
            servidorENT.Observaciones = txtObservaciones.Text
            servidorENT.Tipo = cboTipo.Text
            servidorENT.Estado = chkEstado.Checked

            res = servidorWcfClient.Insertar(servidorENT)

            MessageBox.Show($"{res} Servidor guardados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgv.DataSource = servidorWcfClient.SeleccionarTodos()

            btnNuevo.Enabled = True
            btnInsertar.Enabled = False
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If (txtNombre.Text = String.Empty And txtIp.Text = String.Empty) Or cboAmbiente.Text = String.Empty Or cboTipo.Text = String.Empty Or txtDescripcion.Text = String.Empty Or txtObservaciones.Text = String.Empty Then
            MessageBox.Show("Datos incompletos: nombre, ip, ambiente, tipo, descripcion y observaciones no pueden estar vacios", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            servidorWcfClient = New ServidorWcfClient()
            servidorENT = New ServidorENT()

            servidorENT.Nombre = txtNombre.Text
            servidorENT.Ip = txtIp.Text
            servidorENT.Usuario = txtUsuario.Text
            servidorENT.Pw = txtContraseña.Text
            servidorENT.Ambiente = cboAmbiente.Text
            servidorENT.Descripcion = txtDescripcion.Text
            servidorENT.Observaciones = txtObservaciones.Text
            servidorENT.Tipo = cboTipo.Text
            servidorENT.Estado = chkEstado.Checked
            servidorENT.Id = Id

            res = servidorWcfClient.Actualizar(servidorENT)

            MessageBox.Show($"{res} Servidor actualizados", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgv.DataSource = servidorWcfClient.SeleccionarTodos()
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
        txtNombre.Text = dgv.CurrentRow.Cells("nombre").Value.ToString()
        txtIp.Text = dgv.CurrentRow.Cells("Ip").Value.ToString()
        txtUsuario.Text = dgv.CurrentRow.Cells("Usuario").Value.ToString()
        txtContraseña.Text = dgv.CurrentRow.Cells("Pw").Value.ToString()
        cboTipo.Text = dgv.CurrentRow.Cells("Tipo").Value.ToString()
        cboAmbiente.Text = dgv.CurrentRow.Cells("Ambiente").Value.ToString()
        txtDescripcion.Text = dgv.CurrentRow.Cells("Descripcion").Value.ToString()
        txtObservaciones.Text = dgv.CurrentRow.Cells("Observaciones").Value.ToString()
        chkEstado.Checked = dgv.CurrentRow.Cells("Estado").Value.ToString()
        Id = dgv.CurrentRow.Cells("Id").Value.ToString()

        Call Registro()
    End Sub

    Private Sub dgvBuscar_SelectionChanged(sender As Object, e As EventArgs) Handles dgvBuscar.SelectionChanged
        txtNombre.Text = dgvBuscar.CurrentRow.Cells("nombre").Value.ToString()
        txtIp.Text = dgvBuscar.CurrentRow.Cells("Ip").Value.ToString()
        txtUsuario.Text = dgvBuscar.CurrentRow.Cells("Usuario").Value.ToString()
        txtContraseña.Text = dgvBuscar.CurrentRow.Cells("Pw").Value.ToString()
        cboTipo.Text = dgvBuscar.CurrentRow.Cells("Tipo").Value.ToString()
        cboAmbiente.Text = dgvBuscar.CurrentRow.Cells("Ambiente").Value.ToString()
        txtDescripcion.Text = dgvBuscar.CurrentRow.Cells("Descripcion").Value.ToString()
        txtObservaciones.Text = dgvBuscar.CurrentRow.Cells("Observaciones").Value.ToString()
        chkEstado.Checked = dgvBuscar.CurrentRow.Cells("Estado").Value.ToString()
        Id = dgvBuscar.CurrentRow.Cells("Id").Value.ToString()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        servidorWcfClient = New ServidorWcfClient()
        dgvBuscar.DataSource = servidorWcfClient.BuscarServidor(cboBuscar.Text, txtBuscar.Text)
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