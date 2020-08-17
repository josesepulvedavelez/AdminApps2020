Imports AdminAppsDesktop.ServicioLogin
Imports Entidades

Public Class FrmUsuario
    Dim usuarioENT As UsuarioENT
    Dim usuarioWcfCliente As UsuarioWcfClient
    Dim res As Boolean

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        usuarioENT = New UsuarioENT()
        usuarioENT.Usuario = txtUsuario.Text
        usuarioENT.Contraseña = txtContraseña.Text

        usuarioWcfCliente = New UsuarioWcfClient()
        res = usuarioWcfCliente.Ingresar(usuarioENT)

        If res = True Then
            FrmMenu.Show()
            FrmMenu.lblUsuario.Text = usuarioENT.Usuario
        Else
            MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS", Application.ProductName & "" & Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class