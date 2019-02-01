Imports System.Data.SqlClient
Public Class frmConsultaDescrip
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt2 As New DataTable
    Dim lector As SqlDataReader
    Dim oferta2x1 As Boolean
    Dim ofertaactiva As Boolean
    Dim menor As Decimal
    Dim cadena As String
    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles TextBuscarD.TextChanged
        Try
            TextModelo.Clear()
            Dim clase As New SqlConnection(conexion)
            clase.Open()
            dt2 = New DataTable
            With cmd
                .Connection = clase
                .CommandText = "Select codigo_barras, descripcion, precioventa, existencia, modelo, marca from articulos where descripcion like '" & TextBuscarD.Text & "%'"
            End With
            da.SelectCommand = cmd
            da.Fill(dt2)
            DataBuscat.DataSource = dt2
            da.Dispose()
            clase.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Consulta por Descripción (Ventas)", "Error al iniciar el formulario", Err.Number, cadena)
        End Try
    End Sub

    Private Sub DataGridViewX1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataBuscat.CellDoubleClick
        Try
            Dim C As Integer
            Dim localizado As Boolean
            Dim total As Decimal
            Dim ttart As Integer
            Dim descuentog As Decimal
            Dim totaldescuento As Decimal
            Dim grabtotal As Decimal
            Dim extra As Decimal
            descuentog = Convert.ToDecimal(frmVentas.TextDGlobal.Text)
            Dim clase As New SqlConnection(conexion)
            clase.Open()
            cmd = clase.CreateCommand
            cmd.CommandText = "select codigo_barras, descripcion, precioventa, existencia, descuento from Articulos where codigo_barras='" & DataBuscat.SelectedCells.Item(0).Value & "'"
            lector = cmd.ExecuteReader
            lector.Read()
            extra = 100 - lector(4)
            'Empiezo con una decision para saber si la cantidad no revasa la existeencia 
            If (lector(3) < TextCantidad.Value) Then
                MsgBox("La cantidad que intenta vender supera la que hay en existencia", MsgBoxStyle.Critical, "Error en Existencia")
            Else

                '-------------Aqui empiezo una decision para calcular los productos que tengan algun descuento--------------------------

                If lector(4) > 0 Then
                    If frmVentas.DataVentas.Rows.Count < 2 Then
                        frmVentas.DataVentas.Rows.Add(DataBuscat.SelectedCells.Item(0).Value, lector(1), TextCantidad.Value, (lector(2) * 100) / extra, lector(4), (TextCantidad.Value * lector(2)))
                        'TextArticulo.Clear()
                        TextCantidad.Value = 1
                    Else
                        Encontrado = DataBuscat.SelectedCells.Item(0).Value
                        For Each i As DataGridViewRow In frmVentas.DataVentas.Rows
                            If Encontrado = frmVentas.DataVentas.Item(0, i.Index).Value Then
                                localizado = True
                                'Decision para saber si rebasa la existencia
                                If (frmVentas.DataVentas.Item(2, i.Index).Value = lector(4)) Then
                                    MsgBox("La cantidad que intenta vender supera la que hay en existencia", MsgBoxStyle.Critical, "Error en Existencia")
                                Else
                                    '--------------------------------------------------------
                                    C = frmVentas.DataVentas.Item(2, i.Index).Value
                                    frmVentas.DataVentas.Item(2, i.Index).Value = C + TextCantidad.Value
                                    frmVentas.DataVentas.Item(5, i.Index).Value = frmVentas.DataVentas.Item(2, i.Index).Value * lector(2)
                                    'TextArticulo.Clear()
                                    TextCantidad.Value = 1
                                End If 'Aqui termina la decision de la existencia
                            End If
                        Next
                        If Not localizado Then
                            frmVentas.DataVentas.Rows.Add(DataBuscat.SelectedCells.Item(0).Value, lector(1), TextCantidad.Value, (lector(2) * 100) / extra, lector(4), (TextCantidad.Value * lector(2)))
                            'TextArticulo.Clear()
                            TextCantidad.Value = 1
                        End If
                    End If
                    '--------------------------------Esto quiere decir que sin no hay ofertas haga todo con normalidad---------------------
                Else
                    If frmVentas.DataVentas.Rows.Count < 2 Then
                        frmVentas.DataVentas.Rows.Add(DataBuscat.SelectedCells.Item(0).Value, lector(1), TextCantidad.Value, lector(2), 0, (TextCantidad.Value * lector(2)))
                        'TextArticulo.Clear()
                        TextCantidad.Value = 1
                    Else
                        Encontrado = DataBuscat.SelectedCells.Item(0).Value
                        For Each i As DataGridViewRow In frmVentas.DataVentas.Rows
                            If Encontrado = frmVentas.DataVentas.Item(0, i.Index).Value Then
                                localizado = True
                                'Decision para saber si rebasa la existencia
                                If (frmVentas.DataVentas.Item(2, i.Index).Value = lector(4)) Then
                                    MsgBox("La cantidad que intenta vender supera la que hay en existencia", MsgBoxStyle.Critical, "Error en Existencia")
                                Else
                                    '--------------------------------------------------------
                                    C = frmVentas.DataVentas.Item(2, i.Index).Value
                                    frmVentas.DataVentas.Item(2, i.Index).Value = C + TextCantidad.Value
                                    frmVentas.DataVentas.Item(5, i.Index).Value = frmVentas.DataVentas.Item(2, i.Index).Value * frmVentas.DataVentas.Item(3, i.Index).Value
                                    'TextArticulo.Clear()
                                    TextCantidad.Value = 1
                                End If 'Aqui termina la decision de la existencia
                            End If
                        Next
                        If Not localizado Then
                            frmVentas.DataVentas.Rows.Add(DataBuscat.SelectedCells.Item(0).Value, lector(1), TextCantidad.Value, lector(2), 0, (TextCantidad.Value * lector(2)))
                            'TextArticulo.Clear()
                            TextCantidad.Value = 1
                        End If
                    End If
                End If

                lector.Close()
                clase.Close()
                'A partir de aqui se suma el total neto, descuento y totales
                For Each fila In frmVentas.DataVentas.Rows
                    ttart += Convert.ToDecimal(fila.Cells("CantidadData").Value)
                    total += Convert.ToDecimal(fila.Cells("TotalData").Value)
                Next
                frmVentas.TextTArticulos.Text = Convert.ToString(ttart)
                frmVentas.TextSubNeto.Text = Convert.ToString(total)
                totaldescuento = (total * descuentog) / 100
                totaldescuento = Format(totaldescuento, "0.00")
                frmVentas.TextDexcuento.Text = Convert.ToString(totaldescuento)
                grabtotal = total - totaldescuento
                grabtotal = Format(grabtotal, "0.00")
                frmVentas.TextSubtotal.Text = Convert.ToString(grabtotal)
                frmVentas.TextGranT.Text = Convert.ToString(grabtotal)
                '-----------------------------------------------------------------------
            End If 'aqui se cierra todo si la cantidad esta bien
            Me.Close()
        Catch ex As Exception
            MsgBox("Selecciona un artículo", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub TextModelo_TextChanged(sender As Object, e As EventArgs) Handles TextModelo.TextChanged
        Try
            TextBuscarD.Clear()
            Dim clase As New SqlConnection(conexion)
            clase.Open()
            dt2 = New DataTable
            With cmd
                .Connection = clase
                .CommandText = "Select codigo_barras, descripcion, precioventa, existencia, modelo, marca from articulos where modelo like '" & TextModelo.Text & "%'"
            End With
            da.SelectCommand = cmd
            da.Fill(dt2)
            DataBuscat.DataSource = dt2
            da.Dispose()
            clase.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Consulta por Descripción (Ventas)", "Error al iniciar el formulario", Err.Number, cadena)
        End Try
    End Sub
End Class