Imports Microsoft.Data.SqlClient

Public Class Registrodeusuario


    Dim conexion As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cristian\Desktop\CAEZ\WinFormsApp1\bin\Debug\Database1.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
    End Sub

    Private Sub Password2_TextChanged(sender As Object, e As EventArgs) Handles Password2.TextChanged
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged
    End Sub

    Private Sub TextFechaDeNacimiento_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub TextCorreo_TextChanged(sender As Object, e As EventArgs) Handles TextCorreo.TextChanged
    End Sub

    Private Sub TextApellidoDeUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextApellidoDeUsuario.TextChanged
    End Sub

    Private Sub TextNombreDeUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextNombreDeUsuario.TextChanged
    End Sub

    Private Sub TextAutID_TextChanged(sender As Object, e As EventArgs)
    End Sub


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            conexion.Open()
            Dim sql As String = "INSERT INTO Registro_de_usuario (Nombre_del_usuario, Apellido_del_usuario, Correo_electronico, Fecha_de_nacimiento, Password) VALUES (@Nombre_del_usuario, @Apellido_del_usuario, @Correo_electronico, @Fecha_de_nacimiento, @Password)"
            Dim cmd As New SqlCommand(sql, conexion)


            cmd.Parameters.AddWithValue("@Nombre_del_usuario", TextNombreDeUsuario.Text)
            cmd.Parameters.AddWithValue("@Apellido_del_usuario", TextApellidoDeUsuario.Text)
            cmd.Parameters.AddWithValue("@Correo_electronico", TextCorreo.Text)
            cmd.Parameters.AddWithValue("@Fecha_de_nacimiento", DateTimeFechaNacimiento.Value)
            cmd.Parameters.AddWithValue("@Password", password.Text)


            cmd.ExecuteNonQuery()
            MessageBox.Show("Usuario registrado correctamente ✅")

            Dim gestionForm As New Gestiondeinventario()
            gestionForm.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al registrar: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        TextNombreDeUsuario.Clear()
        TextApellidoDeUsuario.Clear()
        TextCorreo.Clear()
        DateTimeFechaNacimiento.Value = DateTime.Now
        password.Clear()
        Password2.Clear()

    End Sub

    Private Sub DateTimeFechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeFechaNacimiento.ValueChanged

    End Sub

    Private Sub Registrodeusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class