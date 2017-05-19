<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class facturacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(facturacion))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CVC = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.caducidad = New System.Windows.Forms.MaskedTextBox()
        Me.tarjeta = New System.Windows.Forms.MaskedTextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.dni = New System.Windows.Forms.TextBox()
        Me.mail = New System.Windows.Forms.TextBox()
        Me.movil = New System.Windows.Forms.TextBox()
        Me.Provincia = New System.Windows.Forms.TextBox()
        Me.poblacion = New System.Windows.Forms.TextBox()
        Me.Direccion = New System.Windows.Forms.TextBox()
        Me.postal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Nombreee = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.Proyecto_Tienda_PcComponentes.My.Resources.Resources.BannerPcComponentes2
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(901, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.nombre)
        Me.GroupBox1.Controls.Add(Me.dni)
        Me.GroupBox1.Controls.Add(Me.mail)
        Me.GroupBox1.Controls.Add(Me.movil)
        Me.GroupBox1.Controls.Add(Me.Provincia)
        Me.GroupBox1.Controls.Add(Me.poblacion)
        Me.GroupBox1.Controls.Add(Me.Direccion)
        Me.GroupBox1.Controls.Add(Me.postal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Nombreee)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Javanese Text", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(875, 369)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CVC)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.caducidad)
        Me.GroupBox2.Controls.Add(Me.tarjeta)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(863, 107)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Facturación"
        '
        'CVC
        '
        Me.CVC.BeepOnError = True
        Me.CVC.Font = New System.Drawing.Font("Javanese Text", 10.25!)
        Me.CVC.Location = New System.Drawing.Point(807, 53)
        Me.CVC.Mask = "000"
        Me.CVC.Name = "CVC"
        Me.CVC.Size = New System.Drawing.Size(50, 39)
        Me.CVC.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(664, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 47)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Código CVC:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(426, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 47)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Caducidad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tarjeta de Crédito:"
        '
        'caducidad
        '
        Me.caducidad.BeepOnError = True
        Me.caducidad.Font = New System.Drawing.Font("Javanese Text", 10.25!)
        Me.caducidad.Location = New System.Drawing.Point(558, 53)
        Me.caducidad.Mask = "00-00"
        Me.caducidad.Name = "caducidad"
        Me.caducidad.Size = New System.Drawing.Size(55, 39)
        Me.caducidad.TabIndex = 3
        Me.caducidad.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'tarjeta
        '
        Me.tarjeta.BeepOnError = True
        Me.tarjeta.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.tarjeta.Font = New System.Drawing.Font("Javanese Text", 10.25!)
        Me.tarjeta.Location = New System.Drawing.Point(202, 54)
        Me.tarjeta.Mask = "0000-0000-0000-0000"
        Me.tarjeta.Name = "tarjeta"
        Me.tarjeta.Size = New System.Drawing.Size(158, 39)
        Me.tarjeta.TabIndex = 1
        Me.tarjeta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'nombre
        '
        Me.nombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nombre.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.nombre.Location = New System.Drawing.Point(156, 50)
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nombre.Size = New System.Drawing.Size(217, 38)
        Me.nombre.TabIndex = 1
        Me.nombre.TabStop = False
        '
        'dni
        '
        Me.dni.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dni.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.dni.Location = New System.Drawing.Point(652, 50)
        Me.dni.Name = "dni"
        Me.dni.ReadOnly = True
        Me.dni.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dni.Size = New System.Drawing.Size(217, 38)
        Me.dni.TabIndex = 9
        Me.dni.TabStop = False
        '
        'mail
        '
        Me.mail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mail.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.mail.Location = New System.Drawing.Point(156, 97)
        Me.mail.Name = "mail"
        Me.mail.ReadOnly = True
        Me.mail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mail.Size = New System.Drawing.Size(217, 38)
        Me.mail.TabIndex = 3
        Me.mail.TabStop = False
        '
        'movil
        '
        Me.movil.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.movil.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.movil.Location = New System.Drawing.Point(652, 97)
        Me.movil.Name = "movil"
        Me.movil.ReadOnly = True
        Me.movil.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.movil.Size = New System.Drawing.Size(217, 38)
        Me.movil.TabIndex = 11
        Me.movil.TabStop = False
        '
        'Provincia
        '
        Me.Provincia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Provincia.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.Provincia.Location = New System.Drawing.Point(156, 147)
        Me.Provincia.Name = "Provincia"
        Me.Provincia.ReadOnly = True
        Me.Provincia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Provincia.Size = New System.Drawing.Size(217, 38)
        Me.Provincia.TabIndex = 5
        Me.Provincia.TabStop = False
        '
        'poblacion
        '
        Me.poblacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.poblacion.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.poblacion.Location = New System.Drawing.Point(652, 147)
        Me.poblacion.Name = "poblacion"
        Me.poblacion.ReadOnly = True
        Me.poblacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.poblacion.Size = New System.Drawing.Size(217, 38)
        Me.poblacion.TabIndex = 13
        Me.poblacion.TabStop = False
        '
        'Direccion
        '
        Me.Direccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Direccion.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.Direccion.Location = New System.Drawing.Point(156, 197)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Direccion.Size = New System.Drawing.Size(217, 38)
        Me.Direccion.TabIndex = 7
        Me.Direccion.TabStop = False
        '
        'postal
        '
        Me.postal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.postal.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.postal.Location = New System.Drawing.Point(652, 194)
        Me.postal.Name = "postal"
        Me.postal.ReadOnly = True
        Me.postal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.postal.Size = New System.Drawing.Size(217, 38)
        Me.postal.TabIndex = 15
        Me.postal.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(491, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 47)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Población:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(491, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 47)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "DNI:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 47)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "E-mail:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 47)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Provincia:"
        '
        'Nombreee
        '
        Me.Nombreee.AutoSize = True
        Me.Nombreee.Location = New System.Drawing.Point(6, 50)
        Me.Nombreee.Name = "Nombreee"
        Me.Nombreee.Size = New System.Drawing.Size(99, 47)
        Me.Nombreee.TabIndex = 0
        Me.Nombreee.Text = "Nombre:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(491, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 47)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Móvil:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(491, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 47)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Codigo Postal:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 47)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Dirección:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Cancelar)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(13, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 575)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Javanese Text", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(493, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(395, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Comprar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cancelar.Font = New System.Drawing.Font("Javanese Text", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.Location = New System.Drawing.Point(493, 490)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(395, 50)
        Me.Cancelar.TabIndex = 3
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Javanese Text", 10.25!)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 32
        Me.ListBox1.Location = New System.Drawing.Point(13, 390)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(474, 164)
        Me.ListBox1.TabIndex = 1
        '
        'facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Proyecto_Tienda_PcComponentes.My.Resources.Resources.fondonaranja
        Me.ClientSize = New System.Drawing.Size(926, 717)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "facturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Nombreee As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents dni As TextBox
    Friend WithEvents mail As TextBox
    Friend WithEvents movil As TextBox
    Friend WithEvents Provincia As TextBox
    Friend WithEvents poblacion As TextBox
    Friend WithEvents Direccion As TextBox
    Friend WithEvents postal As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents caducidad As MaskedTextBox
    Friend WithEvents tarjeta As MaskedTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CVC As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Cancelar As Button
End Class
