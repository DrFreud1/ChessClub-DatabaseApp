Public Class frm_jug
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        j_s.Items.Add("M")
        j_s.Items.Add("F")
        j_m.Items.Add("True")
        j_m.Items.Add("False")
        j_t.Items.Add("GM")
        j_t.Items.Add("IM")
        j_t.Items.Add("FM")
        j_t.Items.Add("CM")
        j_t.Items.Add("NULL")
        j_t.Items.Add("WGM")
        j_t.Items.Add("WIM")
        j_t.Items.Add("WFM")
        j_t.Items.Add("WCM")
        j_t.Items.Add("NULL")
        llenarComboBox(j_o)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim sSQL As String
        Dim cmd As New Odbc.OdbcCommand
        Try
            sSQL = "INSERT INTO jugador VALUES ("
            sSQL = sSQL + " '" + j_ssn.Text + " ',"
            sSQL = sSQL + " '" + j_n1.Text + "', "
            sSQL = sSQL + " '" + j_n2.Text + "', "
            sSQL = sSQL + " '" + j_a1.Text + "', "
            sSQL = sSQL + " '" + j_a2.Text + "', "
            sSQL = sSQL + " '" + j_s.Text + "', "
            sSQL = sSQL + " '" + j_bd.Text + "', "
            sSQL = sSQL + j_e.Text + ","
            sSQL = sSQL + j_m.Text + ","
            sSQL = sSQL + " '" + j_o.Text + "', "
            sSQL = sSQL + " '" + j_t.Text + "' "
            sSQL = sSQL + ")"

            cmd.CommandText = sSQL
            cmd.Connection = Main.gcn
            cmd.ExecuteNonQuery()
        Catch
            MsgBox("Class Form1 --> Funcion btnAgregar_Click:" + Err.Description, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        MsgBox("Se añadió un jugador")
    End Sub


    Private Sub j_mos_jug_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles j_grd.CellContentClick

    End Sub



    Private Sub j_bor_jug_Click(sender As Object, e As EventArgs)
        If vbYes = MsgBox("Desea eliminar " + j_grd.CurrentRow.Cells(1).Value.ToString + " " + j_grd.CurrentRow.Cells(3).Value.ToString, vbYesNo) Then


            Dim sSQL As String = "DELETE FROM jugador WHERE id = '" + j_grd.CurrentRow.Cells(0).Value.ToString + "'"
            Dim cmd As New Odbc.OdbcCommand
            Try
                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                cmd.ExecuteNonQuery()
                j_grd.Rows().RemoveAt(j_grd.CurrentRow.Index)
            Catch
                MsgBox(Err.Description, MsgBoxStyle.Critical)
                Exit Sub
            End Try

            MsgBox("Registro eliminado")
        End If

    End Sub
    Private Sub j_grd_Click(sender As Object, e As EventArgs) Handles j_grd.Click
        Try
            j_ssn.Text = j_grd.CurrentRow.Cells(0).Value
            j_n1.Text = j_grd.CurrentRow.Cells(1).Value
            j_n2.Text = j_grd.CurrentRow.Cells(2).Value
            j_a1.Text = j_grd.CurrentRow.Cells(3).Value
            j_a2.Text = j_grd.CurrentRow.Cells(4).Value
            j_s.Text = j_grd.CurrentRow.Cells(5).Value
            j_bd.Text = j_grd.CurrentRow.Cells(6).Value
            j_e.Text = j_grd.CurrentRow.Cells(7).Value
            j_m.Text = j_grd.CurrentRow.Cells(8).Value
            j_o.Text = j_grd.CurrentRow.Cells(9).Value
            j_t.Text = j_grd.CurrentRow.Cells(10).Value
        Catch
        End Try
    End Sub
    Private Sub j_act_jug_Click(sender As Object, e As EventArgs)

        Dim sSQL As String
        sSQL = "UPDATE jugador "
        sSQL = sSQL + "SET "
        sSQL = sSQL + "id = '" + j_ssn.Text + "', "
        sSQL = sSQL + "nombre1 = '" + j_n1.Text + "', "
        sSQL = sSQL + "nombre2 = '" + j_n2.Text + "', "
        sSQL = sSQL + "apell1 = '" + j_a1.Text + "', "
        sSQL = sSQL + "apell2 = '" + j_a2.Text + "', "
        sSQL = sSQL + "sexo = '" + j_s.Text + "', "
        sSQL = sSQL + "f_nac = '" + j_bd.Text + "',"
        sSQL = sSQL + "elo = " + j_e.Text + ", "
        sSQL = sSQL + "miembro = " + j_m.Text + ", "
        sSQL = sSQL + "origen = '" + j_o.Text + "', "
        sSQL = sSQL + "titulo = '" + j_t.Text + "' "
        sSQL = sSQL + "WHERE id = '" + j_ssn.Text + "' "

        Dim cmd As New Odbc.OdbcCommand
        cmd.CommandText = sSQL
        cmd.Connection = Main.gcn
        cmd.ExecuteNonQuery()
        MsgBox("Registro actualizado")

        j_grd.CurrentRow().Cells(0).Value = j_ssn.Text
        j_grd.CurrentRow().Cells(1).Value = j_n1.Text
        j_grd.CurrentRow().Cells(2).Value = j_n2.Text
        j_grd.CurrentRow().Cells(3).Value = j_a1.Text
        j_grd.CurrentRow().Cells(4).Value = j_a2.Text
        j_grd.CurrentRow().Cells(5).Value = j_s.Text
        j_grd.CurrentRow().Cells(6).Value = j_bd.Text
        j_grd.CurrentRow().Cells(7).Value = j_e.Text
        j_grd.CurrentRow().Cells(8).Value = j_m.Text
        j_grd.CurrentRow().Cells(9).Value = j_o.Text
        j_grd.CurrentRow().Cells(10).Value = j_t.Text

    End Sub


    Private Sub j_n1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles j_n1.KeyPress
        If ((Strings.Asc(e.KeyChar) >= 0 And Strings.Asc(e.KeyChar) <= 7) Or (Strings.Asc(e.KeyChar) >= 9 And Strings.Asc(e.KeyChar) <= 32) Or (Strings.Asc(e.KeyChar) >= 33 And Strings.Asc(e.KeyChar) <= 64) Or (Strings.Asc(e.KeyChar) >= 91 And Strings.Asc(e.KeyChar) <= 96) Or (Strings.Asc(e.KeyChar) >= 124 And Strings.Asc(e.KeyChar) <= 127)) Then
            e.KeyChar = vbNullChar

        End If
    End Sub
    Private Sub j_n2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles j_n2.KeyPress
        If ((Strings.Asc(e.KeyChar) >= 0 And Strings.Asc(e.KeyChar) <= 7) Or (Strings.Asc(e.KeyChar) >= 9 And Strings.Asc(e.KeyChar) <= 32) Or (Strings.Asc(e.KeyChar) >= 33 And Strings.Asc(e.KeyChar) <= 64) Or (Strings.Asc(e.KeyChar) >= 91 And Strings.Asc(e.KeyChar) <= 96) Or (Strings.Asc(e.KeyChar) >= 124 And Strings.Asc(e.KeyChar) <= 127)) Then
            e.KeyChar = vbNullChar

        End If
    End Sub
    Private Sub j_a1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles j_a1.KeyPress
        If ((Strings.Asc(e.KeyChar) >= 0 And Strings.Asc(e.KeyChar) <= 7) Or (Strings.Asc(e.KeyChar) >= 9 And Strings.Asc(e.KeyChar) <= 32) Or (Strings.Asc(e.KeyChar) >= 33 And Strings.Asc(e.KeyChar) <= 64) Or (Strings.Asc(e.KeyChar) >= 91 And Strings.Asc(e.KeyChar) <= 96) Or (Strings.Asc(e.KeyChar) >= 124 And Strings.Asc(e.KeyChar) <= 127)) Then
            e.KeyChar = vbNullChar

        End If
    End Sub
    Private Sub j_a2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles j_a2.KeyPress
        If ((Strings.Asc(e.KeyChar) >= 0 And Strings.Asc(e.KeyChar) <= 7) Or (Strings.Asc(e.KeyChar) >= 9 And Strings.Asc(e.KeyChar) <= 32) Or (Strings.Asc(e.KeyChar) >= 33 And Strings.Asc(e.KeyChar) <= 64) Or (Strings.Asc(e.KeyChar) >= 91 And Strings.Asc(e.KeyChar) <= 96) Or (Strings.Asc(e.KeyChar) >= 124 And Strings.Asc(e.KeyChar) <= 127)) Then
            e.KeyChar = vbNullChar
            'Else
            '   e.Handled = True
        End If
    End Sub

    Private Sub j_ssn_keyPress(sender As Object, e As KeyPressEventArgs) Handles j_ssn.KeyPress
        If ((Strings.Asc(e.KeyChar) >= 0 And Strings.Asc(e.KeyChar) <= 7) Or (Strings.Asc(e.KeyChar) >= 9 And Strings.Asc(e.KeyChar) <= 32) Or (Strings.Asc(e.KeyChar) >= 33 And Strings.Asc(e.KeyChar) <= 47) Or (Strings.Asc(e.KeyChar) >= 58 And Strings.Asc(e.KeyChar) <= 64) Or (Strings.Asc(e.KeyChar) >= 91 And Strings.Asc(e.KeyChar) <= 96) Or (Strings.Asc(e.KeyChar) >= 124 And Strings.Asc(e.KeyChar) <= 127)) Then
            e.KeyChar = vbNullChar

        End If
    End Sub
    Private Sub j_e_keyPress(sender As Object, e As KeyPressEventArgs) Handles j_e.KeyPress
        If ((Strings.Asc(e.KeyChar) >= 9 And Strings.Asc(e.KeyChar) <= 32)) Then
            e.KeyChar = vbNullChar

        End If
    End Sub
    'Private Sub j_e_keyPress(sender As Object, e As KeyPressEventArgs) Handles j_e.KeyPress
    '    If ((Strings.Asc(e.KeyChar) >= 9 And Strings.Asc(e.KeyChar) <= 31) Or (Strings.Asc(e.KeyChar) >= 33 And Strings.Asc(e.KeyChar) <= 47) Or (Strings.Asc(e.KeyChar) >= 58) Or (Strings.Asc(e.KeyChar) = 43) Or (Asc(e.KeyChar) = 45)) Then
    '        e.KeyChar = vbNullChar
    '        'Else
    '        '   e.Handled = True
    '    End If
    'End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Btn_A_Agregar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btn_buscar_Click(sender As Object, e As EventArgs) Handles Btn_buscar.Click
        Try
            If (j_ssn.Text = "" And j_n1.Text = "" And j_n2.Text = "" And j_a1.Text = "" And j_e.Text = "") Then
                Dim sSQL As String
                sSQL = "select * from jugador"
                Dim cmd As New Odbc.OdbcCommand
                Dim dr As Odbc.OdbcDataReader
                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                dr = cmd.ExecuteReader()
                j_grd.RowCount = 0
                While dr.Read()
                    j_grd.Rows.Add()
                    j_grd.Rows(j_grd.RowCount - 1).Cells(0).Value = dr(0)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(1).Value = dr(1)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(2).Value = dr(2)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(3).Value = dr(3)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(4).Value = dr(4)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(5).Value = dr(5)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(6).Value = dr(6)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(7).Value = dr(7)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(8).Value = dr(8)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(9).Value = dr(9)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(10).Value = dr(10)
                End While
            ElseIf (j_ssn.Text <> "" And j_n1.Text = "" And j_n2.Text = "" And j_a1.Text = "" And j_e.Text = "") Then
                Dim sSQL As String
                sSQL = "select * from jugador  where "
                sSQL = sSQL + "id like '" + j_ssn.Text + "%'" ' or nombre1 like '"

                Dim cmd As New Odbc.OdbcCommand
                Dim dr As Odbc.OdbcDataReader
                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                dr = cmd.ExecuteReader()
                j_grd.RowCount = 0
                While dr.Read()
                    j_grd.Rows.Add()
                    j_grd.Rows(j_grd.RowCount - 1).Cells(0).Value = dr(0)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(1).Value = dr(1)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(2).Value = dr(2)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(3).Value = dr(3)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(4).Value = dr(4)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(5).Value = dr(5)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(6).Value = dr(6)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(7).Value = dr(7)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(8).Value = dr(8)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(9).Value = dr(9)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(10).Value = dr(10)
                End While

            ElseIf (j_ssn.Text = "" And j_n1.Text <> "" And j_n2.Text = "" And j_a1.Text <> "" And j_e.Text = "") Then
                Dim sSQL As String
                sSQL = "select * from jugador  where "
                sSQL = sSQL + "nombre1 like '" + j_n1.Text + "%'  and apell1 like '" + j_a1.Text + "%'"
                Dim cmd As New Odbc.OdbcCommand
                Dim dr As Odbc.OdbcDataReader
                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                dr = cmd.ExecuteReader()
                j_grd.RowCount = 0
                While dr.Read()
                    j_grd.Rows.Add()
                    j_grd.Rows(j_grd.RowCount - 1).Cells(0).Value = dr(0)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(1).Value = dr(1)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(2).Value = dr(2)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(3).Value = dr(3)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(4).Value = dr(4)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(5).Value = dr(5)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(6).Value = dr(6)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(7).Value = dr(7)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(8).Value = dr(8)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(9).Value = dr(9)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(10).Value = dr(10)
                End While
            ElseIf (j_ssn.Text = "" And j_n1.Text <> "" And j_n2.Text = "" And j_a1.Text <> "" And j_e.Text = "") Then

                Dim sSQL As String
                sSQL = "select * from jugador  where "
                sSQL = sSQL + "nombre1 like '" + j_n1.Text + "%'  and apell1 like '" + j_a1.Text + "%'"
                Dim cmd As New Odbc.OdbcCommand
                Dim dr As Odbc.OdbcDataReader
                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                dr = cmd.ExecuteReader()
                j_grd.RowCount = 0
                While dr.Read()
                    j_grd.Rows.Add()
                    j_grd.Rows(j_grd.RowCount - 1).Cells(0).Value = dr(0)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(1).Value = dr(1)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(2).Value = dr(2)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(3).Value = dr(3)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(4).Value = dr(4)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(5).Value = dr(5)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(6).Value = dr(6)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(7).Value = dr(7)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(8).Value = dr(8)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(9).Value = dr(9)
                    j_grd.Rows(j_grd.RowCount - 1).Cells(10).Value = dr(10)
                End While
            ElseIf (j_ssn.Text = "" And j_n1.Text = "" And j_n2.Text = "" And j_a1.Text = "" And j_e.Text <> "") Then

                Dim lt As Char = j_e.Text.Last
                If "+" = lt Then
                    j_e.Text = j_e.Text.Substring(0, j_e.Text.Length - 1)
                    Dim sSQL As String
                    sSQL = "select * from jugador  where "
                    sSQL = sSQL + "elo >=" + j_e.Text + " and miembro ='" + j_m.Text + "'"
                    Dim cmd As New Odbc.OdbcCommand
                    Dim dr As Odbc.OdbcDataReader
                    cmd.CommandText = sSQL
                    cmd.Connection = Main.gcn
                    dr = cmd.ExecuteReader()
                    j_grd.RowCount = 0
                    While dr.Read()
                        j_grd.Rows.Add()
                        j_grd.Rows(j_grd.RowCount - 1).Cells(0).Value = dr(0)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(1).Value = dr(1)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(2).Value = dr(2)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(3).Value = dr(3)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(4).Value = dr(4)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(5).Value = dr(5)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(6).Value = dr(6)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(7).Value = dr(7)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(8).Value = dr(8)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(9).Value = dr(9)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(10).Value = dr(10)
                    End While
                ElseIf "-" = lt Then
                    j_e.Text = j_e.Text.Substring(0, j_e.Text.Length - 1)
                    Dim sSQL As String
                    sSQL = "select * from jugador  where "
                    sSQL = sSQL + "elo <=" + j_e.Text + " and miembro ='" + j_m.Text + "'"
                    Dim cmd As New Odbc.OdbcCommand
                    Dim dr As Odbc.OdbcDataReader
                    cmd.CommandText = sSQL
                    cmd.Connection = Main.gcn
                    dr = cmd.ExecuteReader()
                    j_grd.RowCount = 0
                    While dr.Read()
                        j_grd.Rows.Add()
                        j_grd.Rows(j_grd.RowCount - 1).Cells(0).Value = dr(0)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(1).Value = dr(1)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(2).Value = dr(2)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(3).Value = dr(3)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(4).Value = dr(4)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(5).Value = dr(5)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(6).Value = dr(6)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(7).Value = dr(7)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(8).Value = dr(8)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(9).Value = dr(9)
                        j_grd.Rows(j_grd.RowCount - 1).Cells(10).Value = dr(10)
                    End While
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub Btn_agre_Click(sender As Object, e As EventArgs) Handles Btn_agre.Click
        If j_s.Text = "M" And (j_t.Text = "WCM" Or j_t.Text = "WGM" Or j_t.Text = "WFM" Or j_t.Text = "WIM") Then
            MsgBox("Titulo no pertenece al M")

        Else

            Dim sSQL As String
            Dim cmd As New Odbc.OdbcCommand
            Try
                sSQL = "INSERT INTO jugador VALUES ("
                sSQL = sSQL + " '" + j_ssn.Text + " ',"
                sSQL = sSQL + " '" + j_n1.Text + "', "
                sSQL = sSQL + " '" + j_n2.Text + "', "
                sSQL = sSQL + " '" + j_a1.Text + "', "
                sSQL = sSQL + " '" + j_a2.Text + "', "
                sSQL = sSQL + " '" + j_s.Text + "', "
                sSQL = sSQL + " '" + j_bd.Text + "', "
                sSQL = sSQL + j_e.Text + ","
                sSQL = sSQL + j_m.Text + ","
                sSQL = sSQL + " '" + j_o.Text + "', "
                sSQL = sSQL + " '" + j_t.Text + "' "
                sSQL = sSQL + ")"

                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                cmd.ExecuteNonQuery()
            Catch
                MsgBox("Error -->Agregar_Click:" + Err.Description, MsgBoxStyle.Critical)
                Exit Sub
            End Try
            MsgBox("Se añadió un jugador")
            j_ssn.Text = ""
            j_n1.Text = ""
            j_n2.Text = ""
            j_a1.Text = ""
            j_a2.Text = ""
            j_s.Text = ""
            j_bd.Text = ""
            j_e.Text = ""
            j_m.Text = ""
            j_o.Text = ""
            j_t.Text = ""
        End If
    End Sub

    Private Sub Btn_act_Click(sender As Object, e As EventArgs) Handles Btn_act.Click
        Try

            Dim sSQL As String
            sSQL = "UPDATE jugador "
            sSQL = sSQL + "SET "
            sSQL = sSQL + "nombre1 = '" + j_n1.Text + "', "
            sSQL = sSQL + "nombre2 = '" + j_n2.Text + "', "
            sSQL = sSQL + "apell1 = '" + j_a1.Text + "', "
            sSQL = sSQL + "apell2 = '" + j_a2.Text + "', "
            sSQL = sSQL + "sexo = '" + j_s.Text + "', "
            sSQL = sSQL + "f_nac = '" + j_bd.Text + "',"
            sSQL = sSQL + "elo = " + j_e.Text + ", "
            sSQL = sSQL + "miembro = " + j_m.Text + ", "
            sSQL = sSQL + "origen = '" + j_o.Text + "', "
            sSQL = sSQL + "titulo = '" + j_t.Text + "' "
            sSQL = sSQL + "WHERE id = '" + j_ssn.Text + "' "

            Dim cmd As New Odbc.OdbcCommand
            cmd.CommandText = sSQL
            cmd.Connection = Main.gcn
            cmd.ExecuteNonQuery()
        Catch
            MsgBox("Error --> Actualizar_Click:" + Err.Description, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        MsgBox("Registro actualizado")

        '            j_grd.CurrentRow().Cells(0).Value = j_ssn.Text
        j_grd.CurrentRow().Cells(1).Value = j_n1.Text
        j_grd.CurrentRow().Cells(2).Value = j_n2.Text
        j_grd.CurrentRow().Cells(3).Value = j_a1.Text
        j_grd.CurrentRow().Cells(4).Value = j_a2.Text
        j_grd.CurrentRow().Cells(5).Value = j_s.Text
        j_grd.CurrentRow().Cells(6).Value = j_bd.Text
        j_grd.CurrentRow().Cells(7).Value = j_e.Text
        j_grd.CurrentRow().Cells(8).Value = j_m.Text
        j_grd.CurrentRow().Cells(9).Value = j_o.Text
        j_grd.CurrentRow().Cells(10).Value = j_t.Text

    End Sub

    Private Sub Btn_elim_Click(sender As Object, e As EventArgs) Handles Btn_elim.Click
        Try
            If vbYes = MsgBox("Desea eliminar " + j_grd.CurrentRow.Cells(1).Value.ToString + " " + j_grd.CurrentRow.Cells(3).Value.ToString, vbYesNo) Then


                Dim sSQL As String = "DELETE FROM jugador WHERE id = '" + j_grd.CurrentRow.Cells(0).Value.ToString + "'"
                Dim cmd As New Odbc.OdbcCommand

                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                cmd.ExecuteNonQuery()
                j_grd.Rows().RemoveAt(j_grd.CurrentRow.Index)
                MsgBox("Registro eliminado")
            End If

        Catch
            MsgBox(Err.Description, MsgBoxStyle.Critical)
            Exit Sub


        End Try

    End Sub

End Class