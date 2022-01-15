<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoFilm
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
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.LblBahasa = New System.Windows.Forms.Label()
        Me.LblHargaFilm = New System.Windows.Forms.Label()
        Me.LblDateReleaseFilm = New System.Windows.Forms.Label()
        Me.LblDurasiFilm = New System.Windows.Forms.Label()
        Me.LblDirector = New System.Windows.Forms.Label()
        Me.LblDeskripsi = New System.Windows.Forms.Label()
        Me.LblGenreFilm = New System.Windows.Forms.Label()
        Me.LblNamaFilm = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(370, 427)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(96, 38)
        Me.BtnTutup.TabIndex = 68
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'LblBahasa
        '
        Me.LblBahasa.AutoSize = True
        Me.LblBahasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBahasa.Location = New System.Drawing.Point(415, 348)
        Me.LblBahasa.Name = "LblBahasa"
        Me.LblBahasa.Size = New System.Drawing.Size(70, 20)
        Me.LblBahasa.TabIndex = 67
        Me.LblBahasa.Text = "Bahasa"
        '
        'LblHargaFilm
        '
        Me.LblHargaFilm.AutoSize = True
        Me.LblHargaFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHargaFilm.Location = New System.Drawing.Point(458, 308)
        Me.LblHargaFilm.Name = "LblHargaFilm"
        Me.LblHargaFilm.Size = New System.Drawing.Size(96, 20)
        Me.LblHargaFilm.TabIndex = 66
        Me.LblHargaFilm.Text = "Harga Film"
        '
        'LblDateReleaseFilm
        '
        Me.LblDateReleaseFilm.AutoSize = True
        Me.LblDateReleaseFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateReleaseFilm.Location = New System.Drawing.Point(415, 274)
        Me.LblDateReleaseFilm.Name = "LblDateReleaseFilm"
        Me.LblDateReleaseFilm.Size = New System.Drawing.Size(119, 20)
        Me.LblDateReleaseFilm.TabIndex = 65
        Me.LblDateReleaseFilm.Text = "Date Release"
        '
        'LblDurasiFilm
        '
        Me.LblDurasiFilm.AutoSize = True
        Me.LblDurasiFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDurasiFilm.Location = New System.Drawing.Point(415, 238)
        Me.LblDurasiFilm.Name = "LblDurasiFilm"
        Me.LblDurasiFilm.Size = New System.Drawing.Size(99, 20)
        Me.LblDurasiFilm.TabIndex = 63
        Me.LblDurasiFilm.Text = "Durasi Film"
        '
        'LblDirector
        '
        Me.LblDirector.AutoSize = True
        Me.LblDirector.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDirector.Location = New System.Drawing.Point(415, 202)
        Me.LblDirector.Name = "LblDirector"
        Me.LblDirector.Size = New System.Drawing.Size(73, 20)
        Me.LblDirector.TabIndex = 62
        Me.LblDirector.Text = "Director"
        '
        'LblDeskripsi
        '
        Me.LblDeskripsi.AutoSize = True
        Me.LblDeskripsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeskripsi.Location = New System.Drawing.Point(415, 109)
        Me.LblDeskripsi.Name = "LblDeskripsi"
        Me.LblDeskripsi.Size = New System.Drawing.Size(83, 20)
        Me.LblDeskripsi.TabIndex = 61
        Me.LblDeskripsi.Text = "Deskripsi"
        '
        'LblGenreFilm
        '
        Me.LblGenreFilm.AutoSize = True
        Me.LblGenreFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGenreFilm.Location = New System.Drawing.Point(415, 70)
        Me.LblGenreFilm.Name = "LblGenreFilm"
        Me.LblGenreFilm.Size = New System.Drawing.Size(59, 20)
        Me.LblGenreFilm.TabIndex = 60
        Me.LblGenreFilm.Text = "Genre"
        '
        'LblNamaFilm
        '
        Me.LblNamaFilm.AutoSize = True
        Me.LblNamaFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaFilm.Location = New System.Drawing.Point(415, 28)
        Me.LblNamaFilm.Name = "LblNamaFilm"
        Me.LblNamaFilm.Size = New System.Drawing.Size(55, 20)
        Me.LblNamaFilm.TabIndex = 59
        Me.LblNamaFilm.Text = "Nama"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(200, 348)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Bahasa :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(200, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Harga Film"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(200, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 20)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Date Release Film :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(200, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 20)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Durasi Film :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(200, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Director :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Deskripsi :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Genre Film :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Nama Film :"
        '
        'Pic
        '
        Me.Pic.Location = New System.Drawing.Point(35, 28)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(150, 174)
        Me.Pic.TabIndex = 57
        Me.Pic.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(415, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 20)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Rp."
        '
        'InfoFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 522)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.LblBahasa)
        Me.Controls.Add(Me.LblHargaFilm)
        Me.Controls.Add(Me.LblDateReleaseFilm)
        Me.Controls.Add(Me.LblDurasiFilm)
        Me.Controls.Add(Me.LblDirector)
        Me.Controls.Add(Me.LblDeskripsi)
        Me.Controls.Add(Me.LblGenreFilm)
        Me.Controls.Add(Me.LblNamaFilm)
        Me.Controls.Add(Me.Pic)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InfoFilm"
        Me.Text = "InfoFilm"
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTutup As Button
    Friend WithEvents LblBahasa As Label
    Friend WithEvents LblHargaFilm As Label
    Friend WithEvents LblDateReleaseFilm As Label
    Friend WithEvents LblDurasiFilm As Label
    Friend WithEvents LblDirector As Label
    Friend WithEvents LblDeskripsi As Label
    Friend WithEvents LblGenreFilm As Label
    Friend WithEvents LblNamaFilm As Label
    Friend WithEvents Pic As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
