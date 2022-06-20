Imports CapaNegocios
Imports System.IO
Public Class FormEmpleado

    Dim persona As New CapaNE

    Dim dni As Integer
    Private Sub FormEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LDocumento.Text = "Dni: " + FormLogin.TBDocumento.Text
        LNombreApellido.Text = "Bienvenido: " + persona.LoginEmpleado(FormLogin.TBDocumento.Text, FormLogin.TBContreaseña.Text).Rows(0)(1) + " " + persona.LoginEmpleado(FormLogin.TBDocumento.Text, FormLogin.TBContreaseña.Text).Rows(0)(2)
        LFechaNacimiento.Text = "Fecha de Nacimiento: " + persona.LoginEmpleado(FormLogin.TBDocumento.Text, FormLogin.TBContreaseña.Text).Rows(0)(4)
        LDireccion.Text = "Direccion: " + persona.LoginEmpleado(FormLogin.TBDocumento.Text, FormLogin.TBContreaseña.Text).Rows(0)(5)
        Dim var As Byte() = persona.LoginEmpleado(FormLogin.TBDocumento.Text, FormLogin.TBContreaseña.Text).Rows(0)(7)
        Dim ms As New MemoryStream(var)
        PBFoto.Image = Image.FromStream(ms)
    End Sub


End Class