<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TextComision = New System.Windows.Forms.TextBox()
        Me.TextPass = New System.Windows.Forms.TextBox()
        Me.TextUsuario = New System.Windows.Forms.TextBox()
        Me.ComboHorario = New System.Windows.Forms.ComboBox()
        Me.comboTE = New System.Windows.Forms.ComboBox()
        Me.TxtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.TxtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.TxtCP = New System.Windows.Forms.TextBox()
        Me.TxtColonia = New System.Windows.Forms.TextBox()
        Me.TextNum = New System.Windows.Forms.TextBox()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TextFolioVen = New System.Windows.Forms.TextBox()
        Me.TxtidEmpleado = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbComision = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbCOntra = New System.Windows.Forms.Label()
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbregistros = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtApBuscar = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DataEmpleados = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.DataVendedores = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.LbBuscarV = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBuscarV = New System.Windows.Forms.TextBox()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.GroupPanel1.Controls.Add(Me.TextComision)
        Me.GroupPanel1.Controls.Add(Me.TextPass)
        Me.GroupPanel1.Controls.Add(Me.TextUsuario)
        Me.GroupPanel1.Controls.Add(Me.ComboHorario)
        Me.GroupPanel1.Controls.Add(Me.comboTE)
        Me.GroupPanel1.Controls.Add(Me.TxtCelular)
        Me.GroupPanel1.Controls.Add(Me.TxtTelefono)
        Me.GroupPanel1.Controls.Add(Me.TxtCP)
        Me.GroupPanel1.Controls.Add(Me.TxtColonia)
        Me.GroupPanel1.Controls.Add(Me.TextNum)
        Me.GroupPanel1.Controls.Add(Me.TxtDomicilio)
        Me.GroupPanel1.Controls.Add(Me.TxtNombre)
        Me.GroupPanel1.Controls.Add(Me.TextFolioVen)
        Me.GroupPanel1.Controls.Add(Me.TxtidEmpleado)
        Me.GroupPanel1.Controls.Add(Me.Label12)
        Me.GroupPanel1.Controls.Add(Me.lbComision)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.btActualizar)
        Me.GroupPanel1.Controls.Add(Me.btSalir)
        Me.GroupPanel1.Controls.Add(Me.btGuardar)
        Me.GroupPanel1.Controls.Add(Me.btnEditar)
        Me.GroupPanel1.Controls.Add(Me.btnNuevo)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.Label10)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Controls.Add(Me.Label9)
        Me.GroupPanel1.Controls.Add(Me.Label8)
        Me.GroupPanel1.Controls.Add(Me.Label19)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.LbCOntra)
        Me.GroupPanel1.Controls.Add(Me.LbUsuario)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 149)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(555, 423)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 26
        Me.GroupPanel1.Text = "Datos Personales"
        '
        'TextComision
        '
        Me.TextComision.Enabled = False
        Me.TextComision.Location = New System.Drawing.Point(245, 277)
        Me.TextComision.Name = "TextComision"
        Me.TextComision.Size = New System.Drawing.Size(89, 20)
        Me.TextComision.TabIndex = 70
        Me.TextComision.Visible = False
        '
        'TextPass
        '
        Me.TextPass.Enabled = False
        Me.TextPass.Location = New System.Drawing.Point(383, 277)
        Me.TextPass.Name = "TextPass"
        Me.TextPass.Size = New System.Drawing.Size(137, 20)
        Me.TextPass.TabIndex = 69
        Me.TextPass.Text = "no aplica"
        Me.TextPass.UseSystemPasswordChar = True
        Me.TextPass.Visible = False
        '
        'TextUsuario
        '
        Me.TextUsuario.Enabled = False
        Me.TextUsuario.Location = New System.Drawing.Point(110, 278)
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TextUsuario.TabIndex = 67
        Me.TextUsuario.Text = "No aplica"
        Me.TextUsuario.Visible = False
        '
        'ComboHorario
        '
        Me.ComboHorario.Enabled = False
        Me.ComboHorario.FormattingEnabled = True
        Me.ComboHorario.Items.AddRange(New Object() {"8:00am-2:00pm", "9:00am-3:00pm", "10:00am-4:00pm", "12:00am-6:00pm", "2:00am-8:00pm", "4:00am-9:00pm"})
        Me.ComboHorario.Location = New System.Drawing.Point(383, 237)
        Me.ComboHorario.Name = "ComboHorario"
        Me.ComboHorario.Size = New System.Drawing.Size(137, 21)
        Me.ComboHorario.TabIndex = 66
        '
        'comboTE
        '
        Me.comboTE.Enabled = False
        Me.comboTE.FormattingEnabled = True
        Me.comboTE.Items.AddRange(New Object() {"Almacenista", "Cajero(a)", "Otro", "Vendedor(a)"})
        Me.comboTE.Location = New System.Drawing.Point(167, 237)
        Me.comboTE.Name = "comboTE"
        Me.comboTE.Size = New System.Drawing.Size(129, 21)
        Me.comboTE.TabIndex = 65
        '
        'TxtCelular
        '
        Me.TxtCelular.Enabled = False
        Me.TxtCelular.Location = New System.Drawing.Point(349, 188)
        Me.TxtCelular.Mask = "000-000-0000"
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(94, 20)
        Me.TxtCelular.TabIndex = 64
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Enabled = False
        Me.TxtTelefono.Location = New System.Drawing.Point(154, 186)
        Me.TxtTelefono.Mask = "(999)000-0000"
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TxtTelefono.TabIndex = 63
        '
        'TxtCP
        '
        Me.TxtCP.Enabled = False
        Me.TxtCP.Location = New System.Drawing.Point(413, 140)
        Me.TxtCP.MaxLength = 5
        Me.TxtCP.Name = "TxtCP"
        Me.TxtCP.Size = New System.Drawing.Size(107, 20)
        Me.TxtCP.TabIndex = 62
        '
        'TxtColonia
        '
        Me.TxtColonia.Enabled = False
        Me.TxtColonia.Location = New System.Drawing.Point(110, 140)
        Me.TxtColonia.Name = "TxtColonia"
        Me.TxtColonia.Size = New System.Drawing.Size(150, 20)
        Me.TxtColonia.TabIndex = 61
        '
        'TextNum
        '
        Me.TextNum.Enabled = False
        Me.TextNum.ForeColor = System.Drawing.Color.Black
        Me.TextNum.Location = New System.Drawing.Point(390, 96)
        Me.TextNum.Name = "TextNum"
        Me.TextNum.Size = New System.Drawing.Size(130, 20)
        Me.TextNum.TabIndex = 60
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.Enabled = False
        Me.TxtDomicilio.ForeColor = System.Drawing.Color.Black
        Me.TxtDomicilio.Location = New System.Drawing.Point(110, 96)
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(236, 20)
        Me.TxtDomicilio.TabIndex = 59
        '
        'TxtNombre
        '
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.ForeColor = System.Drawing.Color.Gray
        Me.TxtNombre.Location = New System.Drawing.Point(110, 53)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(316, 20)
        Me.TxtNombre.TabIndex = 58
        Me.TxtNombre.Text = "Ap Paterno Ap Materno Nombre(s)"
        '
        'TextFolioVen
        '
        Me.TextFolioVen.Enabled = False
        Me.TextFolioVen.Location = New System.Drawing.Point(420, 11)
        Me.TextFolioVen.Name = "TextFolioVen"
        Me.TextFolioVen.Size = New System.Drawing.Size(100, 20)
        Me.TextFolioVen.TabIndex = 57
        Me.TextFolioVen.Visible = False
        '
        'TxtidEmpleado
        '
        Me.TxtidEmpleado.Enabled = False
        Me.TxtidEmpleado.Location = New System.Drawing.Point(167, 11)
        Me.TxtidEmpleado.Name = "TxtidEmpleado"
        Me.TxtidEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TxtidEmpleado.TabIndex = 56
        Me.TxtidEmpleado.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(267, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 22)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Folio Vendedor: "
        Me.Label12.Visible = False
        '
        'lbComision
        '
        Me.lbComision.AutoSize = True
        Me.lbComision.BackColor = System.Drawing.Color.Transparent
        Me.lbComision.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbComision.Location = New System.Drawing.Point(153, 276)
        Me.lbComision.Name = "lbComision"
        Me.lbComision.Size = New System.Drawing.Size(96, 22)
        Me.lbComision.TabIndex = 53
        Me.lbComision.Text = "Comisión:"
        Me.lbComision.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(352, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 22)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "No."
        '
        'btActualizar
        '
        Me.btActualizar.BackColor = System.Drawing.Color.Transparent
        Me.btActualizar.BackgroundImage = Global.SoftSales.My.Resources.Resources.ACTUALIZAR
        Me.btActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btActualizar.Enabled = False
        Me.btActualizar.FlatAppearance.BorderSize = 0
        Me.btActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btActualizar.Location = New System.Drawing.Point(271, 349)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(123, 35)
        Me.btActualizar.TabIndex = 48
        Me.btActualizar.UseVisualStyleBackColor = True
        Me.btActualizar.Visible = False
        '
        'btSalir
        '
        Me.btSalir.BackColor = System.Drawing.Color.Transparent
        Me.btSalir.BackgroundImage = Global.SoftSales.My.Resources.Resources.SALIR
        Me.btSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalir.FlatAppearance.BorderSize = 0
        Me.btSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalir.Location = New System.Drawing.Point(401, 349)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(123, 35)
        Me.btSalir.TabIndex = 47
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btGuardar.BackgroundImage = Global.SoftSales.My.Resources.Resources.GUARDAR
        Me.btGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btGuardar.FlatAppearance.BorderSize = 0
        Me.btGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGuardar.Location = New System.Drawing.Point(270, 349)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(123, 35)
        Me.btGuardar.TabIndex = 46
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.BackgroundImage = Global.SoftSales.My.Resources.Resources.EDITAR
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(135, 349)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(123, 35)
        Me.btnEditar.TabIndex = 45
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.BackgroundImage = Global.SoftSales.My.Resources.Resources.nuevo
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Location = New System.Drawing.Point(-1, 349)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(123, 35)
        Me.btnNuevo.TabIndex = 42
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Folio Empleado: "
        Me.Label3.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(264, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 22)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Celular:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Domicilio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Colonia:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(65, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 22)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Télefono:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(266, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 22)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Código Postal:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(302, 236)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 22)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Horario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 22)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Tipo Empleado:"
        '
        'LbCOntra
        '
        Me.LbCOntra.AutoSize = True
        Me.LbCOntra.BackColor = System.Drawing.Color.Transparent
        Me.LbCOntra.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCOntra.Location = New System.Drawing.Point(247, 276)
        Me.LbCOntra.Name = "LbCOntra"
        Me.LbCOntra.Size = New System.Drawing.Size(124, 22)
        Me.LbCOntra.TabIndex = 25
        Me.LbCOntra.Text = "Contraseña:"
        Me.LbCOntra.Visible = False
        '
        'LbUsuario
        '
        Me.LbUsuario.AutoSize = True
        Me.LbUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LbUsuario.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUsuario.Location = New System.Drawing.Point(26, 276)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(80, 22)
        Me.LbUsuario.TabIndex = 24
        Me.LbUsuario.Text = "Usuario:"
        Me.LbUsuario.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SoftSales.My.Resources.Resources._19021479_1671193346248592_1414681670_n
        Me.PictureBox2.Location = New System.Drawing.Point(182, 42)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(228, 104)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SoftSales.My.Resources.Resources.sofsales
        Me.PictureBox1.Location = New System.Drawing.Point(1230, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(103, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 32)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Empleados ""Grupo Roberto"""
        '
        'lbregistros
        '
        Me.lbregistros.AutoSize = True
        Me.lbregistros.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbregistros.Location = New System.Drawing.Point(976, 50)
        Me.lbregistros.Name = "lbregistros"
        Me.lbregistros.Size = New System.Drawing.Size(82, 22)
        Me.lbregistros.TabIndex = 22
        Me.lbregistros.Text = "Label16"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(482, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(289, 22)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Buscar Empleado por Apellido:"
        '
        'TxtApBuscar
        '
        Me.TxtApBuscar.Location = New System.Drawing.Point(777, 52)
        Me.TxtApBuscar.Name = "TxtApBuscar"
        Me.TxtApBuscar.Size = New System.Drawing.Size(164, 20)
        Me.TxtApBuscar.TabIndex = 21
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DataEmpleados
        '
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataEmpleados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataEmpleados.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataEmpleados.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataEmpleados.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataEmpleados.HighlightSelectedColumnHeaders = False
        Me.DataEmpleados.Location = New System.Drawing.Point(602, 100)
        Me.DataEmpleados.Name = "DataEmpleados"
        Me.DataEmpleados.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataEmpleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.DataEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataEmpleados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DataEmpleados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray
        Me.DataEmpleados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataEmpleados.Size = New System.Drawing.Size(748, 208)
        Me.DataEmpleados.TabIndex = 33
        '
        'DataVendedores
        '
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataVendedores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataVendedores.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataVendedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataVendedores.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataVendedores.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataVendedores.HighlightSelectedColumnHeaders = False
        Me.DataVendedores.Location = New System.Drawing.Point(602, 355)
        Me.DataVendedores.Name = "DataVendedores"
        Me.DataVendedores.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataVendedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DataVendedores.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataVendedores.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DataVendedores.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray
        Me.DataVendedores.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataVendedores.Size = New System.Drawing.Size(748, 239)
        Me.DataVendedores.TabIndex = 37
        '
        'LbBuscarV
        '
        Me.LbBuscarV.AutoSize = True
        Me.LbBuscarV.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBuscarV.Location = New System.Drawing.Point(1092, 320)
        Me.LbBuscarV.Name = "LbBuscarV"
        Me.LbBuscarV.Size = New System.Drawing.Size(82, 22)
        Me.LbBuscarV.TabIndex = 36
        Me.LbBuscarV.Text = "Label16"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(598, 322)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(291, 22)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Buscar Vendedor por Apellido:"
        '
        'TextBuscarV
        '
        Me.TextBuscarV.Location = New System.Drawing.Point(895, 322)
        Me.TextBuscarV.Name = "TextBuscarV"
        Me.TextBuscarV.Size = New System.Drawing.Size(164, 20)
        Me.TextBuscarV.TabIndex = 35
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1362, 608)
        Me.Controls.Add(Me.DataVendedores)
        Me.Controls.Add(Me.LbBuscarV)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBuscarV)
        Me.Controls.Add(Me.DataEmpleados)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbregistros)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtApBuscar)
        Me.DoubleBuffered = True
        Me.Name = "frmEmpleados"
        Me.Text = "Empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LbCOntra As System.Windows.Forms.Label
    Friend WithEvents LbUsuario As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbregistros As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtApBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents btGuardar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btActualizar As System.Windows.Forms.Button
    Friend WithEvents DataEmpleados As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbComision As System.Windows.Forms.Label
    Friend WithEvents DataVendedores As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LbBuscarV As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBuscarV As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextPass As System.Windows.Forms.TextBox
    Friend WithEvents TextUsuario As System.Windows.Forms.TextBox
    Friend WithEvents ComboHorario As System.Windows.Forms.ComboBox
    Friend WithEvents comboTE As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtTelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtCP As System.Windows.Forms.TextBox
    Friend WithEvents TxtColonia As System.Windows.Forms.TextBox
    Friend WithEvents TextNum As System.Windows.Forms.TextBox
    Friend WithEvents TxtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TextFolioVen As System.Windows.Forms.TextBox
    Friend WithEvents TxtidEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents TextComision As System.Windows.Forms.TextBox
End Class
