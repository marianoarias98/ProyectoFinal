Imports CapaDatos
Public Class CapaNE

    Dim registro As New CapaDA

    Public Sub AltaEmpleado(Nombre As String, Apellido As String, Documento As Integer, FechaNacimiento As Date, Direccion As String, Contraseña As String, Foto As Array)
        registro.AltaEmpleado(Nombre, Apellido, Documento, FechaNacimiento, Direccion, Contraseña, Foto)
    End Sub

    Public Function SeleccionarEmpleado() As DataTable
        Return registro.SeleccionarEmpleado
    End Function

    Public Sub EliminarEmpleado(IdEmpleado As Integer)
        registro.EliminarEmpleado(IdEmpleado)
    End Sub

    Public Sub ModificacionEmpleado(IdEmpleado As Integer, Nombre As String, Apellido As String, Documento As Integer, FechaNacimiento As Date, Direccion As String)
        registro.ModificacionEmpleado(IdEmpleado, Nombre, Apellido, Documento, FechaNacimiento, Direccion)
    End Sub

    Public Function BusquedaEmpleado(IdEmpleado As Integer) As DataTable
        Return registro.BusquedaEmpleado(IdEmpleado)
    End Function

    Public Function LoginEmpleado(documento As Integer, Contraseña As String) As DataTable
        Return registro.LoginEmpleado(documento, Contraseña)
    End Function


    Public Sub AltaCliente(Nombre As String, Apellido As String, Documento As Integer, FechaNacimiento As Date, Direccion As String, Contraseña As String, Foto As Array)
        registro.AltaCliente(Nombre, Apellido, Documento, FechaNacimiento, Direccion, Contraseña, Foto)
    End Sub

    Public Function SeleccionCliente() As DataTable
        Return registro.SeleccionarCliente
    End Function
    Public Function BusquedaCliente(id As Integer) As DataTable
        Return registro.BusquedaCliente(id)
    End Function

    Public Function BusquedaClientexDNi(dni As Integer) As DataTable
        Return registro.BusquedaClientexDNi(dni)
    End Function
    Public Sub EliminarClient(idcliente As Integer)
        registro.EliminarCliente(idcliente)
    End Sub

    Public Sub ModificacionCliente(IdEmpleado As Integer, Nombre As String, Apellido As String, Documento As Integer, FechaNacimiento As Date, Direccion As String)
        registro.ModificacionCliente(IdEmpleado, Nombre, Apellido, Documento, FechaNacimiento, Direccion)
    End Sub

    Public Function LoginCliente(Dni As Integer, Contraseña As String) As DataTable
        Return registro.LoginCliente(Dni, Contraseña)
    End Function

    Public Sub AltaVehiculo(Marca As String, Modelo As String, Año As Integer, Motor As Double, Precio As Integer, Asientos As Integer, Velocidades As Integer, Peso As Decimal, foto As Array, Disponible As Boolean)
        registro.AltaVehiculo(Marca, Modelo, Año, Motor, Precio, Asientos, Velocidades, Peso, foto, Disponible)
    End Sub

    Public Function SeleccionVehiculo() As DataTable
        Return registro.SeleccionVehiculo
    End Function

    Public Sub EliminarVehiculo(idvehiculo As Integer)
        registro.EliminarVehiculo(idvehiculo)
    End Sub

    Public Sub ModificacionVehiculo(idVehiculo As Integer, Marca As String, Modelo As String, Año As Integer, Motor As String, Precio As Integer, Asientos As String, Velocidades As Integer, Peso As Decimal, Disponible As Boolean)
        registro.ModificacionVehiculo(idVehiculo, Marca, Modelo, Año, Motor, Precio, Asientos, Velocidades, Peso, Disponible)
    End Sub

    Public Function BusquedaVehiculo(idvehiculo As Integer) As DataTable
        Return registro.BusquedaVehiculo(idvehiculo)
    End Function

    Public Function BusquedaxMarcaVehiculo(Marca As String) As DataTable
        Return registro.BusquedaxMarcaVehiculo(Marca)
    End Function

    Public Function BusquedaVehiculoPrecio(PrecioMinimo As Integer, PrecioMaximo As Integer) As DataTable
        Return registro.BusquedaVehiculoPrecio(PrecioMinimo, PrecioMaximo)
    End Function

    Public Function BusquedaVehiculoxModelo(Modelo As String) As DataTable
        Return registro.BusquedaVehiculoxModelo(Modelo)
    End Function

    Public Function Masvendido() As DataTable
        Return registro.MasVendidos
    End Function

    Public Sub AltaSolicitud(Idcliente As Integer, Idvehiculo As Integer, Estado As String)
        registro.AltaSolicitud(Idcliente, Idvehiculo, Estado)
    End Sub

    Public Sub EliminarSolicitud(IdSolicitud)
        registro.EliminarSolicitud(IdSolicitud)
    End Sub

    Public Sub ModificarSolicitud(IdSolicitud As Integer, Idcliente As Integer, Idvehiculo As Integer, Estado As Integer)
        registro.ModificarSolicitud(IdSolicitud, Idcliente, Idvehiculo, Estado)
    End Sub

    Public Sub ModificarEstadoSolicitud(IdSolicitud As Integer, Estado As String)
        registro.ModificarEstadoSolicitud(IdSolicitud, Estado)
    End Sub

    Public Function SeleccionarSolicitud() As DataTable
        Return registro.SeleccionarSolicitud
    End Function

    Public Function SeleccionarVehiculoSolicitud() As DataTable
        Return registro.SeleccionarVehiculoSolicitud
    End Function

    Public Function BusquedasolicitudxIdCliente(IdCliente As Integer) As DataTable
        Return registro.BusquedasolicitudxIdCliente(IdCliente)
    End Function
End Class
