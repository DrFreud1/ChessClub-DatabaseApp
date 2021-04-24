Public Class frmTorneo
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdTorneo.CellContentClick
        txtID.Text = grdTorneo.CurrentRow.Cells(0).Value
        TxtNomb.Text = grdTorneo.CurrentRow.Cells(1).Value
        cboTipo.Text = grdTorneo.CurrentRow.Cells(2).Value
        dtpFR.Text = grdTorneo.CurrentRow.Cells(3).Value
        txtLugar.Text = grdTorneo.CurrentRow.Cells(4).Value
        cboCat.Text = grdTorneo.CurrentRow.Cells(5).Value
        numPrice.Text = grdTorneo.CurrentRow.Cells(6).Value
        txtTiempo.Text = grdTorneo.CurrentRow.Cells(7).Value
    End Sub

    Private Sub txtNomb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNomb.KeyPress
        If ((Strings.Asc(e.KeyChar) >= 0 And Strings.Asc(e.KeyChar) <= 7) Or (Strings.Asc(e.KeyChar) >= 9 And Strings.Asc(e.KeyChar) <= 31) Or (Strings.Asc(e.KeyChar) >= 33 And Strings.Asc(e.KeyChar) <= 64) Or (Strings.Asc(e.KeyChar) >= 91 And Strings.Asc(e.KeyChar) <= 96) Or (Strings.Asc(e.KeyChar) >= 124 And Strings.Asc(e.KeyChar) <= 127)) Then
            e.KeyChar = vbNullChar
            'Else
            '   e.Handled = True
        End If
    End Sub



    'Private Sub txtTipo_keyPress(sender As Object, e As KeyPressEventArgs)
    '    If ((Strings.Asc(e.KeyChar) >= 0 And Strings.Asc(e.KeyChar) <= 7) Or (Strings.Asc(e.KeyChar) >= 9 And Strings.Asc(e.KeyChar) <= 31) Or (Strings.Asc(e.KeyChar) >= 33 And Strings.Asc(e.KeyChar) <= 47) Or (Strings.Asc(e.KeyChar) >= 58 And Strings.Asc(e.KeyChar) <= 64) Or (Strings.Asc(e.KeyChar) >= 91 And Strings.Asc(e.KeyChar) <= 96) Or (Strings.Asc(e.KeyChar) >= 124 And Strings.Asc(e.KeyChar) <= 127)) Then
    '        e.KeyChar = vbNullChar
    '        'Else
    '        '   e.Handled = True
    '    End If
    'End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        Dim sSQL As String
        sSQL = "select id, nombre, tipo, fecha::varchar, lugar, categoria, precio, ctrltiempo from torneo"

        Dim cmd As New Odbc.OdbcCommand
        Dim dr As Odbc.OdbcDataReader
        cmd.CommandText = sSQL
        cmd.Connection = Main.gcn
        dr = cmd.ExecuteReader()
        grdTorneo.RowCount = 0
        While dr.Read()
            grdTorneo.Rows.Add()
            grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(0).Value = dr(0)   'ID
            grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(1).Value = dr(1)   'Nombre
            grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(2).Value = dr(2)   'Apellido
            grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(3).Value = dr(3)
            grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(4).Value = dr(4)
            grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(5).Value = dr(5)
            grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(6).Value = dr(6)
            grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(7).Value = dr(7)
        End While
    End Sub

    Private Sub btnParticipantes_Click(sender As Object, e As EventArgs) Handles btnParticipantes.Click
        Dim sSQL As String
        Try
            sSQL = "select nombre1,nombre2,apell1,apell2 from ("
            sSQL = sSQL + "(select ssn from played where id_torneo = "
            sSQL = sSQL + txtID.Text
            sSQL = sSQL + ") T INNER JOIN jugador on ssn::text = id::text)"

            Dim cmd As New Odbc.OdbcCommand
            Dim dr As Odbc.OdbcDataReader
            cmd.CommandText = sSQL
            cmd.Connection = Main.gcn
            dr = cmd.ExecuteReader()
            grdTorneo.RowCount = 0
            While dr.Read()
                grdTorneo.Rows.Add()
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(0).Value = dr(0)   'ID
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(1).Value = dr(1)   'Nombre
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(2).Value = dr(2)   'Apellido
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(3).Value = dr(3)
                'grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(4).Value = dr(4)
                'grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(5).Value = dr(5)
                'grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(6).Value = dr(6)
            End While
        Catch
            MsgBox(Err.Description, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Btn_agre_Click(sender As Object, e As EventArgs) Handles Btn_agre.Click
        If vbYes = MsgBox("Desea agregar el registro?", vbYesNo) Then
            Dim sSQL As String
            Dim cmd As New Odbc.OdbcCommand

            Try
                sSQL = "INSERT INTO torneo VALUES ("
                sSQL = sSQL + " default, "
                sSQL = sSQL + " '" + TxtNomb.Text + "', "
                sSQL = sSQL + " '" + cboTipo.Text + "', "
                sSQL = sSQL + " '" + dtpFR.Text + "', "
                sSQL = sSQL + " '" + txtLugar.Text + "', "
                sSQL = sSQL + " '" + cboCat.Text + "', "
                sSQL = sSQL + numPrice.Text + ","
                sSQL = sSQL + "'" + txtTiempo.Text + "')"

                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                cmd.ExecuteNonQuery()
            Catch
                MsgBox(Err.Description, MsgBoxStyle.Critical)
                Exit Sub
            End Try
            MsgBox("Registro agregado")
            txtID.Text = ""
            TxtNomb.Text = ""
            txtLugar.Text = ""
            numPrice.Text = vbEmpty
        End If
    End Sub

    Private Sub Btn_act_Click(sender As Object, e As EventArgs) Handles Btn_act.Click
        If vbYes = MsgBox("Desea actualizar el registro: " + txtID.Text + "?", vbYesNo) Then
            Dim sSQL As String
            Dim cmd As New Odbc.OdbcCommand

            Try
                sSQL = "update torneo set "
                sSQL = sSQL + "nombre = '" + TxtNomb.Text + "', "
                sSQL = sSQL + "tipo = '" + cboTipo.Text + "', "
                sSQL = sSQL + "fecha = '" + dtpFR.Text + "', "
                sSQL = sSQL + "lugar = '" + txtLugar.Text + "', "
                sSQL = sSQL + "categoria = '" + cboCat.Text + "', "
                sSQL = sSQL + "precio = " + numPrice.Text + ","
                sSQL = sSQL + "ctrltiempo = '" + txtTiempo.Text + "'"
                sSQL = sSQL + "where id = " + txtID.Text

                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                cmd.ExecuteNonQuery()
            Catch
                MsgBox(Err.Description, MsgBoxStyle.Critical)
                Exit Sub
            End Try
            MsgBox("Registro actualizado")
            txtID.Text = ""
            TxtNomb.Text = ""
            txtLugar.Text = ""
            txtTiempo.Text = ""
            numPrice.Text = vbEmpty
        End If
    End Sub

    Private Sub Btn_elim_Click(sender As Object, e As EventArgs) Handles Btn_elim.Click
        If vbYes = MsgBox("Desea eliminar el registro: " + txtID.Text + "?", vbYesNo) Then

            Dim sSQL As String
            Try
                sSQL = "DELETE from torneo where id = " + txtID.Text

                Dim cmd As New Odbc.OdbcCommand
                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                cmd.ExecuteNonQuery()

            Catch
                MsgBox(Err.Description, MsgBoxStyle.Critical)
                Exit Sub

            End Try
            MsgBox("Registro Eliminado")
            txtID.Text = ""
            TxtNomb.Text = ""
            txtLugar.Text = ""
            txtTiempo.Text = ""
            numPrice.Text = vbEmpty
        End If
    End Sub

    Private Sub frmTorneo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sSQL As String
        sSQL = "select id, nombre, tipo, fecha::varchar, lugar, categoria, precio, ctrltiempo from torneo"

        Dim cmd As New Odbc.OdbcCommand
        Dim dr As Odbc.OdbcDataReader
        cmd.CommandText = sSQL
        cmd.Connection = Main.gcn
        dr = cmd.ExecuteReader()
        grdTorneo.RowCount = 0
        While dr.Read()
            grdTorneo.Rows.Add()
            grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(0).Value = dr(0)   'ID
            grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(1).Value = dr(1)   'Nombre
            grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(2).Value = dr(2)   'Apellido
            grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(3).Value = dr(3)
            grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(4).Value = dr(4)
            grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(5).Value = dr(5)
            grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(6).Value = dr(6)
            grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(7).Value = dr(7)
        End While

        cboCat.Items.Add("N")
        cboCat.Items.Add("C")
        cboCat.Items.Add("A")
        cboTipo.Items.Add("Knockout Chess")
        cboTipo.Items.Add("Re-buy Knockout Chess")
        cboTipo.Items.Add("Round Robin Chess")
        cboTipo.Items.Add("Swiss Chess")
        cboTipo.Items.Add("Satellite Chess")
        cboTipo.Items.Add("Heads up")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If TxtNomb.Text <> "" Then
            Dim sSQL As String
            sSQL = "select id, nombre, tipo, fecha::varchar, lugar, categoria, precio,ctrltiempo from torneo where nombre like '%" + TxtNomb.Text + "%'"

            Dim cmd As New Odbc.OdbcCommand
            Dim dr As Odbc.OdbcDataReader
            cmd.CommandText = sSQL
            cmd.Connection = Main.gcn
            dr = cmd.ExecuteReader()
            grdTorneo.RowCount = 0
            While dr.Read()
                grdTorneo.Rows.Add()
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(0).Value = dr(0)   'ID
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(1).Value = dr(1)   'Nombre
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(2).Value = dr(2)   'Apellido
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(3).Value = dr(3)
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(4).Value = dr(4)
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(5).Value = dr(5)
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(6).Value = dr(6)
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(7).Value = dr(7)
            End While
        End If
        If txtLugar.Text <> "" Then
                Dim sSQL As String
                sSQL = "select id, nombre, tipo, fecha::varchar, lugar, categoria, precio,torneo from torneo where lugar like '%" + txtLugar.Text + "%'"

                Dim cmd As New Odbc.OdbcCommand
                Dim dr As Odbc.OdbcDataReader
                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                dr = cmd.ExecuteReader()
                grdTorneo.RowCount = 0
                While dr.Read()
                    grdTorneo.Rows.Add()
                    grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(0).Value = dr(0)   'ID
                    grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(1).Value = dr(1)   'Nombre
                    grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(2).Value = dr(2)   'Apellido
                    grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(3).Value = dr(3)
                    grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(4).Value = dr(4)
                    grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(5).Value = dr(5)
                    grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(6).Value = dr(6)
                    grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(7).Value = dr(7)
                End While

            End If

            If cboCat.Text = "N" Then
            Dim sSQL As String
            sSQL = "select id, nombre, tipo, fecha::varchar, lugar, categoria, precio,torneo from torneo where categoria ='N'"

            Dim cmd As New Odbc.OdbcCommand
            Dim dr As Odbc.OdbcDataReader
            cmd.CommandText = sSQL
            cmd.Connection = Main.gcn
            dr = cmd.ExecuteReader()
            grdTorneo.RowCount = 0
            While dr.Read()
                grdTorneo.Rows.Add()
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(0).Value = dr(0)   'ID
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(1).Value = dr(1)   'Nombre
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(2).Value = dr(2)   'Apellido
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(3).Value = dr(3)
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(4).Value = dr(4)
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(5).Value = dr(5)
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(6).Value = dr(6)
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(7).Value = dr(7)
            End While

        ElseIf cboCat.Text = "A" Then
            Dim sSQL As String
            sSQL = "select id, nombre, tipo, fecha::varchar, lugar, categoria, precio,torneo from torneo where categoria ='A'"

            Dim cmd As New Odbc.OdbcCommand
            Dim dr As Odbc.OdbcDataReader
            cmd.CommandText = sSQL
            cmd.Connection = Main.gcn
            dr = cmd.ExecuteReader()
            grdTorneo.RowCount = 0
            While dr.Read()
                grdTorneo.Rows.Add()
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(0).Value = dr(0)   'ID
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(1).Value = dr(1)   'Nombre
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(2).Value = dr(2)   'Apellido
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(3).Value = dr(3)
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(4).Value = dr(4)
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(5).Value = dr(5)
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(6).Value = dr(6)
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(7).Value = dr(7)
            End While
        ElseIf cboCat.Text = "C" Then
            Dim sSQL As String
            sSQL = "select id, nombre, tipo, fecha::varchar, lugar, categoria, precio,torneo from torneo where categoria ='C'"

            Dim cmd As New Odbc.OdbcCommand
            Dim dr As Odbc.OdbcDataReader
            cmd.CommandText = sSQL
            cmd.Connection = Main.gcn
            dr = cmd.ExecuteReader()
            grdTorneo.RowCount = 0
            While dr.Read()
                grdTorneo.Rows.Add()
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(0).Value = dr(0)   'ID
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(1).Value = dr(1)   'Nombre
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(2).Value = dr(2)   'Apellido
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(3).Value = dr(3)
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(4).Value = dr(4)
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(5).Value = dr(5)
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(6).Value = dr(6)
                grdTorneo.Rows(grdTorneo.RowCount - 1).Cells(7).Value = dr(7)
            End While
        End If
    End Sub

    Private Sub txtTiempo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTiempo.KeyPress
        If ((Strings.Asc(e.KeyChar) >= 0 And Strings.Asc(e.KeyChar) <= 7) Or (Strings.Asc(e.KeyChar) = 45) Or (Strings.Asc(e.KeyChar) = 47) Or (Strings.Asc(e.KeyChar) >= 58 And Strings.Asc(e.KeyChar) <= 255)) Then
            e.KeyChar = vbNullChar
            'Else
            '   e.Handled = True
        End If
    End Sub


End Class