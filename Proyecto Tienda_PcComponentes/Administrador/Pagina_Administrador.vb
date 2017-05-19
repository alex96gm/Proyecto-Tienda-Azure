Imports System.Data.SqlClient
Imports System
Imports System.Data
Imports System.Configuration

Public Class Pagina_Administrador


    Private Sub Pagina_Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Sony_PSVita' Puede moverla o quitarla según sea necesario.
        Me.Sony_PSVitaTableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Sony_PSVita)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_Tienda_BBDD_AzureDataSet1.Sony_PS4' Puede moverla o quitarla según sea necesario.
        Me.Sony_PS4TableAdapter.Fill(Me.Proyecto_Tienda_BBDD_AzureDataSet1.Sony_PS4)
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


    End Sub
    Private Sub MonitoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitoresToolStripMenuItem.Click
        BindingSourceAdminAzure.DataMember = "Monitores"
    End Sub

    Private Sub AltavocesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltavocesToolStripMenuItem.Click
        BindingSourceAdminAzure.DataMember = "Altavoces"
    End Sub
    Private Sub TecladosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TecladosToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Teclados"

    End Sub

    Private Sub RatonesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RatonesToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Ratones"

    End Sub

    Private Sub AuricularesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuricularesToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Auriculares"

    End Sub

    Private Sub AlfombrillasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlfombrillasToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Alfombrillas"

    End Sub

    Private Sub WebcamsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebcamsToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Webcams"

    End Sub

    Private Sub AdptadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdptadoresToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Adaptadores"

    End Sub

    Private Sub CablesDVIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CablesDVIToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "DVI"

    End Sub

    Private Sub CablesHDMIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CablesHDMIToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "HDMI"

    End Sub

    Private Sub CablesUSBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CablesUSBToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "USB"

    End Sub

    Private Sub CablesVGAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CablesVGAToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "VGA"

    End Sub

    Private Sub AntenasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AntenasToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Antenas"

    End Sub

    Private Sub AdaptadoresUSBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdaptadoresUSBToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Adaptadores_USB"

    End Sub

    Private Sub CableDeRedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CableDeRedToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Cables_de_Red"

    End Sub

    Private Sub RoutersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoutersToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Routers"

    End Sub

    Private Sub TarjetasRedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarjetasRedToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Tarjetas_Red"

    End Sub

    Private Sub HubsSwitchsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HubsSwitchsToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Hubs_Switchs"

    End Sub

    Private Sub PlacaBaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlacaBaseToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "PlacasBase"

    End Sub

    Private Sub ProcesadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesadoresToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Procesadores"

    End Sub

    Private Sub DiscosDurosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscosDurosToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Discos_Duros"

    End Sub

    Private Sub TarjetasGraficasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarjetasGraficasToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Tarjetas_Graficas"

    End Sub

    Private Sub MemoriaRAMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemoriaRAMToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Memoria_RAM"

    End Sub

    Private Sub TarjetasDeSonidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarjetasDeSonidoToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Tarjetas_de_Sonido"

    End Sub

    Private Sub GrabadorasDVDBluRayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrabadorasDVDBluRayToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Grabadoras_DVD-BluRay"

    End Sub

    Private Sub SobremesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobremesaToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Sobremesa"

    End Sub

    Private Sub PortátilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PortátilesToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Portatiles"

    End Sub

    Private Sub AsusToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AsusToolStripMenuItem1.Click

        BindingSourceAdminAzure.DataMember = "Asus1"

    End Sub

    Private Sub AppleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AppleToolStripMenuItem1.Click

        BindingSourceAdminAzure.DataMember = "Apple1"

    End Sub

    Private Sub BQToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BQToolStripMenuItem1.Click

        BindingSourceAdminAzure.DataMember = "BQ1"

    End Sub

    Private Sub MicrosoftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Microsoft"

    End Sub

    Private Sub NvidiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NvidiaToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Nvidia"

    End Sub

    Private Sub SamsungToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SamsungToolStripMenuItem1.Click

        BindingSourceAdminAzure.DataMember = "Samsung1"

    End Sub

    Private Sub AcerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcerToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Acer"

    End Sub

    Private Sub AlcatelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlcatelToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Alcatel"

    End Sub

    Private Sub AppleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppleToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Apple"

    End Sub

    Private Sub AsusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsusToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Asus"

    End Sub

    Private Sub BQToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BQToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "BQ"

    End Sub

    Private Sub HuaweiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HuaweiToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Huawei"

    End Sub

    Private Sub LGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LGToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "LG"

    End Sub

    Private Sub SamsungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SamsungToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Samsung"

    End Sub

    Private Sub SonyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SonyToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Sony"

    End Sub

    Private Sub PS4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PS4ToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Sony_PS4"

    End Sub

    Private Sub SonyPSVitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SonyPSVitaToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Sony_PSVita"

    End Sub

    Private Sub XBOXONEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XBOXONEToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "XBOX_ONE"

    End Sub

    Private Sub WiiUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WiiUToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Nintendo_3DS"

    End Sub

    Private Sub NintendoSwithToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NintendoSwithToolStripMenuItem.Click

        BindingSourceAdminAzure.DataMember = "Nintendo_Switch"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim consulta As String = consultas.Text
            Dim connectionString As String = "Server=tcp:alejandroservidor.database.windows.net,1433;Initial Catalog=Proyecto Tienda BBDD Azure;Persist Security Info=False;User ID=Alejandro;Password=Alesgonzalez1996;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"

            Dim connection As New SqlConnection(connectionString)
            Dim queryCommand As SqlCommand
            queryCommand = New SqlCommand
            queryCommand.CommandType = CommandType.Text
            queryCommand.CommandText = consulta
            queryCommand.Connection = connection
            connection.Open()

            Dim reader As SqlDataReader = queryCommand.ExecuteReader()




            Dim DatosTabla As DataTable = New DataTable
            DatosTabla.Load(reader)
            DataGridView2.DataSource = DatosTabla

            connection.Close()


            Me.OnLoad(e)
        Catch ex As Exception
            MsgBox("La consulta no se ha realizado correctamente")
        End Try

    End Sub


End Class