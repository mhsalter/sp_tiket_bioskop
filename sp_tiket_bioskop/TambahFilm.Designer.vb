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
        Me.TxtDuration = New System.Windows.Forms.TextBox()
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
        Me.BtnTambahGambar.Location = New System.Drawing.Point(26, 199)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(143, 40)
        Me.BtnTambahGambar.TabIndex = 45
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = False
        '
        'RBInggris
        '
        Me.RBInggris.AutoSize = True
        Me.RBInggris.Location = New System.Drawing.Point(6, 55)
        Me.RBInggris.Name = "RBInggris"
        Me.RBInggris.Size = New System.Drawing.Size(132, 24)
        Me.RBInggris.TabIndex = 1
        Me.RBInggris.TabStop = True
        Me.RBInggris.Text = "Bahasa Iggris"
        Me.RBInggris.UseVisualStyleBackColor = True
        '
        'RBIndonesia
        '
        Me.RBIndonesia.AutoSize = True
        Me.RBIndonesia.Location = New System.Drawing.Point(6, 25)
        Me.RBIndonesia.Name = "RBIndonesia"
        Me.RBIndonesia.Size = New System.Drawing.Size(163, 24)
        Me.RBIndonesia.TabIndex = 0
        Me.RBIndonesia.TabStop = True
        Me.RBIndonesia.Text = "Bahasa Indonesia"
        Me.RBIndonesia.UseVisualStyleBackColor = True
        '
        'BtnTambahFilm
        '
        Me.BtnTambahFilm.BackColor = System.Drawing.SystemColors.Window
        Me.BtnTambahFilm.Location = New System.Drawing.Point(659, 576)
        Me.BtnTambahFilm.Name = "BtnTambahFilm"
        Me.BtnTambahFilm.Size = New System.Drawing.Size(143, 40)
        Me.BtnTambahFilm.TabIndex = 46
        Me.BtnTambahFilm.Text = "Tambah Film"
        Me.BtnTambahFilm.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBInggris)
        Me.GroupBox1.Controls.Add(Me.RBIndonesia)
        Me.GroupBox1.Location = New System.Drawing.Point(361, 358)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 91)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'TxtHargaFilm
        '
        Me.TxtHargaFilm.Location = New System.Drawing.Point(361, 315)
        Me.TxtHargaFilm.Name = "TxtHargaFilm"
        Me.TxtHargaFilm.Size = New System.Drawing.Size(275, 26)
        Me.TxtHargaFilm.TabIndex = 42
        '
        'DateReleaseFilm
        '
        Me.DateReleaseFilm.Location = New System.Drawing.Point(361, 274)
        Me.DateReleaseFilm.Name = "DateReleaseFilm"
        Me.DateReleaseFilm.Size = New System.Drawing.Size(275, 26)
        Me.DateReleaseFilm.TabIndex = 41
        '
        'TxtDuration
        '
        Me.TxtDuration.Location = New System.Drawing.Point(361, 231)
        Me.TxtDuration.Name = "TxtDuration"
        Me.TxtDuration.Size = New System.Drawing.Size(275, 26)
        Me.TxtDuration.TabIndex = 39
        '
        'TxtDirector
        '
        Me.TxtDirector.Location = New System.Drawing.Point(361, 199)
        Me.TxtDirector.Name = "TxtDirector"
        Me.TxtDirector.Size = New System.Drawing.Size(275, 26)
        Me.TxtDirector.TabIndex = 38
        '
        'RTBDeskripsi
        '
        Me.RTBDeskripsi.Location = New System.Drawing.Point(361, 93)
        Me.RTBDeskripsi.Name = "RTBDeskripsi"
        Me.RTBDeskripsi.Size = New System.Drawing.Size(275, 96)
        Me.RTBDeskripsi.TabIndex = 37
        Me.RTBDeskripsi.Text = ""
        '
        'CBGenreFilm
        '
        Me.CBGenreFilm.FormattingEnabled = True
        Me.CBGenreFilm.Items.AddRange(New Object() {"Horror", "Action", "Comedy", "Drama", "Romance"})
        Me.CBGenreFilm.Location = New System.Drawing.Point(361, 58)
        Me.CBGenreFilm.Name = "CBGenreFilm"
        Me.CBGenreFilm.Size = New System.Drawing.Size(275, 28)
        Me.CBGenreFilm.TabIndex = 36
        '
        'TxtNamaFilm
        '
        Me.TxtNamaFilm.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNamaFilm.Location = New System.Drawing.Point(361, 25)
        Me.TxtNamaFilm.Name = "TxtNamaFilm"
        Me.TxtNamaFilm.Size = New System.Drawing.Size(275, 26)
        Me.TxtNamaFilm.TabIndex = 35
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(26, 25)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(143, 159)
        Me.PicFoto.TabIndex = 34
        Me.PicFoto.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(175, 356)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Bahasa :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(175, 314)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 20)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Harga Film :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(175, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 20)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Date Release Film :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(175, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Durasi Film :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(175, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Director :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(175, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Deskripsi :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Genre Film :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nama Film :"
        '
        'LblAngka
        '
        Me.LblAngka.AutoSize = True
        Me.LblAngka.BackColor = System.Drawing.SystemColors.Window
        Me.LblAngka.Location = New System.Drawing.Point(599, 164)
        Me.LblAngka.Name = "LblAngka"
        Me.LblAngka.Size = New System.Drawing.Size(27, 20)
        Me.LblAngka.TabIndex = 47
        Me.LblAngka.Text = "50"
        '
        'TambahFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 640)
        Me.Controls.Add(Me.LblAngka)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.BtnTambahFilm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtHargaFilm)
        Me.Controls.Add(Me.DateReleaseFilm)
        Me.Controls.Add(Me.TxtDuration)
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
    Friend WithEvents TxtDuration As TextBox
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
End Class
