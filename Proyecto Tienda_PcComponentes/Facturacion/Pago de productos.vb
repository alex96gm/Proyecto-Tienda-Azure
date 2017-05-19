Public Class facturacion
    Private Sub facturacion_Load(sender As Object, e As EventArgs) Handles Me.Load

        ''DATOS DEL CLIENTE
        Dim i As Integer = 0
        Do
            If lista(i).nom = PaginaPrincipal.cuenta.Text Then
                nombre.Text = lista(i).nom
                mail.Text = lista(i).mail
                dni.Text = lista(i).dni
                Provincia.Text = lista(i).provincia
                poblacion.Text = lista(i).poblacion
                postal.Text = lista(i).codiPostal
                Direccion.Text = lista(i).direccion
                movil.Text = lista(i).movil
            End If
            i = i + 1
        Loop Until i = lista.Length

        '' PRODUCTOS
        Dim x As Integer = 0
        Do
            If listProductos.Count > 0 Then
                ListBox1.Items.Add(listProductos.ElementAt(x).nomProducto)
                x = x + 1
            End If
        Loop Until x = listProductos.Count
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tarjeta.Text.Length = 16 And CVC.Text.Length = 3 And caducidad.Text.Length = 4 Then

            Me.Close()
            Dim form As New Factura
            form.ShowDialog()
            'cerrar mi carrito
        Else

            MsgBox("Algún dato de la facturación es incorrecta")
        End If
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
End Class