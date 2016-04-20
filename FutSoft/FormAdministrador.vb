Public Class FormAdministrador

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Hide()
        FormLogin.Show()
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormUsuarioAlta.Show()
        Me.Hide()
    End Sub

    
End Class