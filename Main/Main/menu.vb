Public Class Main
    Public gcn As New Odbc.OdbcConnection

    Private Sub ArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim lstrCon As String
        lstrCon = "Driver={PostgreSQL ANSI};"
        lstrCon = lstrCon + "database=Chess Club Yachay Tech;"
        lstrCon = lstrCon + "server=localhost;"
        lstrCon = lstrCon + "port=5432;"
        lstrCon = lstrCon + "uid=postgres;"
        lstrCon = lstrCon + "pwd=123456;"
        gcn.ConnectionString = lstrCon
        gcn.Open()

    End Sub


    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If

        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()

    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If (SideMenu.Width = 70) Then
            SideMenu.Visible = False
            SideMenu.Width = 271
            PanelAnimator.ShowSync(SideMenu)
            LogoAnimator.ShowSync(PicLogo)

        Else
            LogoAnimator.HideSync(PicLogo)
            SideMenu.Visible = False
            SideMenu.Width = 70
            PanelAnimator.ShowSync(SideMenu)
        End If
    End Sub

    Private Sub BtnAuspiciante_Click(sender As Object, e As EventArgs) Handles BtnAuspiciante.Click
        AbrirFormEnPanel(New Auspiciante)
    End Sub

    Private Sub BtnFondos_Click(sender As Object, e As EventArgs) Handles BtnFondos.Click
        AbrirFormEnPanel(New Fondos)
    End Sub

    Private Sub BtnJugador_Click(sender As Object, e As EventArgs) Handles BtnJugador.Click
        AbrirFormEnPanel(New frm_jug)

    End Sub

    Private Sub BtnPartida_Click(sender As Object, e As EventArgs) Handles BtnPartida.Click
        AbrirFormEnPanel(New partida)

    End Sub

    Private Sub BtnTorneo_Click(sender As Object, e As EventArgs) Handles BtnTorneo.Click
        AbrirFormEnPanel(New frmTorneo)
    End Sub

    Private Sub BtnEquipo_Click(sender As Object, e As EventArgs) Handles BtnEquipo.Click
        AbrirFormEnPanel(New frm_equ)
    End Sub

    Private Sub BtnDirectiva_Click(sender As Object, e As EventArgs) Handles BtnDirectiva.Click
        AbrirFormEnPanel(New frmDirectiva)
    End Sub


End Class
