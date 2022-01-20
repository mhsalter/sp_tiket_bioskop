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
        Me.BtnSignUp.Location = New System.Drawing.Point(171, 149)
        Me.BtnSignUp.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(64, 23)
        Me.BtnSignUp.TabIndex = 11
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.UseVisualStyleBackColor = True
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(239, 149)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(50, 23)
        Me.BtnLogin.TabIndex = 10
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(25, 92)
        Me.LblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(53, 13)
        Me.LblPassword.TabIndex = 9
        Me.LblPassword.Text = "Password"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(25, 57)
        Me.LblNama.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(35, 13)
        Me.LblNama.TabIndex = 8
        Me.LblNama.Text = "Nama"
        '
        'TxtBoxPassword
        '
        Me.TxtBoxPassword.Location = New System.Drawing.Point(109, 88)
        Me.TxtBoxPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBoxPassword.Name = "TxtBoxPassword"
        Me.TxtBoxPassword.Size = New System.Drawing.Size(182, 20)
        Me.TxtBoxPassword.TabIndex = 7
        '
        'TxtBoxNama
        '
        Me.TxtBoxNama.Location = New System.Drawing.Point(109, 53)
        Me.TxtBoxNama.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBoxNama.Name = "TxtBoxNama"
        Me.TxtBoxNama.Size = New System.Drawing.Size(182, 20)
        Me.TxtBoxNama.TabIndex = 6
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(308, 190)
        Me.Controls.Add(Me.BtnSignUp)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.TxtBoxPassword)
        Me.Controls.Add(Me.TxtBoxNama)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
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
