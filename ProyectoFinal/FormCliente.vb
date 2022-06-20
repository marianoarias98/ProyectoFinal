Imports CapaNegocios
Public Class FormCliente

    Dim cliente As New CapaNE
    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LIdCliente.Text = cliente.BusquedaClientexDNi(FormLogin.TBDocumento.Text).Rows(0)(0).ToString
        GBVerSolicitudes.Hide()
        'LNumeroSolicitudes.Text =

    End Sub

    Private Sub BVerCatalogo_Click(sender As Object, e As EventArgs) Handles BVerCatalogo.Click
        Catalogo.Show()
    End Sub

    Private Sub BVerSolicitudes_Click(sender As Object, e As EventArgs) Handles BVerSolicitudes.Click
        GBVerSolicitudes.Show()
        cliente.BusquedasolicitudxIdCliente(LIdCliente.Text)
        DGVVerSolicitudes.DataSource = cliente.BusquedasolicitudxIdCliente(LIdCliente.Text)
    End Sub

End Class