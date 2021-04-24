Public Class partida
    Public Shared tb As TextBox
    Private Sub partida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sSQL As String
        sSQL = "select ssn,id_torneo,vic,der,emp,pos,diff_elo,pgn from played"
        Dim cmd As New Odbc.OdbcCommand
        Dim dr As Odbc.OdbcDataReader
        cmd.CommandText = sSQL
        cmd.Connection = Main.gcn
        dr = cmd.ExecuteReader()
        jrd_partida.RowCount = 0
        While dr.Read()
            jrd_partida.Rows.Add()
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(0).Value = dr(0)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(1).Value = dr(1)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(2).Value = dr(2)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(3).Value = dr(3)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(4).Value = dr(4)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(5).Value = dr(5)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(6).Value = dr(6)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(7).Value = dr(7)
        End While
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "Seleccione archivo PGN"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Filter = "PGN Files|*.pgn"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txt_pgn.Text = OpenFileDialog1.FileName
        Else
            txt_pgn.Text = "Archivo no seleccionado"
        End If
    End Sub

    Private Sub Btn_agreP_Click(sender As Object, e As EventArgs) Handles Btn_agreP.Click
        Dim sSQL As String
        Dim cmd As New Odbc.OdbcCommand
        Try
            sSQL = "INSERT INTO played VALUES ("
            sSQL = sSQL + txt_vic.Text + ", "
            sSQL = sSQL + txt_der.Text + ", "
            sSQL = sSQL + txt_emp.Text + ", "
            sSQL = sSQL + txt_pos.Text + ", "
            sSQL = sSQL + " '" + txt_elo.Text + " ',"
            sSQL = sSQL + " '" + txt_SSN.Text + " ',"
            sSQL = sSQL + txt_torneo.Text + ", "
            sSQL = sSQL + " '" + txt_pgn.Text + " '"
            sSQL = sSQL + ")"

            cmd.CommandText = sSQL
            cmd.Connection = Main.gcn
            cmd.ExecuteNonQuery()

        Catch
            MsgBox("Class Form_Partida --> Funcion btnAgregar_Click:" + Err.Description, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        MsgBox("Se añadió partida")

        Dim sSQL2 As String
        sSQL2 = "select ssn,id_torneo,vic,der,emp,pos,diff_elo,pgn from played"
        Dim cmd2 As New Odbc.OdbcCommand
        Dim dr2 As Odbc.OdbcDataReader
        cmd2.CommandText = sSQL2
        cmd2.Connection = Main.gcn
        dr2 = cmd2.ExecuteReader()
        jrd_partida.RowCount = 0
        While dr2.Read()
            jrd_partida.Rows.Add()
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(0).Value = dr2(0)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(1).Value = dr2(1)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(2).Value = dr2(2)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(3).Value = dr2(3)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(4).Value = dr2(4)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(5).Value = dr2(5)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(6).Value = dr2(6)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(7).Value = dr2(7)
        End While
    End Sub

    Private Sub Btn_elimP_Click(sender As Object, e As EventArgs) Handles Btn_elimP.Click
        If vbYes = MsgBox("Desea eliminar " + jrd_partida.CurrentRow.Cells(0).Value.ToString + " Torneo: " + jrd_partida.CurrentRow.Cells(1).Value.ToString, vbYesNo) Then


            Dim sSQL As String = "DELETE FROM played WHERE ssn = '" + jrd_partida.CurrentRow.Cells(0).Value.ToString + "'"
            Dim cmd As New Odbc.OdbcCommand
            Try
                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                cmd.ExecuteNonQuery()
                jrd_partida.Rows().RemoveAt(jrd_partida.CurrentRow.Index)
            Catch
                MsgBox(Err.Description, MsgBoxStyle.Critical)
                Exit Sub
            End Try

            MsgBox("Registro eliminado")
        End If
    End Sub

    Private Sub jrd_partida_Click(sender As Object, e As EventArgs) Handles jrd_partida.Click
        txt_SSN.Text = jrd_partida.CurrentRow().Cells(0).Value
        txt_torneo.Text = jrd_partida.CurrentRow().Cells(1).Value
        txt_vic.Text = jrd_partida.CurrentRow().Cells(2).Value
        txt_der.Text = jrd_partida.CurrentRow().Cells(3).Value
        txt_emp.Text = jrd_partida.CurrentRow().Cells(4).Value
        txt_pos.Text = jrd_partida.CurrentRow().Cells(5).Value
        txt_elo.Text = jrd_partida.CurrentRow().Cells(6).Value
        txt_pgn.Text = jrd_partida.CurrentRow().Cells(7).Value
    End Sub

    Private Sub Btn_actP_Click(sender As Object, e As EventArgs) Handles Btn_actP.Click
        Dim sSQL As String
        sSQL = "UPDATE played "
        sSQL = sSQL + "SET "
        sSQL = sSQL + "vic = " + txt_vic.Text + ", "
        sSQL = sSQL + "der = " + txt_der.Text + ", "
        sSQL = sSQL + "emp = " + txt_emp.Text + ", "
        sSQL = sSQL + "pos = " + txt_pos.Text + ", "
        sSQL = sSQL + "diff_elo = '" + txt_elo.Text + "', "
        sSQL = sSQL + "ssn = '" + txt_SSN.Text + "', "
        sSQL = sSQL + "id_torneo = " + txt_torneo.Text + ","
        sSQL = sSQL + "pgn = '" + txt_pgn.Text + "' "
        sSQL = sSQL + "WHERE id_torneo = " + txt_torneo.Text

        Dim cmd As New Odbc.OdbcCommand
        cmd.CommandText = sSQL
        cmd.Connection = Main.gcn
        cmd.ExecuteNonQuery()
        MsgBox("Registro actualizado")

        jrd_partida.CurrentRow().Cells(0).Value = txt_SSN.Text
        jrd_partida.CurrentRow().Cells(1).Value = txt_torneo.Text
        jrd_partida.CurrentRow().Cells(2).Value = txt_vic.Text
        jrd_partida.CurrentRow().Cells(3).Value = txt_der.Text
        jrd_partida.CurrentRow().Cells(4).Value = txt_emp.Text
        jrd_partida.CurrentRow().Cells(5).Value = txt_pos.Text
        jrd_partida.CurrentRow().Cells(6).Value = txt_elo.Text
        jrd_partida.CurrentRow().Cells(7).Value = txt_pgn.Text
    End Sub

    Private Sub Btn_buscarP_Click(sender As Object, e As EventArgs) Handles Btn_buscarP.Click
        Dim sSQL As String
        sSQL = "select ssn,id_torneo,vic,der,emp,pos,diff_elo,pgn from played where "
        sSQL = sSQL + "ssn like '" + txt_SSN.Text + "%'"

        Dim cmd As New Odbc.OdbcCommand
        Dim dr As Odbc.OdbcDataReader
        cmd.CommandText = sSQL
        cmd.Connection = Main.gcn
        dr = cmd.ExecuteReader()
        jrd_partida.RowCount = 0
        While dr.Read()
            jrd_partida.Rows.Add()
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(0).Value = dr(0)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(1).Value = dr(1)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(2).Value = dr(2)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(3).Value = dr(3)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(4).Value = dr(4)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(5).Value = dr(5)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(6).Value = dr(6)
            jrd_partida.Rows(jrd_partida.RowCount - 1).Cells(7).Value = dr(7)
        End While

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim frm As New pgn
        tb = txt_pgn
        pgn.Show()

    End Sub
End Class