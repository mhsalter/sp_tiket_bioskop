<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusJadwal
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
        Me.LblJadwal = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Apakah anda ingin menghapus koleksi?"
        '
        'LblJadwal
        '
        Me.LblJadwal.AutoSize = True
        Me.LblJadwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJadwal.ForeColor = System.Drawing.Color.ForestGreen
        Me.LblJadwal.Location = New System.Drawing.Point(73, 49)
        Me.LblJadwal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblJadwal.Name = "LblJadwal"
        Me.LblJadwal.Size = New System.Drawing.Size(141, 36)
        Me.LblJadwal.TabIndex = 7
        Me.LblJadwal.Text = "Jadwal ?"
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(79, 116)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(144, 33)
        Me.BtnHapus.TabIndex = 8
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'HapusJadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 182)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblJadwal)
        Me.Controls.Add(Me.Label2)
        Me.Name = "HapusJadwal"
        Me.Text = "HapusJadwal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents LblJadwal As Label
    Friend WithEvents BtnHapus As Button
End Class
