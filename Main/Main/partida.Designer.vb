<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class partida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(partida))
        Me.jrd_partida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_actP = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_agreP = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_buscarP = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_elimP = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_SSN = New System.Windows.Forms.TextBox()
        Me.txt_torneo = New System.Windows.Forms.TextBox()
        Me.txt_vic = New System.Windows.Forms.TextBox()
        Me.txt_emp = New System.Windows.Forms.TextBox()
        Me.txt_der = New System.Windows.Forms.TextBox()
        Me.txt_pos = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_pgn = New System.Windows.Forms.TextBox()
        Me.txt_elo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.jrd_partida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'jrd_partida
        '
        Me.jrd_partida.AllowUserToAddRows = False
        Me.jrd_partida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.jrd_partida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column8, Me.Column7})
        Me.jrd_partida.Location = New System.Drawing.Point(464, 186)
        Me.jrd_partida.Margin = New System.Windows.Forms.Padding(4)
        Me.jrd_partida.Name = "jrd_partida"
        Me.jrd_partida.Size = New System.Drawing.Size(1124, 437)
        Me.jrd_partida.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id_Jugador"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Id_Torneo"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Victorias"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Empates"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Derrotas"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Posición"
        Me.Column6.Name = "Column6"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Diff_elo"
        Me.Column8.Name = "Column8"
        '
        'Column7
        '
        Me.Column7.HeaderText = "PGN"
        Me.Column7.Name = "Column7"
        '
        'Btn_actP
        '
        Me.Btn_actP.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_actP.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_actP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_actP.BorderRadius = 0
        Me.Btn_actP.ButtonText = "Actualizar"
        Me.Btn_actP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_actP.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_actP.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_actP.Iconimage = CType(resources.GetObject("Btn_actP.Iconimage"), System.Drawing.Image)
        Me.Btn_actP.Iconimage_right = Nothing
        Me.Btn_actP.Iconimage_right_Selected = Nothing
        Me.Btn_actP.Iconimage_Selected = Nothing
        Me.Btn_actP.IconMarginLeft = 0
        Me.Btn_actP.IconMarginRight = 0
        Me.Btn_actP.IconRightVisible = True
        Me.Btn_actP.IconRightZoom = 0R
        Me.Btn_actP.IconVisible = True
        Me.Btn_actP.IconZoom = 90.0R
        Me.Btn_actP.IsTab = False
        Me.Btn_actP.Location = New System.Drawing.Point(979, 78)
        Me.Btn_actP.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_actP.Name = "Btn_actP"
        Me.Btn_actP.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_actP.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_actP.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_actP.selected = False
        Me.Btn_actP.Size = New System.Drawing.Size(249, 78)
        Me.Btn_actP.TabIndex = 41
        Me.Btn_actP.Text = "Actualizar"
        Me.Btn_actP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_actP.Textcolor = System.Drawing.Color.White
        Me.Btn_actP.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_agreP
        '
        Me.Btn_agreP.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_agreP.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_agreP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_agreP.BorderRadius = 0
        Me.Btn_agreP.ButtonText = "Agregar"
        Me.Btn_agreP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_agreP.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_agreP.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_agreP.Iconimage = CType(resources.GetObject("Btn_agreP.Iconimage"), System.Drawing.Image)
        Me.Btn_agreP.Iconimage_right = Nothing
        Me.Btn_agreP.Iconimage_right_Selected = Nothing
        Me.Btn_agreP.Iconimage_Selected = Nothing
        Me.Btn_agreP.IconMarginLeft = 0
        Me.Btn_agreP.IconMarginRight = 0
        Me.Btn_agreP.IconRightVisible = True
        Me.Btn_agreP.IconRightZoom = 0R
        Me.Btn_agreP.IconVisible = True
        Me.Btn_agreP.IconZoom = 90.0R
        Me.Btn_agreP.IsTab = False
        Me.Btn_agreP.Location = New System.Drawing.Point(464, 78)
        Me.Btn_agreP.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_agreP.Name = "Btn_agreP"
        Me.Btn_agreP.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_agreP.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_agreP.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_agreP.selected = False
        Me.Btn_agreP.Size = New System.Drawing.Size(249, 78)
        Me.Btn_agreP.TabIndex = 40
        Me.Btn_agreP.Text = "Agregar"
        Me.Btn_agreP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_agreP.Textcolor = System.Drawing.Color.White
        Me.Btn_agreP.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_buscarP
        '
        Me.Btn_buscarP.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_buscarP.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_buscarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_buscarP.BorderRadius = 0
        Me.Btn_buscarP.ButtonText = "Buscar"
        Me.Btn_buscarP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_buscarP.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_buscarP.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_buscarP.Iconimage = CType(resources.GetObject("Btn_buscarP.Iconimage"), System.Drawing.Image)
        Me.Btn_buscarP.Iconimage_right = Nothing
        Me.Btn_buscarP.Iconimage_right_Selected = Nothing
        Me.Btn_buscarP.Iconimage_Selected = Nothing
        Me.Btn_buscarP.IconMarginLeft = 0
        Me.Btn_buscarP.IconMarginRight = 0
        Me.Btn_buscarP.IconRightVisible = True
        Me.Btn_buscarP.IconRightZoom = 0R
        Me.Btn_buscarP.IconVisible = True
        Me.Btn_buscarP.IconZoom = 90.0R
        Me.Btn_buscarP.IsTab = False
        Me.Btn_buscarP.Location = New System.Drawing.Point(721, 78)
        Me.Btn_buscarP.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_buscarP.Name = "Btn_buscarP"
        Me.Btn_buscarP.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_buscarP.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_buscarP.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_buscarP.selected = False
        Me.Btn_buscarP.Size = New System.Drawing.Size(249, 78)
        Me.Btn_buscarP.TabIndex = 39
        Me.Btn_buscarP.Text = "Buscar"
        Me.Btn_buscarP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_buscarP.Textcolor = System.Drawing.Color.White
        Me.Btn_buscarP.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_elimP
        '
        Me.Btn_elimP.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_elimP.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_elimP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_elimP.BorderRadius = 0
        Me.Btn_elimP.ButtonText = "Eliminar"
        Me.Btn_elimP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_elimP.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_elimP.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_elimP.Iconimage = CType(resources.GetObject("Btn_elimP.Iconimage"), System.Drawing.Image)
        Me.Btn_elimP.Iconimage_right = Nothing
        Me.Btn_elimP.Iconimage_right_Selected = Nothing
        Me.Btn_elimP.Iconimage_Selected = Nothing
        Me.Btn_elimP.IconMarginLeft = 0
        Me.Btn_elimP.IconMarginRight = 0
        Me.Btn_elimP.IconRightVisible = True
        Me.Btn_elimP.IconRightZoom = 0R
        Me.Btn_elimP.IconVisible = True
        Me.Btn_elimP.IconZoom = 90.0R
        Me.Btn_elimP.IsTab = False
        Me.Btn_elimP.Location = New System.Drawing.Point(1236, 78)
        Me.Btn_elimP.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_elimP.Name = "Btn_elimP"
        Me.Btn_elimP.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_elimP.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_elimP.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_elimP.selected = False
        Me.Btn_elimP.Size = New System.Drawing.Size(249, 78)
        Me.Btn_elimP.TabIndex = 38
        Me.Btn_elimP.Text = "Eliminar"
        Me.Btn_elimP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_elimP.Textcolor = System.Drawing.Color.White
        Me.Btn_elimP.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 367)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 17)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Posición"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 331)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 17)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Derrotas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 299)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Empates"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 262)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Victorias"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 224)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Id_Torneo"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(32, 194)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 17)
        Me.label1.TabIndex = 42
        Me.label1.Text = "SSN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 431)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 17)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Agregar PGN"
        '
        'txt_SSN
        '
        Me.txt_SSN.Location = New System.Drawing.Point(153, 191)
        Me.txt_SSN.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_SSN.Name = "txt_SSN"
        Me.txt_SSN.Size = New System.Drawing.Size(268, 22)
        Me.txt_SSN.TabIndex = 53
        '
        'txt_torneo
        '
        Me.txt_torneo.Location = New System.Drawing.Point(153, 224)
        Me.txt_torneo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_torneo.Name = "txt_torneo"
        Me.txt_torneo.Size = New System.Drawing.Size(268, 22)
        Me.txt_torneo.TabIndex = 54
        '
        'txt_vic
        '
        Me.txt_vic.Location = New System.Drawing.Point(153, 262)
        Me.txt_vic.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_vic.Name = "txt_vic"
        Me.txt_vic.Size = New System.Drawing.Size(268, 22)
        Me.txt_vic.TabIndex = 55
        '
        'txt_emp
        '
        Me.txt_emp.Location = New System.Drawing.Point(153, 299)
        Me.txt_emp.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_emp.Name = "txt_emp"
        Me.txt_emp.Size = New System.Drawing.Size(268, 22)
        Me.txt_emp.TabIndex = 56
        '
        'txt_der
        '
        Me.txt_der.Location = New System.Drawing.Point(153, 331)
        Me.txt_der.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_der.Name = "txt_der"
        Me.txt_der.Size = New System.Drawing.Size(268, 22)
        Me.txt_der.TabIndex = 57
        '
        'txt_pos
        '
        Me.txt_pos.Location = New System.Drawing.Point(153, 367)
        Me.txt_pos.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_pos.Name = "txt_pos"
        Me.txt_pos.Size = New System.Drawing.Size(268, 22)
        Me.txt_pos.TabIndex = 58
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(384, 431)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 28)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_pgn
        '
        Me.txt_pgn.Location = New System.Drawing.Point(153, 431)
        Me.txt_pgn.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_pgn.Name = "txt_pgn"
        Me.txt_pgn.Size = New System.Drawing.Size(221, 22)
        Me.txt_pgn.TabIndex = 60
        '
        'txt_elo
        '
        Me.txt_elo.Location = New System.Drawing.Point(153, 399)
        Me.txt_elo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_elo.Name = "txt_elo"
        Me.txt_elo.Size = New System.Drawing.Size(268, 22)
        Me.txt_elo.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 399)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 17)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Diferencia ELO"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Ver PGN"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(33, 476)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(249, 78)
        Me.BunifuFlatButton1.TabIndex = 63
        Me.BunifuFlatButton1.Text = "Ver PGN"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'partida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1659, 754)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.txt_elo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_pgn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_pos)
        Me.Controls.Add(Me.txt_der)
        Me.Controls.Add(Me.txt_emp)
        Me.Controls.Add(Me.txt_vic)
        Me.Controls.Add(Me.txt_torneo)
        Me.Controls.Add(Me.txt_SSN)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btn_actP)
        Me.Controls.Add(Me.Btn_agreP)
        Me.Controls.Add(Me.Btn_buscarP)
        Me.Controls.Add(Me.Btn_elimP)
        Me.Controls.Add(Me.jrd_partida)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "partida"
        Me.Text = "partida"
        CType(Me.jrd_partida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents jrd_partida As DataGridView
    Friend WithEvents Btn_actP As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_agreP As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_buscarP As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_elimP As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_SSN As TextBox
    Friend WithEvents txt_torneo As TextBox
    Friend WithEvents txt_vic As TextBox
    Friend WithEvents txt_emp As TextBox
    Friend WithEvents txt_der As TextBox
    Friend WithEvents txt_pos As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_pgn As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents txt_elo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
End Class
