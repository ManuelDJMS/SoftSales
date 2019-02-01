Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class frmCaja
    Dim cmd As SqlCommand
    Dim cadena As String
    Dim lector As SqlDataReader
    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        If Me.ValidateChildren = True And TextInicioimp.Text <> "" And ComboCaja.Text <> "" Then
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
                    caja = ComboCaja.Text
                    Fecha = frmVentas.TextFecha.Value.Year & "-" & frmVentas.TextFecha.Value.Month & "-" & frmVentas.TextFecha.Value.Day
                    If ComboCaja.Text = "Caja 1" Then
                        caja = "1"
                        r = "insert into sesion (idempleado, ncaja, fechaapertura, importeinicial) values (" & usuario & ",'1', GETDATE(), '" & TextInicioimp.Text & "')"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                    Else
                        caja = "2"
                        r = "insert into sesion (idempleado, ncaja, fechaapertura, importeinicial) values (" & usuario & ",'2', GETDATE(), '" & TextInicioimp.Text & "')"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                    End If
                    Try
                        '------------------------------------Transaccion----------------------------------------------
                        If MessageBox.Show("¿Desea Guardar los Datos?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                            transaction.Commit()
                            frmMenu.btInicio.Text = nombreusuario
                            frmMenu.RibbonUtilidades.Visible = False
                            r = "select top 1 idsesion from sesion where idempleado=" & usuario & " order by idsesion desc"
                            cmd.CommandText = r
                            lector = cmd.ExecuteReader()
                            lector.Read()
                            idsesion = lector(0)
                            lector.Close()
                            frmMenu.Show()

                        Else
                            transaction.Rollback()
                            MsgBox("Inicio de Sesión Cancelado", MsgBoxStyle.Critical)
                            frmSesion.txtuser.Clear()
                            frmSesion.txtpass.Clear()
                            frmSesion.Show()
                            Me.Close()
                        End If
                    Catch ex As Exception
                        MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error Externo al Sistema")
                        Try
                            transaction.Rollback()
                    Catch ex1 As Exception
                            MsgBox("Error RollBack", MsgBoxStyle.Critical, "Error Externo al Sistema")
                        End Try
                    End Try
                End Using
                cnn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
                cadena = Err.Description
                cadena = cadena.Replace("'", "")
                Bitacora("Caja", "Error al iniciar sesión de cajero", Err.Number, cadena)
            End Try
            Me.Refresh()
        Else
            MessageBox.Show("Faltan ingresar algunos datos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub frmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Me.ToolTip1.Active = True
            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
            Me.ToolTip1.ToolTipTitle = "Ayuda"
            Me.ToolTip1.SetToolTip(Me.pictureBox1, "Ingresa al Sistema")
            Me.ToolTip1.SetToolTip(Me.btnmin, "Minimiza el Sistema")
            Me.ToolTip1.SetToolTip(Me.btncerrar, "Salir a la pantalla principal")
            Me.ToolTip1.AutoPopDelay = 5000
            Timer1.Start()
            lblFecha.Text = DateTime.Now.ToLongDateString()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Caja", "Error al iniciar el formulario", Err.Number, cadena)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        frmSesion.txtuser.Clear()
        frmSesion.txtpass.Clear()
        frmSesion.Show()
        Me.Close()
    End Sub

    Private Sub ComboCaja_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboCaja.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Selecciona una Caja")
        End If
    End Sub

    Private Sub TextInicioimp_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextInicioimp.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca el importe Inicial")
        End If
    End Sub

    Private Sub TextInicioimp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextInicioimp.KeyPress
        NumerosyDecimal(TextInicioimp, e)
    End Sub

    Private Sub TextInicioimp_KeyDown(sender As Object, e As KeyEventArgs) Handles TextInicioimp.KeyDown
        Try

            Select Case e.KeyData
                Case Keys.Enter
                    If Me.ValidateChildren = True And TextInicioimp.Text <> "" And ComboCaja.Text <> "" Then
                        'Try
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
                            If ComboCaja.Text = "Caja 1" Then
                                caja = "1"
                                r = "insert into sesion (idempleado, ncaja, fechaapertura, importeinicial) values (" & usuario & ",'1', GETDATE(), '" & TextInicioimp.Text & "')"
                                cmd.CommandText = r
                                cmd.ExecuteNonQuery()
                            Else
                                caja = "2"
                                r = "insert into sesion (idempleado, ncaja, fechaapertura, importeinicial) values (" & usuario & ",'2', GETDATE(), '" & TextInicioimp.Text & "')"
                                cmd.CommandText = r
                                cmd.ExecuteNonQuery()
                            End If
                            Try
                                '------------------------------------Transaccion----------------------------------------------
                                If MessageBox.Show("¿Desea ingresar al sistema?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                    transaction.Commit()
                                    frmMenu.btInicio.Text = nombreusuario
                                    frmMenu.RibbonUtilidades.Visible = False
                                    r = "select top 1 idsesion from sesion where idempleado=" & usuario & " order by idsesion desc"
                                    cmd.CommandText = r
                                    lector = cmd.ExecuteReader()
                                    lector.Read()
                                    idsesion = lector(0)
                                    lector.Close()
                                    frmMenu.Show()
                                Else
                                    transaction.Rollback()
                                    MsgBox("Inicio de Sesión Cancelado", MsgBoxStyle.Critical)
                                    frmSesion.txtuser.Clear()
                                    frmSesion.txtpass.Clear()
                                    frmSesion.Show()
                                    Me.Close()
                                End If
                            Catch ex As Exception
                                MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error Externo al Sistema")
                                Try
                                    transaction.Rollback()
                                Catch ex1 As Exception
                                    MsgBox("Error RollBack", MsgBoxStyle.Critical, "Error Externo al Sistema")
                                End Try
                            End Try
                        End Using
                        cnn.Close()
                    Else
                        MessageBox.Show("Faltan ingresar algunos datos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Caja", "Error al iniciar precionar enter en la contraseña", Err.Number, cadena)
        End Try

    End Sub

    Private Sub pictureBox1_MouseHover(sender As Object, e As EventArgs) Handles pictureBox1.MouseHover
        pictureBox1.Size = New Size(68, 64)
    End Sub

    Private Sub pictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles pictureBox1.MouseLeave
        pictureBox1.Size = New Size(65, 61)
    End Sub
End Class