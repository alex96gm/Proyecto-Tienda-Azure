Imports System.Data.SqlClient
Imports System
Imports System.Data
Imports System.Configuration

Public Class Pagina_Administrador


    Private Sub Pagina_Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Acer' Puede moverla o quitarla según sea necesario.
        Me.AcerTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Acer)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Acer' Puede moverla o quitarla según sea necesario.
        Me.AcerTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Acer)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.BQ' Puede moverla o quitarla según sea necesario.
        Me.BQTableAdapter.Fill(Me.Proyecto_TiendaDataSet.BQ)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.XBOX_ONE' Puede moverla o quitarla según sea necesario.
        Me.XBOX_ONETableAdapter.Fill(Me.Proyecto_TiendaDataSet.XBOX_ONE)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Webcams' Puede moverla o quitarla según sea necesario.
        Me.WebcamsTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Webcams)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.VGA' Puede moverla o quitarla según sea necesario.
        Me.VGATableAdapter.Fill(Me.Proyecto_TiendaDataSet.VGA)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.USB' Puede moverla o quitarla según sea necesario.
        Me.USBTableAdapter.Fill(Me.Proyecto_TiendaDataSet.USB)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Teclados' Puede moverla o quitarla según sea necesario.
        Me.TecladosTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Teclados)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Tarjetas_Red' Puede moverla o quitarla según sea necesario.
        Me.Tarjetas_RedTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Tarjetas_Red)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Tarjetas_Graficas' Puede moverla o quitarla según sea necesario.
        Me.Tarjetas_GraficasTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Tarjetas_Graficas)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Tarjetas_de_Sonido' Puede moverla o quitarla según sea necesario.
        Me.Tarjetas_de_SonidoTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Tarjetas_de_Sonido)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Sony_PSVita' Puede moverla o quitarla según sea necesario.
        Me.Sony_PSVitaTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Sony_PSVita)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Sony_PS4' Puede moverla o quitarla según sea necesario.
        Me.Sony_PS4TableAdapter.Fill(Me.Proyecto_TiendaDataSet.Sony_PS4)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Sony' Puede moverla o quitarla según sea necesario.
        Me.SonyTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Sony)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Sobremesa' Puede moverla o quitarla según sea necesario.
        Me.SobremesaTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Sobremesa)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Samsung1' Puede moverla o quitarla según sea necesario.
        Me.Samsung1TableAdapter.Fill(Me.Proyecto_TiendaDataSet.Samsung1)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Samsung' Puede moverla o quitarla según sea necesario.
        Me.SamsungTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Samsung)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Routers' Puede moverla o quitarla según sea necesario.
        Me.RoutersTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Routers)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Ratones' Puede moverla o quitarla según sea necesario.
        Me.RatonesTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Ratones)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Procesadores' Puede moverla o quitarla según sea necesario.
        Me.ProcesadoresTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Procesadores)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Portatiles' Puede moverla o quitarla según sea necesario.
        Me.PortatilesTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Portatiles)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.PlacasBase' Puede moverla o quitarla según sea necesario.
        Me.PlacasBaseTableAdapter.Fill(Me.Proyecto_TiendaDataSet.PlacasBase)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Nvidia' Puede moverla o quitarla según sea necesario.
        Me.NvidiaTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Nvidia)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Nintendo_Switch' Puede moverla o quitarla según sea necesario.
        Me.Nintendo_SwitchTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Nintendo_Switch)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Nintendo_3DS' Puede moverla o quitarla según sea necesario.
        Me.Nintendo_3DSTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Nintendo_3DS)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Monitores' Puede moverla o quitarla según sea necesario.
        Me.MonitoresTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Monitores)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Microsoft' Puede moverla o quitarla según sea necesario.
        Me.MicrosoftTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Microsoft)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Memoria_RAM' Puede moverla o quitarla según sea necesario.
        Me.Memoria_RAMTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Memoria_RAM)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.LG' Puede moverla o quitarla según sea necesario.
        Me.LGTableAdapter.Fill(Me.Proyecto_TiendaDataSet.LG)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Hubs_Switchs' Puede moverla o quitarla según sea necesario.
        Me.Hubs_SwitchsTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Hubs_Switchs)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Huawei' Puede moverla o quitarla según sea necesario.
        Me.HuaweiTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Huawei)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.HDMI' Puede moverla o quitarla según sea necesario.
        Me.HDMITableAdapter.Fill(Me.Proyecto_TiendaDataSet.HDMI)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet._Grabadoras_DVD_BluRay' Puede moverla o quitarla según sea necesario.
        Me.Grabadoras_DVD_BluRayTableAdapter.Fill(Me.Proyecto_TiendaDataSet._Grabadoras_DVD_BluRay)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.DVI' Puede moverla o quitarla según sea necesario.
        Me.DVITableAdapter.Fill(Me.Proyecto_TiendaDataSet.DVI)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Discos_Duros' Puede moverla o quitarla según sea necesario.
        Me.Discos_DurosTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Discos_Duros)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Cables_de_Red' Puede moverla o quitarla según sea necesario.
        Me.Cables_de_RedTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Cables_de_Red)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.BQ1' Puede moverla o quitarla según sea necesario.
        Me.BQ1TableAdapter.Fill(Me.Proyecto_TiendaDataSet.BQ1)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.BQ' Puede moverla o quitarla según sea necesario.
        'Me.BQTableAdapter.Fill(Me.Proyecto_TiendaDataSet.BQ)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Auriculares' Puede moverla o quitarla según sea necesario.
        Me.AuricularesTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Auriculares)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Asus1' Puede moverla o quitarla según sea necesario.
        Me.Asus1TableAdapter.Fill(Me.Proyecto_TiendaDataSet.Asus1)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Asus' Puede moverla o quitarla según sea necesario.
        Me.AsusTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Asus)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Apple1' Puede moverla o quitarla según sea necesario.
        Me.Apple1TableAdapter.Fill(Me.Proyecto_TiendaDataSet.Apple1)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Apple' Puede moverla o quitarla según sea necesario.
        Me.AppleTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Apple)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Antenas' Puede moverla o quitarla según sea necesario.
        Me.AntenasTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Antenas)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Altavoces' Puede moverla o quitarla según sea necesario.
        Me.AltavocesTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Altavoces)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Alfombrillas' Puede moverla o quitarla según sea necesario.
        Me.AlfombrillasTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Alfombrillas)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Alcatel' Puede moverla o quitarla según sea necesario.
        Me.AlcatelTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Alcatel)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Adaptadores_USB' Puede moverla o quitarla según sea necesario.
        Me.Adaptadores_USBTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Adaptadores_USB)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Adaptadores' Puede moverla o quitarla según sea necesario.
        Me.AdaptadoresTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Adaptadores)
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_TiendaDataSet.Acer' Puede moverla o quitarla según sea necesario.
        Me.AcerTableAdapter.Fill(Me.Proyecto_TiendaDataSet.Acer)

    End Sub
    Private Sub MonitoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitoresToolStripMenuItem.Click
        BindingSourceAdmin.DataMember = "Monitores"
    End Sub

    Private Sub AltavocesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltavocesToolStripMenuItem.Click
        BindingSourceAdmin.DataMember = "Altavoces"
    End Sub
    Private Sub TecladosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TecladosToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Teclados"

    End Sub

    Private Sub RatonesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RatonesToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Ratones"

    End Sub

    Private Sub AuricularesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuricularesToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Auriculares"

    End Sub

    Private Sub AlfombrillasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlfombrillasToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Alfombrillas"

    End Sub

    Private Sub WebcamsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebcamsToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Webcams"

    End Sub

    Private Sub AdptadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdptadoresToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Adaptadores"

    End Sub

    Private Sub CablesDVIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CablesDVIToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "DVI"

    End Sub

    Private Sub CablesHDMIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CablesHDMIToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "HDMI"

    End Sub

    Private Sub CablesUSBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CablesUSBToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "USB"

    End Sub

    Private Sub CablesVGAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CablesVGAToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "VGA"

    End Sub

    Private Sub AntenasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AntenasToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Antenas"

    End Sub

    Private Sub AdaptadoresUSBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdaptadoresUSBToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Adaptadores_USB"

    End Sub

    Private Sub CableDeRedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CableDeRedToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Cables_de_Red"

    End Sub

    Private Sub RoutersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoutersToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Routers"

    End Sub

    Private Sub TarjetasRedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarjetasRedToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Tarjetas_Red"

    End Sub

    Private Sub HubsSwitchsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HubsSwitchsToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Hubs_Switchs"

    End Sub

    Private Sub PlacaBaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlacaBaseToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "PlacasBase"

    End Sub

    Private Sub ProcesadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesadoresToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Procesadores"

    End Sub

    Private Sub DiscosDurosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscosDurosToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Discos_Duros"

    End Sub

    Private Sub TarjetasGraficasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarjetasGraficasToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Tarjetas_Graficas"

    End Sub

    Private Sub MemoriaRAMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemoriaRAMToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Memoria_RAM"

    End Sub

    Private Sub TarjetasDeSonidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarjetasDeSonidoToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Tarjetas_de_Sonido"

    End Sub

    Private Sub GrabadorasDVDBluRayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrabadorasDVDBluRayToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Grabadoras_DVD-BluRay"

    End Sub

    Private Sub SobremesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobremesaToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Sobremesa"

    End Sub

    Private Sub PortátilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PortátilesToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Portatiles"

    End Sub

    Private Sub AsusToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AsusToolStripMenuItem1.Click

        BindingSourceAdmin.DataMember = "Asus1"

    End Sub

    Private Sub AppleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AppleToolStripMenuItem1.Click

        BindingSourceAdmin.DataMember = "Apple1"

    End Sub

    Private Sub BQToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BQToolStripMenuItem1.Click

        BindingSourceAdmin.DataMember = "BQ1"

    End Sub

    Private Sub MicrosoftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Microsoft"

    End Sub

    Private Sub NvidiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NvidiaToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Nvidia"

    End Sub

    Private Sub SamsungToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SamsungToolStripMenuItem1.Click

        BindingSourceAdmin.DataMember = "Samsung1"

    End Sub

    Private Sub AcerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcerToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Acer"

    End Sub

    Private Sub AlcatelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlcatelToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Alcatel"

    End Sub

    Private Sub AppleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppleToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Apple"

    End Sub

    Private Sub AsusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsusToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Asus"

    End Sub

    Private Sub BQToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BQToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "BQ"

    End Sub

    Private Sub HuaweiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HuaweiToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Huawei"

    End Sub

    Private Sub LGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LGToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "LG"

    End Sub

    Private Sub SamsungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SamsungToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Samsung"

    End Sub

    Private Sub SonyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SonyToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Sony"

    End Sub

    Private Sub PS4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PS4ToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Sony_PS4"

    End Sub

    Private Sub SonyPSVitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SonyPSVitaToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Sony_PSVita"

    End Sub

    Private Sub XBOXONEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XBOXONEToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "XBOX_ONE"

    End Sub

    Private Sub WiiUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WiiUToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Nintendo_3DS"

    End Sub

    Private Sub NintendoSwithToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NintendoSwithToolStripMenuItem.Click

        BindingSourceAdmin.DataMember = "Nintendo_Switch"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim consulta As String = consultas.Text
            Dim connectionString As String = "Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog='Proyecto Tienda';Integrated Security=True"

            Dim connection As New SqlConnection(connectionString)
            Dim queryCommand As SqlClient.SqlCommand
            queryCommand = New SqlClient.SqlCommand
            queryCommand.CommandType = CommandType.Text
            queryCommand.CommandText = consulta
            queryCommand.Connection = connection
            connection.Open()

            Dim reader As SqlClient.SqlDataReader = queryCommand.ExecuteReader()

            ' Data is accessible through the DataReader object here.


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