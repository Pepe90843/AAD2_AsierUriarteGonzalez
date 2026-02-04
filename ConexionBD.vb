Imports MySql.Data.MySqlClient

Public Class ConexionBD

    'CADENA DE TEXTO PARA CONECTARSE A XAMPP
    Private Shared cadenaConexion As String = "server=localhost;database=CINE;user=root;password=;"

    'DEVUELVE UNA CONEXION ABIERTA
    Public Shared Function ObtenerConexion() As MySqlConnection
        Dim conexion As MySqlConnection = Nothing

        Try
            conexion = New MySqlConnection(cadenaConexion)
            conexion.Open()
        Catch ex As MySqlException
            MessageBox.Show(
                "Error al conectar con la base de datos:" & vbCrLf & ex.Message,
                "Error de conexión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try

        Return conexion
    End Function
End Class