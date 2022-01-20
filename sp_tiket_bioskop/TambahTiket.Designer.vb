<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahTiket
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
        Me.CBJadwalTayang = New System.Windows.Forms.ComboBox()
        Me.TBHargaFilm = New System.Windows.Forms.TextBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TBFilm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBHargaKursi = New System.Windows.Forms.TextBox()
        Me.TBTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CBJadwalTayang
        '
        Me.CBJadwalTayang.FormattingEnabled = True
        Me.CBJadwalTayang.Location = New System.Drawing.Point(201, 29)
        Me.CBJadwalTayang.Name = "CBJadwalTayang"
        Me.CBJadwalTayang.Size = New System.Drawing.Size(121, 21)
        Me.CBJadwalTayang.TabIndex = 0
        '
        'TBHargaFilm
        '
        Me.TBHargaFilm.Enabled = False
        Me.TBHargaFilm.Location = New System.Drawing.Point(201, 108)
        Me.TBHargaFilm.Name = "TBHargaFilm"
        Me.TBHargaFilm.Size = New System.Drawing.Size(121, 20)
        Me.TBHargaFilm.TabIndex = 1
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(223, 164)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambah.TabIndex = 2
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TBFilm
        '
        Me.TBFilm.Enabled = False
        Me.TBFilm.Location = New System.Drawing.Point(201, 56)
        Me.TBFilm.Name = "TBFilm"
        Me.TBFilm.Size = New System.Drawing.Size(121, 20)
        Me.TBFilm.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Jadwal Tayang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Film"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Harga Kursi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Harga Film"
        '
        'TBHargaKursi
        '
        Me.TBHargaKursi.Enabled = False
        Me.TBHargaKursi.Location = New System.Drawing.Point(201, 82)
        Me.TBHargaKursi.Name = "TBHargaKursi"
        Me.TBHargaKursi.Size = New System.Drawing.Size(121, 20)
        Me.TBHargaKursi.TabIndex = 8
        '
        'TBTotalHarga
        '
        Me.TBTotalHarga.Enabled = False
        Me.TBTotalHarga.Location = New System.Drawing.Point(201, 138)
        Me.TBTotalHarga.Name = "TBTotalHarga"
        Me.TBTotalHarga.Size = New System.Drawing.Size(121, 20)
        Me.TBTotalHarga.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Harga"
        '
        'TambahTiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 212)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBTotalHarga)
        Me.Controls.Add(Me.TBHargaKursi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBFilm)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TBHargaFilm)
        Me.Controls.Add(Me.CBJadwalTayang)
        Me.Name = "TambahTiket"
        Me.Text = "TambahTiket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBJadwalTayang As ComboBox
    Friend WithEvents TBHargaFilm As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents TBFilm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TBHargaKursi As TextBox
    Friend WithEvents TBTotalHarga As TextBox
    Friend WithEvents Label5 As Label
End Class
