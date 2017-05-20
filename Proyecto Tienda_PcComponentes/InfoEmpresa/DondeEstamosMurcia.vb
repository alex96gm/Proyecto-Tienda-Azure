Public Class DondeEstamosMurcia
    Private Sub DondeEstamosMurcia_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim urlMaps As String = "https://www.google.com/maps/embed/v1/place?&q=PcComponentes+Murcia&key="
        Const clave As String = "AIzaSyDzTBXl2uqIct9fUNBBaVzP6AM92v7OjNE"
        WebBrowser1.AllowNavigation = True
        WebBrowser1.ScriptErrorsSuppressed = True

        urlMaps = urlMaps & clave

        WebBrowser1.DocumentText = "
                                    <html>
                                        <head>
                                        </head>
                                        <body>
                                            <iframe width='709' height='633' frameborder='0' style='border:0' src='" + urlMaps + "'></iframe> 
                                        </body>
                                    </html>
                                   "


        Dim color As Integer
        color = RGB(254, 127, 0)

        Panel1.BackColor = ColorTranslator.FromOle(color)
    End Sub
End Class