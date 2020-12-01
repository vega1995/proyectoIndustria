Imports System.Data.SqlClient
Module conexion
    Public connect As New SqlConnection(checkServer)

    Sub abrir()
        If connect.State = 0 Then
            connect.Open()

        End If
    End Sub
    Sub cerrar()
        If connect.State = 1 Then
            connect.Close()

        End If
    End Sub
End Module
