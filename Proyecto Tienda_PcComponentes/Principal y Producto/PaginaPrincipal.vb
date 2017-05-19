
Public Class PaginaPrincipal
    Dim banner1 As Bitmap = My.Resources.banner10
    Dim banner2 As Bitmap = My.Resources.banner2
    Dim banner3 As Bitmap = My.Resources.banner3
    Dim banner4 As Bitmap = My.Resources.banner4
    Dim banner5 As Bitmap = My.Resources.banner5
    Dim banner6 As Bitmap = My.Resources.heroagonmin
    Dim banner7 As Bitmap = My.Resources.banner7
    Dim banner8 As Bitmap = My.Resources.banner8
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim random As New Random()
        Dim banners() As Bitmap = {banner1, banner2, banner3, banner4, banner5, banner6, banner7, banner8}
        Dim bannersRandom As Integer = random.Next(0, banners.Length)
        BannerProductos.Image = banners(bannersRandom)
    End Sub
    Private Sub PaginaPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        contador = contador + 1
        ReDim Preserve lista(contador)
        lista(contadorUsuarios).nom = "admin"
        lista(contadorUsuarios).mail = "admin@gmail.com"
        lista(contadorUsuarios).dni = "06028077F"
        lista(contadorUsuarios).contraseña = 123456
        lista(contadorUsuarios).edad = 20
        lista(contadorUsuarios).provincia = "aaa"
        lista(contadorUsuarios).poblacion = "aaa"
        lista(contadorUsuarios).direccion = "aaa"
        lista(contadorUsuarios).codiPostal = "25631"
        lista(contadorUsuarios).movil = "123456789"
        contadorUsuarios = contadorUsuarios + 1
    End Sub

    Private Sub MiCarrito_Click(sender As Object, e As EventArgs) Handles MiCarrito.Click
        Dim form1 As New Mi_Carrito
        form1.ShowDialog()
    End Sub
    Private Sub RegistroEntrar_Click(sender As Object, e As EventArgs) Handles RegistroEntrar.Click
        Dim form1 As New Registro_Entrar
        form1.ShowDialog()
    End Sub
    Private Sub MiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiToolStripMenuItem.Click
        Dim form As New MiCuenta
        form.ShowDialog()
    End Sub
    Public Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        cerrarSesion()

        listProductos.Clear()
    End Sub

    Private Sub MadridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MadridToolStripMenuItem.Click
        Dim form As New DondeEstamos
        form.ShowDialog()
    End Sub

    Private Sub MurciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MurciaToolStripMenuItem.Click
        Dim form As New DondeEstamosMurcia
        form.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        System.Diagnostics.Process.Start("https://www.pccomponentes.com/")
    End Sub

    Private Sub QuienesSomosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuienesSomosToolStripMenuItem.Click
        Dim form As New QuienesSomos
        form.ShowDialog()
    End Sub

    Private Sub MonitoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitoresToolStripMenuItem.Click
        Dim form As New Pagina_Productos

        Dim Monitores As String = "Monitores"
        String_BBDD = Monitores

        form.ShowDialog()
    End Sub

    Private Sub AltavocesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltavocesToolStripMenuItem.Click
        Dim form As New Pagina_Productos
        Dim Altavoces As String = "Altavoces"
        String_BBDD = Altavoces
        form.ShowDialog()
    End Sub

    Private Sub TecladosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TecladosToolStripMenuItem.Click
        Dim form As New Pagina_Productos
        Dim Teclados As String = "Teclados"
        String_BBDD = Teclados
        form.ShowDialog()
    End Sub

    Private Sub RatonesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RatonesToolStripMenuItem.Click
        Dim form As New Pagina_Productos
        Dim Ratones As String = "Ratones"
        String_BBDD = Ratones
        form.ShowDialog()
    End Sub

    Private Sub AuricularesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuricularesToolStripMenuItem.Click
        Dim form As New Pagina_Productos
        Dim Auriculares As String = "Auriculares"
        String_BBDD = Auriculares
        form.ShowDialog()
    End Sub

    Private Sub AlfombrillasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlfombrillasToolStripMenuItem.Click
        Dim form As New Pagina_Productos
        Dim Alfombrillas As String = "Alfombrillas"
        String_BBDD = Alfombrillas
        form.ShowDialog()
    End Sub

    Private Sub WebcamsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebcamsToolStripMenuItem.Click
        Dim form As New Pagina_Productos
        Dim Webcams As String = "Webcams"
        String_BBDD = Webcams
        form.ShowDialog()
    End Sub

    Private Sub AdptadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdptadoresToolStripMenuItem.Click
        Dim form As New Pagina_Productos
        Dim Adaptadores As String = "Adaptadores"
        String_BBDD = Adaptadores
        form.ShowDialog()
    End Sub

    Private Sub CablesDVIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CablesDVIToolStripMenuItem.Click
        Dim form As New Pagina_Productos
        Dim DVI As String = "DVI"
        String_BBDD = DVI
        form.ShowDialog()
    End Sub

    Private Sub CablesHDMIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CablesHDMIToolStripMenuItem.Click
        Dim form As New Pagina_Productos
        Dim HDMI As String = "HDMI"
        String_BBDD = HDMI
        form.ShowDialog()
    End Sub

    Private Sub CablesUSBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CablesUSBToolStripMenuItem.Click
        Dim form As New Pagina_Productos
        Dim USB As String = "USB"
        String_BBDD = USB
        form.ShowDialog()
    End Sub

    Private Sub CablesVGAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CablesVGAToolStripMenuItem.Click
        Dim form As New Pagina_Productos
        Dim VGA As String = "VGA"
        String_BBDD = VGA
        form.ShowDialog()
    End Sub

    Private Sub AntenasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AntenasToolStripMenuItem.Click
        Dim form As New Pagina_Productos
        Dim Antenas As String = "Antenas"
        String_BBDD = Antenas
        form.ShowDialog()
    End Sub

    Private Sub AdaptadoresUSBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdaptadoresUSBToolStripMenuItem.Click
        Dim form As New Pagina_Productos
        Dim Adaptadores_USB As String = "Adaptadores_USB"
        String_BBDD = Adaptadores_USB
        form.ShowDialog()
    End Sub

    Private Sub CableDeRedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CableDeRedToolStripMenuItem.Click
        Dim form As New Pagina_Productos
        Dim Cables_de_Red As String = "Cables_de_Red"
        String_BBDD = Cables_de_Red
        form.ShowDialog()
    End Sub

    Private Sub RoutersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoutersToolStripMenuItem.Click
        Dim form As New Pagina_Productos
        Dim Routers As String = "Routers"
        String_BBDD = Routers
        form.ShowDialog()
    End Sub

    Private Sub TarjetasRedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarjetasRedToolStripMenuItem.Click
        Dim form As New Pagina_Productos
        Dim Tarjetas_Red As String = "Tarjetas_Red"
        String_BBDD = Tarjetas_Red
        form.ShowDialog()
    End Sub

    Private Sub HubsSwitchsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HubsSwitchsToolStripMenuItem.Click
        Dim form As New Pagina_Productos
        Dim Hubs_Switchs As String = "Hubs_Switchs"
        String_BBDD = Hubs_Switchs
        form.ShowDialog()
    End Sub

    Private Sub PlacaBaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlacaBaseToolStripMenuItem.Click, ToolStripMenuItem28.Click
        Dim form As New Pagina_Productos
        Dim PlacasBase As String = "PlacasBase"
        String_BBDD = PlacasBase
        form.ShowDialog()
    End Sub

    Private Sub ProcesadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesadoresToolStripMenuItem.Click, ToolStripMenuItem29.Click
        Dim form As New Pagina_Productos
        Dim Procesadores As String = "Procesadores"
        String_BBDD = Procesadores
        form.ShowDialog()
    End Sub

    Private Sub DiscosDurosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscosDurosToolStripMenuItem.Click, ToolStripMenuItem30.Click
        Dim form As New Pagina_Productos
        Dim Discos_Duros As String = "Discos_Duros"
        String_BBDD = Discos_Duros
        form.ShowDialog()
    End Sub

    Private Sub TarjetasGraficasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarjetasGraficasToolStripMenuItem.Click, ToolStripMenuItem31.Click
        Dim form As New Pagina_Productos
        Dim Tarjetas_Graficas As String = "Tarjetas_Graficas"
        String_BBDD = Tarjetas_Graficas
        form.ShowDialog()
    End Sub

    Private Sub MemoriaRAMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemoriaRAMToolStripMenuItem.Click, ToolStripMenuItem32.Click
        Dim form As New Pagina_Productos
        Dim Memoria_RAM As String = "Memoria_RAM"
        String_BBDD = Memoria_RAM
        form.ShowDialog()
    End Sub

    Private Sub TarjetasDeSonidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarjetasDeSonidoToolStripMenuItem.Click, ToolStripMenuItem33.Click
        Dim form As New Pagina_Productos
        Dim Tarjetas_de_Sonido As String = "Tarjetas_de_Sonido"
        String_BBDD = Tarjetas_de_Sonido
        form.ShowDialog()
    End Sub

    Private Sub GrabadorasDVDBluRayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrabadorasDVDBluRayToolStripMenuItem.Click, ToolStripMenuItem34.Click
        Dim form As New Pagina_Productos
        Dim Grabadoras_DVD_BluRay As String = "Grabadoras_DVD-BluRay"
        String_BBDD = Grabadoras_DVD_BluRay
        form.ShowDialog()
    End Sub

    Private Sub SobremesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobremesaToolStripMenuItem.Click, ToolStripMenuItem25.Click
        Dim form As New Pagina_Productos
        Dim Sobremesa As String = "Sobremesa"
        String_BBDD = Sobremesa
        form.ShowDialog()
    End Sub

    Private Sub PortátilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PortátilesToolStripMenuItem.Click, ToolStripMenuItem26.Click
        Dim form As New Pagina_Productos
        Dim Portatiles As String = "Portatiles"
        String_BBDD = Portatiles
        form.ShowDialog()
    End Sub

    Private Sub AsusToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AsusToolStripMenuItem1.Click, ToolStripMenuItem18.Click
        Dim form As New Pagina_Productos
        Dim Asus1 As String = "Asus1"
        String_BBDD = Asus1
        form.ShowDialog()
    End Sub

    Private Sub AppleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AppleToolStripMenuItem1.Click, ToolStripMenuItem19.Click
        Dim form As New Pagina_Productos
        Dim Apple1 As String = "Apple1"
        String_BBDD = Apple1
        form.ShowDialog()
    End Sub

    Private Sub BQToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BQToolStripMenuItem1.Click, ToolStripMenuItem20.Click
        Dim form As New Pagina_Productos
        Dim BQ1 As String = "BQ1"
        String_BBDD = BQ1
        form.ShowDialog()
    End Sub

    Private Sub MicrosoftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftToolStripMenuItem.Click, ToolStripMenuItem21.Click
        Dim form As New Pagina_Productos
        Dim Microsoft As String = "Microsoft"
        String_BBDD = Microsoft
        form.ShowDialog()
    End Sub

    Private Sub NvidiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NvidiaToolStripMenuItem.Click, ToolStripMenuItem22.Click
        Dim form As New Pagina_Productos
        Dim Nvidia As String = "Nvidia"
        String_BBDD = Nvidia
        form.ShowDialog()
    End Sub

    Private Sub SamsungToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SamsungToolStripMenuItem1.Click, ToolStripMenuItem23.Click
        Dim form As New Pagina_Productos
        Dim Samsung1 As String = "Samsung1"
        String_BBDD = Samsung1
        form.ShowDialog()
    End Sub

    Private Sub AcerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcerToolStripMenuItem.Click, ToolStripMenuItem8.Click
        Dim form As New Pagina_Productos
        Dim Acer As String = "Acer"
        String_BBDD = Acer
        form.ShowDialog()
    End Sub

    Private Sub AlcatelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlcatelToolStripMenuItem.Click, ToolStripMenuItem9.Click
        Dim form As New Pagina_Productos
        Dim Alcatel As String = "Alcatel"
        String_BBDD = Alcatel
        form.ShowDialog()
    End Sub

    Private Sub AppleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppleToolStripMenuItem.Click, ToolStripMenuItem10.Click
        Dim form As New Pagina_Productos
        Dim Apple As String = "Apple"
        String_BBDD = Apple
        form.ShowDialog()
    End Sub

    Private Sub AsusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsusToolStripMenuItem.Click, ToolStripMenuItem11.Click
        Dim form As New Pagina_Productos
        Dim Asus As String = "Asus"
        String_BBDD = Asus
        form.ShowDialog()
    End Sub

    Private Sub BQToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BQToolStripMenuItem.Click, ToolStripMenuItem12.Click
        Dim form As New Pagina_Productos
        Dim BQ As String = "BQ"
        String_BBDD = BQ
        form.ShowDialog()
    End Sub

    Private Sub HuaweiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HuaweiToolStripMenuItem.Click, ToolStripMenuItem13.Click
        Dim form As New Pagina_Productos
        Dim Huawei As String = "Huawei"
        String_BBDD = Huawei
        form.ShowDialog()
    End Sub

    Private Sub LGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LGToolStripMenuItem.Click, ToolStripMenuItem14.Click
        Dim form As New Pagina_Productos
        Dim LG As String = "LG"
        String_BBDD = LG
        form.ShowDialog()
    End Sub

    Private Sub SamsungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SamsungToolStripMenuItem.Click, ToolStripMenuItem15.Click
        Dim form As New Pagina_Productos
        Dim Samsung As String = "Samsung"
        String_BBDD = Samsung
        form.ShowDialog()
    End Sub

    Private Sub SonyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SonyToolStripMenuItem.Click, ToolStripMenuItem16.Click
        Dim form As New Pagina_Productos
        Dim Sony As String = "Sony"
        String_BBDD = Sony
        form.ShowDialog()
    End Sub

    Private Sub PS4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PS4ToolStripMenuItem.Click, ToolStripMenuItem2.Click
        Dim form As New Pagina_Productos
        Dim Sony_PS4 As String = "Sony_PS4"
        String_BBDD = Sony_PS4
        form.ShowDialog()
    End Sub

    Private Sub SonyPSVitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SonyPSVitaToolStripMenuItem.Click, ToolStripMenuItem3.Click
        Dim form As New Pagina_Productos
        Dim Sony_PSVita As String = "Sony_PSVita"
        String_BBDD = Sony_PSVita
        form.ShowDialog()
    End Sub

    Private Sub XBOXONEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XBOXONEToolStripMenuItem.Click, ToolStripMenuItem4.Click
        Dim form As New Pagina_Productos
        Dim XBOX_ONE As String = "XBOX_ONE"
        String_BBDD = XBOX_ONE
        form.ShowDialog()
    End Sub

    Private Sub WiiUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WiiUToolStripMenuItem.Click, ToolStripMenuItem5.Click
        Dim form As New Pagina_Productos
        Dim Nintendo_3DS As String = "Nintendo_3DS"
        String_BBDD = Nintendo_3DS
        form.ShowDialog()
    End Sub

    Private Sub NintendoSwithToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NintendoSwithToolStripMenuItem.Click, ToolStripMenuItem6.Click
        Dim form As New Pagina_Productos
        Dim Nintendo_Switch As String = "Nintendo_Switch"
        String_BBDD = Nintendo_Switch
        form.ShowDialog()
    End Sub

    ''CLICKS EN LA FOTOS 
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim form As New Pagina_Productos
        Dim Procesadores As String = "Procesadores"
        String_BBDD = Procesadores
        form.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim form As New Pagina_Productos
        Dim Portatiles As String = "Portatiles"
        String_BBDD = Portatiles
        form.ShowDialog()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim form As New Pagina_Productos
        Dim Samsung As String = "Samsung"
        String_BBDD = Samsung
        form.ShowDialog()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim form As New Pagina_Productos
        Dim Apple As String = "Apple"
        String_BBDD = Apple
        form.ShowDialog()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim form As New Pagina_Productos
        Dim Tarjetas_Graficas As String = "Tarjetas_Graficas"
        String_BBDD = Tarjetas_Graficas
        form.ShowDialog()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim form As New Pagina_Productos

        Dim Monitores As String = "Monitores"
        String_BBDD = Monitores

        form.ShowDialog()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim form As New Pagina_Productos
        Dim Sony_PS4 As String = "Sony_PS4"
        String_BBDD = Sony_PS4
        form.ShowDialog()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim form As New Pagina_Productos
        Dim Routers As String = "Routers"
        String_BBDD = Routers
        form.ShowDialog()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Dim form As New Pagina_Productos
        Dim Ratones As String = "Ratones"
        String_BBDD = Ratones
        form.ShowDialog()
    End Sub

    Private Sub AdministradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministradorToolStripMenuItem.Click
        Dim form As New Usuario_Admin
        form.ShowDialog()
    End Sub
End Class
