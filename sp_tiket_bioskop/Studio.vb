Public Class Studio
    Public Shared ClassStudio As Class_Studio
    Public Shared selectedStudioID As Integer
    Public Sub New()

        ClassStudio = New Class_Studio
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ReloadDataTableDatabase()

    End Sub

    Private Sub Studio_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridViewStudio.DataSource = ClassStudio.GetDataStudioDatabase()
    End Sub

    Private Sub DataGridViewStudio_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewStudio.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewStudio.Rows(index)
        selectedStudioID = selectedRow.Cells(0).Value
        ClassStudio.kapasitasStudio = selectedRow.Cells(1).Value
        ClassStudio.hargakursiStudio = selectedRow.Cells(2).Value

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim tambahstudio = New Tambah_Studio
        tambahstudio.Show()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim editstudio = New Edit_Studio
        editstudio.Show()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim hapusstudio = New Hapus_Studio
        hapusstudio.Show()
    End Sub




End Class