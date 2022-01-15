Public Class EditFilm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PicFoto.Load(FormFilm.Film.dirGambarFilmProperty)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        DateReleaseFilm.Format = DateTimePickerFormat.Custom
        DateReleaseFilm.CustomFormat = "yyyy/MM/dd"
        TxtNamaFilm.Text = FormFilm.Film.namaFilmProperty
        CBGenreFilm.SelectedItem() = FormFilm.Film.genreFilmProperty
        RTBDeskripsi.Text = FormFilm.Film.deskripsiFilmProperty
        TxtDirector.Text = FormFilm.Film.directorFilmProperty
        TxtDuration.Text = FormFilm.Film.durationFilmProperty
        TxtHargaFilm.Text = FormFilm.Film.hargaFilmProperty
        DateReleaseFilm.Value = FormFilm.Film.dateReleaseProperty


        If String.Compare(FormFilm.Film.bahasaProperty, "Indonesia") = 0 Then
            RBIndonesia.Checked = True
        ElseIf String.Compare(FormFilm.Film.bahasaProperty, "Inggris") = 0 Then
            RBInggris.Checked = True
        End If

    End Sub

    Private Sub BtnEditGambar_Click(sender As Object, e As EventArgs) Handles BtnEditGambar.Click
        OpenFileDialogFoto.Title = "Open Foto"
        OpenFileDialogFoto.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialogFoto.ShowDialog()

        Dim PicFilm As String = OpenFileDialogFoto.FileName

        PicFoto.Load(PicFilm)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        FormFilm.Film.dirGambarFilmProperty = PicFilm.ToString()
        FormFilm.Film.dirGambarFilmProperty = FormFilm.Film.dirGambarFilmProperty.Replace("\", "/")
    End Sub

    Private Sub BtnEditFilm_Click(sender As Object, e As EventArgs) Handles BtnEditFilm.Click
        FormFilm.Film.namaFilmProperty = TxtNamaFilm.Text
        FormFilm.Film.genreFilmProperty = CBGenreFilm.SelectedItem().ToString()
        FormFilm.Film.deskripsiFilmProperty = RTBDeskripsi.Text.ToString()
        FormFilm.Film.directorFilmProperty = TxtDirector.Text.ToString()
        FormFilm.Film.durationFilmProperty = TxtDuration.Text

        FormFilm.Film.dateReleaseProperty = DateReleaseFilm.Value.ToString("yyyy/MM/dd")
        FormFilm.Film.hargaFilmProperty = Integer.Parse(TxtHargaFilm.Text)

        If RBIndonesia.Checked Then
            FormFilm.Film.bahasaProperty = "Bahasa Indonesia"
        ElseIf RBInggris.Checked Then
            FormFilm.Film.bahasaProperty = "Bahasa Inggris"
        End If

        FormFilm.Film.AddKoleksiFilm(TxtNamaFilm.Text.ToString())
        'MessageBox.Show(FormFilm.SelectedTabKoleksiFilm )
        FormFilm.Film.UpdateDataKoleksiByIDDatabase(FormFilm.SelectedFilmID,
                                                    FormFilm.Film.dirGambarFilmProperty,
                                                    FormFilm.Film.namaFilmProperty,
                                                    FormFilm.Film.genreFilmProperty,
                                                    FormFilm.Film.directorFilmProperty,
                                                    FormFilm.Film.deskripsiFilmProperty,
                                                    FormFilm.Film.dateReleaseProperty,
                                                    FormFilm.Film.durationFilmProperty,
                                                    FormFilm.Film.hargaFilmProperty,
                                                    FormFilm.Film.bahasaProperty)


        Dim infoFilm = New InfoFilm()
        infoFilm.Show()
        Me.Close()
    End Sub
End Class