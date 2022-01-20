Public Class FormTiket
    Public Shared tiket As ClassTiket
    Public Shared SelectDataTiket
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        tiket = New ClassTiket()
        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub
    Private Sub ReloadDataTableDatabase()
        DGVJadwal.DataSource = tiket.GetDataBioskopDatabase()
        DGVTiket.DataSource = tiket.GetDataTiketDatabase()
    End Sub
    Private Sub DGVTiket_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTiket.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGVTiket.Rows(index)

        SelectDataTiket = selectedRow.Cells(0).Value
    End Sub
    Private Sub FormTiket_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim formtiket = New TambahTiket()
        formtiket.Show()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If SelectDataTiket IsNot Nothing Then
            Dim selectedTiket As List(Of String) = tiket.GetDataTiketByID(SelectDataTiket)
            tiket.GSid_jadwaltayang = selectedTiket(0)
            tiket.GStotal_harga = selectedTiket(1)

            Dim update = New EditTiket()
            update.Show()
        End If
    End Sub
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If SelectDataTiket IsNot Nothing Then
            Dim Hapus = New HapusTiket()
            Hapus.Show()
        End If
    End Sub
End Class