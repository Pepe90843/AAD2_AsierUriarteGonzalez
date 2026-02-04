Public Class Form3
    Dim peli As New Peliculas
    Dim totalEntradas As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btComprar.Click
        If totalEntradas < 10 Then
            Me.peli = Me.peli.actualizarEntrada(peli, Entradas.Value)
            Me.totalEntradas += Entradas.Value
            Form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Ya has comprado 10 entradas hoy, vuelva otro día!!!!")
        End If

    End Sub

    Public Sub Mostrar(peli As Peliculas)
        Me.peli = peli
        lblEntradas.Text = peli.pEntradas
        Me.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btVolver.Click
        Form2.MostrarPeli(Me.peli)
        Me.Hide()
    End Sub
End Class