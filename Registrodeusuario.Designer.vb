<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrodeusuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrodeusuario))
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        TextNombreDeUsuario = New TextBox()
        TextApellidoDeUsuario = New TextBox()
        TextCorreo = New TextBox()
        password = New TextBox()
        Password2 = New TextBox()
        btnCancelar = New Button()
        btnRegistrar = New Button()
        DateTimeFechaNacimiento = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(259, 6)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(269, 81)
        Label1.TabIndex = 0
        Label1.Text = "Registro de usuario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(36, 114)
        Label3.Margin = New Padding(1, 0, 1, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 15)
        Label3.TabIndex = 2
        Label3.Text = "Nombre de usuario:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(34, 176)
        Label4.Margin = New Padding(1, 0, 1, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 15)
        Label4.TabIndex = 3
        Label4.Text = "Apellido de usuario:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(34, 243)
        Label5.Margin = New Padding(1, 0, 1, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 15)
        Label5.TabIndex = 4
        Label5.Text = "Correo electronico:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(101, 258)
        Label6.Margin = New Padding(1, 0, 1, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 15)
        Label6.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(44, 392)
        Label7.Margin = New Padding(1, 0, 1, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 15)
        Label7.TabIndex = 6
        Label7.Text = "Contraseña:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(36, 317)
        Label8.Margin = New Padding(1, 0, 1, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(121, 15)
        Label8.TabIndex = 7
        Label8.Text = "Fecha de nacimiento:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(36, 463)
        Label9.Margin = New Padding(1, 0, 1, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(135, 15)
        Label9.TabIndex = 8
        Label9.Text = "Confirmar Contraseña:"
        ' 
        ' TextNombreDeUsuario
        ' 
        TextNombreDeUsuario.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextNombreDeUsuario.Location = New Point(197, 109)
        TextNombreDeUsuario.Margin = New Padding(1)
        TextNombreDeUsuario.Multiline = True
        TextNombreDeUsuario.Name = "TextNombreDeUsuario"
        TextNombreDeUsuario.Size = New Size(331, 26)
        TextNombreDeUsuario.TabIndex = 10
        ' 
        ' TextApellidoDeUsuario
        ' 
        TextApellidoDeUsuario.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextApellidoDeUsuario.Location = New Point(197, 166)
        TextApellidoDeUsuario.Margin = New Padding(1)
        TextApellidoDeUsuario.Multiline = True
        TextApellidoDeUsuario.Name = "TextApellidoDeUsuario"
        TextApellidoDeUsuario.Size = New Size(331, 25)
        TextApellidoDeUsuario.TabIndex = 11
        ' 
        ' TextCorreo
        ' 
        TextCorreo.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextCorreo.Location = New Point(197, 231)
        TextCorreo.Margin = New Padding(1)
        TextCorreo.Multiline = True
        TextCorreo.Name = "TextCorreo"
        TextCorreo.Size = New Size(331, 27)
        TextCorreo.TabIndex = 12
        ' 
        ' password
        ' 
        password.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        password.Location = New Point(189, 379)
        password.Margin = New Padding(1)
        password.Multiline = True
        password.Name = "password"
        password.PasswordChar = "*"c
        password.Size = New Size(339, 28)
        password.TabIndex = 14
        ' 
        ' Password2
        ' 
        Password2.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Password2.Location = New Point(189, 453)
        Password2.Margin = New Padding(1)
        Password2.Multiline = True
        Password2.Name = "Password2"
        Password2.PasswordChar = "*"c
        Password2.Size = New Size(339, 25)
        Password2.TabIndex = 15
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelar.Location = New Point(578, 554)
        btnCancelar.Margin = New Padding(1)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(133, 37)
        btnCancelar.TabIndex = 16
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegistrar.Location = New Point(44, 554)
        btnRegistrar.Margin = New Padding(1)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(133, 37)
        btnRegistrar.TabIndex = 17
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' DateTimeFechaNacimiento
        ' 
        DateTimeFechaNacimiento.CalendarFont = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimeFechaNacimiento.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimeFechaNacimiento.Location = New Point(189, 307)
        DateTimeFechaNacimiento.Name = "DateTimeFechaNacimiento"
        DateTimeFechaNacimiento.Size = New Size(339, 25)
        DateTimeFechaNacimiento.TabIndex = 18
        ' 
        ' Registrodeusuario
        ' 
        AutoScaleDimensions = New SizeF(12F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(767, 614)
        Controls.Add(DateTimeFechaNacimiento)
        Controls.Add(btnRegistrar)
        Controls.Add(btnCancelar)
        Controls.Add(Password2)
        Controls.Add(password)
        Controls.Add(TextCorreo)
        Controls.Add(TextApellidoDeUsuario)
        Controls.Add(TextNombreDeUsuario)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5)
        Name = "Registrodeusuario"
        Text = "Registro de usuario"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextNombreDeUsuario As TextBox
    Friend WithEvents TextApellidoDeUsuario As TextBox
    Friend WithEvents TextCorreo As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents Password2 As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents DateTimeFechaNacimiento As DateTimePicker
End Class
