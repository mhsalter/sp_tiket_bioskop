Imports System.Text
Imports MySql.Data.MySqlClient
Public Class JadwalTayang
    Private id_film As String
    Private id_studio As Integer
    Private tanggal As String
    Private waktu_mulai As String
    Private waktu_selesai As String

    Private jadwallist As New List(Of String)

    'Database Global Variable
    Private jadwalDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Public Shared sqlAdapter As MySqlDataAdapter
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "bioskop"

    'Get Setter
    Public Property GSid_film() As String
        Get
            Return id_film
        End Get
        Set(ByVal value As String)
            id_film = value
        End Set
    End Property
    Public Property GSid_studio() As String
        Get
            Return id_studio
        End Get
        Set(ByVal value As String)
            id_studio = value
        End Set
    End Property
    Public Property GStanggal() As String
        Get
            Return tanggal
        End Get
        Set(ByVal value As String)
            tanggal = value
        End Set
    End Property
    Public Property GSwaktu_mulai() As String
        Get
            Return waktu_mulai
        End Get
        Set(ByVal value As String)
            waktu_mulai = value
        End Set
    End Property
    Public Property GSwaktu_selesai() As String
        Get
            Return waktu_selesai
        End Get
        Set(ByVal value As String)
            waktu_selesai = value
        End Set
    End Property

    'Readonly
    Public ReadOnly Property getJadwalDataTable() As ArrayList
        Get
            Return jadwalDataTable
        End Get
    End Property

    'Function
    Public Function GetDataJadwalDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT jt.id AS 'ID',
                                    f.film AS 'Film',
                                    jt.id_studio AS 'ID Studio',
                                    jt.tanggal AS 'Tanggal',
                                    jt.waktu_mulai AS 'Waktu Mulai',
                                    jt.waktu_selesai AS 'Waktu Selesai'
                                    FROM jadwal_tayang AS jt
                                    JOIN film AS f ON f.id = jt.id_film"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function GetDataFilm() As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT film FROM film"
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function GetDataStudio() As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
       + "password =" + password + ";" + "database =" + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id FROM studio"
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function AddDataJadwalTayangDatabase(id_film As String,
                                                id_studio As Integer,
                                                tanggal As String,
                                                waktu_mulai As DateTime,
                                                waktu_selesai As DateTime)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO jadwal_tayang (id_film, id_studio, tanggal, waktu_mulai, waktu_selesai) 
                    VALUE ((SELECT id FROM film WHERE film= '" & id_film & "'),
	                    '" & id_studio & "', 
	                    '" & tanggal & "',
	                    '" & waktu_mulai & "',
	                    '" & waktu_selesai & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function
    Public Function GetDataJadwalByID(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT f.film, jt.id_studio, jt.tanggal, 
                                jt.waktu_mulai, jt.waktu_selesai
                                FROM jadwal_tayang AS jt
                                JOIN film AS f ON jt.id = '" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function UpdateDataJadwalByID(ID As String,
                                         id_film As String,
                                         id_studio As Integer,
                                         tanggal As Date,
                                         waktu_mulai As DateTime,
                                         waktu_selesai As DateTime)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE jadwal_tayang SET " &
                        "tanggal='" & tanggal.ToString("yyyy/MM/dd") & "', " &
                        "waktu_mulai='" & waktu_mulai.ToString("HH:mm:ss") & "', " &
                        "waktu_selesai='" & waktu_selesai.ToString("HH:mm:ss") & "' " &
                        "WHERE id='" & ID & "'"

            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function
    Public Function GetDataDuration(id_film As String) As DateTime
        Dim result As DateTime
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT duration FROM film WHERE film = '" & id_film & "'"


            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                result = sqlRead.GetString(0)
            End While

            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
        Return result
    End Function
    Public Function GetUpdateDuration() As DateTime
        Dim result As DateTime
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT duration FROM film WHERE film = '" & GSid_film & "'"


            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                result = sqlRead.GetString(0)
            End While

            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
        Return result
    End Function
    Public Function DeleteDataJadwalByID(ID As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM jadwal_tayang " & "WHERE id='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
