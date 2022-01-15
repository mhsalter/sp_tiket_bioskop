<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFilm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridViewFilm = New System.Windows.Forms.DataGridView()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.ListBoxFilm = New System.Windows.Forms.ListBox()
        Me.BtnSelect = New System.Windows.Forms.Button()
        CType(Me.DataGridViewFilm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewFilm
        '
        Me.DataGridViewFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFilm.Location = New System.Drawing.Point(12, 33)
        Me.DataGridViewFilm.Name = "DataGridViewFilm"
        Me.DataGridViewFilm.RowHeadersWidth = 62
        Me.DataGridViewFilm.RowTemplate.Height = 28
        Me.DataGridViewFilm.Size = New System.Drawing.Size(1007, 317)
        Me.DataGridViewFilm.TabIndex = 0
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(12, 366)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(139, 32)
        Me.BtnTambah.TabIndex = 1
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(309, 366)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(139, 32)
        Me.BtnEdit.TabIndex = 2
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(880, 366)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(139, 32)
        Me.BtnHapus.TabIndex = 3
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'ListBoxFilm
        '
        Me.ListBoxFilm.FormattingEnabled = True
        Me.ListBoxFilm.ItemHeight = 20
        Me.ListBoxFilm.Location = New System.Drawing.Point(12, 416)
        Me.ListBoxFilm.Name = "ListBoxFilm"
        Me.ListBoxFilm.Size = New System.Drawing.Size(1007, 264)
        Me.ListBoxFilm.TabIndex = 4
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(585, 366)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(139, 32)
        Me.BtnSelect.TabIndex = 5
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'FormFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 692)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.ListBoxFilm)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.DataGridViewFilm)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormFilm"
        Me.Text = " "
        CType(Me.DataGridViewFilm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewFilm As DataGridView
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents ListBoxFilm As ListBox
    Friend WithEvents BtnSelect As Button
End Class
