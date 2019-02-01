Imports System.Data.SqlClient
Public Class frmAutorizacion
    Dim cadena As String
    Private Sub frmAutorizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.ToolTip1.Active = True
            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
            Me.ToolTip1.ToolTipTitle = "Ayuda"
            Me.ToolTip1.SetToolTip(Me.btAceptar, "Ingresa al Sistema")
            Me.ToolTip1.SetToolTip(Me.btncerrar, "Salir a la pantalla principal")
            Me.ToolTip1.AutoPopDelay = 5000
            Timer1.Start()
            lblFecha.Text = DateTime.Now.ToLongDateString()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Autorizacion", "Error al iniciar el formulario", Err.Number, cadena)
        End Try
    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        If Me.ValidateChildren = True And TextUser.Text <> "" And TextPass.Text <> "" Then
            Try
                Using conexion1 As New SqlConnection(conexion)
                    conexion1.Open()
                    Dim transaction As SqlTransaction
                    transaction = conexion1.BeginTransaction("Sample")
                    Dim comando As SqlCommand = conexion1.CreateCommand()
                    Dim lector As SqlDataReader
                    comando.Connection = conexion1
                    comando.Transaction = transaction
                    Dim r As String = "select idempleado, usuario, contrasena, tipoempleado from empleados where usuario= " & "'" & TextUser.Text & "'"
                    comando.CommandText = r
                    lector = comando.ExecuteReader()
                    lector.Read()
                    usuario = lector(0)
                    If TextUser.Text = lector(1) And TextPass.Text = lector(2) Then
                        If lector(3) = "Admin" Then
                            idEmpleado = lector(0)
                            lector.Close()
                            If autorizacion = "DescuentoGlobal" Then
                                Dim totaldescuento As Decimal
                                Dim ttart As Integer
                                Dim total As Decimal
                                Dim grantotal As Decimal
                                Dim descuentog As Decimal
                                descuentog = Convert.ToDecimal(frmVentas.TextDGlobal.Text)
                                'Aqui tu codigo a ejecutar
                                For Each fila In frmVentas.DataVentas.Rows
                                    ttart += Convert.ToDecimal(fila.Cells("CantidadData").Value)
                                    total += Convert.ToDecimal(fila.Cells("TotalData").Value)
                                Next
                                totaldescuento = (total * descuentog) / 100
                                frmVentas.TextDexcuento.Text = Convert.ToString(totaldescuento)
                                grantotal = total - totaldescuento
                                frmVentas.TextSubtotal.Text = Convert.ToString(grantotal)
                                frmVentas.TextGranT.Text = Convert.ToString(grantotal)
                                frmVentas.Enabled = True
                            Else
                                'Decision para el departamento oferta
                                If (frmOfertas.rbDepto.Checked) Then
                                    r = "insert into Ofertas (idempleado, FechaOferta, Aplica, Valor, Descripcion, Estado) values (" & Val(idEmpleado) & ", GETDATE()" & ",'" & frmOfertas.rbDepto.Text & "','" & frmOfertas.ComboDepto.Text & "','" & frmOfertas.TextDescricion.Text & "', 'Activa')"
                                    comando.CommandText = r
                                    comando.ExecuteNonQuery()
                                    r = "update articulos set descuento=" & CDbl(descuento) & " where departamento='" & frmOfertas.ComboDepto.Text & "'"
                                    comando.CommandText = r
                                    comando.ExecuteNonQuery()
                                    r = "update articulos set precioventa=(precioventa-((precioventa*descuento)/100)) where departamento='" & frmOfertas.ComboDepto.Text & "'"
                                    comando.CommandText = r
                                    comando.ExecuteNonQuery()
                                    'Decision para la marca
                                ElseIf (frmOfertas.rbTipo.Checked) Then
                                    r = "insert into Ofertas (idempleado, FechaOferta, Aplica, Valor, Descripcion, Estado) values (" & Val(idEmpleado) & ", GETDATE()" & ",'" & frmOfertas.rbTipo.Text & "','" & frmOfertas.ComboMarca.Text & "','" & frmOfertas.TextDescricion.Text & "', 'Activa')"
                                    comando.CommandText = r
                                    comando.ExecuteNonQuery()
                                    r = "update articulos set descuento=" & CDbl(descuento) & " where marca='" & frmOfertas.ComboMarca.Text & "'"
                                    comando.CommandText = r
                                    comando.ExecuteNonQuery()
                                    r = "update articulos set precioventa=(precioventa-((precioventa*descuento)/100)) where marca='" & frmOfertas.ComboMarca.Text & "'"
                                    comando.CommandText = r
                                    comando.ExecuteNonQuery()
                                    'Desicion por departamento y marca
                                ElseIf (frmOfertas.rbMD.Checked) Then
                                    r = "insert into Ofertas (idempleado, FechaOferta, Aplica, Valor, Descripcion, Estado) values (" & Val(idEmpleado) & ", GETDATE()" & ",'" & frmOfertas.rbMD.Text & "','" & frmOfertas.comboMDmarca.Text + " " + frmOfertas.ComboMDdepto.Text & "','" & frmOfertas.TextDescricion.Text & "', 'Activa')"
                                    comando.CommandText = r
                                    comando.ExecuteNonQuery()
                                    r = "update articulos set descuento=" & CDbl(descuento) & " where departamento='" & frmOfertas.ComboMDdepto.Text & "' and marca='" & frmOfertas.comboMDmarca.Text & "'"
                                    comando.CommandText = r
                                    comando.ExecuteNonQuery()
                                    r = "update articulos set precioventa=(precioventa-((precioventa*descuento)/100)) where departamento='" & frmOfertas.ComboMDdepto.Text & "' and marca='" & frmOfertas.comboMDmarca.Text & "'"

                                    comando.CommandText = r
                                    comando.ExecuteNonQuery()
                                    'Desicion por si fue individual
                                Else
                                    r = "insert into Ofertas (idempleado, FechaOferta, Aplica, Valor, Descripcion, Estado) values (" & Val(idEmpleado) & ", GETDATE()" & ",'" & frmOfertas.rbIndividual.Text & "','" & frmOfertas.TextIndividual.Text & "','" & frmOfertas.TextDescricion.Text & "', 'Activa')"

                                    comando.CommandText = r
                                    comando.ExecuteNonQuery()
                                    r = "update articulos set descuento=" & CDbl(descuento) & " where codigo_barras='" & frmOfertas.TextIndividual.Text & "'"
                                    comando.CommandText = r
                                    comando.ExecuteNonQuery()
                                    r = "update articulos set precioventa=(precioventa-((precioventa*descuento)/100)) where codigo_barras='" & frmOfertas.TextIndividual.Text & "'"
                                    comando.CommandText = r
                                    comando.ExecuteNonQuery()
                                End If
                            End If 'aqui termina la decision de que autorizacion fue la que se ocupo
                        Else
                            MsgBox("Usted no es administrador", MsgBoxStyle.Critical, "Ofertas")
                            Me.Close()
                        End If 'termina decision de si es administrador o no
                        '------------------------------------------------
                        Try
                            If MessageBox.Show("¿Desea Autorizar los movimientos?", "Autorización", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                frmOfertas.Enabled = True
                                MsgBox("El movimiento se efectuó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                                transaction.Commit()
                                frmOfertas.ComboDepto.Text = ""
                                frmOfertas.ComboMarca.Text = ""
                                frmOfertas.TextIndividual.Text = ""
                                frmOfertas.ComboOferta.Text = ""
                                frmOfertas.TextDescricion.Text = ""
                                frmOfertas.panelOferta.Enabled = False
                                frmOfertas.btAceptar.Enabled = True
                                frmOfertas.btNuevo.Enabled = False
                                frmOfertas.ComboOferta.Enabled = False
                                frmOfertas.TextIndividual.Enabled = False
                                'Limpio mi formulario de ventas
                                'textMonto.Clear()

                                Me.Close()
                            Else
                                transaction.Rollback()
                                MsgBox("Oferta Cancelada", MsgBoxStyle.Critical, "Guardado Cancelado")
                                frmOfertas.ComboDepto.Text = ""
                                frmOfertas.ComboMarca.Text = ""
                                frmOfertas.TextIndividual.Text = ""
                                frmOfertas.ComboOferta.Text = ""
                                frmOfertas.TextDescricion.Text = ""
                                frmOfertas.panelOferta.Enabled = False
                                frmOfertas.btAceptar.Enabled = True
                                frmOfertas.btNuevo.Enabled = False
                                frmOfertas.ComboOferta.Enabled = False
                                frmOfertas.TextIndividual.Enabled = False
                                'Limpio mi formulario de ventas
                                'textMonto.Clear()
                                frmOfertas.Enabled = True
                                Me.Close()
                            End If
                        Catch ex As Exception
                            MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error externo al Sistema")
                            Try
                                transaction.Rollback()
                            Catch ex1 As Exception
                                MsgBox("Error RollBack", MsgBoxStyle.Critical, "Error interno del Sistema")
                            End Try
                        End Try
                    Else
                        MsgBox("Contraseña incorrecta", MsgBoxStyle.Information)
                        TextPass.Clear()
                    End If
                    conexion1.Close()
                End Using
            Catch ex As Exception
                MsgBox("El nombre de Usuario o el artículo no existen", MsgBoxStyle.Critical, "Datos Incorrectos")
                Me.Refresh()
                TextPass.Clear()
                TextUser.Clear()
            End Try
        Else
            MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        MsgBox("Oferta Cancelada", MsgBoxStyle.Critical)
        frmOfertas.ComboDepto.Text = ""
        frmOfertas.ComboMarca.Text = ""
        frmOfertas.TextIndividual.Text = ""
        frmOfertas.ComboOferta.Text = ""
        frmOfertas.TextDescricion.Text = ""
        frmOfertas.panelOferta.Enabled = False
        frmOfertas.btAceptar.Enabled = True
        frmOfertas.btNuevo.Enabled = False
        frmOfertas.ComboOferta.Enabled = False
        frmOfertas.TextIndividual.Enabled = False
        'Limpio mi formulario de ventas
        'textMonto.Clear()
        frmOfertas.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub TextUsuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextPass.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca el Nombre de Usuario que autorizará la Oferta")
        End If
    End Sub

    Private Sub TextPass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextUser.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca la contraseña")
        End If
    End Sub

    Private Sub TextPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TextPass.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If Me.ValidateChildren = True And TextUser.Text <> "" And TextPass.Text <> "" Then
                    Try
                        Using conexion1 As New SqlConnection(conexion)
                            conexion1.Open()
                            Dim transaction As SqlTransaction
                            transaction = conexion1.BeginTransaction("Sample")
                            Dim comando As SqlCommand = conexion1.CreateCommand()
                            Dim lector As SqlDataReader
                            comando.Connection = conexion1
                            comando.Transaction = transaction
                            Dim r As String = "select idempleado, usuario, contrasena, tipoempleado from empleados where usuario= " & "'" & TextUser.Text & "'"
                            comando.CommandText = r
                            lector = comando.ExecuteReader()
                            lector.Read()
                            usuario = lector(0)
                            If TextUser.Text = lector(1) And TextPass.Text = lector(2) And lector(3) = "Admin" Then
                                If lector(3) = "Admin" Then
                                    idEmpleado = lector(0)
                                    lector.Close()
                                    If autorizacion = "DescuentoGlobal" Then
                                        Dim totaldescuento As Decimal
                                        Dim ttart As Integer
                                        Dim total As Decimal
                                        Dim grantotal As Decimal
                                        Dim descuentog As Decimal
                                        descuentog = Convert.ToDecimal(frmVentas.TextDGlobal.Text)
                                        'Aqui tu codigo a ejecutar
                                        For Each fila In frmVentas.DataVentas.Rows
                                            ttart += Convert.ToDecimal(fila.Cells("CantidadData").Value)
                                            total += Convert.ToDecimal(fila.Cells("TotalData").Value)
                                        Next
                                        totaldescuento = (total * descuentog) / 100
                                        frmVentas.TextDexcuento.Text = Convert.ToString(totaldescuento)
                                        grantotal = total - totaldescuento
                                        frmVentas.TextSubtotal.Text = Convert.ToString(grantotal)
                                        frmVentas.TextGranT.Text = Convert.ToString(grantotal)
                                        frmVentas.Enabled = True
                                    Else
                                        'Decision para el departamento oferta
                                        If (frmOfertas.rbDepto.Checked) Then
                                            r = "insert into Ofertas (idempleado, FechaOferta, Aplica, Valor, Descripcion, Estado) values (" & Val(idEmpleado) & ", GETDATE()" & ",'" & frmOfertas.rbDepto.Text & "','" & frmOfertas.ComboDepto.Text & "','" & frmOfertas.TextDescricion.Text & "', 'Activa')"
                                            comando.CommandText = r
                                            comando.ExecuteNonQuery()
                                            r = "update articulos set descuento=" & CDbl(descuento) & " where departamento='" & frmOfertas.ComboDepto.Text & "'"
                                            comando.CommandText = r
                                            comando.ExecuteNonQuery()
                                            r = "update articulos set precioventa=(precioventa-((precioventa*descuento)/100)) where departamento='" & frmOfertas.ComboDepto.Text & "'"
                                            comando.CommandText = r
                                            comando.ExecuteNonQuery()
                                            'Decision para la marca
                                        ElseIf (frmOfertas.rbTipo.Checked) Then
                                            r = "insert into Ofertas (idempleado, FechaOferta, Aplica, Valor, Descripcion, Estado) values (" & Val(idEmpleado) & ", GETDATE()" & ",'" & frmOfertas.rbTipo.Text & "','" & frmOfertas.ComboMarca.Text & "','" & frmOfertas.TextDescricion.Text & "', 'Activa')"
                                            comando.CommandText = r
                                            comando.ExecuteNonQuery()
                                            r = "update articulos set descuento=" & CDbl(descuento) & " where marca='" & frmOfertas.ComboMarca.Text & "'"
                                            comando.CommandText = r
                                            comando.ExecuteNonQuery()
                                            r = "update articulos set precioventa=(precioventa-((precioventa*descuento)/100)) where marca='" & frmOfertas.ComboMarca.Text & "'"
                                            comando.CommandText = r
                                            comando.ExecuteNonQuery()
                                            'Desicion por departamento y marca
                                        ElseIf (frmOfertas.rbMD.Checked) Then
                                            r = "insert into Ofertas (idempleado, FechaOferta, Aplica, Valor, Descripcion, Estado) values (" & Val(idEmpleado) & ", GETDATE()" & ",'" & frmOfertas.rbMD.Text & "','" & frmOfertas.comboMDmarca.Text + " " + frmOfertas.ComboMDdepto.Text & "','" & frmOfertas.TextDescricion.Text & "', 'Activa')"
                                            comando.CommandText = r
                                            comando.ExecuteNonQuery()
                                            r = "update articulos set descuento=" & CDbl(descuento) & " where departamento='" & frmOfertas.ComboMDdepto.Text & "' and marca='" & frmOfertas.comboMDmarca.Text & "'"
                                            comando.CommandText = r
                                            comando.ExecuteNonQuery()
                                            r = "update articulos set precioventa=(precioventa-((precioventa*descuento)/100)) where departamento='" & frmOfertas.ComboMDdepto.Text & "' and marca='" & frmOfertas.comboMDmarca.Text & "'"

                                            comando.CommandText = r
                                            comando.ExecuteNonQuery()
                                            'Desicion por si fue individual
                                        Else
                                            r = "insert into Ofertas (idempleado, FechaOferta, Aplica, Valor, Descripcion, Estado) values (" & Val(idEmpleado) & ", GETDATE()" & ",'" & frmOfertas.rbIndividual.Text & "','" & frmOfertas.TextIndividual.Text & "','" & frmOfertas.TextDescricion.Text & "', 'Activa')"
                                            comando.CommandText = r
                                            comando.ExecuteNonQuery()
                                            r = "update articulos set descuento=" & CDbl(descuento) & " where codigo_barras='" & frmOfertas.TextIndividual.Text & "'"
                                            comando.CommandText = r
                                            comando.ExecuteNonQuery()
                                            r = "update articulos set precioventa=(precioventa-((precioventa*descuento)/100)) where codigo_barras='" & frmOfertas.TextIndividual.Text & "'"
                                            comando.CommandText = r
                                            comando.ExecuteNonQuery()
                                        End If
                                    End If
                                Else
                                    MsgBox("Usted no es administrador", MsgBoxStyle.Critical, "Ofertas")
                                    Me.Close()
                                End If

                                Try
                                    If MessageBox.Show("¿Desea Autorizar los movimientos?", "Autorización", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                        frmOfertas.Enabled = True
                                        MsgBox("El movimiento se efectuó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                                        transaction.Commit()
                                        frmOfertas.ComboDepto.Text = ""
                                        frmOfertas.ComboMarca.Text = ""
                                        frmOfertas.TextIndividual.Text = ""
                                        frmOfertas.ComboOferta.Text = ""
                                        frmOfertas.TextDescricion.Text = ""
                                        frmOfertas.panelOferta.Enabled = False
                                        frmOfertas.btAceptar.Enabled = True
                                        frmOfertas.btNuevo.Enabled = False
                                        frmOfertas.ComboOferta.Enabled = False
                                        frmOfertas.TextIndividual.Enabled = False
                                        'Limpio mi formulario de ventas
                                        'textMonto.Clear()

                                        Me.Close()
                                    Else
                                        transaction.Rollback()
                                        MsgBox("Oferta Cancelada", MsgBoxStyle.Critical, "Guardado Cancelado")
                                        frmOfertas.ComboDepto.Text = ""
                                        frmOfertas.ComboMarca.Text = ""
                                        frmOfertas.TextIndividual.Text = ""
                                        frmOfertas.ComboOferta.Text = ""
                                        frmOfertas.TextDescricion.Text = ""
                                        frmOfertas.panelOferta.Enabled = False
                                        frmOfertas.btAceptar.Enabled = True
                                        frmOfertas.btNuevo.Enabled = False
                                        frmOfertas.ComboOferta.Enabled = False
                                        frmOfertas.TextIndividual.Enabled = False
                                        'Limpio mi formulario de ventas
                                        'textMonto.Clear()
                                        frmOfertas.Enabled = True
                                        Me.Close()
                                    End If
                                Catch ex As Exception
                                    MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error externo al Sistema")
                                    Try
                                        transaction.Rollback()
                                Catch ex1 As Exception
                                        MsgBox("Error RollBack", MsgBoxStyle.Critical, "Error interno del Sistema")
                                    End Try
                                End Try
                            Else
                                MsgBox("Contraseña incorrecta", MsgBoxStyle.Information)
                                TextPass.Clear()
                            End If
                            conexion1.Close()
                        End Using

                    Catch ex As Exception
                        MsgBox("El nombre de Usuario o el artículo no existen", MsgBoxStyle.Critical, "Datos Incorrectos")
                        Me.Refresh()
                        TextPass.Clear()
                        TextUser.Clear()
                    End Try
                Else
                    MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
    End Sub

    Private Sub btAceptar_MouseHover(sender As Object, e As EventArgs) Handles btAceptar.MouseHover
        btAceptar.Size = New Size(68, 64)
    End Sub

    Private Sub btAceptar_MouseLeave(sender As Object, e As EventArgs) Handles btAceptar.MouseLeave
        btAceptar.Size = New Size(65, 61)
    End Sub
End Class