Imports System.Data.SqlClient
Public Class Inicio

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Timer1.Start()
        PictureBox1.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        imgRoberto.Left -= 7
        lbIniciar.Left -= 7
        PanelImagen.Left -= 7
        Label1.Hide()
        If (imgRoberto.Left <= 90) Then
            lbIniciar.Left = 77
            PanelImagen.Left = -10
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        btaceptar.Top -= 3
        btcancelar.Top -= 3
        If (btaceptar.Top <= 326) Then
            Timer2.Stop()
            Timer3.Start()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Panel1.Top -= 3
        If (Panel1.Top <= 253) Then
            Timer3.Stop()
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        lbsecond.Text = DateTime.Now.ToString("ss")
        lbhora.Text = DateTime.Now.ToString("hh:mm tt")
        CircularProgressBar1.Value = Convert.ToInt32(lbsecond.Text)
    End Sub

    Private Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btcancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btaceptar_Click(sender As Object, e As EventArgs) Handles btaceptar.Click
        If Me.ValidateChildren = True And TextPass.Text <> "" And TextUsuario.Text <> "" Then
            Try
                Using conexion1 As New SqlConnection(conexion)
                    conexion1.Open()
                    Dim transaction As SqlTransaction
                    transaction = conexion1.BeginTransaction("Sample")
                    Dim comando As SqlCommand = conexion1.CreateCommand()
                    Dim lector As SqlDataReader
                    comando.Connection = conexion1
                    comando.Transaction = transaction
                    Dim r As String = "select idempleado, usuario, contrasena, tipoempleado from empleados where usuario= " & "'" & TextUsuario.Text & "'"
                    comando.CommandText = r
                    lector = comando.ExecuteReader()
                    lector.Read()
                    usuario = lector(0)
                    If TextUsuario.Text = lector(1) And TextPass.Text = lector(2) Then
                        If lector(3) = "Cajero(a)" Then
                            nombreusuario = lector(1)
                            idEmpleado = lector(0)
                            lector.Close()
                            MsgBox("Usuario Correcto, BIENVENIDO", MsgBoxStyle.Information)
                            frmMenu.btInicio.Text = nombreusuario
                            frmCaja.Show()
                            conexion1.Close()
                            Me.Close()

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
                            Me.Dispose()
                            conexion1.Close()
                        End If
                    Else
                        MsgBox("Contraseña incorrecta", MsgBoxStyle.Information)
                        TextPass.Clear()
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Datos incorrectos", MsgBoxStyle.Critical)

                Me.Refresh()
                TextPass.Clear()
                TextUsuario.Clear()
            End Try
        End If

    End Sub

    Private Sub TextUsuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca nombre de Usuario")
        End If
    End Sub

    Private Sub TextPass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca su contraseña")
        End If
    End Sub
End Class
