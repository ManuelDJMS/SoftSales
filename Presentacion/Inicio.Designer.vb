<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbsecond = New System.Windows.Forms.Label()
        Me.CircularProgressBar1 = New CircularProgressBar.CircularProgressBar()
        Me.lbhora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.lbIniciar = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelImagen = New System.Windows.Forms.Panel()
        Me.TextPass = New System.Windows.Forms.TextBox()
        Me.TextUsuario = New System.Windows.Forms.TextBox()
        Me.imgSesion = New System.Windows.Forms.PictureBox()
        Me.imgRoberto = New System.Windows.Forms.PictureBox()
        Me.btcancelar = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btaceptar = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelImagen.SuspendLayout()
        CType(Me.imgSesion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgRoberto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(96, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BIENVENIDO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Controls.Add(Me.lbsecond)
        Me.Panel1.Controls.Add(Me.CircularProgressBar1)
        Me.Panel1.Controls.Add(Me.lbhora)
        Me.Panel1.Location = New System.Drawing.Point(-1, 373)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(379, 125)
        Me.Panel1.TabIndex = 2
        '
        'lbsecond
        '
        Me.lbsecond.AutoSize = True
        Me.lbsecond.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbsecond.ForeColor = System.Drawing.Color.White
        Me.lbsecond.Location = New System.Drawing.Point(63, 23)
        Me.lbsecond.Name = "lbsecond"
        Me.lbsecond.Size = New System.Drawing.Size(32, 23)
        Me.lbsecond.TabIndex = 5
        Me.lbsecond.Text = "25"
        '
        'CircularProgressBar1
        '
        Me.CircularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar1.AnimationSpeed = 500
        Me.CircularProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CircularProgressBar1.InnerColor = System.Drawing.SystemColors.ButtonShadow
        Me.CircularProgressBar1.InnerMargin = 2
        Me.CircularProgressBar1.InnerWidth = -1
        Me.CircularProgressBar1.Location = New System.Drawing.Point(46, 1)
        Me.CircularProgressBar1.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar1.Maximum = 60
        Me.CircularProgressBar1.Name = "CircularProgressBar1"
        Me.CircularProgressBar1.OuterColor = System.Drawing.Color.Gray
        Me.CircularProgressBar1.OuterMargin = -10
        Me.CircularProgressBar1.OuterWidth = 10
        Me.CircularProgressBar1.ProgressColor = System.Drawing.Color.White
        Me.CircularProgressBar1.ProgressWidth = 10
        Me.CircularProgressBar1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CircularProgressBar1.Size = New System.Drawing.Size(65, 65)
        Me.CircularProgressBar1.StartAngle = 270
        Me.CircularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar1.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar1.SubscriptText = ""
        Me.CircularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar1.SuperscriptText = ""
        Me.CircularProgressBar1.TabIndex = 5
        Me.CircularProgressBar1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar1.Value = 25
        '
        'lbhora
        '
        Me.lbhora.AutoSize = True
        Me.lbhora.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbhora.ForeColor = System.Drawing.Color.White
        Me.lbhora.Location = New System.Drawing.Point(132, 15)
        Me.lbhora.Name = "lbhora"
        Me.lbhora.Size = New System.Drawing.Size(135, 32)
        Me.lbhora.TabIndex = 4
        Me.lbhora.Text = "00:00 AM"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 1000
        '
        'lbIniciar
        '
        Me.lbIniciar.AutoSize = True
        Me.lbIniciar.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIniciar.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbIniciar.Location = New System.Drawing.Point(378, 9)
        Me.lbIniciar.Name = "lbIniciar"
        Me.lbIniciar.Size = New System.Drawing.Size(185, 32)
        Me.lbIniciar.TabIndex = 4
        Me.lbIniciar.Text = "Iniciar Sesion"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PanelImagen
        '
        Me.PanelImagen.BackColor = System.Drawing.Color.Transparent
        Me.PanelImagen.Controls.Add(Me.TextPass)
        Me.PanelImagen.Controls.Add(Me.TextUsuario)
        Me.PanelImagen.Controls.Add(Me.imgSesion)
        Me.PanelImagen.Location = New System.Drawing.Point(364, 107)
        Me.PanelImagen.Name = "PanelImagen"
        Me.PanelImagen.Size = New System.Drawing.Size(371, 139)
        Me.PanelImagen.TabIndex = 12
        '
        'TextPass
        '
        Me.TextPass.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextPass.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPass.Location = New System.Drawing.Point(85, 76)
        Me.TextPass.Name = "TextPass"
        Me.TextPass.Size = New System.Drawing.Size(255, 31)
        Me.TextPass.TabIndex = 13
        Me.TextPass.UseSystemPasswordChar = True
        '
        'TextUsuario
        '
        Me.TextUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextUsuario.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUsuario.Location = New System.Drawing.Point(85, 34)
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.Size = New System.Drawing.Size(255, 31)
        Me.TextUsuario.TabIndex = 12
        Me.TextUsuario.UseSystemPasswordChar = True
        '
        'imgSesion
        '
        Me.imgSesion.Image = Global.SoftSales.My.Resources.Resources.sesion
        Me.imgSesion.Location = New System.Drawing.Point(-11, 7)
        Me.imgSesion.Name = "imgSesion"
        Me.imgSesion.Size = New System.Drawing.Size(380, 131)
        Me.imgSesion.TabIndex = 9
        Me.imgSesion.TabStop = False
        '
        'imgRoberto
        '
        Me.imgRoberto.Image = Global.SoftSales.My.Resources.Resources.GUARDAR
        Me.imgRoberto.Location = New System.Drawing.Point(391, 50)
        Me.imgRoberto.Name = "imgRoberto"
        Me.imgRoberto.Size = New System.Drawing.Size(139, 108)
        Me.imgRoberto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgRoberto.TabIndex = 13
        Me.imgRoberto.TabStop = False
        Me.imgRoberto.Visible = False
        '
        'btcancelar
        '
        Me.btcancelar.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btcancelar.BackgroundImage = Global.SoftSales.My.Resources.Resources.cerrar
        Me.btcancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btcancelar.Location = New System.Drawing.Point(183, 373)
        Me.btcancelar.Name = "btcancelar"
        Me.btcancelar.Size = New System.Drawing.Size(170, 49)
        Me.btcancelar.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.SoftSales.My.Resources.Resources.sofsales
        Me.PictureBox1.Location = New System.Drawing.Point(77, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btaceptar
        '
        Me.btaceptar.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btaceptar.BackgroundImage = Global.SoftSales.My.Resources.Resources.entrar
        Me.btaceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btaceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btaceptar.Location = New System.Drawing.Point(10, 373)
        Me.btaceptar.Name = "btaceptar"
        Me.btaceptar.Size = New System.Drawing.Size(172, 49)
        Me.btaceptar.TabIndex = 3
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 379)
        Me.Controls.Add(Me.imgRoberto)
        Me.Controls.Add(Me.PanelImagen)
        Me.Controls.Add(Me.lbIniciar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btcancelar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btaceptar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesión"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelImagen.ResumeLayout(False)
        Me.PanelImagen.PerformLayout()
        CType(Me.imgSesion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgRoberto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btcancelar As System.Windows.Forms.Panel
    Friend WithEvents btaceptar As System.Windows.Forms.Panel
    Friend WithEvents lbhora As System.Windows.Forms.Label
    Friend WithEvents lbsecond As System.Windows.Forms.Label
    Friend WithEvents CircularProgressBar1 As CircularProgressBar.CircularProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents lbIniciar As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents imgSesion As System.Windows.Forms.PictureBox
    Friend WithEvents PanelImagen As System.Windows.Forms.Panel
    Friend WithEvents TextPass As System.Windows.Forms.TextBox
    Friend WithEvents TextUsuario As System.Windows.Forms.TextBox
    Friend WithEvents imgRoberto As System.Windows.Forms.PictureBox

End Class
