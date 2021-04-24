<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTorneo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTorneo))
        Me.grdTorneo = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.TxtNomb = New System.Windows.Forms.TextBox()
        Me.dtpFR = New System.Windows.Forms.DateTimePicker()
        Me.numPrice = New System.Windows.Forms.NumericUpDown()
        Me.btnHistorial = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnParticipantes = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_act = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_elim = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_agre = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnBuscar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.cboCat = New System.Windows.Forms.ComboBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTiempo = New System.Windows.Forms.TextBox()
        CType(Me.grdTorneo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdTorneo
        '
        Me.grdTorneo.AllowUserToAddRows = False
        Me.grdTorneo.AllowUserToDeleteRows = False
        Me.grdTorneo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTorneo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.grdTorneo.Location = New System.Drawing.Point(545, 152)
        Me.grdTorneo.Name = "grdTorneo"
        Me.grdTorneo.ReadOnly = True
        Me.grdTorneo.RowTemplate.Height = 24
        Me.grdTorneo.Size = New System.Drawing.Size(982, 481)
        Me.grdTorneo.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tipo"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Fecha"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Lugar"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Categoria"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Precio Inscripcion"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Tiempo"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(223, 273)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(137, 22)
        Me.txtID.TabIndex = 2
        '
        'txtLugar
        '
        Me.txtLugar.Location = New System.Drawing.Point(222, 449)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(230, 22)
        Me.txtLugar.TabIndex = 4
        '
        'TxtNomb
        '
        Me.TxtNomb.Location = New System.Drawing.Point(223, 313)
        Me.TxtNomb.Name = "TxtNomb"
        Me.TxtNomb.Size = New System.Drawing.Size(229, 22)
        Me.TxtNomb.TabIndex = 8
        '
        'dtpFR
        '
        Me.dtpFR.CustomFormat = "yyyy-MM-dd"
        Me.dtpFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFR.Location = New System.Drawing.Point(222, 400)
        Me.dtpFR.Name = "dtpFR"
        Me.dtpFR.Size = New System.Drawing.Size(138, 22)
        Me.dtpFR.TabIndex = 9
        '
        'numPrice
        '
        Me.numPrice.Location = New System.Drawing.Point(223, 554)
        Me.numPrice.Name = "numPrice"
        Me.numPrice.Size = New System.Drawing.Size(137, 22)
        Me.numPrice.TabIndex = 10
        '
        'btnHistorial
        '
        Me.btnHistorial.ActiveBorderThickness = 1
        Me.btnHistorial.ActiveCornerRadius = 20
        Me.btnHistorial.ActiveFillColor = System.Drawing.Color.RoyalBlue
        Me.btnHistorial.ActiveForecolor = System.Drawing.Color.Maroon
        Me.btnHistorial.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnHistorial.BackColor = System.Drawing.SystemColors.Window
        Me.btnHistorial.BackgroundImage = CType(resources.GetObject("btnHistorial.BackgroundImage"), System.Drawing.Image)
        Me.btnHistorial.ButtonText = "Historial de Torneos"
        Me.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHistorial.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorial.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnHistorial.IdleBorderThickness = 1
        Me.btnHistorial.IdleCornerRadius = 20
        Me.btnHistorial.IdleFillColor = System.Drawing.Color.White
        Me.btnHistorial.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnHistorial.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnHistorial.Location = New System.Drawing.Point(14, 37)
        Me.btnHistorial.Margin = New System.Windows.Forms.Padding(5)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(229, 70)
        Me.btnHistorial.TabIndex = 14
        Me.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnParticipantes
        '
        Me.btnParticipantes.ActiveBorderThickness = 1
        Me.btnParticipantes.ActiveCornerRadius = 20
        Me.btnParticipantes.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnParticipantes.ActiveForecolor = System.Drawing.Color.White
        Me.btnParticipantes.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnParticipantes.BackColor = System.Drawing.SystemColors.Window
        Me.btnParticipantes.BackgroundImage = CType(resources.GetObject("btnParticipantes.BackgroundImage"), System.Drawing.Image)
        Me.btnParticipantes.ButtonText = "Participantes"
        Me.btnParticipantes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnParticipantes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParticipantes.ForeColor = System.Drawing.Color.Green
        Me.btnParticipantes.IdleBorderThickness = 1
        Me.btnParticipantes.IdleCornerRadius = 20
        Me.btnParticipantes.IdleFillColor = System.Drawing.Color.White
        Me.btnParticipantes.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnParticipantes.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnParticipantes.Location = New System.Drawing.Point(128, 140)
        Me.btnParticipantes.Margin = New System.Windows.Forms.Padding(5)
        Me.btnParticipantes.Name = "btnParticipantes"
        Me.btnParticipantes.Size = New System.Drawing.Size(232, 70)
        Me.btnParticipantes.TabIndex = 15
        Me.btnParticipantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ID de Torneo: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre de Torneo: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 359)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Tipo de Torneo: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Fecha de Torneo: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 452)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Lugar de Torneo: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 505)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Categoria de Torneo: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 559)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Precio de Inscripcion: "
        '
        'Btn_act
        '
        Me.Btn_act.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_act.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_act.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_act.BorderRadius = 0
        Me.Btn_act.ButtonText = "Actualizar"
        Me.Btn_act.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_act.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_act.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_act.Iconimage = Global.Main.My.Resources.Resources.actualizar
        Me.Btn_act.Iconimage_right = Nothing
        Me.Btn_act.Iconimage_right_Selected = Nothing
        Me.Btn_act.Iconimage_Selected = Nothing
        Me.Btn_act.IconMarginLeft = 0
        Me.Btn_act.IconMarginRight = 0
        Me.Btn_act.IconRightVisible = True
        Me.Btn_act.IconRightZoom = 0R
        Me.Btn_act.IconVisible = True
        Me.Btn_act.IconZoom = 90.0R
        Me.Btn_act.IsTab = False
        Me.Btn_act.Location = New System.Drawing.Point(927, 29)
        Me.Btn_act.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_act.Name = "Btn_act"
        Me.Btn_act.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_act.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_act.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_act.selected = False
        Me.Btn_act.Size = New System.Drawing.Size(249, 78)
        Me.Btn_act.TabIndex = 38
        Me.Btn_act.Text = "Actualizar"
        Me.Btn_act.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_act.Textcolor = System.Drawing.Color.White
        Me.Btn_act.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_elim
        '
        Me.Btn_elim.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_elim.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_elim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_elim.BorderRadius = 0
        Me.Btn_elim.ButtonText = "Eliminar"
        Me.Btn_elim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_elim.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_elim.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_elim.Iconimage = Global.Main.My.Resources.Resources.eliminar
        Me.Btn_elim.Iconimage_right = Nothing
        Me.Btn_elim.Iconimage_right_Selected = Nothing
        Me.Btn_elim.Iconimage_Selected = Nothing
        Me.Btn_elim.IconMarginLeft = 0
        Me.Btn_elim.IconMarginRight = 0
        Me.Btn_elim.IconRightVisible = True
        Me.Btn_elim.IconRightZoom = 0R
        Me.Btn_elim.IconVisible = True
        Me.Btn_elim.IconZoom = 90.0R
        Me.Btn_elim.IsTab = False
        Me.Btn_elim.Location = New System.Drawing.Point(1278, 29)
        Me.Btn_elim.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_elim.Name = "Btn_elim"
        Me.Btn_elim.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_elim.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_elim.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_elim.selected = False
        Me.Btn_elim.Size = New System.Drawing.Size(249, 78)
        Me.Btn_elim.TabIndex = 39
        Me.Btn_elim.Text = "Eliminar"
        Me.Btn_elim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_elim.Textcolor = System.Drawing.Color.White
        Me.Btn_elim.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_agre
        '
        Me.Btn_agre.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_agre.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_agre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_agre.BorderRadius = 0
        Me.Btn_agre.ButtonText = "Agregar"
        Me.Btn_agre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_agre.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_agre.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_agre.Iconimage = Global.Main.My.Resources.Resources.anadir
        Me.Btn_agre.Iconimage_right = Nothing
        Me.Btn_agre.Iconimage_right_Selected = Nothing
        Me.Btn_agre.Iconimage_Selected = Nothing
        Me.Btn_agre.IconMarginLeft = 0
        Me.Btn_agre.IconMarginRight = 0
        Me.Btn_agre.IconRightVisible = True
        Me.Btn_agre.IconRightZoom = 0R
        Me.Btn_agre.IconVisible = True
        Me.Btn_agre.IconZoom = 90.0R
        Me.Btn_agre.IsTab = False
        Me.Btn_agre.Location = New System.Drawing.Point(545, 29)
        Me.Btn_agre.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_agre.Name = "Btn_agre"
        Me.Btn_agre.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_agre.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_agre.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_agre.selected = False
        Me.Btn_agre.Size = New System.Drawing.Size(249, 78)
        Me.Btn_agre.TabIndex = 40
        Me.Btn_agre.Text = "Agregar"
        Me.Btn_agre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_agre.Textcolor = System.Drawing.Color.White
        Me.Btn_agre.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnBuscar
        '
        Me.btnBuscar.ActiveBorderThickness = 1
        Me.btnBuscar.ActiveCornerRadius = 20
        Me.btnBuscar.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnBuscar.ActiveForecolor = System.Drawing.Color.White
        Me.btnBuscar.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Window
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.ButtonText = "Buscar"
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnBuscar.IdleBorderThickness = 1
        Me.btnBuscar.IdleCornerRadius = 20
        Me.btnBuscar.IdleFillColor = System.Drawing.Color.White
        Me.btnBuscar.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnBuscar.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnBuscar.Location = New System.Drawing.Point(270, 37)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(235, 70)
        Me.btnBuscar.TabIndex = 41
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboCat
        '
        Me.cboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCat.FormattingEnabled = True
        Me.cboCat.Location = New System.Drawing.Point(222, 498)
        Me.cboCat.Name = "cboCat"
        Me.cboCat.Size = New System.Drawing.Size(138, 24)
        Me.cboCat.TabIndex = 42
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(223, 352)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(137, 24)
        Me.cboTipo.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(17, 601)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Tiempo: "
        '
        'txtTiempo
        '
        Me.txtTiempo.Location = New System.Drawing.Point(223, 596)
        Me.txtTiempo.Name = "txtTiempo"
        Me.txtTiempo.Size = New System.Drawing.Size(137, 22)
        Me.txtTiempo.TabIndex = 45
        '
        'frmTorneo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.Main.My.Resources.Resources.FINALFINAL
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1539, 645)
        Me.Controls.Add(Me.txtTiempo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.cboCat)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Btn_agre)
        Me.Controls.Add(Me.Btn_elim)
        Me.Controls.Add(Me.Btn_act)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnParticipantes)
        Me.Controls.Add(Me.btnHistorial)
        Me.Controls.Add(Me.numPrice)
        Me.Controls.Add(Me.dtpFR)
        Me.Controls.Add(Me.TxtNomb)
        Me.Controls.Add(Me.txtLugar)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.grdTorneo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTorneo"
        Me.Text = "Historial de Torneos"
        CType(Me.grdTorneo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdTorneo As DataGridView
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtCat As TextBox
    Friend WithEvents txtLugar As TextBox
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents TxtNomb As TextBox
    Friend WithEvents dtpFR As DateTimePicker
    Friend WithEvents numPrice As NumericUpDown
    Friend WithEvents btnHistorial As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnParticipantes As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Btn_act As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_elim As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_agre As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnBuscar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents cboCat As ComboBox
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTiempo As TextBox
End Class
