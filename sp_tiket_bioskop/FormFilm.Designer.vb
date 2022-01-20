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
        Me.DataGridViewFilm.Location = New System.Drawing.Point(8, 21)
        Me.DataGridViewFilm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridViewFilm.Name = "DataGridViewFilm"
        Me.DataGridViewFilm.RowHeadersWidth = 62
        Me.DataGridViewFilm.RowTemplate.Height = 28
        Me.DataGridViewFilm.Size = New System.Drawing.Size(671, 206)
        Me.DataGridViewFilm.TabIndex = 0
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(8, 238)
        Me.BtnTambah.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(93, 21)
        Me.BtnTambah.TabIndex = 1
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(206, 238)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(93, 21)
        Me.BtnEdit.TabIndex = 2
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(587, 238)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(93, 21)
        Me.BtnHapus.TabIndex = 3
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'ListBoxFilm
        '
        Me.ListBoxFilm.FormattingEnabled = True
        Me.ListBoxFilm.Location = New System.Drawing.Point(8, 270)
        Me.ListBoxFilm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBoxFilm.Name = "ListBoxFilm"
        Me.ListBoxFilm.Size = New System.Drawing.Size(673, 173)
        Me.ListBoxFilm.TabIndex = 4
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(390, 238)
        Me.BtnSelect.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(93, 21)
        Me.BtnSelect.TabIndex = 5
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'FormFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.ListBoxFilm)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.DataGridViewFilm)
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
