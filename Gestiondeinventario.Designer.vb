<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestiondeinventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestiondeinventario))
        Label1 = New Label()
        Combotablas = New ComboBox()
        TextBarradeBusqueda = New TextBox()
        btnBuscar = New Button()
        Label2 = New Label()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        Label4 = New Label()
        Label5 = New Label()
        btnRegistrar = New Button()
        btnActualizar = New Button()
        btnEliminar = New Button()
        BtnExtraerPdf = New Button()
        Label6 = New Label()
        TextNombreProducto = New TextBox()
        TextCantidad = New TextBox()
        TextMarcaproducto = New TextBox()
        HScrollBar1 = New HScrollBar()
        VScrollBar1 = New VScrollBar()
        DateTimeingreso = New DateTimePicker()
        Label7 = New Label()
        DateTimegreso = New DateTimePicker()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(500, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 27)
        Label1.TabIndex = 0
        Label1.Text = "Gestión de inventario."
        ' 
        ' Combotablas
        ' 
        Combotablas.FormattingEnabled = True
        Combotablas.Location = New Point(185, 37)
        Combotablas.Margin = New Padding(1, 2, 1, 2)
        Combotablas.Name = "Combotablas"
        Combotablas.Size = New Size(187, 24)
        Combotablas.TabIndex = 1
        ' 
        ' TextBarradeBusqueda
        ' 
        TextBarradeBusqueda.Location = New Point(384, 38)
        TextBarradeBusqueda.Margin = New Padding(1, 2, 1, 2)
        TextBarradeBusqueda.Name = "TextBarradeBusqueda"
        TextBarradeBusqueda.Size = New Size(660, 23)
        TextBarradeBusqueda.TabIndex = 2
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnBuscar.Location = New Point(1054, 36)
        btnBuscar.Margin = New Padding(1, 2, 1, 2)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(116, 24)
        btnBuscar.TabIndex = 3
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sans Serif Collection", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(49, 107)
        Label2.Margin = New Padding(1, 0, 1, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 41)
        Label2.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(49, 164)
        Label3.Margin = New Padding(1, 0, 1, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 16)
        Label3.TabIndex = 5
        Label3.Text = "Cantidad:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(36, 281)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1148, 149)
        DataGridView1.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(779, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 16)
        Label4.TabIndex = 7
        Label4.Text = "Marca del producto:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(779, 164)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 16)
        Label5.TabIndex = 8
        Label5.Text = "Fecha de ingreso:"
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Location = New Point(49, 235)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(103, 31)
        btnRegistrar.TabIndex = 9
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(384, 235)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(96, 31)
        btnActualizar.TabIndex = 10
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(695, 235)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(96, 31)
        btnEliminar.TabIndex = 11
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' BtnExtraerPdf
        ' 
        BtnExtraerPdf.Location = New Point(1074, 235)
        BtnExtraerPdf.Name = "BtnExtraerPdf"
        BtnExtraerPdf.Size = New Size(96, 31)
        BtnExtraerPdf.TabIndex = 12
        BtnExtraerPdf.Text = "Extraer PDF"
        BtnExtraerPdf.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(49, 107)
        Label6.Margin = New Padding(1, 0, 1, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(132, 16)
        Label6.TabIndex = 13
        Label6.Text = "Nombre del producto:"
        ' 
        ' TextNombreProducto
        ' 
        TextNombreProducto.Location = New Point(185, 100)
        TextNombreProducto.Name = "TextNombreProducto"
        TextNombreProducto.Size = New Size(242, 23)
        TextNombreProducto.TabIndex = 14
        ' 
        ' TextCantidad
        ' 
        TextCantidad.Location = New Point(185, 157)
        TextCantidad.Name = "TextCantidad"
        TextCantidad.Size = New Size(242, 23)
        TextCantidad.TabIndex = 15
        ' 
        ' TextMarcaproducto
        ' 
        TextMarcaproducto.Location = New Point(917, 104)
        TextMarcaproducto.Name = "TextMarcaproducto"
        TextMarcaproducto.Size = New Size(253, 23)
        TextMarcaproducto.TabIndex = 16
        ' 
        ' HScrollBar1
        ' 
        HScrollBar1.Location = New Point(36, 418)
        HScrollBar1.Name = "HScrollBar1"
        HScrollBar1.Size = New Size(1134, 11)
        HScrollBar1.TabIndex = 18
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Location = New Point(1170, 281)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(14, 148)
        VScrollBar1.TabIndex = 19
        ' 
        ' DateTimeingreso
        ' 
        DateTimeingreso.Location = New Point(917, 157)
        DateTimeingreso.Name = "DateTimeingreso"
        DateTimeingreso.Size = New Size(253, 23)
        DateTimeingreso.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(779, 203)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 16)
        Label7.TabIndex = 21
        Label7.Text = "Fecha de egreso:"
        ' 
        ' DateTimegreso
        ' 
        DateTimegreso.Location = New Point(917, 198)
        DateTimegreso.Name = "DateTimegreso"
        DateTimegreso.Size = New Size(253, 23)
        DateTimegreso.TabIndex = 22
        ' 
        ' Gestiondeinventario
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1278, 442)
        Controls.Add(DateTimegreso)
        Controls.Add(Label7)
        Controls.Add(DateTimeingreso)
        Controls.Add(VScrollBar1)
        Controls.Add(HScrollBar1)
        Controls.Add(TextMarcaproducto)
        Controls.Add(TextCantidad)
        Controls.Add(TextNombreProducto)
        Controls.Add(Label6)
        Controls.Add(BtnExtraerPdf)
        Controls.Add(btnEliminar)
        Controls.Add(btnActualizar)
        Controls.Add(btnRegistrar)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnBuscar)
        Controls.Add(TextBarradeBusqueda)
        Controls.Add(Combotablas)
        Controls.Add(Label1)
        Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ControlText
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Gestiondeinventario"
        Text = "Gestion de inventario"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Combotablas As ComboBox
    Friend WithEvents TextBarradeBusqueda As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents BtnExtraerPdf As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextNombreProducto As TextBox
    Friend WithEvents TextCantidad As TextBox
    Friend WithEvents TextMarcaproducto As TextBox
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents DateTimeingreso As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimegreso As DateTimePicker
End Class
