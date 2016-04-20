Public Class FormLogin

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        End
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Hide()
        FormInicio.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FormAdministrador.Show()
        Me.Hide()
    End Sub

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        FormMenu.Show()
        Me.Hide()
    End Sub
End Class