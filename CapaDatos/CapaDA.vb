Imports System.Data.SqlClient
Public Class CapaDA
    Public ReadOnly Property RetornarCadena() As String
        Get
            Return "Server=DESKTOP-JM7Q6DD;Database=Concesionario;Trusted_Connection=True; "
        End Get
    End Property

    'GESTIÓN EMPLEADOS-----------------------------------------------------------------------------------
    Public Sub AltaEmpleado(Nombre As String, Apellido As String, Documento As Integer, FechaNacimiento As Date, Direccion As String, Contraseña As String, Foto As Array)
        Dim conexion As New SqlConnection(RetornarCadena)
        Dim comando As New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "Insert into Empleados Values (@Nombre, @Apellido, @Documento, @FechaNacimiento, @Direccion, @Contraseña, @Foto)"
        comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre
        comando.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = Apellido
        comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = Documento
        comando.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = FechaNacimiento
        comando.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Direccion
        comando.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = Contraseña
        comando.Parameters.Add("@Foto", SqlDbType.Image).Value = Foto

        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Sub ModificacionEmpleado(IdEmpleado As Integer, Nombre As String, Apellido As String, Documento As Integer, FechaNacimiento As Date, Direccion As String)
        Dim conexion As New SqlConnection(RetornarCadena)
        Dim comando As New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "Update Empleados set Nombre = '" & Nombre & "', Apellido = '" & Apellido & "', Documento = '" & Documento & "', FechaNacimiento = '" & FechaNacimiento & "', Direccion = '" & Direccion & "',  where IdEmpleado = '" & IdEmpleado & "'"
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Sub EliminarEmpleado(IdEmpleado As Integer)
        Dim conexion As New SqlConnection(RetornarCadena)
        Dim comando As New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "Delete FROM Empleados where IdEmpleado = '" & IdEmpleado & "'"
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Function SeleccionarEmpleado() As DataTable
        Dim consulta As String = "Select IdEmpleado, Nombre, Apellido, Documento, FechaNacimiento, Direccion FROM Empleados"
        Dim adaptador As New SqlDataAdapter(consulta, RetornarCadena)
        Dim tabla As New DataTable
        adaptador.Fill(tabla)
        Return tabla
    End Function

    Public Function BusquedaEmpleado(IdEmpleado As Integer) As DataTable
        Dim consulta As String = "Select * FROM Empleados where IdEmpleado = '" & IdEmpleado & "'"
        Dim adaptador As New SqlDataAdapter(consulta, RetornarCadena)
        Dim tabla As New DataTable
        adaptador.Fill(tabla)
        Return tabla
    End Function

    Public Function LoginEmpleado(Documento As Integer, Contraseña As String) As DataTable
        Dim consulta As String = "Select * FROM Empleados where Documento = '" & Documento & "' and Contraseña = '" & Contraseña & "'"
        Dim adaptador As New SqlDataAdapter(consulta, RetornarCadena)
        Dim tabla As New DataTable
        adaptador.Fill(tabla)
        Return tabla
    End Function



    'GESTIÓN CLIENTES-----------------------------------------------------------------------------------
    Public Sub AltaCliente(Nombre As String, Apellido As String, Documento As Integer, FechaNacimiento As Date, Direccion As String, Contraseña As String, Foto As Array)
        Dim conexion As New SqlConnection(RetornarCadena)
        Dim comando As New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "Insert into Clientes Values (@Nombre, @Apellido, @Documento, @FechaNacimiento, @Direccion, @Contraseña, @Foto)"
        comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre
        comando.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = Apellido
        comando.Parameters.Add("@Documento", SqlDbType.VarChar).Value = Documento
        comando.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = FechaNacimiento
        comando.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Direccion
        comando.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = Contraseña
        comando.Parameters.Add("@Foto", SqlDbType.Image).Value = Foto

        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Sub ModificacionCliente(IdEmpleado As Integer, Nombre As String, Apellido As String, Documento As Integer, FechaNacimiento As Date, Direccion As String)
        Dim conexion As New SqlConnection(RetornarCadena)
        Dim comando As New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "Update Clientes set Nombre = '" & Nombre & "', Apellido = '" & Apellido & "', Documento = '" & Documento & "', FechaNacimiento = '" & FechaNacimiento & "', Direccion = '" & Direccion & "' where IdCliente = '" & IdEmpleado & "'"
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Sub EliminarCliente(IdCliente As Integer)
        Dim conexion As New SqlConnection(RetornarCadena)
        Dim comando As New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "Delete FROM Clientes where IdCliente = '" & IdCliente & "'"
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Function SeleccionarCliente() As DataTable
        Dim consulta As String = "Select IdCliente,Nombre, Apellido, Documento, FechaNacimiento, Direccion FROM Clientes"
        Dim adaptador As New SqlDataAdapter(consulta, RetornarCadena)
        Dim tabla As New DataTable
        adaptador.Fill(tabla)
        Return tabla
    End Function

    Public Function BusquedaCliente(id As Integer) As DataTable
        Dim consulta As String = "Select * FROM Clientes where IdCliente = '" & id & "'"
        Dim adaptador As New SqlDataAdapter(consulta, RetornarCadena)
        Dim tabla As New DataTable
        adaptador.Fill(tabla)
        Return tabla
    End Function

    Public Function BusquedaClientexDNi(dni As Integer) As DataTable
        Dim consulta As String = "Select * FROM Clientes where Documento = '" & dni & "'"
        Dim adaptador As New SqlDataAdapter(consulta, RetornarCadena)
        Dim tabla As New DataTable
        adaptador.Fill(tabla)
        Return tabla
    End Function
    Public Function LoginCliente(Dni As Integer, Contraseña As String) As DataTable
        Dim consulta As String = "Select * FROM Clientes where Documento = '" & Dni & "' and Contraseña = '" & Contraseña & "'"
        Dim adaptador As New SqlDataAdapter(consulta, RetornarCadena)
        Dim tabla As New DataTable
        adaptador.Fill(tabla)
        Return tabla
    End Function

    'GESTIÓN VEHICULOS-----------------------------------------------------------------------------------

    Public Sub AltaVehiculo(Marca As String, Modelo As String, Año As Integer, Motor As Double, Precio As Integer, Asientos As Integer, Velocidades As Integer, Peso As Decimal, foto As Array, Disponible As Boolean)
        Dim conexion As New SqlConnection(RetornarCadena)
        Dim comando As New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "Insert into Vehiculos Values (@Marca, @Modelo, @Año, @Motor, @Precio, @Asientos, @Velocidades, @Peso, @Foto, @Disponible)"
        comando.Parameters.Add("@Marca", SqlDbType.VarChar).Value = Marca
        comando.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = Modelo
        comando.Parameters.Add("@Año", SqlDbType.Int).Value = Año
        comando.Parameters.Add("@Motor", SqlDbType.Decimal).Value = Motor
        comando.Parameters.Add("@Precio", SqlDbType.Int).Value = Precio
        comando.Parameters.Add("@Asientos", SqlDbType.Int).Value = Asientos
        comando.Parameters.Add("@Velocidades", SqlDbType.Int).Value = Velocidades
        comando.Parameters.Add("@Peso", SqlDbType.Decimal).Value = Peso
        comando.Parameters.Add("@Foto", SqlDbType.Image).Value = foto
        comando.Parameters.Add("@Disponible", SqlDbType.Bit).Value = Disponible
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Sub ModificacionVehiculo(idVehiculo As Integer, Marca As String, Modelo As String, Año As Integer, Motor As String, Precio As Integer, Asientos As String, Velocidades As Integer, Peso As Decimal, Disponible As Boolean)
        Dim conexion As New SqlConnection(RetornarCadena)
        Dim comando As New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "Update Vehiculos set Marca = '" & Marca & "', Modelo = '" & Modelo & "', Año = '" & Año & "', Motor = '" & Motor & "', Precio = '" & Precio & "', Asientos = '" & Asientos & "', Velocidades = '" & Velocidades & "', Peso = '" & Peso & "', Disponible = '" & Disponible & "' where IdVehiculo = '" & idVehiculo & "'"
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Sub EliminarVehiculo(IdVehiculo As Integer)
        Dim conexion As New SqlConnection(RetornarCadena)
        Dim comando As New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "Delete FROM Vehiculos where IdVehiculo = '" & IdVehiculo & "'"
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Function SeleccionVehiculo() As DataTable
        Dim consulta As String = "Select IdVehiculo, Marca, Modelo, Año, Motor, Precio, Asientos, Velocidades, Peso, Disponible FROM Vehiculos"
        Dim adaptador As New SqlDataAdapter(consulta, RetornarCadena)
        Dim tabla As New DataTable
        adaptador.Fill(tabla)
        Return tabla
    End Function

    Public Function BusquedaVehiculo(IdVehiculo As Integer) As DataTable
        Dim consulta As String = "Select * from Vehiculos where IdVehiculo = '" & IdVehiculo & "'"
        Dim adaptador As New SqlDataAdapter(consulta, RetornarCadena)
        Dim tabla As New DataTable
        adaptador.Fill(tabla)
        Return tabla
    End Function

    Public Function BusquedaxMarcaVehiculo(Marca As String) As DataTable
        Dim consulta As String = "Select IdVehiculo, Marca, Modelo, Año, Disponible from Vehiculos where Marca = '" & Marca & "'"
        Dim adaptador As New SqlDataAdapter(consulta, RetornarCadena)
        Dim tabla As New DataTable
        adaptador.Fill(tabla)
        Return tabla
    End Function

    Public Function BusquedaVehiculoPrecio(PrecioMinimo As Integer, PrecioMaximo As Integer) As DataTable
        Dim consulta As String = "Select IdVehiculo, Marca, Modelo, Año, Disponible from Vehiculos where Precio > '" & PrecioMinimo & "' and Precio < '" & PrecioMaximo & "'"
        Dim adaptador As New SqlDataAdapter(consulta, RetornarCadena)
        Dim tabla As New DataTable
        adaptador.Fill(tabla)
        Return tabla
    End Function

    Public Function BusquedaVehiculoxModelo(Modelo As String) As DataTable
        Dim consulta As String = "Select IdVehiculo, Marca, Modelo, Año, Disponible from Vehiculos where Modelo like '" & Modelo & "%'"
        Dim adaptador As New SqlDataAdapter(consulta, RetornarCadena)
        Dim tabla As New DataTable
        adaptador.Fill(tabla)
        Return tabla
    End Function

    Public Function MasVendidos() As DataTable
        Dim consulta As String = "Select IdEmpleado, Foto FROM Empleados "
        Dim adaptador As New SqlDataAdapter(consulta, RetornarCadena)
        Dim tabla As New DataTable
        adaptador.Fill(tabla)
        Return tabla
    End Function

    'GESTION SOLICITUDES

    Public Sub AltaSolicitud(Idcliente As Integer, Idvehiculo As Integer, Estado As String)
        Dim conexion As New SqlConnection(RetornarCadena)
        Dim comando As New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "Insert into Solicitudes values(@IdCliente, @IdVehiculo, @Estado)"
        comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = Idcliente
        comando.Parameters.Add("@IdVehiculo", SqlDbType.Int).Value = Idvehiculo
        comando.Parameters.Add("@Estado", SqlDbType.VarChar).Value = Estado

        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Sub EliminarSolicitud(IdSolicitud)
        Dim conexion As New SqlConnection(RetornarCadena)
        Dim comando As New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "Delete from Solicitud where IdSolicitud = '" & IdSolicitud & "'"

        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Sub ModificarSolicitud(IdSolicitud As Integer, Idcliente As Integer, Idvehiculo As Integer, Estado As Integer)
        Dim conexion As New SqlConnection(RetornarCadena)
        Dim comando As New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "Update Solicitud set IdCliente = '" & Idcliente & "', IdVehiculo = '" & Idvehiculo & "', Estado = '" & Estado & "' where IdSolicitud = '" & IdSolicitud & "'"

        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Sub ModificarEstadoSolicitud(IdSolicitud As Integer, Estado As String)
        Dim conexion As New SqlConnection(RetornarCadena)
        Dim comando As New SqlCommand
        comando.Connection = conexion
        comando.CommandText = "Update Solicitud set Estado = '" & Estado & "' where Id = '" & IdSolicitud & "'"

        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Function SeleccionarSolicitud() As DataTable
        Dim consulta As String = "Select * from Solicitudes "
        Dim adaptador As New SqlDataAdapter(consulta, RetornarCadena)
        Dim tabla As New DataTable
        adaptador.Fill(tabla)
        Return tabla
    End Function

    Public Function SeleccionarVehiculoSolicitud() As DataTable
        Dim consulta As String = "Select IdVehiculo, Marca, Modelo, Año, Disponible FROM Vehiculos"
        Dim adaptador As New SqlDataAdapter(consulta, RetornarCadena)
        Dim tabla As New DataTable
        adaptador.Fill(tabla)
        Return tabla
    End Function

    Public Function BusquedasolicitudxIdCliente(IdCliente As Integer) As DataTable
        Dim consulta As String = "Select * from Solicitudes where IdCliente = '" & IdCliente & "'"
        Dim adaptador As New SqlDataAdapter(consulta, RetornarCadena)
        Dim tabla As New DataTable
        adaptador.Fill(tabla)
        Return tabla
    End Function
End Class
