Module Registro_Entrar_Modulo

    Public Structure Usuarios
        Public nom, mail, contraseña, dni, provincia, poblacion, direccion As String
        Public edad, codiPostal, movil As Integer
        Public foto As Image

    End Structure
    Public contadorUsuarios As Integer = 0
    Public contador As Integer = 0
    Public lista(contador) As Usuarios

    Public Function ValidarNombre(ByVal textbox As Object) As Boolean
        If textbox.text = "" Then
            Return False
        End If
        Return True
    End Function
    Public Function ValidarMail1(ByVal textbox As Object) As Boolean
        If textbox.text.Length = 0 Then
            Return False
        End If
        ''Controlar que no haya dos correos iguales
        Dim i As Integer = 0
        Do
            If textbox.text.Equals(lista(i).mail) Then
                MsgBox("Este correo ya esta registrado")
                Return False
            Else
                If textbox.text.Contains("@gmail.com") Or textbox.text.Contains("@outlook.es") Or
                    textbox.text.Contains("@hotmail.es") Or textbox.text.Contains("@yahoo.es") Or
                    textbox.text.Contains("@yahoo.com") Then
                    Return True
                Else
                    MsgBox("Dominio del correo incorrecto o no encontrado")
                    Return False
                End If
            End If
            i = i + 1
        Loop Until i = 10
        Return False
    End Function
    Public Function validarMail2(ByVal textbox1 As Object, ByVal textbox2 As Object) As Boolean
        If textbox2.Text.Length = 0 Then
            Return False
        Else
            If (textbox1.text = textbox2.text) Then
                Return True
            End If
        End If
        Return False
    End Function
    Public Function validarContraseña(ByVal textbox As Object) As Boolean
        If textbox.text.Length = 0 Then
            Return True
        End If
        Return False
    End Function
    Public Function validarEdad(ByVal textbox As Object) As Boolean
        If textbox.text.Length = 0 Then
            Return False
        Else
            If textbox.text < 18 Or textbox.text > 100 Then
                Return False
            End If
        End If
        Return True
    End Function
    Public Function validarDNI(ByVal textbox As Object) As Boolean
        If textbox.text.Length = 0 Or textbox.text.Length > 9 Or textbox.text.Length < 9 Then
            Return False
        Else
            Dim dniNumero, ultimaletra, letra As String
            Dim numero, res As Integer
            Const Cadena As String = "TRWAGMYFPDXBNJZSQVHLCKE"
            dniNumero = textbox.text

            ultimaletra = dniNumero.Substring(dniNumero.Length - 1, 1)
            numero = dniNumero.Substring(0, dniNumero.Length - 1)
            res = numero Mod 23
            letra = Cadena.Substring(res, res - res + 1)
            If ultimaletra = letra Then
                Return True
            End If
        End If
        Return False
    End Function
    Public Function validarProvincia_Poblacion(ByVal textbox As Object) As Boolean
        If textbox.text.Length = 0 Then
            Return True
        End If
        Return False
    End Function
    Public Function validarDireccion(ByVal textbox As Object) As Boolean
        If textbox.text.Length = 0 Then
            Return True
        End If
        Return False
    End Function
    Public Function validarCodigoPostal(ByVal textbox As Object) As Boolean
        If textbox.text.Length = 0 Then
            Return True
        Else
            If textbox.text.Length > 5 Or textbox.text.Length < 5 Then
                Return True
            End If
        End If
        Return False
    End Function
    Public Function validarMovil(ByVal textbox As Object) As Boolean
        If textbox.text.Length = 0 Then
            Return True
        Else
            If textbox.text.Length > 9 Or textbox.text.Length < 9 Then
                Return True
            End If
        End If
        Return False
    End Function

End Module
