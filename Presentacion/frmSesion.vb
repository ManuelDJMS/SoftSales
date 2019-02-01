Imports System.Data.SqlClient
Public Class frmSesion
    Dim cadena As String
    Private Sub frmSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
        Me.ToolTip1.Active = True
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda"
        Me.ToolTip1.SetToolTip(Me.pictureBox1, "Ingresa al Sistema")
        Me.ToolTip1.SetToolTip(Me.btnmin, "Minimiza el Sistema")
        Me.ToolTip1.SetToolTip(Me.btncerrar, "Salir del Sistema")
        Me.ToolTip1.AutoPopDelay = 5000
        Dim desktopSize As Size = System.Windows.Forms.SystemInformation.PrimaryMonitorSize       'Captura el Tamaño del Monitor
        Dim alto As Int32 = (desktopSize.Height - 280) \ 2
        Dim ancho As Int32 = (desktopSize.Width - 500) \ 2
        panel1.Location = New Point(ancho, alto)
        Timer1.Start()
            lblFecha.Text = DateTime.Now.ToLongDateString()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Sesión", "Error al iniciar el formulario", Err.Number, cadena)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'lbsecond.Text = DateTime.Now.ToString("ss")
        lblHora.Text = DateTime.Now.ToString("hh:mm tt")
        'CircularProgressBar1.Value = Convert.ToInt32(lbsecond.Text)
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        If Me.ValidateChildren = True And txtpass.Text <> "" And txtuser.Text <> "" Then
            Try
                Using conexion1 As New SqlConnection(conexion)
                    conexion1.Open()
                    Dim transaction As SqlTransaction
                    transaction = conexion1.BeginTransaction("Sample")
                    Dim comando As SqlCommand = conexion1.CreateCommand()
                    Dim lector As SqlDataReader
                    comando.Connection = conexion1
                    comando.Transaction = transaction
                    Dim r As String = "select idempleado, usuario, contrasena, tipoempleado from empleados where usuario= " & "'" & txtuser.Text & "'"
                    comando.CommandText = r
                    lector = comando.ExecuteReader()
                    lector.Read()
                    usuario = lector(0)
                    'MsgBox(usuario)
                    If txtuser.Text = lector(1) And txtpass.Text = lector(2) Then
                        If lector(3) = "Cajero(a)" Then
                            nombreusuario = lector(1)
                            'idEmpleado = lector(0)
                            lector.Close()
                            MsgBox("Usuario Correcto, BIENVENIDO", MsgBoxStyle.Information)
                            frmMenu.btInicio.Text = nombreusuario
                            frmCaja.Show()
                            conexion1.Close()
                            Me.Hide()

                        ElseIf lector(3) = "Admin" Then
                            ' MsgBox(nombreusuario)
                            frmMenu.btInicio.Text = nombreusuario
                            lector.Close()
                            r = "insert into sesionadmin (idempleado, fechaapertura) values (" & usuario & ", GETDATE())"
                            comando.CommandText = r
                            comando.ExecuteNonQuery()
                            transaction.Commit()
                            ' MsgBox("Bienvenido Administrador", MsgBoxStyle.Information)

                            frmMenu.Show()
                            Me.Hide()
                            conexion1.Close()
                        End If
                    Else
                        MsgBox("Contraseña incorrecta", MsgBoxStyle.Information)
                        txtpass.Clear()
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Datos Incorrectos")
                cadena = Err.Description
                cadena = cadena.Replace("'", "")
                Bitacora("Sesión", "Error al iniciar el formulario", Err.Number, cadena)
                Me.Refresh()
                txtpass.Clear()
                txtuser.Clear()
            End Try
        Else
            MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub txtpass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpass.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    If Me.ValidateChildren = True And txtpass.Text <> "" And txtuser.Text <> "" Then
                        Using conexion1 As New SqlConnection(conexion)
                            conexion1.Open()
                            Dim transaction As SqlTransaction
                            transaction = conexion1.BeginTransaction("Sample")
                            Dim comando As SqlCommand = conexion1.CreateCommand()
                            Dim lector As SqlDataReader
                            comando.Connection = conexion1
                            comando.Transaction = transaction
                            Dim r As String = "select idempleado, usuario, contrasena, tipoempleado from empleados where usuario= " & "'" & txtuser.Text & "'"
                            comando.CommandText = r
                            lector = comando.ExecuteReader()
                            lector.Read()
                            usuario = lector(0)
                            'MsgBox(usuario)
                            If txtuser.Text = lector(1) And txtpass.Text = lector(2) Then
                                If lector(3) = "Admin" Then
                                        nombreusuario = lector(1)
                                    frmMenu.btInicio.Text = nombreusuario
                                    frmMenu.btID.Text = lector(0)
                                    usuario = lector(0)
                                    'MsgBox(usuario)
                                        lector.Close()
                                        r = "insert into sesionadmin (idempleado, fechaapertura) values (" & usuario & ", GETDATE())"
                                        comando.CommandText = r
                                        comando.ExecuteNonQuery()
                                    transaction.Commit()
                                    conexion1.Close()
                                        ' MsgBox("Bienvenido Administrador", MsgBoxStyle.Information)
                                        frmMenu.Show()
                                        Me.Hide()
                                        'conexion1.Close()
                                ElseIf lector(3) = "Cajero(a)" Then
                                    nombreusuario = lector(1)
                                    'idEmpleado = lector(0)
                                    lector.Close()
                                    MsgBox("Usuario Correcto, BIENVENIDO", MsgBoxStyle.Information)
                                    frmMenu.btInicio.Text = nombreusuario
                                    frmCaja.Show()
                                    conexion1.Close()
                                    Me.Hide()
                                    ' MsgBox(nombreusuario)
                                End If
                            Else
                                MsgBox("Contraseña incorrecta", MsgBoxStyle.Information)
                                txtpass.Clear()
                            End If
                        End Using

                    Else
                        MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Sesión", "Error al iniciar el formulario", Err.Number, cadena)
        End Try
    End Sub

    Private Sub txtuser_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtuser.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca un Nombre de Usuario")
        End If
    End Sub

    Private Sub txtpass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtpass.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca su Contraseña")
        End If
    End Sub
End Class