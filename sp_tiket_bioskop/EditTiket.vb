Public Class EditTiket
    Dim datajadwal As New List(Of String)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        datajadwal = FormTiket.tiket.GetDataJadwal()
        CBJadwalTayang.Items.Clear()
        For Each jadwal In datajadwal
            CBJadwalTayang.Items.Add(jadwal)
        Next
        ' Add any initialization after the InitializeComponent() call.

        CBJadwalTayang.SelectedItem() = FormTiket.tiket.GSid_jadwaltayang
        TBTotalHarga.Text = FormTiket.tiket.GStotal_harga

    End Sub
    Private Sub CBJadwalTayang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBJadwalTayang.SelectedIndexChanged
        Dim namafilm As String = FormTiket.tiket.GetDataNamaFilm(CBJadwalTayang.SelectedItem.ToString())
        TBFilm.Text = namafilm
        Dim hargakursi As Integer = FormTiket.tiket.GetDataHargaKursi(CBJadwalTayang.SelectedItem.ToString())
        TBHargaKursi.Text = hargakursi
        Dim hargafilm As Integer = FormTiket.tiket.GetDataHargaFilm(CBJadwalTayang.SelectedItem.ToString())
        TBHargaFilm.Text = hargafilm
        TBTotalHarga.Text = hargakursi + hargafilm
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        'set value
        FormTiket.tiket.GSid_jadwaltayang = CBJadwalTayang.SelectedItem().ToString()
        FormTiket.tiket.GStotal_harga = TBTotalHarga.Text

        'EditJadwal
        FormTiket.tiket.UpdateDataTiketByID(FormTiket.SelectDataTiket,
                                            FormTiket.tiket.GSid_jadwaltayang,
                                            FormTiket.tiket.GStotal_harga)

        'Tutup Edit
        Me.Close()
    End Sub
End Class