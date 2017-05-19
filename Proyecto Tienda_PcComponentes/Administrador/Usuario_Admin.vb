Public Class Usuario_Admin
    Private Sub aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
        If usuAd.Text.Equals("admin") Then
            If contraAd.Text.Equals("admin") Then
                Dim form As New Pagina_Administrador
                form.ShowDialog()
                Me.Close()
            Else
                MsgBox("Contraseña Incorrecta")
            End If
        Else
            MsgBox("Usuario Incorrecto")
        End If
    End Sub

    Private Sub canc_Click(sender As Object, e As EventArgs) Handles canc.Click
        Me.Close()
    End Sub
End Class