<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MiCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MiCuenta))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.poblacion = New System.Windows.Forms.TextBox()
        Me.movil = New System.Windows.Forms.TextBox()
        Me.codigo_postal = New System.Windows.Forms.TextBox()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.provincia = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.edad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dni = New System.Windows.Forms.TextBox()
        Me.contraseña = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Nombreee = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.borrarFoto = New System.Windows.Forms.Button()
        Me.añadir = New System.Windows.Forms.Button()
        Me.fotografia = New System.Windows.Forms.PictureBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.AbrirFoto = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.fotografia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.Proyecto_Tienda_PcComponentes.My.Resources.Resources.BannerPcComponentes2
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(901, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Javanese Text", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(425, 556)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mi Cuenta"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.poblacion)
        Me.GroupBox4.Controls.Add(Me.movil)
        Me.GroupBox4.Controls.Add(Me.codigo_postal)
        Me.GroupBox4.Controls.Add(Me.direccion)
        Me.GroupBox4.Controls.Add(Me.provincia)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 289)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(411, 256)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dirección de envio"
        '
        'poblacion
        '
        Me.poblacion.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.poblacion.Location = New System.Drawing.Point(172, 78)
        Me.poblacion.Name = "poblacion"
        Me.poblacion.ReadOnly = True
        Me.poblacion.Size = New System.Drawing.Size(217, 38)
        Me.poblacion.TabIndex = 4
        '
        'movil
        '
        Me.movil.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.movil.Location = New System.Drawing.Point(172, 210)
        Me.movil.Name = "movil"
        Me.movil.ReadOnly = True
        Me.movil.Size = New System.Drawing.Size(217, 38)
        Me.movil.TabIndex = 13
        '
        'codigo_postal
        '
        Me.codigo_postal.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.codigo_postal.Location = New System.Drawing.Point(172, 166)
        Me.codigo_postal.Name = "codigo_postal"
        Me.codigo_postal.ReadOnly = True
        Me.codigo_postal.Size = New System.Drawing.Size(217, 38)
        Me.codigo_postal.TabIndex = 10
        '
        'direccion
        '
        Me.direccion.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.direccion.Location = New System.Drawing.Point(172, 122)
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Size = New System.Drawing.Size(217, 38)
        Me.direccion.TabIndex = 7
        '
        'provincia
        '
        Me.provincia.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.provincia.Location = New System.Drawing.Point(172, 34)
        Me.provincia.Name = "provincia"
        Me.provincia.ReadOnly = True
        Me.provincia.Size = New System.Drawing.Size(217, 38)
        Me.provincia.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 45)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Móvil:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 45)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Codigo Postal:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 45)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Población:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 45)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Dirección:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 45)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Provincia:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.edad)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.dni)
        Me.GroupBox3.Controls.Add(Me.contraseña)
        Me.GroupBox3.Controls.Add(Me.email)
        Me.GroupBox3.Controls.Add(Me.Nombre)
        Me.GroupBox3.Controls.Add(Me.Nombreee)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(411, 256)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de cuenta y personales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 45)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Edad:"
        '
        'edad
        '
        Me.edad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edad.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.edad.Location = New System.Drawing.Point(172, 210)
        Me.edad.Name = "edad"
        Me.edad.ReadOnly = True
        Me.edad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edad.Size = New System.Drawing.Size(217, 38)
        Me.edad.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 45)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "DNI:"
        '
        'dni
        '
        Me.dni.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dni.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.dni.Location = New System.Drawing.Point(172, 166)
        Me.dni.Name = "dni"
        Me.dni.ReadOnly = True
        Me.dni.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dni.Size = New System.Drawing.Size(217, 38)
        Me.dni.TabIndex = 13
        '
        'contraseña
        '
        Me.contraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contraseña.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.contraseña.Location = New System.Drawing.Point(172, 122)
        Me.contraseña.Name = "contraseña"
        Me.contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contraseña.ReadOnly = True
        Me.contraseña.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.contraseña.Size = New System.Drawing.Size(217, 38)
        Me.contraseña.TabIndex = 10
        '
        'email
        '
        Me.email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.email.Location = New System.Drawing.Point(172, 80)
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.email.Size = New System.Drawing.Size(217, 38)
        Me.email.TabIndex = 4
        '
        'Nombre
        '
        Me.Nombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Nombre.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.Nombre.Location = New System.Drawing.Point(172, 36)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Nombre.Size = New System.Drawing.Size(217, 38)
        Me.Nombre.TabIndex = 1
        '
        'Nombreee
        '
        Me.Nombreee.AutoSize = True
        Me.Nombreee.Location = New System.Drawing.Point(6, 35)
        Me.Nombreee.Name = "Nombreee"
        Me.Nombreee.Size = New System.Drawing.Size(96, 45)
        Me.Nombreee.TabIndex = 0
        Me.Nombreee.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 45)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 45)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "E-mail:"
        '
        'Guardar
        '
        Me.Guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guardar.Enabled = False
        Me.Guardar.Location = New System.Drawing.Point(155, 53)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(139, 50)
        Me.Guardar.TabIndex = 3
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = False
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Salir.Location = New System.Drawing.Point(446, 509)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(449, 50)
        Me.Salir.TabIndex = 4
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.Salir)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Font = New System.Drawing.Font("Javanese Text", 15.25!)
        Me.Panel1.Location = New System.Drawing.Point(12, 131)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(902, 574)
        Me.Panel1.TabIndex = 6
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.borrarFoto)
        Me.GroupBox6.Controls.Add(Me.añadir)
        Me.GroupBox6.Controls.Add(Me.fotografia)
        Me.GroupBox6.Location = New System.Drawing.Point(446, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(449, 231)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Fotografía"
        '
        'borrarFoto
        '
        Me.borrarFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.borrarFoto.CausesValidation = False
        Me.borrarFoto.Location = New System.Drawing.Point(218, 147)
        Me.borrarFoto.Name = "borrarFoto"
        Me.borrarFoto.Size = New System.Drawing.Size(225, 50)
        Me.borrarFoto.TabIndex = 6
        Me.borrarFoto.Text = "Borrar Foto"
        Me.borrarFoto.UseVisualStyleBackColor = False
        '
        'añadir
        '
        Me.añadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.añadir.CausesValidation = False
        Me.añadir.Location = New System.Drawing.Point(218, 63)
        Me.añadir.Name = "añadir"
        Me.añadir.Size = New System.Drawing.Size(225, 50)
        Me.añadir.TabIndex = 5
        Me.añadir.Text = "Añadir Foto"
        Me.añadir.UseVisualStyleBackColor = False
        '
        'fotografia
        '
        Me.fotografia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fotografia.Location = New System.Drawing.Point(6, 42)
        Me.fotografia.Name = "fotografia"
        Me.fotografia.Size = New System.Drawing.Size(206, 183)
        Me.fotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotografia.TabIndex = 0
        Me.fotografia.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Borrar)
        Me.GroupBox5.Location = New System.Drawing.Point(446, 376)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(449, 127)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Borrar Cuenta"
        '
        'Borrar
        '
        Me.Borrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Borrar.Location = New System.Drawing.Point(119, 53)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(219, 50)
        Me.Borrar.TabIndex = 5
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cancelar)
        Me.GroupBox1.Controls.Add(Me.Modificar)
        Me.GroupBox1.Controls.Add(Me.Guardar)
        Me.GroupBox1.Location = New System.Drawing.Point(446, 239)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 133)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modificar Datos de Cuenta"
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancelar.CausesValidation = False
        Me.Cancelar.Enabled = False
        Me.Cancelar.Location = New System.Drawing.Point(300, 53)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(143, 50)
        Me.Cancelar.TabIndex = 5
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = False
        '
        'Modificar
        '
        Me.Modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Modificar.CausesValidation = False
        Me.Modificar.Location = New System.Drawing.Point(6, 53)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(143, 50)
        Me.Modificar.TabIndex = 4
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = False
        '
        'AbrirFoto
        '
        Me.AbrirFoto.Filter = "Archivos .jpg|*.jpg|Archivos .png|*.png|Todos los archivos|*.*"
        '
        'MiCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackgroundImage = Global.Proyecto_Tienda_PcComponentes.My.Resources.Resources.fondonaranja
        Me.ClientSize = New System.Drawing.Size(926, 717)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MiCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mi Cuenta"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.fotografia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Guardar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents poblacion As TextBox
    Friend WithEvents movil As TextBox
    Friend WithEvents codigo_postal As TextBox
    Friend WithEvents direccion As TextBox
    Friend WithEvents provincia As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Salir As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents edad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dni As TextBox
    Friend WithEvents contraseña As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents Nombre As TextBox
    Friend WithEvents Nombreee As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Modificar As Button
    Friend WithEvents Borrar As Button
    Friend WithEvents Cancelar As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents borrarFoto As Button
    Friend WithEvents añadir As Button
    Friend WithEvents fotografia As PictureBox
    Friend WithEvents AbrirFoto As OpenFileDialog
End Class
