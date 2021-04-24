<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fondos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fondos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_F_Valor = New System.Windows.Forms.TextBox()
        Me.Txt_F_Descripcion = New System.Windows.Forms.TextBox()
        Me.Txt_F_idtorneo = New System.Windows.Forms.TextBox()
        Me.Btn_F_Buscar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_F_Actualizar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_F_Eliminar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_F_Agregar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.F_grd = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Fondos = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cbo_Descripcion = New System.Windows.Forms.ComboBox()
        CType(Me.F_grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(403, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(396, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Valor $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(341, 217)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(359, 337)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 29)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Id_Torneo"
        '
        'Txt_F_Valor
        '
        Me.Txt_F_Valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_F_Valor.Location = New System.Drawing.Point(537, 144)
        Me.Txt_F_Valor.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_F_Valor.Name = "Txt_F_Valor"
        Me.Txt_F_Valor.Size = New System.Drawing.Size(295, 30)
        Me.Txt_F_Valor.TabIndex = 17
        '
        'Txt_F_Descripcion
        '
        Me.Txt_F_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_F_Descripcion.Location = New System.Drawing.Point(537, 214)
        Me.Txt_F_Descripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_F_Descripcion.Name = "Txt_F_Descripcion"
        Me.Txt_F_Descripcion.Size = New System.Drawing.Size(295, 30)
        Me.Txt_F_Descripcion.TabIndex = 18
        '
        'Txt_F_idtorneo
        '
        Me.Txt_F_idtorneo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_F_idtorneo.Location = New System.Drawing.Point(537, 335)
        Me.Txt_F_idtorneo.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_F_idtorneo.Name = "Txt_F_idtorneo"
        Me.Txt_F_idtorneo.Size = New System.Drawing.Size(295, 30)
        Me.Txt_F_idtorneo.TabIndex = 19
        '
        'Btn_F_Buscar
        '
        Me.Btn_F_Buscar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_F_Buscar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_F_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_F_Buscar.BorderRadius = 0
        Me.Btn_F_Buscar.ButtonText = "Buscar"
        Me.Btn_F_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_F_Buscar.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_F_Buscar.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_F_Buscar.Iconimage = Global.Main.My.Resources.Resources.buscar
        Me.Btn_F_Buscar.Iconimage_right = Nothing
        Me.Btn_F_Buscar.Iconimage_right_Selected = Nothing
        Me.Btn_F_Buscar.Iconimage_Selected = Nothing
        Me.Btn_F_Buscar.IconMarginLeft = 0
        Me.Btn_F_Buscar.IconMarginRight = 0
        Me.Btn_F_Buscar.IconRightVisible = True
        Me.Btn_F_Buscar.IconRightZoom = 0R
        Me.Btn_F_Buscar.IconVisible = True
        Me.Btn_F_Buscar.IconZoom = 90.0R
        Me.Btn_F_Buscar.IsTab = False
        Me.Btn_F_Buscar.Location = New System.Drawing.Point(169, 855)
        Me.Btn_F_Buscar.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_F_Buscar.Name = "Btn_F_Buscar"
        Me.Btn_F_Buscar.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_F_Buscar.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_F_Buscar.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_F_Buscar.selected = False
        Me.Btn_F_Buscar.Size = New System.Drawing.Size(180, 78)
        Me.Btn_F_Buscar.TabIndex = 23
        Me.Btn_F_Buscar.Text = "Buscar"
        Me.Btn_F_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_F_Buscar.Textcolor = System.Drawing.Color.White
        Me.Btn_F_Buscar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_F_Actualizar
        '
        Me.Btn_F_Actualizar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_F_Actualizar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_F_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_F_Actualizar.BorderRadius = 0
        Me.Btn_F_Actualizar.ButtonText = "Actualizar"
        Me.Btn_F_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_F_Actualizar.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_F_Actualizar.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_F_Actualizar.Iconimage = Global.Main.My.Resources.Resources.actualizar
        Me.Btn_F_Actualizar.Iconimage_right = Nothing
        Me.Btn_F_Actualizar.Iconimage_right_Selected = Nothing
        Me.Btn_F_Actualizar.Iconimage_Selected = Nothing
        Me.Btn_F_Actualizar.IconMarginLeft = 0
        Me.Btn_F_Actualizar.IconMarginRight = 0
        Me.Btn_F_Actualizar.IconRightVisible = True
        Me.Btn_F_Actualizar.IconRightZoom = 0R
        Me.Btn_F_Actualizar.IconVisible = True
        Me.Btn_F_Actualizar.IconZoom = 90.0R
        Me.Btn_F_Actualizar.IsTab = False
        Me.Btn_F_Actualizar.Location = New System.Drawing.Point(169, 738)
        Me.Btn_F_Actualizar.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_F_Actualizar.Name = "Btn_F_Actualizar"
        Me.Btn_F_Actualizar.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_F_Actualizar.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_F_Actualizar.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_F_Actualizar.selected = False
        Me.Btn_F_Actualizar.Size = New System.Drawing.Size(180, 78)
        Me.Btn_F_Actualizar.TabIndex = 22
        Me.Btn_F_Actualizar.Text = "Actualizar"
        Me.Btn_F_Actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_F_Actualizar.Textcolor = System.Drawing.Color.White
        Me.Btn_F_Actualizar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_F_Eliminar
        '
        Me.Btn_F_Eliminar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_F_Eliminar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_F_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_F_Eliminar.BorderRadius = 0
        Me.Btn_F_Eliminar.ButtonText = "Eliminar"
        Me.Btn_F_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_F_Eliminar.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_F_Eliminar.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_F_Eliminar.Iconimage = Global.Main.My.Resources.Resources.eliminar
        Me.Btn_F_Eliminar.Iconimage_right = Nothing
        Me.Btn_F_Eliminar.Iconimage_right_Selected = Nothing
        Me.Btn_F_Eliminar.Iconimage_Selected = Nothing
        Me.Btn_F_Eliminar.IconMarginLeft = 0
        Me.Btn_F_Eliminar.IconMarginRight = 0
        Me.Btn_F_Eliminar.IconRightVisible = True
        Me.Btn_F_Eliminar.IconRightZoom = 0R
        Me.Btn_F_Eliminar.IconVisible = True
        Me.Btn_F_Eliminar.IconZoom = 90.0R
        Me.Btn_F_Eliminar.IsTab = False
        Me.Btn_F_Eliminar.Location = New System.Drawing.Point(169, 623)
        Me.Btn_F_Eliminar.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_F_Eliminar.Name = "Btn_F_Eliminar"
        Me.Btn_F_Eliminar.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_F_Eliminar.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_F_Eliminar.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_F_Eliminar.selected = False
        Me.Btn_F_Eliminar.Size = New System.Drawing.Size(180, 78)
        Me.Btn_F_Eliminar.TabIndex = 21
        Me.Btn_F_Eliminar.Text = "Eliminar"
        Me.Btn_F_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_F_Eliminar.Textcolor = System.Drawing.Color.White
        Me.Btn_F_Eliminar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_F_Agregar
        '
        Me.Btn_F_Agregar.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_F_Agregar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_F_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_F_Agregar.BorderRadius = 0
        Me.Btn_F_Agregar.ButtonText = "Agregar"
        Me.Btn_F_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_F_Agregar.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_F_Agregar.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_F_Agregar.Iconimage = Global.Main.My.Resources.Resources.anadir
        Me.Btn_F_Agregar.Iconimage_right = Nothing
        Me.Btn_F_Agregar.Iconimage_right_Selected = Nothing
        Me.Btn_F_Agregar.Iconimage_Selected = Nothing
        Me.Btn_F_Agregar.IconMarginLeft = 0
        Me.Btn_F_Agregar.IconMarginRight = 0
        Me.Btn_F_Agregar.IconRightVisible = True
        Me.Btn_F_Agregar.IconRightZoom = 0R
        Me.Btn_F_Agregar.IconVisible = True
        Me.Btn_F_Agregar.IconZoom = 90.0R
        Me.Btn_F_Agregar.IsTab = False
        Me.Btn_F_Agregar.Location = New System.Drawing.Point(169, 516)
        Me.Btn_F_Agregar.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_F_Agregar.Name = "Btn_F_Agregar"
        Me.Btn_F_Agregar.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_F_Agregar.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_F_Agregar.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_F_Agregar.selected = False
        Me.Btn_F_Agregar.Size = New System.Drawing.Size(180, 78)
        Me.Btn_F_Agregar.TabIndex = 20
        Me.Btn_F_Agregar.Text = "Agregar"
        Me.Btn_F_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_F_Agregar.Textcolor = System.Drawing.Color.White
        Me.Btn_F_Agregar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'F_grd
        '
        Me.F_grd.AllowUserToAddRows = False
        Me.F_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.F_grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column4})
        Me.F_grd.Location = New System.Drawing.Point(688, 516)
        Me.F_grd.Margin = New System.Windows.Forms.Padding(4)
        Me.F_grd.Name = "F_grd"
        Me.F_grd.Size = New System.Drawing.Size(720, 401)
        Me.F_grd.TabIndex = 24
        '
        'Column1
        '
        Me.Column1.HeaderText = "Fecha"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Valor"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Descripcion"
        Me.Column3.Name = "Column3"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Ingresos/Egresos"
        Me.Column5.Name = "Column5"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Id_torneo"
        Me.Column4.Name = "Column4"
        '
        'Date_Fondos
        '
        Me.Date_Fondos.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Fondos.CustomFormat = "yyyy-MM-dd"
        Me.Date_Fondos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Fondos.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Date_Fondos.Location = New System.Drawing.Point(537, 68)
        Me.Date_Fondos.Margin = New System.Windows.Forms.Padding(4)
        Me.Date_Fondos.Name = "Date_Fondos"
        Me.Date_Fondos.Size = New System.Drawing.Size(165, 30)
        Me.Date_Fondos.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(279, 277)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(203, 29)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Ingresos/Egresos"
        '
        'Cbo_Descripcion
        '
        Me.Cbo_Descripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Descripcion.FormattingEnabled = True
        Me.Cbo_Descripcion.Location = New System.Drawing.Point(537, 272)
        Me.Cbo_Descripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.Cbo_Descripcion.Name = "Cbo_Descripcion"
        Me.Cbo_Descripcion.Size = New System.Drawing.Size(295, 33)
        Me.Cbo_Descripcion.TabIndex = 29
        '
        'Fondos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Main.My.Resources.Resources.FINALFINAL
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1837, 1055)
        Me.Controls.Add(Me.Cbo_Descripcion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Date_Fondos)
        Me.Controls.Add(Me.F_grd)
        Me.Controls.Add(Me.Btn_F_Buscar)
        Me.Controls.Add(Me.Btn_F_Actualizar)
        Me.Controls.Add(Me.Btn_F_Eliminar)
        Me.Controls.Add(Me.Btn_F_Agregar)
        Me.Controls.Add(Me.Txt_F_idtorneo)
        Me.Controls.Add(Me.Txt_F_Descripcion)
        Me.Controls.Add(Me.Txt_F_Valor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Fondos"
        Me.Text = "Fondos"
        CType(Me.F_grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_F_Valor As TextBox
    Friend WithEvents Txt_F_Descripcion As TextBox
    Friend WithEvents Txt_F_idtorneo As TextBox
    Friend WithEvents Btn_F_Buscar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_F_Actualizar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_F_Eliminar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_F_Agregar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents F_grd As DataGridView
    Friend WithEvents Date_Fondos As DateTimePicker
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Cbo_Descripcion As ComboBox
End Class
