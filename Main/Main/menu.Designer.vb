<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation4 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.SideMenu = New System.Windows.Forms.Panel()
        Me.BtnPartida = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnJugador = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.BtnAuspiciante = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnFondos = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnEquipo = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnTorneo = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnDirectiva = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.LogoAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.SideMenu.SuspendLayout()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SideMenu
        '
        Me.SideMenu.BackColor = System.Drawing.Color.Silver
        Me.SideMenu.Controls.Add(Me.BtnPartida)
        Me.SideMenu.Controls.Add(Me.BtnJugador)
        Me.SideMenu.Controls.Add(Me.PicLogo)
        Me.SideMenu.Controls.Add(Me.btnMenu)
        Me.SideMenu.Controls.Add(Me.BtnAuspiciante)
        Me.SideMenu.Controls.Add(Me.BtnFondos)
        Me.SideMenu.Controls.Add(Me.BtnEquipo)
        Me.SideMenu.Controls.Add(Me.BtnTorneo)
        Me.SideMenu.Controls.Add(Me.BtnDirectiva)
        Me.PanelAnimator.SetDecoration(Me.SideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.SideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideMenu.Location = New System.Drawing.Point(0, 0)
        Me.SideMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SideMenu.Name = "SideMenu"
        Me.SideMenu.Size = New System.Drawing.Size(361, 897)
        Me.SideMenu.TabIndex = 12
        '
        'BtnPartida
        '
        Me.BtnPartida.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.BtnPartida.BackColor = System.Drawing.Color.Teal
        Me.BtnPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPartida.BorderRadius = 1
        Me.BtnPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BtnPartida.ButtonText = "         Partida"
        Me.BtnPartida.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BtnPartida, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnPartida, BunifuAnimatorNS.DecorationType.None)
        Me.BtnPartida.DisabledColor = System.Drawing.Color.Gray
        Me.BtnPartida.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnPartida.Iconimage = Global.Main.My.Resources.Resources.partida2
        Me.BtnPartida.Iconimage_right = Nothing
        Me.BtnPartida.Iconimage_right_Selected = Nothing
        Me.BtnPartida.Iconimage_Selected = Nothing
        Me.BtnPartida.IconMarginLeft = 0
        Me.BtnPartida.IconMarginRight = 0
        Me.BtnPartida.IconRightVisible = True
        Me.BtnPartida.IconRightZoom = 0R
        Me.BtnPartida.IconVisible = True
        Me.BtnPartida.IconZoom = 110.0R
        Me.BtnPartida.IsTab = True
        Me.BtnPartida.Location = New System.Drawing.Point(0, 311)
        Me.BtnPartida.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnPartida.Name = "BtnPartida"
        Me.BtnPartida.Normalcolor = System.Drawing.Color.Teal
        Me.BtnPartida.OnHovercolor = System.Drawing.Color.DarkSlateGray
        Me.BtnPartida.OnHoverTextColor = System.Drawing.Color.DarkTurquoise
        Me.BtnPartida.selected = False
        Me.BtnPartida.Size = New System.Drawing.Size(361, 76)
        Me.BtnPartida.TabIndex = 18
        Me.BtnPartida.Text = "         Partida"
        Me.BtnPartida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPartida.Textcolor = System.Drawing.Color.White
        Me.BtnPartida.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnJugador
        '
        Me.BtnJugador.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.BtnJugador.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnJugador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnJugador.BorderRadius = 1
        Me.BtnJugador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BtnJugador.ButtonText = "          Jugador"
        Me.BtnJugador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BtnJugador, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnJugador, BunifuAnimatorNS.DecorationType.None)
        Me.BtnJugador.DisabledColor = System.Drawing.Color.Gray
        Me.BtnJugador.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnJugador.Iconimage = Global.Main.My.Resources.Resources.perfil
        Me.BtnJugador.Iconimage_right = Nothing
        Me.BtnJugador.Iconimage_right_Selected = Nothing
        Me.BtnJugador.Iconimage_Selected = Nothing
        Me.BtnJugador.IconMarginLeft = 0
        Me.BtnJugador.IconMarginRight = 0
        Me.BtnJugador.IconRightVisible = True
        Me.BtnJugador.IconRightZoom = 0R
        Me.BtnJugador.IconVisible = True
        Me.BtnJugador.IconZoom = 110.0R
        Me.BtnJugador.IsTab = True
        Me.BtnJugador.Location = New System.Drawing.Point(0, 228)
        Me.BtnJugador.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnJugador.Name = "BtnJugador"
        Me.BtnJugador.Normalcolor = System.Drawing.Color.Teal
        Me.BtnJugador.OnHovercolor = System.Drawing.Color.DarkSlateGray
        Me.BtnJugador.OnHoverTextColor = System.Drawing.Color.DarkTurquoise
        Me.BtnJugador.selected = True
        Me.BtnJugador.Size = New System.Drawing.Size(361, 76)
        Me.BtnJugador.TabIndex = 17
        Me.BtnJugador.Text = "          Jugador"
        Me.BtnJugador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnJugador.Textcolor = System.Drawing.Color.White
        Me.BtnJugador.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PicLogo
        '
        Me.LogoAnimator.SetDecoration(Me.PicLogo, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.PicLogo, BunifuAnimatorNS.DecorationType.None)
        Me.PicLogo.Image = Global.Main.My.Resources.Resources.Logo_NoFondo
        Me.PicLogo.Location = New System.Drawing.Point(16, 15)
        Me.PicLogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(259, 190)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicLogo.TabIndex = 12
        Me.PicLogo.TabStop = False
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoAnimator.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.Location = New System.Drawing.Point(283, 15)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(59, 53)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 12
        Me.btnMenu.TabStop = False
        '
        'BtnAuspiciante
        '
        Me.BtnAuspiciante.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.BtnAuspiciante.BackColor = System.Drawing.Color.Teal
        Me.BtnAuspiciante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAuspiciante.BorderRadius = 1
        Me.BtnAuspiciante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BtnAuspiciante.ButtonText = "          Auspiciante"
        Me.BtnAuspiciante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BtnAuspiciante, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnAuspiciante, BunifuAnimatorNS.DecorationType.None)
        Me.BtnAuspiciante.DisabledColor = System.Drawing.Color.Gray
        Me.BtnAuspiciante.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnAuspiciante.Iconimage = Global.Main.My.Resources.Resources.auspiciante
        Me.BtnAuspiciante.Iconimage_right = Nothing
        Me.BtnAuspiciante.Iconimage_right_Selected = Nothing
        Me.BtnAuspiciante.Iconimage_Selected = Nothing
        Me.BtnAuspiciante.IconMarginLeft = 0
        Me.BtnAuspiciante.IconMarginRight = 0
        Me.BtnAuspiciante.IconRightVisible = True
        Me.BtnAuspiciante.IconRightZoom = 0R
        Me.BtnAuspiciante.IconVisible = True
        Me.BtnAuspiciante.IconZoom = 110.0R
        Me.BtnAuspiciante.IsTab = True
        Me.BtnAuspiciante.Location = New System.Drawing.Point(0, 732)
        Me.BtnAuspiciante.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnAuspiciante.Name = "BtnAuspiciante"
        Me.BtnAuspiciante.Normalcolor = System.Drawing.Color.Teal
        Me.BtnAuspiciante.OnHovercolor = System.Drawing.Color.DarkSlateGray
        Me.BtnAuspiciante.OnHoverTextColor = System.Drawing.Color.DarkTurquoise
        Me.BtnAuspiciante.selected = False
        Me.BtnAuspiciante.Size = New System.Drawing.Size(361, 76)
        Me.BtnAuspiciante.TabIndex = 16
        Me.BtnAuspiciante.Text = "          Auspiciante"
        Me.BtnAuspiciante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAuspiciante.Textcolor = System.Drawing.Color.White
        Me.BtnAuspiciante.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnFondos
        '
        Me.BtnFondos.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.BtnFondos.BackColor = System.Drawing.Color.Teal
        Me.BtnFondos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFondos.BorderRadius = 1
        Me.BtnFondos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BtnFondos.ButtonText = "          Fondos"
        Me.BtnFondos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BtnFondos, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnFondos, BunifuAnimatorNS.DecorationType.None)
        Me.BtnFondos.DisabledColor = System.Drawing.Color.Gray
        Me.BtnFondos.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnFondos.Iconimage = Global.Main.My.Resources.Resources.fondos
        Me.BtnFondos.Iconimage_right = Nothing
        Me.BtnFondos.Iconimage_right_Selected = Nothing
        Me.BtnFondos.Iconimage_Selected = Nothing
        Me.BtnFondos.IconMarginLeft = 0
        Me.BtnFondos.IconMarginRight = 0
        Me.BtnFondos.IconRightVisible = True
        Me.BtnFondos.IconRightZoom = 0R
        Me.BtnFondos.IconVisible = True
        Me.BtnFondos.IconZoom = 110.0R
        Me.BtnFondos.IsTab = True
        Me.BtnFondos.Location = New System.Drawing.Point(0, 646)
        Me.BtnFondos.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnFondos.Name = "BtnFondos"
        Me.BtnFondos.Normalcolor = System.Drawing.Color.Teal
        Me.BtnFondos.OnHovercolor = System.Drawing.Color.DarkSlateGray
        Me.BtnFondos.OnHoverTextColor = System.Drawing.Color.DarkTurquoise
        Me.BtnFondos.selected = False
        Me.BtnFondos.Size = New System.Drawing.Size(361, 76)
        Me.BtnFondos.TabIndex = 15
        Me.BtnFondos.Text = "          Fondos"
        Me.BtnFondos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFondos.Textcolor = System.Drawing.Color.White
        Me.BtnFondos.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnEquipo
        '
        Me.BtnEquipo.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.BtnEquipo.BackColor = System.Drawing.Color.Teal
        Me.BtnEquipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEquipo.BorderRadius = 1
        Me.BtnEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BtnEquipo.ButtonText = "          Equipo"
        Me.BtnEquipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BtnEquipo, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnEquipo, BunifuAnimatorNS.DecorationType.None)
        Me.BtnEquipo.DisabledColor = System.Drawing.Color.Gray
        Me.BtnEquipo.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnEquipo.Iconimage = Global.Main.My.Resources.Resources.equipo
        Me.BtnEquipo.Iconimage_right = Nothing
        Me.BtnEquipo.Iconimage_right_Selected = Nothing
        Me.BtnEquipo.Iconimage_Selected = Nothing
        Me.BtnEquipo.IconMarginLeft = 0
        Me.BtnEquipo.IconMarginRight = 0
        Me.BtnEquipo.IconRightVisible = True
        Me.BtnEquipo.IconRightZoom = 0R
        Me.BtnEquipo.IconVisible = True
        Me.BtnEquipo.IconZoom = 110.0R
        Me.BtnEquipo.IsTab = True
        Me.BtnEquipo.Location = New System.Drawing.Point(0, 479)
        Me.BtnEquipo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnEquipo.Name = "BtnEquipo"
        Me.BtnEquipo.Normalcolor = System.Drawing.Color.Teal
        Me.BtnEquipo.OnHovercolor = System.Drawing.Color.DarkSlateGray
        Me.BtnEquipo.OnHoverTextColor = System.Drawing.Color.DarkTurquoise
        Me.BtnEquipo.selected = False
        Me.BtnEquipo.Size = New System.Drawing.Size(361, 76)
        Me.BtnEquipo.TabIndex = 14
        Me.BtnEquipo.Text = "          Equipo"
        Me.BtnEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEquipo.Textcolor = System.Drawing.Color.White
        Me.BtnEquipo.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnTorneo
        '
        Me.BtnTorneo.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.BtnTorneo.BackColor = System.Drawing.Color.Teal
        Me.BtnTorneo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTorneo.BorderRadius = 1
        Me.BtnTorneo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BtnTorneo.ButtonText = "          Torneo"
        Me.BtnTorneo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BtnTorneo, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnTorneo, BunifuAnimatorNS.DecorationType.None)
        Me.BtnTorneo.DisabledColor = System.Drawing.Color.Gray
        Me.BtnTorneo.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnTorneo.Iconimage = Global.Main.My.Resources.Resources.torneo
        Me.BtnTorneo.Iconimage_right = Nothing
        Me.BtnTorneo.Iconimage_right_Selected = Nothing
        Me.BtnTorneo.Iconimage_Selected = Nothing
        Me.BtnTorneo.IconMarginLeft = 0
        Me.BtnTorneo.IconMarginRight = 0
        Me.BtnTorneo.IconRightVisible = True
        Me.BtnTorneo.IconRightZoom = 0R
        Me.BtnTorneo.IconVisible = True
        Me.BtnTorneo.IconZoom = 110.0R
        Me.BtnTorneo.IsTab = True
        Me.BtnTorneo.Location = New System.Drawing.Point(0, 395)
        Me.BtnTorneo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnTorneo.Name = "BtnTorneo"
        Me.BtnTorneo.Normalcolor = System.Drawing.Color.Teal
        Me.BtnTorneo.OnHovercolor = System.Drawing.Color.DarkSlateGray
        Me.BtnTorneo.OnHoverTextColor = System.Drawing.Color.DarkTurquoise
        Me.BtnTorneo.selected = False
        Me.BtnTorneo.Size = New System.Drawing.Size(361, 76)
        Me.BtnTorneo.TabIndex = 12
        Me.BtnTorneo.Text = "          Torneo"
        Me.BtnTorneo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTorneo.Textcolor = System.Drawing.Color.White
        Me.BtnTorneo.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnDirectiva
        '
        Me.BtnDirectiva.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.BtnDirectiva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnDirectiva.BackColor = System.Drawing.Color.Teal
        Me.BtnDirectiva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDirectiva.BorderRadius = 1
        Me.BtnDirectiva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BtnDirectiva.ButtonText = "          Directiva"
        Me.BtnDirectiva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAnimator.SetDecoration(Me.BtnDirectiva, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BtnDirectiva, BunifuAnimatorNS.DecorationType.None)
        Me.BtnDirectiva.DisabledColor = System.Drawing.Color.Gray
        Me.BtnDirectiva.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnDirectiva.Iconimage = Global.Main.My.Resources.Resources.directiva
        Me.BtnDirectiva.Iconimage_right = Nothing
        Me.BtnDirectiva.Iconimage_right_Selected = Nothing
        Me.BtnDirectiva.Iconimage_Selected = Nothing
        Me.BtnDirectiva.IconMarginLeft = 0
        Me.BtnDirectiva.IconMarginRight = 0
        Me.BtnDirectiva.IconRightVisible = True
        Me.BtnDirectiva.IconRightZoom = 0R
        Me.BtnDirectiva.IconVisible = True
        Me.BtnDirectiva.IconZoom = 110.0R
        Me.BtnDirectiva.IsTab = True
        Me.BtnDirectiva.Location = New System.Drawing.Point(0, 562)
        Me.BtnDirectiva.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnDirectiva.Name = "BtnDirectiva"
        Me.BtnDirectiva.Normalcolor = System.Drawing.Color.Teal
        Me.BtnDirectiva.OnHovercolor = System.Drawing.Color.DarkSlateGray
        Me.BtnDirectiva.OnHoverTextColor = System.Drawing.Color.DarkTurquoise
        Me.BtnDirectiva.selected = False
        Me.BtnDirectiva.Size = New System.Drawing.Size(361, 76)
        Me.BtnDirectiva.TabIndex = 5
        Me.BtnDirectiva.Text = "          Directiva"
        Me.BtnDirectiva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDirectiva.Textcolor = System.Drawing.Color.White
        Me.BtnDirectiva.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LogoAnimator
        '
        Me.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.LogoAnimator.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Animation4.RotateCoeff = 0!
        Animation4.RotateLimit = 0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0!
        Animation4.TransparencyCoeff = 0!
        Me.LogoAnimator.DefaultAnimation = Animation4
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackgroundImage = Global.Main.My.Resources.Resources.FINALFINAL
        Me.PanelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelAnimator.SetDecoration(Me.PanelContenedor, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.PanelContenedor, BunifuAnimatorNS.DecorationType.None)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(361, 0)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1439, 897)
        Me.PanelContenedor.TabIndex = 13
        '
        'PanelAnimator
        '
        Me.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles
        Me.PanelAnimator.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 1
        Animation3.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 2.0!
        Animation3.TransparencyCoeff = 0!
        Me.PanelAnimator.DefaultAnimation = Animation3
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1800, 897)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.SideMenu)
        Me.LogoAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Base de Datos Club Yachay Tech"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SideMenu.ResumeLayout(False)
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SideMenu As Panel
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents BtnAuspiciante As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnFondos As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnEquipo As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnTorneo As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnDirectiva As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PanelAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents LogoAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BtnJugador As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents BtnPartida As Bunifu.Framework.UI.BunifuFlatButton
End Class
