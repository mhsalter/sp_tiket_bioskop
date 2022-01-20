<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.BtnSignUp = New System.Windows.Forms.Button()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.TxtBoxPassword = New System.Windows.Forms.TextBox()
        Me.TxtBoxNama = New System.Windows.Forms.TextBox()
        Me.TxtBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnSignUp
        '
        Me.BtnSignUp.Location = New System.Drawing.Point(215, 129)
        Me.BtnSignUp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(71, 23)
        Me.BtnSignUp.TabIndex = 16
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.UseVisualStyleBackColor = True
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(22, 97)
        Me.LblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(53, 13)
        Me.LblPassword.TabIndex = 15
        Me.LblPassword.Text = "Password"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(22, 62)
        Me.LblNama.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(35, 13)
        Me.LblNama.TabIndex = 14
        Me.LblNama.Text = "Nama"
        '
        'TxtBoxPassword
        '
        Me.TxtBoxPassword.Location = New System.Drawing.Point(106, 94)
        Me.TxtBoxPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtBoxPassword.Name = "TxtBoxPassword"
        Me.TxtBoxPassword.Size = New System.Drawing.Size(182, 20)
        Me.TxtBoxPassword.TabIndex = 13
        '
        'TxtBoxNama
        '
        Me.TxtBoxNama.Location = New System.Drawing.Point(106, 58)
        Me.TxtBoxNama.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtBoxNama.Name = "TxtBoxNama"
        Me.TxtBoxNama.Size = New System.Drawing.Size(182, 20)
        Me.TxtBoxNama.TabIndex = 12
        '
        'TxtBoxEmail
        '
        Me.TxtBoxEmail.Location = New System.Drawing.Point(106, 25)
        Me.TxtBoxEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtBoxEmail.Name = "TxtBoxEmail"
        Me.TxtBoxEmail.Size = New System.Drawing.Size(182, 20)
        Me.TxtBoxEmail.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Email"
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(308, 166)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBoxEmail)
        Me.Controls.Add(Me.BtnSignUp)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.TxtBoxPassword)
        Me.Controls.Add(Me.TxtBoxNama)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "SignUp"
        Me.Text = "SignUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSignUp As Button
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents TxtBoxPassword As TextBox
    Friend WithEvents TxtBoxNama As TextBox
    Friend WithEvents TxtBoxEmail As TextBox
    Friend WithEvents Label1 As Label
End Class
