<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahJadwal
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
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.DTPJadwal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBFilm = New System.Windows.Forms.ComboBox()
        Me.CBStudio = New System.Windows.Forms.ComboBox()
        Me.DTPWaktuMulai = New System.Windows.Forms.DateTimePicker()
        Me.DTPWaktuSelesai = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(161, 252)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambah.TabIndex = 0
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'DTPJadwal
        '
        Me.DTPJadwal.CustomFormat = ""
        Me.DTPJadwal.Location = New System.Drawing.Point(199, 110)
        Me.DTPJadwal.Name = "DTPJadwal"
        Me.DTPJadwal.Size = New System.Drawing.Size(200, 20)
        Me.DTPJadwal.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Film"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Studio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Waktu Mulai"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Waktu Selesai"
        '
        'CBFilm
        '
        Me.CBFilm.FormattingEnabled = True
        Me.CBFilm.Location = New System.Drawing.Point(199, 39)
        Me.CBFilm.Name = "CBFilm"
        Me.CBFilm.Size = New System.Drawing.Size(200, 21)
        Me.CBFilm.TabIndex = 9
        '
        'CBStudio
        '
        Me.CBStudio.FormattingEnabled = True
        Me.CBStudio.Location = New System.Drawing.Point(199, 74)
        Me.CBStudio.Name = "CBStudio"
        Me.CBStudio.Size = New System.Drawing.Size(200, 21)
        Me.CBStudio.TabIndex = 10
        '
        'DTPWaktuMulai
        '
        Me.DTPWaktuMulai.CustomFormat = "HH:mm:ss"
        Me.DTPWaktuMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWaktuMulai.Location = New System.Drawing.Point(199, 146)
        Me.DTPWaktuMulai.Name = "DTPWaktuMulai"
        Me.DTPWaktuMulai.ShowUpDown = True
        Me.DTPWaktuMulai.Size = New System.Drawing.Size(200, 20)
        Me.DTPWaktuMulai.TabIndex = 11
        '
        'DTPWaktuSelesai
        '
        Me.DTPWaktuSelesai.CustomFormat = "HH:mm:ss"
        Me.DTPWaktuSelesai.Enabled = False
        Me.DTPWaktuSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWaktuSelesai.Location = New System.Drawing.Point(199, 190)
        Me.DTPWaktuSelesai.Name = "DTPWaktuSelesai"
        Me.DTPWaktuSelesai.ShowUpDown = True
        Me.DTPWaktuSelesai.Size = New System.Drawing.Size(200, 20)
        Me.DTPWaktuSelesai.TabIndex = 12
        '
        'TambahJadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 352)
        Me.Controls.Add(Me.DTPWaktuSelesai)
        Me.Controls.Add(Me.DTPWaktuMulai)
        Me.Controls.Add(Me.CBStudio)
        Me.Controls.Add(Me.CBFilm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTPJadwal)
        Me.Controls.Add(Me.BtnTambah)
        Me.Name = "TambahJadwal"
        Me.Text = "TambahJadwal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTambah As Button
    Friend WithEvents DTPJadwal As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CBFilm As ComboBox
    Friend WithEvents CBStudio As ComboBox
    Friend WithEvents DTPWaktuMulai As DateTimePicker
    Friend WithEvents DTPWaktuSelesai As DateTimePicker
End Class
