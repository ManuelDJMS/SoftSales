<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormaPago
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
        Me.QatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.lbMensaje = New System.Windows.Forms.Label()
        Me.lbmonto = New System.Windows.Forms.Label()
        Me.textMonto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TxtCobro = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btCerrar = New System.Windows.Forms.Button()
        Me.btAceptar = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.QatCustomizeItem1})
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass
        Me.RibbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.RibbonControl1.Size = New System.Drawing.Size(411, 29)
        Me.RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonControl1.TabGroupHeight = 14
        Me.RibbonControl1.TabIndex = 0
        Me.RibbonControl1.Text = "RibbonControl1"
        '
        'QatCustomizeItem1
        '
        Me.QatCustomizeItem1.Name = "QatCustomizeItem1"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        '
        'lbMensaje
        '
        Me.lbMensaje.AutoSize = True
        Me.lbMensaje.BackColor = System.Drawing.Color.Transparent
        Me.lbMensaje.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMensaje.Location = New System.Drawing.Point(126, 47)
        Me.lbMensaje.Name = "lbMensaje"
        Me.lbMensaje.Size = New System.Drawing.Size(146, 22)
        Me.lbMensaje.TabIndex = 1
        Me.lbMensaje.Text = "Total a Cobrar:"
        '
        'lbmonto
        '
        Me.lbmonto.AutoSize = True
        Me.lbmonto.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmonto.Location = New System.Drawing.Point(116, 123)
        Me.lbmonto.Name = "lbmonto"
        Me.lbmonto.Size = New System.Drawing.Size(75, 22)
        Me.lbmonto.TabIndex = 3
        Me.lbmonto.Text = "Monto:"
        '
        'textMonto
        '
        '
        '
        '
        Me.textMonto.Border.Class = "TextBoxBorder"
        Me.textMonto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.textMonto.Location = New System.Drawing.Point(191, 125)
        Me.textMonto.Name = "textMonto"
        Me.textMonto.Size = New System.Drawing.Size(100, 20)
        Me.textMonto.TabIndex = 4
        '
        'TxtCobro
        '
        Me.TxtCobro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCobro.Enabled = False
        Me.TxtCobro.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCobro.Location = New System.Drawing.Point(0, 76)
        Me.TxtCobro.Name = "TxtCobro"
        Me.TxtCobro.Size = New System.Drawing.Size(411, 43)
        Me.TxtCobro.TabIndex = 54
        Me.TxtCobro.Text = "0.0"
        Me.TxtCobro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.SoftSales.My.Resources.Resources.cancelar
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(223, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 35)
        Me.Button1.TabIndex = 53
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btCerrar
        '
        Me.btCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btCerrar.BackgroundImage = Global.SoftSales.My.Resources.Resources.BTCERRAR
        Me.btCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCerrar.FlatAppearance.BorderSize = 0
        Me.btCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCerrar.Location = New System.Drawing.Point(223, 148)
        Me.btCerrar.Name = "btCerrar"
        Me.btCerrar.Size = New System.Drawing.Size(123, 35)
        Me.btCerrar.TabIndex = 55
        Me.btCerrar.UseVisualStyleBackColor = True
        Me.btCerrar.Visible = False
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
        Me.btAceptar.Location = New System.Drawing.Point(68, 148)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(123, 35)
        Me.btAceptar.TabIndex = 52
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'frmFormaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 195)
        Me.Controls.Add(Me.btCerrar)
        Me.Controls.Add(Me.TxtCobro)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.textMonto)
        Me.Controls.Add(Me.lbmonto)
        Me.Controls.Add(Me.lbMensaje)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFormaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Efectivo"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents QatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents lbMensaje As System.Windows.Forms.Label
    Friend WithEvents lbmonto As System.Windows.Forms.Label
    Friend WithEvents textMonto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btAceptar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtCobro As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btCerrar As System.Windows.Forms.Button
End Class
