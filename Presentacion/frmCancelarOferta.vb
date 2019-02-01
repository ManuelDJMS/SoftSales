Imports System.Data.SqlClient
Public Class frmCancelarOferta
    Dim cmd As New SqlCommand
    Dim lector As SqlDataReader
    Dim dt2 As New DataTable
    Dim cadena As String
    Dim da As New SqlDataAdapter
    Private Sub frmCancelarOferta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim clase As New SqlConnection(conexion)
            clase.Open()
            cmd = clase.CreateCommand
            Dim R As String
            R = "select nombre, FechaOferta, Aplica, Valor, Descripcion, Estado, idOferta from Ofertas inner join empleados on Ofertas.idempleado=empleados.idempleado where Estado='Activa'"
            cmd.CommandText = R
            lector = cmd.ExecuteReader
            While lector.Read()
                DataOfertas.Rows.Add(lector(6), lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            End While
            lector.Close()
            clase.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Cancelar Ofertas", "Error al iniciar el formulario", Err.Number, cadena)
        End Try
    End Sub

    Private Sub DataOfertas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataOfertas.CellDoubleClick
        Try
            Using conexion1 As New SqlConnection(conexion)
                conexion1.Open()
                Dim transaction As SqlTransaction
                transaction = conexion1.BeginTransaction("Sample")
                cmd = conexion1.CreateCommand()
                cmd.Connection = conexion1
                cmd.Transaction = transaction
                Dim r As String

                'Decision para el departamento oferta
                If (DataOfertas.SelectedCells.Item(3).Value = "Departamento") Then
                    r = "update articulos set precioventa=(precioventa*100)/(100-descuento) where departamento='" & DataOfertas.SelectedCells.Item(4).Value & "'"
                    cmd.CommandText = r
                    cmd.ExecuteNonQuery()
                    r = "update articulos set descuento=0 where departamento='" & DataOfertas.SelectedCells.Item(4).Value & "'"
                    cmd.CommandText = r
                    cmd.ExecuteNonQuery()
                    r = "update ofertas set Estado='Cancelada' where idOferta=" & Val(DataOfertas.SelectedCells.Item(0).Value)
                    cmd.CommandText = r
                    cmd.ExecuteNonQuery()
                    'Decision para la marca
                ElseIf (DataOfertas.SelectedCells.Item(3).Value = "Marca") Then
                    r = "update articulos set precioventa=(precioventa*100)/(100-descuento) where marca='" & DataOfertas.SelectedCells.Item(4).Value & "'"
                    cmd.CommandText = r
                    cmd.ExecuteNonQuery()
                    r = "update articulos set descuento=0 where marca='" & DataOfertas.SelectedCells.Item(4).Value & "'"
                    cmd.CommandText = r
                    cmd.ExecuteNonQuery()
                    r = "update ofertas set Estado='Cancelada' where idOferta=" & Val(DataOfertas.SelectedCells.Item(0).Value)
                    cmd.CommandText = r
                    cmd.ExecuteNonQuery()
                    'Desicion por departamento y marca
                ElseIf (DataOfertas.SelectedCells.Item(3).Value = "Marca y Departamento") Then
                    Dim Cadena As String = DataOfertas.SelectedCells.Item(4).Value
                    Dim ArrCadena As String() = Cadena.Split(" ")
                    'MsgBox(ArrCadena(0))
                    'MsgBox(ArrCadena(1))
                    r = "update articulos set precioventa=(precioventa*100)/(100-descuento) where departamento='" & ArrCadena(1) & "' and marca='" & ArrCadena(0) & "'"
                    cmd.CommandText = r
                    cmd.ExecuteNonQuery()
                    r = "update articulos set descuento=0 where departamento='" & ArrCadena(1) & "' and marca='" & ArrCadena(0) & "'"
                    cmd.CommandText = r
                    cmd.ExecuteNonQuery()
                    r = "update ofertas set Estado='Cancelada' where idOferta=" & Val(DataOfertas.SelectedCells.Item(0).Value)
                    cmd.CommandText = r
                    cmd.ExecuteNonQuery()
                    'Desicion por si fue individual
                Else
                    r = "update articulos set precioventa=(precioventa*100)/(100-descuento) where codigo_barras='" & DataOfertas.SelectedCells.Item(4).Value & "'"
                    cmd.CommandText = r
                    cmd.ExecuteNonQuery()
                    r = "update articulos set descuento=0 where codigo_barras='" & DataOfertas.SelectedCells.Item(4).Value & "'"
                    cmd.CommandText = r
                    cmd.ExecuteNonQuery()
                    r = "update ofertas set Estado='Cancelada' where idOferta=" & Val(DataOfertas.SelectedCells.Item(0).Value)
                    cmd.CommandText = r
                    cmd.ExecuteNonQuery()
                End If
                '------------------------------------------------
                Try
                    If MessageBox.Show("¿Desea Anular la Venta?", "Cancelar Oferta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

                        MsgBox("Los precios de la oferta seleccionada volvieron a su precio normal", MsgBoxStyle.Information, "Guardado Exitoso")
                        transaction.Commit()
                        Me.Close()
                    Else
                        transaction.Rollback()
                        MsgBox("Operacion de Anular Oferta Cancelada", MsgBoxStyle.Critical, "Oferta Cancelada")
                        Me.Close()
                    End If
                Catch ex As Exception
                    MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error externo al Sistema")
                    Try
                        transaction.Rollback()
                Catch ex1 As Exception
                        MsgBox("Error RollBack", MsgBoxStyle.Critical, "Error interno del Sistema")
                    End Try
                End Try
                conexion1.Close()
            End Using
        Catch ex As Exception
            MsgBox("Selecciona una Oferta", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class