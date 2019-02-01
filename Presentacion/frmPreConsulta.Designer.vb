<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreConsulta
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
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.TextFolioV = New System.Windows.Forms.TextBox()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.lbParrafo1 = New System.Windows.Forms.Label()
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
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass
        Me.RibbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.RibbonControl1.Size = New System.Drawing.Size(307, 28)
        Me.RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonControl1.TabGroupHeight = 14
        Me.RibbonControl1.TabIndex = 0
        Me.RibbonControl1.Text = "RibbonControl1"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        '
        'btBuscar
        '
        Me.btBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btBuscar.BackgroundImage = Global.SoftSales.My.Resources.Resources.btbuscar
        Me.btBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btBuscar.FlatAppearance.BorderSize = 0
        Me.btBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscar.Location = New System.Drawing.Point(26, 84)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(123, 35)
        Me.btBuscar.TabIndex = 60
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'TextFolioV
        '
        Me.TextFolioV.Location = New System.Drawing.Point(176, 53)
        Me.TextFolioV.Name = "TextFolioV"
        Me.TextFolioV.Size = New System.Drawing.Size(100, 20)
        Me.TextFolioV.TabIndex = 59
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btCancelar.BackgroundImage = Global.SoftSales.My.Resources.Resources.BTCERRAR
        Me.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancelar.FlatAppearance.BorderSize = 0
        Me.btCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancelar.Location = New System.Drawing.Point(155, 84)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(123, 35)
        Me.btCancelar.TabIndex = 58
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'lbParrafo1
        '
        Me.lbParrafo1.AutoSize = True
        Me.lbParrafo1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbParrafo1.Location = New System.Drawing.Point(22, 53)
        Me.lbParrafo1.Name = "lbParrafo1"
        Me.lbParrafo1.Size = New System.Drawing.Size(148, 22)
        Me.lbParrafo1.TabIndex = 57
        Me.lbParrafo1.Text = "Folio de Venta:"
        '
        'frmPreConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 130)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.TextFolioV)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.lbParrafo1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPreConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Venta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents btBuscar As System.Windows.Forms.Button
    Friend WithEvents TextFolioV As System.Windows.Forms.TextBox
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents lbParrafo1 As System.Windows.Forms.Label
End Class
