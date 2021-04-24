<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDirectiva
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDirectiva))
        Me.grdDirectiva = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboAnio = New System.Windows.Forms.ComboBox()
        Me.cboCargo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.cboJugadorID = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.txtPeriodo = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAgregar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnShowDirect = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.grdDirectiva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdDirectiva
        '
        Me.grdDirectiva.AllowUserToAddRows = False
        Me.grdDirectiva.AllowUserToDeleteRows = False
        Me.grdDirectiva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDirectiva.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6, Me.Column2, Me.Column3, Me.Column1})
        Me.grdDirectiva.Location = New System.Drawing.Point(514, 155)
        Me.grdDirectiva.Name = "grdDirectiva"
        Me.grdDirectiva.ReadOnly = True
        Me.grdDirectiva.RowTemplate.Height = 24
        Me.grdDirectiva.Size = New System.Drawing.Size(880, 488)
        Me.grdDirectiva.TabIndex = 0
        '
        'Column4
        '
        Me.Column4.HeaderText = "ID Jugador"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Nombre"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Apellido"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cargo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Anio"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Periodo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'cboAnio
        '
        Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnio.FormattingEnabled = True
        Me.cboAnio.Location = New System.Drawing.Point(741, 38)
        Me.cboAnio.Name = "cboAnio"
        Me.cboAnio.Size = New System.Drawing.Size(121, 24)
        Me.cboAnio.TabIndex = 2
        '
        'cboCargo
        '
        Me.cboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCargo.FormattingEnabled = True
        Me.cboCargo.Location = New System.Drawing.Point(1156, 85)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Size = New System.Drawing.Size(121, 24)
        Me.cboCargo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(603, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID de Jugador: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1009, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Periodo: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1009, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cargo Ocupado: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(603, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Anio:"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(1156, 38)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(121, 24)
        Me.cboPeriodo.TabIndex = 9
        '
        'cboJugadorID
        '
        Me.cboJugadorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJugadorID.FormattingEnabled = True
        Me.cboJugadorID.Location = New System.Drawing.Point(741, 89)
        Me.cboJugadorID.Name = "cboJugadorID"
        Me.cboJugadorID.Size = New System.Drawing.Size(121, 24)
        Me.cboJugadorID.TabIndex = 39
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(172, 512)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 22)
        Me.txtID.TabIndex = 40
        Me.txtID.Visible = False
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(172, 540)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(100, 22)
        Me.txtAnio.TabIndex = 41
        Me.txtAnio.Visible = False
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Location = New System.Drawing.Point(172, 568)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Size = New System.Drawing.Size(100, 22)
        Me.txtPeriodo.TabIndex = 42
        Me.txtPeriodo.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnEliminar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.BorderRadius = 0
        Me.btnEliminar.ButtonText = "Eliminar"
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.DisabledColor = System.Drawing.Color.Gray
        Me.btnEliminar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnEliminar.Iconimage = Global.Main.My.Resources.Resources.eliminar
        Me.btnEliminar.Iconimage_right = Nothing
        Me.btnEliminar.Iconimage_right_Selected = Nothing
        Me.btnEliminar.Iconimage_Selected = Nothing
        Me.btnEliminar.IconMarginLeft = 0
        Me.btnEliminar.IconMarginRight = 0
        Me.btnEliminar.IconRightVisible = True
        Me.btnEliminar.IconRightZoom = 0R
        Me.btnEliminar.IconVisible = True
        Me.btnEliminar.IconZoom = 90.0R
        Me.btnEliminar.IsTab = False
        Me.btnEliminar.Location = New System.Drawing.Point(99, 426)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.btnEliminar.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.btnEliminar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnEliminar.selected = False
        Me.btnEliminar.Size = New System.Drawing.Size(249, 78)
        Me.btnEliminar.TabIndex = 38
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEliminar.Textcolor = System.Drawing.Color.White
        Me.btnEliminar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAgregar
        '
        Me.btnAgregar.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.btnAgregar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregar.BorderRadius = 0
        Me.btnAgregar.ButtonText = "Agregar"
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.DisabledColor = System.Drawing.Color.Gray
        Me.btnAgregar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAgregar.Iconimage = Global.Main.My.Resources.Resources.anadir
        Me.btnAgregar.Iconimage_right = Nothing
        Me.btnAgregar.Iconimage_right_Selected = Nothing
        Me.btnAgregar.Iconimage_Selected = Nothing
        Me.btnAgregar.IconMarginLeft = 0
        Me.btnAgregar.IconMarginRight = 0
        Me.btnAgregar.IconRightVisible = True
        Me.btnAgregar.IconRightZoom = 0R
        Me.btnAgregar.IconVisible = True
        Me.btnAgregar.IconZoom = 90.0R
        Me.btnAgregar.IsTab = False
        Me.btnAgregar.Location = New System.Drawing.Point(99, 285)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.btnAgregar.OnHovercolor = System.Drawing.Color.DarkCyan
        Me.btnAgregar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAgregar.selected = False
        Me.btnAgregar.Size = New System.Drawing.Size(249, 78)
        Me.btnAgregar.TabIndex = 37
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAgregar.Textcolor = System.Drawing.Color.White
        Me.btnAgregar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnShowDirect
        '
        Me.btnShowDirect.ActiveBorderThickness = 1
        Me.btnShowDirect.ActiveCornerRadius = 20
        Me.btnShowDirect.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnShowDirect.ActiveForecolor = System.Drawing.Color.White
        Me.btnShowDirect.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnShowDirect.BackColor = System.Drawing.SystemColors.Control
        Me.btnShowDirect.BackgroundImage = CType(resources.GetObject("btnShowDirect.BackgroundImage"), System.Drawing.Image)
        Me.btnShowDirect.ButtonText = "Mostrar Directiva"
        Me.btnShowDirect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowDirect.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowDirect.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnShowDirect.IdleBorderThickness = 1
        Me.btnShowDirect.IdleCornerRadius = 20
        Me.btnShowDirect.IdleFillColor = System.Drawing.Color.White
        Me.btnShowDirect.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnShowDirect.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnShowDirect.Location = New System.Drawing.Point(99, 38)
        Me.btnShowDirect.Margin = New System.Windows.Forms.Padding(5)
        Me.btnShowDirect.Name = "btnShowDirect"
        Me.btnShowDirect.Size = New System.Drawing.Size(249, 101)
        Me.btnShowDirect.TabIndex = 1
        Me.btnShowDirect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDirectiva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Main.My.Resources.Resources.FINALFINAL
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1411, 666)
        Me.Controls.Add(Me.txtPeriodo)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.cboJugadorID)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCargo)
        Me.Controls.Add(Me.cboAnio)
        Me.Controls.Add(Me.btnShowDirect)
        Me.Controls.Add(Me.grdDirectiva)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDirectiva"
        Me.Text = "Directiva del Club"
        CType(Me.grdDirectiva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdDirectiva As DataGridView
    Friend WithEvents btnShowDirect As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents cboCargo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboPeriodo As ComboBox
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents btnAgregar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnEliminar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cboAnio As ComboBox
    Friend WithEvents cboJugadorID As ComboBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents txtPeriodo As TextBox
End Class
