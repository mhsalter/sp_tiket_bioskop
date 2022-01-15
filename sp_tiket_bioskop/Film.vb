Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Film
    Private ListFilm As New List(Of String)
    Private SelectedFilm As String

    Private koleksiDataTable As New ArrayList()
    Private NamaFilm As String
    Private GenreFilm As String

    Private DeskripsiFilm As String
    Private Director As String
    Private Duration As String

    Private DateRelease
    Private Bahasa As String
    Private HargaFilm As Integer

    Private Foto As String
    'Private Kategori As New List(Of String)

    'Database Global Variable

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "bioskop"

    'Public Function AddKategori(value As String)
    'Kategori.Add(value)
    'Return ""
    'End Function

    'Public ReadOnly Property getKategoriItem() As List(Of String)
    'Get
    'Return Kategori
    'Get
    'End Property

    'Public Function resetKategori()
    'Kategori.Clear()
    'Return ""
    'End Function

    Public Function AddKoleksiFilm(value As String)
        ListFilm.Add(value)
        Return ""
    End Function

    Public Function RemoveKoleksiFilm(Value As String)
        ListFilm.Remove(Value)
        Return ""
    End Function

    Public Property selectedProperty() As String
        Get
            Return SelectedFilm
        End Get
        Set(ByVal value As String)
            SelectedFilm = value
        End Set
    End Property

    Public ReadOnly Property getKoleksiItem() As List(Of String)
        Get
            Return ListFilm
        End Get
    End Property

    Public Property namaFilmProperty() As String
        Get
            Return NamaFilm
        End Get
        Set(ByVal value As String)
            NamaFilm = value
        End Set
    End Property

    Public Property genreFilmProperty() As String
        Get
            Return GenreFilm
        End Get
        Set(ByVal value As String)
            GenreFilm = value
        End Set
    End Property

    Public Property deskripsiFilmProperty() As String
        Get
            Return DeskripsiFilm
        End Get
        Set(ByVal value As String)
            DeskripsiFilm = value
        End Set
    End Property

    Public Property directorFilmProperty() As String
        Get
            Return Director
        End Get
        Set(ByVal value As String)
            Director = value
        End Set
    End Property

    Public Property durationFilmProperty() As String
        Get
            Return Duration
        End Get
        Set(ByVal value As String)
            Duration = value
        End Set
    End Property

    Public Property dateReleaseProperty() As String
        Get
            Return DateRelease
        End Get
        Set(ByVal value As String)
            DateRelease = value
        End Set
    End Property

    Public Property bahasaProperty() As String
        Get
            Return Bahasa
        End Get
        Set(ByVal value As String)
            Bahasa = value
        End Set
    End Property

    Public Property hargaFilmProperty() As Integer
        Get
            Return HargaFilm
        End Get
        Set(ByVal value As Integer)
            HargaFilm = value
        End Set
    End Property

    Public Property dirGambarFilmProperty() As String
        Get
            Return Foto
        End Get
        Set(ByVal value As String)
            Foto = value
        End Set
    End Property

    Public Function AddKoleksiDataTable(foto_film As String,
                                       nama_film As String,
                                       genre_film As String,
                                       director_film As String,
                                       deskripsi_film As String,
                                       date_release As Date,
                                       duration_film As String,
                                       harga_film As Integer,
                                       bahasa_film As String)

        koleksiDataTable.Add({foto_film,
                             nama_film,
                             genre_film,
                             director_film,
                             deskripsi_film,
                             date_release,
                             duration_film,
                             harga_film,
                             bahasa_film})
    End Function

    Public Function RemoveKoleksiDataTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
    End Function

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        ' Convert to String.
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        ' Convert to List.
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database

        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id AS 'ID',
                                  film AS 'Nama Film',
                                  genre AS 'Jenis Koleksi',
                                  deskripsi AS 'Deskripsi',
                                  director AS 'Director',
                                  duration AS 'Duration',
                                  date_release AS 'Date Release',
                                  bahasa AS 'Bahasa',
                                  harga_film AS 'Harga Film'
                                  FROM film"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataKoleksiDatabase(foto_film As String,
                                           nama_film As String,
                                           genre_film As String,
                                           director_film As String,
                                           deskripsi_film As String,
                                           date_release As String,
                                           duration_film As String,
                                           harga_film As Integer,
                                           bahasa_film As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO FILM(film, genre,
                        deskripsi, director, duration,
                        date_release, bahasa, harga_film,
                        foto) VALUE(
            '" & nama_film & "',
            '" & genre_film & "',
            '" & deskripsi_film & "',
            '" & director_film & "',
            '" & duration_film & "',
            '" & date_release & "',
            '" & bahasa_film & "',          
            '" & harga_film & "',
            '" & foto_film & "')"
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

    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id,
                                  film,
                                  genre,
                                  deskripsi,
                                  director,
                                  duration,
                                  date_release,
                                  bahasa,
                                  harga_film,
                                  foto
                                  FROM film
                                  WHERE id ='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result

    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                                  foto_film As String,
                                                  nama_film As String,
                                                  genre_film As String,
                                                  director_film As String,
                                                  deskripsi_film As String,
                                                  date_release As String,
                                                  duration_film As String,
                                                  harga_film As Integer,
                                                  bahasa_film As String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE film SET" &
                "film ='" & nama_film & "', " &
                "foto ='" & foto_film & "', " &
                "deskripsi ='" & deskripsi_film & "', " &
                "director ='" & director_film & "', " &
                "genre ='" & genre_film & "', " &
                "date_release ='" & date_release & "', " &
                "duration ='" & duration_film & "', " &
                "harga_film ='" & harga_film & "', " &
                "bahasa ='" & bahasa_film & "' " &
                "WHERE id ='" & ID & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            dbConn.Close()
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)


        dbConn.ConnectionString = "Server =" + server + ";" + "User id =" + username + ";" + "Password =" + password + ";" + "Database =" + database

        'Try
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "DELETE FROM film " &
                "WHERE id ='" & ID & "'"

        Debug.WriteLine(sqlQuery)

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()

        'Perpustakaan.sqlDt.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()

        'Catch ex As Exception
        'Return ex.Message
        'Finally
        'dbConn.Dispose()
        'End Try


    End Function



End Class




