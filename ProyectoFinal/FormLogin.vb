Imports CapaNegocios
Public Class FormLogin
    Dim tiempo As Integer
    Dim persona As New CapaNE
    Private Sub BEntrar_Click(sender As Object, e As EventArgs) Handles BEntrar.Click
        If TBDocumento.Text = "1234" And TBContreaseña.Text = "1234" Then
            FormAdmin.Show()
        Else
            If persona.LoginEmpleado(TBDocumento.Text, TBContreaseña.Text).Rows.Count <> 0 Then
                FormEmpleado.Show()
            Else

                If persona.LoginCliente(TBDocumento.Text, TBContreaseña.Text).Rows.Count <> 0 Then
                    FormCliente.Show()
                End If
            End If
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 1000
        Player.BringToFront()
        Player.uiMode = "none"
        Player.URL = "C:\Users\maria\source\repos\ProyectoFinal\ProyectoFinal\Video\video_intro.mp4"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tiempo = tiempo + 1

        If tiempo = 11 Then
            Player.Ctlcontrols.stop()
            Player.Hide()
        End If
    End Sub
End Class