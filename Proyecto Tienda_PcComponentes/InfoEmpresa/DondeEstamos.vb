﻿Public Class DondeEstamos
    Private Sub DondeEstamos_Invalidated(sender As Object, e As InvalidateEventArgs) Handles Me.Invalidated
        Dim urlMaps As String = "https://www.google.com/maps/embed/v1/place?&q=PcComponentes+Madrid+Store&key="
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
    End Sub
End Class