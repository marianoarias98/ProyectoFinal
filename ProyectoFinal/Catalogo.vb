Imports CapaNegocios
Imports System.IO
Public Class Catalogo

    Dim vehiculo As New CapaNE

    Private Sub Catalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GBVerTodos.Hide()
        GBMasVenidos.Show()
        DGVVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        GBCatalogo.Hide()
    End Sub

    Private Sub BTVerMas_Click(sender As Object, e As EventArgs) Handles BTVerMas.Click
        GBCatalogo.Show()
        LMarcaModelo.Text = vehiculo.BusquedaVehiculo(DGVVehiculos.CurrentRow.Cells(0).Value).Rows(0)(1) + " " + vehiculo.BusquedaVehiculo(DGVVehiculos.CurrentRow.Cells(0).Value).Rows(0)(2)
        LAño.Text = "Año: " + vehiculo.BusquedaVehiculo(DGVVehiculos.CurrentRow.Cells(0).Value).Rows(0)(3).ToString
        LMotor.Text = "Motor: " + vehiculo.BusquedaVehiculo(DGVVehiculos.CurrentRow.Cells(0).Value).Rows(0)(4).ToString + " L"
        LPrecio.Text = "Precio: $" + vehiculo.BusquedaVehiculo(DGVVehiculos.CurrentRow.Cells(0).Value).Rows(0)(5).ToString
        LAsientos.Text = "Cant. Asientos: " + vehiculo.BusquedaVehiculo(DGVVehiculos.CurrentRow.Cells(0).Value).Rows(0)(6).ToString
        LVelocidad.Text = "Cant. Velocidades: " + vehiculo.BusquedaVehiculo(DGVVehiculos.CurrentRow.Cells(0).Value).Rows(0)(7).ToString
        LPeso.Text = "Peso: " + vehiculo.BusquedaVehiculo(DGVVehiculos.CurrentRow.Cells(0).Value).Rows(0)(8).ToString
        If vehiculo.BusquedaVehiculo(DGVVehiculos.CurrentRow.Cells(0).Value).Rows(0)(10).ToString() = True Then
            LStock.Text = "El vehiculo está DISPONIBLE"

        Else
            LStock.Text = "El vehiculo NO está DISPONIBLE"
        End If
        Dim var As Byte() = vehiculo.BusquedaVehiculo(DGVVehiculos.CurrentRow.Cells(0).Value).Rows(0)(9)
        Dim ms As New MemoryStream(var)
        PbFotoVehiculo.Image = Image.FromStream(ms)

    End Sub

    Private Sub CBFiltroNarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBFiltroNarca.SelectedIndexChanged
        DGVVehiculos.DataSource = vehiculo.BusquedaxMarcaVehiculo(CBFiltroNarca.Text)
    End Sub

    Private Sub CBPrecio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPrecio.SelectedIndexChanged
        Dim preciominimo As Integer
        Dim preciomaximo As Integer
        If CBPrecio.Text = "Menos de 2 Millones" Then
            preciominimo = 0
            preciomaximo = 1999999
        Else
            If CBPrecio.Text = "Menos de 3 Millones" Then
                preciominimo = 2000000
                preciomaximo = 2999999
            Else
                If CBPrecio.Text = "Menos de 4 Millones" Then
                    preciominimo = 3000000
                    preciomaximo = 3999999
                Else
                    preciominimo = 4000000
                    preciomaximo = 10000000
                End If
            End If

        End If
        DGVVehiculos.DataSource = vehiculo.BusquedaVehiculoPrecio(preciominimo, preciomaximo)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TBBusqueda.TextChanged
        DGVVehiculos.DataSource = vehiculo.BusquedaVehiculoxModelo(TBBusqueda.Text)
    End Sub

    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Me.Hide()
    End Sub

    Private Sub BVerTodos_Click(sender As Object, e As EventArgs) Handles BVerTodos.Click
        GBVerTodos.Show()
    End Sub

    Private Sub BMasVendido_Click(sender As Object, e As EventArgs) Handles BMasVendido.Click
        Dim var1 As Byte() = vehiculo.Masvendido().Rows(0)(1)
        Dim ms1 As New MemoryStream(var1)
        PBMasVendido1.Image = Image.FromStream(ms1)

        Dim var2 As Byte() = vehiculo.Masvendido().Rows(1)(1)
        Dim ms2 As New MemoryStream(var2)
        PBMasVendido2.Image = Image.FromStream(ms2)
    End Sub
End Class