Imports System.Net.Http
Imports System.Security.Policy
Imports System.Text.Json

Public Class Creditos
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbPerfil.Click
        Dim url As String = "https://github.com/Pepe90843"

        Process.Start(New ProcessStartInfo With {
        .FileName = url,
        .UseShellExecute = True
        })
    End Sub

    Private Async Sub Creditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim perfil As CreditosMetodos = Await ObtenerPerfilGithub()

        If perfil IsNot Nothing Then
            lblNombre.Text = perfil.login
            lblRepos.Text = perfil.public_repos
            pbPerfil.Load(perfil.avatar_url)
        Else
            MessageBox.Show("Error al cargar el perfil de GitHub")
        End If
    End Sub

    Private Async Function ObtenerPerfilGithub() As Task(Of CreditosMetodos)
        Using cliente As New HttpClient()

            cliente.DefaultRequestHeaders.Add("User-Agent", "CineApp")

            Dim url As String = "https://api.github.com/users/Pepe90843"

            Dim respuesta As HttpResponseMessage = Await cliente.GetAsync(url)

            If respuesta.IsSuccessStatusCode Then
                Dim json As String = Await respuesta.Content.ReadAsStringAsync()
                Return JsonSerializer.Deserialize(Of CreditosMetodos)(json)
            End If
        End Using

        Return Nothing
    End Function

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class