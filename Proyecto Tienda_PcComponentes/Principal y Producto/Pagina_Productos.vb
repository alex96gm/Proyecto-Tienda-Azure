
Imports System.Data.SqlClient
Public Class Pagina_Productos

    Private Sub Perifericos_Monitores_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.XBOX_ONE' Puede moverla o quitarla según sea necesario.
        Me.XBOX_ONETableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.XBOX_ONE)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Webcams' Puede moverla o quitarla según sea necesario.
        Me.WebcamsTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Webcams)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.VGA' Puede moverla o quitarla según sea necesario.
        Me.VGATableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.VGA)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.USB' Puede moverla o quitarla según sea necesario.
        Me.USBTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.USB)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Teclados' Puede moverla o quitarla según sea necesario.
        Me.TecladosTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Teclados)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Tarjetas_Red' Puede moverla o quitarla según sea necesario.
        Me.Tarjetas_RedTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Tarjetas_Red)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Tarjetas_Graficas' Puede moverla o quitarla según sea necesario.
        Me.Tarjetas_GraficasTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Tarjetas_Graficas)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Tarjetas_de_Sonido' Puede moverla o quitarla según sea necesario.
        Me.Tarjetas_de_SonidoTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Tarjetas_de_Sonido)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Sony_PS4' Puede moverla o quitarla según sea necesario.
        Me.Sony_PS4TableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Sony_PS4)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Sony_PSVita' Puede moverla o quitarla según sea necesario.
        Me.Sony_PSVitaTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Sony_PSVita)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Sony' Puede moverla o quitarla según sea necesario.
        Me.SonyTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Sony)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Sobremesa' Puede moverla o quitarla según sea necesario.
        Me.SobremesaTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Sobremesa)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Samsung1' Puede moverla o quitarla según sea necesario.
        Me.Samsung1TableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Samsung1)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Samsung' Puede moverla o quitarla según sea necesario.
        Me.SamsungTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Samsung)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Routers' Puede moverla o quitarla según sea necesario.
        Me.RoutersTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Routers)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Ratones' Puede moverla o quitarla según sea necesario.
        Me.RatonesTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Ratones)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Procesadores' Puede moverla o quitarla según sea necesario.
        Me.ProcesadoresTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Procesadores)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Portatiles' Puede moverla o quitarla según sea necesario.
        Me.PortatilesTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Portatiles)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.PlacasBase' Puede moverla o quitarla según sea necesario.
        Me.PlacasBaseTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.PlacasBase)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Nvidia' Puede moverla o quitarla según sea necesario.
        Me.NvidiaTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Nvidia)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Nintendo_Switch' Puede moverla o quitarla según sea necesario.
        Me.Nintendo_SwitchTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Nintendo_Switch)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Nintendo_3DS' Puede moverla o quitarla según sea necesario.
        Me.Nintendo_3DSTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Nintendo_3DS)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Monitores' Puede moverla o quitarla según sea necesario.
        Me.MonitoresTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Monitores)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Microsoft' Puede moverla o quitarla según sea necesario.
        Me.MicrosoftTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Microsoft)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Memoria_RAM' Puede moverla o quitarla según sea necesario.
        Me.Memoria_RAMTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Memoria_RAM)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.LG' Puede moverla o quitarla según sea necesario.
        Me.LGTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.LG)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Hubs_Switchs' Puede moverla o quitarla según sea necesario.
        Me.Hubs_SwitchsTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Hubs_Switchs)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Huawei' Puede moverla o quitarla según sea necesario.
        Me.HuaweiTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Huawei)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.HDMI' Puede moverla o quitarla según sea necesario.
        Me.HDMITableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.HDMI)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1._Grabadoras_DVD_BluRay' Puede moverla o quitarla según sea necesario.
        Me.Grabadoras_DVD_BluRayTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1._Grabadoras_DVD_BluRay)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.DVI' Puede moverla o quitarla según sea necesario.
        Me.DVITableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.DVI)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Discos_Duros' Puede moverla o quitarla según sea necesario.
        Me.Discos_DurosTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Discos_Duros)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Cables_de_Red' Puede moverla o quitarla según sea necesario.
        Me.Cables_de_RedTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Cables_de_Red)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.BQ1' Puede moverla o quitarla según sea necesario.
        Me.BQ1TableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.BQ1)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.BQ' Puede moverla o quitarla según sea necesario.
        Me.BQTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.BQ)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Auriculares' Puede moverla o quitarla según sea necesario.
        Me.AuricularesTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Auriculares)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Asus1' Puede moverla o quitarla según sea necesario.
        Me.Asus1TableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Asus1)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Asus' Puede moverla o quitarla según sea necesario.
        Me.AsusTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Asus)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Apple1' Puede moverla o quitarla según sea necesario.
        Me.Apple1TableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Apple1)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Apple' Puede moverla o quitarla según sea necesario.
        Me.AppleTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Apple)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Antenas' Puede moverla o quitarla según sea necesario.
        Me.AntenasTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Antenas)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Altavoces' Puede moverla o quitarla según sea necesario.
        Me.AltavocesTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Altavoces)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Alfombrillas' Puede moverla o quitarla según sea necesario.
        Me.AlfombrillasTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Alfombrillas)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Alcatel' Puede moverla o quitarla según sea necesario.
        Me.AlcatelTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Alcatel)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Adaptadores_USB' Puede moverla o quitarla según sea necesario.
        Me.Adaptadores_USBTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Adaptadores_USB)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Adaptadores' Puede moverla o quitarla según sea necesario.
        Me.AdaptadoresTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Adaptadores)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Acer' Puede moverla o quitarla según sea necesario.
        Me.AcerTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Acer)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet1._Grabadoras_DVD_BluRay' Puede moverla o quitarla según sea necesario.




        BindingSourceAzureBBDD.DataMember = String_BBDD


        If PaginaPrincipal.cuenta.Text IsNot "Cuenta" Then
            AñadirCarrito.Enabled = True
            IrCarrito.Enabled = True
        Else
            AñadirCarrito.Enabled = False
            IrCarrito.Enabled = False
        End If

        ''textboxs de bbdd
        TextBox2.Text = contador
        TextBox3.Text = BindingSourceAzureBBDD.Count

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim cont As Integer
        cont = TextBox1.Text
        If cont = 1 Then
            MsgBox("La cantidad mínima de un producto es 1")
        Else
            cont = cont - 1
            TextBox1.Text = cont
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cont As Integer
        cont = TextBox1.Text
        If cont = 10 Then
            MsgBox("La cantidad máxima de un producto es 10")
        Else
            cont = cont + 1
            TextBox1.Text = cont
        End If
    End Sub

    Dim cont As Integer = 0

    Public Sub AñadirCarrito_Click(sender As Object, e As EventArgs) Handles AñadirCarrito.Click
        Dim producto As String
        Dim nom As String
        Dim cant As Integer
        Dim precio As Integer
        Dim precioTo As Integer
        Dim fr1 As New Mi_Carrito
        Dim tablaBBDD As String

        If BindingSourceAzureBBDD.DataMember.Contains("1") Then
            tablaBBDD = BindingSourceAzureBBDD.DataMember.Substring(0, BindingSourceAzureBBDD.DataMember.Length - 1)
        Else
            tablaBBDD = BindingSourceAzureBBDD.DataMember
        End If

        nom = Label1.Text
        cant = TextBox1.Text
        precio = Label2.Text
        precioTo = cant * precio
        producto = Label1.Text + "     " + CStr(cant) + "      " + CStr(precio) + "      " + CStr(precioTo)


        Dim product As String = "Producto"
        product = product + CStr(cont)

        Dim thisList As New Productos
        thisList.nomLargoProducto = producto
        thisList.nomProducto = nom
        thisList.precProducto = precio
        thisList.cantProducto = cant
        thisList.totalProducto = precioTo
        thisList.tabla = tablaBBDD
        listProductos.Add(thisList)

        MsgBox("Se ha añadido el producto al carrito")

    End Sub

    Private Sub IrCarrito_Click(sender As Object, e As EventArgs) Handles IrCarrito.Click
        Dim form1 As New Mi_Carrito
        form1.ShowDialog()
    End Sub
    Dim contador As Integer = 1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Primero_Click(sender As Object, e As EventArgs) Handles Primero.Click
        BindingSourceAzureBBDD.MoveFirst()
        TextBox2.Text = BindingSourceAzureBBDD.Count - (BindingSourceAzureBBDD.Count - 1)
        contador = 1
    End Sub

    Private Sub ant_Click(sender As Object, e As EventArgs) Handles ant.Click
        BindingSourceAzureBBDD.MovePrevious()
        If contador > 1 Then
            contador = contador - 1
            TextBox2.Text = contador
        End If
    End Sub

    Private Sub sigui_Click(sender As Object, e As EventArgs) Handles sigui.Click
        BindingSourceAzureBBDD.MoveNext()

        If contador < BindingSourceAzureBBDD.Count Then
            contador = contador + 1
            TextBox2.Text = contador
        End If
    End Sub

    Private Sub Ultimo_Click(sender As Object, e As EventArgs) Handles Ultimo.Click
        BindingSourceAzureBBDD.MoveLast()
        TextBox2.Text = BindingSourceAzureBBDD.Count
        contador = 10
    End Sub
End Class