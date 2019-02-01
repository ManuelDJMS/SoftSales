Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmCorteCaja
    Dim comando As SqlCommand
    Dim lector As SqlDataReader
    Dim cadena As String
    Private Sub frmCorteCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MsgBox(idEmpleado)
        Me.ToolTip1.Active = True
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda"
        Me.ToolTip1.SetToolTip(Me.btAceptar, "Guarda los datos del corte del Día de hoy")
        Me.ToolTip1.SetToolTip(Me.btCancelar, "Vuelve al menú principal")
        Me.ToolTip1.AutoPopDelay = 5000
        Dim clase As New SqlConnection(conexion)
        clase.Open()
        comando = clase.CreateCommand
        Dim Fecha As String
        Fecha = DateFecha.Value.Year & "-" & DateFecha.Value.Month & "-" & DateFecha.Value.Day
        Dim R As String
        '--------------------------------Importe de Efectivo Reportado por el Sistema--------------------------------
        Try
            R = "SELECT SUM(Importe) AS TotalMercancia FROM Ventas inner join DetallePago on Ventas.FolioVenta=DetallePago.FolioVenta inner join empleados on empleados.idempleado=ventas.idempleado inner join sesion on sesion.idempleado=empleado.idempleado where Referencia='EFECTIVO' and Fecha='" & Fecha & "' and sesion.idempleado=" & idsesion
            comando.CommandText = R
            lector = comando.ExecuteReader
            lector.Read()
            TextTES.Text = lector(0)
            lector.Close()
        Catch ex As Exception
            TextTES.Text = "0.0"
        End Try
        '--------------------------------Importe de Cheque Reportado por el Sistema--------------------------------
        Try
            R = "SELECT SUM(Importe) as TotalCheque from Ventas inner join DetallePago on Ventas.FolioVenta=DetallePago.FolioVenta where Referencia like 'C%' and Fecha='" & Fecha & "' and ventas.idempleado=" & usuario
            comando.CommandText = R
            lector = comando.ExecuteReader
            lector.Read()
            TextTCS.Text = lector(0)
            lector.Close()
        Catch ex As Exception
            TextTCS.Text = "0.0"
            lector.Close()
        End Try
        '--------------------------------Importe de Tarjeta Reportado por el Sistema--------------------------------
        Try
            R = "SELECT SUM(Importe) as TotalTarjeta from Ventas inner join DetallePago on Ventas.FolioVenta=DetallePago.FolioVenta where Referencia like 'T%' and Fecha='" & Fecha & "' and ventas.idempleado=" & usuario
            comando.CommandText = R
            lector = comando.ExecuteReader
            lector.Read()
            TextTTS.Text = lector(0)
            lector.Close()
        Catch ex As Exception
            TextTTS.Text = "0.0"
            lector.Close()
        End Try
        '--------------------------------Importe de Vales Reportado por el Sistema--------------------------------
        Try
            R = "SELECT SUM(Importe) as TotalTarjeta from Ventas inner join DetallePago on Ventas.FolioVenta=DetallePago.FolioVenta where Referencia like 'V%' and Fecha='" & Fecha & "' and ventas.idempleado=" & usuario
            comando.CommandText = R
            lector = comando.ExecuteReader
            lector.Read()
            TextValeSis.Text = lector(0)
            lector.Close()
        Catch ex As Exception
            TextValeSis.Text = "0.0"
            lector.Close()
        End Try
        '--------------------------------Primer folio del Dia--------------------------------
        Try
            R = "select top 1 FolioVenta from Ventas where Fecha='" & Fecha & "' and idempleado=" & usuario & " order by Consecutivo"
            comando.CommandText = R
            lector = comando.ExecuteReader
            lector.Read()
            TexxPrimerFolio.Text = lector(0)
            lector.Close()
        Catch ex As Exception
            TexxPrimerFolio.Text = "0.0"
            lector.Close()
        End Try
        '--------------------------------Primer ultimo del Dia--------------------------------
        Try
            R = "select top 1 FolioVenta from Ventas where Fecha='" & Fecha & "' and idempleado=" & usuario & " order by Consecutivo desc"
            comando.CommandText = R
            lector = comando.ExecuteReader
            lector.Read()
            TextUltFolio.Text = lector(0)
            lector.Close()
        Catch ex As Exception
            TextUltFolio.Text = "0.0"
            lector.Close()
        End Try

    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        'If Me.ValidateChildren = True And TextTotalCR.Text <> "" And TextTotalER.Text <> "" And TextTotalTR.Text <> "" Then
        Try
            Using conexion1 As New SqlConnection(conexion)
                conexion1.Open()
                Dim transaction As SqlTransaction
                transaction = conexion1.BeginTransaction("Sample")
                Dim comando As SqlCommand = conexion1.CreateCommand()
                comando.Connection = conexion1
                comando.Transaction = transaction
                Dim observaciones As String
                observaciones = TexxPrimerFolio.Text + "-" + TextUltFolio.Text
                Dim r As String
                r = "insert into CorteCaja (idSesion, FechaCierre, TotalEfectivoSis, TotalChequeSis, TotalTarjetaSis, TotalValeSis, Diferencia, Folios, Observaciones) values (" & Val(idsesion) & ", GETDATE(), " & CDbl(TextTES.Text) & "," & CDbl(TextTCS.Text) & "," & CDbl(TextTTS.Text) & "," & CDbl(TextValeSis.Text) & "," & CDbl(TextDiferencia.Text) & ",'" & observaciones & "','" & TextObservaciones.Text & "')"
                comando.CommandText = r
                comando.ExecuteNonQuery()
                Try
                    If MessageBox.Show("¿Desea Guardar los datos del corte de caja?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        transaction.Commit()
                        MsgBox("El corte de caja se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                        frmSesion.txtpass.Clear()
                        frmSesion.txtuser.Clear()
                        'Saco la fecha de cierre
                        r = "select top 1 idsesion from sesion where idempleado=" & Val(usuario) & " order by idsesion desc"
                        comando.CommandText = r
                        lector = comando.ExecuteReader()
                        lector.Read()
                        idsesion = lector(0)
                        lector.Close()

                        '----------------------------------Aqui se imprime el ticket-----------------------------------
                        'Dim pagoen As Integer
                        'pagoen = idsesion
                        Dim f1 As String
                        f1 = idsesion
                        Dim clase As New SqlConnection(conexion)
                        Dim cmd As New SqlCommand
                        clase.Open()
                        cmd = clase.CreateCommand
                        cmd.CommandText = "CortedeCaja"
                        cmd.CommandType = CommandType.StoredProcedure
                        Dim adaptador As New SqlDataAdapter()
                        adaptador.SelectCommand = New SqlCommand
                        adaptador.SelectCommand.Connection = clase
                        adaptador.SelectCommand.CommandText = "CortedeCaja"
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                        Dim param1 = New SqlParameter("@idSesion", SqlDbType.Int)
                        param1.Direction = ParameterDirection.Input
                        param1.Value = (f1)
                        adaptador.SelectCommand.Parameters.Add(param1)
                        Dim dataset As New DataSet
                        adaptador.Fill(dataset)
                        dataset.DataSetName = "DataSet1"
                        Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
                        datasource.Name = "DataSet1"
                        datasource.Value = dataset.Tables(0)
                        Dim p1 As New ReportParameter("idSesion", f1)
                        FrmCortedeCaja.ReportViewer1.LocalReport.DataSources.Clear()
                        FrmCortedeCaja.ReportViewer1.LocalReport.DataSources.Add(datasource)
                        FrmCortedeCaja.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\SoftSales\SoftSales\Reportes\ReporteCorteCaja.rdlc"
                        FrmCortedeCaja.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1})
                        FrmCortedeCaja.ReportViewer1.RefreshReport()
                        'End If
                        FrmCortedeCaja.Show()
                        clase.Close()
                        '------------------------------------------------------------------------------------------------
                        efectivo = Convert.ToDecimal(TextTES.Text)
                        tarjeta = Convert.ToDecimal(TextTTS.Text)
                        cheque = Convert.ToDecimal(TextTCS.Text)
                        gastos = Convert.ToDecimal(TextDiferencia.Text)
                        totalgeneral = efectivo + tarjeta + cheque - gastos

                        Me.Close()
                    Else
                        transaction.Rollback()
                        MsgBox("Datos Cancelados", MsgBoxStyle.Critical, "Guardado Cancelado")
                        frmMenu.btInicio.Text = nombreusuario
                        frmMenu.Show()
                        Me.Close()
                    End If
                Catch ex As Exception
                    MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error del Sistema")
                    Try
                        transaction.Rollback()
                    Catch ex1 As Exception
                        MsgBox("Error RollBack ", MsgBoxStyle.Critical, "Error del Sistema")
                    End Try
                End Try
                conexion1.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Corte de Caja", "Error a la hora de guardar", Err.Number, cadena)
        End Try
        Me.Refresh()
        'Else
        'MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' End If
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        frmMenu.btInicio.Text = nombreusuario
        frmMenu.Show()
        Me.Close()
    End Sub
    Private Sub TextObservaciones_GotFocus(sender As Object, e As EventArgs) Handles TextObservaciones.GotFocus
        If (TextObservaciones.Text = "Ninguna Observación" Or TextObservaciones.Text = "") Then
            TextObservaciones.ForeColor = Color.Black
            TextObservaciones.Text = ""
        End If
    End Sub

    Private Sub TextObservaciones_LostFocus(sender As Object, e As EventArgs) Handles TextObservaciones.LostFocus
        If (TextObservaciones.Text = Nothing) Then
            TextObservaciones.ForeColor = Color.Gray
            TextObservaciones.Text = "Ninguna Observación"
        End If
    End Sub
    Private Sub TextDiferencia_GotFocus(sender As Object, e As EventArgs) Handles TextDiferencia.GotFocus
        If (TextDiferencia.Text = "0" Or TextDiferencia.Text = "") Then
            TextDiferencia.ForeColor = Color.Black
            TextDiferencia.Text = ""
        End If
    End Sub

    Private Sub TextDiferencia_LostFocus(sender As Object, e As EventArgs) Handles TextDiferencia.LostFocus
        If (TextDiferencia.Text = Nothing) Then
            TextDiferencia.ForeColor = Color.Gray
            TextDiferencia.Text = "0"
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

    Private Sub DateFecha_ValueChanged(sender As Object, e As EventArgs) Handles DateFecha.ValueChanged

    End Sub

    Private Sub TextObservaciones_TextChanged(sender As Object, e As EventArgs) Handles TextObservaciones.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextDiferencia_TextChanged(sender As Object, e As EventArgs) Handles TextDiferencia.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class