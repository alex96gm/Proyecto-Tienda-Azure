<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario_Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuario_Admin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.canc = New System.Windows.Forms.Button()
        Me.aceptar = New System.Windows.Forms.Button()
        Me.usuAd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.contraAd = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.canc)
        Me.Panel1.Controls.Add(Me.aceptar)
        Me.Panel1.Controls.Add(Me.usuAd)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.contraAd)
        Me.Panel1.Font = New System.Drawing.Font("Javanese Text", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 207)
        Me.Panel1.TabIndex = 0
        '
        'canc
        '
        Me.canc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.canc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.canc.Location = New System.Drawing.Point(308, 83)
        Me.canc.Name = "canc"
        Me.canc.Size = New System.Drawing.Size(115, 49)
        Me.canc.TabIndex = 4
        Me.canc.Text = "Cancelar"
        Me.canc.UseVisualStyleBackColor = False
        '
        'aceptar
        '
        Me.aceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.aceptar.Location = New System.Drawing.Point(308, 138)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(115, 49)
        Me.aceptar.TabIndex = 5
        Me.aceptar.Text = "Aceptar"
        Me.aceptar.UseVisualStyleBackColor = False
        '
        'usuAd
        '
        Me.usuAd.Font = New System.Drawing.Font("Javanese Text", 10.25!)
        Me.usuAd.Location = New System.Drawing.Point(13, 56)
        Me.usuAd.Name = "usuAd"
        Me.usuAd.Size = New System.Drawing.Size(289, 39)
        Me.usuAd.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 47)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario Administrador:"
        '
        'contraAd
        '
        Me.contraAd.Font = New System.Drawing.Font("Javanese Text", 10.25!)
        Me.contraAd.Location = New System.Drawing.Point(13, 148)
        Me.contraAd.Name = "contraAd"
        Me.contraAd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contraAd.Size = New System.Drawing.Size(289, 39)
        Me.contraAd.TabIndex = 3
        '
        'Usuario_Admin
        '
        Me.AcceptButton = Me.aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Tienda_PcComponentes.My.Resources.Resources.fondonaranja
        Me.CancelButton = Me.canc
        Me.ClientSize = New System.Drawing.Size(461, 231)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Usuario_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents contraAd As TextBox
    Friend WithEvents usuAd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents canc As Button
    Friend WithEvents aceptar As Button
End Class
