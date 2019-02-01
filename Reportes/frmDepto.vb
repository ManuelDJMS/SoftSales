Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmDepto
    Dim cmd As SqlCommand
    Dim lector As SqlDataReader
    Dim cadena As String
    Private Sub frmDepto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
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
            cmd.CommandText = "select distinct departamento from articulos"
            lector = cmd.ExecuteReader
            While lector.Read()
                ComboDepto.Items.Add(lector(0))
            End While
            lector.Close()

            cmd.CommandText = "select distinct marca from articulos"
            lector = cmd.ExecuteReader
            While lector.Read()
                ComboMarca.Items.Add(lector(0))
            End While
            lector.Close()
            clase.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Reportde de Marcas y Departamentos", "Error al iniciar el formulario", Err.Number, cadena)
        End Try
    End Sub
    Private Sub rbMarca_CheckedChanged(sender As Object, e As EventArgs) Handles rbMarca.CheckedChanged
        If (rbMarca.Checked) Then
            ComboMarca.Enabled = True
            ComboDepto.Enabled = False
        End If
    End Sub

    Private Sub rbDepto_CheckedChanged(sender As Object, e As EventArgs) Handles rbDepto.CheckedChanged
        If (rbDepto.Checked) Then
            ComboMarca.Enabled = False
            ComboDepto.Enabled = True
        End If
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        'Try
        If Me.ValidateChildren = True And ComboDepto.Text <> "" Or ComboMarca.Text <> "" Then
            If Not (ComboDepto.Text = "") Then
                Dim f1 As String
                f1 = ComboDepto.Text
                Dim clase As New SqlConnection(conexion)
                clase.Open()
                cmd = clase.CreateCommand
                cmd.CommandText = "Reporte_ArticulosDeptos"
                cmd.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter()
                adaptador.SelectCommand = New SqlCommand
                adaptador.SelectCommand.Connection = clase
                adaptador.SelectCommand.CommandText = "Reporte_ArticulosDeptos"
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim param1 = New SqlParameter("@Depto", SqlDbType.Text)
                param1.Direction = ParameterDirection.Input
                param1.Value = (f1)
                adaptador.SelectCommand.Parameters.Add(param1)
                Dim dataset As New DataSet
                adaptador.Fill(dataset)
                dataset.DataSetName = "DataSet1"
                Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                datasource.Name = "DataSet1"
                datasource.Value = dataset.Tables(0)
                Dim p1 As New ReportParameter("Departamento", f1)
                frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteArticulosXDepto.rdlc"
                frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1})
                frmReportes.ReportViewer1.RefreshReport()
                'End If
                frmReportes.MdiParent = frmMenu
                frmReportes.Show()
                clase.Close()

            ElseIf Not (ComboMarca.Text = "") Then
                Dim f1 As String
                f1 = ComboMarca.Text
                Dim clase As New SqlConnection(conexion)
                clase.Open()
                cmd = clase.CreateCommand
                cmd.CommandText = "Reporte_ArticulosMarca"
                cmd.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter()
                adaptador.SelectCommand = New SqlCommand
                adaptador.SelectCommand.Connection = clase
                adaptador.SelectCommand.CommandText = "Reporte_ArticulosMarca"
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim param1 = New SqlParameter("@Marca", SqlDbType.Text)
                param1.Direction = ParameterDirection.Input
                param1.Value = (f1)
                adaptador.SelectCommand.Parameters.Add(param1)
                Dim dataset As New DataSet
                adaptador.Fill(dataset)
                dataset.DataSetName = "DataSet1"
                Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                datasource.Name = "DataSet1"
                datasource.Value = dataset.Tables(0)
                Dim p1 As New ReportParameter("Marca", f1)
                frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
                frmReportes.ReportViewer1.LocalReport.DataSources.Add(datasource)
                frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteArticulosXMarca.rdlc"
                frmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1})
                frmReportes.ReportViewer1.RefreshReport()
                'End If
                frmReportes.MdiParent = frmMenu
                frmReportes.Show()
                clase.Close()
            End If
        Else
            MessageBox.Show("Falta seleccionar datos", "Error al abrir el Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'Catch ex As Exception
        'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        'cadena = Err.Description
        'cadena = cadena.Replace("'", "")
        'Bitacora("Reportes por Departamento y Marcas", "Error al crear el reporte", Err.Number, cadena)
        'End Try
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