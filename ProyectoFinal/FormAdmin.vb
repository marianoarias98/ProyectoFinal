Imports CapaNegocios
Imports System.IO
Imports System.Drawing.Imaging
Public Class FormAdmin

    Dim persona As New CapaNE

    ''GESTION EMPLEADOS
    Private Sub BVerTodoEmpleados_Click(sender As Object, e As EventArgs) Handles BVerTodoEmpleados.Click
        DGVEmpleados.DataSource = persona.SeleccionarEmpleado()
    End Sub

    Private Sub BFotoEmpleados_Click(sender As Object, e As EventArgs) Handles BFotoEmpleados.Click
        Dim dialgo As New OpenFileDialog
        dialgo.Filter = "images|*.jpg;*.png;*.gif;*.bmp"

        If dialgo.ShowDialog = Windows.Forms.DialogResult.OK Then
            PBFotoEmpleado.Image = Image.FromFile(dialgo.FileName)
        End If

    End Sub

    Private Sub BAltaEmpleadaEmpleados_Click(sender As Object, e As EventArgs) Handles BAltaEmpleadaEmpleados.Click
        Dim memorystream As New MemoryStream
        PBFotoEmpleado.Image.Save(memorystream, PBFotoEmpleado.Image.RawFormat)
        persona.AltaEmpleado(TBNombreEmpleado.Text, TBApellidoEmpleado.Text, TBDocumentoEmpleado.Text, DTPNacimientoEmpleado.Value, TBDireccionEmpleado.Text, "12345", memorystream.ToArray)
        DGVEmpleados.DataSource = persona.SeleccionarEmpleado()
    End Sub

    Private Sub BBajaEmpleado_Click(sender As Object, e As EventArgs) Handles BBajaEmpleado.Click
        persona.EliminarEmpleado(DGVEmpleados.CurrentRow.Cells(0).Value)
        DGVEmpleados.DataSource = persona.SeleccionarEmpleado()
    End Sub

    Private Sub BTraerDatosEmpleado_Click(sender As Object, e As EventArgs) Handles BTraerDatosEmpleado.Click
        TBNombreEmpleado.Text = DGVEmpleados.CurrentRow.Cells(1).Value
        TBApellidoEmpleado.Text = DGVEmpleados.CurrentRow.Cells(2).Value
        TBDocumentoEmpleado.Text = DGVEmpleados.CurrentRow.Cells(3).Value
        DTPNacimientoEmpleado.Value = DGVEmpleados.CurrentRow.Cells(4).Value
        TBDireccionEmpleado.Text = DGVEmpleados.CurrentRow.Cells(5).Value
        Dim var As Byte() = persona.BusquedaEmpleado(DGVEmpleados.CurrentRow.Cells(0).Value).Rows(0)(7)
        Dim ms As New MemoryStream(var)
        PBFotoEmpleado.Image = Image.FromStream(ms)

    End Sub

    Private Sub BActualizarEmpleados_Click(sender As Object, e As EventArgs) Handles BActualizarEmpleados.Click
        persona.ModificacionEmpleado(DGVEmpleados.CurrentRow.Cells(0).Value, TBNombreEmpleado.Text, TBApellidoEmpleado.Text, TBDocumentoEmpleado.Text, DTPNacimientoEmpleado.Value, TBDireccionEmpleado.Text)
        DGVEmpleados.DataSource = persona.SeleccionarEmpleado()
    End Sub

    'GESTION CLIENTES
    Private Sub BTFotoCliente_Click(sender As Object, e As EventArgs) Handles BTFotoCliente.Click
        Dim dialgo As New OpenFileDialog
        dialgo.Filter = "images|*.jpg;*.png;*.gif;*.bmp"

        If dialgo.ShowDialog = Windows.Forms.DialogResult.OK Then
            PBFotoCliente.Image = Image.FromFile(dialgo.FileName)
        End If
    End Sub
    Private Sub BTMostrarTodoCliente_Click(sender As Object, e As EventArgs) Handles BTMostrarTodoCliente.Click
        DGVClientes.DataSource = persona.SeleccionCliente()
    End Sub

    Private Sub BTAltaCliente_Click(sender As Object, e As EventArgs) Handles BTAltaCliente.Click
        Dim memorystream As New MemoryStream
        PBFotoCliente.Image.Save(memorystream, PBFotoCliente.Image.RawFormat)
        persona.AltaCliente(TBNombreCliente.Text, TBApellidoCliente.Text, TBDocumentoCliente.Text, DTPNacimientoCliente.Value, TBDireccionCliente.Text, "12345", memorystream.ToArray)
        DGVClientes.DataSource = persona.SeleccionCliente()
    End Sub
    Private Sub BTBajaCliente_Click(sender As Object, e As EventArgs) Handles BTBajaCliente.Click
        persona.EliminarClient(DGVClientes.CurrentRow.Cells(0).Value)
        DGVClientes.DataSource = persona.SeleccionCliente()
    End Sub

    Private Sub BTTrerDatosCliente_Click(sender As Object, e As EventArgs) Handles BTTrerDatosCliente.Click
        TBNombreCliente.Text = DGVClientes.CurrentRow.Cells(1).Value
        TBApellidoCliente.Text = DGVClientes.CurrentRow.Cells(2).Value
        TBDocumentoCliente.Text = DGVClientes.CurrentRow.Cells(3).Value
        DTPNacimientoCliente.Value = DGVClientes.CurrentRow.Cells(4).Value
        TBDireccionCliente.Text = DGVClientes.CurrentRow.Cells(5).Value
        Dim var As Byte() = persona.BusquedaCliente(DGVClientes.CurrentRow.Cells(0).Value).Rows(0)(7)
        Dim ms As New MemoryStream(var)
        PBFotoCliente.Image = Image.FromStream(ms)
    End Sub

    Private Sub BTActualizarCliente_Click(sender As Object, e As EventArgs) Handles BTActualizarCliente.Click
        persona.ModificacionCliente(DGVClientes.CurrentRow.Cells(0).Value, TBNombreCliente.Text, TBApellidoCliente.Text, TBDocumentoCliente.Text, DTPNacimientoCliente.Value, TBDireccionCliente.Text)
        DGVClientes.DataSource = persona.SeleccionCliente()
    End Sub

    'GESTION VEHICULO
    Private Sub BTFotoVehiculo_Click(sender As Object, e As EventArgs) Handles BTFotoVehiculo.Click
        Dim dialgo As New OpenFileDialog
        dialgo.Filter = "images|*.jpg;*.png;*.gif;*.bmp"

        If dialgo.ShowDialog = Windows.Forms.DialogResult.OK Then
            PBFotoVehiculo.Image = Image.FromFile(dialgo.FileName)
        End If

    End Sub
    Private Sub BTMostrarTodoVehiculo_Click(sender As Object, e As EventArgs) Handles BTMostrarTodoVehiculo.Click
        DGVVehiculos.DataSource = persona.SeleccionVehiculo()
    End Sub
    Private Sub BTAltaVehiculo_Click(sender As Object, e As EventArgs) Handles BTAltaVehiculo.Click
        Dim memorystream As New MemoryStream
        PBFotoVehiculo.Image.Save(memorystream, PBFotoVehiculo.Image.RawFormat)
        persona.AltaVehiculo(CBMarcaVehiculo.Text, TBModeloVehiculo.Text, TBAñoVehiculo.Text, TBMotorVehiculo.Text, TBPrecioVehiculo.Text, CBAsientosVehiculos.Text, CBTransmisionesVehiculos.Text, TBPesoVehiculo.Text, memorystream.ToArray, CBDisponibleVehiculo.Checked)
        DGVVehiculos.DataSource = persona.SeleccionVehiculo()
    End Sub
    Private Sub BTBajaVehiculo_Click(sender As Object, e As EventArgs) Handles BTBajaVehiculo.Click
        persona.EliminarVehiculo(DGVVehiculos.CurrentRow.Cells(0).Value)
        DGVVehiculos.DataSource = persona.SeleccionVehiculo()
    End Sub

    Private Sub BTTraerDatosVehiculos_Click(sender As Object, e As EventArgs) Handles BTTraerDatosVehiculos.Click
        CBMarcaVehiculo.Text = DGVVehiculos.CurrentRow.Cells(1).Value
        TBModeloVehiculo.Text = DGVVehiculos.CurrentRow.Cells(2).Value
        TBAñoVehiculo.Text = DGVVehiculos.CurrentRow.Cells(3).Value
        TBMotorVehiculo.Text = DGVVehiculos.CurrentRow.Cells(4).Value
        TBPrecioVehiculo.Text = DGVVehiculos.CurrentRow.Cells(5).Value
        CBAsientosVehiculos.Text = DGVVehiculos.CurrentRow.Cells(6).Value
        CBTransmisionesVehiculos.Text = DGVVehiculos.CurrentRow.Cells(7).Value
        TBPesoVehiculo.Text = DGVVehiculos.CurrentRow.Cells(8).Value
        Dim var As Byte() = persona.BusquedaVehiculo(DGVVehiculos.CurrentRow.Cells(0).Value).Rows(0)(9)
        Dim ms As New MemoryStream(var)
        PBFotoVehiculo.Image = Image.FromStream(ms)
        CBDisponibleVehiculo.Checked = DGVVehiculos.CurrentRow.Cells(9).Value
    End Sub

    Private Sub BTActualizar_Click(sender As Object, e As EventArgs) Handles BTActualizar.Click
        persona.ModificacionVehiculo(DGVVehiculos.CurrentRow.Cells(0).Value, CBMarcaVehiculo.Text, TBModeloVehiculo.Text, TBAñoVehiculo.Text, TBMotorVehiculo.Text, TBPrecioVehiculo.Text, CBAsientosVehiculos.Text, CBTransmisionesVehiculos.Text, TBPesoVehiculo.Text, CBDisponibleVehiculo.Checked)
        DGVVehiculos.DataSource = persona.SeleccionVehiculo
    End Sub

    'GESTION SOLICITUDES

    Private Sub BMostrarTodoSolicitud_Click(sender As Object, e As EventArgs) Handles BMostrarTodoSolicitud.Click
        DGVSolicitudes.DataSource = persona.SeleccionarSolicitud()
    End Sub

    Private Sub BAltaSolicitud_Click(sender As Object, e As EventArgs) Handles BAltaSolicitud.Click
        persona.AltaSolicitud(DGVClienteSolicitud.CurrentRow.Cells(0).Value, DGVVehiculoSolicitud.CurrentRow.Cells(0).Value, CBEstadoSolicitud.Text)
        DGVSolicitudes.DataSource = persona.SeleccionarSolicitud()
    End Sub

    'FORMULARIOS Y GROUP BOXS
    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVVehiculos.ForeColor = Color.White
        GBGestionSolicitudes.Hide()
        GBClientes.Hide()
        GBEmpleados.Hide()
        GBVeehiculos.Hide()
        DGVEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVClienteSolicitud.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVVehiculoSolicitud.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub BGBGestionEmpleados_Click(sender As Object, e As EventArgs) Handles BGBGestionEmpleados.Click
        GBClientes.Hide()
        GBClientes.Hide()
        GBGestionSolicitudes.Hide()
        GBEmpleados.Show()
    End Sub

    Private Sub GBGestionCliente_Click(sender As Object, e As EventArgs) Handles BTGestionClientes.Click
        GBGestionSolicitudes.Hide()
        GBEmpleados.Hide()
        GBVeehiculos.Hide()
        GBClientes.Show()
    End Sub

    Private Sub BTGestionVehiculos_Click(sender As Object, e As EventArgs) Handles BTGestionVehiculos.Click
        GBGestionSolicitudes.Hide()
        GBEmpleados.Hide()
        GBClientes.Hide()
        GBVeehiculos.Show()
    End Sub

    Private Sub BCerrarSesion_Click(sender As Object, e As EventArgs) Handles BCerrarSesion.Click
        Me.Hide()
    End Sub

    Private Sub BTGestionSolicitudes_Click(sender As Object, e As EventArgs) Handles BTGestionSolicitudes.Click
        GBGestionSolicitudes.Show()
        GBEmpleados.Hide()
        GBClientes.Hide()
        GBVeehiculos.Hide()
        CBEstadoSolicitud.Text = "Pendiente"
        DGVSolicitudes.DataSource = persona.SeleccionarSolicitud()
        DGVClienteSolicitud.DataSource = persona.SeleccionCliente
        DGVVehiculoSolicitud.DataSource = persona.SeleccionarVehiculoSolicitud
    End Sub


End Class
