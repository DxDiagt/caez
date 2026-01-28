Imports Microsoft.Data.SqlClient

Public Class Login
    Private conexion As New Microsoft.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cristian\Desktop\CAEZ\WinFormsApp1\bin\Debug\Database1.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextIngresoDeUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextIngresoDeUsuario.TextChanged

    End Sub

    Private Sub TextContraseña_TextChanged(sender As Object, e As EventArgs) Handles TextContraseña.TextChanged

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim usuario, password As String
        usuario = TextIngresoDeUsuario.Text
        password = TextContraseña.Text
        Dim accesoPermitido As Boolean = False

        ' Validar contra la base de datos
        Try
            conexion.Open()
            Dim sql As String = "SELECT COUNT(*) FROM Registro_de_usuario WHERE (Nombre_del_usuario = @usuario OR Correo_electronico = @usuario) AND Password = @password"
            Dim cmd As New Microsoft.Data.SqlClient.SqlCommand(sql, conexion)
            cmd.Parameters.AddWithValue("@usuario", usuario)
            cmd.Parameters.AddWithValue("@password", password)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                accesoPermitido = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        If accesoPermitido Then
            MessageBox.Show("Bienvenido al sistema", "Acceso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Gestiondeinventario.Show()
        Else
            MessageBox.Show("Usuario o Contraseña Incorrecta", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LinkRegitroDeUsuario_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkRegistroDeUsuario.LinkClicked
        Dim frm As New Registrodeusuario()
        frm.ShowDialog()



    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub
End Class