<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReguistrosJugadores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReguistrosJugadores))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabFoto = New System.Windows.Forms.Label()
        Me.WebCam1 = New WebCAM.WebCam()
        Me.BtnCapturar = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.LabAtras = New System.Windows.Forms.Label()
        Me.Cerrar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(35, 73)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(194, 193)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(205, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 35)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Registro Jugador"
        '
        'LabFoto
        '
        Me.LabFoto.AutoSize = True
        Me.LabFoto.BackColor = System.Drawing.Color.Transparent
        Me.LabFoto.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.25!, System.Drawing.FontStyle.Bold)
        Me.LabFoto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabFoto.Location = New System.Drawing.Point(94, 257)
        Me.LabFoto.Name = "LabFoto"
        Me.LabFoto.Size = New System.Drawing.Size(74, 35)
        Me.LabFoto.TabIndex = 21
        Me.LabFoto.Text = "Foto"
        '
        'WebCam1
        '
        Me.WebCam1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WebCam1.Imagen = Nothing
        Me.WebCam1.Location = New System.Drawing.Point(35, 73)
        Me.WebCam1.MilisegundosCaptura = 100
        Me.WebCam1.Name = "WebCam1"
        Me.WebCam1.Size = New System.Drawing.Size(194, 193)
        Me.WebCam1.TabIndex = 22
        '
        'BtnCapturar
        '
        Me.BtnCapturar.Location = New System.Drawing.Point(100, 312)
        Me.BtnCapturar.Name = "BtnCapturar"
        Me.BtnCapturar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCapturar.TabIndex = 24
        Me.BtnCapturar.Text = "Capturar"
        Me.BtnCapturar.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Imagen *.jpg| *.jpg"
        '
        'LabAtras
        '
        Me.LabAtras.AutoSize = True
        Me.LabAtras.BackColor = System.Drawing.Color.Transparent
        Me.LabAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabAtras.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabAtras.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabAtras.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabAtras.Location = New System.Drawing.Point(-2, -1)
        Me.LabAtras.Name = "LabAtras"
        Me.LabAtras.Size = New System.Drawing.Size(32, 25)
        Me.LabAtras.TabIndex = 25
        Me.LabAtras.Text = "< "
        '
        'Cerrar
        '
        Me.Cerrar.AutoSize = True
        Me.Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cerrar.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Cerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Cerrar.Location = New System.Drawing.Point(935, 0)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(23, 24)
        Me.Cerrar.TabIndex = 26
        Me.Cerrar.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(820, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 21)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Cerrar sesión"
        '
        'FormReguistrosJugadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(956, 537)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cerrar)
        Me.Controls.Add(Me.LabAtras)
        Me.Controls.Add(Me.BtnCapturar)
        Me.Controls.Add(Me.LabFoto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.WebCam1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormReguistrosJugadores"
        Me.Text = "FormRegustrosJugadores"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabFoto As System.Windows.Forms.Label
    Friend WithEvents WebCam1 As WebCAM.WebCam
    Friend WithEvents BtnCapturar As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LabAtras As System.Windows.Forms.Label
    Friend WithEvents Cerrar As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
