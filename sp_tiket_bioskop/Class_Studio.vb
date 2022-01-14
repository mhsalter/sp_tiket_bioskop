Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Class_Studio

    Private Kapasitas As Integer
    Private HargaKursi As Integer

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "127.0.0.1"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "bioskop"

    Public Property kapasitasStudio() As Integer
        Get
            Return Kapasitas
        End Get
        Set(ByVal value As Integer)
            Kapasitas = value
        End Set
    End Property
    Public Property hargakursiStudio() As Integer
        Get
            Return HargaKursi
        End Get
        Set(ByVal value As Integer)
            HargaKursi = value
        End Set
    End Property

    Public Function GetDataStudioDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT
                                        id AS 'ID',
                                        kapasitas AS 'Ukuran',
                                        harga_kursi AS 'Biaya'
                                        FROM studio"

            sqlRead = sqlCommand.ExecuteReader

            result.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()
            Return result

    End Function

    Public Function AddDataStudioDatabase(kapasitas As Integer,
                                          harga_kursi As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO studio(kapasitas, harga_kursi) VALUES(
            '" & kapasitas & "',
            '" & harga_kursi & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'sistem_penitipan_barang.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataStudioByID(ID As Integer) As List(Of String)
        Dim result As New List(Of String)


        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id, kapasitas, harga_kursi FROM studio
                                      WHERE id=" & ID

            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                result.Add(sqlRead.GetString(0).ToString())
                result.Add(sqlRead.GetString(1).ToString())
                result.Add(sqlRead.GetString(2).ToString())
            End While

            sqlRead.Close()
            dbConn.Close()
            Return result

    End Function

    Public Function EditDataStudioByID(ID As Integer, kapasitas As Integer,
                                          harga_kursi As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE studio SET kapasitas='" & kapasitas & "', " &
                                     "harga_kursi='" & harga_kursi & "' " &
                                     "WHERE id=" & ID

            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            dbConn.Close()
            sqlRead.Close()


        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function DeleteDataStudioByID(ID As Integer)


        dbConn.ConnectionString = "Server =" + server + ";" + "User id =" + username + ";" + "Password =" + password + ";" + "Database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM studio " &
                    "WHERE id='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()


        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
