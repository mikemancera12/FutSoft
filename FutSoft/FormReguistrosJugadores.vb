Public Class FormReguistrosJugadores

    Private Sub LabFoto_Click(sender As Object, e As EventArgs) Handles LabFoto.Click
        WebCam1.Visible = True
        PictureBox2.Visible = False
        WebCam1.Start()
        WebCam1.Start()
    End Sub



    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnCapturar.Click
        PictureBox2.Image = WebCam1.Imagen
        SaveFileDialog1.ShowDialog()
        PictureBox2.Image.Save(SaveFileDialog1.FileName)
        PictureBox2.Visible = True
        WebCam1.Refresh()

    End Sub

    Private Sub FormRegustrosJugadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebCam1.Visible = False
    End Sub


    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        End
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        FormLogin.Show()

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        WebCam1.Visible = True
        PictureBox2.Visible = False
        WebCam1.Start()
        WebCam1.Start()
    End Sub

    Private Sub LabAtras_Click(sender As Object, e As EventArgs) Handles LabAtras.Click
        Me.Hide()
        FormMenu.Show()
    End Sub
End Class