Public Class frmDirectiva
    Private Sub frmDirectiva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCargo.Items.Add("Presidente")
        cboCargo.Items.Add("Viceresidente")
        cboCargo.Items.Add("Tesorero")
        cboCargo.Items.Add("Secreatrio")
        cboCargo.Items.Add("Consejero")
        cboCargo.Items.Add("Vocal")
        cboPeriodo.Items.Add(1)
        cboPeriodo.Items.Add(2)
        cboAnio.Items.Add(2014)
        cboAnio.Items.Add(2015)
        cboAnio.Items.Add(2016)
        cboAnio.Items.Add(2017)
        cboAnio.Items.Add(2018)
        cboAnio.Items.Add(2019)
        cboAnio.Items.Add("Todo")
        CargaComboMiembros()

    End Sub

    Private Sub CargaComboMiembros()
        Dim cmd As New Odbc.OdbcCommand
        Dim dr As Odbc.OdbcDataReader
        cmd.CommandText = "select id from jugador where miembro = True"
        cmd.Connection = Main.gcn
        dr = cmd.ExecuteReader() 'This is used for SELECT
        While dr.Read()
            cboJugadorID.Items.Add(dr(0))
        End While
    End Sub

    Private Sub btnShowDirect_Click(sender As Object, e As EventArgs) Handles btnShowDirect.Click
        Try
            If cboAnio.Text = "Todo" Or cboAnio.Text = "" Then
                Dim sSQL As String
                sSQL = "select id_jug,nombre1,apell1,cargo,dyear,periodo from(
                    (select id_jug,dyear,periodo,cargo from directiva) T Inner Join jugador on id_jug = id::bigint)"

                Dim cmd As New Odbc.OdbcCommand
                Dim dr As Odbc.OdbcDataReader
                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                dr = cmd.ExecuteReader()
                grdDirectiva.RowCount = 0
                While dr.Read()
                    grdDirectiva.Rows.Add()
                    grdDirectiva.Rows(grdDirectiva.RowCount - 1).Cells(0).Value = dr(0)   'ID
                    grdDirectiva.Rows(grdDirectiva.RowCount - 1).Cells(1).Value = dr(1)   'Nombre
                    grdDirectiva.Rows(grdDirectiva.RowCount - 1).Cells(2).Value = dr(2)   'Apellido
                    grdDirectiva.Rows(grdDirectiva.RowCount - 1).Cells(3).Value = dr(3)
                    grdDirectiva.Rows(grdDirectiva.RowCount - 1).Cells(4).Value = dr(4)
                    grdDirectiva.Rows(grdDirectiva.RowCount - 1).Cells(5).Value = dr(5)
                End While

            Else
                Dim sSQL As String
                sSQL = "select id_jug,nombre1,apell1,cargo,dyear,periodo from(
                    (select id_jug,dyear,periodo,cargo from directiva) T Inner Join jugador on id_jug = id::bigint)
                    where dyear = " + cboAnio.Text + "and periodo = " + cboPeriodo.Text
                Dim cmd As New Odbc.OdbcCommand
                Dim dr As Odbc.OdbcDataReader
                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                dr = cmd.ExecuteReader()
                grdDirectiva.RowCount = 0
                While dr.Read()
                    grdDirectiva.Rows.Add()
                    grdDirectiva.Rows(grdDirectiva.RowCount - 1).Cells(0).Value = dr(0)   'ID
                    grdDirectiva.Rows(grdDirectiva.RowCount - 1).Cells(1).Value = dr(1)   'Nombre
                    grdDirectiva.Rows(grdDirectiva.RowCount - 1).Cells(2).Value = dr(2)   'Apellido
                    grdDirectiva.Rows(grdDirectiva.RowCount - 1).Cells(3).Value = dr(3)
                    grdDirectiva.Rows(grdDirectiva.RowCount - 1).Cells(4).Value = dr(4)
                    grdDirectiva.Rows(grdDirectiva.RowCount - 1).Cells(5).Value = dr(5)
                End While
            End If
        Catch
            MsgBox(Err.Description, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtID_keyPress(sender As Object, e As KeyPressEventArgs)
        If ((Strings.Asc(e.KeyChar) >= 0 And Strings.Asc(e.KeyChar) <= 7) Or (Strings.Asc(e.KeyChar) >= 9 And Strings.Asc(e.KeyChar) <= 31) Or (Strings.Asc(e.KeyChar) >= 33 And Strings.Asc(e.KeyChar) <= 47) Or (Strings.Asc(e.KeyChar) >= 58 And Strings.Asc(e.KeyChar) <= 64) Or (Strings.Asc(e.KeyChar) >= 91 And Strings.Asc(e.KeyChar) <= 96) Or (Strings.Asc(e.KeyChar) >= 124 And Strings.Asc(e.KeyChar) <= 127)) Then
            e.KeyChar = vbNullChar
            'Else
            '   e.Handled = True
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If vbYes = MsgBox("Desea agregar el registro?", vbYesNo) Then
            Dim sSQL As String
            Dim cmd As New Odbc.OdbcCommand

            Try
                sSQL = "INSERT INTO directiva VALUES ("
                sSQL = sSQL + cboPeriodo.Text
                sSQL = sSQL + " ,'" + cboCargo.Text + "', "
                sSQL = sSQL + cboAnio.Text + ", "
                sSQL = sSQL + cboJugadorID.Text + ") "
                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                cmd.ExecuteNonQuery()
            Catch
                MsgBox(Err.Description, MsgBoxStyle.Critical)
                Exit Sub
            End Try
            MsgBox("Registro agregado")
            cboJugadorID.Text = ""

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If vbYes = MsgBox("Desea eliminar el registro: " + txtID.Text + "?", vbYesNo) Then

            Dim sSQL As String
            Try
                sSQL = "DELETE from directiva where id_jug = " + txtID.Text + "and dyear =" + txtAnio.Text + "and periodo = " + txtPeriodo.Text

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
        End If
    End Sub



    Private Sub grdDirectiva_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdDirectiva.CellContentClick
        txtID.Text = grdDirectiva.CurrentRow.Cells(0).Value
        cboCargo.Text = grdDirectiva.CurrentRow.Cells(1).Value
        txtAnio.Text = grdDirectiva.CurrentRow.Cells(4).Value
        txtPeriodo.Text = grdDirectiva.CurrentRow.Cells(5).Value

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 

    End Sub
End Class