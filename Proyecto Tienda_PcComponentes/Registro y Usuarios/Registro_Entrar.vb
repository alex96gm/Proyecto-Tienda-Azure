Public Class Registro_Entrar
    Private Sub Entrar_Click(sender As Object, e As EventArgs) Handles Entrar.Click
        Dim contra, correo As String
        contra = contrase.Text
        correo = email.Text
        Dim aux As Boolean = False

        If contrase.Text = "" Or email.Text = "" Then
            MsgBox("Introduzca bien los datos")
            Exit Sub
        End If

        If email.Text.Contains("@gmail.com") Or email.Text.Contains("@outlook.es") Or
            email.Text.Contains("@hotmail.es") Or email.Text.Contains("@yahoo.es") Or
              email.Text.Contains("@yahoo.com") Then
            Dim i As Integer = 0
            Do
                If lista(i).mail = correo And lista(i).contraseña = contra Then


                    aux = True
                    MsgBox("Ha entrado en su cuenta")

                    PaginaPrincipal.cuenta.Enabled = True
                    PaginaPrincipal.MiCarrito.Enabled = True
                    PaginaPrincipal.RegistroEntrar.Visible = False
                    PaginaPrincipal.cuenta.Text = lista(i).nom
                    Me.Close()

                    Exit Do

                Else
                    aux = False
                End If
                i = i + 1
            Loop Until i = lista.Length
        Else

            aux = False
        End If


        If aux = False Then
            MsgBox("Usuario incorrecto, introduzca los datos correctamente")
        End If
    End Sub
    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click

        camposCorrectos()

        If x1.Visible = False And x2.Visible = False And x3.Visible = False And x4.Visible = False And
            x5.Visible = False And x6.Visible = False And x7.Visible = False And x8.Visible = False And
            x9.Visible = False And x10.Visible = False And x11.Visible = False And PoliticaPrivacidad.Checked = True Then
            contador = contador + 1
            ReDim Preserve lista(contador)
            lista(contadorUsuarios).nom = Nombre.Text
            lista(contadorUsuarios).mail = email1.Text
            lista(contadorUsuarios).dni = dni.Text
            lista(contadorUsuarios).contraseña = contraseña.Text
            lista(contadorUsuarios).edad = edad.Text
            lista(contadorUsuarios).provincia = provincia.Text
            lista(contadorUsuarios).poblacion = poblacion.Text
            lista(contadorUsuarios).direccion = direccion.Text
            lista(contadorUsuarios).codiPostal = codigo_postal.Text
            lista(contadorUsuarios).movil = movil.Text
            MsgBox("Usuario Registrado")
            contadorUsuarios = contadorUsuarios + 1
            ponerCamposEnBlanco()

        End If
    End Sub

    Private Sub Cance_Click(sender As Object, e As EventArgs) Handles Cance.Click
        ponerCamposEnBlanco()
    End Sub

    Public Sub camposCorrectos()
        If ValidarNombre(Nombre) = False Then
            x1.Visible = True
        Else
            x1.Visible = False
        End If

        If ValidarMail1(email1) = False Then
            x2.Visible = True
        Else
            x2.Visible = False
        End If

        If validarMail2(email1, email2) = False Then
            x3.Visible = True
        Else
            x3.Visible = False
        End If
        If validarContraseña(contraseña) = True Then
            x4.Visible = True
        Else
            x4.Visible = False
        End If
        If validarDNI(dni) = False Then
            x5.Visible = True
        Else
            x5.Visible = False
        End If

        If validarEdad(edad) = False Then
            x6.Visible = True
        Else
            x6.Visible = False
        End If
        If validarProvincia_Poblacion(provincia) = True Then
            x7.Visible = True
        Else
            x7.Visible = False
        End If
        If validarProvincia_Poblacion(poblacion) = True Then
            x8.Visible = True
        Else
            x8.Visible = False
        End If

        If validarDireccion(direccion) = True Then
            x9.Visible = True
        Else
            x9.Visible = False
        End If

        If validarCodigoPostal(codigo_postal) = True Then
            x10.Visible = True
        Else
            x10.Visible = False
        End If
        If validarMovil(movil) = True Then
            x11.Visible = True
        Else
            x11.Visible = False
        End If
        If PoliticaPrivacidad.Checked = False Then
            MsgBox("Aceptar la política de privacidad es un campo obligatorio")
        End If
    End Sub
    Public Sub ponerCamposEnBlanco()
        Nombre.Text = ""
        email1.Text = ""
        email2.Text = ""
        contraseña.Text = ""
        dni.Text = ""
        edad.Text = ""
        provincia.Text = ""
        poblacion.Text = ""
        direccion.Text = ""
        codigo_postal.Text = ""
        movil.Text = ""
        PoliticaPrivacidad.Checked = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frm As New ContraseñaOlvidada
        frm.ShowDialog()
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
            If Asc(e.KeyChar) < 64 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 32 Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub politica_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles politica.LinkClicked
        Dim form As New PoliticaDePrivacidad
        form.ShowDialog()

    End Sub
End Class

