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
        Me.BtnSignUp.Location = New System.Drawing.Point(323, 198)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(107, 36)
        Me.BtnSignUp.TabIndex = 16
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.UseVisualStyleBackColor = True
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(33, 150)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(78, 20)
        Me.LblPassword.TabIndex = 15
        Me.LblPassword.Text = "Password"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(33, 95)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(51, 20)
        Me.LblNama.TabIndex = 14
        Me.LblNama.Text = "Nama"
        '
        'TxtBoxPassword
        '
        Me.TxtBoxPassword.Location = New System.Drawing.Point(159, 144)
        Me.TxtBoxPassword.Name = "TxtBoxPassword"
        Me.TxtBoxPassword.Size = New System.Drawing.Size(271, 26)
        Me.TxtBoxPassword.TabIndex = 13
        '
        'TxtBoxNama
        '
        Me.TxtBoxNama.Location = New System.Drawing.Point(159, 89)
        Me.TxtBoxNama.Name = "TxtBoxNama"
        Me.TxtBoxNama.Size = New System.Drawing.Size(271, 26)
        Me.TxtBoxNama.TabIndex = 12
        '
        'TxtBoxEmail
        '
        Me.TxtBoxEmail.Location = New System.Drawing.Point(159, 38)
        Me.TxtBoxEmail.Name = "TxtBoxEmail"
        Me.TxtBoxEmail.Size = New System.Drawing.Size(271, 26)
        Me.TxtBoxEmail.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Email"
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 255)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBoxEmail)
        Me.Controls.Add(Me.BtnSignUp)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.TxtBoxPassword)
        Me.Controls.Add(Me.TxtBoxNama)
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
