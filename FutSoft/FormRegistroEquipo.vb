Public Class FormRegistroEquipo

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Hide()
        FormMenu.Show()
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        End
    End Sub

    Private Sub LabCerrarSecion_Click(sender As Object, e As EventArgs) Handles LabCerrarSecion.Click
        Me.Hide()
        FormLogin.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PicBoxEscudo.Click

    End Sub

    Private Sub BtnBuscarEscudo_Click(sender As Object, e As EventArgs) Handles BtnBuscarEscudo.Click
        Try
            System.Diagnostics.Process.Start("https://www.google.com.mx/search?q=escudos+de+futbol&biw=1366&bih=681&source=lnms&tbm=isch&sa=X&ved=0ahUKEwinpvmwnp7MAhUinIMKHXD4CaYQ_AUIBigB")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        OpenFileDialog1.InitialDirectory = "C:\Users\Ringo"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PicBoxEscudo.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNomEquipo.Clear()
        txtJugadores.Clear()
        ComBoxCategaria.Text = "--Seleccione--"
        ComBoxLiga.Text = "--Seleccione--"
        TxtNombreCapitan.Clear()
        PicBoxEscudo.ImageLocation = ("C:\Users\Ringo\Documents\Visual Studio 2013\Projects\FutSoft\FutSoft\Resources\equpo.jpg")

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        FormMenu.Show()
    End Sub
End Class