<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hapus_Studio
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblHapusStudio = New System.Windows.Forms.Label()
        Me.BtnHapusStudio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah Ingin Menghapus Studio"
        '
        'LblHapusStudio
        '
        Me.LblHapusStudio.AutoSize = True
        Me.LblHapusStudio.Location = New System.Drawing.Point(191, 125)
        Me.LblHapusStudio.Name = "LblHapusStudio"
        Me.LblHapusStudio.Size = New System.Drawing.Size(37, 13)
        Me.LblHapusStudio.TabIndex = 1
        Me.LblHapusStudio.Text = "Studio"
        '
        'BtnHapusStudio
        '
        Me.BtnHapusStudio.Location = New System.Drawing.Point(173, 165)
        Me.BtnHapusStudio.Name = "BtnHapusStudio"
        Me.BtnHapusStudio.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapusStudio.TabIndex = 2
        Me.BtnHapusStudio.Text = "Hapus Studio"
        Me.BtnHapusStudio.UseVisualStyleBackColor = True
        '
        'Hapus_Studio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 322)
        Me.Controls.Add(Me.BtnHapusStudio)
        Me.Controls.Add(Me.LblHapusStudio)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Hapus_Studio"
        Me.Text = "Hapus_Studio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblHapusStudio As Label
    Friend WithEvents BtnHapusStudio As Button
End Class
