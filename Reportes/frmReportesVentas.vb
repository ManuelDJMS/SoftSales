Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmReportesVentas
    Dim cmd As SqlCommand
    Dim lector As SqlDataReader
    Dim Fecha As String
    Dim fecha2 As String
    Dim empleado As String
    Dim cadena As String
    Private Sub frmReportesVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip1.Active = True
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda"
        Me.ToolTip1.SetToolTip(Me.btAceptar, "Abrir el reporte Seleccionado")
        Me.ToolTip1.SetToolTip(Me.btCancelar, "Cancela la Vista del Reporte")
        Me.ToolTip1.AutoPopDelay = 5000
        Dim clase As New SqlConnection(conexion)
        clase.Open()
        cmd = clase.CreateCommand
        cmd.CommandText = "select nombre from empleados where tipoempleado='Cajero(a)' or tipoempleado='Admin'"
        lector = cmd.ExecuteReader
        While lector.Read()
            ComboEmpleadoDC.Items.Add(lector(0))
        End While
        lector.Close()
        cmd.CommandText = "select nombre from empleados where tipoempleado='Cajero(a)' or tipoempleado='Admin'"
        lector = cmd.ExecuteReader
        While lector.Read()
            ComboVentasFC.Items.Add(lector(0))
        End While
        lector.Close()
        clase.Close()
    End Sub

    Private Sub rbVentasGDia_CheckedChanged(sender As Object, e As EventArgs) Handles rbVentasGDia.CheckedChanged
        If (rbVentasGDia.Checked) Then
            PanelVentasDia.Enabled = True
            PanelFormasPago.Enabled = False
            GroupCajeroDia.Enabled = False
            panelVentasFechas.Enabled = False
            panelFechasPago.Enabled = False
            panelVentasFC.Enabled = False
        End If
    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        Try
            If rbVentasGDia.Checked Then
                'Dim Fecha As String
                Fecha = DateVentasGdia.Value.Year & "-" & DateVentasGdia.Value.Month & "-" & DateVentasGdia.Value.Day
                Dim clase As New SqlConnection(conexion)
                clase.Open()
                cmd = clase.CreateCommand
                cmd.CommandText = "Reporte_VentasDia"
                cmd.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter()
                adaptador.SelectCommand = New SqlCommand
                adaptador.SelectCommand.Connection = clase
                adaptador.SelectCommand.CommandText = "Reporte_VentasDia"
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim param1 = New SqlParameter("@FechaDia", SqlDbType.Date)
                param1.Direction = ParameterDirection.Input
                param1.Value = (Fecha)
                adaptador.SelectCommand.Parameters.Add(param1)
                Dim dataset As New DataSet
                adaptador.Fill(dataset)
                dataset.DataSetName = "DataSet1"
                Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                datasource.Name = "DataSet1"
                datasource.Value = dataset.Tables(0)
                Dim p1 As New ReportParameter("Dia", Fecha)
                frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteVentasxDia.rdlc"
                frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1})
                frmReportes.ReportViewer1.RefreshReport()
                'End If
                frmReportes.MdiParent = frmMenu
                frmReportes.Show()
                clase.Close()
                '-----------------------------------------Ventas por Fechas----------------------------------------------
            ElseIf rbVentasFechas.Checked Then
                'Dim Fecha As String
                Fecha = DateFechas.Value.Year & "-" & DateFechas.Value.Month & "-" & DateFechas.Value.Day
                fecha2 = DateFechas2.Value.Year & "-" & DateFechas2.Value.Month & "-" & DateFechas2.Value.Day
                Dim clase As New SqlConnection(conexion)
                clase.Open()
                cmd = clase.CreateCommand
                cmd.CommandText = "Reporte_VentasFechas"
                cmd.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter()
                adaptador.SelectCommand = New SqlCommand
                adaptador.SelectCommand.Connection = clase
                adaptador.SelectCommand.CommandText = "Reporte_VentasFechas"
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim param1 = New SqlParameter("@FechaDia1", SqlDbType.Date)
                Dim param2 = New SqlParameter("@FechaDia2", SqlDbType.Date)
                param1.Direction = ParameterDirection.Input
                param1.Value = (Fecha)
                param2.Direction = ParameterDirection.Input
                param2.Value = (fecha2)
                adaptador.SelectCommand.Parameters.Add(param1)
                adaptador.SelectCommand.Parameters.Add(param2)
                Dim dataset As New DataSet
                adaptador.Fill(dataset)
                dataset.DataSetName = "DataSet1"
                Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                datasource.Name = "DataSet1"
                datasource.Value = dataset.Tables(0)
                Dim p1 As New ReportParameter("Dia1", Fecha)
                Dim p2 As New ReportParameter("Dia2", fecha2)
                frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteVentasFechas.rdlc"
                frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
                frmReportes.ReportViewer1.RefreshReport()
                'End If
                frmReportes.MdiParent = frmMenu
                frmReportes.Show()
                clase.Close()
                '-----------------------------------------Formas de Pago por DIA-----------------------------------------
            ElseIf rbFormaPago.Checked Then
                If (rbEfectivo.Checked) Then
                    ' Dim Fecha As String
                    Fecha = DateFormasPago.Value.Year & "-" & DateFormasPago.Value.Month & "-" & DateFormasPago.Value.Day
                    Dim clase As New SqlConnection(conexion)
                    clase.Open()
                    cmd = clase.CreateCommand
                    cmd.CommandText = "Reporte_VentasDiaEfectivo"
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter()
                    adaptador.SelectCommand = New SqlCommand
                    adaptador.SelectCommand.Connection = clase
                    adaptador.SelectCommand.CommandText = "Reporte_VentasDiaEfectivo"
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                    Dim param1 = New SqlParameter("@FechaDia", SqlDbType.Date)
                    param1.Direction = ParameterDirection.Input
                    param1.Value = (Fecha)
                    adaptador.SelectCommand.Parameters.Add(param1)
                    Dim dataset As New DataSet
                    adaptador.Fill(dataset)
                    dataset.DataSetName = "DataSet1"
                    Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                    datasource.Name = "DataSet1"
                    datasource.Value = dataset.Tables(0)
                    Dim p1 As New ReportParameter("Dia", Fecha)
                    frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                    frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                    frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteVentasDiaEfectivo.rdlc"
                    frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1})
                    frmReportes.ReportViewer1.RefreshReport()
                    'End If
                    frmReportes.MdiParent = frmMenu
                    frmReportes.Show()
                    clase.Close()
                ElseIf (rbTarjeta.Checked) Then
                    ' Dim Fecha As String
                    Fecha = DateFormasPago.Value.Year & "-" & DateFormasPago.Value.Month & "-" & DateFormasPago.Value.Day
                    Dim clase As New SqlConnection(conexion)
                    clase.Open()
                    cmd = clase.CreateCommand
                    cmd.CommandText = "Reporte_VentasDiaTarjeta"
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter()
                    adaptador.SelectCommand = New SqlCommand
                    adaptador.SelectCommand.Connection = clase
                    adaptador.SelectCommand.CommandText = "Reporte_VentasDiaTarjeta"
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                    Dim param1 = New SqlParameter("@FechaDia", SqlDbType.Date)
                    param1.Direction = ParameterDirection.Input
                    param1.Value = (Fecha)
                    adaptador.SelectCommand.Parameters.Add(param1)
                    Dim dataset As New DataSet
                    adaptador.Fill(dataset)
                    dataset.DataSetName = "DataSet1"
                    Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                    datasource.Name = "DataSet1"
                    datasource.Value = dataset.Tables(0)
                    Dim p1 As New ReportParameter("Dia", Fecha)
                    frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                    frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                    frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteVentasDiaTarjet.rdlc"
                    frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1})
                    frmReportes.ReportViewer1.RefreshReport()
                    'End If
                    frmReportes.MdiParent = frmMenu
                    frmReportes.Show()
                    clase.Close()
                ElseIf (rbCheque.Checked) Then
                    'Dim Fecha As String
                    Fecha = DateFormasPago.Value.Year & "-" & DateFormasPago.Value.Month & "-" & DateFormasPago.Value.Day
                    Dim clase As New SqlConnection(conexion)
                    clase.Open()
                    cmd = clase.CreateCommand
                    cmd.CommandText = "Reporte_VentasDiaCheques"
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter()
                    adaptador.SelectCommand = New SqlCommand
                    adaptador.SelectCommand.Connection = clase
                    adaptador.SelectCommand.CommandText = "Reporte_VentasDiaCheques"
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                    Dim param1 = New SqlParameter("@FechaDia", SqlDbType.Date)
                    param1.Direction = ParameterDirection.Input
                    param1.Value = (Fecha)
                    adaptador.SelectCommand.Parameters.Add(param1)
                    Dim dataset As New DataSet
                    adaptador.Fill(dataset)
                    dataset.DataSetName = "DataSet1"
                    Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                    datasource.Name = "DataSet1"
                    datasource.Value = dataset.Tables(0)
                    Dim p1 As New ReportParameter("Dia", Fecha)
                    frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                    frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                    frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteVentasDiaCheque.rdlc"
                    frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1})
                    frmReportes.ReportViewer1.RefreshReport()
                    'End If
                    frmReportes.MdiParent = frmMenu
                    frmReportes.Show()
                    clase.Close()
                End If
                '---------------------------------------Ventas por dia por cajero --------------------------------------
            ElseIf rbCajeroDia.Checked Then
                If (rbEfectivoDC.Checked) Then
                    ' Dim Fecha As String
                    empleado = ComboEmpleadoDC.Text
                    Fecha = DateCajeroDia.Value.Year & "-" & DateCajeroDia.Value.Month & "-" & DateCajeroDia.Value.Day
                    Dim clase As New SqlConnection(conexion)
                    clase.Open()
                    cmd = clase.CreateCommand
                    cmd.CommandText = "Reporte_VentasDiaEfectivoCajeros"
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter()
                    adaptador.SelectCommand = New SqlCommand
                    adaptador.SelectCommand.Connection = clase
                    adaptador.SelectCommand.CommandText = "Reporte_VentasDiaEfectivoCajeros"
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                    Dim param1 = New SqlParameter("@FechaDia", SqlDbType.Date)
                    Dim param2 = New SqlParameter("@Empleado", SqlDbType.Text)
                    param1.Direction = ParameterDirection.Input
                    param1.Value = (Fecha)
                    param2.Direction = ParameterDirection.Input
                    param2.Value = (empleado)
                    adaptador.SelectCommand.Parameters.Add(param1)
                    adaptador.SelectCommand.Parameters.Add(param2)
                    Dim dataset As New DataSet
                    adaptador.Fill(dataset)
                    dataset.DataSetName = "DataSet1"
                    Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                    datasource.Name = "DataSet1"
                    datasource.Value = dataset.Tables(0)
                    Dim p1 As New ReportParameter("Dia", Fecha)
                    Dim p2 As New ReportParameter("Empleado", empleado)
                    frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                    frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                    frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteVentasDiaEfectivoCajeros.rdlc"
                    frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
                    frmReportes.ReportViewer1.RefreshReport()
                    'End If
                    frmReportes.MdiParent = frmMenu
                    frmReportes.Show()
                    clase.Close()
                ElseIf (rbTarjetaDC.Checked) Then
                    ' Dim Fecha As String
                    empleado = ComboEmpleadoDC.Text
                    Fecha = DateCajeroDia.Value.Year & "-" & DateCajeroDia.Value.Month & "-" & DateCajeroDia.Value.Day
                    Dim clase As New SqlConnection(conexion)
                    clase.Open()
                    cmd = clase.CreateCommand
                    cmd.CommandText = "Reporte_VentasDiaTarjetaCajeros"
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter()
                    adaptador.SelectCommand = New SqlCommand
                    adaptador.SelectCommand.Connection = clase
                    adaptador.SelectCommand.CommandText = "Reporte_VentasDiaTarjetaCajeros"
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                    Dim param1 = New SqlParameter("@FechaDia", SqlDbType.Date)
                    Dim param2 = New SqlParameter("@Empleado", SqlDbType.Text)
                    param1.Direction = ParameterDirection.Input
                    param1.Value = (Fecha)
                    adaptador.SelectCommand.Parameters.Add(param1)
                    param2.Direction = ParameterDirection.Input
                    param2.Value = (empleado)
                    adaptador.SelectCommand.Parameters.Add(param2)
                    Dim dataset As New DataSet
                    adaptador.Fill(dataset)
                    dataset.DataSetName = "DataSet1"
                    Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                    datasource.Name = "DataSet1"
                    datasource.Value = dataset.Tables(0)
                    Dim p1 As New ReportParameter("Dia", Fecha)
                    Dim p2 As New ReportParameter("Empleado", empleado)
                    frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                    frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                    frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteVentasDiaTarjetaCajeros.rdlc"
                    frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
                    frmReportes.ReportViewer1.RefreshReport()
                    'End If
                    frmReportes.MdiParent = frmMenu
                    frmReportes.Show()
                    clase.Close()
                ElseIf (rbChequeDC.Checked) Then
                    'Dim Fecha As String
                    empleado = ComboEmpleadoDC.Text
                    Fecha = DateCajeroDia.Value.Year & "-" & DateCajeroDia.Value.Month & "-" & DateCajeroDia.Value.Day
                    Dim clase As New SqlConnection(conexion)
                    clase.Open()
                    cmd = clase.CreateCommand
                    cmd.CommandText = "Reporte_VentasDiaChequeCajeros"
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter()
                    adaptador.SelectCommand = New SqlCommand
                    adaptador.SelectCommand.Connection = clase
                    adaptador.SelectCommand.CommandText = "Reporte_VentasDiaChequeCajeros"
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                    Dim param1 = New SqlParameter("@FechaDia", SqlDbType.Date)
                    param1.Direction = ParameterDirection.Input
                    param1.Value = (Fecha)
                    adaptador.SelectCommand.Parameters.Add(param1)
                    Dim param2 = New SqlParameter("@Empleado", SqlDbType.Text)
                    param2.Direction = ParameterDirection.Input
                    param2.Value = (empleado)
                    adaptador.SelectCommand.Parameters.Add(param2)
                    Dim dataset As New DataSet
                    adaptador.Fill(dataset)
                    dataset.DataSetName = "DataSet1"
                    Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                    datasource.Name = "DataSet1"
                    datasource.Value = dataset.Tables(0)
                    Dim p1 As New ReportParameter("Dia", Fecha)
                    Dim p2 As New ReportParameter("Empleado", empleado)
                    frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                    frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                    frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteVentasDiaChequeCajeros.rdlc"
                    frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
                    frmReportes.ReportViewer1.RefreshReport()
                    'End If
                    frmReportes.MdiParent = frmMenu
                    frmReportes.Show()
                    clase.Close()
                End If 'decision de termino de fechas dia
                '-----------------------------------------Formas de Pago por Fechas-----------------------------------------
            ElseIf rbVentasFechasPago.Checked Then
                If (rbFechasEfectivo.Checked) Then
                    Fecha = DateFechasPago.Value.Year & "-" & DateFechasPago.Value.Month & "-" & DateFechasPago.Value.Day
                    fecha2 = DateFechasPago2.Value.Year & "-" & DateFechasPago2.Value.Month & "-" & DateFechasPago2.Value.Day
                    Dim clase As New SqlConnection(conexion)
                    clase.Open()
                    cmd = clase.CreateCommand
                    cmd.CommandText = "Reporte_VentasFechasDiaEfectivo"
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter()
                    adaptador.SelectCommand = New SqlCommand
                    adaptador.SelectCommand.Connection = clase
                    adaptador.SelectCommand.CommandText = "Reporte_VentasFechasDiaEfectivo"
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                    Dim param1 = New SqlParameter("@Fecha1", SqlDbType.Date)
                    Dim param2 = New SqlParameter("@Fecha2", SqlDbType.Date)
                    param1.Direction = ParameterDirection.Input
                    param1.Value = (Fecha)
                    param2.Direction = ParameterDirection.Input
                    param2.Value = (fecha2)
                    adaptador.SelectCommand.Parameters.Add(param1)
                    adaptador.SelectCommand.Parameters.Add(param2)
                    Dim dataset As New DataSet
                    adaptador.Fill(dataset)
                    dataset.DataSetName = "DataSet1"
                    Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                    datasource.Name = "DataSet1"
                    datasource.Value = dataset.Tables(0)
                    Dim p1 As New ReportParameter("Dia1", Fecha)
                    Dim p2 As New ReportParameter("Dia2", fecha2)
                    frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                    frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                    frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteVentasFechasEfectivo.rdlc"
                    frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
                    frmReportes.ReportViewer1.RefreshReport()
                    'End If
                    frmReportes.MdiParent = frmMenu
                    frmReportes.Show()
                    clase.Close()
                ElseIf (rbFechasCheque.Checked) Then
                    Fecha = DateFechasPago.Value.Year & "-" & DateFechasPago.Value.Month & "-" & DateFechasPago.Value.Day
                    fecha2 = DateFechasPago2.Value.Year & "-" & DateFechasPago2.Value.Month & "-" & DateFechasPago2.Value.Day
                    Dim clase As New SqlConnection(conexion)
                    clase.Open()
                    cmd = clase.CreateCommand
                    cmd.CommandText = "Reporte_VentasFechasDiaCheques"
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter()
                    adaptador.SelectCommand = New SqlCommand
                    adaptador.SelectCommand.Connection = clase
                    adaptador.SelectCommand.CommandText = "Reporte_VentasFechasDiaCheques"
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                    Dim param1 = New SqlParameter("@Fecha1", SqlDbType.Date)
                    Dim param2 = New SqlParameter("@Fecha2", SqlDbType.Date)
                    param1.Direction = ParameterDirection.Input
                    param1.Value = (Fecha)
                    param2.Direction = ParameterDirection.Input
                    param2.Value = (fecha2)
                    adaptador.SelectCommand.Parameters.Add(param1)
                    adaptador.SelectCommand.Parameters.Add(param2)
                    Dim dataset As New DataSet
                    adaptador.Fill(dataset)
                    dataset.DataSetName = "DataSet1"
                    Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                    datasource.Name = "DataSet1"
                    datasource.Value = dataset.Tables(0)
                    Dim p1 As New ReportParameter("Dia1", Fecha)
                    Dim p2 As New ReportParameter("Dia2", fecha2)
                    frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                    frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                    frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteVentasFechasCheque.rdlc"
                    frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
                    frmReportes.ReportViewer1.RefreshReport()
                    'End If
                    frmReportes.MdiParent = frmMenu
                    frmReportes.Show()
                    clase.Close()
                ElseIf (rbFechasTarjeta.Checked) Then
                    Fecha = DateFechasPago.Value.Year & "-" & DateFechasPago.Value.Month & "-" & DateFechasPago.Value.Day
                    fecha2 = DateFechasPago2.Value.Year & "-" & DateFechasPago2.Value.Month & "-" & DateFechasPago2.Value.Day
                    Dim clase As New SqlConnection(conexion)
                    clase.Open()
                    cmd = clase.CreateCommand
                    cmd.CommandText = "Reporte_VentasFechasDiaTarjeta"
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter()
                    adaptador.SelectCommand = New SqlCommand
                    adaptador.SelectCommand.Connection = clase
                    adaptador.SelectCommand.CommandText = "Reporte_VentasFechasDiaTarjeta"
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                    Dim param1 = New SqlParameter("@Fecha1", SqlDbType.Date)
                    Dim param2 = New SqlParameter("@Fecha2", SqlDbType.Date)
                    param1.Direction = ParameterDirection.Input
                    param1.Value = (Fecha)
                    param2.Direction = ParameterDirection.Input
                    param2.Value = (fecha2)
                    adaptador.SelectCommand.Parameters.Add(param1)
                    adaptador.SelectCommand.Parameters.Add(param2)
                    Dim dataset As New DataSet
                    adaptador.Fill(dataset)
                    dataset.DataSetName = "DataSet1"
                    Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                    datasource.Name = "DataSet1"
                    datasource.Value = dataset.Tables(0)
                    Dim p1 As New ReportParameter("Dia1", Fecha)
                    Dim p2 As New ReportParameter("Dia2", fecha2)
                    frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                    frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                    frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteVentasFechasTarjeta.rdlc"
                    frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
                    frmReportes.ReportViewer1.RefreshReport()
                    'End If
                    frmReportes.MdiParent = frmMenu
                    frmReportes.Show()
                    clase.Close()
                End If 'termina la decision de los tipos de pago
                '---------------------------------------Ventas por fechas por cajero --------------------------------------
            ElseIf rbVentasFechasCajero.Checked Then
                If (rbVentasFE.Checked) Then
                    ' Dim Fecha As String
                    empleado = ComboVentasFC.Text
                    Fecha = DateVentasFC.Value.Year & "-" & DateVentasFC.Value.Month & "-" & DateVentasFC.Value.Day
                    fecha2 = DateVentasFC2.Value.Year & "-" & DateVentasFC2.Value.Month & "-" & DateVentasFC2.Value.Day
                    Dim clase As New SqlConnection(conexion)
                    clase.Open()
                    cmd = clase.CreateCommand
                    cmd.CommandText = "Reporte_VentasFechasEfectivoCajeros"
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter()
                    adaptador.SelectCommand = New SqlCommand
                    adaptador.SelectCommand.Connection = clase
                    adaptador.SelectCommand.CommandText = "Reporte_VentasFechasEfectivoCajeros"
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                    Dim param1 = New SqlParameter("@Fecha1", SqlDbType.Date)
                    Dim param2 = New SqlParameter("@Fecha2", SqlDbType.Date)
                    Dim param3 = New SqlParameter("@Empleado", SqlDbType.Text)
                    param1.Direction = ParameterDirection.Input
                    param1.Value = (Fecha)
                    param2.Direction = ParameterDirection.Input
                    param2.Value = (fecha2)
                    param3.Direction = ParameterDirection.Input
                    param3.Value = (empleado)
                    adaptador.SelectCommand.Parameters.Add(param1)
                    adaptador.SelectCommand.Parameters.Add(param2)
                    adaptador.SelectCommand.Parameters.Add(param3)
                    Dim dataset As New DataSet
                    adaptador.Fill(dataset)
                    dataset.DataSetName = "DataSet1"
                    Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                    datasource.Name = "DataSet1"
                    datasource.Value = dataset.Tables(0)
                    Dim p1 As New ReportParameter("Empleado", empleado)
                    Dim p2 As New ReportParameter("Dia1", Fecha)
                    Dim p3 As New ReportParameter("Dia2", fecha2)
                    frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                    frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                    frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteVentasFechasEfectivoCajeros.rdlc"
                    frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3})
                    frmReportes.ReportViewer1.RefreshReport()
                    'End If
                    frmReportes.MdiParent = frmMenu
                    frmReportes.Show()
                    clase.Close()
                ElseIf (rbVentasFT.Checked) Then
                    ' Dim Fecha As String
                    empleado = ComboVentasFC.Text
                    Fecha = DateVentasFC.Value.Year & "-" & DateVentasFC.Value.Month & "-" & DateVentasFC.Value.Day
                    fecha2 = DateVentasFC2.Value.Year & "-" & DateVentasFC2.Value.Month & "-" & DateVentasFC2.Value.Day
                    Dim clase As New SqlConnection(conexion)
                    clase.Open()
                    cmd = clase.CreateCommand
                    cmd.CommandText = "Reporte_VentasFechasTarjetaCajeros"
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter()
                    adaptador.SelectCommand = New SqlCommand
                    adaptador.SelectCommand.Connection = clase
                    adaptador.SelectCommand.CommandText = "Reporte_VentasFechasTarjetaCajeros"
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                    Dim param1 = New SqlParameter("@Fecha1", SqlDbType.Date)
                    Dim param2 = New SqlParameter("@Fecha2", SqlDbType.Date)
                    Dim param3 = New SqlParameter("@Empleado", SqlDbType.Text)
                    param1.Direction = ParameterDirection.Input
                    param1.Value = (Fecha)
                    param2.Direction = ParameterDirection.Input
                    param2.Value = (fecha2)
                    param3.Direction = ParameterDirection.Input
                    param3.Value = (empleado)
                    adaptador.SelectCommand.Parameters.Add(param1)
                    adaptador.SelectCommand.Parameters.Add(param2)
                    adaptador.SelectCommand.Parameters.Add(param3)
                    Dim dataset As New DataSet
                    adaptador.Fill(dataset)
                    dataset.DataSetName = "DataSet1"
                    Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                    datasource.Name = "DataSet1"
                    datasource.Value = dataset.Tables(0)
                    Dim p1 As New ReportParameter("Empleado", empleado)
                    Dim p2 As New ReportParameter("Dia1", Fecha)
                    Dim p3 As New ReportParameter("Dia2", fecha2)
                    frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                    frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                    frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteVentasFechasTarjetaCajeros.rdlc"
                    frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3})
                    frmReportes.ReportViewer1.RefreshReport()
                    'End If
                    frmReportes.MdiParent = frmMenu
                    frmReportes.Show()
                    clase.Close()
                ElseIf (rbVentasFC.Checked) Then
                    empleado = ComboVentasFC.Text
                    Fecha = DateVentasFC.Value.Year & "-" & DateVentasFC.Value.Month & "-" & DateVentasFC.Value.Day
                    fecha2 = DateVentasFC2.Value.Year & "-" & DateVentasFC2.Value.Month & "-" & DateVentasFC2.Value.Day
                    Dim clase As New SqlConnection(conexion)
                    clase.Open()
                    cmd = clase.CreateCommand
                    cmd.CommandText = "Reporte_VentasFechasChequeCajeros"
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim adaptador As New SqlDataAdapter()
                    adaptador.SelectCommand = New SqlCommand
                    adaptador.SelectCommand.Connection = clase
                    adaptador.SelectCommand.CommandText = "Reporte_VentasFechasChequeCajeros"
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                    Dim param1 = New SqlParameter("@Fecha1", SqlDbType.Date)
                    Dim param2 = New SqlParameter("@Fecha2", SqlDbType.Date)
                    Dim param3 = New SqlParameter("@Empleado", SqlDbType.Text)
                    param1.Direction = ParameterDirection.Input
                    param1.Value = (Fecha)
                    param2.Direction = ParameterDirection.Input
                    param2.Value = (fecha2)
                    param3.Direction = ParameterDirection.Input
                    param3.Value = (empleado)
                    adaptador.SelectCommand.Parameters.Add(param1)
                    adaptador.SelectCommand.Parameters.Add(param2)
                    adaptador.SelectCommand.Parameters.Add(param3)
                    Dim dataset As New DataSet
                    adaptador.Fill(dataset)
                    dataset.DataSetName = "DataSet1"
                    Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                    datasource.Name = "DataSet1"
                    datasource.Value = dataset.Tables(0)
                    Dim p1 As New ReportParameter("Empleado", empleado)
                    Dim p2 As New ReportParameter("Dia1", Fecha)
                    Dim p3 As New ReportParameter("Dia2", fecha2)
                    frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                    frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                    frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteVentasFechasChequeCajeros.rdlc"
                    frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3})
                    frmReportes.ReportViewer1.RefreshReport()
                    'End If
                    frmReportes.MdiParent = frmMenu
                    frmReportes.Show()
                    clase.Close()
                End If 'decision de termino de fechas dia
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Reportes de Ventas", "Error al crear el reporte", Err.Number, cadena)
        End Try
    End Sub

    Private Sub rbFormaPago_CheckedChanged(sender As Object, e As EventArgs) Handles rbFormaPago.CheckedChanged
        If rbFormaPago.Checked Then
            PanelVentasDia.Enabled = False
            PanelFormasPago.Enabled = True
            GroupCajeroDia.Enabled = False
            panelVentasFechas.Enabled = False
            panelFechasPago.Enabled = False
            panelVentasFC.Enabled = False
        End If
    End Sub

    Private Sub rbCajeroDia_CheckedChanged(sender As Object, e As EventArgs) Handles rbCajeroDia.CheckedChanged
        If rbCajeroDia.Checked Then
            GroupCajeroDia.Enabled = True
            PanelVentasDia.Enabled = False
            PanelFormasPago.Enabled = False
            panelVentasFechas.Enabled = False
            panelFechasPago.Enabled = False
            panelVentasFC.Enabled = False
        End If
    End Sub

    Private Sub rbVentasFechas_CheckedChanged(sender As Object, e As EventArgs) Handles rbVentasFechas.CheckedChanged
        If rbVentasFechas.Checked Then
            panelVentasFechas.Enabled = True
            PanelVentasDia.Enabled = False
            PanelFormasPago.Enabled = False
            GroupCajeroDia.Enabled = False
            panelFechasPago.Enabled = False
            panelVentasFC.Enabled = False
        End If
    End Sub

    Private Sub rbVentasFechasPago_CheckedChanged(sender As Object, e As EventArgs) Handles rbVentasFechasPago.CheckedChanged
        If rbVentasFechasPago.Checked Then
            panelFechasPago.Enabled = True
            PanelVentasDia.Enabled = False
            PanelFormasPago.Enabled = False
            GroupCajeroDia.Enabled = False
            panelVentasFechas.Enabled = False
            panelVentasFC.Enabled = False
        End If
    End Sub

    Private Sub rbVentasFechasCajero_CheckedChanged(sender As Object, e As EventArgs) Handles rbVentasFechasCajero.CheckedChanged
        If rbVentasFechasCajero.Checked Then
            panelVentasFC.Enabled = True
            PanelVentasDia.Enabled = False
            PanelFormasPago.Enabled = False
            GroupCajeroDia.Enabled = False
            panelVentasFechas.Enabled = False
            panelFechasPago.Enabled = False
        End If
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
End Class