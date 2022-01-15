Public Class Login
    'Public Shared Pengguna As New User()
    Public Shared film As FormFilm
    Public Shared User As User

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        film = New FormFilm()
        User = New User()
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim nama As String = TxtBoxNama.Text
        Dim password As String = TxtBoxPassword.Text

        Dim data_user As List(Of String)

        If nama.Contains("@") Then
            data_user = User.CheckAuthDataBase("", nama, password)
        Else
            data_user = User.CheckAuthDataBase(nama, "", password)
        End If


        If data_user.Count > 0 Then
            User.NamaProperty = data_user(1)
            FormFilm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Password")
        End If

    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        SignUp.Show()
    End Sub

    Private Sub TxtBoxNama_Leave(sender As Object, e As EventArgs) Handles TxtBoxNama.Leave
        If TxtBoxNama.Text.Length < 1 Then
            TxtBoxNama.Select()
            MessageBox.Show("Please add Least 1 String")
        End If
    End Sub

    Private Sub TxtBoxPassword_Leave(sender As Object, e As EventArgs) Handles TxtBoxPassword.Leave
        If TxtBoxPassword.Text.Length < 1 Then
            TxtBoxPassword.Select()
            MessageBox.Show("Please add Least 1 String")
        End If
    End Sub
End Class