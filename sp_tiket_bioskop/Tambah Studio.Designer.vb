<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah_Studio
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtKapasitas = New System.Windows.Forms.TextBox()
        Me.TxtHargaKursi = New System.Windows.Forms.TextBox()
        Me.BtnTambahStudio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kapasitas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga Kursi"
        '
        'TxtKapasitas
        '
        Me.TxtKapasitas.Location = New System.Drawing.Point(131, 6)
        Me.TxtKapasitas.Name = "TxtKapasitas"
        Me.TxtKapasitas.Size = New System.Drawing.Size(100, 20)
        Me.TxtKapasitas.TabIndex = 4
        '
        'TxtHargaKursi
        '
        Me.TxtHargaKursi.Location = New System.Drawing.Point(131, 33)
        Me.TxtHargaKursi.Name = "TxtHargaKursi"
        Me.TxtHargaKursi.Size = New System.Drawing.Size(100, 20)
        Me.TxtHargaKursi.TabIndex = 5
        '
        'BtnTambahStudio
        '
        Me.BtnTambahStudio.Location = New System.Drawing.Point(131, 70)
        Me.BtnTambahStudio.Name = "BtnTambahStudio"
        Me.BtnTambahStudio.Size = New System.Drawing.Size(100, 23)
        Me.BtnTambahStudio.TabIndex = 6
        Me.BtnTambahStudio.Text = "Tambah Studio"
        Me.BtnTambahStudio.UseVisualStyleBackColor = True
        '
        'Tambah_Studio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(251, 107)
        Me.Controls.Add(Me.BtnTambahStudio)
        Me.Controls.Add(Me.TxtHargaKursi)
        Me.Controls.Add(Me.TxtKapasitas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Tambah_Studio"
        Me.Text = "Tambah_Studio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtKapasitas As TextBox
    Friend WithEvents TxtHargaKursi As TextBox
    Friend WithEvents BtnTambahStudio As Button
End Class
