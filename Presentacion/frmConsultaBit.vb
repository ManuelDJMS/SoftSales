Imports System.Data.SqlClient
Public Class frmConsultaBit
    Dim da As New SqlDataAdapter
    Dim dt2 As New DataTable
    Dim lector As SqlDataReader
    Dim cmd As SqlCommand
    Dim cadena As String

    Private Sub frmConsultaBit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim clase As New SqlConnection(conexionBit)
            clase.Open()
            cmd = clase.CreateCommand
            Dim R As String
            R = "select *from Resultados"
            cmd.CommandText = R
            lector = cmd.ExecuteReader
            While lector.Read()
                DataBitacora.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            End While
            lector.Close()
            clase.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Consulta Bitacora", "Error al iniciar el formulario", Err.Number, cadena)
        End Try
    End Sub
End Class