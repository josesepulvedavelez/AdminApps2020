Imports AdminAppsDesktop.ServicioProveedor
Imports AdminAppsDesktop.ServicioContacto
Imports AdminAppsDesktop.ServicioAplicacion
Imports Entidades

Public Class FrmPrincipalInforme
    Dim proveedorWcfClient As ProveedorWcfClient
    Dim contactoWcfClient As ContactoWcfClient
    Dim aplicacionWcfClient As AplicacionWcfClient

    Private Sub FrmPrincipalInforme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        proveedorWcfClient = New ProveedorWcfClient()

        cboProveedor.DataSource = proveedorWcfClient.SeleccionarProveedor()
        cboProveedor.DisplayMember = "Proveedor"
        cboProveedor.ValueMember = "Id"
    End Sub

    Private Sub cboProveedor_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboProveedor.SelectionChangeCommitted
        CargarContacto()
        CargarAplicacion()
    End Sub

    Private Sub CargarContacto()
        contactoWcfClient = New ContactoWcfClient()
        dgvContacto.DataSource = contactoWcfClient.SeleccionarContacto(cboProveedor.SelectedValue)

        dgvContacto.Columns("ProveedorId").Visible = False
        dgvContacto.Columns("Id").Visible = False
    End Sub

    Private Sub CargarAplicacion()
        aplicacionWcfClient = New AplicacionWcfClient()
        dgvServidorAplicacion.DataSource = aplicacionWcfClient.SelecccionarAplicacion(cboProveedor.SelectedValue)

        dgvServidorAplicacion.Columns("proveedorId").Visible = False
        dgvServidorAplicacion.Columns("ServidorId").Visible = False
        dgvServidorAplicacion.Columns("Id").Visible = False
    End Sub

End Class