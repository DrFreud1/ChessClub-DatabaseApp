<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Auspiciante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Auspiciante))
        Me.A_grd = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_A_Buscar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_A_Actualizar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_A_Eliminar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_A_Agregar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_A_id = New System.Windows.Forms.TextBox()
        Me.Txt_A_Nombre = New System.Windows.Forms.TextBox()
        Me.Txt_A_Direccion = New System.Windows.Forms.TextBox()
        Me.Txt_A_Telefono = New System.Windows.Forms.TextBox()
        Me.Txt_A_Email = New System.Windows.Forms.TextBox()
        CType(Me.A_grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'A_grd
        '
        Me.A_grd.AllowUserToAddRows = False
        Me.A_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.A_grd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.A_grd.Location = New System.Drawing.Point(711, 28)
        Me.A_grd.Margin = New System.Windows.Forms.Padding(4)
        Me.A_grd.Name = "A_grd"
        Me.A_grd.Size = New System.Drawing.Size(724, 417)
        Me.A_grd.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id_Auspiciante"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Direccion"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Telefono"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Email"
        Me.Column5.Name = "Column5"
        '
        'Btn_A_Buscar
        '
        Me.Btn_A_Buscar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_A_Buscar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_A_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_A_Buscar.BorderRadius = 0
        Me.Btn_A_Buscar.ButtonText = "Buscar"
        Me.Btn_A_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_A_Buscar.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_A_Buscar.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_A_Buscar.Iconimage = Global.Main.My.Resources.Resources.buscar
        Me.Btn_A_Buscar.Iconimage_right = Nothing
        Me.Btn_A_Buscar.Iconimage_right_Selected = Nothing
        Me.Btn_A_Buscar.Iconimage_Selected = Nothing
        Me.Btn_A_Buscar.IconMarginLeft = 0
        Me.Btn_A_Buscar.IconMarginRight = 0
        Me.Btn_A_Buscar.IconRightVisible = True
        Me.Btn_A_Buscar.IconRightZoom = 0R
        Me.Btn_A_Buscar.IconVisible = True
        Me.Btn_A_Buscar.IconZoom = 90.0R
        Me.Btn_A_Buscar.IsTab = False
        Me.Btn_A_Buscar.Location = New System.Drawing.Point(1472, 367)
        Me.Btn_A_Buscar.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_A_Buscar.Name = "Btn_A_Buscar"
        Me.Btn_A_Buscar.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_A_Buscar.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_A_Buscar.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_A_Buscar.selected = False
        Me.Btn_A_Buscar.Size = New System.Drawing.Size(180, 78)
        Me.Btn_A_Buscar.TabIndex = 7
        Me.Btn_A_Buscar.Text = "Buscar"
        Me.Btn_A_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_A_Buscar.Textcolor = System.Drawing.Color.White
        Me.Btn_A_Buscar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_A_Actualizar
        '
        Me.Btn_A_Actualizar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_A_Actualizar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_A_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_A_Actualizar.BorderRadius = 0
        Me.Btn_A_Actualizar.ButtonText = "Actualizar"
        Me.Btn_A_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_A_Actualizar.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_A_Actualizar.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_A_Actualizar.Iconimage = Global.Main.My.Resources.Resources.actualizar
        Me.Btn_A_Actualizar.Iconimage_right = Nothing
        Me.Btn_A_Actualizar.Iconimage_right_Selected = Nothing
        Me.Btn_A_Actualizar.Iconimage_Selected = Nothing
        Me.Btn_A_Actualizar.IconMarginLeft = 0
        Me.Btn_A_Actualizar.IconMarginRight = 0
        Me.Btn_A_Actualizar.IconRightVisible = True
        Me.Btn_A_Actualizar.IconRightZoom = 0R
        Me.Btn_A_Actualizar.IconVisible = True
        Me.Btn_A_Actualizar.IconZoom = 90.0R
        Me.Btn_A_Actualizar.IsTab = False
        Me.Btn_A_Actualizar.Location = New System.Drawing.Point(1472, 250)
        Me.Btn_A_Actualizar.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_A_Actualizar.Name = "Btn_A_Actualizar"
        Me.Btn_A_Actualizar.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_A_Actualizar.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_A_Actualizar.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_A_Actualizar.selected = False
        Me.Btn_A_Actualizar.Size = New System.Drawing.Size(180, 78)
        Me.Btn_A_Actualizar.TabIndex = 6
        Me.Btn_A_Actualizar.Text = "Actualizar"
        Me.Btn_A_Actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_A_Actualizar.Textcolor = System.Drawing.Color.White
        Me.Btn_A_Actualizar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_A_Eliminar
        '
        Me.Btn_A_Eliminar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_A_Eliminar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_A_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_A_Eliminar.BorderRadius = 0
        Me.Btn_A_Eliminar.ButtonText = "Eliminar"
        Me.Btn_A_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_A_Eliminar.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_A_Eliminar.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_A_Eliminar.Iconimage = Global.Main.My.Resources.Resources.eliminar
        Me.Btn_A_Eliminar.Iconimage_right = Nothing
        Me.Btn_A_Eliminar.Iconimage_right_Selected = Nothing
        Me.Btn_A_Eliminar.Iconimage_Selected = Nothing
        Me.Btn_A_Eliminar.IconMarginLeft = 0
        Me.Btn_A_Eliminar.IconMarginRight = 0
        Me.Btn_A_Eliminar.IconRightVisible = True
        Me.Btn_A_Eliminar.IconRightZoom = 0R
        Me.Btn_A_Eliminar.IconVisible = True
        Me.Btn_A_Eliminar.IconZoom = 90.0R
        Me.Btn_A_Eliminar.IsTab = False
        Me.Btn_A_Eliminar.Location = New System.Drawing.Point(1472, 134)
        Me.Btn_A_Eliminar.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_A_Eliminar.Name = "Btn_A_Eliminar"
        Me.Btn_A_Eliminar.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_A_Eliminar.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_A_Eliminar.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_A_Eliminar.selected = False
        Me.Btn_A_Eliminar.Size = New System.Drawing.Size(180, 78)
        Me.Btn_A_Eliminar.TabIndex = 5
        Me.Btn_A_Eliminar.Text = "Eliminar"
        Me.Btn_A_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_A_Eliminar.Textcolor = System.Drawing.Color.White
        Me.Btn_A_Eliminar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_A_Agregar
        '
        Me.Btn_A_Agregar.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_A_Agregar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_A_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_A_Agregar.BorderRadius = 0
        Me.Btn_A_Agregar.ButtonText = "Agregar"
        Me.Btn_A_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_A_Agregar.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_A_Agregar.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_A_Agregar.Iconimage = Global.Main.My.Resources.Resources.anadir
        Me.Btn_A_Agregar.Iconimage_right = Nothing
        Me.Btn_A_Agregar.Iconimage_right_Selected = Nothing
        Me.Btn_A_Agregar.Iconimage_Selected = Nothing
        Me.Btn_A_Agregar.IconMarginLeft = 0
        Me.Btn_A_Agregar.IconMarginRight = 0
        Me.Btn_A_Agregar.IconRightVisible = True
        Me.Btn_A_Agregar.IconRightZoom = 0R
        Me.Btn_A_Agregar.IconVisible = True
        Me.Btn_A_Agregar.IconZoom = 90.0R
        Me.Btn_A_Agregar.IsTab = False
        Me.Btn_A_Agregar.Location = New System.Drawing.Point(1472, 28)
        Me.Btn_A_Agregar.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_A_Agregar.Name = "Btn_A_Agregar"
        Me.Btn_A_Agregar.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.Btn_A_Agregar.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.Btn_A_Agregar.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_A_Agregar.selected = False
        Me.Btn_A_Agregar.Size = New System.Drawing.Size(180, 78)
        Me.Btn_A_Agregar.TabIndex = 4
        Me.Btn_A_Agregar.Text = "Agregar"
        Me.Btn_A_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_A_Agregar.Textcolor = System.Drawing.Color.White
        Me.Btn_A_Agregar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Id Auspiciante"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(193, 206)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 29)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Dirección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(200, 283)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 29)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(237, 359)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 29)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Email"
        '
        'Txt_A_id
        '
        Me.Txt_A_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_A_id.Location = New System.Drawing.Point(349, 64)
        Me.Txt_A_id.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_A_id.Name = "Txt_A_id"
        Me.Txt_A_id.Size = New System.Drawing.Size(105, 30)
        Me.Txt_A_id.TabIndex = 14
        '
        'Txt_A_Nombre
        '
        Me.Txt_A_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_A_Nombre.Location = New System.Drawing.Point(349, 134)
        Me.Txt_A_Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_A_Nombre.Name = "Txt_A_Nombre"
        Me.Txt_A_Nombre.Size = New System.Drawing.Size(295, 30)
        Me.Txt_A_Nombre.TabIndex = 15
        '
        'Txt_A_Direccion
        '
        Me.Txt_A_Direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_A_Direccion.Location = New System.Drawing.Point(349, 206)
        Me.Txt_A_Direccion.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_A_Direccion.Name = "Txt_A_Direccion"
        Me.Txt_A_Direccion.Size = New System.Drawing.Size(295, 30)
        Me.Txt_A_Direccion.TabIndex = 16
        '
        'Txt_A_Telefono
        '
        Me.Txt_A_Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_A_Telefono.Location = New System.Drawing.Point(349, 281)
        Me.Txt_A_Telefono.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_A_Telefono.Name = "Txt_A_Telefono"
        Me.Txt_A_Telefono.Size = New System.Drawing.Size(295, 30)
        Me.Txt_A_Telefono.TabIndex = 17
        '
        'Txt_A_Email
        '
        Me.Txt_A_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_A_Email.Location = New System.Drawing.Point(349, 357)
        Me.Txt_A_Email.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_A_Email.Name = "Txt_A_Email"
        Me.Txt_A_Email.Size = New System.Drawing.Size(295, 30)
        Me.Txt_A_Email.TabIndex = 18
        '
        'Auspiciante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Main.My.Resources.Resources.FINALFINAL
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1837, 516)
        Me.Controls.Add(Me.Txt_A_Email)
        Me.Controls.Add(Me.Txt_A_Telefono)
        Me.Controls.Add(Me.Txt_A_Direccion)
        Me.Controls.Add(Me.Txt_A_Nombre)
        Me.Controls.Add(Me.Txt_A_id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.A_grd)
        Me.Controls.Add(Me.Btn_A_Buscar)
        Me.Controls.Add(Me.Btn_A_Actualizar)
        Me.Controls.Add(Me.Btn_A_Eliminar)
        Me.Controls.Add(Me.Btn_A_Agregar)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Auspiciante"
        Me.Text = "Auspiciante"
        CType(Me.A_grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_A_Agregar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_A_Eliminar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_A_Actualizar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_A_Buscar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents A_grd As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_A_id As TextBox
    Friend WithEvents Txt_A_Nombre As TextBox
    Friend WithEvents Txt_A_Direccion As TextBox
    Friend WithEvents Txt_A_Telefono As TextBox
    Friend WithEvents Txt_A_Email As TextBox
End Class
