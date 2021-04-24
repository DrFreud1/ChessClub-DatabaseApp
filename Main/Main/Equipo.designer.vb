<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_equ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_equ))
        Me.e_grd = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.e_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imagen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.e_cb_nam = New System.Windows.Forms.ComboBox()
        Me.e_cb_tip = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.e_ima = New System.Windows.Forms.Button()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.lb_inc = New System.Windows.Forms.Label()
        Me.lb_sin = New System.Windows.Forms.Label()
        Me.lb_of = New System.Windows.Forms.Label()
        Me.lb_nof = New System.Windows.Forms.Label()
        Me.lb_rt = New System.Windows.Forms.Label()
        Me.lb_tt = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.e_buscar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.e_elim = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.e_add = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.e_grd2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.e_grd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e_grd2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'e_grd
        '
        Me.e_grd.AllowUserToAddRows = False
        Me.e_grd.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.e_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.e_grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.e_name, Me.Tipo, Me.imagen})
        Me.e_grd.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.e_grd.Location = New System.Drawing.Point(320, 54)
        Me.e_grd.Margin = New System.Windows.Forms.Padding(4)
        Me.e_grd.Name = "e_grd"
        Me.e_grd.Size = New System.Drawing.Size(591, 284)
        Me.e_grd.TabIndex = 40
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        '
        'e_name
        '
        Me.e_name.HeaderText = "Nombre"
        Me.e_name.Name = "e_name"
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'imagen
        '
        Me.imagen.HeaderText = "Foto"
        Me.imagen.Name = "imagen"
        '
        'e_cb_nam
        '
        Me.e_cb_nam.FormattingEnabled = True
        Me.e_cb_nam.Location = New System.Drawing.Point(124, 412)
        Me.e_cb_nam.Margin = New System.Windows.Forms.Padding(4)
        Me.e_cb_nam.Name = "e_cb_nam"
        Me.e_cb_nam.Size = New System.Drawing.Size(151, 24)
        Me.e_cb_nam.TabIndex = 41
        '
        'e_cb_tip
        '
        Me.e_cb_tip.FormattingEnabled = True
        Me.e_cb_tip.Location = New System.Drawing.Point(124, 455)
        Me.e_cb_tip.Margin = New System.Windows.Forms.Padding(4)
        Me.e_cb_tip.Name = "e_cb_tip"
        Me.e_cb_tip.Size = New System.Drawing.Size(151, 24)
        Me.e_cb_tip.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 416)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 459)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Tipo"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'e_ima
        '
        Me.e_ima.Location = New System.Drawing.Point(61, 489)
        Me.e_ima.Margin = New System.Windows.Forms.Padding(4)
        Me.e_ima.Name = "e_ima"
        Me.e_ima.Size = New System.Drawing.Size(125, 26)
        Me.e_ima.TabIndex = 45
        Me.e_ima.Text = "Cargar imagen"
        Me.e_ima.UseVisualStyleBackColor = True
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(231, 489)
        Me.lblFile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(0, 17)
        Me.lblFile.TabIndex = 46
        '
        'lb_inc
        '
        Me.lb_inc.AutoSize = True
        Me.lb_inc.Location = New System.Drawing.Point(607, 409)
        Me.lb_inc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_inc.Name = "lb_inc"
        Me.lb_inc.Size = New System.Drawing.Size(0, 17)
        Me.lb_inc.TabIndex = 49
        '
        'lb_sin
        '
        Me.lb_sin.AutoSize = True
        Me.lb_sin.Location = New System.Drawing.Point(808, 409)
        Me.lb_sin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_sin.Name = "lb_sin"
        Me.lb_sin.Size = New System.Drawing.Size(0, 17)
        Me.lb_sin.TabIndex = 50
        '
        'lb_of
        '
        Me.lb_of.AutoSize = True
        Me.lb_of.Location = New System.Drawing.Point(607, 466)
        Me.lb_of.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_of.Name = "lb_of"
        Me.lb_of.Size = New System.Drawing.Size(0, 17)
        Me.lb_of.TabIndex = 52
        '
        'lb_nof
        '
        Me.lb_nof.AutoSize = True
        Me.lb_nof.Location = New System.Drawing.Point(1212, 455)
        Me.lb_nof.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_nof.Name = "lb_nof"
        Me.lb_nof.Size = New System.Drawing.Size(0, 17)
        Me.lb_nof.TabIndex = 53
        '
        'lb_rt
        '
        Me.lb_rt.AutoSize = True
        Me.lb_rt.Location = New System.Drawing.Point(859, 386)
        Me.lb_rt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_rt.Name = "lb_rt"
        Me.lb_rt.Size = New System.Drawing.Size(0, 17)
        Me.lb_rt.TabIndex = 54
        '
        'lb_tt
        '
        Me.lb_tt.AutoSize = True
        Me.lb_tt.Location = New System.Drawing.Point(859, 444)
        Me.lb_tt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_tt.Name = "lb_tt"
        Me.lb_tt.Size = New System.Drawing.Size(0, 17)
        Me.lb_tt.TabIndex = 55
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(931, 27)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(429, 284)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'e_buscar
        '
        Me.e_buscar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.e_buscar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.e_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.e_buscar.BorderRadius = 0
        Me.e_buscar.ButtonText = "Buscar"
        Me.e_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.e_buscar.DisabledColor = System.Drawing.Color.Gray
        Me.e_buscar.Iconcolor = System.Drawing.Color.Transparent
        Me.e_buscar.Iconimage = Global.Main.My.Resources.Resources.buscar
        Me.e_buscar.Iconimage_right = Nothing
        Me.e_buscar.Iconimage_right_Selected = Nothing
        Me.e_buscar.Iconimage_Selected = Nothing
        Me.e_buscar.IconMarginLeft = 0
        Me.e_buscar.IconMarginRight = 0
        Me.e_buscar.IconRightVisible = True
        Me.e_buscar.IconRightZoom = 0R
        Me.e_buscar.IconVisible = True
        Me.e_buscar.IconZoom = 90.0R
        Me.e_buscar.IsTab = False
        Me.e_buscar.Location = New System.Drawing.Point(16, 54)
        Me.e_buscar.Margin = New System.Windows.Forms.Padding(5)
        Me.e_buscar.Name = "e_buscar"
        Me.e_buscar.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.e_buscar.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.e_buscar.OnHoverTextColor = System.Drawing.Color.White
        Me.e_buscar.selected = False
        Me.e_buscar.Size = New System.Drawing.Size(249, 78)
        Me.e_buscar.TabIndex = 39
        Me.e_buscar.Text = "Buscar"
        Me.e_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.e_buscar.Textcolor = System.Drawing.Color.White
        Me.e_buscar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'e_elim
        '
        Me.e_elim.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.e_elim.BackColor = System.Drawing.Color.DarkSlateGray
        Me.e_elim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.e_elim.BorderRadius = 0
        Me.e_elim.ButtonText = "Eliminar"
        Me.e_elim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.e_elim.DisabledColor = System.Drawing.Color.Gray
        Me.e_elim.Iconcolor = System.Drawing.Color.Transparent
        Me.e_elim.Iconimage = Global.Main.My.Resources.Resources.eliminar
        Me.e_elim.Iconimage_right = Nothing
        Me.e_elim.Iconimage_right_Selected = Nothing
        Me.e_elim.Iconimage_Selected = Nothing
        Me.e_elim.IconMarginLeft = 0
        Me.e_elim.IconMarginRight = 0
        Me.e_elim.IconRightVisible = True
        Me.e_elim.IconRightZoom = 0R
        Me.e_elim.IconVisible = True
        Me.e_elim.IconZoom = 90.0R
        Me.e_elim.IsTab = False
        Me.e_elim.Location = New System.Drawing.Point(16, 261)
        Me.e_elim.Margin = New System.Windows.Forms.Padding(5)
        Me.e_elim.Name = "e_elim"
        Me.e_elim.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.e_elim.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.e_elim.OnHoverTextColor = System.Drawing.Color.White
        Me.e_elim.selected = False
        Me.e_elim.Size = New System.Drawing.Size(249, 78)
        Me.e_elim.TabIndex = 38
        Me.e_elim.Text = "Eliminar"
        Me.e_elim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.e_elim.Textcolor = System.Drawing.Color.White
        Me.e_elim.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'e_add
        '
        Me.e_add.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.e_add.BackColor = System.Drawing.Color.DarkSlateGray
        Me.e_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.e_add.BorderRadius = 0
        Me.e_add.ButtonText = "Agregar"
        Me.e_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.e_add.DisabledColor = System.Drawing.Color.Gray
        Me.e_add.Iconcolor = System.Drawing.Color.Transparent
        Me.e_add.Iconimage = Global.Main.My.Resources.Resources.anadir
        Me.e_add.Iconimage_right = Nothing
        Me.e_add.Iconimage_right_Selected = Nothing
        Me.e_add.Iconimage_Selected = Nothing
        Me.e_add.IconMarginLeft = 0
        Me.e_add.IconMarginRight = 0
        Me.e_add.IconRightVisible = True
        Me.e_add.IconRightZoom = 0R
        Me.e_add.IconVisible = True
        Me.e_add.IconZoom = 90.0R
        Me.e_add.IsTab = False
        Me.e_add.Location = New System.Drawing.Point(16, 156)
        Me.e_add.Margin = New System.Windows.Forms.Padding(5)
        Me.e_add.Name = "e_add"
        Me.e_add.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.e_add.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.e_add.OnHoverTextColor = System.Drawing.Color.White
        Me.e_add.selected = False
        Me.e_add.Size = New System.Drawing.Size(249, 78)
        Me.e_add.TabIndex = 37
        Me.e_add.Text = "Agregar"
        Me.e_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.e_add.Textcolor = System.Drawing.Color.White
        Me.e_add.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'e_grd2
        '
        Me.e_grd2.AllowUserToAddRows = False
        Me.e_grd2.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.e_grd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.e_grd2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.e_grd2.Location = New System.Drawing.Point(320, 374)
        Me.e_grd2.Margin = New System.Windows.Forms.Padding(4)
        Me.e_grd2.Name = "e_grd2"
        Me.e_grd2.Size = New System.Drawing.Size(377, 171)
        Me.e_grd2.TabIndex = 61
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tipo"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Total"
        Me.Column3.Name = "Column3"
        '
        'frm_equ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Main.My.Resources.Resources.FINALFINAL
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1373, 662)
        Me.Controls.Add(Me.e_grd2)
        Me.Controls.Add(Me.lb_tt)
        Me.Controls.Add(Me.lb_rt)
        Me.Controls.Add(Me.lb_nof)
        Me.Controls.Add(Me.lb_of)
        Me.Controls.Add(Me.lb_sin)
        Me.Controls.Add(Me.lb_inc)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.e_ima)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.e_cb_tip)
        Me.Controls.Add(Me.e_cb_nam)
        Me.Controls.Add(Me.e_grd)
        Me.Controls.Add(Me.e_buscar)
        Me.Controls.Add(Me.e_elim)
        Me.Controls.Add(Me.e_add)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_equ"
        Me.Text = "Equipo"
        CType(Me.e_grd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e_grd2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents e_add As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents e_elim As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents e_buscar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents e_grd As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents e_name As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents imagen As DataGridViewTextBoxColumn
    Friend WithEvents e_cb_nam As ComboBox
    Friend WithEvents e_cb_tip As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents e_ima As Button
    Friend WithEvents lblFile As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lb_inc As Label
    Friend WithEvents lb_sin As Label
    Friend WithEvents lb_of As Label
    Friend WithEvents lb_nof As Label
    Friend WithEvents lb_rt As Label
    Friend WithEvents lb_tt As Label
    Friend WithEvents e_grd2 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
