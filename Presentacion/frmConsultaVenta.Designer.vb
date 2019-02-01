<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaVenta
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
        Me.PFormulario = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GrTotales = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TextGranT = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextSubtotal = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextDexcuento = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextSubNeto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.imgSoft = New System.Windows.Forms.PictureBox()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TextDGlobal = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextTArticulos = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TextFecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextFolio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btImprimir = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.TextidVendedor = New System.Windows.Forms.TextBox()
        Me.TextVendedor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextCondicion = New System.Windows.Forms.TextBox()
        Me.TextCajera = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextidCajera = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataVentas = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PFormulario.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrTotales.SuspendLayout()
        CType(Me.imgSoft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DataVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PFormulario
        '
        Me.PFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PFormulario.Controls.Add(Me.Label11)
        Me.PFormulario.Controls.Add(Me.PictureBox2)
        Me.PFormulario.Controls.Add(Me.GrTotales)
        Me.PFormulario.Controls.Add(Me.imgSoft)
        Me.PFormulario.Controls.Add(Me.GroupPanel3)
        Me.PFormulario.Controls.Add(Me.Label1)
        Me.PFormulario.Controls.Add(Me.GroupPanel2)
        Me.PFormulario.Controls.Add(Me.GroupPanel1)
        Me.PFormulario.Controls.Add(Me.DataVentas)
        Me.PFormulario.Location = New System.Drawing.Point(225, 12)
        Me.PFormulario.Name = "PFormulario"
        Me.PFormulario.Size = New System.Drawing.Size(903, 555)
        Me.PFormulario.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calisto MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label11.Location = New System.Drawing.Point(275, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(194, 36)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Consulta de "
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SoftSales.My.Resources.Resources._19021479_1671193346248592_1414681670_n
        Me.PictureBox2.Location = New System.Drawing.Point(40, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(228, 104)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'GrTotales
        '
        Me.GrTotales.BackColor = System.Drawing.Color.Maroon
        Me.GrTotales.CanvasColor = System.Drawing.SystemColors.Control
        Me.GrTotales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GrTotales.Controls.Add(Me.TextGranT)
        Me.GrTotales.Controls.Add(Me.TextSubtotal)
        Me.GrTotales.Controls.Add(Me.TextDexcuento)
        Me.GrTotales.Controls.Add(Me.TextSubNeto)
        Me.GrTotales.Controls.Add(Me.Label12)
        Me.GrTotales.Controls.Add(Me.Label10)
        Me.GrTotales.Controls.Add(Me.Label9)
        Me.GrTotales.Controls.Add(Me.Label8)
        Me.GrTotales.Location = New System.Drawing.Point(615, 396)
        Me.GrTotales.Name = "GrTotales"
        Me.GrTotales.Size = New System.Drawing.Size(242, 141)
        '
        '
        '
        Me.GrTotales.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GrTotales.Style.BackColorGradientAngle = 90
        Me.GrTotales.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GrTotales.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GrTotales.Style.BorderBottomWidth = 1
        Me.GrTotales.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GrTotales.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GrTotales.Style.BorderLeftWidth = 1
        Me.GrTotales.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GrTotales.Style.BorderRightWidth = 1
        Me.GrTotales.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GrTotales.Style.BorderTopWidth = 1
        Me.GrTotales.Style.Class = ""
        Me.GrTotales.Style.CornerDiameter = 4
        Me.GrTotales.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GrTotales.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GrTotales.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GrTotales.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GrTotales.StyleMouseDown.Class = ""
        Me.GrTotales.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GrTotales.StyleMouseOver.Class = ""
        Me.GrTotales.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GrTotales.TabIndex = 35
        '
        'TextGranT
        '
        '
        '
        '
        Me.TextGranT.Border.Class = "TextBoxBorder"
        Me.TextGranT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextGranT.Enabled = False
        Me.TextGranT.Location = New System.Drawing.Point(152, 103)
        Me.TextGranT.Name = "TextGranT"
        Me.TextGranT.Size = New System.Drawing.Size(82, 20)
        Me.TextGranT.TabIndex = 9
        '
        'TextSubtotal
        '
        '
        '
        '
        Me.TextSubtotal.Border.Class = "TextBoxBorder"
        Me.TextSubtotal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextSubtotal.Enabled = False
        Me.TextSubtotal.Location = New System.Drawing.Point(152, 74)
        Me.TextSubtotal.Name = "TextSubtotal"
        Me.TextSubtotal.Size = New System.Drawing.Size(82, 20)
        Me.TextSubtotal.TabIndex = 7
        '
        'TextDexcuento
        '
        '
        '
        '
        Me.TextDexcuento.Border.Class = "TextBoxBorder"
        Me.TextDexcuento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextDexcuento.Enabled = False
        Me.TextDexcuento.Location = New System.Drawing.Point(152, 41)
        Me.TextDexcuento.Name = "TextDexcuento"
        Me.TextDexcuento.Size = New System.Drawing.Size(82, 20)
        Me.TextDexcuento.TabIndex = 6
        Me.TextDexcuento.Text = "0.00"
        '
        'TextSubNeto
        '
        '
        '
        '
        Me.TextSubNeto.Border.Class = "TextBoxBorder"
        Me.TextSubNeto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextSubNeto.Enabled = False
        Me.TextSubNeto.Location = New System.Drawing.Point(152, 10)
        Me.TextSubNeto.Name = "TextSubNeto"
        Me.TextSubNeto.Size = New System.Drawing.Size(82, 20)
        Me.TextSubNeto.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 22)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Total a Pagar:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(55, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 22)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Subtotal:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(31, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 22)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Descuento:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Subtotal Neto:"
        '
        'imgSoft
        '
        Me.imgSoft.Image = Global.SoftSales.My.Resources.Resources.sofsales
        Me.imgSoft.Location = New System.Drawing.Point(760, 32)
        Me.imgSoft.Name = "imgSoft"
        Me.imgSoft.Size = New System.Drawing.Size(87, 55)
        Me.imgSoft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSoft.TabIndex = 0
        Me.imgSoft.TabStop = False
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.TextDGlobal)
        Me.GroupPanel3.Controls.Add(Me.Label13)
        Me.GroupPanel3.Controls.Add(Me.TextTArticulos)
        Me.GroupPanel3.Controls.Add(Me.Label7)
        Me.GroupPanel3.Location = New System.Drawing.Point(22, 406)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(562, 56)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.Class = ""
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.Class = ""
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.Class = ""
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 34
        '
        'TextDGlobal
        '
        '
        '
        '
        Me.TextDGlobal.Border.Class = "TextBoxBorder"
        Me.TextDGlobal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextDGlobal.Enabled = False
        Me.TextDGlobal.Location = New System.Drawing.Point(470, 14)
        Me.TextDGlobal.Name = "TextDGlobal"
        Me.TextDGlobal.Size = New System.Drawing.Size(61, 20)
        Me.TextDGlobal.TabIndex = 5
        Me.TextDGlobal.Text = "0.0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(292, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 22)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Descuento Global:"
        '
        'TextTArticulos
        '
        '
        '
        '
        Me.TextTArticulos.Border.Class = "TextBoxBorder"
        Me.TextTArticulos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextTArticulos.Enabled = False
        Me.TextTArticulos.Location = New System.Drawing.Point(186, 14)
        Me.TextTArticulos.Name = "TextTArticulos"
        Me.TextTArticulos.Size = New System.Drawing.Size(100, 20)
        Me.TextTArticulos.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 22)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Total de Artículos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(286, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 54)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Ventas"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.GroupPanel2.Controls.Add(Me.TextFecha)
        Me.GroupPanel2.Controls.Add(Me.Label3)
        Me.GroupPanel2.Controls.Add(Me.Label2)
        Me.GroupPanel2.Controls.Add(Me.TextFolio)
        Me.GroupPanel2.Location = New System.Drawing.Point(475, 10)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(279, 100)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.Class = ""
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.Class = ""
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.Class = ""
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 33
        '
        'TextFecha
        '
        Me.TextFecha.Enabled = False
        Me.TextFecha.Location = New System.Drawing.Point(82, 56)
        Me.TextFecha.Name = "TextFecha"
        Me.TextFecha.Size = New System.Drawing.Size(184, 20)
        Me.TextFecha.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 22)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Folio Venta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 22)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Fecha:"
        '
        'TextFolio
        '
        '
        '
        '
        Me.TextFolio.Border.Class = "TextBoxBorder"
        Me.TextFolio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextFolio.Enabled = False
        Me.TextFolio.Location = New System.Drawing.Point(127, 20)
        Me.TextFolio.Name = "TextFolio"
        Me.TextFolio.Size = New System.Drawing.Size(139, 20)
        Me.TextFolio.TabIndex = 29
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.GroupPanel1.Controls.Add(Me.btImprimir)
        Me.GroupPanel1.Controls.Add(Me.btSalir)
        Me.GroupPanel1.Controls.Add(Me.TextidVendedor)
        Me.GroupPanel1.Controls.Add(Me.TextVendedor)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.TextCondicion)
        Me.GroupPanel1.Controls.Add(Me.TextCajera)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.TextidCajera)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Location = New System.Drawing.Point(61, 118)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(774, 86)
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
        Me.GroupPanel1.TabIndex = 31
        '
        'btImprimir
        '
        Me.btImprimir.BackColor = System.Drawing.Color.Transparent
        Me.btImprimir.BackgroundImage = Global.SoftSales.My.Resources.Resources.imprimir
        Me.btImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btImprimir.FlatAppearance.BorderSize = 0
        Me.btImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btImprimir.Location = New System.Drawing.Point(459, 40)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(123, 35)
        Me.btImprimir.TabIndex = 60
        Me.btImprimir.UseVisualStyleBackColor = True
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
        Me.btSalir.Location = New System.Drawing.Point(599, 40)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(123, 35)
        Me.btSalir.TabIndex = 51
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'TextidVendedor
        '
        Me.TextidVendedor.Enabled = False
        Me.TextidVendedor.Location = New System.Drawing.Point(131, 45)
        Me.TextidVendedor.Name = "TextidVendedor"
        Me.TextidVendedor.Size = New System.Drawing.Size(73, 20)
        Me.TextidVendedor.TabIndex = 59
        '
        'TextVendedor
        '
        '
        '
        '
        Me.TextVendedor.Border.Class = "TextBoxBorder"
        Me.TextVendedor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextVendedor.Enabled = False
        Me.TextVendedor.Location = New System.Drawing.Point(210, 45)
        Me.TextVendedor.Name = "TextVendedor"
        Me.TextVendedor.Size = New System.Drawing.Size(174, 20)
        Me.TextVendedor.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 22)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Vendedor:"
        '
        'TextCondicion
        '
        Me.TextCondicion.Enabled = False
        Me.TextCondicion.Location = New System.Drawing.Point(589, 9)
        Me.TextCondicion.Name = "TextCondicion"
        Me.TextCondicion.Size = New System.Drawing.Size(151, 20)
        Me.TextCondicion.TabIndex = 7
        '
        'TextCajera
        '
        '
        '
        '
        Me.TextCajera.Border.Class = "TextBoxBorder"
        Me.TextCajera.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextCajera.Enabled = False
        Me.TextCajera.Location = New System.Drawing.Point(163, 10)
        Me.TextCajera.Name = "TextCajera"
        Me.TextCajera.Size = New System.Drawing.Size(221, 20)
        Me.TextCajera.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(389, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 22)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Condición de Pago:"
        '
        'TextidCajera
        '
        '
        '
        '
        Me.TextidCajera.Border.Class = "TextBoxBorder"
        Me.TextidCajera.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextidCajera.Enabled = False
        Me.TextidCajera.Location = New System.Drawing.Point(92, 10)
        Me.TextidCajera.Name = "TextidCajera"
        Me.TextidCajera.Size = New System.Drawing.Size(65, 20)
        Me.TextidCajera.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cajera:"
        '
        'DataVentas
        '
        Me.DataVentas.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Articulo, Me.Column1, Me.CantidadData, Me.Column3, Me.Column4, Me.TotalData})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataVentas.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataVentas.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataVentas.HighlightSelectedColumnHeaders = False
        Me.DataVentas.Location = New System.Drawing.Point(54, 231)
        Me.DataVentas.Name = "DataVentas"
        Me.DataVentas.ReadOnly = True
        Me.DataVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataVentas.Size = New System.Drawing.Size(799, 159)
        Me.DataVentas.TabIndex = 32
        '
        'Articulo
        '
        Me.Articulo.HeaderText = "Artículo"
        Me.Articulo.Name = "Articulo"
        Me.Articulo.ReadOnly = True
        Me.Articulo.Width = 150
        '
        'Column1
        '
        Me.Column1.HeaderText = "Descripción"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 200
        '
        'CantidadData
        '
        Me.CantidadData.HeaderText = "Cantidad"
        Me.CantidadData.Name = "CantidadData"
        Me.CantidadData.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Desc. Extra"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'TotalData
        '
        Me.TotalData.HeaderText = "Importe"
        Me.TotalData.Name = "TotalData"
        Me.TotalData.ReadOnly = True
        '
        'frmConsultaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 606)
        Me.Controls.Add(Me.PFormulario)
        Me.Name = "frmConsultaVenta"
        Me.Text = "Consulta de Venta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PFormulario.ResumeLayout(False)
        Me.PFormulario.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrTotales.ResumeLayout(False)
        Me.GrTotales.PerformLayout()
        CType(Me.imgSoft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.DataVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PFormulario As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GrTotales As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TextGranT As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextSubtotal As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextDexcuento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextSubNeto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents imgSoft As System.Windows.Forms.PictureBox
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents TextTArticulos As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextFolio As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TextCajera As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextidCajera As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataVentas As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextFecha As System.Windows.Forms.TextBox
    Friend WithEvents TextCondicion As System.Windows.Forms.TextBox
    Friend WithEvents btImprimir As System.Windows.Forms.Button
    Friend WithEvents TextidVendedor As System.Windows.Forms.TextBox
    Friend WithEvents TextVendedor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TextDGlobal As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadData As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalData As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
