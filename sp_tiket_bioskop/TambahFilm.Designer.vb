<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahFilm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialogFoto = New System.Windows.Forms.OpenFileDialog()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.RBInggris = New System.Windows.Forms.RadioButton()
        Me.RBIndonesia = New System.Windows.Forms.RadioButton()
        Me.BtnTambahFilm = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtHargaFilm = New System.Windows.Forms.TextBox()
        Me.DateReleaseFilm = New System.Windows.Forms.DateTimePicker()
        Me.TxtDirector = New System.Windows.Forms.TextBox()
        Me.RTBDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.CBGenreFilm = New System.Windows.Forms.ComboBox()
        Me.TxtNamaFilm = New System.Windows.Forms.TextBox()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblAngka = New System.Windows.Forms.Label()
        Me.DTPDuration = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialogFoto
        '
        Me.OpenFileDialogFoto.FileName = "OpenFileDialogFoto"
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.BackColor = System.Drawing.SystemColors.Window
        Me.BtnTambahGambar.Location = New System.Drawing.Point(17, 129)
        Me.BtnTambahGambar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(95, 26)
        Me.BtnTambahGambar.TabIndex = 45
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = False
        '
        'RBInggris
        '
        Me.RBInggris.AutoSize = True
        Me.RBInggris.Location = New System.Drawing.Point(4, 36)
        Me.RBInggris.Margin = New System.Windows.Forms.Padding(2)
        Me.RBInggris.Name = "RBInggris"
        Me.RBInggris.Size = New System.Drawing.Size(89, 17)
        Me.RBInggris.TabIndex = 1
        Me.RBInggris.TabStop = True
        Me.RBInggris.Text = "Bahasa Iggris"
        Me.RBInggris.UseVisualStyleBackColor = True
        '
        'RBIndonesia
        '
        Me.RBIndonesia.AutoSize = True
        Me.RBIndonesia.Location = New System.Drawing.Point(4, 16)
        Me.RBIndonesia.Margin = New System.Windows.Forms.Padding(2)
        Me.RBIndonesia.Name = "RBIndonesia"
        Me.RBIndonesia.Size = New System.Drawing.Size(110, 17)
        Me.RBIndonesia.TabIndex = 0
        Me.RBIndonesia.TabStop = True
        Me.RBIndonesia.Text = "Bahasa Indonesia"
        Me.RBIndonesia.UseVisualStyleBackColor = True
        '
        'BtnTambahFilm
        '
        Me.BtnTambahFilm.BackColor = System.Drawing.SystemColors.Window
        Me.BtnTambahFilm.Location = New System.Drawing.Point(445, 306)
        Me.BtnTambahFilm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTambahFilm.Name = "BtnTambahFilm"
        Me.BtnTambahFilm.Size = New System.Drawing.Size(95, 26)
        Me.BtnTambahFilm.TabIndex = 46
        Me.BtnTambahFilm.Text = "Tambah Film"
        Me.BtnTambahFilm.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBInggris)
        Me.GroupBox1.Controls.Add(Me.RBIndonesia)
        Me.GroupBox1.Location = New System.Drawing.Point(241, 233)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(183, 59)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'TxtHargaFilm
        '
        Me.TxtHargaFilm.Location = New System.Drawing.Point(241, 205)
        Me.TxtHargaFilm.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtHargaFilm.Name = "TxtHargaFilm"
        Me.TxtHargaFilm.Size = New System.Drawing.Size(185, 20)
        Me.TxtHargaFilm.TabIndex = 42
        '
        'DateReleaseFilm
        '
        Me.DateReleaseFilm.Location = New System.Drawing.Point(241, 178)
        Me.DateReleaseFilm.Margin = New System.Windows.Forms.Padding(2)
        Me.DateReleaseFilm.Name = "DateReleaseFilm"
        Me.DateReleaseFilm.Size = New System.Drawing.Size(185, 20)
        Me.DateReleaseFilm.TabIndex = 41
        '
        'TxtDirector
        '
        Me.TxtDirector.Location = New System.Drawing.Point(241, 129)
        Me.TxtDirector.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDirector.Name = "TxtDirector"
        Me.TxtDirector.Size = New System.Drawing.Size(185, 20)
        Me.TxtDirector.TabIndex = 38
        '
        'RTBDeskripsi
        '
        Me.RTBDeskripsi.Location = New System.Drawing.Point(241, 60)
        Me.RTBDeskripsi.Margin = New System.Windows.Forms.Padding(2)
        Me.RTBDeskripsi.Name = "RTBDeskripsi"
        Me.RTBDeskripsi.Size = New System.Drawing.Size(185, 64)
        Me.RTBDeskripsi.TabIndex = 37
        Me.RTBDeskripsi.Text = ""
        '
        'CBGenreFilm
        '
        Me.CBGenreFilm.FormattingEnabled = True
        Me.CBGenreFilm.Items.AddRange(New Object() {"Horror", "Action", "Comedy", "Drama", "Romance"})
        Me.CBGenreFilm.Location = New System.Drawing.Point(241, 38)
        Me.CBGenreFilm.Margin = New System.Windows.Forms.Padding(2)
        Me.CBGenreFilm.Name = "CBGenreFilm"
        Me.CBGenreFilm.Size = New System.Drawing.Size(185, 21)
        Me.CBGenreFilm.TabIndex = 36
        '
        'TxtNamaFilm
        '
        Me.TxtNamaFilm.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNamaFilm.Location = New System.Drawing.Point(241, 16)
        Me.TxtNamaFilm.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNamaFilm.Name = "TxtNamaFilm"
        Me.TxtNamaFilm.Size = New System.Drawing.Size(185, 20)
        Me.TxtNamaFilm.TabIndex = 35
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(17, 16)
        Me.PicFoto.Margin = New System.Windows.Forms.Padding(2)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(95, 103)
        Me.PicFoto.TabIndex = 34
        Me.PicFoto.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(117, 231)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Bahasa :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(117, 204)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Harga Film :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(117, 178)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Date Release Film :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(117, 154)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Durasi Film :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(117, 131)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Director :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Deskripsi :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Genre Film :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nama Film :"
        '
        'LblAngka
        '
        Me.LblAngka.AutoSize = True
        Me.LblAngka.BackColor = System.Drawing.SystemColors.Window
        Me.LblAngka.Location = New System.Drawing.Point(399, 107)
        Me.LblAngka.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblAngka.Name = "LblAngka"
        Me.LblAngka.Size = New System.Drawing.Size(19, 13)
        Me.LblAngka.TabIndex = 47
        Me.LblAngka.Text = "50"
        '
        'DTPDuration
        '
        Me.DTPDuration.CustomFormat = "HH:mm:ss"
        Me.DTPDuration.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPDuration.Location = New System.Drawing.Point(241, 153)
        Me.DTPDuration.Name = "DTPDuration"
        Me.DTPDuration.ShowUpDown = True
        Me.DTPDuration.Size = New System.Drawing.Size(185, 20)
        Me.DTPDuration.TabIndex = 48
        '
        'TambahFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 343)
        Me.Controls.Add(Me.DTPDuration)
        Me.Controls.Add(Me.LblAngka)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.BtnTambahFilm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtHargaFilm)
        Me.Controls.Add(Me.DateReleaseFilm)
        Me.Controls.Add(Me.TxtDirector)
        Me.Controls.Add(Me.RTBDeskripsi)
        Me.Controls.Add(Me.CBGenreFilm)
        Me.Controls.Add(Me.TxtNamaFilm)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TambahFilm"
        Me.Text = "TambahFilm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialogFoto As OpenFileDialog
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents RBInggris As RadioButton
    Friend WithEvents RBIndonesia As RadioButton
    Friend WithEvents BtnTambahFilm As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtHargaFilm As TextBox
    Friend WithEvents DateReleaseFilm As DateTimePicker
    Friend WithEvents TxtDirector As TextBox
    Friend WithEvents RTBDeskripsi As RichTextBox
    Friend WithEvents CBGenreFilm As ComboBox
    Friend WithEvents TxtNamaFilm As TextBox
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblAngka As Label
    Friend WithEvents DTPDuration As DateTimePicker
End Class
