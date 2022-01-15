<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.BtnSignUp = New System.Windows.Forms.Button()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.TxtBoxPassword = New System.Windows.Forms.TextBox()
        Me.TxtBoxNama = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnSignUp
        '
        Me.BtnSignUp.Location = New System.Drawing.Point(257, 229)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(96, 36)
        Me.BtnSignUp.TabIndex = 11
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.UseVisualStyleBackColor = True
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(359, 229)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 36)
        Me.BtnLogin.TabIndex = 10
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(37, 142)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(78, 20)
        Me.LblPassword.TabIndex = 9
        Me.LblPassword.Text = "Password"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(37, 87)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(51, 20)
        Me.LblNama.TabIndex = 8
        Me.LblNama.Text = "Nama"
        '
        'TxtBoxPassword
        '
        Me.TxtBoxPassword.Location = New System.Drawing.Point(163, 136)
        Me.TxtBoxPassword.Name = "TxtBoxPassword"
        Me.TxtBoxPassword.Size = New System.Drawing.Size(271, 26)
        Me.TxtBoxPassword.TabIndex = 7
        '
        'TxtBoxNama
        '
        Me.TxtBoxNama.Location = New System.Drawing.Point(163, 81)
        Me.TxtBoxNama.Name = "TxtBoxNama"
        Me.TxtBoxNama.Size = New System.Drawing.Size(271, 26)
        Me.TxtBoxNama.TabIndex = 6
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 292)
        Me.Controls.Add(Me.BtnSignUp)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.TxtBoxPassword)
        Me.Controls.Add(Me.TxtBoxNama)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSignUp As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblNama As Label
    Friend WithEvents TxtBoxPassword As TextBox
    Friend WithEvents TxtBoxNama As TextBox
End Class
