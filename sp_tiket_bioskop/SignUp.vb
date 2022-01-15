Public Class SignUp
    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        If TxtBoxNama.Text.Length > 0 And TxtBoxPassword.Text.Length > 0 And TxtBoxEmail.Text.Length > 0 Then
            Login.User.AddUsersDatabase(TxtBoxNama.Text, TxtBoxPassword.Text, TxtBoxEmail.Text)
            Me.Close()
        Else
            MessageBox.Show("Lengkapi Data")
        End If
    End Sub
End Class