<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaja
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.ComboCaja = New System.Windows.Forms.ComboBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnmin = New System.Windows.Forms.Button()
        Me.TextInicioimp = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.BackgroundImage = Global.SoftSales.My.Resources.Resources.cajas
        Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel1.Controls.Add(Me.lblHora)
        Me.panel1.Controls.Add(Me.lblFecha)
        Me.panel1.Controls.Add(Me.ComboCaja)
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Controls.Add(Me.btncerrar)
        Me.panel1.Controls.Add(Me.btnmin)
        Me.panel1.Controls.Add(Me.TextInicioimp)
        Me.panel1.Location = New System.Drawing.Point(0, -2)
        Me.panel1.Name = "panel1"
        Me.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.panel1.Size = New System.Drawing.Size(502, 287)
        Me.panel1.TabIndex = 11
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.lblHora.Location = New System.Drawing.Point(394, 237)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHora.Size = New System.Drawing.Size(48, 20)
        Me.lblHora.TabIndex = 8
        Me.lblHora.Text = "Hora"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.lblFecha.Location = New System.Drawing.Point(119, 237)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFecha.Size = New System.Drawing.Size(59, 20)
        Me.lblFecha.TabIndex = 9
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboCaja
        '
        Me.ComboCaja.BackColor = System.Drawing.Color.SkyBlue
        Me.ComboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboCaja.FormattingEnabled = True
        Me.ComboCaja.Items.AddRange(New Object() {"Caja 1", "Caja 2"})
        Me.ComboCaja.Location = New System.Drawing.Point(121, 106)
        Me.ComboCaja.Name = "ComboCaja"
        Me.ComboCaja.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboCaja.Size = New System.Drawing.Size(224, 21)
        Me.ComboCaja.TabIndex = 7
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox1.Image = Global.SoftSales.My.Resources.Resources.btn_ingresar_log1
        Me.pictureBox1.Location = New System.Drawing.Point(377, 111)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(65, 61)
        Me.pictureBox1.TabIndex = 6
        Me.pictureBox1.TabStop = False
        '
        'btncerrar
        '
        Me.btncerrar.BackgroundImage = Global.SoftSales.My.Resources.Resources.btn_cerrar
        Me.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncerrar.Location = New System.Drawing.Point(62, 233)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(35, 30)
        Me.btncerrar.TabIndex = 5
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnmin
        '
        Me.btnmin.BackgroundImage = Global.SoftSales.My.Resources.Resources.btn_min
        Me.btnmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmin.Location = New System.Drawing.Point(21, 233)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(35, 30)
        Me.btnmin.TabIndex = 4
        Me.btnmin.UseVisualStyleBackColor = True
        '
        'TextInicioimp
        '
        Me.TextInicioimp.BackColor = System.Drawing.Color.SkyBlue
        Me.TextInicioimp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextInicioimp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextInicioimp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextInicioimp.Location = New System.Drawing.Point(121, 160)
        Me.TextInicioimp.Name = "TextInicioimp"
        Me.TextInicioimp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextInicioimp.Size = New System.Drawing.Size(224, 19)
        Me.TextInicioimp.TabIndex = 0
        '
        'frmCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 284)
        Me.Controls.Add(Me.panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCaja"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComboCaja As System.Windows.Forms.ComboBox
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents btncerrar As System.Windows.Forms.Button
    Private WithEvents btnmin As System.Windows.Forms.Button
    Private WithEvents TextInicioimp As System.Windows.Forms.TextBox
    Private WithEvents lblHora As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
