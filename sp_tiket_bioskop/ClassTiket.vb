Imports MySql.Data.MySqlClient
Public Class ClassTiket
    Private id_jadwaltayang As Integer
    Private total_harga As Integer

    'Database Connection
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Public Shared sqlAdapter As MySqlDataAdapter
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "bioskop"
    'Getter Setter
    Public Property GStotal_harga() As Integer
        Get
            Return total_harga
        End Get
        Set(ByVal value As Integer)
            total_harga = value
        End Set
    End Property
    Public Property GSid_jadwaltayang() As Integer
        Get
            Return id_jadwaltayang
        End Get
        Set(ByVal value As Integer)
            id_jadwaltayang = value
        End Set
    End Property
    'Function
    Public Function GetDataBioskopDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT
                                    jd.id AS 'ID Jadwal Tayang',
                                    fl.film AS 'Film',
                                    fl.harga_film AS 'Harga Film',
                                    jd.id_studio AS 'ID Studio',
                                    jd.tanggal AS 'Tanggal',
                                    jd.waktu_mulai AS 'Waktu Mulai',
                                    jd.waktu_selesai AS 'Waktu Selesai',
                                    st.harga_kursi AS 'Harga Kursi'
                                    FROM jadwal_tayang AS jd
                                    JOIN studio AS st ON
                                    jd.id_studio = st.id
                                    JOIN film AS fl ON
                                    jd.id_film =  fl.id"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function GetDataTiketDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id AS 'ID Tiket',
                                     id_jadwal_tayang AS 'ID Jadwal Tayang',
                                     total_harga AS 'Total Harga'
                                     FROM tiket"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function GetDataJadwal() As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id FROM jadwal_tayang"
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function GetDataNamaFilm(id_jadwal As Integer) As String
        Dim result As String

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT film FROM film
                         WHERE (id = (SELECT id_film FROM jadwal_tayang WHERE id='" & id_jadwal & "'))
                         = id"

            Debug.WriteLine(sqlQuery)
            sqlCommand.CommandText = sqlQuery
            sqlRead = sqlCommand.ExecuteReader
            While sqlRead.Read
                result = sqlRead.GetString(0).ToString()
            End While

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
        Return result
    End Function
    Public Function GetDataHargaKursi(id_jadwal As Integer) As Integer
        Dim result As New Integer

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT harga_kursi FROM studio
                                    WHERE (id = (SELECT id_studio FROM jadwal_tayang WHERE id='" & id_jadwal & "'))
                                     = id"

            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                result = Integer.Parse(sqlRead.GetString(0))
            End While

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
        Return result
    End Function
    Public Function GetDataHargaFilm(id_jadwal As Integer) As Integer
        Dim result As New Integer

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT harga_film FROM film
                                    WHERE (id = (SELECT id_film FROM jadwal_tayang WHERE id='" & id_jadwal & "'))
                                     = id"

            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                result = Integer.Parse(sqlRead.GetString(0))
            End While

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
        Return result
    End Function
    Public Function AddDataTiketDatabase(id_jadwal As Integer,
                                         total_harga As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO tiket (id_jadwal_tayang, total_harga) 
                    VALUE ('" & id_jadwal & "',
	                        '" & total_harga & "')"

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
    Public Function GetDataTiketByID(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT id_jadwal_tayang, total_harga FROM tiket
                        WHERE id = '" & ID & "'"

            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                result.Add(sqlRead.GetString(0).ToString())
                result.Add(sqlRead.GetString(1).ToString())
            End While

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
    Public Function UpdateDataTiketByID(ID As Integer,
                                        id_jadwal As Integer,
                                        total_harga As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE tiket SET " &
                        "id_jadwal_tayang='" & id_jadwal & "', " &
                        "total_harga='" & total_harga & "'" &
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
    Public Function DeleteDataTiketByID(ID As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM tiket " & "WHERE id='" & ID & "'"

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
