Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmFormasPago
    Dim cmd As SqlCommand
    Dim lector As SqlDataReader
    Dim referencia1 As String
    Dim referenciat As String
    Dim referenciav As String
    Dim pagos As Boolean
    Dim pagoscheque As Boolean
    Dim cadena As String
    Dim pagoen As String

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        aceptar = True
        Dim cobro As Decimal
        Dim monto As Decimal
        Dim resto As Decimal
        If Me.ValidateChildren = True And TextCuenta.Text <> "" And ComboSucursal.Text <> "" And TextImporte.Text <> "" And TextNCheque.Text <> "" And TextTitular.Text <> "" Then
            cobro = Convert.ToDecimal(lbTotalCobro.Text)
            monto = Convert.ToDecimal(TextImporte.Text)
            Try
                cnn = New SqlConnection(conexion)
                Using cnn
                    cnn.Open()
                    Dim transaction As SqlTransaction
                    transaction = cnn.BeginTransaction
                    cmd = New SqlCommand
                    cmd = cnn.CreateCommand
                    cmd.Connection = cnn
                    cmd.Transaction = transaction
                    Dim r As String
                    Dim Fecha As String
                    'Hago el id(Referencia del Cheque)
                    If DataCheques.Rows.Count < 2 Then
                        r = "select count(*) from Cheques"
                        cmd.CommandText = r
                        Dim N As Integer
                        N = cmd.ExecuteScalar + 1
                        ' Dim referencia As String
                        referencia1 = "C" + N.ToString
                    Else
                        r = "select count(*) from Cheques"
                        cmd.CommandText = r
                        Dim N2 As Integer
                        Dim n3 As Integer
                        n3 = DataCheques.Rows.Count - 1
                        N2 = cmd.ExecuteScalar + 1
                        n3 = N2 + n3
                        referencia1 = "C" + n3.ToString
                    End If
                    'Empiezo a guardar la venta y su detalle
                    Fecha = frmVentas.TextFecha.Value.Year & "-" & frmVentas.TextFecha.Value.Month & "-" & frmVentas.TextFecha.Value.Day
                    r = "insert into Ventas (FolioVenta, idempleado, idvendedor, Fecha, DescuentoGlobal, Subtotal) values ('" & frmVentas.TextFolio.Text & "'," & Val(frmVentas.TextidCajera.Text) & "," & Val(frmVentas.ComboVendedor.Text) & ",'" & Fecha & "'," & CDbl(frmVentas.TextDGlobal.Text) & "," & CDbl(frmVentas.TextSubtotal.Text) & ")"
                    cmd.CommandText = r
                    cmd.ExecuteNonQuery()
                    'Aqui verifico si existe otro cheque para asi almacenarlo
                    'If pagoscheque = True Then
                    If DataCheques.Rows.Count < 2 Then
                        r = "insert into Cheques (Referencia, CuentaBanco, NoCheque, idBanco, Titular) values ('" & referencia1 & "','" & TextCuenta.Text & "','" & TextNCheque.Text & "'," & Val(TextSucursal.Text) & ",'" & TextTitular.Text & "')"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                        pagoen = "CHEQUE"
                    Else
                        Dim ch1 As String
                        Dim ch2 As String
                        Dim ch3 As String
                        Dim ch4 As Integer
                        Dim ch5 As String
                        For I = 0 To DataCheques.Rows.Count - 2
                            ch1 = DataCheques.Item(0, I).Value
                            ch2 = DataCheques.Item(1, I).Value
                            ch3 = DataCheques.Item(2, I).Value
                            ch4 = Val(DataCheques.Item(3, I).Value)
                            ch5 = DataCheques.Item(4, I).Value
                            r = "insert into Cheques(Referencia, CuentaBanco, NoCheque, idBanco, Titular) values('" & ch1 & "','" & ch2 & "','" & ch3 & "'," & ch4 & ",'" & ch5 & "')"
                            cmd.CommandText = r
                            cmd.ExecuteNonQuery()
                        Next
                        r = "insert into Cheques(Referencia, CuentaBanco, NoCheque, idBanco, Titular) values('" & referencia1 & "','" & TextCuenta.Text & "','" & TextNCheque.Text & "'," & Val(TextSucursal.Text) & ",'" & TextTitular.Text & "')"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                    End If
                    'Aqui empiezo a guardar el Detalle de la venta----------------------------------------
                    Dim c2 As String
                    Dim c3 As Integer
                    Dim c4 As Decimal
                    Dim c5 As Decimal
                    Dim c6 As String
                    For I = 0 To frmVentas.DataVentas.Rows.Count - 2
                        c2 = frmVentas.DataVentas.Item(0, I).Value
                        c3 = Val(frmVentas.DataVentas.Item(2, I).Value)
                        c4 = CDbl(frmVentas.DataVentas.Item(3, I).Value)
                        c5 = CDbl(frmVentas.DataVentas.Item(4, I).Value)
                        c6 = frmVentas.DataVentas.Item(1, I).Value
                        r = "insert into DetalleVenta(FolioVenta, codigo_barras, Cantidad, Precio, DescuentoExtra, Descripcion) values('" & frmVentas.TextFolio.Text & "','" & c2 & "'," & c3 & "," & c4 & "," & c5 & ",'" & c6 & "')"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                        r = "update articulos set existencia=existencia-" & c3 & " where codigo_barras='" & c2 & "'"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                    Next
                    '-------------------------------------------------------------------------
                    'Aqui verifica si no se completa el importe de otro tipo de pago
                    'If pagos = True Then
                    If DataDetallePago.Rows.Count < 2 Then
                        ' DataGridView1.Rows.Add(frmVentas.TextFolio.Text, referencia1, TextImporte.Text)
                        r = "insert into DetallePago (FolioVenta, Referencia, Importe) values ('" & frmVentas.TextFolio.Text & "','" & referencia1 & "'," & CDbl(TextImporte.Text) & ")"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()

                    Else
                        DataDetallePago.Rows.Add(frmVentas.TextFolio.Text, referencia1, TextImporte.Text)
                        Dim d3 As String
                        Dim d4 As Decimal
                        '-----Aqui verifico si ya hay en el dataPAgos para agregar el ultimo tipo de pago
                        Dim localizado As Boolean
                        Encontrado = referencia1
                        For Each i As DataGridViewRow In DataDetallePago.Rows
                            If Encontrado = DataDetallePago.Item(1, i.Index).Value Then
                                localizado = True
                            End If
                        Next
                        If Not localizado Then
                            DataDetallePago.Rows.Add(frmVentas.TextFolio.Text, referencia1, TextImporte.Text)
                        End If
                        For I = 0 To DataDetallePago.Rows.Count - 2
                            d3 = DataDetallePago.Item(1, I).Value
                            d4 = CDbl(DataDetallePago.Item(2, I).Value)
                            r = "insert into DetallePago(FolioVenta, Referencia, Importe) values('" & frmVentas.TextFolio.Text & "','" & d3 & "'," & d4 & ")"
                            cmd.CommandText = r
                            cmd.ExecuteNonQuery()
                            ' DataDetallePago.Rows.Clear()
                        Next
                        pagos = False
                        pagoen = "Varias formas de Pago"
                    End If
                    '---------------------------Aqui empiezo a guardar las tarjetas si es que ya se pago con una
                    If DataTarjetas.Rows.Count > 0 Then
                        Dim t1 As String
                        Dim t2 As String
                        'Dim t3 As String
                        Dim t4 As String
                        For I = 0 To DataTarjetas.Rows.Count - 2
                            t1 = DataTarjetas.Item(0, I).Value
                            t2 = DataTarjetas.Item(1, I).Value
                            't3 = DataTarjetas.Item(2, I).Value
                            t4 = DataTarjetas.Item(2, I).Value
                            r = "insert into Tarjeta(Referencia, NoTarjeta, Autorizacion) values('" & t1 & "','" & t2 & "','" & t4 & "')"
                            cmd.CommandText = r
                            cmd.ExecuteNonQuery()
                        Next
                        'pagoen = "Varias formas de Pago 24"
                    End If
                    '---------------------------Aqui empiezo a guardar los Vales si es que ya se pago con una
                    If DataVale.Rows.Count > 0 Then
                        Dim t1 As String
                        Dim t2 As Decimal
                        'Dim t3 As String

                        For I = 0 To DataVale.Rows.Count - 2
                            t1 = DataVale.Item(0, I).Value
                            t2 = CDbl(DataVale.Item(1, I).Value)
                           
                            r = "insert into Vales(Referencia, MontoVale) values('" & t1 & "'," & t2 & ")"
                            cmd.CommandText = r
                            cmd.ExecuteNonQuery()
                        Next
                        'pagoen = "Varias formas de Pago 24"
                    End If
                    Try
                        '------------------------------------Transaccion----------------------------------------------
                        'Aqui verifico si el monto cubre el total de la venta
                        If monto >= cobro Then
                            If MessageBox.Show("¿Desea Guardar la Venta?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                transaction.Commit()
                                MsgBox("El la venta se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                                resto = monto - cobro
                                lbTotalCobro.Text = Convert.ToString(resto)
                                '----------------------------------Aqui se imprime el ticket-----------------------------------
                                Dim f1 As String
                                f1 = frmVentas.TextFolio.Text
                                Dim clase As New SqlConnection(conexion)
                                clase.Open()
                                cmd = clase.CreateCommand
                                cmd.CommandText = "TICKETVENTA"
                                cmd.CommandType = CommandType.StoredProcedure
                                Dim adaptador As New SqlDataAdapter()
                                adaptador.SelectCommand = New SqlCommand
                                adaptador.SelectCommand.Connection = clase
                                adaptador.SelectCommand.CommandText = "TICKETVENTA"
                                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                                Dim param1 = New SqlParameter("@Venta1", SqlDbType.Text)
                                param1.Direction = ParameterDirection.Input
                                param1.Value = (f1)
                                adaptador.SelectCommand.Parameters.Add(param1)
                                Dim dataset As New DataSet
                                adaptador.Fill(dataset)
                                dataset.DataSetName = "DataSet1"
                                Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                                datasource.Name = "DataSet1"
                                datasource.Value = dataset.Tables(0)
                                Dim p1 As New ReportParameter("Venta1", f1)
                                Dim p2 As New ReportParameter("CantidadLetra", ConvertirNumero(frmVentas.TextGranT.Text))
                                Dim p3 As New ReportParameter("Subtotal", CDbl(frmVentas.TextSubNeto.Text))
                                Dim p4 As New ReportParameter("DescGlobal", CDbl(frmVentas.TextDexcuento.Text))
                                Dim p5 As New ReportParameter("Total", CDbl(frmVentas.TextGranT.Text))
                                Dim p6 As New ReportParameter("Pago", pagoen)
                                frmTicket.ReportViewer1.LocalReport.DataSources.Clear()
                                frmTicket.ReportViewer1.LocalReport.DataSources.Add(datasource)
                                frmTicket.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\Ticket.rdlc"
                                frmTicket.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3, p4, p5, p6})
                                frmTicket.ReportViewer1.RefreshReport()
                                'End If
                                frmTicket.Show()
                                clase.Close()
                                '------------------------------------------------------------------------------------------------

                                'Limpio mi formulario de ventas
                                frmVentas.TextFolio.Text = ""
                                frmVentas.ComboCPago.Text = ""
                                frmVentas.DataVentas.Rows.Clear()
                                frmVentas.TextDGlobal.Text = "0.0"
                                frmVentas.TextTArticulos.Text = ""
                                limpiarCampos1(frmVentas.GrTotales)
                                limpiarCampos1(PanelCheque)
                                frmVentas.Enabled = True
                                deshaCampos(frmVentas.GrTotales)
                                frmVentas.ComboCPago.Text = ""
                                frmVentas.ComboCPago.Enabled = False
                                frmVentas.TextArticulo.Enabled = False
                                frmVentas.TextCantidad.Enabled = False
                                frmVentas.TextDGlobal.Enabled = False
                                codigo = 0
                                Me.Close()
                            Else
                                transaction.Rollback()
                                MsgBox("Venta Cancelada", MsgBoxStyle.Critical)
                                'Limpio mi formulario de ventas
                                ' textMonto.Clear()
                                frmVentas.TextFolio.Text = ""
                                frmVentas.ComboCPago.Text = ""
                                frmVentas.DataVentas.Rows.Clear()
                                frmVentas.TextDGlobal.Text = "0.0"
                                frmVentas.TextTArticulos.Text = ""
                                limpiarCampos1(frmVentas.GrTotales)
                                frmVentas.Enabled = True
                                deshaCampos(frmVentas.GrTotales)
                                frmVentas.ComboCPago.Text = ""
                                frmVentas.ComboCPago.Enabled = False
                                frmVentas.TextArticulo.Enabled = False
                                frmVentas.TextCantidad.Enabled = False
                                frmVentas.TextDGlobal.Enabled = False
                                codigo = 0
                                Me.Close()
                            End If
                        Else
                            If aceptar = True Then
                                If MessageBox.Show("El monto ingresado no cubre totalmente el importe de la venta, ¿desea cubrir el monto con otro tipo de pago?", "Saldo Insuficiente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                                    resto = cobro - monto
                                    ' DataDetallePago.Rows.Add(frmVentas.TextFolio.Text, referencia1, TextImporte.Text)
                                    DataCheques.Rows.Add(referencia1, TextCuenta.Text, TextNCheque.Text, TextSucursal.Text, TextTitular.Text)
                                    limpiarCampos1(PanelCheque)
                                    TextImporte.Text = resto
                                    lbTotalCobro.Text = resto
                                    TextImporteT.Text = resto
                                    lbTotalCobroT.Text = resto
                                    TextImportV.Text = resto
                                    lbcobroV.Text = resto
                                    PtnTarjeta.Visible = True
                                    ptnVale.Visible = True
                                    'Me.Refresh()
                                End If
                            End If
                        End If
                        'Aqui acaba la desiion de el monto de la venta
                    Catch ex As Exception
                        MsgBox("Commit Exception type: {0} no se pudo insertar por error")
                        Try
                            transaction.Rollback()
                    Catch ex1 As Exception
                            MsgBox("Error RollBack ")
                        End Try
                    End Try
                End Using
                cnn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message + ex.StackTrace)
            End Try
            'Me.Refresh()
        Else
            MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        ErrorProvider1.Clear()
    End Sub

    Private Sub frmFormasPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.ToolTip1.Active = True
            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
            Me.ToolTip1.ToolTipTitle = "Ayuda"
            Me.ToolTip1.SetToolTip(Me.btAceptar, "Guarda la venta y los datos del Cheque")
            Me.ToolTip1.SetToolTip(Me.btCancelar, "Cancela la venta y los datos del Cheque")
            Me.ToolTip1.SetToolTip(Me.btAceptarT, "Guarda la venta y los datos de la Tarjeta")
            Me.ToolTip1.SetToolTip(Me.btCancelarT, "Cancela la venta y los datos de la Tarjeta")
            Me.ToolTip1.AutoPopDelay = 5000
            Dim clase As New SqlConnection(conexion)
            clase.Open()
            cmd = clase.CreateCommand
            cmd.CommandText = "select Banco from Bancos"
            lector = cmd.ExecuteReader
            While lector.Read()
                ComboSucursal.Items.Add(lector(0))
            End While
            lector.Close()
            clase.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Formas de Pago", "Error al iniciar el formulario", Err.Number, cadena)
        End Try
    End Sub

    Private Sub ComboSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboSucursal.SelectedIndexChanged
        Try
            Dim clase As New SqlConnection(conexion)
            clase.Open()
            cmd = clase.CreateCommand
            Dim R As String
            R = "Select * from Bancos where Banco=" & "'" & ComboSucursal.Text & "'"
            cmd.CommandText = R
            lector = cmd.ExecuteReader()
            lector.Read()
            TextSucursal.Text = lector(0)
            lector.Close()
            clase.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Formas de Pago", "Error al cargar la combo de los bancos", Err.Number, cadena)
        End Try
    End Sub

    Private Sub btAceptarT_Click(sender As Object, e As EventArgs) Handles btAceptarT.Click
        aceptar = True
        Dim cobro As Decimal
        Dim monto As Decimal
        Dim resto As Decimal
        If Me.ValidateChildren = True And TextNoTarjeta.Text <> "" And TextAutorizar.Text <> "" And TextImporteT.Text <> "" Then
            cobro = Convert.ToDecimal(lbTotalCobroT.Text)
            monto = Convert.ToDecimal(TextImporteT.Text)
            Try
                cnn = New SqlConnection(conexion)
                Using cnn
                    cnn.Open()
                    Dim transaction As SqlTransaction
                    transaction = cnn.BeginTransaction
                    cmd = New SqlCommand
                    cmd = cnn.CreateCommand
                    cmd.Connection = cnn
                    cmd.Transaction = transaction
                    Dim r As String
                    Dim Fecha As String
                    'Hago el id(Referencia de la tarjeta)
                    If DataTarjetas.Rows.Count < 2 Then
                        r = "select count(*) from Tarjeta"
                        cmd.CommandText = r
                        Dim N As Integer
                        N = cmd.ExecuteScalar + 1
                        ' Dim referencia As String
                        referenciat = "T" + N.ToString

                    Else
                        r = "select count(*) from Tarjeta"
                        cmd.CommandText = r
                        Dim N2 As Integer
                        Dim n3 As Integer
                        n3 = DataTarjetas.Rows.Count - 1
                        N2 = cmd.ExecuteScalar + 1
                        n3 = N2 + n3
                        referenciat = "T" + n3.ToString
                    End If
                    'Empiezo a guardar la venta y su detalle
                    Fecha = frmVentas.TextFecha.Value.Year & "-" & frmVentas.TextFecha.Value.Month & "-" & frmVentas.TextFecha.Value.Day
                    r = "insert into Ventas (FolioVenta, idempleado, idvendedor, Fecha, DescuentoGlobal, Subtotal) values ('" & frmVentas.TextFolio.Text & "'," & Val(frmVentas.TextidCajera.Text) & "," & Val(frmVentas.ComboVendedor.Text) & ",'" & Fecha & "'," & CDbl(frmVentas.TextDGlobal.Text) & "," & CDbl(frmVentas.TextSubtotal.Text) & ")"
                    cmd.CommandText = r
                    cmd.ExecuteNonQuery()
                    'Aqui verifico si existe otra tarjeta para asi almacenarlo
                    If DataTarjetas.Rows.Count < 2 Then
                        r = "insert into Tarjeta (Referencia, NoTarjeta, Autorizacion) values ('" & referenciat & "','" & TextNoTarjeta.Text & "','" & TextAutorizar.Text & "')"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                        pagoen = "TARJETA"
                    Else
                        Dim t1 As String
                        'Dim t2 As String
                        Dim t3 As String
                        Dim t4 As String
                        For I = 0 To DataTarjetas.Rows.Count - 2
                            t1 = DataTarjetas.Item(0, I).Value
                            't2 = DataTarjetas.Item(1, I).Value
                            t3 = DataTarjetas.Item(1, I).Value
                            t4 = DataTarjetas.Item(2, I).Value
                            r = "insert into Tarjeta(Referencia, NoTarjeta, Autorizacion) values('" & t1 & "','" & t3 & "','" & t4 & "')"
                            cmd.CommandText = r
                            cmd.ExecuteNonQuery()
                        Next
                        r = "insert into Tarjeta (Referencia, NoTarjeta, Autorizacion) values ('" & referenciat & "','" & TextNoTarjeta.Text & "','" & TextAutorizar.Text & "')"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                    End If
                    'Aqui empiezo a guardar el Detalle de la venta----------------------------------------
                    Dim c2 As String
                    Dim c3 As Integer
                    Dim c4 As Decimal
                    Dim c5 As Decimal
                    Dim c6 As String
                    For I = 0 To frmVentas.DataVentas.Rows.Count - 2
                        c2 = frmVentas.DataVentas.Item(0, I).Value
                        c3 = Val(frmVentas.DataVentas.Item(2, I).Value)
                        c4 = CDbl(frmVentas.DataVentas.Item(3, I).Value)
                        c5 = CDbl(frmVentas.DataVentas.Item(4, I).Value)
                        c6 = frmVentas.DataVentas.Item(1, I).Value
                        r = "insert into DetalleVenta(FolioVenta, codigo_barras, Cantidad, Precio, DescuentoExtra, descripcion) values('" & frmVentas.TextFolio.Text & "','" & c2 & "'," & c3 & "," & c4 & "," & c5 & ",'" & c6 & "')"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                        r = "update articulos set existencia=existencia-" & c3 & " where codigo_barras='" & c2 & "'"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                    Next
                    '-------------------------------------------------------------------------
                    'Aqui verifica si no se completa el importe de otro tipo de pago
                    If DataDetallePago.Rows.Count < 2 Then
                        r = "insert into DetallePago (FolioVenta, Referencia, Importe) values ('" & frmVentas.TextFolio.Text & "','" & referenciat & "'," & CDbl(TextImporteT.Text) & ")"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                    Else
                        'DataDetallePago.Rows.Add(frmVentas.TextFolio.Text, referenciat, TextImporteT.Text)
                        Dim d3 As String
                        Dim d4 As Decimal
                        '-----Aqui verifico si ya hay en el dataPAgos para agregar el ultimo tipo de pago
                        Dim localizado As Boolean
                        Encontrado = referenciat
                        For Each i As DataGridViewRow In DataDetallePago.Rows
                            If Encontrado = DataDetallePago.Item(1, i.Index).Value Then
                                localizado = True
                            End If
                        Next
                        If Not localizado Then
                            'DataDetallePago.Rows.Add(frmVentas.TextFolio.Text, referenciat, TextImporteT.Text)
                        End If

                        For I = 0 To DataDetallePago.Rows.Count - 2
                            d3 = DataDetallePago.Item(1, I).Value
                            d4 = CDbl(DataDetallePago.Item(2, I).Value)
                            r = "insert into DetallePago(FolioVenta, Referencia, Importe) values('" & frmVentas.TextFolio.Text & "','" & d3 & "'," & d4 & ")"
                            cmd.CommandText = r
                            cmd.ExecuteNonQuery()
                        Next
                        r = "insert into DetallePago(FolioVenta, Referencia, Importe) values('" & frmVentas.TextFolio.Text & "','" & referenciat & "'," & CDbl(TextImporteT.Text) & ")"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                        pagos = False
                        pagoen = "Varias formas de Pago"
                    End If
                    '-----------------Empiezo a guardar los cheques en caso de que ya hallan cubierto una parte----------
                    If DataCheques.Rows.Count > 0 Then
                        Dim ch1 As String
                        Dim ch2 As String
                        Dim ch3 As String
                        Dim ch4 As Integer
                        Dim ch5 As String
                        For I = 0 To DataCheques.Rows.Count - 2
                            ch1 = DataCheques.Item(0, I).Value
                            ch2 = DataCheques.Item(1, I).Value
                            ch3 = DataCheques.Item(2, I).Value
                            ch4 = Val(DataCheques.Item(3, I).Value)
                            ch5 = DataCheques.Item(4, I).Value
                            r = "insert into Cheques(Referencia, CuentaBanco, NoCheque, idBanco, Titular) values('" & ch1 & "','" & ch2 & "','" & ch3 & "'," & ch4 & ",'" & ch5 & "')"
                            cmd.CommandText = r
                            cmd.ExecuteNonQuery()
                            ' DataCheques.Rows.Clear()
                            'pagoen = "Varias Formas de Pago"
                        Next
                    End If
                    '---------------------------Aqui empiezo a guardar los Vales si es que ya se pago con una
                    If DataVale.Rows.Count > 0 Then
                        Dim t1 As String
                        Dim t2 As Decimal
                        'Dim t3 As String

                        For I = 0 To DataVale.Rows.Count - 2
                            t1 = DataVale.Item(0, I).Value
                            t2 = CDbl(DataVale.Item(1, I).Value)

                            r = "insert into Vales(Referencia, MontoVale) values('" & t1 & "'," & t2 & ")"
                            cmd.CommandText = r
                            cmd.ExecuteNonQuery()
                        Next
                        'pagoen = "Varias formas de Pago"
                    End If
                    Try
                        '------------------------------------Transaccion----------------------------------------------
                        'Aqui verifico si el monto cubre el total de la venta
                        If monto >= cobro Then
                            If MessageBox.Show("¿Desea Guardar la Venta?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

                                transaction.Commit()
                                MsgBox("El venta se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                                resto = monto - cobro
                                lbTotalCobro.Text = Convert.ToString(resto)
                                '----------------------------------Aqui se imprime el ticket-----------------------------------
                                Dim f1 As String
                                f1 = frmVentas.TextFolio.Text
                                Dim clase As New SqlConnection(conexion)
                                clase.Open()
                                cmd = clase.CreateCommand
                                cmd.CommandText = "TICKETVENTA"
                                cmd.CommandType = CommandType.StoredProcedure
                                Dim adaptador As New SqlDataAdapter()
                                adaptador.SelectCommand = New SqlCommand
                                adaptador.SelectCommand.Connection = clase
                                adaptador.SelectCommand.CommandText = "TICKETVENTA"
                                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                                Dim param1 = New SqlParameter("@Venta1", SqlDbType.Text)
                                param1.Direction = ParameterDirection.Input
                                param1.Value = (f1)
                                adaptador.SelectCommand.Parameters.Add(param1)
                                Dim dataset As New DataSet
                                adaptador.Fill(dataset)
                                dataset.DataSetName = "DataSet1"
                                Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                                datasource.Name = "DataSet1"
                                datasource.Value = dataset.Tables(0)
                                Dim p1 As New ReportParameter("Venta1", f1)
                                Dim p2 As New ReportParameter("CantidadLetra", ConvertirNumero(frmVentas.TextGranT.Text))
                                Dim p3 As New ReportParameter("Subtotal", CDbl(frmVentas.TextSubNeto.Text))
                                Dim p4 As New ReportParameter("DescGlobal", CDbl(frmVentas.TextDexcuento.Text))
                                Dim p5 As New ReportParameter("Total", CDbl(frmVentas.TextGranT.Text))
                                Dim p6 As New ReportParameter("Pago", pagoen)
                                frmTicket.ReportViewer1.LocalReport.DataSources.Clear()
                                frmTicket.ReportViewer1.LocalReport.DataSources.Add(datasource)
                                frmTicket.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\Ticket.rdlc"
                                frmTicket.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3, p4, p5, p6})
                                frmTicket.ReportViewer1.RefreshReport()
                                'End If
                                frmTicket.Show()
                                clase.Close()
                                '------------------------------------------------------------------------------------------------

                                'Limpio mi formulario de ventas
                                frmVentas.TextFolio.Text = ""
                                frmVentas.ComboCPago.Text = ""
                                frmVentas.DataVentas.Rows.Clear()
                                frmVentas.TextDGlobal.Text = "0.0"
                                frmVentas.TextTArticulos.Text = ""
                                'limpiarCampos1(frmVentas.GrTotales)
                                deshaCampos(frmVentas.GrTotales)
                                frmVentas.TextArticulo.Enabled = False
                                frmVentas.TextDGlobal.Enabled = False
                                frmVentas.ComboCPago.Enabled = False
                                frmVentas.TextCantidad.Enabled = False
                                limpiarCampos1(PanelTarjeta)
                                frmVentas.Enabled = True
                                frmFormaPago.Close()
                                Me.Close()
                            Else
                                transaction.Rollback()
                                MsgBox("Venta Cancelada", MsgBoxStyle.Critical)
                                'Limpio mi formulario de ventas
                                frmVentas.TextFolio.Text = ""
                                frmVentas.ComboCPago.Text = ""
                                frmVentas.DataVentas.Rows.Clear()
                                frmVentas.TextDGlobal.Text = "0.0"
                                frmVentas.TextTArticulos.Text = ""
                                'limpiarCampos1(frmVentas.GrTotales)
                                deshaCampos(frmVentas.GrTotales)
                                frmVentas.TextCantidad.Enabled = False
                                frmVentas.TextArticulo.Enabled = False
                                frmVentas.TextDGlobal.Enabled = False
                                frmVentas.ComboCPago.Enabled = False
                                frmVentas.Enabled = True
                                frmFormaPago.Close()
                                Me.Close()
                            End If
                        Else
                            'Si el saldo no cumbre el monto se abre un mensaje de "si desea pagar con otra forma de pago"
                            If aceptar = True Then
                                If MessageBox.Show("El monto ingresado no cubre totalmente el importe de la venta, ¿desea cubrir el monto con otro tipo de pago?", "Saldo Insuficiente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                                    resto = cobro - monto
                                    DataTarjetas.Rows.Add(referenciat, TextNoTarjeta.Text, TextAutorizar.Text)
                                    DataDetallePago.Rows.Add(frmVentas.TextFolio.Text, referenciat, TextImporteT.Text)
                                    limpiarCampos1(PanelTarjeta)
                                    TextImporteT.Text = resto
                                    lbTotalCobroT.Text = resto
                                    TextImporte.Text = resto
                                    lbTotalCobro.Text = resto
                                    TextImportV.Text = resto
                                    lbcobroV.Text = resto
                                    ptnCheque.Visible = True
                                    ptnVale.Visible = True
                                    ErrorProvider1.Clear()
                                    Me.Refresh()
                                End If
                            End If
                        End If
                        'Aqui acaba la desiion de el monto de la venta
                    Catch ex As Exception
                        MsgBox("Commit Exception type: {0} no se pudo insertar por error")
                        Try
                            transaction.Rollback()
                    Catch ex1 As Exception
                            MsgBox("Error RollBack ")
                        End Try
                    End Try
                End Using
                cnn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message + ex.StackTrace)
            End Try
            Me.Refresh()
        Else
            MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Refresh()
        ErrorProvider1.Clear()
    End Sub

    Private Sub TextNCheque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNCheque.KeyPress
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

    Private Sub TextTitular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextTitular.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextImporte.KeyPress
        NumerosyDecimal(TextImporte, e)
    End Sub

    Private Sub TextNoTarjeta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNoTarjeta.KeyPress
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

    Private Sub TextNoId_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub TextImporteT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextImporteT.KeyPress
        NumerosyDecimal(TextImporteT, e)
    End Sub

    Private Sub TextCuenta_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextCuenta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca la Cuenta de Cheque")
        End If
    End Sub

    Private Sub ComboSucursal_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboSucursal.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Seleccione un Banco")
        End If
    End Sub

    Private Sub TextNCheque_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextNCheque.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca el No del Cheque")
        End If
    End Sub

    Private Sub TextTitular_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextTitular.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca el nombre del Titular")
        End If
    End Sub

    Private Sub TextImporte_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextImporte.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca el importe a pagar")
        End If
    End Sub

    Private Sub TextNoTarjeta_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextNoTarjeta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider2.SetError(sender, "")
        Else
            Me.ErrorProvider2.SetError(sender, "Introduzca el número de tarjeta")
        End If
    End Sub

    Private Sub TextAutorizar_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextAutorizar.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider2.SetError(sender, "")
        Else
            Me.ErrorProvider2.SetError(sender, "Introduzca la Autorización")
        End If
    End Sub

    Private Sub TextNoId_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider2.SetError(sender, "")
        Else
            Me.ErrorProvider2.SetError(sender, "Introduzca el No. Id")
        End If
    End Sub

    Private Sub TextImporteT_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextImporteT.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider2.SetError(sender, "")
        Else
            Me.ErrorProvider2.SetError(sender, "Introduzca el importe a pagar")
        End If
    End Sub

    Private Sub btCancelarT_Click(sender As Object, e As EventArgs) Handles btCancelarT.Click
        MsgBox("Venta Cancelada", MsgBoxStyle.Critical)
        'Limpio mi formulario de ventas
        'textMonto.Clear()
        frmVentas.TextFolio.Text = ""
        frmVentas.ComboCPago.Text = ""
        frmVentas.DataVentas.Rows.Clear()
        frmVentas.TextDGlobal.Text = "0.0"
        frmVentas.TextTArticulos.Text = ""
        limpiarCampos1(frmVentas.GrTotales)
        frmVentas.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub btAceptar_MouseHover(sender As Object, e As EventArgs) Handles btAceptar.MouseHover
        btAceptar.Size = New Size(126, 38)
    End Sub

    Private Sub btAceptar_MouseLeave(sender As Object, e As EventArgs) Handles btAceptar.MouseLeave
        btAceptar.Size = New Size(123, 35)
    End Sub

    Private Sub btCancelar_MouseHover(sender As Object, e As EventArgs) Handles btCancelar.MouseHover
        btCancelar.Size = New Size(126, 38)
    End Sub

    Private Sub btCancelar_MouseLeave(sender As Object, e As EventArgs) Handles btCancelar.MouseLeave
        btCancelar.Size = New Size(123, 35)
    End Sub

    Private Sub btAceptarT_MouseHover(sender As Object, e As EventArgs) Handles btAceptarT.MouseHover
        btAceptarT.Size = New Size(126, 38)
    End Sub

    Private Sub btAceptarT_MouseLeave(sender As Object, e As EventArgs) Handles btAceptarT.MouseLeave
        btAceptarT.Size = New Size(123, 35)
    End Sub

    Private Sub btCancelarT_MouseHover(sender As Object, e As EventArgs) Handles btCancelarT.MouseHover
        btCancelarT.Size = New Size(126, 38)
    End Sub

    Private Sub btCancelarT_MouseLeave(sender As Object, e As EventArgs) Handles btCancelarT.MouseLeave
        btCancelarT.Size = New Size(123, 35)
    End Sub

    Private Sub frmFormasPago_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmVentas.TextFolio.Text = ""
        frmVentas.ComboCPago.Text = ""
        frmVentas.DataVentas.Rows.Clear()
        frmVentas.TextDGlobal.Text = "0.0"
        frmVentas.TextTArticulos.Text = ""
        limpiarCampos1(frmVentas.GrTotales)
        frmVentas.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        MsgBox("Venta Cancelada", MsgBoxStyle.Critical)
        'Limpio mi formulario de ventas
        'textMonto.Clear()
        frmVentas.TextFolio.Text = ""
        frmVentas.ComboCPago.Text = ""
        frmVentas.DataVentas.Rows.Clear()
        frmVentas.TextDGlobal.Text = "0.0"
        frmVentas.TextTArticulos.Text = ""
        limpiarCampos1(frmVentas.GrTotales)
        frmVentas.Enabled = True
        Me.Dispose()
    End Sub


    Private Sub btAceptarV_Click(sender As Object, e As EventArgs) Handles btAceptarV.Click
        aceptar = True
        Dim cobro As Decimal
        Dim monto As Decimal
        Dim resto As Decimal
        If Me.ValidateChildren = True And combovale.Text <> "" And TextImportV.Text <> "" Then
            cobro = Convert.ToDecimal(lbcobroV.Text)
            monto = Convert.ToDecimal(combovale.Text)
            Try
                cnn = New SqlConnection(conexion)
                Using cnn
                    cnn.Open()
                    Dim transaction As SqlTransaction
                    transaction = cnn.BeginTransaction
                    cmd = New SqlCommand
                    cmd = cnn.CreateCommand
                    cmd.Connection = cnn
                    cmd.Transaction = transaction
                    Dim r As String
                    Dim Fecha As String
                    'Hago el id(Referencia de la tarjeta)
                    If DataVale.Rows.Count < 2 Then
                        r = "select count(*) from Vales"
                        cmd.CommandText = r
                        Dim N As Integer
                        N = cmd.ExecuteScalar + 1
                        ' Dim referencia As String
                        referenciav = "V" + N.ToString

                    Else
                        r = "select count(*) from Vales"
                        cmd.CommandText = r
                        Dim N2 As Integer
                        Dim n3 As Integer
                        n3 = DataVale.Rows.Count - 1
                        N2 = cmd.ExecuteScalar + 1
                        n3 = N2 + n3
                        referenciav = "V" + n3.ToString
                    End If
                    'Empiezo a guardar la venta y su detalle
                    Fecha = frmVentas.TextFecha.Value.Year & "-" & frmVentas.TextFecha.Value.Month & "-" & frmVentas.TextFecha.Value.Day
                    r = "insert into Ventas (FolioVenta, idempleado, idvendedor, Fecha, DescuentoGlobal, Subtotal) values ('" & frmVentas.TextFolio.Text & "'," & Val(frmVentas.TextidCajera.Text) & "," & Val(frmVentas.ComboVendedor.Text) & ",'" & Fecha & "'," & CDbl(frmVentas.TextDGlobal.Text) & "," & CDbl(frmVentas.TextSubtotal.Text) & ")"
                    cmd.CommandText = r
                    cmd.ExecuteNonQuery()
                    'Aqui verifico si existe otra tarjeta para asi almacenarlo
                    If DataVale.Rows.Count < 2 Then
                        r = "insert into Vales (Referencia, MontoVale) values ('" & referenciav & "'," & CDbl(combovale.Text) & ")"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                        pagoen = "VALE"
                    Else
                        Dim t1 As String
                        'Dim t2 As String
                        Dim t3 As String
                        For I = 0 To DataVale.Rows.Count - 2
                            t1 = DataVale.Item(0, I).Value
                            't2 = DataTarjetas.Item(1, I).Value
                            t3 = CDbl(DataVale.Item(1, I).Value)

                            r = "insert into Vales(Referencia, MontoVale) values('" & t1 & "'," & t3 & ")"
                            cmd.CommandText = r
                            cmd.ExecuteNonQuery()
                        Next
                        r = "insert into Vales (Referencia, MontoVale) values ('" & referenciav & "'," & CDbl(combovale.Text) & ")"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                    End If
                    'Aqui empiezo a guardar el Detalle de la venta----------------------------------------
                    Dim c2 As String
                    Dim c3 As Integer
                    Dim c4 As Decimal
                    Dim c5 As Decimal
                    Dim c6 As String
                    For I = 0 To frmVentas.DataVentas.Rows.Count - 2
                        c2 = frmVentas.DataVentas.Item(0, I).Value
                        c3 = Val(frmVentas.DataVentas.Item(2, I).Value)
                        c4 = CDbl(frmVentas.DataVentas.Item(3, I).Value)
                        c5 = CDbl(frmVentas.DataVentas.Item(4, I).Value)
                        c6 = frmVentas.DataVentas.Item(1, I).Value
                        r = "insert into DetalleVenta(FolioVenta, codigo_barras, Cantidad, Precio, DescuentoExtra, descripcion) values('" & frmVentas.TextFolio.Text & "','" & c2 & "'," & c3 & "," & c4 & "," & c5 & ",'" & c6 & "')"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                        r = "update articulos set existencia=existencia-" & c3 & " where codigo_barras='" & c2 & "'"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                    Next
                    '-------------------------------------------------------------------------
                    'Aqui verifica si no se completa el importe de otro tipo de pago
                    If DataDetallePago.Rows.Count < 2 Then
                        r = "insert into DetallePago (FolioVenta, Referencia, Importe) values ('" & frmVentas.TextFolio.Text & "','" & referenciav & "'," & CDbl(combovale.Text) & ")"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                    Else
                        'DataDetallePago.Rows.Add(frmVentas.TextFolio.Text, referenciav, combovale.Text)

                        Dim d3 As String
                        Dim d4 As Decimal
                        '-----Aqui verifico si ya hay en el dataPAgos para agregar el ultimo tipo de pago
                        Dim localizado As Boolean
                        Encontrado = referenciat
                        For Each i As DataGridViewRow In DataDetallePago.Rows
                            If Encontrado = DataDetallePago.Item(1, i.Index).Value Then
                                localizado = True
                            End If
                        Next
                        If Not localizado Then
                            ' DataDetallePago.Rows.Add(frmVentas.TextFolio.Text, referenciat, combovale.Text)
                        End If

                        For I = 0 To DataDetallePago.Rows.Count - 2
                            d3 = DataDetallePago.Item(1, I).Value
                            d4 = CDbl(DataDetallePago.Item(2, I).Value)
                            r = "insert into DetallePago(FolioVenta, Referencia, Importe) values('" & frmVentas.TextFolio.Text & "','" & d3 & "'," & d4 & ")"
                            cmd.CommandText = r
                            cmd.ExecuteNonQuery()
                        Next
                        r = "insert into DetallePago(FolioVenta, Referencia, Importe) values('" & frmVentas.TextFolio.Text & "','" & referenciav & "'," & CDbl(TextImportV.Text) & ")"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                        pagos = False
                        pagoen = "Varias formas de Pago"
                    End If
                    '-----------------Empiezo a guardar los cheques en caso de que ya hallan cubierto una parte----------
                    If DataCheques.Rows.Count > 0 Then
                        Dim ch1 As String
                        Dim ch2 As String
                        Dim ch3 As String
                        Dim ch4 As Integer
                        Dim ch5 As String
                        For I = 0 To DataCheques.Rows.Count - 2
                            ch1 = DataCheques.Item(0, I).Value
                            ch2 = DataCheques.Item(1, I).Value
                            ch3 = DataCheques.Item(2, I).Value
                            ch4 = Val(DataCheques.Item(3, I).Value)
                            ch5 = DataCheques.Item(4, I).Value
                            r = "insert into Cheques(Referencia, CuentaBanco, NoCheque, idBanco, Titular) values('" & ch1 & "','" & ch2 & "','" & ch3 & "'," & ch4 & ",'" & ch5 & "')"
                            cmd.CommandText = r
                            cmd.ExecuteNonQuery()
                            ' DataCheques.Rows.Clear()

                        Next
                    End If
                    '-----------------Empiezo a guardar las tarjetas en caso de que ya hallan cubierto una parte----------
                    If DataTarjetas.Rows.Count > 0 Then
                        Dim t1 As String
                        Dim t2 As String
                        'Dim t3 As String
                        Dim t4 As String
                        For I = 0 To DataTarjetas.Rows.Count - 2
                            t1 = DataTarjetas.Item(0, I).Value
                            t2 = DataTarjetas.Item(1, I).Value
                            't3 = DataTarjetas.Item(2, I).Value
                            t4 = DataTarjetas.Item(2, I).Value
                            r = "insert into Tarjeta(Referencia, NoTarjeta, Autorizacion) values('" & t1 & "','" & t2 & "','" & t4 & "')"
                            cmd.CommandText = r
                            cmd.ExecuteNonQuery()
                        Next
                        'pagoen = "Varias formas de Pago 24"
                    End If
                    Try
                        '------------------------------------Transaccion----------------------------------------------
                        'Aqui verifico si el monto cubre el total de la venta
                        If monto >= cobro Then
                            If MessageBox.Show("¿Desea Guardar la Venta?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

                                transaction.Commit()
                                MsgBox("El venta se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                                resto = monto - cobro
                                lbTotalCobro.Text = Convert.ToString(resto)
                                '----------------------------------Aqui se imprime el ticket-----------------------------------
                                Dim f1 As String
                                f1 = frmVentas.TextFolio.Text
                                Dim clase As New SqlConnection(conexion)
                                clase.Open()
                                cmd = clase.CreateCommand
                                cmd.CommandText = "TICKETVENTA"
                                cmd.CommandType = CommandType.StoredProcedure
                                Dim adaptador As New SqlDataAdapter()
                                adaptador.SelectCommand = New SqlCommand
                                adaptador.SelectCommand.Connection = clase
                                adaptador.SelectCommand.CommandText = "TICKETVENTA"
                                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                                Dim param1 = New SqlParameter("@Venta1", SqlDbType.Text)
                                param1.Direction = ParameterDirection.Input
                                param1.Value = (f1)
                                adaptador.SelectCommand.Parameters.Add(param1)
                                Dim dataset As New DataSet
                                adaptador.Fill(dataset)
                                dataset.DataSetName = "DataSet1"
                                Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                                datasource.Name = "DataSet1"
                                datasource.Value = dataset.Tables(0)
                                Dim p1 As New ReportParameter("Venta1", f1)
                                Dim p2 As New ReportParameter("CantidadLetra", ConvertirNumero(frmVentas.TextGranT.Text))
                                Dim p3 As New ReportParameter("Subtotal", CDbl(frmVentas.TextSubNeto.Text))
                                Dim p4 As New ReportParameter("DescGlobal", CDbl(frmVentas.TextDexcuento.Text))
                                Dim p5 As New ReportParameter("Total", CDbl(frmVentas.TextGranT.Text))
                                Dim p6 As New ReportParameter("Pago", pagoen)
                                frmTicket.ReportViewer1.LocalReport.DataSources.Clear()
                                frmTicket.ReportViewer1.LocalReport.DataSources.Add(datasource)
                                frmTicket.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\Ticket.rdlc"
                                frmTicket.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3, p4, p5, p6})
                                frmTicket.ReportViewer1.RefreshReport()
                                'End If
                                frmTicket.Show()
                                clase.Close()
                                '------------------------------------------------------------------------------------------------

                                'Limpio mi formulario de ventas
                                frmVentas.TextFolio.Text = ""
                                frmVentas.ComboCPago.Text = ""
                                frmVentas.DataVentas.Rows.Clear()
                                frmVentas.TextDGlobal.Text = "0.0"
                                frmVentas.TextTArticulos.Text = ""
                                'limpiarCampos1(frmVentas.GrTotales)
                                deshaCampos(frmVentas.GrTotales)
                                frmVentas.TextArticulo.Enabled = False
                                frmVentas.TextDGlobal.Enabled = False
                                frmVentas.ComboCPago.Enabled = False
                                frmVentas.TextCantidad.Enabled = False
                                limpiarCampos1(PanelTarjeta)
                                frmVentas.Enabled = True
                                frmFormaPago.Close()
                                Me.Close()
                            Else
                                transaction.Rollback()
                                MsgBox("Venta Cancelada", MsgBoxStyle.Critical)
                                'Limpio mi formulario de ventas
                                frmVentas.TextFolio.Text = ""
                                frmVentas.ComboCPago.Text = ""
                                frmVentas.DataVentas.Rows.Clear()
                                frmVentas.TextDGlobal.Text = "0.0"
                                frmVentas.TextTArticulos.Text = ""
                                'limpiarCampos1(frmVentas.GrTotales)
                                deshaCampos(frmVentas.GrTotales)
                                frmVentas.TextCantidad.Enabled = False
                                frmVentas.TextArticulo.Enabled = False
                                frmVentas.TextDGlobal.Enabled = False
                                frmVentas.ComboCPago.Enabled = False
                                frmVentas.Enabled = True
                                frmFormaPago.Close()
                                Me.Close()
                            End If
                        Else
                            'Si el saldo no cumbre el monto se abre un mensaje de "si desea pagar con otra forma de pago"
                            If aceptar = True Then
                                If MessageBox.Show("El monto ingresado no cubre totalmente el importe de la venta, ¿desea cubrir el monto con otro tipo de pago?", "Saldo Insuficiente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                                    resto = cobro - monto
                                    DataVale.Rows.Add(referenciav, combovale.Text)
                                    DataDetallePago.Rows.Add(frmVentas.TextFolio.Text, referenciav, TextImportV.Text)
                                    limpiarCampos1(panelvale)
                                    TextImporteT.Text = resto
                                    lbTotalCobroT.Text = resto
                                    TextImporte.Text = resto
                                    lbTotalCobro.Text = resto
                                    'vale
                                    TextImportV.Text = resto
                                    lbcobroV.Text = resto
                                    ptnCheque.Visible = True
                                    PtnTarjeta.Visible = True
                                    ErrorProvider1.Clear()
                                    ErrorProvider2.Clear()
                                    Me.Refresh()
                                End If
                            End If
                        End If
                        'Aqui acaba la desiion de el monto de la venta
                    Catch ex As Exception
                        MsgBox("Commit Exception type: {0} no se pudo insertar por error")
                        Try
                            transaction.Rollback()
                    Catch ex1 As Exception
                            MsgBox("Error RollBack ")
                        End Try
                    End Try
                End Using
                cnn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message + ex.StackTrace)
            End Try
            Me.Refresh()
        Else
            MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Refresh()
        ErrorProvider1.Clear()
    End Sub
End Class