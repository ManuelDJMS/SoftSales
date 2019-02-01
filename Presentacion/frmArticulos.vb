Imports System.Data.SqlClient
Public Class frmArticulos
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt2 As New DataTable
    Dim lector As SqlDataReader
    Dim cadena As String
    Private Sub frmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'SoftSalesDataSet.Reporte_Empleados' Puede moverla o quitarla según sea necesario.
        Try
            Me.ToolTip1.Active = True
            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
            Me.ToolTip1.ToolTipTitle = "Ayuda"
            Me.ToolTip1.SetToolTip(Me.btnEditar, "Edita los datos del articulo")
            Me.ToolTip1.SetToolTip(Me.btGuardar, "Guarda los nuevos datos del articulo")
            Me.ToolTip1.SetToolTip(Me.btnNuevo, "Agrega un nuevo articulo")
            Me.ToolTip1.SetToolTip(Me.btActualizar, "Actualiza los datos del articulo")
            Me.ToolTip1.SetToolTip(Me.btnImportar, "Importar un archivo de Exccel")
            Me.ToolTip1.SetToolTip(Me.btGuardarExc, "Guardar los datos de Excel")
            Me.ToolTip1.AutoPopDelay = 5000
            'Saco la variable de mi clase 
            ' Inicio.Close()

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
            dt2 = New DataTable
            With cmd
                .Connection = clase
                .CommandText = "Select *from articulos"
            End With
            da.SelectCommand = cmd
            da.Fill(dt2)
            DataGridViewX1.DataSource = dt2
            Dim r2 As DataRow
            TextBuscarArt.AutoCompleteCustomSource.Clear()
            For Each r2 In dt2.Rows
                TextBuscarArt.AutoCompleteCustomSource.Add(r2.Item("codigo_barras").ToString)
            Next
            clase.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Artículos", "Error al iniciar el formulario", Err.Number, cadena)
        End Try
        da.Dispose()
        lbarticulos.Text = "Total de Artículos: " + Convert.ToString(DataGridViewX1.Rows.Count - 1)
    End Sub

    Private Sub TextBuscarArt_TextChanged(sender As Object, e As EventArgs) Handles TextBuscarArt.TextChanged
        Dim clase As New SqlConnection(conexion)
        Try
            clase.Open()
            dt2 = New DataTable
            With cmd
                .Connection = clase
                .CommandText = "Select *from Articulos where codigo_barras like '" & TextBuscarArt.Text & "%'"
            End With
            da.SelectCommand = cmd
            da.Fill(dt2)
            DataGridViewX1.DataSource = dt2
            clase.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Artículos", "Error al buscar desde el Texbox", Err.Number, cadena)
        End Try
        da.Dispose()
        clase.Close()
        lbarticulos.Text = "Total de Artículos: " + Convert.ToString(DataGridViewX1.Rows.Count - 1)
    End Sub

    Private Sub DataGridViewX1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellDoubleClick
        Try
            btnEditar.Enabled = True
            TextCB.Text = DataGridViewX1.SelectedCells.Item(0).Value
            TextDescripcion.Text = DataGridViewX1.SelectedCells.Item(1).Value
            TextPrecioVenta.Text = DataGridViewX1.SelectedCells.Item(2).Value
            TextExist.Text = DataGridViewX1.SelectedCells.Item(3).Value
            TextModelo.Text = DataGridViewX1.SelectedCells.Item(4).Value
            TextTalla.Text = DataGridViewX1.SelectedCells.Item(5).Value
            ComboDepto.Text = DataGridViewX1.SelectedCells.Item(6).Value
            ComboMarca.Text = DataGridViewX1.SelectedCells.Item(7).Value
            'TextInpuesto.Text = DataGridViewX1.SelectedCells.Item(5).Value
            btGuardar.Enabled = False
        Catch ex As Exception
            MsgBox("Selecciona un artículo", MsgBoxStyle.Exclamation, "Error al seleccionar un artículo")
        End Try
    End Sub
    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Try
            '   DataGridViewX1.Enabled = False
            'DataGridViewX1.Rows.Clear()
            Dim myFileDialog As New OpenFileDialog()

            With myFileDialog
                .Filter = "Excel Files |*.xlsx"
                .Title = "Open File"
                .ShowDialog()
            End With
            Dim path As String = myFileDialog.FileName.ToString

            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim dataSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            'Dim path As String = "C:\Users\Manuel\Documents\Residencias\plantillaPlaza1.xlsx"

            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [prueba_excel$]", MyConnection)

            dataSet = New System.Data.DataSet
            MyCommand.Fill(dataSet)

            DataGridViewX1.DataSource = dataSet.Tables(0)
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Artículos", "Error importar un archivo de excel", Err.Number, cadena)
        End Try
    End Sub

    Private Sub btGuardarExc_Click(sender As Object, e As EventArgs) Handles btGuardarExc.Click
        Try
            Using conexion1 As New SqlConnection(conexion)
                conexion1.Open()
                Dim transaction As SqlTransaction
                transaction = conexion1.BeginTransaction("Sample")
                Dim comando As SqlCommand = conexion1.CreateCommand()
                comando.Connection = conexion1
                comando.Transaction = transaction
                Dim R As String
                Dim c1 As String
                Dim c2 As String
                Dim c3 As Decimal
                Dim c4 As Integer
                Dim c5 As String
                Dim c6 As String
                Dim c7 As String
                Dim c8 As String
                For I = 0 To DataGridViewX1.Rows.Count - 2
                    c1 = DataGridViewX1.Item(0, I).Value
                    c2 = DataGridViewX1.Item(1, I).Value
                    c3 = CDbl(DataGridViewX1.Item(2, I).Value)
                    c4 = Val(DataGridViewX1.Item(3, I).Value)
                    c5 = DataGridViewX1.Item(4, I).Value
                    c6 = DataGridViewX1.Item(5, I).Value
                    c7 = DataGridViewX1.Item(6, I).Value
                    c8 = DataGridViewX1.Item(7, I).Value
                    R = "if exists(select codigo_barras from articulos where codigo_barras='" & c1 & "') begin update articulos set existencia=existencia+" & c4 & " where codigo_barras='" & c1 & "'; end else begin insert into articulos(codigo_barras, descripcion, precioventa, existencia, modelo, talla, departamento, marca, descuento) values('" & c1 & "','" & c2 & "'," & c3 & "," & c4 & ",'" & c5 & "','" & c6 & "','" & c7 & "','" & c8 & "', 0.00" & "); end"
                    'MsgBox(R)
                    comando.CommandText = R
                    comando.ExecuteNonQuery()
                Next
                Try
                    If MessageBox.Show("¿Desea Guardar la lista de Artículos?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        dt2 = New DataTable
                        With comando
                            .Connection = conexion1
                            .CommandText = "Select *from Articulos"
                        End With
                        da.SelectCommand = comando
                        da.Fill(dt2)
                        DataGridViewX1.DataSource = dt2
                        transaction.Commit()
                        MsgBox("El artículo se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                        DataGridViewX1.Enabled = True
                        deshaCampos(GroupPanel1)
                        ComboDepto.Enabled = False
                        ComboMarca.Enabled = False
                        'Actualizar los combos
                        ComboDepto.Items.Clear()
                        ComboMarca.Items.Clear()
                        'comando.Connection = conexion1
                        comando.CommandText = "select distinct departamento from articulos"
                        lector = comando.ExecuteReader
                        While lector.Read()
                            ComboDepto.Items.Add(lector(0))
                        End While
                        lector.Close()
                        comando.CommandText = "select distinct marca from articulos"
                        lector = comando.ExecuteReader
                        While lector.Read()
                            ComboMarca.Items.Add(lector(0))
                        End While
                        lector.Close()
                        lbarticulos.Text = "Total de Artículos: " + Convert.ToString(DataGridViewX1.Rows.Count - 1)
                    Else
                        transaction.Rollback()
                        MsgBox("Datos Cancelados", MsgBoxStyle.Critical, "Guardado Cancelado")
                        deshaCampos(GroupPanel1)
                        btGuardar.Enabled = True
                        btSalir.Enabled = False
                        ComboDepto.Enabled = False
                        ComboMarca.Enabled = False
                        dt2 = New DataTable
                        With comando
                            .Connection = conexion1
                            .CommandText = "Select *from articulos"
                        End With
                        da.SelectCommand = comando
                        da.Fill(dt2)
                        DataGridViewX1.DataSource = dt2
                        DataGridViewX1.Enabled = True
                    End If
                Catch ex As Exception
                    MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error externo al Sistema")
                    Try
                        transaction.Rollback()
                Catch ex1 As Exception
                        MsgBox("Error RollBack", MsgBoxStyle.Critical, "Error interno del Sistema")
                    End Try
                End Try
                conexion1.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Artículos", "Error al guardar el archivo de excel", Err.Number, cadena)
        End Try
    End Sub

    Private Sub btnImportar_MouseHover(sender As Object, e As EventArgs) Handles btnImportar.MouseHover
        btnImportar.Size = New Size(126, 38)
    End Sub

    Private Sub btnImportar_MouseLeave(sender As Object, e As EventArgs) Handles btnImportar.MouseLeave
        btnImportar.Size = New Size(123, 35)
    End Sub

    Private Sub btGuardarExc_MouseHover(sender As Object, e As EventArgs) Handles btGuardarExc.MouseHover
        btGuardarExc.Size = New Size(126, 38)
    End Sub

    Private Sub btGuardarExc_MouseLeave(sender As Object, e As EventArgs) Handles btGuardarExc.MouseLeave
        btGuardarExc.Size = New Size(123, 35)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos1(GroupPanel1)
        'ComboDepto.DropDownStyle = ComboBoxStyle.DropDownList
        btGuardar.Enabled = True
        btnEditar.Enabled = False
        DataGridViewX1.Enabled = False
        ComboDepto.Enabled = True
        ComboMarca.Enabled = True
        btActualizar.Visible = False
        btGuardar.Visible = True
        TextBuscarArt.Enabled = False
        btnImportar.Enabled = False
        btGuardarExc.Enabled = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
        ComboDepto.Enabled = True
        ComboMarca.Enabled = True
        btGuardar.Visible = False
        btActualizar.Visible = True
        btActualizar.Enabled = True
            habCampos(GroupPanel1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Artículos", "Error en el botón Editar", Err.Number, cadena)
        End Try
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        If Me.ValidateChildren = True And TextCB.Text <> "" And ComboDepto.Text <> "" And ComboMarca.Text <> "" And TextDescripcion.Text <> "" And TextPrecioVenta.Text <> "" And TextModelo.Text <> "" Then
            Try
                Using conexion1 As New SqlConnection(conexion)
                    conexion1.Open()
                    Dim transaction As SqlTransaction
                    transaction = conexion1.BeginTransaction("Sample")
                    Dim comando As SqlCommand = conexion1.CreateCommand()
                    comando.Connection = conexion1
                    comando.Transaction = transaction
                    Dim r As String
                    r = "if exists(select codigo_barras from articulos where codigo_barras='" & TextCB.Text & "') begin update articulos set existencia=existencia+" & Val(TextExist.Text) & "where codigo_barras='" & TextCB.Text & "'; end else begin insert into articulos(codigo_barras, descripcion, precioventa, existencia, modelo, talla, departamento, marca, descuento) values('" & TextCB.Text & "','" & TextDescripcion.Text & "'," & CDbl(TextPrecioVenta.Text) & "," & Val(TextExist.Text) & ",'" & TextModelo.Text & "','" & TextTalla.Text & "','" & ComboDepto.Text & "','" & ComboMarca.Text & "', 0.00); end"
                    'r = "insert into articulos (codigo_barras, descripcion, precioventa, existencia, modelo, talla, departamento, marca, oferta) values ('" & TextCB.Text & "','" & TextDescripcion.Text & "'," & CDbl(TextPrecioVenta.Text) & "," & Val(TextExist.Text) & ",'" & TextModelo.Text & "','" & TextTalla.Text & "','" & ComboDepto.Text & "','" & ComboMarca.Text & "','Normal')"
                    ' MsgBox(r)
                    comando.CommandText = r
                    comando.ExecuteNonQuery()
                    Try
                        If MessageBox.Show("¿Desea Guardar los datos del Artículo?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                            dt2 = New DataTable
                            With comando
                                .Connection = conexion1
                                .CommandText = "Select *from articulos"
                            End With
                            da.SelectCommand = comando
                            da.Fill(dt2)
                            DataGridViewX1.DataSource = dt2
                            transaction.Commit()
                            MsgBox("El artículo se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                            DataGridViewX1.Enabled = True
                            limpiarCampos1(GroupPanel1)
                            deshaCampos(GroupPanel1)
                            ComboDepto.Enabled = False
                            ComboMarca.Enabled = False
                            ComboDepto.Text = ""
                            TextBuscarArt.Enabled = True
                            ComboMarca.Text = ""
                            btGuardarExc.Enabled = True
                            btnImportar.Enabled = True
                            btSalir.Enabled = True
                            'Actualizar los combos
                            ComboDepto.Items.Clear()
                            ComboMarca.Items.Clear()
                            comando.CommandText = "select distinct departamento from articulos"
                            lector = comando.ExecuteReader
                            While lector.Read()
                                ComboDepto.Items.Add(lector(0))
                            End While
                            lector.Close()
                            comando.CommandText = "select distinct marca from articulos"
                            lector = comando.ExecuteReader
                            While lector.Read()
                                ComboMarca.Items.Add(lector(0))
                            End While
                            lector.Close()
                            lbarticulos.Text = "Total de Artículos: " + Convert.ToString(DataGridViewX1.Rows.Count - 1)

                        Else
                            transaction.Rollback()
                            MsgBox("Datos Cancelados", MsgBoxStyle.Critical, "Guardado Cancelado")
                            btGuardar.Enabled = True
                            btSalir.Enabled = False
                            'limpiarCampos1(GroupPanel1)
                            deshaCampos(GroupPanel1)
                            ComboDepto.Enabled = True
                            btGuardarExc.Enabled = True
                            btnImportar.Enabled = True
                            ComboDepto.Enabled = False
                            ComboMarca.Enabled = False
                            ComboDepto.Text = ""
                            TextBuscarArt.Enabled = True
                            ComboMarca.Text = ""
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
                Bitacora("Articulos", "Error a la hora de guardar el registro", Err.Number, cadena)
            End Try
            Me.Refresh()
        Else
            MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        If Me.ValidateChildren = True And TextCB.Text <> "" And TextTalla.Text <> "" And TextModelo.Text <> "" Then
            Try
                Using conexion1 As New SqlConnection(conexion)
                    conexion1.Open()
                    Dim transaction As SqlTransaction
                    transaction = conexion1.BeginTransaction("Sample")
                    Dim comando As SqlCommand = conexion1.CreateCommand()
                    comando.Connection = conexion1
                    comando.Transaction = transaction
                    Dim r As String
                    r = "update articulos set descripcion='" & TextDescripcion.Text & "', precioventa=" & CDbl(TextPrecioVenta.Text) & ", existencia=" & Val(TextExist.Text) & ", modelo='" & TextModelo.Text & "', talla='" & TextTalla.Text & "', departamento='" & ComboDepto.Text & "', marca='" & ComboMarca.Text & "' where codigo_barras='" & TextCB.Text & "'"
                    comando.CommandText = r
                    comando.ExecuteNonQuery()
                    Try
                        If MessageBox.Show("¿Desea Actualizar los Datos del Artículo?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                            dt2 = New DataTable
                            With comando
                                .Connection = conexion1
                                .CommandText = "Select *from Articulos"
                            End With
                            da.SelectCommand = comando
                            da.Fill(dt2)
                            DataGridViewX1.DataSource = dt2
                            transaction.Commit()
                            MsgBox("El artículo se actualizó correctamente", MsgBoxStyle.Information, "Actualización Exitosa")
                            DataGridViewX1.Enabled = True
                            limpiarCampos1(GroupPanel1)
                            deshaCampos(GroupPanel1)
                            ComboDepto.Enabled = False
                            ComboMarca.Enabled = False
                            btGuardarExc.Enabled = True
                            btnImportar.Enabled = True
                            btActualizar.Visible = False
                            btActualizar.Enabled = False
                            btGuardar.Enabled = True
                            btGuardar.Visible = True
                            'Actualizar los combos
                            ComboDepto.Items.Clear()
                            ComboMarca.Items.Clear()
                            comando.CommandText = "select distinct departamento from articulos"
                            lector = comando.ExecuteReader
                            While lector.Read()
                                ComboDepto.Items.Add(lector(0))
                            End While
                            lector.Close()
                            comando.CommandText = "select distinct marca from articulos"
                            lector = comando.ExecuteReader
                            While lector.Read()
                                ComboMarca.Items.Add(lector(0))
                            End While
                            lector.Close()
                        Else
                            transaction.Rollback()
                            MsgBox("Datos Cancelados", MsgBoxStyle.Critical, "Guardado Cancelado")
                            limpiarCampos1(Me.GroupPanel1)
                            btGuardar.Enabled = True
                            btSalir.Enabled = False
                            ComboDepto.Enabled = False
                            limpiarCampos1(GroupPanel1)
                            deshaCampos(GroupPanel1)
                            btGuardarExc.Enabled = True
                            btnImportar.Enabled = True
                            btActualizar.Visible = False
                            btActualizar.Enabled = False
                            btGuardar.Enabled = True
                            btGuardar.Visible = True
                        End If
                    Catch ex As Exception
                        MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error externo al Sistema")
                        Try
                            transaction.Rollback()
                    Catch ex1 As Exception
                            MsgBox("Error RollBack ", MsgBoxStyle.Critical, "Error externo al Sistema")
                        End Try
                    End Try
                    conexion1.Close()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
                cadena = Err.Description
                cadena = cadena.Replace("'", "")
                Bitacora("Artículos", "Error al actualizar el registro", Err.Number, cadena)
            End Try
            Me.Refresh()
        Else
            MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub TextCB_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextCB.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca el Código de Barras del Articulo")
        End If
    End Sub

    Private Sub ComboDepto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboDepto.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Eliga algún departamento")
        End If
    End Sub

    Private Sub TextDescripcion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextDescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca alguna descripción del Artículo")
        End If
    End Sub

    Private Sub TextModelo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextModelo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca el Modelo del Artículo")
        End If
    End Sub

    Private Sub TextTalla_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextTalla.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca la Talla del Artículo")
        End If
    End Sub

    Private Sub TextExist_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextExist.KeyPress
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

    Private Sub TextPrecioVenta_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextPrecioVenta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Introduzca el precio del artículo")
        End If
    End Sub

    Private Sub TextPrecioVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPrecioVenta.KeyPress
        NumerosyDecimal(TextPrecioVenta, e)
    End Sub

    Private Sub ComboMarca_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboMarca.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Eliga alguna marca")
        End If
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

    Private Sub btActualizar_MouseHover(sender As Object, e As EventArgs) Handles btActualizar.MouseHover
        btActualizar.Size = New Size(126, 38)
    End Sub

    Private Sub btActualizar_MouseLeave(sender As Object, e As EventArgs) Handles btActualizar.MouseLeave
        btActualizar.Size = New Size(123, 35)
    End Sub
End Class