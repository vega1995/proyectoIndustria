<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conexionManual
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCnString = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Menu
        Me.Label1.Location = New System.Drawing.Point(26, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese la cadena conexion"
        '
        'txtCnString
        '
        Me.txtCnString.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCnString.Location = New System.Drawing.Point(30, 98)
        Me.txtCnString.Name = "txtCnString"
        Me.txtCnString.Size = New System.Drawing.Size(603, 33)
        Me.txtCnString.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(575, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Una vez que estes listo dale a ""Generar cadena de conexion"". Se creara un Archivo" &
    " que " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "contendra tu conexion Encryptada."
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.White
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(368, 137)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(265, 31)
        Me.button1.TabIndex = 3
        Me.button1.Text = "Generar cadena de conexion"
        Me.button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(603, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 36)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'conexionManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(657, 220)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCnString)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "conexionManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "conexion Manual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCnString As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents button1 As Button
    Friend WithEvents Button2 As Button
End Class
