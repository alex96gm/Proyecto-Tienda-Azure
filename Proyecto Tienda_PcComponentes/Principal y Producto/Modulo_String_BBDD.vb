Module Modulo_String_BBDD


    Public String_BBDD As String
    '-------------------------------------------
    Public Sub cerrarSesion()
        PaginaPrincipal.cuenta.Enabled = False
        PaginaPrincipal.MiCarrito.Enabled = False
        PaginaPrincipal.RegistroEntrar.Visible = True
        PaginaPrincipal.cuenta.Text = "Cuenta"
    End Sub
    Public Sub abrirSesion()
        PaginaPrincipal.cuenta.Enabled = True
        PaginaPrincipal.MiCarrito.Enabled = True
        PaginaPrincipal.RegistroEntrar.Visible = False

    End Sub

End Module
