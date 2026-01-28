<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextIngresoDeUsuario = New TextBox()
        TextContraseña = New TextBox()
        btnAceptar = New Button()
        btnCancelar = New Button()
        GroupBox1 = New GroupBox()
        linkRegistroDeUsuario = New LinkLabel()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Javanese Text", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(53, -8)
        Label1.Name = "Label1"
        Label1.Size = New Size(514, 54)
        Label1.TabIndex = 0
        Label1.Text = "INGRESAR A GESTION DE INVENTARIO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(35, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 15)
        Label2.TabIndex = 1
        Label2.Text = "Ingreso de usuario:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(35, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 15)
        Label3.TabIndex = 2
        Label3.Text = "Contraseña:"
        ' 
        ' TextIngresoDeUsuario
        ' 
        TextIngresoDeUsuario.Location = New Point(153, 22)
        TextIngresoDeUsuario.Name = "TextIngresoDeUsuario"
        TextIngresoDeUsuario.Size = New Size(250, 23)
        TextIngresoDeUsuario.TabIndex = 3
        ' 
        ' TextContraseña
        ' 
        TextContraseña.Location = New Point(153, 74)
        TextContraseña.Name = "TextContraseña"
        TextContraseña.PasswordChar = "*"c
        TextContraseña.Size = New Size(250, 23)
        TextContraseña.TabIndex = 4
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Location = New Point(452, 220)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(134, 31)
        btnAceptar.TabIndex = 5
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(30, 220)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(134, 31)
        btnCancelar.TabIndex = 6
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(linkRegistroDeUsuario)
        GroupBox1.Controls.Add(TextContraseña)
        GroupBox1.Controls.Add(TextIngresoDeUsuario)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(30, 49)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(556, 165)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Ingresar"
        ' 
        ' linkRegistroDeUsuario
        ' 
        linkRegistroDeUsuario.AutoSize = True
        linkRegistroDeUsuario.Location = New Point(214, 117)
        linkRegistroDeUsuario.Name = "linkRegistroDeUsuario"
        linkRegistroDeUsuario.Size = New Size(99, 15)
        linkRegistroDeUsuario.TabIndex = 5
        linkRegistroDeUsuario.TabStop = True
        linkRegistroDeUsuario.Text = "Registrar Usuario."
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(653, 263)
        Controls.Add(GroupBox1)
        Controls.Add(btnCancelar)
        Controls.Add(btnAceptar)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Login"
        Text = "Ingresar"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextIngresoDeUsuario As TextBox
    Friend WithEvents TextContraseña As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents linkRegistroDeUsuario As LinkLabel
End Class
