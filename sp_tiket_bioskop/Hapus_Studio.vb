Public Class Hapus_Studio
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim studioInformation = Studio.ClassStudio.GetDataStudioByID(Studio.selectedStudioID)

        TBStudio.Text = "STUDIO ID " + studioInformation(0).ToString()
    End Sub

    Private Sub BtnHapusStudio_Click(sender As Object, e As EventArgs) Handles BtnHapusStudio.Click
        Studio.ClassStudio.DeleteDataStudioByID(Studio.selectedStudioID)
        Me.Close()
    End Sub
End Class