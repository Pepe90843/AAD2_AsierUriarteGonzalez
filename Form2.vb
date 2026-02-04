Public Class Form2
    Dim peli As Peliculas
    Private Sub btVenderEntradas_Click(sender As Object, e As EventArgs) Handles btVenderEntradas.Click
        Form3.Mostrar(peli)
    End Sub

    Public Sub MostrarPeli(peli As Peliculas)
        Me.peli = peli
        lblTitulo.Text = peli.pTitulo
        lblDuracion.Text = peli.pDuracion
        lblEstreno.Text = peli.pAnioEstreno
        lblPrecio.Text = $"{peli.pPrecio}€"
        tbSinopsis.Text = peli.pSinopsis
        pbPelicula.ImageLocation = peli.pUrl
        Me.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class