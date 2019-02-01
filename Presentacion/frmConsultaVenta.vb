Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmConsultaVenta
    Dim comando As SqlCommand
    Dim lector As SqlDataReader
    Dim cadena As String
    Dim condicion As Integer
    Private Sub frmConsultaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip1.Active = True
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda"
        Me.ToolTip1.SetToolTip(Me.btImprimir, "Re-Imprime el ticket de esta Venta")
        Me.ToolTip1.AutoPopDelay = 5000
        Try

            Dim clase As New SqlConnection(conexion)
            clase.Open()
            comando = clase.CreateCommand
            Dim R As String
            R = "select Ventas.FolioVenta, empleados.idempleado, empleados.nombre, vendedores.idvendedor, vendedores.nombre, Fecha, DescuentoGlobal, Subtotal from Ventas inner join empleados on Ventas.idempleado=empleados.idempleado inner join vendedores on ventas.idvendedor=vendedores.idvendedor where Ventas.FolioVenta='" & frmPreConsulta.TextFolioV.Text & "'"
            comando.CommandText = R
            lector = comando.ExecuteReader
            lector.Read()
            TextFolio.Text = lector(0)
            TextidCajera.Text = lector(1)
            TextCajera.Text = lector(2)
            TextidVendedor.Text = lector(3)
            TextVendedor.Text = lector(4)
            TextFecha.Text = lector(5)
            TextDGlobal.Text = lector(6)
            TextSubtotal.Text = lector(7)
            lector.Close()
            R = "select count(*) Referencia from ventas inner join DetallePago on ventas.FolioVenta=DetallePago.FolioVenta where Ventas.FolioVenta='" & frmPreConsulta.TextFolioV.Text & "'"
            comando.CommandText = R
            lector = comando.ExecuteReader
            lector.Read()
            condicion = lector(0)
            lector.Close()
            If (condicion = 1) Then
                R = "select Referencia from ventas inner join DetallePago on ventas.FolioVenta=DetallePago.FolioVenta where Ventas.FolioVenta='" & frmPreConsulta.TextFolioV.Text & "'"
                comando.CommandText = R
                lector = comando.ExecuteReader
                lector.Read()
                ' nomcondicion = lector(0)

                If (lector(0).ToString(0) = "T") Then
                    TextCondicion.Text = "TARJETA"
                ElseIf (lector(0).ToString(0) = "C") Then
                    TextCondicion.Text = "CHEQUE"
                Else
                    TextCondicion.Text = lector(0)
                End If
                lector.Close()
            Else
                TextCondicion.Text = "VARIOS"
            End If
            Dim subt As Decimal
            Dim total As Decimal
            subt = Convert.ToDecimal(TextSubtotal.Text)
            'total = subt + iva
            TextGranT.Text = Convert.ToString(total)
            'TextIva.Text = Convert.ToString(iva)
            R = "select DetalleVenta.codigo_barras, DetalleVenta.descripcion, DetalleVenta.Cantidad, DetalleVenta.Precio, DescuentoExtra from articulos inner join DetalleVenta on articulos.codigo_barras=DetalleVenta.codigo_barras inner join Ventas on DetalleVenta.FolioVenta=ventas.FolioVenta where DetalleVenta.FolioVenta='" & frmPreConsulta.TextFolioV.Text & "'"
            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read()
                If (lector(4) = 0) Then
                    DataVentas.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), (lector(2) * lector(3)))
                Else
                    DataVentas.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), Format(((lector(2) * lector(3)) - (((lector(2) * lector(3)) * lector(4)) / 100)), "0.00"))
                End If
                'DataVentas.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            End While
            lector.Close()
            clase.Close()
            Dim ttart As Integer
            Dim descuentog As Decimal
            descuentog = Convert.ToDecimal(TextDGlobal.Text)
            Dim totaldescuento As Decimal
            Dim grabtotal As Decimal
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
        Catch ex As Exception
            MessageBox.Show("El folio de Venta no es Válido, vuelve a escribir el Folio", "Folio de Venta Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub btImprimir_MouseHover(sender As Object, e As EventArgs) Handles btImprimir.MouseHover
        btImprimir.Size = New Size(126, 38)
    End Sub

    Private Sub btImprimir_MouseLeave(sender As Object, e As EventArgs) Handles btImprimir.MouseLeave
        btImprimir.Size = New Size(123, 35)
    End Sub

    Private Sub btSalir_MouseHover(sender As Object, e As EventArgs) Handles btSalir.MouseHover
        btSalir.Size = New Size(126, 38)
    End Sub

    Private Sub btSalir_MouseLeave(sender As Object, e As EventArgs) Handles btSalir.MouseLeave
        btSalir.Size = New Size(123, 35)
    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click
        '----------------------------------Aqui se imprime el ticket-----------------------------------
        Dim pagoen As String
        pagoen = TextCondicion.Text
        Dim f1 As String
        f1 = TextFolio.Text
        Dim clase As New SqlConnection(conexion)
        clase.Open()
        comando = clase.CreateCommand
        comando.CommandText = "TICKETVENTA"
        comando.CommandType = CommandType.StoredProcedure
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
        Dim p2 As New ReportParameter("CantidadLetra", ConvertirNumero(TextGranT.Text))
        Dim p3 As New ReportParameter("Subtotal", CDbl(TextSubNeto.Text))
        Dim p4 As New ReportParameter("DescGlobal", CDbl(TextDexcuento.Text))
        Dim p5 As New ReportParameter("Total", CDbl(TextGranT.Text))
        Dim p6 As New ReportParameter("Pago", pagoen)
        frmTicket.ReportViewer1.LocalReport.DataSources.Clear()
        frmTicket.ReportViewer1.LocalReport.DataSources.Add(datasource)
        frmTicket.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\Ticket.rdlc"
        frmTicket.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3, p4, p5, p6})
        frmTicket.ReportViewer1.RefreshReport()
        frmTicket.Show()
        clase.Close()
        '------------------------------------------------------------------------------------------------

    End Sub
End Class