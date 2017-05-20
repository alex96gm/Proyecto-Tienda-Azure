Public Class MiCuenta
    Private Sub MiCuenta_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim i As Integer = 0
        Do
            If lista(i).nom = PaginaPrincipal.cuenta.Text Then
                Nombre.Text = lista(i).nom
                email.Text = lista(i).mail
                contraseña.Text = lista(i).contraseña
                dni.Text = lista(i).dni
                edad.Text = lista(i).edad
                provincia.Text = lista(i).provincia
                poblacion.Text = lista(i).poblacion
                codigo_postal.Text = lista(i).codiPostal
                direccion.Text = lista(i).direccion
                movil.Text = lista(i).movil
                fotografia.Image = lista(i).foto
            End If
            i = i + 1
        Loop Until i = lista.Length
    End Sub
    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click

        Dim msgboxBorrar As MsgBoxResult = MsgBox("¿Está seguro de que quiere borrar su cuenta de PcComponentes?", vbOKCancel, "Borrar Cuenta Confirmar")

        If msgboxBorrar = vbOK Then
            Dim i As Integer = 0
            Do
                If lista(i).nom = PaginaPrincipal.cuenta.Text Then
                    'Dim random As New Random()
                    'Dim numRandom As Integer = random.Next(11111111, 99999999)
                    'lista(i).nom = CInt(numRandom)
                    'lista(i).mail = CInt(numRandom)

                    lista(i).nom = ""
                    lista(i).mail = ""
                    lista(i).contraseña = ""
                    lista(i).dni = ""
                    lista(i).edad = Nothing
                    lista(i).provincia = ""
                    lista(i).poblacion = ""
                    lista(i).codiPostal = Nothing
                    lista(i).direccion = ""
                    lista(i).movil = Nothing
                    lista(i).foto = Nothing
                End If
                i = i + 1
            Loop Until i = lista.Length

            cerrarSesion()
            Me.Close()

            MsgBox("Su cuenta se ha borrado correctamente")
        Else
            MsgBox("Se ha cancelado el borrado de su cuenta")
        End If
    End Sub
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click

        If email.Text.Contains("@gmail.com") Or email.Text.Contains("@outlook.es") Or
            email.Text.Contains("@hotmail.es") Or email.Text.Contains("@yahoo.es") Or
              email.Text.Contains("@yahoo.com") Then
            Dim i As Integer = 0
            Do
                If lista(i).nom = PaginaPrincipal.cuenta.Text Then
                    lista(i).nom = Nombre.Text
                    lista(i).mail = email.Text
                    lista(i).contraseña = contraseña.Text
                    lista(i).dni = dni.Text
                    lista(i).edad = edad.Text
                    lista(i).provincia = provincia.Text
                    lista(i).poblacion = poblacion.Text
                    lista(i).codiPostal = codigo_postal.Text
                    lista(i).direccion = direccion.Text
                    lista(i).movil = movil.Text
                End If
                i = i + 1
            Loop Until i = lista.Length


            Modificar.Enabled = True
            Guardar.Enabled = False
            Cancelar.Enabled = False
            Nombre.ReadOnly = True
            email.ReadOnly = True
            contraseña.ReadOnly = True
            dni.ReadOnly = True
            edad.ReadOnly = True
            provincia.ReadOnly = True
            poblacion.ReadOnly = True
            direccion.ReadOnly = True
            codigo_postal.ReadOnly = True
            movil.ReadOnly = True


            PaginaPrincipal.cuenta.Text = Nombre.Text
        Else
            MsgBox("El correo electrónico esta mal escrito")

        End If
    End Sub
    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        Dim msgboxModificar As String

        msgboxModificar = MsgBox("¿Está seguro de que desea modificar su cuenta de PcComponentes?", vbOKCancel, "Borrar Cuenta Confirmar")

        If msgboxModificar = vbOK Then
            Guardar.Enabled = True
            Cancelar.Enabled = True
            Modificar.Enabled = False
            Nombre.ReadOnly = False
            email.ReadOnly = False
            contraseña.ReadOnly = False
            dni.ReadOnly = False
            edad.ReadOnly = False
            provincia.ReadOnly = False
            poblacion.ReadOnly = False
            direccion.ReadOnly = False
            codigo_postal.ReadOnly = False
            movil.ReadOnly = False
        Else
            Modificar.Enabled = True
            Guardar.Enabled = False
            Cancelar.Enabled = False
            Nombre.ReadOnly = True
            email.ReadOnly = True
            contraseña.ReadOnly = True
            dni.ReadOnly = True
            edad.ReadOnly = True
            provincia.ReadOnly = True
            poblacion.ReadOnly = True
            direccion.ReadOnly = True
            codigo_postal.ReadOnly = True
            movil.ReadOnly = True
        End If
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click

        Dim i As Integer = 0
        Do
            If lista(i).nom = PaginaPrincipal.cuenta.Text Then
                Nombre.Text = lista(i).nom
                email.Text = lista(i).mail
                contraseña.Text = lista(i).contraseña
                dni.Text = lista(i).dni
                edad.Text = lista(i).edad
                provincia.Text = lista(i).provincia
                poblacion.Text = lista(i).poblacion
                codigo_postal.Text = lista(i).codiPostal
                direccion.Text = lista(i).direccion
                movil.Text = lista(i).movil
            End If
            i = i + 1
        Loop Until i = lista.Length


        Modificar.Enabled = True
        Guardar.Enabled = False
        Cancelar.Enabled = False
        Nombre.ReadOnly = True
        email.ReadOnly = True
        contraseña.ReadOnly = True
        dni.ReadOnly = True
        edad.ReadOnly = True
        provincia.ReadOnly = True
        poblacion.ReadOnly = True
        direccion.ReadOnly = True
        codigo_postal.ReadOnly = True
        movil.ReadOnly = True
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub añadir_Click(sender As Object, e As EventArgs) Handles añadir.Click
        Dim formFoto As DialogResult
        formFoto = AbrirFoto.ShowDialog()
        If formFoto = Windows.Forms.DialogResult.OK Then

            Dim foto As String = AbrirFoto.FileName


            Dim i As Integer = 0
            Do
                If lista(i).nom = PaginaPrincipal.cuenta.Text Then
                    lista(i).foto = Image.FromFile(foto)
                    fotografia.Image = lista(i).foto

                End If
                i = i + 1
            Loop Until i = lista.Length

        End If
    End Sub

    Private Sub borrarFoto_Click(sender As Object, e As EventArgs) Handles borrarFoto.Click
        fotografia.Image = Nothing

        Dim i As Integer = 0
        Do
            If lista(i).nom = PaginaPrincipal.cuenta.Text Then

                lista(i).foto = Nothing
            End If
            i = i + 1
        Loop Until i = lista.Length
    End Sub

    '' BLOQUEO DE TECLAS PARA INPUTS DE NUMEROS
    Private Sub edad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles edad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub codigo_postal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles codigo_postal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub movil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles movil.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    '' BLOQUEO DE TECLAS PARA INPUTS DE TEXTO 65-90 97-122

    Private Sub Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nombre.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 64 Or Asc(e.KeyChar) > 255 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 32 Then
                e.Handled = False
            End If
        End If

    End Sub

    Private Sub provincia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles provincia.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 64 Or Asc(e.KeyChar) > 255 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 32 Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub poblacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles poblacion.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 64 Or Asc(e.KeyChar) > 255 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 32 Then
                e.Handled = False
            End If
        End If
    End Sub
End Class