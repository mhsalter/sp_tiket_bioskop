Public Class TambahFilm

    Dim MaxChar = 50
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DateReleaseFilm.Format = DateTimePickerFormat.Custom
        DateReleaseFilm.CustomFormat = "yyyy/MM/dd"
    End Sub
    Private Sub BtnTambahFilm_Click(sender As Object, e As EventArgs) Handles BtnTambahFilm.Click
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

        FormFilm.Film.AddDataKoleksiDatabase(FormFilm.Film.dirGambarFilmProperty,
                                             FormFilm.Film.namaFilmProperty,
                                             FormFilm.Film.genreFilmProperty,
                                             FormFilm.Film.directorFilmProperty,
                                             FormFilm.Film.deskripsiFilmProperty,
                                             FormFilm.Film.dateReleaseProperty,
                                             FormFilm.Film.durationFilmProperty,
                                             FormFilm.Film.hargaFilmProperty,
                                             FormFilm.Film.bahasaProperty)

        Dim Info_Film = New InfoFilm()
        Info_Film.Show()
        Me.Close()

    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialogFoto.Title = "Open Foto"
        OpenFileDialogFoto.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialogFoto.ShowDialog()

        Dim PicKoleksi As String = OpenFileDialogFoto.FileName

        PicFoto.Load(PicKoleksi)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        FormFilm.Film.dirGambarFilmProperty = PicKoleksi.ToString()
        FormFilm.Film.dirGambarFilmProperty = FormFilm.Film.dirGambarFilmProperty.Replace("\", "/")
    End Sub

    Private Sub TxtNamaFilm_Leave(sender As Object, e As EventArgs) Handles TxtNamaFilm.Leave
        If TxtNamaFilm.Text.Length < 1 Then
            TxtNamaFilm.Select()
            MessageBox.Show("Please add Least 1 String")
        End If
    End Sub

    Private Sub TxtDuration_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDuration.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub TxtHargaFilm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHargaFilm.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If

    End Sub

    Private Sub RTBDeskripsi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RTBDeskripsi.KeyPress
        If RTBDeskripsi.Text.Length >= MaxChar Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Max Length")
            End If
        End If

        LblAngka.Text = (MaxChar - RTBDeskripsi.Text.Length)
    End Sub
End Class