Public Class FormFilm
    Public Shared Film As Film
    Public Shared SelectedFilm As String
    Public Shared SelectedFilmID As String
    Public Shared SelectedTabKoleksiFilm As String
    Public Sub New()
        Film = New Film()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub
    Private Sub ReloadDataTableDatabase()
        DataGridViewFilm.DataSource = Film.GetDataKoleksiDatabase()
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim tambah_film = New TambahFilm()
        tambah_film.Show()
    End Sub
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim formHapus = New HapusFilm()
        formHapus.Show()
    End Sub
    Private Sub FormFilm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ListBoxFilm.Items.Clear()

        For Each koll In Film.getKoleksiItem
            ListBoxFilm.Items.Add(koll)
        Next

        ReloadDataTableDatabase()
        UpdateDataTableArrayList()
    End Sub
    Private Sub ListBoxFilm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxFilm.SelectedIndexChanged
        SelectedFilm = ListBoxFilm.SelectedItem()
    End Sub
    Public Sub UpdateDataTableArrayList()
        For Each rowFilm In Film.getKoleksiDataTable()
            Dim dataTable As String() = {rowFilm(1),
                                         rowFilm(2),
                                         rowFilm(3),
                                         rowFilm(4),
                                         rowFilm(5),
                                         rowFilm(6),
                                         rowFilm(7),
                                         rowFilm(8),
                                         rowFilm(9)}
            DataGridViewFilm.Rows.Add(dataTable)
            DataGridViewFilm.Rows.Clear()
        Next
    End Sub
    Private Sub DataGridViewFilm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewFilm.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewFilm.Rows(index)

        SelectedFilmID = selectedRow.Cells(0).Value
        SelectedTabKoleksiFilm = selectedRow.Cells(1).Value
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim selectedfilm As List(Of String) = Film.GetDataKoleksiByIDDatabase(SelectedFilmID)

        Film.dirGambarFilmProperty = selectedfilm(9)

        Film.namaFilmProperty = selectedfilm(1)
        Film.genreFilmProperty = selectedfilm(2)
        Film.deskripsiFilmProperty = selectedfilm(3)
        Film.directorFilmProperty = selectedfilm(4)
        Film.durationFilmProperty = selectedfilm(5)
        Film.dateReleaseProperty = selectedfilm(6)
        Film.hargaFilmProperty = selectedfilm(8)
        Film.bahasaProperty = selectedfilm(7)


        Dim formUpdate = New EditFilm()
        formUpdate.Show()
    End Sub
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Dim selectedfilm As List(Of String) = Film.GetDataKoleksiByIDDatabase(SelectedFilmID)

        Film.dirGambarFilmProperty = selectedfilm(9)

        Film.namaFilmProperty = selectedfilm(1)
        Film.genreFilmProperty = selectedfilm(2)
        Film.deskripsiFilmProperty = selectedfilm(3)
        Film.directorFilmProperty = selectedfilm(4)
        Film.durationFilmProperty = selectedfilm(5)
        Film.dateReleaseProperty = selectedfilm(6)
        Film.hargaFilmProperty = selectedfilm(8)
        Film.bahasaProperty = selectedfilm(7)


        Dim formSelect = New InfoFilm()
        formSelect.Show()
    End Sub
End Class



