<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTiket
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
        Me.DGVTiket = New System.Windows.Forms.DataGridView()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.DGVJadwal = New System.Windows.Forms.DataGridView()
        CType(Me.DGVTiket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVJadwal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVTiket
        '
        Me.DGVTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTiket.Location = New System.Drawing.Point(12, 184)
        Me.DGVTiket.Name = "DGVTiket"
        Me.DGVTiket.Size = New System.Drawing.Size(344, 150)
        Me.DGVTiket.TabIndex = 0
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(362, 184)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambah.TabIndex = 1
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(362, 232)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 2
        Me.BtnEdit.Text = "Update"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(362, 279)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 3
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'DGVJadwal
        '
        Me.DGVJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVJadwal.Location = New System.Drawing.Point(12, 12)
        Me.DGVJadwal.Name = "DGVJadwal"
        Me.DGVJadwal.Size = New System.Drawing.Size(861, 150)
        Me.DGVJadwal.TabIndex = 4
        '
        'FormTiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 349)
        Me.Controls.Add(Me.DGVJadwal)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.DGVTiket)
        Me.Name = "FormTiket"
        Me.Text = "FormTiket"
        CType(Me.DGVTiket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVJadwal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVTiket As DataGridView
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents DGVJadwal As DataGridView
End Class
