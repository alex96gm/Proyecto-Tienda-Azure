Imports System.Data.SqlClient
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
            Dim schema = {"Cables", "Componentes", "Consolas", "Moviles", "Ordenadores", "Perifericos", "Redes", "Tablets"}

            Dim x As Integer = 0
            Do
                If listProductos.Count > 0 Then

                    For Each item As String In schema
                        Try
                            Dim consulta As String = "update " & item & "." & listProductos.ElementAt(x).tabla & " set stock=stock-" & listProductos.ElementAt(x).cantProducto & " where nombre like '" & listProductos.ElementAt(x).nomProducto & "'"

                            Dim connectionString As String = "Data Source=alejandroservidor.database.windows.net;Initial Catalog='Proyecto Tienda BBDD Azure';User ID=Alejandro;Password=Alesgonzalez1996"

                            Dim connection As New SqlConnection(connectionString)
                            Dim queryCommand As SqlCommand
                            queryCommand = New SqlCommand
                            queryCommand.CommandType = CommandType.Text
                            queryCommand.CommandText = consulta
                            queryCommand.Connection = connection
                            connection.Open()

                            Dim reader As SqlDataReader = queryCommand.ExecuteReader()

                        Catch ex As Exception

                        End Try
                    Next
                    x = x + 1
                End If
            Loop Until x = listProductos.Count

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

    Private Sub facturacion_Closed(sender As Object, e As EventArgs) Handles Me.Closed


    End Sub
End Class