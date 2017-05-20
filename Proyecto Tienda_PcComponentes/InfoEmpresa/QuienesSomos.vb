Public Class QuienesSomos
    Private Sub facebook_Click(sender As Object, e As EventArgs) Handles facebook.Click
        Process.Start("https://www.facebook.com/pccomponentes")
    End Sub

    Private Sub twitter_Click(sender As Object, e As EventArgs) Handles twitter.Click
        Process.Start("https://twitter.com/pccomponentes")
    End Sub

    Private Sub google_Click(sender As Object, e As EventArgs) Handles google.Click
        Process.Start("https://plus.google.com/+pccomponentes")
    End Sub

    Private Sub instagram_Click(sender As Object, e As EventArgs) Handles instagram.Click
        Process.Start("https://www.instagram.com/pccomponentes/")
    End Sub

    Private Sub youtube_Click(sender As Object, e As EventArgs) Handles youtube.Click
        Process.Start("https://www.youtube.com/user/PcComponentescom")
    End Sub

    Private Sub QuienesSomos_Load(sender As Object, e As EventArgs) Handles Me.Load
        ''rojo 254 verde 127 azul 0 hex fe7f00
        Dim color As Integer
        color = RGB(254, 127, 0)

        Panel1.BackColor = ColorTranslator.FromOle(color)
        Panel2.BackColor = ColorTranslator.FromOle(color)
        Panel3.BackColor = ColorTranslator.FromOle(color)
    End Sub
End Class