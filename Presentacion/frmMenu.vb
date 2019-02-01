Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmMenu
    Dim comando As SqlCommand
    Dim lector As SqlDataAdapter
    Dim cadena As String
    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        frmEmpleados.Close()
        frmConsultaVenta.Close()
        frmVentas.Close()
        frmOfertas.Close()
        frmReportes.Close()
        frmReportesVentas.Close()
        frmDepto.Close()
        frmConsultaBit.Close()
        'abro mi form
        frmArticulos.MdiParent = Me
        frmArticulos.Show()
    End Sub
    Private Sub btOfertas_Click(sender As Object, e As EventArgs) Handles btOfertas.Click
        frmEmpleados.Close()
        frmConsultaVenta.Close()
        frmVentas.Close()
        frmArticulos.Close()
        frmReportes.Close()
        frmReportesVentas.Close()
        frmDepto.Close()
        frmConsultaBit.Close()
        frmOfertas.MdiParent = Me
        frmOfertas.Show()
    End Sub

    Private Sub btEmpleados_Click(sender As Object, e As EventArgs) Handles btEmpleados.Click
        frmArticulos.Close()
        frmConsultaVenta.Close()
        frmVentas.Close()
        frmOfertas.Close()
        frmReportes.Close()
        frmReportesVentas.Close()
        frmDepto.Close()
        frmConsultaBit.Close()
        frmEmpleados.MdiParent = Me
        frmEmpleados.Show()
    End Sub

    Private Sub btVentas_Click(sender As Object, e As EventArgs) Handles btVentas.Click
        frmEmpleados.Close()
        frmConsultaVenta.Close()
        frmArticulos.Close()
        frmOfertas.Close()
        frmReportes.Close()
        frmReportesVentas.Close()
        frmDepto.Close()
        frmConsultaBit.Close()
        frmVentas.MdiParent = Me
        frmVentas.Show()
    End Sub

    Private Sub btRespalsar_Click(sender As Object, e As EventArgs) Handles btRespalsar.Click
        If MessageBox.Show("¿Desea Respaldar la Base de Datos?", "Respaldo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

            cnn = New SqlConnection(conexion)
            Using cnn
                Dim Dir As String = ""
                'Abrimos un cuadro de Dialogo 
                Dim path As New SaveFileDialog
                'Ponemos la extension en que se va a almacenar
                path.Filter = "Archivo backup | *.bak"
                If path.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dir = CStr(path.FileName)
                End If
                ' Dim nombre As String = ("CafeBackUp")
                Dim Backup As String = "BACKUP DATABASE [SoftSales] TO  DISK = N'" & Dir & "' WITH NOFORMAT, NOINIT,  NAME = N'SoftSales-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
                Try
                    cnn.Open()
                    Dim command As SqlCommand = New SqlCommand(Backup, cnn)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Se ha creado un BackUp de La base de datos satisfactoria")
                    cnn.Close()
                Catch ex As Exception
                    MessageBox.Show("Error al copiar la base de datos")
                End Try
            End Using
        Else
            MsgBox("Se canceló el Respaldo", MsgBoxStyle.Information, "Respaldo Cancelado")
        End If
    End Sub
    Private Sub btConsultaV_Click(sender As Object, e As EventArgs) Handles btConsultaV.Click
        frmEmpleados.Close()
        frmArticulos.Close()
        frmVentas.Close()
        frmOfertas.Close()
        frmReportes.Close()
        frmReportesVentas.Close()
        frmDepto.Close()
        frmConsultaBit.Close()
        frmPreConsulta.Show()
    End Sub

    Private Sub btBitaco_Click(sender As Object, e As EventArgs) Handles btBitaco.Click
        frmEmpleados.Close()
        frmConsultaVenta.Close()
        frmVentas.Close()
        frmOfertas.Close()
        frmReportes.Close()
        frmReportesVentas.Close()
        frmDepto.Close()
        frmArticulos.Close()
        frmConsultaBit.MdiParent = Me
        frmConsultaBit.Show()
    End Sub
    Private Sub btArticulos_Click(sender As Object, e As EventArgs) Handles btArticulos.Click
        frmEmpleados.Close()
        frmConsultaVenta.Close()
        frmVentas.Close()
        frmOfertas.Close()
        frmArticulos.Close()
        frmReportesVentas.Close()
        frmDepto.Close()
        frmConsultaBit.Close()
        Try
            Dim clase As New SqlConnection(conexion)
            clase.Open()
            comando = clase.CreateCommand
            comando.CommandText = "Reporte_ArticulosCompleto"
            'Dim cmd As New SqlCommand("Reporte_Clientes", conexion)
            comando.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter(comando)
            Dim data As New DataSet
            adaptador.Fill(data)
            data.DataSetName = "DataSet1"
            Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(reportes)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteArticulosCompleto.rdlc"
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.MdiParent = Me
            frmReportes.Show()
            clase.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Menu principal", "Error al iniciar el reporte de articulos", Err.Number, cadena)
        End Try
    End Sub

    Private Sub btExistencia_Click(sender As Object, e As EventArgs) Handles btExistencia.Click
        frmEmpleados.Close()
        frmConsultaVenta.Close()
        frmVentas.Close()
        frmOfertas.Close()
        frmArticulos.Close()
        frmReportesVentas.Close()
        frmDepto.Close()
        frmConsultaBit.Close()
        Try
            Dim clase As New SqlConnection(conexion)
            clase.Open()
            comando = clase.CreateCommand
            comando.CommandText = "Reporte_ArticulosExistencia5"
            'Dim cmd As New SqlCommand("Reporte_Clientes", conexion)
            comando.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter(comando)
            Dim data As New DataSet
            adaptador.Fill(data)
            data.DataSetName = "DataSet1"
            Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(reportes)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\Report3.rdlc"
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.MdiParent = Me
            frmReportes.Show()
            clase.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Menu principal", "Error al iniciar el reporte de articulos por existencia", Err.Number, cadena)
        End Try
    End Sub

    Private Sub btDepartamento_Click(sender As Object, e As EventArgs) Handles btDepartamento.Click
        frmEmpleados.Close()
        frmConsultaVenta.Close()
        frmVentas.Close()
        frmOfertas.Close()
        frmReportes.Close()
        frmReportesVentas.Close()
        frmArticulos.Close()
        frmConsultaBit.Close()
        frmDepto.Show()
    End Sub

    Private Sub btVendedores_Click(sender As Object, e As EventArgs) Handles btVendedores.Click
        frmEmpleados.Close()
        frmConsultaVenta.Close()
        frmVentas.Close()
        frmOfertas.Close()
        frmArticulos.Close()
        frmReportesVentas.Close()
        frmDepto.Close()
        frmConsultaBit.Close()
        Try
            Dim clase As New SqlConnection(conexion)
            clase.Open()
            comando = clase.CreateCommand
            comando.CommandText = "Reporte_Vendedores"
            'Dim cmd As New SqlCommand("Reporte_Clientes", conexion)
            comando.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter(comando)
            Dim data As New DataSet
            adaptador.Fill(data)
            data.DataSetName = "DataSet1"
            Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(reportes)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteVendedores.rdlc"
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.MdiParent = Me
            frmReportes.Show()
            clase.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Menu principal", "Error al iniciar el reporte de vendedores", Err.Number, cadena)
        End Try
    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        frmArticulos.Close()
        frmConsultaVenta.Close()
        frmVentas.Close()
        frmOfertas.Close()
        frmReportes.Close()
        frmReportesVentas.Close()
        frmDepto.Close()
        frmConsultaBit.Close()
        Try
            Dim clase As New SqlConnection(conexion)
            clase.Open()
            comando = clase.CreateCommand
            comando.CommandText = "Reporte_Empleados"
            'Dim cmd As New SqlCommand("Reporte_Clientes", conexion)
            comando.CommandType = CommandType.StoredProcedure
            Dim adaptador As New SqlDataAdapter(comando)
            Dim data As New DataSet
            adaptador.Fill(data)
            data.DataSetName = "DataSet1"
            Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
            frmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            frmReportes.ReportViewer1.LocalReport.DataSources.Add(reportes)
            frmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\Report1.rdlc"
            frmReportes.ReportViewer1.RefreshReport()
            frmReportes.MdiParent = Me
            frmReportes.Show()
            clase.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Menu principal", "Error al iniciar el reporte de los empleados", Err.Number, cadena)
        End Try
    End Sub

    Private Sub btReportesVentas_Click(sender As Object, e As EventArgs) Handles btReportesVentas.Click
        frmEmpleados.Close()
        frmConsultaVenta.Close()
        frmVentas.Close()
        frmOfertas.Close()
        frmReportes.Close()
        frmArticulos.Close()
        frmDepto.Close()
        frmConsultaBit.Close()

        frmReportesVentas.MdiParent = Me
        frmReportesVentas.Show()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmCaja.Close()
    End Sub

    Private Sub btInicio_Click(sender As Object, e As EventArgs) Handles btInicio.Click

    End Sub

    Private Sub btCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        frmCorteCaja.Show()
        Me.Dispose()
    End Sub

    Private Sub frmMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If MessageBox.Show("No puedes salir del sistema hasta hacer el corte de Caja, ¿Desea realizarlo ahora? ", "Cerrar Sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            frmCorteCaja.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub btRestart_Click(sender As Object, e As EventArgs) Handles btRestart.Click
        If MessageBox.Show("¿Desea Restaurar la Base de Datos?", "Restaurar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            frmSesion.Close()
            cnn = New SqlConnection(conexionMaster)
            Using cnn
                Dim Dir As String = ""
                Dim path As New OpenFileDialog
                'Ponemos la extension en que se va a almacenar
                path.Filter = "Archivo backup | *.bak"
                If path.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dir = CStr(path.FileName)
                End If

                Dim BackUp As String = "RESTORE DATABASE SoftSales from  DISK = '" & Dir & "' WITH REPLACE"
                'Try
                cnn.Open()
                Dim command As SqlCommand = New SqlCommand(BackUp, cnn)
                command.ExecuteNonQuery()
                MessageBox.Show("Se ha restaurado el BackUp de La base de datos satisfactoria")
                cnn.Close()
                'Catch ex As Exception
                'MessageBox.Show("Error al restaurar la base de datos")
                cnn.Close()
                'End Try
            End Using
        Else
            MsgBox("Se canceló el Restaurar", MsgBoxStyle.Information, "Restaurar Cancelado")
        End If

    End Sub

    Private Sub btCancelarOf_Click(sender As Object, e As EventArgs) Handles btCancelarOf.Click
        frmCancelarOferta.MdiParent = Me
        frmCancelarOferta.Show()
    End Sub
End Class