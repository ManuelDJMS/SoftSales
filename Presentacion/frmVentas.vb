Imports System.Data.SqlClient
Public Class frmVentas
    Dim comando As SqlCommand
    Dim lector As SqlDataReader
    Dim dt2 As New DataTable
    Dim da As New SqlDataAdapter
    Dim oferta2x1 As Boolean
    Dim menor As Decimal
    Dim ofertaactiva As Boolean = False
    Dim cadena As String
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.ToolTip1.Active = True
            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
            Me.ToolTip1.ToolTipTitle = "Ayuda"
            Me.ToolTip1.SetToolTip(Me.btnEliminar, "Elimina un producto de la lista")
            Me.ToolTip1.SetToolTip(Me.btGuardar, "Guarda los nuevos datos de la venta")
            Me.ToolTip1.SetToolTip(Me.btnNuevo, "Realiza una nueva Venta")
            Me.ToolTip1.SetToolTip(Me.btAgregar, "Busca el artículo por Departamento o Modelo")
            Me.ToolTip1.SetToolTip(Me.BtProductoV, "Agrega un producto común")
            Me.ToolTip1.AutoPopDelay = 5000
            Dim clase As New SqlConnection(conexion)
            clase.Open()
            comando = clase.CreateCommand
            comando.CommandText = "select idempleado, nombre from empleados where idempleado=" & usuario
            lector = comando.ExecuteReader
            lector.Read()
            TextidCajera.Text = lector(0)
            'TextidCajera.Text = "2"
            TextCajera.Text = lector(1)
            lector.Close()
            comando = clase.CreateCommand
            comando.CommandText = "select idvendedor from vendedores"
            lector = comando.ExecuteReader
            While lector.Read()
                ComboVendedor.Items.Add(lector(0))
            End While
            lector.Close()
            clase.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Ventas", "Error al iniciar el formulario", Err.Number, cadena)
        End Try
    End Sub

    Private Sub btnNuevo_MouseHover(sender As Object, e As EventArgs) Handles btnNuevo.MouseHover
        btnNuevo.Size = New Size(126, 38)
    End Sub

    Private Sub btnNuevo_MouseLeave(sender As Object, e As EventArgs) Handles btnNuevo.MouseLeave
        btnNuevo.Size = New Size(123, 35)
    End Sub

    Private Sub btnImprimir_MouseHover(sender As Object, e As EventArgs) Handles btnEliminar.MouseHover
        btnEliminar.Size = New Size(126, 38)
    End Sub

    Private Sub btnImprimir_MouseLeave(sender As Object, e As EventArgs) Handles btnEliminar.MouseLeave
        btnEliminar.Size = New Size(123, 35)
    End Sub

    Private Sub btGuardar_MouseHover(sender As Object, e As EventArgs) Handles btGuardar.MouseHover
        btGuardar.Size = New Size(126, 38)
    End Sub

    Private Sub btGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btGuardar.MouseLeave
        btGuardar.Size = New Size(123, 35)
    End Sub

    Private Sub btSalir_MouseHover(sender As Object, e As EventArgs) Handles btSalir.MouseHover
        btSalir.Size = New Size(126, 38)
    End Sub

    Private Sub btSalir_MouseLeave(sender As Object, e As EventArgs) Handles btSalir.MouseLeave
        btSalir.Size = New Size(123, 35)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Dim clase As New SqlConnection(conexion)
            clase.Open()
            comando = clase.CreateCommand
            TextArticulo.Enabled = True
            TextCantidad.Enabled = True
            ComboCPago.Enabled = True
            ComboVendedor.Enabled = True
            TextDGlobal.Enabled = True
            btAgregar.Enabled = True
            BtProductoV.Enabled = True
            '  limpiarCampos1(GroupPanel3)
            TextDGlobal.Text = "0.0"
            TextTArticulos.Clear()
            limpiarCampos1(GrTotales)
            deshaCampos(GrTotales)
            DataVentas.Rows.Clear()
            'Generar la cadena del folio
            Dim cajafolio As String 'bo
            Dim r As String
           
            Dim idfolio As String
            Dim folio As String
            Dim foliov As String
            Dim foliov2 As String
            cajafolio = Convert.ToString(caja) 'bo
            idfolio = Convert.ToString(usuario)
            folio = "VC" + "C" + caja + idfolio

            r = "select count(*) from Ventas where FolioVenta like '" & folio & "%'"
            comando.CommandText = r
            Dim N As Integer
            N = comando.ExecuteScalar + 1
            foliov = Convert.ToString(N)
            foliov2 = folio + foliov
            TextFolio.Text = foliov2
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Ventas", "Error al precionar Nuevo", Err.Number, cadena)
        End Try
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub
   
    Private Sub TextDGlobal_KeyDown(sender As Object, e As KeyEventArgs) Handles TextDGlobal.KeyDown
        Try

            Select Case e.KeyData
                Case Keys.Enter
                    If TextDGlobal.Text = "" Then
                        MsgBox("Ingrese un descuento mayor a cero", MsgBoxStyle.Critical, "Error del Sistema")
                    Else
                        If MessageBox.Show("Para realizar un descuento necesitará autorización del Admin", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                            Me.Enabled = False
                            autorizacion = "DescuentoGlobal"
                            frmAutorizacion.Show()
                        End If
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Ventas", "Error al realizar un descuento Global", Err.Number, cadena)
        End Try
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            If  DataVentas.RowCount > 1 Then
                If Me.ValidateChildren = True And ComboCPago.Text <> "" And ComboVendedor.Text <> "" Then
                    If ComboCPago.SelectedItem.ToString = "EFECTIVO" Then
                        frmFormaPago.Show()
                        frmFormaPago.TxtCobro.Text = TextGranT.Text
                    ElseIf ComboCPago.SelectedItem.ToString = "CHEQUE" Then
                        frmFormasPago.ptnCheque.Visible = True
                        frmFormasPago.PtnTarjeta.Visible = False
                        frmFormasPago.ptnVale.Visible = False
                        frmFormasPago.ptnCheque.Select()
                        frmFormasPago.TextImporte.Text = TextGranT.Text
                        frmFormasPago.lbTotalCobro.Text = TextGranT.Text
                        frmFormasPago.Show()
                    ElseIf ComboCPago.SelectedItem.ToString = "TARJETA" Then
                        frmFormasPago.PtnTarjeta.Visible = True
                        frmFormasPago.ptnCheque.Visible = False
                        frmFormasPago.ptnVale.Visible = False
                        frmFormasPago.PtnTarjeta.Select()
                        frmFormasPago.TextImporteT.Text = TextGranT.Text
                        frmFormasPago.lbTotalCobroT.Text = TextGranT.Text
                        frmFormasPago.Show()
                    Else
                        frmFormasPago.ptnVale.Visible = True
                        frmFormasPago.ptnCheque.Visible = False
                        frmFormasPago.PtnTarjeta.Visible = False
                        frmFormasPago.ptnVale.Select()
                        frmFormasPago.TextImportV.Text = TextGranT.Text
                        frmFormasPago.lbcobroV.Text = TextGranT.Text
                        frmFormasPago.Show()
                    End If
                    Me.Enabled = False
                Else
                    MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("No hay productos por vender", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'Tiempo.Start()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Ventas", "Error al realizar una venta", Err.Number, cadena)
        End Try
    End Sub

    Private Sub DataVentas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataVentas.CellEndEdit
        Try
            Dim r As Integer
            Dim f As Integer
            Dim cantidad As Integer
            Dim precio As Decimal
            Dim descuento As Decimal
            Dim resta As Decimal
            Dim total As Decimal
            Dim ttart As Decimal
            Dim descuentog As Decimal
            Dim totaldescuento As Decimal
            Dim grabtotal As Decimal
            descuentog = Convert.ToDecimal(TextDGlobal.Text)
            r = DataVentas.CurrentCell.RowIndex
            f = DataVentas.CurrentCell.ColumnIndex + 1
            cantidad = DataVentas.Item(2, r).Value
            precio = DataVentas.Item(3, r).Value
            descuento = DataVentas.Item(4, r).Value
            resta = ((cantidad * precio) * descuento) / 100
            total = (precio * cantidad) - resta
            DataVentas.Item(f, r).Value = total
            Dim totaldc As Decimal
            'Aqui vuelvo a sumar los totales del Grid
            For Each fila In DataVentas.Rows
                ttart += Convert.ToDecimal(fila.Cells("CantidadData").Value)
                totaldc += Convert.ToDecimal(fila.Cells("TotalData").Value)
            Next
            TextTArticulos.Text = Convert.ToString(ttart)
            TextSubNeto.Text = Convert.ToString(totaldc)
            totaldescuento = (total * descuentog) / 100
            totaldescuento = Format(totaldescuento, "0.00")
            TextDexcuento.Text = Convert.ToString(totaldescuento)
            grabtotal = totaldc - totaldescuento
            grabtotal = Format(grabtotal, "0.00")
            TextSubtotal.Text = Convert.ToString(grabtotal)
            TextGranT.Text = Convert.ToString(grabtotal)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Ventas", "Error al realizar un descuento en el DataGrid", Err.Number, cadena)
        End Try
    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        frmConsultaDescrip.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim subt As Decimal
            Dim subtnuevo As Decimal
            Dim totaldescuento As Decimal
            Dim importe As Decimal = Convert.ToDouble(DataVentas.CurrentRow.Cells(5).Value)
            Dim descGlobal As Decimal = Convert.ToDouble(TextDGlobal.Text)
            subt = Convert.ToDecimal(TextSubNeto.Text)
            subtnuevo = subt - importe
            TextSubNeto.Text = Convert.ToString(subtnuevo)
            If descGlobal > 0.0 Then
                totaldescuento = (subtnuevo * descGlobal) / 100
                totaldescuento = Format(totaldescuento, "0.00")
                TextDexcuento.Text = Convert.ToString(totaldescuento)
                subtnuevo = subtnuevo - totaldescuento
                TextSubtotal.Text = Convert.ToString(subtnuevo)

            Else
                TextSubtotal.Text = Convert.ToString(subtnuevo)
            End If

            Dim totalnew As Decimal
            If descGlobal > 0.0 Then
                TextGranT.Text = Convert.ToString(subtnuevo)
            Else
                totalnew = Convert.ToDecimal(TextGranT.Text)
                totalnew = totalnew - importe
                TextGranT.Text = Convert.ToString(totalnew)
            End If

            DataVentas.Rows.RemoveAt(DataVentas.CurrentRow.Index)
        Catch ex As Exception
            MsgBox("Selecciona un registro", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TextArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles TextArticulo.KeyDown
        Try
            Dim C As Integer
            Dim localizado As Boolean
            Dim total As Decimal
            Dim ttart As Integer
            Dim descuentog As Decimal
            Dim totaldescuento As Decimal
            Dim grabtotal As Decimal
            Dim extra As Decimal
            descuentog = Convert.ToDecimal(TextDGlobal.Text)
            Dim clase As New SqlConnection(conexion)
            Select Case e.KeyData
                Case Keys.Enter

                    If TextArticulo.Text = "" Then
                        MsgBox("Ingresa un código de Barras", MsgBoxStyle.Critical, "No se escribió nada")
                    Else
                        clase.Open()
                        comando = clase.CreateCommand
                        comando.CommandText = "select codigo_barras, descripcion, precioventa, existencia, descuento from Articulos where codigo_barras='" & TextArticulo.Text & "'"
                        lector = comando.ExecuteReader
                        lector.Read()
                        extra = 100 - lector(4)
                        'Empiezo con una decision para saber si la cantidad no revasa la existeencia 
                        If (lector(3) < TextCantidad.Value) Then
                            MsgBox("La cantidad que intenta vender supera la que hay en existencia", MsgBoxStyle.Critical, "Error en Existencia")
                        Else

                            '-------------Aqui empiezo una decision para calcular los productos que tengan algun descuento--------------------------

                            If lector(4) > 0 Then
                                If DataVentas.Rows.Count < 2 Then
                                    DataVentas.Rows.Add(TextArticulo.Text, lector(1), TextCantidad.Value, (lector(2) * 100) / extra, lector(4), (TextCantidad.Value * lector(2)))
                                    TextArticulo.Clear()
                                    TextCantidad.Value = 1
                                Else
                                    Encontrado = TextArticulo.Text
                                    For Each i As DataGridViewRow In DataVentas.Rows
                                        If Encontrado = DataVentas.Item(0, i.Index).Value Then
                                            localizado = True
                                            'Decision para saber si rebasa la existencia
                                            If (DataVentas.Item(2, i.Index).Value = lector(4)) Then
                                                MsgBox("La cantidad que intenta vender supera la que hay en existencia", MsgBoxStyle.Critical, "Error en Existencia")
                                            Else
                                                '--------------------------------------------------------
                                                C = DataVentas.Item(2, i.Index).Value
                                                DataVentas.Item(2, i.Index).Value = C + TextCantidad.Value
                                                DataVentas.Item(5, i.Index).Value = DataVentas.Item(2, i.Index).Value * lector(2)
                                                TextArticulo.Clear()
                                                TextCantidad.Value = 1
                                            End If 'Aqui termina la decision de la existencia
                                        End If
                                    Next
                                    If Not localizado Then
                                        DataVentas.Rows.Add(TextArticulo.Text, lector(1), TextCantidad.Value, (lector(2) * 100) / extra, lector(4), (TextCantidad.Value * lector(2)))
                                        TextArticulo.Clear()
                                        TextCantidad.Value = 1
                                    End If
                                End If
                                '--------------------------------Esto quiere decir que sin no hay ofertas haga todo con normalidad---------------------
                            Else
                                If DataVentas.Rows.Count < 2 Then
                                    DataVentas.Rows.Add(TextArticulo.Text, lector(1), TextCantidad.Value, lector(2), 0, (TextCantidad.Value * lector(2)))
                                    TextArticulo.Clear()
                                    TextCantidad.Value = 1
                                Else
                                    Encontrado = TextArticulo.Text
                                    For Each i As DataGridViewRow In DataVentas.Rows
                                        If Encontrado = DataVentas.Item(0, i.Index).Value Then
                                            localizado = True
                                            'Decision para saber si rebasa la existencia
                                            If (DataVentas.Item(2, i.Index).Value = lector(4)) Then
                                                MsgBox("La cantidad que intenta vender supera la que hay en existencia", MsgBoxStyle.Critical, "Error en Existencia")
                                            Else
                                                '--------------------------------------------------------
                                                C = DataVentas.Item(2, i.Index).Value
                                                DataVentas.Item(2, i.Index).Value = C + TextCantidad.Value
                                                DataVentas.Item(5, i.Index).Value = DataVentas.Item(2, i.Index).Value * DataVentas.Item(3, i.Index).Value
                                                TextArticulo.Clear()
                                                TextCantidad.Value = 1
                                            End If 'Aqui termina la decision de la existencia
                                        End If
                                    Next
                                    If Not localizado Then
                                        DataVentas.Rows.Add(TextArticulo.Text, lector(1), TextCantidad.Value, lector(2), 0, (TextCantidad.Value * lector(2)))
                                        TextArticulo.Clear()
                                        TextCantidad.Value = 1
                                    End If
                                End If
                            End If

                            lector.Close()
                            clase.Close()
                            'A partir de aqui se suma el total neto, descuento y totales
                            For Each fila In DataVentas.Rows
                                ttart += Convert.ToDecimal(fila.Cells("CantidadData").Value)
                                total += Convert.ToDecimal(fila.Cells("TotalData").Value)
                            Next
                            TextTArticulos.Text = Convert.ToString(ttart)
                            TextSubNeto.Text = Convert.ToString(total)
                            totaldescuento = (total * descuentog) / 100
                            totaldescuento = Format(totaldescuento, "0.00")
                            TextDexcuento.Text = Convert.ToString(totaldescuento)
                            grabtotal = total - totaldescuento
                            grabtotal = Format(grabtotal, "0.00")
                            TextSubtotal.Text = Convert.ToString(grabtotal)
                            TextGranT.Text = Convert.ToString(grabtotal)
                            '-----------------------------------------------------------------------
                        End If 'aqui se cierra todo si la cantidad esta bien
                    End If 'termina desicion de validacion del codigo 
            End Select
        Catch ex As Exception
            MsgBox("El codigo de Barras no puede ser leido o no se encuentra en la base de datos del sistema", MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub

    Private Sub TextDGlobal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextDGlobal.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ComboVendedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboVendedor.SelectedIndexChanged
        Try
        Dim clase As New SqlConnection(conexion)
        clase.Open()
        comando = clase.CreateCommand
        comando.CommandText = "select nombre from vendedores where idvendedor=" & ComboVendedor.Text
        lector = comando.ExecuteReader
        lector.Read()
        TextVendedor.Text = lector(0)
            lector.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Ventas", "Error al cargar la combo de vendedores", Err.Number, cadena)
        End Try
    End Sub

    Private Sub BtProductoV_Click(sender As Object, e As EventArgs) Handles BtProductoV.Click
            codigo = codigo + 1
            frmProductoVario.Show()
    End Sub
    Private Sub ComboVendedor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboVendedor.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Seleccione un vendedor")
        End If
    End Sub

    Private Sub btAgregar_MouseHover(sender As Object, e As EventArgs) Handles btAgregar.MouseHover
        btAgregar.Size = New Size(126, 38)
    End Sub

    Private Sub btAgregar_MouseLeave(sender As Object, e As EventArgs) Handles btAgregar.MouseLeave
        btAgregar.Size = New Size(123, 35)
    End Sub

    Private Sub BtProductoV_MouseHover(sender As Object, e As EventArgs) Handles BtProductoV.MouseHover
        BtProductoV.Size = New Size(126, 38)
    End Sub

    Private Sub BtProductoV_MouseLeave(sender As Object, e As EventArgs) Handles BtProductoV.MouseLeave
        BtProductoV.Size = New Size(123, 35)
    End Sub


    Private Sub ComboCPago_Validating_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboCPago.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Eliga una forma de Pago")
        End If
    End Sub
End Class