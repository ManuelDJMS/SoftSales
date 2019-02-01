<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCorteCaja
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
        Me.RibbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextTES = New System.Windows.Forms.TextBox()
        Me.TextTCS = New System.Windows.Forms.TextBox()
        Me.TextTTS = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TexxPrimerFolio = New System.Windows.Forms.TextBox()
        Me.panelFolios = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TextUltFolio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateFecha = New System.Windows.Forms.DateTimePicker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TextDiferencia = New System.Windows.Forms.TextBox()
        Me.TextObservaciones = New System.Windows.Forms.TextBox()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TextValeSis = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panelFolios.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.RibbonControl1.Enabled = False
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass
        Me.RibbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.RibbonControl1.Size = New System.Drawing.Size(641, 25)
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
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(205, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Corte de Caja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total en Efectivo (Sistema):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(262, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total en Cheques (Sistema):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(241, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total en Tarjeta (Sistema):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 22)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Diferencia:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(236, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 22)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Observaciones:"
        '
        'TextTES
        '
        Me.TextTES.Enabled = False
        Me.TextTES.Location = New System.Drawing.Point(274, 9)
        Me.TextTES.Name = "TextTES"
        Me.TextTES.Size = New System.Drawing.Size(148, 20)
        Me.TextTES.TabIndex = 10
        '
        'TextTCS
        '
        Me.TextTCS.Enabled = False
        Me.TextTCS.Location = New System.Drawing.Point(274, 45)
        Me.TextTCS.Name = "TextTCS"
        Me.TextTCS.Size = New System.Drawing.Size(148, 20)
        Me.TextTCS.TabIndex = 11
        '
        'TextTTS
        '
        Me.TextTTS.Enabled = False
        Me.TextTTS.Location = New System.Drawing.Point(274, 80)
        Me.TextTTS.Name = "TextTTS"
        Me.TextTTS.Size = New System.Drawing.Size(148, 20)
        Me.TextTTS.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 22)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Folios del Día:"
        '
        'TexxPrimerFolio
        '
        Me.TexxPrimerFolio.Enabled = False
        Me.TexxPrimerFolio.Location = New System.Drawing.Point(122, 11)
        Me.TexxPrimerFolio.Name = "TexxPrimerFolio"
        Me.TexxPrimerFolio.Size = New System.Drawing.Size(100, 20)
        Me.TexxPrimerFolio.TabIndex = 60
        '
        'panelFolios
        '
        Me.panelFolios.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelFolios.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.panelFolios.Controls.Add(Me.TextUltFolio)
        Me.panelFolios.Controls.Add(Me.Label12)
        Me.panelFolios.Controls.Add(Me.Label11)
        Me.panelFolios.Controls.Add(Me.TexxPrimerFolio)
        Me.panelFolios.Location = New System.Drawing.Point(147, 68)
        Me.panelFolios.Name = "panelFolios"
        Me.panelFolios.Size = New System.Drawing.Size(483, 49)
        '
        '
        '
        Me.panelFolios.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelFolios.Style.BackColorGradientAngle = 90
        Me.panelFolios.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelFolios.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelFolios.Style.BorderBottomWidth = 1
        Me.panelFolios.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelFolios.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelFolios.Style.BorderLeftWidth = 1
        Me.panelFolios.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelFolios.Style.BorderRightWidth = 1
        Me.panelFolios.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelFolios.Style.BorderTopWidth = 1
        Me.panelFolios.Style.Class = ""
        Me.panelFolios.Style.CornerDiameter = 4
        Me.panelFolios.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.panelFolios.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.panelFolios.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelFolios.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.panelFolios.StyleMouseDown.Class = ""
        Me.panelFolios.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.panelFolios.StyleMouseOver.Class = ""
        Me.panelFolios.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.panelFolios.TabIndex = 61
        '
        'TextUltFolio
        '
        Me.TextUltFolio.Enabled = False
        Me.TextUltFolio.Location = New System.Drawing.Point(346, 11)
        Me.TextUltFolio.Name = "TextUltFolio"
        Me.TextUltFolio.Size = New System.Drawing.Size(100, 20)
        Me.TextUltFolio.TabIndex = 63
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(228, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 22)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Último Folio:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 22)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Primer Folio:"
        '
        'DateFecha
        '
        Me.DateFecha.Location = New System.Drawing.Point(13, 336)
        Me.DateFecha.Name = "DateFecha"
        Me.DateFecha.Size = New System.Drawing.Size(165, 20)
        Me.DateFecha.TabIndex = 62
        Me.DateFecha.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TextDiferencia
        '
        Me.TextDiferencia.ForeColor = System.Drawing.Color.Gray
        Me.TextDiferencia.Location = New System.Drawing.Point(119, 309)
        Me.TextDiferencia.Name = "TextDiferencia"
        Me.TextDiferencia.Size = New System.Drawing.Size(100, 20)
        Me.TextDiferencia.TabIndex = 63
        Me.TextDiferencia.Text = "0"
        '
        'TextObservaciones
        '
        Me.TextObservaciones.ForeColor = System.Drawing.Color.Gray
        Me.TextObservaciones.Location = New System.Drawing.Point(396, 293)
        Me.TextObservaciones.Multiline = True
        Me.TextObservaciones.Name = "TextObservaciones"
        Me.TextObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextObservaciones.Size = New System.Drawing.Size(213, 63)
        Me.TextObservaciones.TabIndex = 64
        Me.TextObservaciones.Text = "Ninguna Observación"
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
        Me.btCancelar.Location = New System.Drawing.Point(309, 376)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(123, 35)
        Me.btCancelar.TabIndex = 56
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
        Me.btAceptar.Location = New System.Drawing.Point(178, 376)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(123, 35)
        Me.btAceptar.TabIndex = 55
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 22)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Desglose"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 22)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "de Ingresos:"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.TextValeSis)
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.TextTTS)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.TextTCS)
        Me.GroupPanel1.Controls.Add(Me.TextTES)
        Me.GroupPanel1.Location = New System.Drawing.Point(147, 123)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(449, 153)
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
        Me.GroupPanel1.TabIndex = 69
        '
        'TextValeSis
        '
        Me.TextValeSis.Enabled = False
        Me.TextValeSis.Location = New System.Drawing.Point(274, 113)
        Me.TextValeSis.Name = "TextValeSis"
        Me.TextValeSis.Size = New System.Drawing.Size(148, 20)
        Me.TextValeSis.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(229, 22)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total en Vales (Sistema):"
        '
        'frmCorteCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(641, 430)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextObservaciones)
        Me.Controls.Add(Me.TextDiferencia)
        Me.Controls.Add(Me.DateFecha)
        Me.Controls.Add(Me.panelFolios)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCorteCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cerrar Sesión"
        Me.panelFolios.ResumeLayout(False)
        Me.panelFolios.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextTES As System.Windows.Forms.TextBox
    Friend WithEvents TextTCS As System.Windows.Forms.TextBox
    Friend WithEvents TextTTS As System.Windows.Forms.TextBox
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents btAceptar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TexxPrimerFolio As System.Windows.Forms.TextBox
    Friend WithEvents panelFolios As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TextUltFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents TextObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents TextDiferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TextValeSis As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
