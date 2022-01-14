﻿Public Class Edit_Studio

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        TxtKapasitas.Text = Studio.ClassStudio.kapasitasStudio
        TxtHargaKursi.Text = Studio.ClassStudio.hargakursiStudio
    End Sub


    Private Sub TxtHargaKursi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHargaKursi.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukan Hanya Angka")
        End If
    End Sub

    Private Sub BtnEditStudio_Click(sender As Object, e As EventArgs) Handles BtnEditStudio.Click
        Studio.ClassStudio.kapasitasStudio = TxtKapasitas.Text.ToString()
        Studio.ClassStudio.hargakursiStudio = Integer.Parse(TxtHargaKursi.Text)

        Studio.ClassStudio.EditDataStudioByID(Studio.selectedStudioID,
                                              Studio.ClassStudio.kapasitasStudio,
                                              Studio.ClassStudio.hargakursiStudio)

        Me.Close()
    End Sub
End Class