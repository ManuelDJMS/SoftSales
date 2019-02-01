<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOfertas
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
        Me.GalleryContainer2 = New DevComponents.DotNetBar.GalleryContainer()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.RibbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btNuevo = New System.Windows.Forms.Button()
        Me.panelOferta = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ComboMDdepto = New System.Windows.Forms.ComboBox()
        Me.comboMDmarca = New System.Windows.Forms.ComboBox()
        Me.rbMD = New System.Windows.Forms.RadioButton()
        Me.ComboMarca = New System.Windows.Forms.ComboBox()
        Me.ComboDepto = New System.Windows.Forms.ComboBox()
        Me.rbDepto = New System.Windows.Forms.RadioButton()
        Me.rbTipo = New System.Windows.Forms.RadioButton()
        Me.rbIndividual = New System.Windows.Forms.RadioButton()
        Me.TextIndividual = New System.Windows.Forms.TextBox()
        Me.ComboOferta = New System.Windows.Forms.ComboBox()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextDescricion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupPanel1.SuspendLayout()
        Me.panelOferta.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GalleryContainer2
        '
        '
        '
        '
        Me.GalleryContainer2.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer"
        Me.GalleryContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GalleryContainer2.EnableGalleryPopup = False
        Me.GalleryContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.GalleryContainer2.MinimumSize = New System.Drawing.Size(180, 240)
        Me.GalleryContainer2.MultiLine = False
        Me.GalleryContainer2.Name = "GalleryContainer2"
        Me.GalleryContainer2.PopupUsesStandardScrollbars = False
        '
        'LabelItem1
        '
        Me.LabelItem1.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.LabelItem1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelItem1.CanCustomize = False
        Me.LabelItem1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelItem1.Name = "LabelItem1"
        '
        'RibbonControl1
        '
        '
        '
        '
        Me.RibbonControl1.BackgroundStyle.Class = ""
        Me.RibbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonControl1.CaptionVisible = True
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass
        Me.RibbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.RibbonControl1.Size = New System.Drawing.Size(498, 26)
        Me.RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonControl1.TabGroupHeight = 14
        Me.RibbonControl1.TabIndex = 0
        Me.RibbonControl1.Text = "RibbonControl1"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(60, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ofertas del Día"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btNuevo)
        Me.GroupPanel1.Controls.Add(Me.panelOferta)
        Me.GroupPanel1.Controls.Add(Me.ComboOferta)
        Me.GroupPanel1.Controls.Add(Me.btCancelar)
        Me.GroupPanel1.Controls.Add(Me.btAceptar)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.TextDescricion)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 77)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(473, 330)
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
        Me.GroupPanel1.TabIndex = 1
        '
        'btNuevo
        '
        Me.btNuevo.BackColor = System.Drawing.Color.Transparent
        Me.btNuevo.BackgroundImage = Global.SoftSales.My.Resources.Resources.GUARDAR
        Me.btNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNuevo.Enabled = False
        Me.btNuevo.FlatAppearance.BorderSize = 0
        Me.btNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNuevo.Location = New System.Drawing.Point(168, 275)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(123, 35)
        Me.btNuevo.TabIndex = 60
        Me.btNuevo.UseVisualStyleBackColor = True
        '
        'panelOferta
        '
        Me.panelOferta.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelOferta.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.panelOferta.Controls.Add(Me.ComboMDdepto)
        Me.panelOferta.Controls.Add(Me.comboMDmarca)
        Me.panelOferta.Controls.Add(Me.rbMD)
        Me.panelOferta.Controls.Add(Me.ComboMarca)
        Me.panelOferta.Controls.Add(Me.ComboDepto)
        Me.panelOferta.Controls.Add(Me.rbDepto)
        Me.panelOferta.Controls.Add(Me.rbTipo)
        Me.panelOferta.Controls.Add(Me.rbIndividual)
        Me.panelOferta.Controls.Add(Me.TextIndividual)
        Me.panelOferta.Enabled = False
        Me.panelOferta.Location = New System.Drawing.Point(39, 42)
        Me.panelOferta.Name = "panelOferta"
        Me.panelOferta.Size = New System.Drawing.Size(397, 180)
        '
        '
        '
        Me.panelOferta.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelOferta.Style.BackColorGradientAngle = 90
        Me.panelOferta.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelOferta.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelOferta.Style.BorderBottomWidth = 1
        Me.panelOferta.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelOferta.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelOferta.Style.BorderLeftWidth = 1
        Me.panelOferta.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelOferta.Style.BorderRightWidth = 1
        Me.panelOferta.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelOferta.Style.BorderTopWidth = 1
        Me.panelOferta.Style.Class = ""
        Me.panelOferta.Style.CornerDiameter = 4
        Me.panelOferta.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.panelOferta.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.panelOferta.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelOferta.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.panelOferta.StyleMouseDown.Class = ""
        Me.panelOferta.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.panelOferta.StyleMouseOver.Class = ""
        Me.panelOferta.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.panelOferta.TabIndex = 59
        '
        'ComboMDdepto
        '
        Me.ComboMDdepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMDdepto.Enabled = False
        Me.ComboMDdepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboMDdepto.FormattingEnabled = True
        Me.ComboMDdepto.Location = New System.Drawing.Point(222, 101)
        Me.ComboMDdepto.Name = "ComboMDdepto"
        Me.ComboMDdepto.Size = New System.Drawing.Size(154, 21)
        Me.ComboMDdepto.TabIndex = 18
        '
        'comboMDmarca
        '
        Me.comboMDmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMDmarca.Enabled = False
        Me.comboMDmarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboMDmarca.FormattingEnabled = True
        Me.comboMDmarca.Location = New System.Drawing.Point(31, 101)
        Me.comboMDmarca.Name = "comboMDmarca"
        Me.comboMDmarca.Size = New System.Drawing.Size(154, 21)
        Me.comboMDmarca.TabIndex = 17
        '
        'rbMD
        '
        Me.rbMD.AutoSize = True
        Me.rbMD.BackColor = System.Drawing.Color.Transparent
        Me.rbMD.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMD.Location = New System.Drawing.Point(9, 69)
        Me.rbMD.Name = "rbMD"
        Me.rbMD.Size = New System.Drawing.Size(248, 26)
        Me.rbMD.TabIndex = 16
        Me.rbMD.TabStop = True
        Me.rbMD.Text = "Marca y Departamento"
        Me.rbMD.UseVisualStyleBackColor = False
        '
        'ComboMarca
        '
        Me.ComboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMarca.Enabled = False
        Me.ComboMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboMarca.FormattingEnabled = True
        Me.ComboMarca.Location = New System.Drawing.Point(184, 39)
        Me.ComboMarca.Name = "ComboMarca"
        Me.ComboMarca.Size = New System.Drawing.Size(192, 21)
        Me.ComboMarca.TabIndex = 15
        '
        'ComboDepto
        '
        Me.ComboDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboDepto.Enabled = False
        Me.ComboDepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboDepto.FormattingEnabled = True
        Me.ComboDepto.Location = New System.Drawing.Point(184, 3)
        Me.ComboDepto.Name = "ComboDepto"
        Me.ComboDepto.Size = New System.Drawing.Size(192, 21)
        Me.ComboDepto.TabIndex = 14
        '
        'rbDepto
        '
        Me.rbDepto.AutoSize = True
        Me.rbDepto.BackColor = System.Drawing.Color.Transparent
        Me.rbDepto.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDepto.Location = New System.Drawing.Point(9, 3)
        Me.rbDepto.Name = "rbDepto"
        Me.rbDepto.Size = New System.Drawing.Size(166, 26)
        Me.rbDepto.TabIndex = 10
        Me.rbDepto.TabStop = True
        Me.rbDepto.Text = "Departamento"
        Me.rbDepto.UseVisualStyleBackColor = False
        '
        'rbTipo
        '
        Me.rbTipo.AutoSize = True
        Me.rbTipo.BackColor = System.Drawing.Color.Transparent
        Me.rbTipo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTipo.Location = New System.Drawing.Point(9, 37)
        Me.rbTipo.Name = "rbTipo"
        Me.rbTipo.Size = New System.Drawing.Size(89, 26)
        Me.rbTipo.TabIndex = 11
        Me.rbTipo.TabStop = True
        Me.rbTipo.Text = "Marca"
        Me.rbTipo.UseVisualStyleBackColor = False
        '
        'rbIndividual
        '
        Me.rbIndividual.AutoSize = True
        Me.rbIndividual.BackColor = System.Drawing.Color.Transparent
        Me.rbIndividual.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbIndividual.Location = New System.Drawing.Point(9, 133)
        Me.rbIndividual.Name = "rbIndividual"
        Me.rbIndividual.Size = New System.Drawing.Size(118, 26)
        Me.rbIndividual.TabIndex = 12
        Me.rbIndividual.TabStop = True
        Me.rbIndividual.Text = "Individual"
        Me.rbIndividual.UseVisualStyleBackColor = False
        '
        'TextIndividual
        '
        Me.TextIndividual.Enabled = False
        Me.TextIndividual.Location = New System.Drawing.Point(184, 139)
        Me.TextIndividual.Name = "TextIndividual"
        Me.TextIndividual.Size = New System.Drawing.Size(192, 20)
        Me.TextIndividual.TabIndex = 13
        '
        'ComboOferta
        '
        Me.ComboOferta.Enabled = False
        Me.ComboOferta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboOferta.FormattingEnabled = True
        Me.ComboOferta.Items.AddRange(New Object() {"Descuento"})
        Me.ComboOferta.Location = New System.Drawing.Point(85, 237)
        Me.ComboOferta.Name = "ComboOferta"
        Me.ComboOferta.Size = New System.Drawing.Size(88, 21)
        Me.ComboOferta.TabIndex = 58
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
        Me.btCancelar.Location = New System.Drawing.Point(297, 275)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(123, 35)
        Me.btCancelar.TabIndex = 57
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'btAceptar
        '
        Me.btAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btAceptar.BackgroundImage = Global.SoftSales.My.Resources.Resources.nuevo
        Me.btAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAceptar.FlatAppearance.BorderSize = 0
        Me.btAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAceptar.Location = New System.Drawing.Point(39, 275)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(123, 35)
        Me.btAceptar.TabIndex = 56
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Crear una oferta por:"
        '
        'TextDescricion
        '
        Me.TextDescricion.Enabled = False
        Me.TextDescricion.Location = New System.Drawing.Point(314, 238)
        Me.TextDescricion.Name = "TextDescricion"
        Me.TextDescricion.Size = New System.Drawing.Size(122, 20)
        Me.TextDescricion.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Oferta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descripción:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmOfertas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 419)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOfertas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ofertas"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.panelOferta.ResumeLayout(False)
        Me.panelOferta.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GalleryContainer2 As DevComponents.DotNetBar.GalleryContainer
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TextDescricion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents btAceptar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ComboOferta As System.Windows.Forms.ComboBox
    Friend WithEvents panelOferta As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ComboMarca As System.Windows.Forms.ComboBox
    Friend WithEvents ComboDepto As System.Windows.Forms.ComboBox
    Friend WithEvents rbDepto As System.Windows.Forms.RadioButton
    Friend WithEvents rbTipo As System.Windows.Forms.RadioButton
    Friend WithEvents rbIndividual As System.Windows.Forms.RadioButton
    Friend WithEvents TextIndividual As System.Windows.Forms.TextBox
    Friend WithEvents btNuevo As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ComboMDdepto As System.Windows.Forms.ComboBox
    Friend WithEvents comboMDmarca As System.Windows.Forms.ComboBox
    Friend WithEvents rbMD As System.Windows.Forms.RadioButton
End Class
