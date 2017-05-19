<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContraseñaOlvidada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContraseñaOlvidada))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Mostrar = New System.Windows.Forms.Button()
        Me.dniContra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.contra = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.mailContra = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 244)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Mostrar)
        Me.GroupBox1.Controls.Add(Me.dniContra)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.contra)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.mailContra)
        Me.GroupBox1.Font = New System.Drawing.Font("Javanese Text", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 229)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mostrar Contraseña"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(392, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 45)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Mostrar
        '
        Me.Mostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Mostrar.ForeColor = System.Drawing.Color.Black
        Me.Mostrar.Location = New System.Drawing.Point(392, 112)
        Me.Mostrar.Name = "Mostrar"
        Me.Mostrar.Size = New System.Drawing.Size(113, 45)
        Me.Mostrar.TabIndex = 6
        Me.Mostrar.Text = "Mostrar"
        Me.Mostrar.UseVisualStyleBackColor = False
        '
        'dniContra
        '
        Me.dniContra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dniContra.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.dniContra.Location = New System.Drawing.Point(136, 94)
        Me.dniContra.Name = "dniContra"
        Me.dniContra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dniContra.Size = New System.Drawing.Size(217, 38)
        Me.dniContra.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DNI:"
        '
        'contra
        '
        Me.contra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contra.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.contra.Location = New System.Drawing.Point(136, 169)
        Me.contra.Name = "contra"
        Me.contra.ReadOnly = True
        Me.contra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.contra.Size = New System.Drawing.Size(217, 38)
        Me.contra.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 45)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Contraseña:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 45)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "E-mail:"
        '
        'mailContra
        '
        Me.mailContra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mailContra.Font = New System.Drawing.Font("Javanese Text", 10.0!)
        Me.mailContra.Location = New System.Drawing.Point(136, 49)
        Me.mailContra.Name = "mailContra"
        Me.mailContra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mailContra.Size = New System.Drawing.Size(217, 38)
        Me.mailContra.TabIndex = 1
        '
        'ContraseñaOlvidada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Proyecto_Tienda_PcComponentes.My.Resources.Resources.fondonaranja
        Me.ClientSize = New System.Drawing.Size(550, 268)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ContraseñaOlvidada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contraseña"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents mailContra As TextBox
    Friend WithEvents dniContra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents contra As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Mostrar As Button
End Class
