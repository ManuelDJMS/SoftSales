﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSesion
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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnmin = New System.Windows.Forms.Button()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.BackgroundImage = Global.SoftSales.My.Resources.Resources.login2
        Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel1.Controls.Add(Me.PictureBox2)
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Controls.Add(Me.btncerrar)
        Me.panel1.Controls.Add(Me.btnmin)
        Me.panel1.Controls.Add(Me.lblHora)
        Me.panel1.Controls.Add(Me.lblFecha)
        Me.panel1.Controls.Add(Me.txtpass)
        Me.panel1.Controls.Add(Me.txtuser)
        Me.panel1.Location = New System.Drawing.Point(143, 61)
        Me.panel1.Name = "panel1"
        Me.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.panel1.Size = New System.Drawing.Size(500, 280)
        Me.panel1.TabIndex = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SoftSales.My.Resources.Resources.roberto
        Me.PictureBox2.Location = New System.Drawing.Point(253, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(114, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox1.Image = Global.SoftSales.My.Resources.Resources.btn_ingresar
        Me.pictureBox1.Location = New System.Drawing.Point(367, 87)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(90, 85)
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
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.SkyBlue
        Me.lblHora.Location = New System.Drawing.Point(389, 30)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHora.Size = New System.Drawing.Size(48, 20)
        Me.lblHora.TabIndex = 3
        Me.lblHora.Text = "Hora"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.lblFecha.Location = New System.Drawing.Point(194, 235)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFecha.Size = New System.Drawing.Size(59, 20)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.SkyBlue
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtpass.Location = New System.Drawing.Point(120, 155)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtpass.Size = New System.Drawing.Size(224, 22)
        Me.txtpass.TabIndex = 1
        Me.txtpass.UseSystemPasswordChar = True
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.SkyBlue
        Me.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtuser.Location = New System.Drawing.Point(120, 104)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtuser.Size = New System.Drawing.Size(224, 19)
        Me.txtuser.TabIndex = 0
        '
        'Timer1
        '
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SoftSales.My.Resources.Resources.logos
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(787, 402)
        Me.Controls.Add(Me.panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSesion"
        Me.Text = "frmSesion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents btncerrar As System.Windows.Forms.Button
    Private WithEvents btnmin As System.Windows.Forms.Button
    Private WithEvents lblHora As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Public WithEvents txtpass As System.Windows.Forms.TextBox
    Public WithEvents txtuser As System.Windows.Forms.TextBox
End Class
