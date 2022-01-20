Public Class HapusTiket
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblTiket.Text = "Tiket ID " + FormTiket.SelectDataTiket.ToString()
    End Sub
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        FormTiket.tiket.DeleteDataTiketByID(FormTiket.SelectDataTiket)
        Me.Close()
    End Sub
End Class