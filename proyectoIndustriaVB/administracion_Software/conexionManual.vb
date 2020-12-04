Imports System.Data
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Xml


Public Class conexionManual

    Private aes As New AES()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If txtCnString.Text = "" Then
            MessageBox.Show("Por favor ingrese la cadena de conexion", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            SavetoXML(aes.Encrypt(txtCnString.Text, appPwdUnique, Integer.Parse("256")))
            mostrar_usuario()




        End If


    End Sub
    Sub mostrar_usuario()

        Dim idusuario As Integer
        Dim conexionPrueba As New SqlConnection(txtCnString.Text)
        ' Dim con As New SqlCommand("Select count(id) from usuario", conexionPrueba)
        Try
            conexionPrueba.Open()

            abrir()

            ' idusuario = con.ExecuteScalar()
            MessageBox.Show("Conexion creada correctamente", "conexion")
            Dim usuario As New Comercializadora.Form1
            usuario.Show()
            Me.Hide()
            cerrar()



        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub SavetoXML(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("ConnectionString.xml")
        Dim root As XmlElement = doc.DocumentElement
        root.Attributes.Item(0).Value = dbcnString
        Dim writer As XmlTextWriter = New XmlTextWriter("ConnectionString.xml", Nothing)
        writer.Formatting = Formatting.Indented
        doc.Save(writer)
        writer.Close()
    End Sub
    Dim dbcnString As String
    Public Sub ReadfromXML()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("ConnectionString.xml")
            Dim root As XmlElement = doc.DocumentElement
            dbcnString = root.Attributes.Item(0).Value
            txtCnString.Text = (aes.Decrypt(dbcnString, appPwdUnique, Integer.Parse("256")))
        Catch ex As System.Security.Cryptography.CryptographicException
        End Try
    End Sub

    Private Sub ConexionManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadfromXML()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class