Imports Microsoft.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO



Public Class Gestiondeinventario

    Dim conexion As New Microsoft.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cristian\Desktop\CAEZ\WinFormsApp1\bin\Debug\Database1.mdf;Integrated Security=True;Connect Timeout=30")
    Private dt As Object
    Private da As Object






    Public ReadOnly Property RichTextBox11 As RichTextBox
        Get
            Return RichTextBox1()
        End Get
    End Property

    Private Function RichTextBox1() As RichTextBox
        Throw New NotImplementedException()
    End Function

    Public Function GetRichTextBox1() As RichTextBox
        Return RichTextBox1()
    End Function

    Public Sub SetRichTextBox1(value As RichTextBox, richTextBox1 As RichTextBox)
        richTextBox1 = value
    End Sub

    Private Sub Gestiondeinventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conexion.Open()
            Dim dt As New DataTable()
            Dim schema As DataTable = conexion.GetSchema("Tables")
            For Each row As DataRow In schema.Rows
                Dim tableName As String = row("TABLE_NAME").ToString()
                If tableName.ToLower() <> "Registro_de_usuario" AndAlso tableName.ToLower() <> "table" Then
                    Combotablas.Items.Add(tableName)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error al cargar tablas: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Combotablas.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione una tabla para buscar.")
            Return
        End If

        Dim tableName As String = Combotablas.SelectedItem.ToString()
        Dim nombreProducto As String = TextBarradeBusqueda.Text.Trim()

        If String.IsNullOrWhiteSpace(nombreProducto) Then
            MessageBox.Show("Ingrese un texto para buscar.")
            Return
        End If

        Dim rutaMDF As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database1.mdf")
        Dim cadenaConexion As String = $"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cristian\Desktop\CAEZ\WinFormsApp1\bin\Debug\Database1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"

        Dim sql As String = $"SELECT * FROM [{tableName}] WHERE [Nombre_del_producto] LIKE @nombre"

        Try
            Using conexion As New Microsoft.Data.SqlClient.SqlConnection(cadenaConexion)
                conexion.Open()

                Using da As New Microsoft.Data.SqlClient.SqlDataAdapter(sql, conexion)
                    da.SelectCommand.Parameters.Add("@nombre", SqlDbType.NVarChar, 100).Value = "%" & nombreProducto & "%"

                    Dim dt As New DataTable()
                    da.Fill(dt)

                    DataGridView1.DataSource = dt

                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("No se encontraron resultados.")
                    Else
                        Dim fila As DataRow = dt.Rows(0)

                        TextNombreProducto.Text = fila("Nombre_del_producto").ToString()
                        TextCantidad.Text = fila("Cantidad").ToString()
                        TextMarcaproducto.Text = fila("Marca").ToString()

                        If dt.Columns.Contains("Fecha_Ingreso") AndAlso Not IsDBNull(fila("Fecha_Ingreso")) Then
                            DateTimeingreso.Value = Convert.ToDateTime(fila("Fecha_Ingreso"))
                        End If

                        If dt.Columns.Contains("Fecha_egreso") AndAlso Not IsDBNull(fila("Fecha_egreso")) Then
                            DateTimegreso.Value = Convert.ToDateTime(fila("Fecha_egreso"))
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message)
        End Try
    End Sub

    Private Sub Combotablas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combotablas.SelectedIndexChanged
        Try
            conexion.Open()
            Dim tableName As String = Combotablas.SelectedItem.ToString()
            Dim sql As String = $"SELECT * FROM [{tableName}]"
            Dim da As New Microsoft.Data.SqlClient.SqlDataAdapter(sql, conexion)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al mostrar la tabla: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub TextBarradeBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TextBarradeBusqueda.TextChanged

    End Sub

    Private Sub TextNombreProducto_TextChanged(sender As Object, e As EventArgs) Handles TextNombreProducto.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextMarcaproducto.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextCantidad.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        If Combotablas.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione una tabla para registrar.")
            Return
        End If

        Dim tableName As String = Combotablas.SelectedItem.ToString()
        Try
            conexion.Open()
            Dim sql As String = $"INSERT INTO [{tableName}] 
            ([Nombre_del_producto], [Marca], [Cantidad], [Fecha_de_Ingreso]) 
            VALUES (@Nombre_del_producto, @Marca, @Cantidad, @Fecha_de_Ingreso)"

            Dim cmd As New Microsoft.Data.SqlClient.SqlCommand(sql, conexion)
            cmd.Parameters.AddWithValue("@Nombre_del_producto", TextNombreProducto.Text.Trim())
            cmd.Parameters.AddWithValue("@Marca", TextMarcaproducto.Text.Trim())
            cmd.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(TextCantidad.Text.Trim()))
            cmd.Parameters.AddWithValue("@Fecha_de_Ingreso", DateTimeingreso.Value)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Producto registrado correctamente.")
        Catch ex As Exception
            MessageBox.Show("Error al registrar: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim tableName As String = Combotablas.SelectedItem.ToString()

        Dim idValue As Object = DataGridView1.CurrentRow.Cells("Id").Value
        Dim id As Integer = IIf(IsDBNull(idValue), 0, Convert.ToInt32(idValue))

        Dim cantidad As Integer
        If String.IsNullOrEmpty(TextCantidad.Text.Trim()) Then
            cantidad = 0
        Else
            Try
                cantidad = Convert.ToInt32(TextCantidad.Text.Trim())
            Catch ex As FormatException
                MessageBox.Show("La cantidad debe ser un número válido.")
                Return
            End Try
        End If

        Try
            conexion.Open()
            Dim sql As String = $"UPDATE [{tableName}] 
                             SET Nombre_del_producto=@Nombre_del_producto,
                                 Marca=@Marca,
                                 Cantidad=@Cantidad,
                                 Fecha_de_Ingreso=@Fecha_de_Ingreso,
                                 Fecha_de_egreso=@Fecha_de_egreso
                                  "

            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(sql, conexion)
                cmd.Parameters.AddWithValue("@Nombre_del_producto", TextNombreProducto.Text.Trim())
                cmd.Parameters.AddWithValue("@Marca", TextMarcaproducto.Text.Trim())
                cmd.Parameters.AddWithValue("@Cantidad", cantidad)
                cmd.Parameters.AddWithValue("@Fecha_de_Ingreso", DateTimeingreso.Value)
                cmd.Parameters.AddWithValue("@Fecha_de_egreso", DateTimegreso.Value)


                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Producto actualizado correctamente.")
        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub


    Private Sub BtnExtraerPdf_Click(sender As Object, e As EventArgs) Handles BtnExtraerPdf.Click
        Try
            Dim sfd As New SaveFileDialog()
            sfd.Filter = "PDF Files|*.pdf"
            sfd.FileName = "DatosTabla.pdf"

            If sfd.ShowDialog() = DialogResult.OK Then
                Dim savePath As String = sfd.FileName


                Dim doc As New Document(PageSize.A4)
                Dim fs As New FileStream(savePath, FileMode.Create, FileAccess.Write, FileShare.None)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, fs)

                doc.Open()

                Dim fontNormal As Font = FontFactory.GetFont(FontFactory.HELVETICA, 10)
                Dim fontHeader As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)

                doc.Add(New Paragraph("Datos extraídos de la tabla: " & Combotablas.SelectedItem.ToString(),
                                  FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)))
                doc.Add(New Paragraph(vbCrLf))

                If RichTextBox11.Lines.Length > 0 Then
                    Dim headers() As String = RichTextBox11.Lines(0).Split(vbTab)
                    Dim pdfTable As New PdfPTable(headers.Length)

                    For Each header As String In headers
                        Dim cell As New PdfPCell(New Phrase(header, fontHeader))
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY
                        cell.HorizontalAlignment = Element.ALIGN_CENTER
                        pdfTable.AddCell(cell)
                    Next

                    For i As Integer = 1 To RichTextBox11.Lines.Length - 1
                        If Not String.IsNullOrWhiteSpace(RichTextBox11.Lines(i)) Then
                            Dim cells() As String = RichTextBox11.Lines(i).Split(vbTab)
                            For Each cellText As String In cells
                                pdfTable.AddCell(New Phrase(cellText, fontNormal))
                            Next
                        End If
                    Next

                    doc.Add(pdfTable)
                End If

                doc.Close()
                fs.Close()

                MessageBox.Show("PDF generado correctamente en: " & savePath)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al generar PDF: " & ex.Message & vbCrLf & "StackTrace: " & ex.StackTrace)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.CurrentRow Is Nothing Then Return

        Try
            Dim row As DataGridViewRow = DataGridView1.CurrentRow
            Dim cellValue As Object


            cellValue = row.Cells("Nombre_del_producto").Value
            TextNombreProducto.Text = IIf(IsDBNull(cellValue), "", cellValue.ToString())


            cellValue = row.Cells("Marca").Value
            TextMarcaproducto.Text = IIf(IsDBNull(cellValue), "", cellValue.ToString())


            cellValue = row.Cells("Cantidad").Value
            TextCantidad.Text = IIf(IsDBNull(cellValue), "0", cellValue).ToString()


            cellValue = row.Cells("Fecha_de_Ingreso").Value
            If Not IsDBNull(cellValue) Then
                DateTimeingreso.Value = CDate(cellValue)
            End If

            cellValue = row.Cells("Fecha_de_egreso").Value
            If Not IsDBNull(cellValue) Then
                DateTimegreso.Value = CDate(cellValue)
            Else

                DateTimegreso.Value = Date.Today
            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos del producto: " & ex.Message)
        End Try

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub DateTimeingreso_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeingreso.ValueChanged

    End Sub

    Private Sub DateTimegreso_ValueChanged(sender As Object, e As EventArgs) Handles DateTimegreso.ValueChanged

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim valorId = DataGridView1.SelectedRows(0).Cells("Id").Value

            If valorId IsNot Nothing AndAlso Not IsDBNull(valorId) Then
                Dim idEliminar As Integer = Convert.ToInt32(valorId)

                Dim conexionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cristian\Desktop\CAEZ\WinFormsApp1\bin\Debug\Database1.mdf;Integrated Security=True;Connect Timeout=30"

                Using conexion As New SqlConnection(conexionString)
                    conexion.Open()

                    Dim query As String = "DELETE FROM Electricidad WHERE Id = @Id"
                    Using comando As New SqlCommand(query, conexion)
                        comando.Parameters.AddWithValue("@Id", idEliminar)

                        Dim filasAfectadas As Integer = comando.ExecuteNonQuery()

                        If filasAfectadas > 0 Then
                            MessageBox.Show("Registro eliminado correctamente.")


                            Dim adaptador As New SqlDataAdapter("SELECT * FROM Electricidad", conexion)
                            Dim tabla As New DataTable()
                            adaptador.Fill(tabla)
                            DataGridView1.DataSource = tabla
                        Else
                            MessageBox.Show("No se encontró el registro a eliminar.")
                        End If
                    End Using
                End Using
            Else
                MessageBox.Show("El Id seleccionado está vacío o es inválido.")
            End If
        Else
            MessageBox.Show("Por favor selecciona una fila para eliminar.")
        End If




    End Sub
End Class