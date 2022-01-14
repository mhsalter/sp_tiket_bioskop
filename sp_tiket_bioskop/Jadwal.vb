Public Class Jadwal
    Public Shared Cjadwal As JadwalTayang
    Public Shared SelectedDataJadwal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Cjadwal = New JadwalTayang()
        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub
    Private Sub ReloadDataTableDatabase()
        DGVJadwalTayang.DataSource = Cjadwal.GetDataJadwalDatabase()
    End Sub
    Private Sub Jadwal_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub
    Private Sub DGVJadwalTayang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVJadwalTayang.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGVJadwalTayang.Rows(index)

        SelectedDataJadwal = selectedRow.Cells(0).Value

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim TambahJadwal = New TambahJadwal()
        TambahJadwal.Show()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        If SelectedDataJadwal IsNot Nothing Then
            Dim selectedJadwal As List(Of String) = Cjadwal.GetDataJadwalByID(SelectedDataJadwal)
            Cjadwal.GSid_film = selectedJadwal(0)
            Cjadwal.GSid_studio = selectedJadwal(1)
            Cjadwal.GStanggal = selectedJadwal(2)
            Cjadwal.GSwaktu_mulai = selectedJadwal(3)
            Cjadwal.GSwaktu_selesai = selectedJadwal(4)

            Dim Update = New EditJadwal()
            Update.Show()
        End If
    End Sub
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If SelectedDataJadwal IsNot Nothing Then
            Dim Hapus = New HapusJadwal()
            HapusJadwal.Show()
        End If
    End Sub
End Class