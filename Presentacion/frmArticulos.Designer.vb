<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ComboMarca = New System.Windows.Forms.ComboBox()
        Me.TextPrecioVenta = New System.Windows.Forms.TextBox()
        Me.TextExist = New System.Windows.Forms.TextBox()
        Me.TextTalla = New System.Windows.Forms.TextBox()
        Me.TextModelo = New System.Windows.Forms.TextBox()
        Me.TextDescripcion = New System.Windows.Forms.TextBox()
        Me.ComboDepto = New System.Windows.Forms.ComboBox()
        Me.TextCB = New System.Windows.Forms.TextBox()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TextBuscarArt = New System.Windows.Forms.TextBox()
        Me.lbarticulos = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btGuardarExc = New System.Windows.Forms.Button()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.ComboMarca)
        Me.GroupPanel1.Controls.Add(Me.TextPrecioVenta)
        Me.GroupPanel1.Controls.Add(Me.TextExist)
        Me.GroupPanel1.Controls.Add(Me.TextTalla)
        Me.GroupPanel1.Controls.Add(Me.TextModelo)
        Me.GroupPanel1.Controls.Add(Me.TextDescripcion)
        Me.GroupPanel1.Controls.Add(Me.ComboDepto)
        Me.GroupPanel1.Controls.Add(Me.TextCB)
        Me.GroupPanel1.Controls.Add(Me.btGuardar)
        Me.GroupPanel1.Controls.Add(Me.btActualizar)
        Me.GroupPanel1.Controls.Add(Me.btSalir)
        Me.GroupPanel1.Controls.Add(Me.btnEditar)
        Me.GroupPanel1.Controls.Add(Me.btnNuevo)
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.Label20)
        Me.GroupPanel1.Controls.Add(Me.Label22)
        Me.GroupPanel1.Controls.Add(Me.Label24)
        Me.GroupPanel1.Controls.Add(Me.Label26)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 194)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(610, 289)
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
        Me.GroupPanel1.TabIndex = 24
        Me.GroupPanel1.Text = "Propiedades"
        '
        'ComboMarca
        '
        Me.ComboMarca.Enabled = False
        Me.ComboMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboMarca.FormattingEnabled = True
        Me.ComboMarca.Location = New System.Drawing.Point(325, 174)
        Me.ComboMarca.Name = "ComboMarca"
        Me.ComboMarca.Size = New System.Drawing.Size(144, 21)
        Me.ComboMarca.TabIndex = 72
        '
        'TextPrecioVenta
        '
        Me.TextPrecioVenta.Enabled = False
        Me.TextPrecioVenta.Location = New System.Drawing.Point(142, 174)
        Me.TextPrecioVenta.Name = "TextPrecioVenta"
        Me.TextPrecioVenta.Size = New System.Drawing.Size(100, 20)
        Me.TextPrecioVenta.TabIndex = 68
        '
        'TextExist
        '
        Me.TextExist.Enabled = False
        Me.TextExist.Location = New System.Drawing.Point(523, 123)
        Me.TextExist.Name = "TextExist"
        Me.TextExist.Size = New System.Drawing.Size(73, 20)
        Me.TextExist.TabIndex = 67
        '
        'TextTalla
        '
        Me.TextTalla.Enabled = False
        Me.TextTalla.Location = New System.Drawing.Point(305, 123)
        Me.TextTalla.Name = "TextTalla"
        Me.TextTalla.Size = New System.Drawing.Size(112, 20)
        Me.TextTalla.TabIndex = 66
        '
        'TextModelo
        '
        Me.TextModelo.Enabled = False
        Me.TextModelo.Location = New System.Drawing.Point(100, 125)
        Me.TextModelo.Name = "TextModelo"
        Me.TextModelo.Size = New System.Drawing.Size(142, 20)
        Me.TextModelo.TabIndex = 65
        '
        'TextDescripcion
        '
        Me.TextDescripcion.Enabled = False
        Me.TextDescripcion.Location = New System.Drawing.Point(129, 52)
        Me.TextDescripcion.Multiline = True
        Me.TextDescripcion.Name = "TextDescripcion"
        Me.TextDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextDescripcion.Size = New System.Drawing.Size(358, 53)
        Me.TextDescripcion.TabIndex = 64
        '
        'ComboDepto
        '
        Me.ComboDepto.Enabled = False
        Me.ComboDepto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboDepto.FormattingEnabled = True
        Me.ComboDepto.Location = New System.Drawing.Point(475, 13)
        Me.ComboDepto.Name = "ComboDepto"
        Me.ComboDepto.Size = New System.Drawing.Size(121, 21)
        Me.ComboDepto.TabIndex = 63
        '
        'TextCB
        '
        Me.TextCB.Enabled = False
        Me.TextCB.Location = New System.Drawing.Point(182, 14)
        Me.TextCB.Name = "TextCB"
        Me.TextCB.Size = New System.Drawing.Size(128, 20)
        Me.TextCB.TabIndex = 62
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
        Me.btGuardar.Location = New System.Drawing.Point(306, 217)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(123, 35)
        Me.btGuardar.TabIndex = 61
        Me.btGuardar.UseVisualStyleBackColor = True
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
        Me.btActualizar.Location = New System.Drawing.Point(305, 217)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(123, 35)
        Me.btActualizar.TabIndex = 60
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
        Me.btSalir.Location = New System.Drawing.Point(435, 217)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(123, 35)
        Me.btSalir.TabIndex = 59
        Me.btSalir.UseVisualStyleBackColor = True
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
        Me.btnEditar.Location = New System.Drawing.Point(169, 217)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(123, 35)
        Me.btnEditar.TabIndex = 58
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
        Me.btnNuevo.Location = New System.Drawing.Point(33, 217)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(123, 35)
        Me.btnNuevo.TabIndex = 57
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(248, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 22)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Marca:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(248, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 22)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Talla:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 22)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Modelo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Código de Barras:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(316, 12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(153, 22)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Departamento:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(11, 55)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(121, 22)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Descripción:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(423, 123)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(103, 22)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Existencia:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(11, 172)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(135, 22)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Precio Venta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(127, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 32)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Artículos ""Grupo Roberto"""
        '
        'DataGridViewX1
        '
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridViewX1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.HighlightSelectedColumnHeaders = False
        Me.DataGridViewX1.Location = New System.Drawing.Point(638, 114)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewX1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewX1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewX1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray
        Me.DataGridViewX1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewX1.Size = New System.Drawing.Size(704, 465)
        Me.DataGridViewX1.TabIndex = 32
        '
        'TextBuscarArt
        '
        Me.TextBuscarArt.Location = New System.Drawing.Point(762, 25)
        Me.TextBuscarArt.Name = "TextBuscarArt"
        Me.TextBuscarArt.Size = New System.Drawing.Size(198, 20)
        Me.TextBuscarArt.TabIndex = 31
        '
        'lbarticulos
        '
        Me.lbarticulos.AutoSize = True
        Me.lbarticulos.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbarticulos.Location = New System.Drawing.Point(1025, 25)
        Me.lbarticulos.Name = "lbarticulos"
        Me.lbarticulos.Size = New System.Drawing.Size(82, 22)
        Me.lbarticulos.TabIndex = 30
        Me.lbarticulos.Text = "Label29"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(583, 25)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(174, 22)
        Me.Label28.TabIndex = 29
        Me.Label28.Text = "Código de Barras:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btGuardarExc
        '
        Me.btGuardarExc.BackColor = System.Drawing.Color.Transparent
        Me.btGuardarExc.BackgroundImage = Global.SoftSales.My.Resources.Resources.guardar_excel
        Me.btGuardarExc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btGuardarExc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btGuardarExc.FlatAppearance.BorderSize = 0
        Me.btGuardarExc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btGuardarExc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btGuardarExc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGuardarExc.Location = New System.Drawing.Point(864, 56)
        Me.btGuardarExc.Name = "btGuardarExc"
        Me.btGuardarExc.Size = New System.Drawing.Size(123, 35)
        Me.btGuardarExc.TabIndex = 51
        Me.btGuardarExc.UseVisualStyleBackColor = True
        '
        'btnImportar
        '
        Me.btnImportar.BackColor = System.Drawing.Color.Transparent
        Me.btnImportar.BackgroundImage = Global.SoftSales.My.Resources.Resources.importar_excel
        Me.btnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImportar.FlatAppearance.BorderSize = 0
        Me.btnImportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportar.Location = New System.Drawing.Point(735, 56)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(123, 35)
        Me.btnImportar.TabIndex = 50
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SoftSales.My.Resources.Resources._19021479_1671193346248592_1414681670_n
        Me.PictureBox1.Location = New System.Drawing.Point(197, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SoftSales.My.Resources.Resources.sofsales
        Me.PictureBox2.Location = New System.Drawing.Point(1266, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'frmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1354, 608)
        Me.Controls.Add(Me.btGuardarExc)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.TextBuscarArt)
        Me.Controls.Add(Me.lbarticulos)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Articulos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TextBuscarArt As System.Windows.Forms.TextBox
    Friend WithEvents lbarticulos As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents btGuardarExc As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btActualizar As System.Windows.Forms.Button
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btGuardar As System.Windows.Forms.Button
    Friend WithEvents ComboMarca As System.Windows.Forms.ComboBox
    Friend WithEvents TextPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents TextExist As System.Windows.Forms.TextBox
    Friend WithEvents TextTalla As System.Windows.Forms.TextBox
    Friend WithEvents TextModelo As System.Windows.Forms.TextBox
    Friend WithEvents TextDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents ComboDepto As System.Windows.Forms.ComboBox
    Friend WithEvents TextCB As System.Windows.Forms.TextBox
End Class
