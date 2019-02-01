Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms
Public Class frmFormaPago
    Dim cmd As SqlCommand
    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        aceptar = True
        'textMonto.Size = New Size(25, 12)
        Dim cobro As Decimal
        Dim monto As Decimal
        Dim resto As Decimal
        If textMonto.Text <> "" Then
            cobro = Convert.ToDecimal(TxtCobro.Text)
            monto = Convert.ToDecimal(textMonto.Text)
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
                    Fecha = frmVentas.TextFecha.Value.Year & "-" & frmVentas.TextFecha.Value.Month & "-" & frmVentas.TextFecha.Value.Day
                    r = "insert into Ventas (FolioVenta, idempleado, idvendedor, Fecha, DescuentoGlobal, Subtotal) values ('" & frmVentas.TextFolio.Text & "'," & Val(frmVentas.TextidCajera.Text) & "," & Val(frmVentas.ComboVendedor.Text) & ",'" & Fecha & "'," & CDbl(frmVentas.TextDGlobal.Text) & "," & CDbl(frmVentas.TextSubtotal.Text) & ")"
                    cmd.CommandText = r
                    cmd.ExecuteNonQuery()
                    If (monto > cobro) Then
                        r = "insert into DetallePago (FolioVenta, Referencia, Importe) values ('" & frmVentas.TextFolio.Text & "','" & frmVentas.ComboCPago.Text & "'," & CDbl(cobro) & ")"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                    Else
                        r = "insert into DetallePago (FolioVenta, Referencia, Importe) values ('" & frmVentas.TextFolio.Text & "','" & frmVentas.ComboCPago.Text & "'," & CDbl(textMonto.Text) & ")"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                    End If
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
                        r = "insert into DetalleVenta(FolioVenta, codigo_barras, Cantidad, Precio, DescuentoExtra, Descripcion) values('" & frmVentas.TextFolio.Text & "','" & c2 & "'," & c3 & "," & c4 & ",'" & c5 & "','" & c6 & "')"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                        r = "update articulos set existencia=existencia-" & c3 & " where codigo_barras='" & c2 & "'"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                    Next
                    Try
                        '------------------------------------Transaccion----------------------------------------------
                        'Aqui verifico si el monto cubre el total de la venta
                        If monto >= cobro Then
                            If MessageBox.Show("¿Desea Guardar la Venta?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

                                transaction.Commit()
                                lbMensaje.Text = "Su Cambio es:"
                                resto = monto - cobro
                                TxtCobro.Text = Convert.ToString(resto)
                                '----------------------------------Aqui se imprime el ticket-----------------------------------
                                Dim pagoen As String
                                pagoen = "EFECTIVO Su cambio: " + TxtCobro.Text
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

                                textMonto.Clear()
                                textMonto.Enabled = False
                                'Limpio mi formulario de ventas
                                frmVentas.ComboCPago.Text = ""
                                frmVentas.DataVentas.Rows.Clear()
                                frmVentas.TextDGlobal.Text = "0.0"
                                frmVentas.TextTArticulos.Text = ""
                                limpiarCampos1(frmVentas.GrTotales)
                                frmVentas.ComboCPago.Enabled = False
                                frmVentas.TextArticulo.Enabled = False
                                frmVentas.TextCantidad.Enabled = False
                                deshaCampos(frmVentas.GrTotales)
                                frmVentas.TextDGlobal.Enabled = False
                                frmVentas.Enabled = True
                                btAceptar.Enabled = False
                                'Habilitar cerrar-----------
                                btCerrar.Visible = True
                                Button1.Visible = False
                                frmVentas.btAgregar.Enabled = False
                                textMonto.Visible = False
                                lbmonto.Visible = False
                                codigo = 0
                                frmVentas.BtProductoV.Enabled = False

                                frmVentas.TextFolio.Text = ""
                                '--------------------------------------------------------------------------------------------------
                            Else
                                transaction.Rollback()
                                MsgBox("Venta Cancelada", MsgBoxStyle.Critical)
                                'Limpio mi formulario de ventas
                                textMonto.Clear()
                                frmVentas.TextFolio.Text = ""
                                frmVentas.ComboCPago.Text = ""
                                frmVentas.DataVentas.Rows.Clear()
                                frmVentas.TextDGlobal.Text = "0.0"
                                frmVentas.TextTArticulos.Text = ""
                                limpiarCampos1(frmVentas.GrTotales)
                                frmVentas.ComboCPago.Enabled = False
                                frmVentas.TextArticulo.Enabled = False
                                frmVentas.TextCantidad.Enabled = False
                                frmVentas.Enabled = True
                                deshaCampos(frmVentas.GrTotales)
                                frmVentas.TextDGlobal.Enabled = False
                                frmVentas.btAgregar.Enabled = False
                                frmVentas.BtProductoV.Enabled = False
                                codigo = 0
                                Me.Dispose()
                            End If
                        Else
                            If aceptar = True Then
                                If MessageBox.Show("El monto ingresado no cubre totalmente el importe de la venta, ¿desea cubrir el monto con otro tipo de pago?", "Saldo Insuficiente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                                    pagos = True
                                    resto = cobro - monto
                                    frmFormasPago.DataDetallePago.Rows.Add(frmVentas.TextFolio.Text, "EFECTIVO", textMonto.Text)
                                    frmFormasPago.TextImporte.Text = resto
                                    frmFormasPago.lbTotalCobro.Text = resto
                                    frmFormasPago.TextImporteT.Text = resto
                                    frmFormasPago.lbTotalCobroT.Text = resto
                                    frmFormasPago.TextImportV.Text = resto
                                    frmFormasPago.lbcobroV.Text = resto
                                    frmFormasPago.Show()
                                    Me.Hide()
                                End If
                            End If
                        End If
                        ' Aqui acaba la desiion de el monto de la venta
                    Catch ex As Exception
                        MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error Externo al Sistema")
                        Try
                            transaction.Rollback()
                    Catch ex1 As Exception
                            MsgBox("Error RollBack", MsgBoxStyle.Critical, "Error externo al Sistema")
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
    End Sub

    Private Sub textMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textMonto.KeyPress
        NumerosyDecimal(textMonto, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Venta Cancelada", MsgBoxStyle.Critical)
        'Limpio mi formulario de ventas
        textMonto.Clear()
        frmVentas.TextFolio.Text = ""
        frmVentas.ComboCPago.Text = ""
        frmVentas.DataVentas.Rows.Clear()
        frmVentas.TextDGlobal.Text = "0.0"
        frmVentas.TextTArticulos.Text = ""
        limpiarCampos1(frmVentas.GrTotales)
        frmVentas.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub frmFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip1.Active = True
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda"
        Me.ToolTip1.SetToolTip(Me.btAceptar, "Guarda el importe de la venta")
        Me.ToolTip1.SetToolTip(Me.Button1, "Cancela la venta")
        Me.ToolTip1.AutoPopDelay = 5000
    End Sub

    Private Sub textMonto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles textMonto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca el monto recibido")
        End If
    End Sub

    Private Sub btCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        Me.Close()
    End Sub

    Private Sub textMonto_KeyDown(sender As Object, e As KeyEventArgs) Handles textMonto.KeyDown
         Select e.KeyData
            Case Keys.Enter
                aceptar = True
                Dim cobro As Decimal
                Dim monto As Decimal
                Dim resto As Decimal
                If Me.ValidateChildren = True And textMonto.Text <> "" Then
                    cobro = Convert.ToDecimal(TxtCobro.Text)
                    monto = Convert.ToDecimal(textMonto.Text)
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
                            Fecha = frmVentas.TextFecha.Value.Year & "-" & frmVentas.TextFecha.Value.Month & "-" & frmVentas.TextFecha.Value.Day
                            r = "insert into Ventas (FolioVenta, idempleado, idvendedor, Fecha, DescuentoGlobal, Subtotal) values ('" & frmVentas.TextFolio.Text & "'," & Val(frmVentas.TextidCajera.Text) & "," & Val(frmVentas.ComboVendedor.Text) & ",'" & Fecha & "'," & CDbl(frmVentas.TextDGlobal.Text) & "," & CDbl(frmVentas.TextSubtotal.Text) & ")"
                            cmd.CommandText = r
                            cmd.ExecuteNonQuery()
                            If (monto > cobro) Then
                                r = "insert into DetallePago (FolioVenta, Referencia, Importe) values ('" & frmVentas.TextFolio.Text & "','" & frmVentas.ComboCPago.Text & "'," & CDbl(cobro) & ")"
                                cmd.CommandText = r
                                cmd.ExecuteNonQuery()
                            Else
                                r = "insert into DetallePago (FolioVenta, Referencia, Importe) values ('" & frmVentas.TextFolio.Text & "','" & frmVentas.ComboCPago.Text & "'," & CDbl(textMonto.Text) & ")"
                                cmd.CommandText = r
                                cmd.ExecuteNonQuery()
                            End If
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
                            Try
                                '------------------------------------Transaccion----------------------------------------------
                                'Aqui verifico si el monto cubre el total de la venta
                                If monto >= cobro Then
                                    If MessageBox.Show("¿Desea Guardar la Venta?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                        transaction.Commit()
                                        lbMensaje.Text = "Su Cambio es:"
                                        resto = monto - cobro
                                        TxtCobro.Text = Convert.ToString(resto)
                                        '----------------------------------Aqui se imprime el ticket-----------------------------------
                                        Dim pagoen As String
                                        pagoen = "EFECTIVO Su cambio: " + TxtCobro.Text
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
                                        'Dim param2 = New SqlParameter("@", SqlDbType.Text)
                                        'param1.Direction = ParameterDirection.Input
                                        'param1.Value = (f1)
                                        'adaptador.SelectCommand.Parameters.Add(param1)
                                        Dim dataset As New DataSet
                                        adaptador.Fill(dataset)
                                        dataset.DataSetName = "DataSet1"
                                        Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                                        datasource.Name = "DataSet1"
                                        datasource.Value = dataset.Tables(0)
                                        Dim p1 As New ReportParameter("Venta1", f1)
                                        Dim p2 As New ReportParameter("CantidadLetra", ConvertirNumero(frmVentas.TextGranT.Text))
                                        Dim p3 As New ReportParameter("Subtotal", CDbl(frmVentas.TextGranT.Text))
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

                                        textMonto.Clear()
                                        textMonto.Enabled = False
                                        'Limpio mi formulario de ventas
                                        frmVentas.TextFolio.Text = ""
                                        frmVentas.ComboCPago.Text = ""
                                        frmVentas.DataVentas.Rows.Clear()
                                        frmVentas.TextDGlobal.Text = "0.0"
                                        frmVentas.TextTArticulos.Text = ""
                                        limpiarCampos1(frmVentas.GrTotales)
                                        frmVentas.ComboCPago.Enabled = False
                                        frmVentas.TextArticulo.Enabled = False
                                        frmVentas.TextCantidad.Enabled = False
                                        deshaCampos(frmVentas.GrTotales)
                                        frmVentas.TextDGlobal.Enabled = False
                                        frmVentas.Enabled = True
                                        btAceptar.Enabled = False
                                        'Habilitar cerrar-----------
                                        btCerrar.Visible = True
                                        Button1.Visible = False
                                        frmVentas.btAgregar.Enabled = False
                                        textMonto.Visible = False
                                        lbmonto.Visible = False
                                        codigo = 0
                                    Else
                                        transaction.Rollback()
                                        MsgBox("Venta Cancelada", MsgBoxStyle.Critical)
                                        'Limpio mi formulario de ventas
                                        textMonto.Clear()
                                        frmVentas.TextFolio.Text = ""
                                        frmVentas.ComboCPago.Text = ""
                                        frmVentas.DataVentas.Rows.Clear()
                                        frmVentas.TextDGlobal.Text = "0.0"
                                        frmVentas.TextTArticulos.Text = ""
                                        limpiarCampos1(frmVentas.GrTotales)
                                        frmVentas.ComboCPago.Enabled = False
                                        frmVentas.TextArticulo.Enabled = False
                                        frmVentas.TextCantidad.Enabled = False
                                        frmVentas.Enabled = True
                                        deshaCampos(frmVentas.GrTotales)
                                        frmVentas.TextDGlobal.Enabled = False
                                        frmVentas.btAgregar.Enabled = False
                                        codigo = 0
                                        Me.Close()

                                    End If
                                Else
                                    If aceptar = True Then
                                        If MessageBox.Show("El monto ingresado no cubre totalmente el importe de la venta, ¿desea cubrir el monto con otro tipo de pago?", "Saldo Insuficiente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                                            pagos = True
                                            resto = cobro - monto
                                            frmFormasPago.DataDetallePago.Rows.Add(frmVentas.TextFolio.Text, "EFECTIVO", textMonto.Text)
                                            frmFormasPago.TextImporte.Text = resto
                                            frmFormasPago.lbTotalCobro.Text = resto
                                            frmFormasPago.TextImporteT.Text = resto
                                            frmFormasPago.lbTotalCobroT.Text = resto
                                            frmFormasPago.Show()
                                            Me.Hide()
                                        End If
                                    End If
                                End If
                                'Aqui acaba la desiion de el monto de la venta
                            Catch ex As Exception
                                MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error Externo al Sistema")
                                Try
                                    transaction.Rollback()
                                Catch ex1 As Exception
                                    MsgBox("Error RollBack", MsgBoxStyle.Critical, "Error externo al Sistema")
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
        End Select
    End Sub

    Private Sub btAceptar_MouseHover(sender As Object, e As EventArgs) Handles btAceptar.MouseHover
        btAceptar.Size = New Size(126, 38)
    End Sub

    Private Sub btAceptar_MouseLeave(sender As Object, e As EventArgs) Handles btAceptar.MouseLeave
        btAceptar.Size = New Size(123, 35)
    End Sub

    Private Sub btCerrar_MouseHover(sender As Object, e As EventArgs) Handles btCerrar.MouseHover
        btCerrar.Size = New Size(126, 38)
    End Sub

    Private Sub btCerrar_MouseLeave(sender As Object, e As EventArgs) Handles btCerrar.MouseLeave
        btCerrar.Size = New Size(123, 35)
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.Size = New Size(126, 38)
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.Size = New Size(123, 35)
    End Sub

    Private Sub frmFormaPago_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Limpio mi formulario de ventas
        textMonto.Clear()
        frmVentas.TextFolio.Text = ""
        frmVentas.ComboCPago.Text = ""
        frmVentas.DataVentas.Rows.Clear()
        frmVentas.TextDGlobal.Text = "0.0"
        frmVentas.TextTArticulos.Text = ""
        limpiarCampos1(frmVentas.GrTotales)
        frmVentas.Enabled = True
        Me.Dispose()
    End Sub
End Class