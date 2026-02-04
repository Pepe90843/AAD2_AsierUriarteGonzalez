Public Class Form1
    Dim peli As New Peliculas
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbINTERESTELAR.Click
        peli = peli.BuscarPeli(1)
        Form2.MostrarPeli(peli)
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pbPRIMATE.Click
        peli = peli.BuscarPeli(2)
        Form2.MostrarPeli(peli)
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles pbVELOCIPASTOR.Click
        peli = peli.BuscarPeli(3)
        Form2.MostrarPeli(peli)
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles pbPIJAMARAYAS.Click
        peli = peli.BuscarPeli(4)
        Form2.MostrarPeli(peli)
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles pbPEORVECINO.Click
        peli = peli.BuscarPeli(5)
        Form2.MostrarPeli(peli)
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Creditos.Show()
        Me.Hide()
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm")
    End Sub
End Class
