Imports System.Data
Imports System.Data.SqlClient
Module Module4
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter
    Sub abrir()
        Try
            conexiones = New SqlConnection("Data Source=SERVER3\COMPAC2;Initial Catalog=METASINF-2019-2; User Id=sa; Password=Met99011578a;Integrated Security=true")
            conexiones.Open()

        Catch ex As Exception

        End Try
    End Sub
    Sub autoCompletar(ByVal campoTexto As TextBox)
        Try
            enunciado = New SqlCommand("select NombreUsuario from Usuarios", conexiones)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read
                campoTexto.AutoCompleteCustomSource.Add("NombreUsuario")
            End While
            respuesta.Close()

        Catch ex As Exception

        End Try
    End Sub
End Module
