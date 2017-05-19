Public Class ContraseñaOlvidada
    Private Sub Mostrar_Click(sender As Object, e As EventArgs) Handles Mostrar.Click
        contra.Text = ""
        Dim dni_contra, mail_contra As String
        Dim aux As Boolean = False
        dni_contra = dniContra.Text
        mail_contra = mailContra.Text
        Dim i As Integer = 0
        Do
            If lista(i).mail = mail_contra And lista(i).dni = dni_contra Then
                contra.Text = lista(i).contraseña
                aux = True
                Exit Do
            Else
                aux = False
            End If
            i = i + 1
        Loop Until i = lista.Length

        If aux = False Then
            MsgBox("No se ha encontrado la contraseña, escriba bien los datos")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class