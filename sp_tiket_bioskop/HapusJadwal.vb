Public Class HapusJadwal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblJadwal.Text = "Jadwal Tayang ID " + Jadwal.SelectedDataJadwal.ToString()
    End Sub
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Jadwal.Cjadwal.DeleteDataJadwalByID(Jadwal.SelectedDataJadwal)
        Me.Close()
    End Sub
End Class