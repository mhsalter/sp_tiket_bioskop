Public Class Tambah_Studio

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub BtnTambahStudio_Click(sender As Object, e As EventArgs) Handles BtnTambahStudio.Click
        Studio.ClassStudio.kapasitasStudio = Integer.Parse(TxtKapasitas.Text)
        Studio.ClassStudio.hargakursiStudio = Integer.Parse(TxtHargaKursi.Text)

        Studio.ClassStudio.AddDataStudioDatabase(Studio.ClassStudio.kapasitasStudio,
                                                Studio.ClassStudio.hargakursiStudio)

        Me.Close()
    End Sub

    Private Sub TxtHargaKursi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHargaKursi.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukan Hanya Angka")
        End If
    End Sub
End Class