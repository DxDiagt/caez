Public Class Presentacion

    Private Sub Presentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuramos el ProgressBar
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0

        ' Configuramos el Timer
        Timer1.Interval = 100 ' cada 100 ms
        Timer1.Start()
    End Sub




    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Incrementamos la barra sin exceder el máximo
        If ProgressBar1.Value + 5 <= ProgressBar1.Maximum Then
            ProgressBar1.Value += 5
        Else
            ProgressBar1.Value = ProgressBar1.Maximum
        End If

        ' Cuando llega al máximo
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            Timer1.Stop()

            ' Abrimos la ventana predeterminada
            Dim frmPrincipal As New Login() ' tu formulario destino
            frmPrincipal.Show()

            ' Ocultamos el splash para evitar que la aplicación termine
            Me.Hide()
        End If
    End Sub

End Class

