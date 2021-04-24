<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_jug
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_jug))
        Me.j_bd = New System.Windows.Forms.DateTimePicker()
        Me.j_ssn = New System.Windows.Forms.TextBox()
        Me.j_n1 = New System.Windows.Forms.TextBox()
        Me.j_n2 = New System.Windows.Forms.TextBox()
        Me.j_a1 = New System.Windows.Forms.TextBox()
        Me.j_a2 = New System.Windows.Forms.TextBox()
        Me.j_e = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.j_s = New System.Windows.Forms.ComboBox()
        Me.j_t = New System.Windows.Forms.ComboBox()
        Me.j_o = New System.Windows.Forms.ComboBox()
        Me.j_grd = New System.Windows.Forms.DataGridView()
        Me.g_ssn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.elo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.miembro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.origen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.j_m = New System.Windows.Forms.ComboBox()
        Me.Btn_elim = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_buscar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_agre = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_act = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.j_grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'j_bd
        '
        Me.j_bd.CustomFormat = "yyyy-MM-dd"
        Me.j_bd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.j_bd.Location = New System.Drawing.Point(183, 257)
        Me.j_bd.Margin = New System.Windows.Forms.Padding(4)
        Me.j_bd.Name = "j_bd"
        Me.j_bd.Size = New System.Drawing.Size(271, 22)
        Me.j_bd.TabIndex = 3
        '
        'j_ssn
        '
        Me.j_ssn.Location = New System.Drawing.Point(183, 44)
        Me.j_ssn.Margin = New System.Windows.Forms.Padding(4)
        Me.j_ssn.Name = "j_ssn"
        Me.j_ssn.Size = New System.Drawing.Size(271, 22)
        Me.j_ssn.TabIndex = 4
        '
        'j_n1
        '
        Me.j_n1.Location = New System.Drawing.Point(183, 76)
        Me.j_n1.Margin = New System.Windows.Forms.Padding(4)
        Me.j_n1.Name = "j_n1"
        Me.j_n1.Size = New System.Drawing.Size(271, 22)
        Me.j_n1.TabIndex = 5
        '
        'j_n2
        '
        Me.j_n2.Location = New System.Drawing.Point(183, 108)
        Me.j_n2.Margin = New System.Windows.Forms.Padding(4)
        Me.j_n2.Name = "j_n2"
        Me.j_n2.Size = New System.Drawing.Size(271, 22)
        Me.j_n2.TabIndex = 6
        '
        'j_a1
        '
        Me.j_a1.Location = New System.Drawing.Point(183, 140)
        Me.j_a1.Margin = New System.Windows.Forms.Padding(4)
        Me.j_a1.Name = "j_a1"
        Me.j_a1.Size = New System.Drawing.Size(271, 22)
        Me.j_a1.TabIndex = 7
        '
        'j_a2
        '
        Me.j_a2.Location = New System.Drawing.Point(183, 172)
        Me.j_a2.Margin = New System.Windows.Forms.Padding(4)
        Me.j_a2.Name = "j_a2"
        Me.j_a2.Size = New System.Drawing.Size(271, 22)
        Me.j_a2.TabIndex = 8
        '
        'j_e
        '
        Me.j_e.Location = New System.Drawing.Point(183, 298)
        Me.j_e.Margin = New System.Windows.Forms.Padding(4)
        Me.j_e.Name = "j_e"
        Me.j_e.Size = New System.Drawing.Size(271, 22)
        Me.j_e.TabIndex = 9
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 44)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 17)
        Me.label1.TabIndex = 12
        Me.label1.Text = "SSN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nombre 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 149)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Apellido 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 298)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "ELO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 330)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Miembro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 366)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Origen"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 265)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Fec_Nacimiento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 181)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Apellido 2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 402)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Titulo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 217)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 17)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Sexo"
        '
        'j_s
        '
        Me.j_s.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.j_s.FormattingEnabled = True
        Me.j_s.Location = New System.Drawing.Point(183, 213)
        Me.j_s.Margin = New System.Windows.Forms.Padding(4)
        Me.j_s.Name = "j_s"
        Me.j_s.Size = New System.Drawing.Size(271, 24)
        Me.j_s.TabIndex = 28
        '
        'j_t
        '
        Me.j_t.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.j_t.FormattingEnabled = True
        Me.j_t.Location = New System.Drawing.Point(183, 393)
        Me.j_t.Margin = New System.Windows.Forms.Padding(4)
        Me.j_t.Name = "j_t"
        Me.j_t.Size = New System.Drawing.Size(271, 24)
        Me.j_t.TabIndex = 29
        '
        'j_o
        '
        Me.j_o.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.j_o.FormattingEnabled = True
        Me.j_o.Location = New System.Drawing.Point(183, 362)
        Me.j_o.Margin = New System.Windows.Forms.Padding(4)
        Me.j_o.Name = "j_o"
        Me.j_o.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.j_o.Size = New System.Drawing.Size(271, 24)
        Me.j_o.TabIndex = 30
        '
        'j_grd
        '
        Me.j_grd.AllowUserToAddRows = False
        Me.j_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.j_grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.g_ssn, Me.Nombre_1, Me.Nombre_2, Me.apellido_1, Me.apellido_2, Me.Sexo, Me.fecha_nac, Me.elo, Me.miembro, Me.origen, Me.titulo})
        Me.j_grd.Location = New System.Drawing.Point(496, 108)
        Me.j_grd.Margin = New System.Windows.Forms.Padding(4)
        Me.j_grd.Name = "j_grd"
        Me.j_grd.Size = New System.Drawing.Size(1200, 550)
        Me.j_grd.TabIndex = 31
        '
        'g_ssn
        '
        Me.g_ssn.HeaderText = "ssn"
        Me.g_ssn.Name = "g_ssn"
        '
        'Nombre_1
        '
        Me.Nombre_1.HeaderText = "Nombre 1"
        Me.Nombre_1.Name = "Nombre_1"
        '
        'Nombre_2
        '
        Me.Nombre_2.HeaderText = "Nombre 2"
        Me.Nombre_2.Name = "Nombre_2"
        '
        'apellido_1
        '
        Me.apellido_1.HeaderText = "Apellido 1"
        Me.apellido_1.Name = "apellido_1"
        '
        'apellido_2
        '
        Me.apellido_2.HeaderText = "Apellido 2"
        Me.apellido_2.Name = "apellido_2"
        '
        'Sexo
        '
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        Me.Sexo.Width = 40
        '
        'fecha_nac
        '
        Me.fecha_nac.HeaderText = "Fecha Nacimiento"
        Me.fecha_nac.Name = "fecha_nac"
        '
        'elo
        '
        Me.elo.HeaderText = "Elo"
        Me.elo.Name = "elo"
        Me.elo.Width = 40
        '
        'miembro
        '
        Me.miembro.HeaderText = "Miembro"
        Me.miembro.Name = "miembro"
        Me.miembro.Width = 50
        '
        'origen
        '
        Me.origen.HeaderText = "Origen"
        Me.origen.Name = "origen"
        Me.origen.Width = 60
        '
        'titulo
        '
        Me.titulo.HeaderText = "Titulo"
        Me.titulo.Name = "titulo"
        Me.titulo.Width = 60
        '
        'j_m
        '
        Me.j_m.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.j_m.FormattingEnabled = True
        Me.j_m.Location = New System.Drawing.Point(183, 330)
        Me.j_m.Margin = New System.Windows.Forms.Padding(4)
        Me.j_m.Name = "j_m"
        Me.j_m.Size = New System.Drawing.Size(271, 24)
        Me.j_m.TabIndex = 32
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
        Me.Btn_elim.Location = New System.Drawing.Point(1141, 16)
        Me.Btn_elim.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_elim.Name = "Btn_elim"
        Me.Btn_elim.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_elim.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_elim.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_elim.selected = False
        Me.Btn_elim.Size = New System.Drawing.Size(187, 78)
        Me.Btn_elim.TabIndex = 34
        Me.Btn_elim.Text = "Eliminar"
        Me.Btn_elim.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_elim.Textcolor = System.Drawing.Color.White
        Me.Btn_elim.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_buscar
        '
        Me.Btn_buscar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_buscar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_buscar.BorderRadius = 0
        Me.Btn_buscar.ButtonText = "Buscar"
        Me.Btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_buscar.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_buscar.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_buscar.Iconimage = Global.Main.My.Resources.Resources.buscar
        Me.Btn_buscar.Iconimage_right = Nothing
        Me.Btn_buscar.Iconimage_right_Selected = Nothing
        Me.Btn_buscar.Iconimage_Selected = Nothing
        Me.Btn_buscar.IconMarginLeft = 0
        Me.Btn_buscar.IconMarginRight = 0
        Me.Btn_buscar.IconRightVisible = True
        Me.Btn_buscar.IconRightZoom = 0R
        Me.Btn_buscar.IconVisible = True
        Me.Btn_buscar.IconZoom = 90.0R
        Me.Btn_buscar.IsTab = False
        Me.Btn_buscar.Location = New System.Drawing.Point(496, 12)
        Me.Btn_buscar.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_buscar.Name = "Btn_buscar"
        Me.Btn_buscar.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_buscar.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_buscar.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_buscar.selected = False
        Me.Btn_buscar.Size = New System.Drawing.Size(184, 78)
        Me.Btn_buscar.TabIndex = 35
        Me.Btn_buscar.Text = "Buscar"
        Me.Btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_buscar.Textcolor = System.Drawing.Color.White
        Me.Btn_buscar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Btn_agre.Location = New System.Drawing.Point(17, 475)
        Me.Btn_agre.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_agre.Name = "Btn_agre"
        Me.Btn_agre.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_agre.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_agre.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_agre.selected = False
        Me.Btn_agre.Size = New System.Drawing.Size(249, 78)
        Me.Btn_agre.TabIndex = 36
        Me.Btn_agre.Text = "Agregar"
        Me.Btn_agre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_agre.Textcolor = System.Drawing.Color.White
        Me.Btn_agre.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Btn_act.Location = New System.Drawing.Point(807, 12)
        Me.Btn_act.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_act.Name = "Btn_act"
        Me.Btn_act.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_act.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_act.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_act.selected = False
        Me.Btn_act.Size = New System.Drawing.Size(192, 78)
        Me.Btn_act.TabIndex = 37
        Me.Btn_act.Text = "Actualizar"
        Me.Btn_act.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_act.Textcolor = System.Drawing.Color.White
        Me.Btn_act.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frm_jug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Main.My.Resources.Resources.FINALFINAL
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1371, 673)
        Me.Controls.Add(Me.Btn_act)
        Me.Controls.Add(Me.Btn_agre)
        Me.Controls.Add(Me.Btn_buscar)
        Me.Controls.Add(Me.Btn_elim)
        Me.Controls.Add(Me.j_m)
        Me.Controls.Add(Me.j_grd)
        Me.Controls.Add(Me.j_o)
        Me.Controls.Add(Me.j_t)
        Me.Controls.Add(Me.j_s)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.j_e)
        Me.Controls.Add(Me.j_a2)
        Me.Controls.Add(Me.j_a1)
        Me.Controls.Add(Me.j_n2)
        Me.Controls.Add(Me.j_n1)
        Me.Controls.Add(Me.j_ssn)
        Me.Controls.Add(Me.j_bd)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Label8)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_jug"
        Me.Text = "Jugador"
        CType(Me.j_grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents j_bd As DateTimePicker
    Friend WithEvents j_ssn As TextBox
    Friend WithEvents j_n1 As TextBox
    Friend WithEvents j_n2 As TextBox
    Friend WithEvents j_a1 As TextBox
    Friend WithEvents j_a2 As TextBox
    Friend WithEvents j_e As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents j_s As ComboBox
    Friend WithEvents j_t As ComboBox
    Friend WithEvents j_o As ComboBox
    Friend WithEvents j_grd As DataGridView
    Friend WithEvents j_m As ComboBox
    Friend WithEvents g_ssn As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_1 As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_2 As DataGridViewTextBoxColumn
    Friend WithEvents apellido_1 As DataGridViewTextBoxColumn
    Friend WithEvents apellido_2 As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents fecha_nac As DataGridViewTextBoxColumn
    Friend WithEvents elo As DataGridViewTextBoxColumn
    Friend WithEvents miembro As DataGridViewTextBoxColumn
    Friend WithEvents origen As DataGridViewTextBoxColumn
    Friend WithEvents titulo As DataGridViewTextBoxColumn
    Friend WithEvents Btn_elim As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_buscar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_agre As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_act As Bunifu.Framework.UI.BunifuFlatButton
End Class
