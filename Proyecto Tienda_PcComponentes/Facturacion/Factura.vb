Public Class Factura
    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim total As Integer = 0
        ''DATOS DEL CLIENTE
        Dim i As Integer = 0
        Do
            If lista(i).nom = PaginaPrincipal.cuenta.Text Then
                Label2.Text = lista(i).nom
                Label3.Text = lista(i).mail
                Label4.Text = lista(i).dni
                Label5.Text = lista(i).provincia
                Label6.Text = lista(i).poblacion
                Label7.Text = lista(i).codiPostal
                Label8.Text = lista(i).direccion
                Label9.Text = lista(i).movil
            End If
            i = i + 1
        Loop Until i = lista.Length
        ''Productos
        Dim x As Integer = 0
        Do
            If listProductos.Count > 0 Then
                ListBox1.Items.Add(listProductos.ElementAt(x).nomProducto)
                total = total + listProductos.ElementAt(x).totalProducto
                x = x + 1
            End If
        Loop Until x = listProductos.Count
        ''Fecha
        Dim fecha As Date = Today
        Label13.Text = fecha.ToShortDateString

        Label11.Text = total
    End Sub

    Private Sub Descargar_Click(sender As Object, e As EventArgs) Handles Descargar.Click
        Dim random As New Random()
        Dim numrandomrandom As Integer = random.Next(0, 999)

        Dim nomFact As String = "Factura" + CStr(numrandomrandom)
        Dim rutaFactura = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\" + nomFact + ".jpg"

        ''Posición left de la captura en el formulario       
        Dim posx As Integer = 12
        '' Posición top de la captura en el formulario;
        Dim posy As Integer = 12

        Dim bmp As Bitmap = New Bitmap(368, 585)
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.CopyFromScreen(PointToScreen(New Point(posx, posy)), Point.Empty, New Size(368, 585))
        bmp.Save(rutaFactura)


        MsgBox("La factura se ha descargado en: " + rutaFactura)

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        listProductos.Clear()
        Me.Close()
    End Sub

    Private Sub Factura_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        listProductos.Clear()
    End Sub
End Class