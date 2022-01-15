Public Class InfoFilm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        Pic.Load(FormFilm.Film.dirGambarFilmProperty)
        Pic.SizeMode = PictureBoxSizeMode.StretchImage

        LblNamaFilm.Text = FormFilm.Film.namaFilmProperty
        LblGenreFilm.Text = FormFilm.Film.genreFilmProperty
        LblDeskripsi.Text = FormFilm.Film.deskripsiFilmProperty
        LblDirector.Text = FormFilm.Film.directorFilmProperty
        LblDateReleaseFilm.Text = FormFilm.Film.dateReleaseProperty
        LblHargaFilm.Text = FormFilm.Film.hargaFilmProperty
        LblDurasiFilm.Text = FormFilm.Film.durationFilmProperty
        LblBahasa.Text = FormFilm.Film.bahasaProperty

    End Sub
    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        FormFilm.Film.dirGambarFilmProperty = ""

        FormFilm.Film.namaFilmProperty = ""
        FormFilm.Film.directorFilmProperty = ""
        FormFilm.Film.deskripsiFilmProperty = ""
        FormFilm.Film.hargaFilmProperty = 0
        FormFilm.Film.bahasaProperty = ""
        FormFilm.Film.durationFilmProperty = 0
        FormFilm.Film.dateReleaseProperty = ""

        Me.Close()

    End Sub
End Class