Public Class frmProductoVario
    Private Sub frmProductoVario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip1.Active = True
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda"
        Me.ToolTip1.SetToolTip(Me.btAceptar, "Agrega el producto vario a la lista de compras")
        Me.ToolTip1.SetToolTip(Me.btCancelar, "Cancela el producto vario")
        Me.ToolTip1.AutoPopDelay = 5000
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

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        If (Me.ValidateChildren = True And TextDescripcion.Text <> "" And TextPrecioVenta.Text <> "" And TextDescuento.Text <> "") Then

            Dim C As Integer
            Dim localizado As Boolean
            Dim total As Decimal
            Dim ttart As Integer
            Dim descuentog As Decimal
            Dim totaldescuento As Decimal
            Dim grabtotal As Decimal
            Dim extra As Decimal
            Dim d As Decimal 'variable para sacar el descuento del producto vario
            Dim pv As Decimal 'variable para sacar el precio de venta del producto 
            Dim cod As String 'variable para crear el codigo de barras del producto vario
            cod = "VCXXXX" + (Convert.ToString(codigo))
            d = Convert.ToDecimal(TextDescuento.Text)
            pv = Convert.ToDecimal(TextPrecioVenta.Text)
            descuentog = Convert.ToDecimal(frmVentas.TextDGlobal.Text)
            extra = 100 - (Convert.ToDecimal(TextDescuento.Text))

            If d > 0 Then
                If frmVentas.DataVentas.Rows.Count < 2 Then
                    frmVentas.DataVentas.Rows.Add(cod, TextDescripcion.Text, TextCantidad.Value, (pv * 100) / extra, TextDescuento.Text, (TextCantidad.Value * pv))
                    frmVentas.TextArticulo.Clear()
                    TextCantidad.Value = 1
                Else
                    Encontrado = cod
                    For Each i As DataGridViewRow In frmVentas.DataVentas.Rows
                        If Encontrado = frmVentas.DataVentas.Item(0, i.Index).Value Then
                            localizado = True
                            '--------------------------------------------------------
                            C = frmVentas.DataVentas.Item(2, i.Index).Value
                            frmVentas.DataVentas.Item(2, i.Index).Value = C + TextCantidad.Value
                            frmVentas.DataVentas.Item(5, i.Index).Value = frmVentas.DataVentas.Item(2, i.Index).Value * pv
                            TextCantidad.Value = 1
                        End If
                    Next
                    If Not localizado Then
                        frmVentas.DataVentas.Rows.Add(cod, TextDescripcion.Text, TextCantidad.Value, (pv * 100) / extra, pv, (TextCantidad.Value * pv))
                        frmVentas.TextArticulo.Clear()
                        TextCantidad.Value = 1
                    End If
                End If
                '--------------------------------Esto quiere decir que sin no hay ofertas haga todo con normalidad---------------------
            Else
                If frmVentas.DataVentas.Rows.Count < 2 Then
                    frmVentas.DataVentas.Rows.Add(cod, TextDescripcion.Text, TextCantidad.Value, pv, 0, (TextCantidad.Value * pv))
                    frmVentas.TextArticulo.Clear()
                    TextCantidad.Value = 1
                Else
                    Encontrado = pv
                    For Each i As DataGridViewRow In frmVentas.DataVentas.Rows
                        If Encontrado = frmVentas.DataVentas.Item(0, i.Index).Value Then
                            localizado = True
                            '--------------------------------------------------------
                            C = frmVentas.DataVentas.Item(2, i.Index).Value
                            frmVentas.DataVentas.Item(2, i.Index).Value = C + TextCantidad.Value
                            frmVentas.DataVentas.Item(5, i.Index).Value = frmVentas.DataVentas.Item(2, i.Index).Value * frmVentas.DataVentas.Item(3, i.Index).Value
                            'TextArticulo.Clear()
                            TextCantidad.Value = 1
                        End If
                    Next
                    If Not localizado Then
                        frmVentas.DataVentas.Rows.Add(cod, TextDescripcion.Text, TextCantidad.Value, pv, 0, (TextCantidad.Value * pv))
                        TextCantidad.Value = 1
                    End If
                End If
            End If
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
            Me.Close()
        Else
            MessageBox.Show("Faltan ingresar algunos datos", "Error al crear el producto vario", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub

    Private Sub TextDescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextDescuento.KeyPress
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

    Private Sub TextPrecioVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPrecioVenta.KeyPress
        NumerosyDecimal(TextPrecioVenta, e)
    End Sub
End Class