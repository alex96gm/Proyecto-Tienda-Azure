﻿Public Class QuienesSomos
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
End Class