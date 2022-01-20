Public Class EditJadwal
    Dim datafilm As New List(Of String)
    Dim datastudio As New List(Of String)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
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

        DTPWaktuMulai.Format = DateTimePickerFormat.Custom
        DTPWaktuMulai.CustomFormat = "HH:mm:ss"
        DTPWaktuSelesai.Format = DateTimePickerFormat.Custom
        DTPWaktuSelesai.CustomFormat = "HH:mm:ss"

        ' Add any initialization after the InitializeComponent() call.
        CBFilm.SelectedItem() = Jadwal.Cjadwal.GSid_film
        CBStudio.SelectedItem = Jadwal.Cjadwal.GSid_studio
        DTPJadwal.Value = Jadwal.Cjadwal.GStanggal
        DTPWaktuMulai.Value = Convert.ToDateTime(Jadwal.Cjadwal.GSwaktu_mulai)
        DTPWaktuSelesai.Value = Convert.ToDateTime(Jadwal.Cjadwal.GSwaktu_selesai)

    End Sub
    Private Sub DTPWaktuMulai_ValueChanged(sender As Object, e As EventArgs) Handles DTPWaktuMulai.ValueChanged
        Dim duration As DateTime = Jadwal.Cjadwal.GetUpdateDuration()
        DTPWaktuSelesai.Value = DTPWaktuMulai.Value.AddHours(duration.Hour)
    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        'set value
        Jadwal.Cjadwal.GSid_film = CBFilm.SelectedItem().ToString()
        Jadwal.Cjadwal.GSid_studio = CBStudio.SelectedItem().ToString()
        Jadwal.Cjadwal.GStanggal = DTPJadwal.Value.ToString("yyyy/MM/dd")
        Jadwal.Cjadwal.GSwaktu_mulai = DTPWaktuMulai.Value.ToString("HH:mm:ss")
        Jadwal.Cjadwal.GSwaktu_selesai = DTPWaktuSelesai.Value.ToString("HH:mm:ss")

        'EditJadwal
        Jadwal.Cjadwal.UpdateDataJadwalByID(Jadwal.SelectedDataJadwal,
                                                    Jadwal.Cjadwal.GSid_film,
                                                    Jadwal.Cjadwal.GSid_studio,
                                                    Jadwal.Cjadwal.GStanggal,
                                                    Jadwal.Cjadwal.GSwaktu_mulai,
                                                    Jadwal.Cjadwal.GSwaktu_selesai
                                                    )

        'tutup edit
        Me.Close()

    End Sub
End Class