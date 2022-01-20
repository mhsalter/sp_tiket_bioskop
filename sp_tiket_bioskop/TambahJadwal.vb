Public Class TambahJadwal
    Dim datafilm As New List(Of String)
    Dim datastudio As New List(Of String)

    'Public Shared jadwaltayang As New Jadwal()
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Jadwal.Cjadwal.GetDataFilm()

        datafilm = Jadwal.Cjadwal.GetDataFilm()
        CBFilm.Items.Clear()
        For Each film In datafilm
            CBFilm.Items.Add(film)
        Next

        datastudio = Jadwal.Cjadwal.GetDataStudio()
        CBStudio.Items.Clear()
        For Each studio In datastudio
            CBStudio.Items.Add(studio)
        Next
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub CBFilm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBFilm.SelectedIndexChanged
        Dim duration As DateTime = Jadwal.Cjadwal.GetDataDuration(CBFilm.SelectedItem.ToString())
        DTPWaktuSelesai.Value = DTPWaktuMulai.Value.AddHours(duration.Hour)
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        'set value
        Jadwal.Cjadwal.GSid_film = CBFilm.SelectedItem().ToString()
        Jadwal.Cjadwal.GSid_studio = CBStudio.SelectedItem().ToString()
        Jadwal.Cjadwal.GStanggal = DTPJadwal.Value.ToString("yyyy/MM/dd")
        Jadwal.Cjadwal.GSwaktu_mulai = DTPWaktuMulai.Value.ToString("HH:mm:ss")
        Jadwal.Cjadwal.GSwaktu_selesai = DTPWaktuSelesai.Value.ToString("HH:mm:ss")

        'addJadwal
        Jadwal.Cjadwal.AddDataJadwalTayangDatabase(Jadwal.Cjadwal.GSid_film,
                                                    Jadwal.Cjadwal.GSid_studio,
                                                    Jadwal.Cjadwal.GStanggal,
                                                    Jadwal.Cjadwal.GSwaktu_mulai,
                                                    Jadwal.Cjadwal.GSwaktu_selesai
                                                    )

        'Tutup Jadwal
        Me.Close()
    End Sub
End Class