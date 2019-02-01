Imports System.Data.SqlClient
Public Class frmVerSesion
    Dim cmd As SqlCommand
    Dim lector As SqlDataReader
    Dim cadena As String
    Private Sub frmVerSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        Dim clase As New SqlConnection(conexion)
        clase.Open()
        cmd = clase.CreateCommand
        Dim R As String
        R = "select FolioCorte, sesion.idsesion, fechaapertura, fechacierre, totalEfectivoSis, TotalChequeSis,TotalTarjetaSis,Totalvalesis, folios, sesion.idempleado, ncaja, importeinicial from CorteCaja inner join sesion on CorteCaja.idSesion=sesion.idsesion inner join empleados on sesion.idempleado=empleados.idempleado where sesion.idempleado=" & usuario
        cmd.CommandText = R
        lector = cmd.ExecuteReader
        While lector.Read()
            DataBitacora.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9), lector(10), lector(11))
        End While
        lector.Close()
        clase.Close()
        'Catch ex As Exception
        ' MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        ' cadena = Err.Description
        ' cadena = cadena.Replace("'", "")
        ' Bitacora("Consulta Bitacora", "Error al iniciar el formulario", Err.Number, cadena)
        ' End Try
    End Sub
End Class