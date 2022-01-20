<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusFilm
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
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.LblNamaFilm = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(139, 205)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(59, 25)
        Me.BtnHapus.TabIndex = 8
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'LblNamaFilm
        '
        Me.LblNamaFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaFilm.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblNamaFilm.Location = New System.Drawing.Point(31, 77)
        Me.LblNamaFilm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNamaFilm.Name = "LblNamaFilm"
        Me.LblNamaFilm.Size = New System.Drawing.Size(270, 120)
        Me.LblNamaFilm.TabIndex = 7
        Me.LblNamaFilm.Text = "Nama Film"
        Me.LblNamaFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Apakah Ingin Menghapus Film?"
        '
        'HapusFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(331, 292)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblNamaFilm)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "HapusFilm"
        Me.Text = "HapusFilm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnHapus As Button
    Friend WithEvents LblNamaFilm As Label
    Friend WithEvents Label1 As Label
End Class
