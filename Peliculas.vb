Imports System.Collections
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Peliculas
    ' ATRIBUTOS DE LA CLASE
    Private id_pelicula As Integer
    Private titulo As String
    Private anio_estreno As Integer
    Private duracion As String
    Private precio As Decimal
    Private sinopsis As String
    Private url_imagen As String
    Private entradas As Integer

    ' GETTERS Y SETTERS
    Public Property pEntradas() As Integer
        Get
            Return entradas
        End Get
        Set(ByVal value As Integer)
            entradas = value
        End Set
    End Property
    Public Property pUrl() As String
        Get
            Return url_imagen
        End Get
        Set(ByVal value As String)
            url_imagen = value
        End Set
    End Property
    Public Property pSinopsis() As String
        Get
            Return sinopsis
        End Get
        Set(ByVal value As String)
            sinopsis = value
        End Set
    End Property
    Public Property pPrecio() As Decimal
        Get
            Return precio
        End Get
        Set(ByVal value As Decimal)
            precio = value
        End Set
    End Property
    Public Property pDuracion() As String
        Get
            Return duracion
        End Get
        Set(ByVal value As String)
            duracion = value
        End Set
    End Property
    Public Property pAnioEstreno() As Integer
        Get
            Return anio_estreno
        End Get
        Set(ByVal value As Integer)
            anio_estreno = value
        End Set
    End Property
    Public Property pTitulo() As String
        Get
            Return titulo
        End Get
        Set(ByVal value As String)
            titulo = value
        End Set
    End Property
    Public Property pPelicula() As Integer
        Get
            Return id_pelicula
        End Get
        Set(ByVal value As Integer)
            id_pelicula = value
        End Set
    End Property

    'CONSTRUCTORES DE LA CLASE
    Public Sub New()
        Me.id_pelicula = 0
        Me.titulo = ""
        Me.anio_estreno = 0
        Me.duracion = ""
        Me.precio = 0.0
        Me.sinopsis = ""
        Me.url_imagen = ""
        Me.entradas = 0
    End Sub

    Public Sub New(id_pelicula As Integer, titulo As String, anio_estreno As Integer, duracion As String, precio As Decimal, sinopsis As String, url_imagen As String, entradas As Integer)
        Me.id_pelicula = id_pelicula
        Me.titulo = titulo
        Me.anio_estreno = anio_estreno
        Me.duracion = duracion
        Me.precio = precio
        Me.sinopsis = sinopsis
        Me.url_imagen = url_imagen
        Me.entradas = entradas
    End Sub

    'METODO PARA BUSCAR LA PELICULA
    Public Function BuscarPeli(id As Integer) As Peliculas

        Dim pelicula As Peliculas
        Dim conexion As MySqlConnection = ConexionBD.ObtenerConexion()

        If conexion Is Nothing Then
            Return pelicula
        End If

        Dim sql As String = $"SELECT * FROM pelicula WHERE id_pelicula = {id}"
        Dim comando As New MySqlCommand(sql, conexion)
        Dim lector As MySqlDataReader = comando.ExecuteReader()

        If lector.Read() Then
            pelicula = New Peliculas(
                    lector("id_pelicula"),
                    lector("titulo").ToString(),
                    lector("anio_estreno"),
                    lector("duracion").ToString(),
                    Convert.ToDecimal(lector("precio")),
                    lector("sinopsis").ToString(),
                    lector("url_imagen").ToString(),
                    lector("entradas")
                )
        End If

        lector.Close()
        conexion.Close()

        Return pelicula

    End Function

    'METODO PARA ACTUALIZAR LAS ENTRADAS
    Public Function actualizarEntrada(peli As Peliculas, numEntradas As Integer) As Peliculas

        'COMPRUEBA SI HAY MAS ENTRADAS
        If peli.entradas - numEntradas < 0 Then
            MessageBox.Show("No quedan tantas entrdas")
            Return peli
        End If

        Dim conexion As MySqlConnection = ConexionBD.ObtenerConexion()
        Dim entradasRestantes As Integer = peli.entradas - numEntradas

        If conexion Is Nothing Then
            Return peli
        End If

        Dim sql As String = $"UPDATE pelicula SET entradas = {entradasRestantes} WHERE id_pelicula = {peli.id_pelicula}"
        Dim comando As New MySqlCommand(sql, conexion)
        comando.ExecuteNonQuery()
        conexion.Close()

        'CON ESTO ESCRIBO EN EL FICHERO
        Me.venderEntradas(numEntradas, peli)
        peli = peli.BuscarPeli(peli.id_pelicula)
        Return peli
    End Function

    Private Sub venderEntradas(numEntradas As Integer, peli As Peliculas)
        'Escribir en el fichero
        Dim linea As String = $"{peli.titulo} - número de entradas: {numEntradas} - importe total: {peli.precio * numEntradas}€"

        Try
            Dim streamWritter As New StreamWriter("peliculas.txt", True)
            streamWritter.WriteLine(linea)
            MessageBox.Show($"Tus {numEntradas} entradas fueron compradas con exito!!!!")
            streamWritter.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
