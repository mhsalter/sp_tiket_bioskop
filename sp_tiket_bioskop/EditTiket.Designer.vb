<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTiket
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBTotalHarga = New System.Windows.Forms.TextBox()
        Me.TBHargaKursi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBFilm = New System.Windows.Forms.TextBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.TBHargaFilm = New System.Windows.Forms.TextBox()
        Me.CBJadwalTayang = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 18)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Total Harga"
        '
        'TBTotalHarga
        '
        Me.TBTotalHarga.Enabled = False
        Me.TBTotalHarga.Location = New System.Drawing.Point(207, 121)
        Me.TBTotalHarga.Name = "TBTotalHarga"
        Me.TBTotalHarga.Size = New System.Drawing.Size(121, 20)
        Me.TBTotalHarga.TabIndex = 20
        '
        'TBHargaKursi
        '
        Me.TBHargaKursi.Enabled = False
        Me.TBHargaKursi.Location = New System.Drawing.Point(207, 65)
        Me.TBHargaKursi.Name = "TBHargaKursi"
        Me.TBHargaKursi.Size = New System.Drawing.Size(121, 20)
        Me.TBHargaKursi.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Harga Film"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 18)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Harga Kursi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nama Film"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Jadwal Tayang"
        '
        'TBFilm
        '
        Me.TBFilm.Enabled = False
        Me.TBFilm.Location = New System.Drawing.Point(207, 39)
        Me.TBFilm.Name = "TBFilm"
        Me.TBFilm.Size = New System.Drawing.Size(121, 20)
        Me.TBFilm.TabIndex = 14
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(229, 147)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 13
        Me.BtnEdit.Text = "Update"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'TBHargaFilm
        '
        Me.TBHargaFilm.Enabled = False
        Me.TBHargaFilm.Location = New System.Drawing.Point(207, 91)
        Me.TBHargaFilm.Name = "TBHargaFilm"
        Me.TBHargaFilm.Size = New System.Drawing.Size(121, 20)
        Me.TBHargaFilm.TabIndex = 12
        '
        'CBJadwalTayang
        '
        Me.CBJadwalTayang.FormattingEnabled = True
        Me.CBJadwalTayang.Location = New System.Drawing.Point(207, 12)
        Me.CBJadwalTayang.Name = "CBJadwalTayang"
        Me.CBJadwalTayang.Size = New System.Drawing.Size(121, 21)
        Me.CBJadwalTayang.TabIndex = 11
        '
        'EditTiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(364, 186)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBTotalHarga)
        Me.Controls.Add(Me.TBHargaKursi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBFilm)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.TBHargaFilm)
        Me.Controls.Add(Me.CBJadwalTayang)
        Me.Name = "EditTiket"
        Me.Text = "EditTiket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents TBTotalHarga As TextBox
    Friend WithEvents TBHargaKursi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TBFilm As TextBox
    Friend WithEvents BtnEdit As Button
    Friend WithEvents TBHargaFilm As TextBox
    Friend WithEvents CBJadwalTayang As ComboBox
End Class
