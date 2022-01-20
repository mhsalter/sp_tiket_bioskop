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
        Me.BtnHapusStudio = New System.Windows.Forms.Button()
        Me.TBStudio = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah Ingin Menghapus Studio"
        '
        'BtnHapusStudio
        '
        Me.BtnHapusStudio.Location = New System.Drawing.Point(94, 87)
        Me.BtnHapusStudio.Name = "BtnHapusStudio"
        Me.BtnHapusStudio.Size = New System.Drawing.Size(100, 23)
        Me.BtnHapusStudio.TabIndex = 2
        Me.BtnHapusStudio.Text = "Hapus Studio"
        Me.BtnHapusStudio.UseVisualStyleBackColor = True
        '
        'TBStudio
        '
        Me.TBStudio.Enabled = False
        Me.TBStudio.Location = New System.Drawing.Point(94, 42)
        Me.TBStudio.Name = "TBStudio"
        Me.TBStudio.Size = New System.Drawing.Size(100, 20)
        Me.TBStudio.TabIndex = 3
        '
        'Hapus_Studio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(296, 137)
        Me.Controls.Add(Me.TBStudio)
        Me.Controls.Add(Me.BtnHapusStudio)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Hapus_Studio"
        Me.Text = "Hapus_Studio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnHapusStudio As Button
    Friend WithEvents TBStudio As TextBox
End Class
