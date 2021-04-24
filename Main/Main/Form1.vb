Imports ilf
Imports ilf.pgn
Imports ilf.pgn.Data

Namespace ReadPgnFile
End Namespace

Public Class pgn

    Private Sub pgn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txt_w.Text = partida.tb.Text
            Dim archivo As String
            archivo = partida.tb.Text
            Dim reader = New PgnReader()
            Dim db = reader.ReadFromFile(archivo)
            Dim game = db.Games(0)
            Dim njuegos = db.Games.Count
            Dim moves As String
            Dim fpartida As String = game.Year
            moves = game.ToString


            RichTextBox1.Text = moves.Substring(moves.IndexOf("1."))
            txt_w.Text = game.WhitePlayer
            txt_b.Text = game.BlackPlayer
            txt_fecha.Text = fpartida
            txt_sitio.Text = game.Event
            txt_ew.Text = moves.Substring(moves.IndexOf("WhiteElo") + 8, 7)
            txt_eb.Text = moves.Substring(moves.IndexOf("BlackElo") + 8, 7)
            If game.Result = GameResult.White Then
                txt_resultado.Text = "Piezas Blancas Ganan"
            ElseIf game.Result = GameResult.Black Then
                txt_resultado.Text = "Piezas Negras Ganan"
            ElseIf game.Result = GameResult.Draw Then
                txt_resultado.Text = "Tablas"
            Else
                txt_resultado.Text = "Juego no terminado"
            End If

            txt_total.Text = njuegos
        Catch
            MsgBox("Error Partida no escogida: " + Err.Description, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        txt_w.Text = partida.tb.Text
        Dim archivo As String
        archivo = partida.tb.Text
        Dim reader = New PgnReader()
        Dim db = reader.ReadFromFile(archivo)
        Dim njuego = txt_num.Text
        Dim game = db.Games(Convert.ToInt32(njuego) - 1)
        Dim njuegos = db.Games.Count
        Dim moves As String
        Dim fpartida As String = game.Year
        moves = game.ToString


        RichTextBox1.Text = moves.Substring(moves.IndexOf("1."))
        txt_w.Text = game.WhitePlayer
        txt_b.Text = game.BlackPlayer
        txt_fecha.Text = fpartida
        txt_sitio.Text = game.Event
        txt_ew.Text = moves.Substring(moves.IndexOf("WhiteElo") + 8, 7)
        txt_eb.Text = moves.Substring(moves.IndexOf("BlackElo") + 8, 7)
        If game.Result = GameResult.White Then
            txt_resultado.Text = "Piezas Blancas Ganan"
        ElseIf game.Result = GameResult.Black Then
            txt_resultado.Text = "Piezas Negras Ganan"
        ElseIf game.Result = GameResult.Draw Then
            txt_resultado.Text = "Tablas"
        Else
            txt_resultado.Text = "Juego no terminado"
        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        txt_w.Text = partida.tb.Text
        Dim archivo As String
        archivo = partida.tb.Text
        Dim reader = New PgnReader()
        Dim db = reader.ReadFromFile(archivo)
        Dim njuego = txt_num.Text
        Dim game = db.Games(Convert.ToInt32(njuego) - 1)
        Dim moves As String
        moves = game.ToString
        Clipboard.SetText(moves)
        MsgBox("Partida Copiada al portapapeles")

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click

        Process.Start("https://lichess.org/paste")
    End Sub
End Class