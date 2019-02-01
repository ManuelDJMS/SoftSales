Imports System.Data.SqlClient
Public Class frmOfertas

    Dim cmd As SqlCommand
    Dim lector As SqlDataReader
    Dim cadena As String
    Private Sub frmOfertas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.ToolTip1.Active = True
            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
            Me.ToolTip1.ToolTipTitle = "Ayuda"
            Me.ToolTip1.SetToolTip(Me.btAceptar, "Agrega una Oferta")
            Me.ToolTip1.SetToolTip(Me.btNuevo, "Guarda la oferta del Día")
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

            cmd.CommandText = "select distinct marca from articulos"
            lector = cmd.ExecuteReader
            While lector.Read()
                comboMDmarca.Items.Add(lector(0))
            End While
            lector.Close()

            cmd.CommandText = "select distinct departamento from articulos"
            lector = cmd.ExecuteReader
            While lector.Read()
                ComboMDdepto.Items.Add(lector(0))
            End While
            lector.Close()
            clase.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Artículos", "Error al iniciar el formulario", Err.Number, cadena)
        End Try
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
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        If Me.ValidateChildren = True And (rbDepto.Checked Or rbIndividual.Checked Or rbTipo.Checked Or rbMD.Checked) And ComboOferta.Text <> "" And TextDescricion.Text <> "" Then
            Dim clase As New SqlConnection(conexion)
            clase.Open()
            cmd = clase.CreateCommand
            Dim r As String
            If (rbDepto.Checked) Then
                r = "select descuento from articulos where departamento='" & ComboDepto.Text & "'"
                cmd.CommandText = r
                lector = cmd.ExecuteReader()
                lector.Read()
                If (lector(0) > 0) Then
                    lector.Close()
                    MsgBox("La oferta ya existe", MsgBoxStyle.Exclamation, "Ofertas")
                    Me.Close()
                Else
                    If MessageBox.Show("Para Guardar la Venta necesitará autorización del Admin", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        Me.Enabled = False
                        frmAutorizacion.Show()
                    End If
                End If
                'Decision para la marca
            ElseIf (rbTipo.Checked) Then
                r = "select descuento from articulos where marca='" & ComboMarca.Text & "'"
                cmd.CommandText = r
                lector = cmd.ExecuteReader()
                lector.Read()
                If (lector(0) > 0) Then
                    lector.Close()
                    MsgBox("La oferta ya existe", MsgBoxStyle.Exclamation, "Ofertas")
                    Me.Close()
                Else
                    If MessageBox.Show("Para Guardar la Venta necesitará autorización del Admin", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        Me.Enabled = False
                        frmAutorizacion.Show()
                    End If
                End If
                'Desicion por departamento y marca
            ElseIf (rbMD.Checked) Then
                r = "select descuento from articulos where departamento='" & ComboMDdepto.Text & "' and marca='" & comboMDmarca.Text & "'"
                cmd.CommandText = r
                lector = cmd.ExecuteReader()
                lector.Read()
                If (lector(0) > 0) Then
                    lector.Close()
                    MsgBox("La oferta ya existe", MsgBoxStyle.Exclamation, "Ofertas")
                    Me.Close()
                Else
                    If MessageBox.Show("Para Guardar la Venta necesitará autorización del Admin", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        Me.Enabled = False
                        frmAutorizacion.Show()
                    End If
                End If

            Else
                r = "select descuento from articulos where codigo_barras='" & TextIndividual.Text & "'"
                cmd.CommandText = r
                lector = cmd.ExecuteReader()
                lector.Read()
                If lector(0) > 0 Then
                    lector.Close()
                    MsgBox("La oferta ya existe", MsgBoxStyle.Exclamation, "Ofertas")
                    Me.Close()
                Else
                    If MessageBox.Show("Para Guardar la Venta necesitará autorización del Admin", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        Me.Enabled = False
                        frmAutorizacion.Show()
                    End If
                End If

            End If
        Else
            MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        panelOferta.Enabled = True
        ComboOferta.Enabled = True
        TextDescricion.Enabled = True
        btNuevo.Enabled = True
        btAceptar.Enabled = False
    End Sub

    Private Sub rbDepto_CheckedChanged(sender As Object, e As EventArgs) Handles rbDepto.CheckedChanged
        If (rbDepto.Checked) Then
            ComboDepto.Enabled = True
            ComboMarca.Enabled = False
            TextIndividual.Enabled = False
            ComboMDdepto.Enabled = False
            comboMDmarca.Enabled = False
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub rbTipo_CheckedChanged(sender As Object, e As EventArgs) Handles rbTipo.CheckedChanged
        If (rbTipo.Checked) Then
            ComboDepto.Enabled = False
            ComboMarca.Enabled = True
            TextIndividual.Enabled = False
            ComboMDdepto.Enabled = False
            comboMDmarca.Enabled = False
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub rbIndividual_CheckedChanged(sender As Object, e As EventArgs) Handles rbIndividual.CheckedChanged
        If (rbIndividual.Checked) Then
            ComboDepto.Enabled = False
            ComboMarca.Enabled = False
            TextIndividual.Enabled = True
            ComboMDdepto.Enabled = False
            comboMDmarca.Enabled = False
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub ComboOferta_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboOferta.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Eliga alguna Oferta")
        End If
    End Sub

    Private Sub TextDescricion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextDescricion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Proporcione el porque de la Oferta")
        End If
    End Sub

    Private Sub btNuevo_MouseHover(sender As Object, e As EventArgs) Handles btNuevo.MouseHover
        btNuevo.Size = New Size(126, 38)
    End Sub

    Private Sub btNuevo_MouseLeave(sender As Object, e As EventArgs) Handles btNuevo.MouseLeave
        btNuevo.Size = New Size(123, 35)
    End Sub

    Private Sub ComboDepto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboDepto.Validating
        If ComboDepto.Enabled = True Then
            If DirectCast(sender, ComboBox).Text.Length > 0 Then
                Me.ErrorProvider1.SetError(sender, "")
            Else
                Me.ErrorProvider1.SetError(sender, "Eliga un Departamento")
            End If
        End If
    End Sub

    Private Sub ComboMarca_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboMarca.Validating
        If ComboMarca.Enabled = True Then
            If DirectCast(sender, ComboBox).Text.Length > 0 Then
                Me.ErrorProvider1.SetError(sender, "")
            Else
                Me.ErrorProvider1.SetError(sender, "Eliga alguna Marca")
            End If
        End If
    End Sub

    Private Sub TextIndividual_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextIndividual.Validating
        If TextIndividual.Enabled = True Then
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                Me.ErrorProvider1.SetError(sender, "")
            Else
                Me.ErrorProvider1.SetError(sender, "Ingrese un código de barras de algún artículo")
            End If
        End If
    End Sub

    Private Sub rbMD_CheckedChanged(sender As Object, e As EventArgs) Handles rbMD.CheckedChanged
        If (rbMD.Checked) Then
            ComboDepto.Enabled = False
            ComboMarca.Enabled = False
            TextIndividual.Enabled = False
            ComboMDdepto.Enabled = True
            comboMDmarca.Enabled = True
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub comboMDmarca_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles comboMDmarca.Validating
        If comboMDmarca.Enabled = True Then
            If DirectCast(sender, ComboBox).Text.Length > 0 Then
                Me.ErrorProvider1.SetError(sender, "")
            Else
                Me.ErrorProvider1.SetError(sender, "Eliga alguna Marca")
            End If
        End If
    End Sub

    Private Sub ComboMDdepto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboMDdepto.Validating
        If ComboMDdepto.Enabled = True Then
            If DirectCast(sender, ComboBox).Text.Length > 0 Then
                Me.ErrorProvider1.SetError(sender, "")
            Else
                Me.ErrorProvider1.SetError(sender, "Eliga algún Departamento")
            End If
        End If
    End Sub

    Private Sub ComboOferta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboOferta.SelectedIndexChanged
        If ComboOferta.SelectedItem.ToString = "Descuento" Then
            frmMensajes.Show()
        End If
    End Sub
End Class