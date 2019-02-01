<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormasPago
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
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.RibbonTabItem1 = New DevComponents.DotNetBar.RibbonTabItem()
        Me.RibbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel4 = New DevComponents.DotNetBar.RibbonPanel()
        Me.panelvale = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.combovale = New System.Windows.Forms.ComboBox()
        Me.TextImportV = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbcobroV = New System.Windows.Forms.Label()
        Me.btCancelarV = New System.Windows.Forms.Button()
        Me.btAceptarV = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RibbonPanel2 = New DevComponents.DotNetBar.RibbonPanel()
        Me.PanelTarjeta = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TextImporteT = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbTotalCobroT = New System.Windows.Forms.Label()
        Me.btCancelarT = New System.Windows.Forms.Button()
        Me.btAceptarT = New System.Windows.Forms.Button()
        Me.TextAutorizar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextNoTarjeta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RibbonPanel3 = New DevComponents.DotNetBar.RibbonPanel()
        Me.DataVale = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTarjetas = New System.Windows.Forms.DataGridView()
        Me.rt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.autorizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataCheques = New System.Windows.Forms.DataGridView()
        Me.r = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numcheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDetallePago = New System.Windows.Forms.DataGridView()
        Me.Folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RibbonPanel1 = New DevComponents.DotNetBar.RibbonPanel()
        Me.PanelCheque = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TextSucursal = New System.Windows.Forms.TextBox()
        Me.ComboSucursal = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lbTotalCobro = New System.Windows.Forms.Label()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextImporte = New System.Windows.Forms.TextBox()
        Me.TextTitular = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextNCheque = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextCuenta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ptnCheque = New DevComponents.DotNetBar.RibbonTabItem()
        Me.PtnTarjeta = New DevComponents.DotNetBar.RibbonTabItem()
        Me.ptnVale = New DevComponents.DotNetBar.RibbonTabItem()
        Me.DATOS = New DevComponents.DotNetBar.RibbonTabItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RibbonControl1.SuspendLayout()
        Me.RibbonPanel4.SuspendLayout()
        Me.panelvale.SuspendLayout()
        Me.RibbonPanel2.SuspendLayout()
        Me.PanelTarjeta.SuspendLayout()
        Me.RibbonPanel3.SuspendLayout()
        CType(Me.DataVale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTarjetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDetallePago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanel1.SuspendLayout()
        Me.PanelCheque.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        '
        'RibbonTabItem1
        '
        Me.RibbonTabItem1.Checked = True
        Me.RibbonTabItem1.Name = "RibbonTabItem1"
        Me.RibbonTabItem1.Text = "RibbonTabItem1"
        '
        'RibbonControl1
        '
        '
        '
        '
        Me.RibbonControl1.BackgroundStyle.Class = ""
        Me.RibbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonControl1.CaptionVisible = True
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel2)
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel4)
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel3)
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel1)
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ptnCheque, Me.PtnTarjeta, Me.ptnVale, Me.DATOS})
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass
        Me.RibbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.RibbonControl1.Size = New System.Drawing.Size(577, 238)
        Me.RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonControl1.TabGroupHeight = 14
        Me.RibbonControl1.TabIndex = 0
        Me.RibbonControl1.Text = "RibbonControl1"
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel4.Controls.Add(Me.panelvale)
        Me.RibbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel4.Location = New System.Drawing.Point(0, 56)
        Me.RibbonPanel4.Name = "RibbonPanel4"
        Me.RibbonPanel4.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel4.Size = New System.Drawing.Size(577, 180)
        '
        '
        '
        Me.RibbonPanel4.Style.Class = ""
        Me.RibbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel4.StyleMouseDown.Class = ""
        Me.RibbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel4.StyleMouseOver.Class = ""
        Me.RibbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel4.TabIndex = 4
        Me.RibbonPanel4.Visible = False
        '
        'panelvale
        '
        Me.panelvale.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelvale.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.panelvale.Controls.Add(Me.combovale)
        Me.panelvale.Controls.Add(Me.TextImportV)
        Me.panelvale.Controls.Add(Me.Label7)
        Me.panelvale.Controls.Add(Me.lbcobroV)
        Me.panelvale.Controls.Add(Me.btCancelarV)
        Me.panelvale.Controls.Add(Me.btAceptarV)
        Me.panelvale.Controls.Add(Me.Label11)
        Me.panelvale.Location = New System.Drawing.Point(131, 19)
        Me.panelvale.Name = "panelvale"
        Me.panelvale.Size = New System.Drawing.Size(321, 140)
        '
        '
        '
        Me.panelvale.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelvale.Style.BackColorGradientAngle = 90
        Me.panelvale.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelvale.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelvale.Style.BorderBottomWidth = 1
        Me.panelvale.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelvale.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelvale.Style.BorderLeftWidth = 1
        Me.panelvale.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelvale.Style.BorderRightWidth = 1
        Me.panelvale.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelvale.Style.BorderTopWidth = 1
        Me.panelvale.Style.Class = ""
        Me.panelvale.Style.CornerDiameter = 4
        Me.panelvale.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.panelvale.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.panelvale.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelvale.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.panelvale.StyleMouseDown.Class = ""
        Me.panelvale.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.panelvale.StyleMouseOver.Class = ""
        Me.panelvale.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.panelvale.TabIndex = 1
        '
        'combovale
        '
        Me.combovale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.combovale.FormattingEnabled = True
        Me.combovale.Items.AddRange(New Object() {"100", "200", "500"})
        Me.combovale.Location = New System.Drawing.Point(167, 20)
        Me.combovale.Name = "combovale"
        Me.combovale.Size = New System.Drawing.Size(130, 21)
        Me.combovale.TabIndex = 61
        '
        'TextImportV
        '
        '
        '
        '
        Me.TextImportV.Border.Class = "TextBoxBorder"
        Me.TextImportV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextImportV.Location = New System.Drawing.Point(167, 53)
        Me.TextImportV.Name = "TextImportV"
        Me.TextImportV.Size = New System.Drawing.Size(128, 20)
        Me.TextImportV.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(84, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 22)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Importe:"
        '
        'lbcobroV
        '
        Me.lbcobroV.AutoSize = True
        Me.lbcobroV.Location = New System.Drawing.Point(3, 58)
        Me.lbcobroV.Name = "lbcobroV"
        Me.lbcobroV.Size = New System.Drawing.Size(39, 13)
        Me.lbcobroV.TabIndex = 58
        Me.lbcobroV.Text = "Label6"
        Me.lbcobroV.Visible = False
        '
        'btCancelarV
        '
        Me.btCancelarV.BackColor = System.Drawing.Color.Transparent
        Me.btCancelarV.BackgroundImage = Global.SoftSales.My.Resources.Resources.cancelar
        Me.btCancelarV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCancelarV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancelarV.FlatAppearance.BorderSize = 0
        Me.btCancelarV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btCancelarV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btCancelarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelarV.Location = New System.Drawing.Point(162, 86)
        Me.btCancelarV.Name = "btCancelarV"
        Me.btCancelarV.Size = New System.Drawing.Size(123, 35)
        Me.btCancelarV.TabIndex = 57
        Me.btCancelarV.UseVisualStyleBackColor = True
        '
        'btAceptarV
        '
        Me.btAceptarV.BackColor = System.Drawing.Color.Transparent
        Me.btAceptarV.BackgroundImage = Global.SoftSales.My.Resources.Resources.aceptar
        Me.btAceptarV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btAceptarV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAceptarV.FlatAppearance.BorderSize = 0
        Me.btAceptarV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btAceptarV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btAceptarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAceptarV.Location = New System.Drawing.Point(33, 86)
        Me.btAceptarV.Name = "btAceptarV"
        Me.btAceptarV.Size = New System.Drawing.Size(123, 35)
        Me.btAceptarV.TabIndex = 56
        Me.btAceptarV.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(156, 22)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Monto del Vale:"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel2.Controls.Add(Me.PanelTarjeta)
        Me.RibbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel2.Location = New System.Drawing.Point(0, 56)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel2.Size = New System.Drawing.Size(577, 180)
        '
        '
        '
        Me.RibbonPanel2.Style.Class = ""
        Me.RibbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseDown.Class = ""
        Me.RibbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseOver.Class = ""
        Me.RibbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel2.TabIndex = 2
        '
        'PanelTarjeta
        '
        Me.PanelTarjeta.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelTarjeta.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelTarjeta.Controls.Add(Me.TextImporteT)
        Me.PanelTarjeta.Controls.Add(Me.Label9)
        Me.PanelTarjeta.Controls.Add(Me.lbTotalCobroT)
        Me.PanelTarjeta.Controls.Add(Me.btCancelarT)
        Me.PanelTarjeta.Controls.Add(Me.btAceptarT)
        Me.PanelTarjeta.Controls.Add(Me.TextAutorizar)
        Me.PanelTarjeta.Controls.Add(Me.TextNoTarjeta)
        Me.PanelTarjeta.Controls.Add(Me.Label8)
        Me.PanelTarjeta.Controls.Add(Me.Label6)
        Me.PanelTarjeta.Location = New System.Drawing.Point(93, 13)
        Me.PanelTarjeta.Name = "PanelTarjeta"
        Me.PanelTarjeta.Size = New System.Drawing.Size(395, 153)
        '
        '
        '
        Me.PanelTarjeta.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelTarjeta.Style.BackColorGradientAngle = 90
        Me.PanelTarjeta.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelTarjeta.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.PanelTarjeta.Style.BorderBottomWidth = 1
        Me.PanelTarjeta.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelTarjeta.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.PanelTarjeta.Style.BorderLeftWidth = 1
        Me.PanelTarjeta.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.PanelTarjeta.Style.BorderRightWidth = 1
        Me.PanelTarjeta.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.PanelTarjeta.Style.BorderTopWidth = 1
        Me.PanelTarjeta.Style.Class = ""
        Me.PanelTarjeta.Style.CornerDiameter = 4
        Me.PanelTarjeta.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.PanelTarjeta.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.PanelTarjeta.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelTarjeta.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.PanelTarjeta.StyleMouseDown.Class = ""
        Me.PanelTarjeta.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.PanelTarjeta.StyleMouseOver.Class = ""
        Me.PanelTarjeta.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PanelTarjeta.TabIndex = 0
        '
        'TextImporteT
        '
        '
        '
        '
        Me.TextImporteT.Border.Class = "TextBoxBorder"
        Me.TextImporteT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextImporteT.Location = New System.Drawing.Point(167, 78)
        Me.TextImporteT.Name = "TextImporteT"
        Me.TextImporteT.Size = New System.Drawing.Size(128, 20)
        Me.TextImporteT.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(84, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 22)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Importe:"
        '
        'lbTotalCobroT
        '
        Me.lbTotalCobroT.AutoSize = True
        Me.lbTotalCobroT.Location = New System.Drawing.Point(9, 125)
        Me.lbTotalCobroT.Name = "lbTotalCobroT"
        Me.lbTotalCobroT.Size = New System.Drawing.Size(39, 13)
        Me.lbTotalCobroT.TabIndex = 58
        Me.lbTotalCobroT.Text = "Label6"
        Me.lbTotalCobroT.Visible = False
        '
        'btCancelarT
        '
        Me.btCancelarT.BackColor = System.Drawing.Color.Transparent
        Me.btCancelarT.BackgroundImage = Global.SoftSales.My.Resources.Resources.cancelar
        Me.btCancelarT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCancelarT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancelarT.FlatAppearance.BorderSize = 0
        Me.btCancelarT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btCancelarT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btCancelarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelarT.Location = New System.Drawing.Point(193, 107)
        Me.btCancelarT.Name = "btCancelarT"
        Me.btCancelarT.Size = New System.Drawing.Size(123, 35)
        Me.btCancelarT.TabIndex = 57
        Me.btCancelarT.UseVisualStyleBackColor = True
        '
        'btAceptarT
        '
        Me.btAceptarT.BackColor = System.Drawing.Color.Transparent
        Me.btAceptarT.BackgroundImage = Global.SoftSales.My.Resources.Resources.aceptar
        Me.btAceptarT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btAceptarT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAceptarT.FlatAppearance.BorderSize = 0
        Me.btAceptarT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btAceptarT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btAceptarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAceptarT.Location = New System.Drawing.Point(64, 107)
        Me.btAceptarT.Name = "btAceptarT"
        Me.btAceptarT.Size = New System.Drawing.Size(123, 35)
        Me.btAceptarT.TabIndex = 56
        Me.btAceptarT.UseVisualStyleBackColor = True
        '
        'TextAutorizar
        '
        '
        '
        '
        Me.TextAutorizar.Border.Class = "TextBoxBorder"
        Me.TextAutorizar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextAutorizar.Location = New System.Drawing.Point(129, 46)
        Me.TextAutorizar.Name = "TextAutorizar"
        Me.TextAutorizar.Size = New System.Drawing.Size(206, 20)
        Me.TextAutorizar.TabIndex = 4
        '
        'TextNoTarjeta
        '
        '
        '
        '
        Me.TextNoTarjeta.Border.Class = "TextBoxBorder"
        Me.TextNoTarjeta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextNoTarjeta.Location = New System.Drawing.Point(129, 10)
        Me.TextNoTarjeta.MaxLength = 4
        Me.TextNoTarjeta.Name = "TextNoTarjeta"
        Me.TextNoTarjeta.Size = New System.Drawing.Size(206, 20)
        Me.TextNoTarjeta.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 22)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Autorización:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "No. Tarjeta:"
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel3.Controls.Add(Me.DataVale)
        Me.RibbonPanel3.Controls.Add(Me.DataTarjetas)
        Me.RibbonPanel3.Controls.Add(Me.DataCheques)
        Me.RibbonPanel3.Controls.Add(Me.DataDetallePago)
        Me.RibbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel3.Location = New System.Drawing.Point(0, 56)
        Me.RibbonPanel3.Name = "RibbonPanel3"
        Me.RibbonPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel3.Size = New System.Drawing.Size(577, 180)
        '
        '
        '
        Me.RibbonPanel3.Style.Class = ""
        Me.RibbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseDown.Class = ""
        Me.RibbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseOver.Class = ""
        Me.RibbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel3.TabIndex = 3
        Me.RibbonPanel3.Visible = False
        '
        'DataVale
        '
        Me.DataVale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataVale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DataVale.Location = New System.Drawing.Point(357, -2)
        Me.DataVale.Name = "DataVale"
        Me.DataVale.Size = New System.Drawing.Size(212, 58)
        Me.DataVale.TabIndex = 3
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Referencia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Monto Vale"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataTarjetas
        '
        Me.DataTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTarjetas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rt, Me.nt, Me.autorizacion})
        Me.DataTarjetas.Location = New System.Drawing.Point(108, 117)
        Me.DataTarjetas.Name = "DataTarjetas"
        Me.DataTarjetas.Size = New System.Drawing.Size(344, 57)
        Me.DataTarjetas.TabIndex = 2
        '
        'rt
        '
        Me.rt.HeaderText = "referenciat"
        Me.rt.Name = "rt"
        '
        'nt
        '
        Me.nt.HeaderText = "NoTarjeta"
        Me.nt.Name = "nt"
        '
        'autorizacion
        '
        Me.autorizacion.HeaderText = "Autorizacion"
        Me.autorizacion.Name = "autorizacion"
        '
        'DataCheques
        '
        Me.DataCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataCheques.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.r, Me.cb, Me.numcheque, Me.idb, Me.tt})
        Me.DataCheques.Location = New System.Drawing.Point(12, 54)
        Me.DataCheques.Name = "DataCheques"
        Me.DataCheques.Size = New System.Drawing.Size(539, 63)
        Me.DataCheques.TabIndex = 1
        '
        'r
        '
        Me.r.HeaderText = "Referencia"
        Me.r.Name = "r"
        '
        'cb
        '
        Me.cb.HeaderText = "CuentaBanco"
        Me.cb.Name = "cb"
        '
        'numcheque
        '
        Me.numcheque.HeaderText = "NoCheque"
        Me.numcheque.Name = "numcheque"
        '
        'idb
        '
        Me.idb.HeaderText = "idBanco"
        Me.idb.Name = "idb"
        '
        'tt
        '
        Me.tt.HeaderText = "Titular"
        Me.tt.Name = "tt"
        '
        'DataDetallePago
        '
        Me.DataDetallePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataDetallePago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Folio, Me.Referencia, Me.importe})
        Me.DataDetallePago.Location = New System.Drawing.Point(12, -2)
        Me.DataDetallePago.Name = "DataDetallePago"
        Me.DataDetallePago.Size = New System.Drawing.Size(344, 58)
        Me.DataDetallePago.TabIndex = 0
        '
        'Folio
        '
        Me.Folio.HeaderText = "Folio"
        Me.Folio.Name = "Folio"
        '
        'Referencia
        '
        Me.Referencia.HeaderText = "Referencia"
        Me.Referencia.Name = "Referencia"
        '
        'importe
        '
        Me.importe.HeaderText = "importe"
        Me.importe.Name = "importe"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel1.Controls.Add(Me.PanelCheque)
        Me.RibbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel1.Location = New System.Drawing.Point(0, 56)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel1.Size = New System.Drawing.Size(577, 180)
        '
        '
        '
        Me.RibbonPanel1.Style.Class = ""
        Me.RibbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseDown.Class = ""
        Me.RibbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseOver.Class = ""
        Me.RibbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel1.TabIndex = 1
        Me.RibbonPanel1.Visible = False
        '
        'PanelCheque
        '
        Me.PanelCheque.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelCheque.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelCheque.Controls.Add(Me.TextSucursal)
        Me.PanelCheque.Controls.Add(Me.ComboSucursal)
        Me.PanelCheque.Controls.Add(Me.lbTotalCobro)
        Me.PanelCheque.Controls.Add(Me.btCancelar)
        Me.PanelCheque.Controls.Add(Me.btAceptar)
        Me.PanelCheque.Controls.Add(Me.Label5)
        Me.PanelCheque.Controls.Add(Me.TextImporte)
        Me.PanelCheque.Controls.Add(Me.TextTitular)
        Me.PanelCheque.Controls.Add(Me.TextNCheque)
        Me.PanelCheque.Controls.Add(Me.TextCuenta)
        Me.PanelCheque.Controls.Add(Me.Label4)
        Me.PanelCheque.Controls.Add(Me.Label1)
        Me.PanelCheque.Controls.Add(Me.Label3)
        Me.PanelCheque.Controls.Add(Me.Label2)
        Me.PanelCheque.Location = New System.Drawing.Point(9, 13)
        Me.PanelCheque.Name = "PanelCheque"
        Me.PanelCheque.Size = New System.Drawing.Size(556, 153)
        '
        '
        '
        Me.PanelCheque.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelCheque.Style.BackColorGradientAngle = 90
        Me.PanelCheque.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelCheque.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.PanelCheque.Style.BorderBottomWidth = 1
        Me.PanelCheque.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelCheque.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.PanelCheque.Style.BorderLeftWidth = 1
        Me.PanelCheque.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.PanelCheque.Style.BorderRightWidth = 1
        Me.PanelCheque.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.PanelCheque.Style.BorderTopWidth = 1
        Me.PanelCheque.Style.Class = ""
        Me.PanelCheque.Style.CornerDiameter = 4
        Me.PanelCheque.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.PanelCheque.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.PanelCheque.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelCheque.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.PanelCheque.StyleMouseDown.Class = ""
        Me.PanelCheque.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.PanelCheque.StyleMouseOver.Class = ""
        Me.PanelCheque.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PanelCheque.TabIndex = 5
        '
        'TextSucursal
        '
        Me.TextSucursal.Location = New System.Drawing.Point(7, 122)
        Me.TextSucursal.Name = "TextSucursal"
        Me.TextSucursal.Size = New System.Drawing.Size(100, 20)
        Me.TextSucursal.TabIndex = 58
        Me.TextSucursal.Visible = False
        '
        'ComboSucursal
        '
        Me.ComboSucursal.DisplayMember = "Text"
        Me.ComboSucursal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboSucursal.FormattingEnabled = True
        Me.ComboSucursal.ItemHeight = 14
        Me.ComboSucursal.Location = New System.Drawing.Point(367, 15)
        Me.ComboSucursal.Name = "ComboSucursal"
        Me.ComboSucursal.Size = New System.Drawing.Size(163, 20)
        Me.ComboSucursal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboSucursal.TabIndex = 57
        '
        'lbTotalCobro
        '
        Me.lbTotalCobro.AutoSize = True
        Me.lbTotalCobro.Location = New System.Drawing.Point(229, 103)
        Me.lbTotalCobro.Name = "lbTotalCobro"
        Me.lbTotalCobro.Size = New System.Drawing.Size(39, 13)
        Me.lbTotalCobro.TabIndex = 56
        Me.lbTotalCobro.Text = "Label6"
        Me.lbTotalCobro.Visible = False
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btCancelar.BackgroundImage = Global.SoftSales.My.Resources.Resources.cancelar
        Me.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancelar.FlatAppearance.BorderSize = 0
        Me.btCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelar.Location = New System.Drawing.Point(422, 91)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(123, 35)
        Me.btCancelar.TabIndex = 55
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'btAceptar
        '
        Me.btAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btAceptar.BackgroundImage = Global.SoftSales.My.Resources.Resources.aceptar
        Me.btAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAceptar.FlatAppearance.BorderSize = 0
        Me.btAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAceptar.Location = New System.Drawing.Point(293, 93)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(123, 35)
        Me.btAceptar.TabIndex = 53
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 22)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Importe:"
        '
        'TextImporte
        '
        Me.TextImporte.Location = New System.Drawing.Point(96, 99)
        Me.TextImporte.Name = "TextImporte"
        Me.TextImporte.Size = New System.Drawing.Size(100, 20)
        Me.TextImporte.TabIndex = 10
        '
        'TextTitular
        '
        '
        '
        '
        Me.TextTitular.Border.Class = "TextBoxBorder"
        Me.TextTitular.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextTitular.Location = New System.Drawing.Point(352, 56)
        Me.TextTitular.Name = "TextTitular"
        Me.TextTitular.Size = New System.Drawing.Size(178, 20)
        Me.TextTitular.TabIndex = 9
        '
        'TextNCheque
        '
        '
        '
        '
        Me.TextNCheque.Border.Class = "TextBoxBorder"
        Me.TextNCheque.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextNCheque.Location = New System.Drawing.Point(126, 56)
        Me.TextNCheque.Name = "TextNCheque"
        Me.TextNCheque.Size = New System.Drawing.Size(125, 20)
        Me.TextNCheque.TabIndex = 8
        '
        'TextCuenta
        '
        '
        '
        '
        Me.TextCuenta.Border.Class = "TextBoxBorder"
        Me.TextCuenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextCuenta.Location = New System.Drawing.Point(85, 15)
        Me.TextCuenta.Name = "TextCuenta"
        Me.TextCuenta.Size = New System.Drawing.Size(166, 20)
        Me.TextCuenta.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(279, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Titular:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cuenta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sucursal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No. Cheque:"
        '
        'ptnCheque
        '
        Me.ptnCheque.Name = "ptnCheque"
        Me.ptnCheque.Panel = Me.RibbonPanel1
        Me.ptnCheque.Text = "CHEQUE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PtnTarjeta
        '
        Me.PtnTarjeta.Checked = True
        Me.PtnTarjeta.Name = "PtnTarjeta"
        Me.PtnTarjeta.Panel = Me.RibbonPanel2
        Me.PtnTarjeta.Text = "TARJETA"
        '
        'ptnVale
        '
        Me.ptnVale.Name = "ptnVale"
        Me.ptnVale.Panel = Me.RibbonPanel4
        Me.ptnVale.Text = "VALE"
        '
        'DATOS
        '
        Me.DATOS.Name = "DATOS"
        Me.DATOS.Panel = Me.RibbonPanel3
        Me.DATOS.Text = "DATOS"
        Me.DATOS.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'frmFormasPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 239)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFormasPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formas de Pago"
        Me.RibbonControl1.ResumeLayout(False)
        Me.RibbonControl1.PerformLayout()
        Me.RibbonPanel4.ResumeLayout(False)
        Me.panelvale.ResumeLayout(False)
        Me.panelvale.PerformLayout()
        Me.RibbonPanel2.ResumeLayout(False)
        Me.PanelTarjeta.ResumeLayout(False)
        Me.PanelTarjeta.PerformLayout()
        Me.RibbonPanel3.ResumeLayout(False)
        CType(Me.DataVale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTarjetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDetallePago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanel1.ResumeLayout(False)
        Me.PanelCheque.ResumeLayout(False)
        Me.PanelCheque.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents RibbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents RibbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RibbonPanel2 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents ptnCheque As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents PtnTarjeta As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents PanelCheque As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextImporte As System.Windows.Forms.TextBox
    Friend WithEvents TextTitular As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextNCheque As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextCuenta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btAceptar As System.Windows.Forms.Button
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents lbTotalCobro As System.Windows.Forms.Label
    Friend WithEvents RibbonPanel3 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents DataDetallePago As System.Windows.Forms.DataGridView
    Friend WithEvents Folio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Referencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATOS As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents ComboSucursal As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents TextSucursal As System.Windows.Forms.TextBox
    Friend WithEvents DataCheques As System.Windows.Forms.DataGridView
    Friend WithEvents r As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numcheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelTarjeta As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbTotalCobroT As System.Windows.Forms.Label
    Friend WithEvents btCancelarT As System.Windows.Forms.Button
    Friend WithEvents btAceptarT As System.Windows.Forms.Button
    Friend WithEvents TextAutorizar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextNoTarjeta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextImporteT As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DataTarjetas As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents rt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents autorizacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RibbonPanel4 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents ptnVale As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents panelvale As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents combovale As System.Windows.Forms.ComboBox
    Friend WithEvents TextImportV As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbcobroV As System.Windows.Forms.Label
    Friend WithEvents btCancelarV As System.Windows.Forms.Button
    Friend WithEvents btAceptarV As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataVale As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
