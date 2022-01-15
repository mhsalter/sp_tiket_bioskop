Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Public Class User
    Private Nama As String
    Private Password As String
    Private Email As String

    Private User As New ArrayList()

    Private TripleDES As New TripleDESCryptoServiceProvider

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "bioskop"
    Public Property NamaProperty() As String
        Get
            Return Nama
        End Get
        Set(ByVal value As String)
            Nama = value
        End Set
    End Property

    Public Property PasswordProperty() As String
        Get
            Return Password
        End Get
        Set(ByVal value As String)
            Password = value
        End Set
    End Property



    Public ReadOnly Property getDataUsers() As ArrayList
        Get
            Return User
        End Get
    End Property

    Public Function EncrypData(ByVal plaintext As String) As String

        'Convert the plaintext string to a byte array.
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        'Create the stream.
        Dim ms As New System.IO.MemoryStream
        'Create the encoder to write the stream.
        Dim encStream As New CryptoStream(ms,
            TripleDES.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        'Use the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        'Convert the encrypted stream to a printable string.
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function EncryptMDS(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)

        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()

    End Function

    Public Function AddUsersDatabase(username_regist As String, password_regist As String, email As String)
        Try
            Dim today = Date.Now()
            dbConn.ConnectionString = "Server =" + server + ";" + "User id =" + username_db + ";" + "Password =" + password_db + ";" + "Database =" + database

            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO USER( nama, password, email) VALUE(
            '" & username_regist & "',
            '" & EncryptMDS(password_regist) & "',
            '" & email & "')"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function CheckAuthDataBase(username_login As String, email_login As String, password_login As String) As List(Of String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "Server =" + server + ";" + "User id =" + username_db + ";" + "Password =" + password_db + ";" + "Database =" + database

            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim queryAuth As String

            If username_login <> "" Then

                queryAuth = "SELECT id, nama FROM user WHERE nama =
                            '" & username_login & "'AND password ='" & EncryptMDS(password_login) & "'"

            ElseIf email_login <> "" Then

                queryAuth = "SELECT id, nama FROM user WHERE email =
                            '" & email_login & "'AND password ='" & EncryptMDS(password_login) & "'"

            End If

            'Dim queryAuth = "SELECT id, nama FROM user WHERE nama =
            ''" & username_login Or Email "' AND password ='" & EncryptMDS(password_login) & "'"

            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
