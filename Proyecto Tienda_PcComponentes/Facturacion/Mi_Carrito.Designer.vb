<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mi_Carrito
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mi_Carrito))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Bajar = New System.Windows.Forms.Button()
        Me.Subir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.salir = New System.Windows.Forms.Button()
        Me.pagar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Tot = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tot.SuspendLayout()
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
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 575)
        Me.Panel1.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Font = New System.Drawing.Font("Javanese Text", 15.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 364)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(592, 197)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acciones de Productos"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Bajar)
        Me.Panel3.Controls.Add(Me.Subir)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(6, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(291, 149)
        Me.Panel3.TabIndex = 10
        '
        'Bajar
        '
        Me.Bajar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bajar.Location = New System.Drawing.Point(169, 81)
        Me.Bajar.Name = "Bajar"
        Me.Bajar.Size = New System.Drawing.Size(115, 49)
        Me.Bajar.TabIndex = 10
        Me.Bajar.Text = "↓"
        Me.Bajar.UseVisualStyleBackColor = False
        '
        'Subir
        '
        Me.Subir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Subir.Location = New System.Drawing.Point(169, 12)
        Me.Subir.Name = "Subir"
        Me.Subir.Size = New System.Drawing.Size(115, 49)
        Me.Subir.TabIndex = 8
        Me.Subir.Text = "↑"
        Me.Subir.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 47)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Bajar Producto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 47)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Subir Producto"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Eliminar)
        Me.Panel2.Location = New System.Drawing.Point(303, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(283, 149)
        Me.Panel2.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 47)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Eliminar Producto"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Eliminar
        '
        Me.Eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Eliminar.Location = New System.Drawing.Point(3, 89)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(273, 49)
        Me.Eliminar.TabIndex = 8
        Me.Eliminar.Text = "X"
        Me.Eliminar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.salir)
        Me.GroupBox2.Controls.Add(Me.pagar)
        Me.GroupBox2.Font = New System.Drawing.Font("Javanese Text", 15.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(610, 364)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 197)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Compra"
        '
        'salir
        '
        Me.salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.salir.Location = New System.Drawing.Point(6, 133)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(268, 47)
        Me.salir.TabIndex = 7
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = False
        '
        'pagar
        '
        Me.pagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pagar.Enabled = False
        Me.pagar.Location = New System.Drawing.Point(6, 59)
        Me.pagar.Name = "pagar"
        Me.pagar.Size = New System.Drawing.Size(268, 47)
        Me.pagar.TabIndex = 6
        Me.pagar.Text = "Pagar"
        Me.pagar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Tot)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Javanese Text", 15.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(878, 344)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Proyecto_Tienda_PcComponentes.My.Resources.Resources.logoPcCOMPONENTES
        Me.PictureBox2.Location = New System.Drawing.Point(660, 46)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(212, 191)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Tot
        '
        Me.Tot.Controls.Add(Me.Label6)
        Me.Tot.Controls.Add(Me.total)
        Me.Tot.Font = New System.Drawing.Font("Javanese Text", 15.25!, System.Drawing.FontStyle.Bold)
        Me.Tot.Location = New System.Drawing.Point(660, 243)
        Me.Tot.Name = "Tot"
        Me.Tot.Size = New System.Drawing.Size(212, 82)
        Me.Tot.TabIndex = 6
        Me.Tot.TabStop = False
        Me.Tot.Text = "Total Compra"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(159, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 39)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "€"
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(53, 33)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 39)
        Me.total.TabIndex = 5
        Me.total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Javanese Text", 15.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(81, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(488, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Producto / Cantidad /Precio Uds. /Precio Total"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 45
        Me.ListBox1.Location = New System.Drawing.Point(6, 96)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(648, 229)
        Me.ListBox1.TabIndex = 0
        '
        'Mi_Carrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Tienda_PcComponentes.My.Resources.Resources.fondonaranja
        Me.ClientSize = New System.Drawing.Size(926, 717)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Mi_Carrito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mi Carrito"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tot.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Tot As GroupBox
    Friend WithEvents total As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pagar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Eliminar As Button
    Friend WithEvents salir As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Bajar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Subir As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
