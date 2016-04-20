<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistroEquipo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistroEquipo))
        Me.Cerrar = New System.Windows.Forms.Label()
        Me.LabCerrarSecion = New System.Windows.Forms.Label()
        Me.Volver = New System.Windows.Forms.Label()
        Me.PicBoxEscudo = New System.Windows.Forms.PictureBox()
        Me.ComBoxCategaria = New System.Windows.Forms.ComboBox()
        Me.txtJugadores = New System.Windows.Forms.TextBox()
        Me.txtNomEquipo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabEquipos = New System.Windows.Forms.Label()
        Me.Escudo = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComBoxLiga = New System.Windows.Forms.ComboBox()
        Me.BtnBuscarEscudo = New System.Windows.Forms.Button()
        Me.labNombreCapitan = New System.Windows.Forms.Label()
        Me.TxtNombreCapitan = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PicBoxEscudo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cerrar
        '
        Me.Cerrar.AutoSize = True
        Me.Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cerrar.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Cerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Cerrar.Location = New System.Drawing.Point(933, -1)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(23, 24)
        Me.Cerrar.TabIndex = 18
        Me.Cerrar.Text = "X"
        '
        'LabCerrarSecion
        '
        Me.LabCerrarSecion.AutoSize = True
        Me.LabCerrarSecion.BackColor = System.Drawing.Color.Transparent
        Me.LabCerrarSecion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabCerrarSecion.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCerrarSecion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabCerrarSecion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabCerrarSecion.Location = New System.Drawing.Point(818, 2)
        Me.LabCerrarSecion.Name = "LabCerrarSecion"
        Me.LabCerrarSecion.Size = New System.Drawing.Size(109, 21)
        Me.LabCerrarSecion.TabIndex = 19
        Me.LabCerrarSecion.Text = "Cerrar sesión"
        '
        'Volver
        '
        Me.Volver.AutoSize = True
        Me.Volver.BackColor = System.Drawing.Color.Transparent
        Me.Volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Volver.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Volver.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Volver.Location = New System.Drawing.Point(0, -1)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(24, 24)
        Me.Volver.TabIndex = 23
        Me.Volver.Text = "<"
        '
        'PicBoxEscudo
        '
        Me.PicBoxEscudo.BackColor = System.Drawing.Color.Transparent
        Me.PicBoxEscudo.Image = CType(resources.GetObject("PicBoxEscudo.Image"), System.Drawing.Image)
        Me.PicBoxEscudo.Location = New System.Drawing.Point(67, 155)
        Me.PicBoxEscudo.Name = "PicBoxEscudo"
        Me.PicBoxEscudo.Size = New System.Drawing.Size(162, 152)
        Me.PicBoxEscudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBoxEscudo.TabIndex = 24
        Me.PicBoxEscudo.TabStop = False
        '
        'ComBoxCategaria
        '
        Me.ComBoxCategaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComBoxCategaria.FormattingEnabled = True
        Me.ComBoxCategaria.Items.AddRange(New Object() {"Infantil", "Juvenil", "Mixto", "Veterano"})
        Me.ComBoxCategaria.Location = New System.Drawing.Point(494, 291)
        Me.ComBoxCategaria.Name = "ComBoxCategaria"
        Me.ComBoxCategaria.Size = New System.Drawing.Size(121, 28)
        Me.ComBoxCategaria.TabIndex = 67
        Me.ComBoxCategaria.Text = "--Seleccione--"
        '
        'txtJugadores
        '
        Me.txtJugadores.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJugadores.Location = New System.Drawing.Point(494, 243)
        Me.txtJugadores.Name = "txtJugadores"
        Me.txtJugadores.Size = New System.Drawing.Size(42, 28)
        Me.txtJugadores.TabIndex = 62
        '
        'txtNomEquipo
        '
        Me.txtNomEquipo.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomEquipo.Location = New System.Drawing.Point(494, 197)
        Me.txtNomEquipo.Name = "txtNomEquipo"
        Me.txtNomEquipo.Size = New System.Drawing.Size(179, 28)
        Me.txtNomEquipo.TabIndex = 61
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(371, 299)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 20)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Categoría :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(276, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 20)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Número de Jugadores :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(302, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Nombre del Equipo:"
        '
        'LabEquipos
        '
        Me.LabEquipos.AutoSize = True
        Me.LabEquipos.BackColor = System.Drawing.Color.Transparent
        Me.LabEquipos.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.25!, System.Drawing.FontStyle.Bold)
        Me.LabEquipos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabEquipos.Location = New System.Drawing.Point(264, 70)
        Me.LabEquipos.Name = "LabEquipos"
        Me.LabEquipos.Size = New System.Drawing.Size(272, 35)
        Me.LabEquipos.TabIndex = 68
        Me.LabEquipos.Text = "Registro de equipos"
        '
        'Escudo
        '
        Me.Escudo.AutoSize = True
        Me.Escudo.BackColor = System.Drawing.Color.Transparent
        Me.Escudo.Font = New System.Drawing.Font("Microsoft JhengHei UI", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Escudo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Escudo.Location = New System.Drawing.Point(97, 310)
        Me.Escudo.Name = "Escudo"
        Me.Escudo.Size = New System.Drawing.Size(108, 35)
        Me.Escudo.TabIndex = 69
        Me.Escudo.Text = "Escudo"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(920, 490)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 72
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(876, 473)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 36)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Fut"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(911, 511)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 26)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Soft"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(422, 355)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Liga"
        '
        'ComBoxLiga
        '
        Me.ComBoxLiga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComBoxLiga.FormattingEnabled = True
        Me.ComBoxLiga.Location = New System.Drawing.Point(494, 347)
        Me.ComBoxLiga.Name = "ComBoxLiga"
        Me.ComBoxLiga.Size = New System.Drawing.Size(121, 28)
        Me.ComBoxLiga.TabIndex = 74
        Me.ComBoxLiga.Text = "--Seleccione--"
        '
        'BtnBuscarEscudo
        '
        Me.BtnBuscarEscudo.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscarEscudo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.BtnBuscarEscudo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnBuscarEscudo.Location = New System.Drawing.Point(48, 355)
        Me.BtnBuscarEscudo.Name = "BtnBuscarEscudo"
        Me.BtnBuscarEscudo.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarEscudo.TabIndex = 75
        Me.BtnBuscarEscudo.Text = "Buscar"
        Me.BtnBuscarEscudo.UseVisualStyleBackColor = False
        '
        'labNombreCapitan
        '
        Me.labNombreCapitan.AutoSize = True
        Me.labNombreCapitan.BackColor = System.Drawing.Color.Transparent
        Me.labNombreCapitan.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.labNombreCapitan.Location = New System.Drawing.Point(327, 401)
        Me.labNombreCapitan.Name = "labNombreCapitan"
        Me.labNombreCapitan.Size = New System.Drawing.Size(135, 20)
        Me.labNombreCapitan.TabIndex = 76
        Me.labNombreCapitan.Text = "Nombre Capitan"
        '
        'TxtNombreCapitan
        '
        Me.TxtNombreCapitan.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtNombreCapitan.Location = New System.Drawing.Point(494, 393)
        Me.TxtNombreCapitan.Name = "TxtNombreCapitan"
        Me.TxtNombreCapitan.Size = New System.Drawing.Size(179, 28)
        Me.TxtNombreCapitan.TabIndex = 77
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGuardar.Location = New System.Drawing.Point(362, 464)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 27)
        Me.btnGuardar.TabIndex = 78
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNuevo.Location = New System.Drawing.Point(494, 464)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(100, 27)
        Me.btnNuevo.TabIndex = 79
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnAgregar.Location = New System.Drawing.Point(154, 355)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 80
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(103, 429)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(68, 62)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 81
        Me.PictureBox4.TabStop = False
        '
        'FormRegistroEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(956, 537)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.TxtNombreCapitan)
        Me.Controls.Add(Me.labNombreCapitan)
        Me.Controls.Add(Me.BtnBuscarEscudo)
        Me.Controls.Add(Me.ComBoxLiga)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Escudo)
        Me.Controls.Add(Me.LabEquipos)
        Me.Controls.Add(Me.ComBoxCategaria)
        Me.Controls.Add(Me.txtJugadores)
        Me.Controls.Add(Me.txtNomEquipo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PicBoxEscudo)
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.LabCerrarSecion)
        Me.Controls.Add(Me.Cerrar)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRegistroEquipo"
        Me.Text = "FormRegistroEquipo"
        CType(Me.PicBoxEscudo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cerrar As System.Windows.Forms.Label
    Friend WithEvents LabCerrarSecion As System.Windows.Forms.Label
    Friend WithEvents Volver As System.Windows.Forms.Label
    Friend WithEvents PicBoxEscudo As System.Windows.Forms.PictureBox
    Friend WithEvents ComBoxCategaria As System.Windows.Forms.ComboBox
    Friend WithEvents txtJugadores As System.Windows.Forms.TextBox
    Friend WithEvents txtNomEquipo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabEquipos As System.Windows.Forms.Label
    Friend WithEvents Escudo As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComBoxLiga As System.Windows.Forms.ComboBox
    Friend WithEvents BtnBuscarEscudo As System.Windows.Forms.Button
    Friend WithEvents labNombreCapitan As System.Windows.Forms.Label
    Friend WithEvents TxtNombreCapitan As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
