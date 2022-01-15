Public Class HapusFilm
    Private hapusTable As String
    Private namaTable As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        hapusTable = FormFilm.SelectedFilmID
        namaTable = FormFilm.SelectedTabKoleksiFilm
        LblNamaFilm.Text = namaTable
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        FormFilm.Film.DeleteDataKoleksiByIDDatabase(hapusTable)
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class