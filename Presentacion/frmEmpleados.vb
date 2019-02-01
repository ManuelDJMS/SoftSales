Imports System.Data.SqlClient
Public Class frmEmpleados
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt2 As New DataTable
    Dim dt3 As New DataTable
    Dim lector As SqlDataReader
    Dim cadena As String
    Dim actualizar As String

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip1.Active = True
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda"
        Me.ToolTip1.SetToolTip(Me.btnEditar, "Edita los datos del empleado")
        Me.ToolTip1.SetToolTip(Me.btGuardar, "Guarda los nuevos datos del empleado")
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Agrega un nuevo empleado")
        Me.ToolTip1.SetToolTip(Me.btActualizar, "Actualiza los datos del empleado")
        Me.ToolTip1.AutoPopDelay = 5000
        Dim clase As New SqlConnection(conexion)
        clase.Open()
        Try
            dt2 = New DataTable
            With cmd
                .Connection = clase
                .CommandText = "Select *from Empleados"
            End With
            da.SelectCommand = cmd
            da.Fill(dt2)
            'DataArticulos.DataSource = dt2
            DataEmpleados.DataSource = dt2
            Dim r2 As DataRow
            TxtApBuscar.AutoCompleteCustomSource.Clear()
            For Each r2 In dt2.Rows
                TxtApBuscar.AutoCompleteCustomSource.Add(r2.Item("nombre").ToString)
            Next
            'hgjhgghggjhhhhhhhhh
            dt2 = New DataTable
            With cmd
                .Connection = clase
                .CommandText = "Select *from vendedores"
            End With
            da.SelectCommand = cmd
            da.Fill(dt2)
            'DataArticulos.DataSource = dt2
            DataVendedores.DataSource = dt2
            Dim r1 As DataRow
            TextBuscarV.AutoCompleteCustomSource.Clear()
            For Each r1 In dt2.Rows
                TextBuscarV.AutoCompleteCustomSource.Add(r1.Item("nombre").ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Empleados", "Error al iniciar el formulario", Err.Number, cadena)
        End Try
        da.Dispose()
        lbregistros.Text = "Total de Empleados: " + Convert.ToString(DataEmpleados.Rows.Count - 1)
        LbBuscarV.Text = "Total de Vendedores: " + Convert.ToString(DataVendedores.Rows.Count - 1)
        clase.Close()
    End Sub

    Private Sub btnNuevo_MouseHover(sender As Object, e As EventArgs) Handles btnNuevo.MouseHover
        btnNuevo.Size = New Size(126, 38)
    End Sub

    Private Sub btnNuevo_MouseLeave(sender As Object, e As EventArgs) Handles btnNuevo.MouseLeave
        btnNuevo.Size = New Size(123, 35)
    End Sub

    Private Sub btnEditar_MouseHover(sender As Object, e As EventArgs) Handles btnEditar.MouseHover
        btnEditar.Size = New Size(126, 38)
    End Sub

    Private Sub btnEditar_MouseLeave(sender As Object, e As EventArgs) Handles btnEditar.MouseLeave
        btnEditar.Size = New Size(123, 35)
    End Sub

    Private Sub btGuardar_MouseHover(sender As Object, e As EventArgs) Handles btGuardar.MouseHover
        btGuardar.Size = New Size(126, 38)
    End Sub

    Private Sub btGuardar_MouseLeave(sender As Object, e As EventArgs) Handles btGuardar.MouseLeave
        btGuardar.Size = New Size(123, 35)
    End Sub

    Private Sub btSalir_MouseHover(sender As Object, e As EventArgs) Handles btSalir.MouseHover
        btSalir.Size = New Size(126, 38)
    End Sub

    Private Sub btSalir_MouseLeave(sender As Object, e As EventArgs) Handles btSalir.MouseLeave
        btSalir.Size = New Size(123, 35)
    End Sub
    Private Sub TxtApBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtApBuscar.TextChanged
        Dim clase As New SqlConnection(conexion)
        Try
            clase.Open()
            dt2 = New DataTable
            With cmd
                .Connection = clase
                .CommandText = "Select *from Empleados where nombre like '" & TxtApBuscar.Text & "%'"
            End With
            da.SelectCommand = cmd
            da.Fill(dt2)
            DataEmpleados.DataSource = dt2
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Empleados", "Error al buscar un empleado", Err.Number, cadena)
        End Try
        da.Dispose()
        clase.Close()
        lbregistros.Text = "Total de Empleados: " + Convert.ToString(DataEmpleados.Rows.Count - 1)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Dim clase As New SqlConnection(conexion)
            clase.Open()
            cmd = clase.CreateCommand
            limpiarCampos1(GroupPanel1)
            'placeholder
            TxtNombre.Text = "Ap Paterno Ap Materno Nombre(s)"
            TxtNombre.ForeColor = Color.Gray
            '----
            TxtidEmpleado.Enabled = False
            TxtTelefono.Clear()
            TxtCelular.Clear()
            btnEditar.Enabled = False
            btSalir.Enabled = False
            btGuardar.Enabled = True
            TextPass.Text = "No aplica"
            TextUsuario.Text = "No aplica"
            TextPass.Visible = False
            TextUsuario.Text = "0"
            TextComision.Visible = False
            TextUsuario.Visible = False
            LbCOntra.Visible = False
            LbUsuario.Visible = False
            ComboHorario.Visible = True
            comboTE.Visible = True
            TxtTelefono.Enabled = True
            TxtCelular.Enabled = True
            Dim r As String
            r = "select count(*) from Empleados"
            cmd.CommandText = r
            Dim N As Integer
            N = cmd.ExecuteScalar + 1
            TxtidEmpleado.Text = N
            DataEmpleados.Enabled = False
            TxtApBuscar.Enabled = False
            'Folio del vendedor
            r = "select count(*) from vendedores"
            cmd.CommandText = r
            N = cmd.ExecuteScalar + 1
            TextFolioVen.Text = N
            DataVendedores.Enabled = False
            TextBuscarV.Enabled = False
            clase.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Empleados", "Error al presionar NUEVO", Err.Number, cadena)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        btActualizar.Visible = True
        btActualizar.Enabled = True
        TxtDomicilio.ForeColor = Color.Black
        TxtNombre.ForeColor = Color.Black
        TextNum.ForeColor = Color.Black
        ComboHorario.Enabled = True
        comboTE.Enabled = False
        habCampos(GroupPanel1)
        TxtNombre.Enabled = False
    End Sub

    Private Sub DataEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataEmpleados.CellDoubleClick
        Try
            actualizar = "otros"
            btnEditar.Enabled = True
            ComboHorario.Enabled = False
            comboTE.Enabled = False
            TxtDomicilio.ForeColor = Color.Black
            TxtNombre.ForeColor = Color.Black
            lbComision.Visible = False
            TextComision.Enabled = False
            TextComision.Visible = False
            Dim Cadena As String = DataEmpleados.SelectedCells.Item(2).Value
            Dim ArrCadena As String() = Cadena.Split("#")
            If (DataEmpleados.SelectedCells.Item(9).Value = "Cajero(a)") Then
                'btnEditar.Enabled = True
                TextUsuario.Visible = True
                LbUsuario.Visible = True
                TextPass.Visible = True
                LbCOntra.Visible = True
                TxtidEmpleado.Text = DataEmpleados.SelectedCells.Item(0).Value
                TxtNombre.Text = DataEmpleados.SelectedCells.Item(1).Value
                TxtDomicilio.Text = ArrCadena(0)
                TextNum.Text = "#" + ArrCadena(1)
                TxtColonia.Text = DataEmpleados.SelectedCells.Item(3).Value
                TxtCP.Text = DataEmpleados.SelectedCells.Item(4).Value
                TxtTelefono.Text = DataEmpleados.SelectedCells.Item(5).Value
                TxtCelular.Text = DataEmpleados.SelectedCells.Item(6).Value
                TextPass.Text = DataEmpleados.SelectedCells.Item(8).Value
                TextUsuario.Text = DataEmpleados.SelectedCells.Item(7).Value
                comboTE.Text = DataEmpleados.SelectedCells.Item(9).Value
                ComboHorario.Text = DataEmpleados.SelectedCells.Item(10).Value
            Else
                TextUsuario.Visible = False
                LbUsuario.Visible = False
                TextPass.Visible = False
                LbCOntra.Visible = False
                TxtidEmpleado.Text = DataEmpleados.SelectedCells.Item(0).Value
                TxtNombre.Text = DataEmpleados.SelectedCells.Item(1).Value
                TxtDomicilio.Text = ArrCadena(0)
                TextNum.Text = "#" + ArrCadena(1)
                TxtColonia.Text = DataEmpleados.SelectedCells.Item(3).Value
                TxtCP.Text = DataEmpleados.SelectedCells.Item(4).Value
                TxtTelefono.Text = DataEmpleados.SelectedCells.Item(5).Value
                TxtCelular.Text = DataEmpleados.SelectedCells.Item(6).Value
                TextPass.Text = DataEmpleados.SelectedCells.Item(8).Value
                TextUsuario.Text = DataEmpleados.SelectedCells.Item(7).Value
                comboTE.Text = DataEmpleados.SelectedCells.Item(9).Value
                ComboHorario.Text = DataEmpleados.SelectedCells.Item(10).Value
            End If
        Catch ex As Exception
            MsgBox("Selecciona a un empleado", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        If (Me.ValidateChildren = True And TxtColonia.Text <> "" And TxtCP.Text <> "" And TxtCelular.Text <> "" And comboTE.Text <> "" And TextPass.Text <> "" And TextUsuario.Text <> "" And TextNum.Text <> "") Then
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
                    Dim direccion As String
                    direccion = TxtDomicilio.Text + " #" + TextNum.Text
                    Dim r As String
                    If (comboTE.Text = "Vendedor(a)") Then
                        r = "insert into vendedores (idvendedor, nombre, direccion, colonia, cp, telefono, celular, horario, comision) values (" & Val(TextFolioVen.Text) & ",'" & TxtNombre.Text & "','" & direccion & "','" & TxtColonia.Text & "','" & TxtCP.Text & "','" & TxtTelefono.Text & "','" & TxtCelular.Text & "','" & ComboHorario.Text & "','" & CDbl(TextComision.Text) & "')"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                    Else
                        r = "insert into empleados (idempleado, nombre, direccion, colonia, cp, telefono, celular, usuario, contrasena, tipoempleado, horario) values (" & Val(TxtidEmpleado.Text) & ",'" & TxtNombre.Text & "','" & direccion & "','" & TxtColonia.Text & "','" & TxtCP.Text & "','" & TxtTelefono.Text & "','" & TxtCelular.Text & "','" & TextUsuario.Text & "','" & TextPass.Text & "','" & comboTE.Text & "','" & ComboHorario.Text & "')"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                    End If
                    Try
                        '------------------------------------Transaccion----------------------------------------------
                        If MessageBox.Show("¿Desea Guardar los Datos?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                            transaction.Commit()
                            MsgBox("El empleado se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                            limpiarCampos1(GroupPanel1)
                            deshaCampos(GroupPanel1)
                            btSalir.Enabled = True
                            TextPass.Text = "No aplica"
                            TextUsuario.Text = "No aplica"
                            TextPass.Visible = False
                            TextUsuario.Visible = False
                            TextComision.Text = "0"
                            TextComision.Visible = False
                            LbCOntra.Visible = False
                            LbUsuario.Visible = False
                            comboTE.Enabled = False
                            ComboHorario.Enabled = False
                            TxtTelefono.Enabled = False
                            TxtCelular.Enabled = False
                            TxtTelefono.Clear()
                            TxtCelular.Clear()
                            TxtApBuscar.Enabled = True

                            TxtNombre.Text = "Ap Paterno Ap Materno Nombre(s)"
                            TxtNombre.ForeColor = Color.Gray

                            If (comboTE.SelectedItem.ToString = "Vendedor(a)") Then
                                dt2 = New DataTable
                                With cmd
                                    .Connection = cnn
                                    .CommandText = "Select *from vendedores"
                                End With
                                da.SelectCommand = cmd
                                da.Fill(dt2)
                                DataVendedores.DataSource = dt2

                                LbBuscarV.Text = "Total de Vendedores: " + Convert.ToString(DataVendedores.Rows.Count - 1)
                            Else
                                'Si fue vendedor:
                                dt2 = New DataTable
                                With cmd
                                    .Connection = cnn
                                    .CommandText = "Select *from empleados"
                                End With
                                da.SelectCommand = cmd
                                da.Fill(dt2)
                                DataEmpleados.DataSource = dt2

                                lbregistros.Text = "Total de Empleados: " + Convert.ToString(DataEmpleados.Rows.Count - 1)
                            End If
                            DataEmpleados.Enabled = True
                            DataVendedores.Enabled = True
                        Else
                            transaction.Rollback()
                            MsgBox("Datos Cancelados", MsgBoxStyle.Critical, "Guardado Cancelado")
                            btGuardar.Enabled = True
                            btSalir.Enabled = False
                            limpiarCampos1(GroupPanel1)
                            deshaCampos(GroupPanel1)
                            TxtTelefono.Clear()
                            TxtCelular.Clear()
                            TxtTelefono.Enabled = False
                            TxtCelular.Enabled = False
                            comboTE.Enabled = False
                            ComboHorario.Enabled = False
                            DataEmpleados.Enabled = True
                            TxtApBuscar.Enabled = True
                            'placeholder

                            TxtNombre.Text = "Ap Paterno Ap Materno Nombre(s)"
                            TxtNombre.ForeColor = Color.Gray

                        End If

                    Catch ex As Exception
                        MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error del Sistema")
                        Try
                            transaction.Rollback()
                        Catch ex1 As Exception
                            MsgBox("Error RollBack", MsgBoxStyle.Critical, "Error del Sistema")
                        End Try
                    End Try
                End Using
                cnn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
                cadena = Err.Description
                cadena = cadena.Replace("'", "")
                Bitacora("Empleados", "Error al guardar el empleado", Err.Number, cadena)
            End Try
            Me.Refresh()
        Else
            MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btActualizar_MouseHover(sender As Object, e As EventArgs) Handles btActualizar.MouseHover
        btActualizar.Size = New Size(126, 38)
    End Sub

    Private Sub btActualizar_MouseLeave(sender As Object, e As EventArgs) Handles btActualizar.MouseLeave
        btActualizar.Size = New Size(123, 35)
    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        If (Me.ValidateChildren = True And TxtColonia.Text <> "" And TxtCP.Text <> "" And TxtCelular.Text <> "" And comboTE.Text <> "" And TextPass.Text <> "" And TextUsuario.Text <> "" And TextNum.Text <> "") Then
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
                    Dim direccion As String
                    direccion = TxtDomicilio.Text + " #" + TextNum.Text
                    Dim r As String
                    If (actualizar = "vendedor") Then
                        r = "update vendedores set direccion='" & direccion & "', colonia='" & TxtColonia.Text & "', cp='" & TxtCP.Text & "', telefono='" & TxtTelefono.Text & "', celular='" & TxtCelular.Text & "', horario='" & ComboHorario.Text & "', comision=" & CDbl(TextComision.Text) & " where idvendedor=" & Val(TextFolioVen.Text)
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                    Else
                        r = "update empleados set direccion='" & direccion & "', colonia='" & TxtColonia.Text & "', cp='" & TxtCP.Text & "', telefono='" & TxtTelefono.Text & "', celular='" & TxtCelular.Text & "', usuario='" & TextUsuario.Text & "', contrasena='" & TextPass.Text & "', horario='" & ComboHorario.Text & "' where idempleado='" & TxtidEmpleado.Text & "'"
                        cmd.CommandText = r
                        cmd.ExecuteNonQuery()
                    End If

                    Try
                        '------------------------------------Transaccion----------------------------------------------
                        If MessageBox.Show("¿Desea Actualizar los Datos?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                            transaction.Commit()
                            MsgBox("El empleado se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                            limpiarCampos1(GroupPanel1)
                            deshaCampos(GroupPanel1)
                            btSalir.Enabled = True
                            TextPass.Text = "No aplica"
                            TextUsuario.Text = "No aplica"
                            TextPass.Visible = False
                            TextUsuario.Visible = False
                            TextComision.Text = "0"
                            TextComision.Visible = False
                            LbCOntra.Visible = False
                            LbUsuario.Visible = False
                            comboTE.Enabled = False
                            ComboHorario.Enabled = False
                            TxtTelefono.Enabled = False
                            TxtCelular.Enabled = False
                            TxtTelefono.Clear()
                            TxtCelular.Clear()
                            TxtApBuscar.Enabled = True

                            TxtNombre.Text = "Ap Paterno Ap Materno Nombre(s)"
                            TxtNombre.ForeColor = Color.Gray

                            If (comboTE.SelectedItem.ToString = "Vendedor(a)") Then
                                dt2 = New DataTable
                                With cmd
                                    .Connection = cnn
                                    .CommandText = "Select *from vendedores"
                                End With
                                da.SelectCommand = cmd
                                da.Fill(dt2)
                                DataVendedores.DataSource = dt2

                                LbBuscarV.Text = "Total de Vendedores: " + Convert.ToString(DataVendedores.Rows.Count - 1)
                            Else
                                'Si fue vendedor:
                                dt2 = New DataTable
                                With cmd
                                    .Connection = cnn
                                    .CommandText = "Select *from empleados"
                                End With
                                da.SelectCommand = cmd
                                da.Fill(dt2)
                                DataEmpleados.DataSource = dt2

                                lbregistros.Text = "Total de Empleados: " + Convert.ToString(DataEmpleados.Rows.Count - 1)
                            End If
                            DataEmpleados.Enabled = True
                            DataVendedores.Enabled = True
                        Else
                            transaction.Rollback()
                            MsgBox("Datos Cancelados", MsgBoxStyle.Critical, "Guardado Cancelado")
                            btGuardar.Enabled = True
                            btSalir.Enabled = False
                            limpiarCampos1(GroupPanel1)
                            deshaCampos(GroupPanel1)
                            TxtTelefono.Clear()
                            TxtCelular.Clear()
                            TxtTelefono.Enabled = False
                            TxtCelular.Enabled = False
                            comboTE.Enabled = False
                            ComboHorario.Enabled = False
                            DataEmpleados.Enabled = True
                            TxtApBuscar.Enabled = True
                            'placeholder

                            TxtNombre.Text = "Ap Paterno Ap Materno Nombre(s)"
                            TxtNombre.ForeColor = Color.Gray

                        End If
                    Catch ex As Exception
                        MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error del Sistema")
                        Try
                            transaction.Rollback()
                        Catch ex1 As Exception
                            MsgBox("Error RollBack", MsgBoxStyle.Critical, "Error del Sistema")
                        End Try
                    End Try
                End Using
                cnn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
                cadena = Err.Description
                cadena = cadena.Replace("'", "")
                Bitacora("Empleados", "Error al guardar el empleado", Err.Number, cadena)
            End Try
            Me.Refresh()
        Else
            MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TxtNombre_GotFocus(sender As Object, e As EventArgs) Handles TxtNombre.GotFocus
        If (TxtNombre.Text = "Ap Paterno Ap Materno Nombre(s)" Or TxtNombre.Text = "") Then
            TxtNombre.ForeColor = Color.Black
            TxtNombre.Text = ""
        End If
    End Sub

    Private Sub TxtNombre_LostFocus(sender As Object, e As EventArgs) Handles TxtNombre.LostFocus
        If (TxtNombre.Text = Nothing) Then
            TxtNombre.ForeColor = Color.Gray
            TxtNombre.Text = "Ap Paterno Ap Materno Nombre(s)"
        End If
    End Sub

    Private Sub TxtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca el nombre del cliente")
        End If
    End Sub

    Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TxtDomicilio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtDomicilio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca la dirección del cliente")
        End If
    End Sub
    Private Sub TextNum_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextNum.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca el número de domicilio del cliente")
        End If
    End Sub

    Private Sub TxtColonia_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtColonia.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca la colonia del cliente")
        End If
    End Sub

    Private Sub TxtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCP.KeyPress
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

    Private Sub TxtCP_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtCP.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca el código postal del cliente")
        End If
    End Sub

    Private Sub TxtCelular_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtCelular.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 8 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca un número de teléfono")
        End If
    End Sub

    Private Sub comboTE_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles comboTE.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca el tipo de empleado")
        End If
    End Sub

    Private Sub ComboHorario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboHorario.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca el horario que trabajará el empleado")
        End If
    End Sub

    Private Sub TextUsuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextUsuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca una Nombre de Usuario")
        End If
    End Sub

    Private Sub TextPass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextPass.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca una contraseña")
        End If
    End Sub

    Private Sub comboTE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTE.SelectedIndexChanged
        Try
        If comboTE.SelectedItem.ToString = ("Cajero(a)") Then
            TextPass.Text = ""
            TextUsuario.Text = ""
            TextPass.Visible = True
            TextUsuario.Visible = True
            LbCOntra.Visible = True
            LbUsuario.Visible = True
            TextComision.Visible = False
            TextComision.Enabled = False
            lbComision.Visible = False
        ElseIf comboTE.SelectedItem.ToString = ("Vendedor(a)") Then
            TextComision.Visible = True
            TextComision.Enabled = True
            TextPass.Text = "No aplica"
            TextUsuario.Text = "No aplica"
            TextPass.Visible = False
            TextUsuario.Visible = False
            LbCOntra.Visible = False
            LbUsuario.Visible = False
            lbComision.Visible = True
        Else
            TextPass.Text = "No aplica"
            TextUsuario.Text = "No aplica"
            TextPass.Visible = False
            TextUsuario.Visible = False
            LbCOntra.Visible = False
            LbUsuario.Visible = False
            TextComision.Visible = False
            TextComision.Enabled = False
            lbComision.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Empleados", "Error al seleccionar el tipo de Empleado", Err.Number, cadena)
        End Try
    End Sub

    Private Sub TextComision_Validated(sender As Object, e As EventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca el valor de la comisión del vendedor")
        End If
    End Sub

    Private Sub DataVendedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataVendedores.CellDoubleClick
        Try
            btnEditar.Enabled = True
            ComboHorario.Enabled = False
            comboTE.Enabled = False
            TxtDomicilio.ForeColor = Color.Black
            TxtNombre.ForeColor = Color.Black
            TextNum.ForeColor = Color.Black
            lbComision.Visible = True
            TextComision.Visible = True
            TextComision.Enabled = False
            deshaCampos(GroupPanel1)
            TextUsuario.Visible = False
            LbUsuario.Visible = False
            TextPass.Visible = False
            LbCOntra.Visible = False
            actualizar = "vendedor"
            TextFolioVen.Text = DataVendedores.SelectedCells.Item(0).Value
            TxtNombre.Text = DataVendedores.SelectedCells.Item(1).Value
            TxtDomicilio.Text = DataVendedores.SelectedCells.Item(2).Value
            TxtColonia.Text = DataVendedores.SelectedCells.Item(3).Value
            TxtCP.Text = DataVendedores.SelectedCells.Item(4).Value
            TxtTelefono.Text = DataVendedores.SelectedCells.Item(5).Value
            TxtCelular.Text = DataVendedores.SelectedCells.Item(6).Value
            comboTE.Text = "Vendedor(a)"
            ComboHorario.Text = DataVendedores.SelectedCells.Item(7).Value
            TextComision.Text = DataVendedores.SelectedCells.Item(8).Value
        Catch ex As Exception
            MsgBox("Selecciona a un empleado", MsgBoxStyle.Critical, "Error en el Sistema")
        End Try
    End Sub

    Private Sub TextComision_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TextComision.KeyPress
        NumerosyDecimal(TextComision, e)
    End Sub
End Class