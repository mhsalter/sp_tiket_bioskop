Public Class Home
    Private Sub FilmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilmToolStripMenuItem.Click
        Dim film As New FormFilm
        film.Show()
    End Sub
    Private Sub StudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudioToolStripMenuItem.Click
        Dim studio As New Studio
        studio.Show()
    End Sub
    Private Sub JadwalTayangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JadwalTayangToolStripMenuItem.Click
        Dim jadwal_tayang As New Jadwal
        jadwal_tayang.Show()
    End Sub
    Private Sub TiketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiketToolStripMenuItem.Click
        Dim tiket As New FormTiket
        tiket.Show()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Process.Start("https://www.instagram.com/mhs.rama/")
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Process.Start("https://www.instagram.com/inilhamf/?utm_medium=copy_link")
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Process.Start("http://instagram.com/hedy_tiesya")
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Process.Start("http://instagram.com/kautsar_arief")
    End Sub
End Class