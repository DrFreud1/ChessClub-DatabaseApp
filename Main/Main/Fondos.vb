Public Class Fondos
    Private Sub Btn_F_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_F_Agregar.Click
        Dim sSQL As String
        Dim cmd As New Odbc.OdbcCommand
        Try
            sSQL = "INSERT INTO Fondos VALUES ("
            sSQL = sSQL + " '" + Date_Fondos.Text + "', "
            sSQL = sSQL + Txt_F_Valor.Text + ", "
            sSQL = sSQL + " '" + Txt_F_Descripcion.Text + "', "
            sSQL = sSQL + " '" + Cbo_Descripcion.Text + "', "
            sSQL = sSQL + Txt_F_idtorneo.Text + " "
            sSQL = sSQL + ")"

            cmd.CommandText = sSQL
            cmd.Connection = Main.gcn
            cmd.ExecuteNonQuery()
        Catch
            MsgBox("Error --> Funcion btnAgregar_Click:" + Err.Description, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        MsgBox("Se añadió fondo")

        Dim sSQLf As String
        sSQLf = "SELECT fec, money, descripcion, i_e, id_torneo FROM Fondos"
        Dim cmdf As New Odbc.OdbcCommand
        Dim drf As Odbc.OdbcDataReader
        cmdf.CommandText = sSQLf
        cmdf.Connection = Main.gcn
        drf = cmdf.ExecuteReader()
        F_grd.RowCount = 0

        While drf.Read()
            F_grd.Rows.Add()
            F_grd.Rows(F_grd.RowCount - 1).Cells(0).Value = drf(0)
            F_grd.Rows(F_grd.RowCount - 1).Cells(1).Value = drf(1)
            F_grd.Rows(F_grd.RowCount - 1).Cells(2).Value = drf(2)
            F_grd.Rows(F_grd.RowCount - 1).Cells(3).Value = drf(3)
            F_grd.Rows(F_grd.RowCount - 1).Cells(4).Value = drf(4)
        End While

        Txt_F_Valor.Text = " "
        Txt_F_Descripcion.Text = " "
        Txt_F_idtorneo.Text = " "
    End Sub

    Private Sub F_grd_Click(sender As Object, e As EventArgs) Handles F_grd.Click
        Date_Fondos.Text = F_grd.CurrentRow.Cells(0).Value
        Txt_F_Valor.Text = F_grd.CurrentRow.Cells(1).Value
        Txt_F_Descripcion.Text = F_grd.CurrentRow.Cells(2).Value
        Cbo_Descripcion.Text = F_grd.CurrentRow.Cells(3).Value
        Txt_F_idtorneo.Text = F_grd.CurrentRow.Cells(4).Value

    End Sub

    Private Sub Btn_F_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_F_Eliminar.Click
        If vbYes = MsgBox("Desea eliminar ", vbYesNo) Then

            Dim sSQL As String = "DELETE FROM Fondos WHERE id_torneo= '" + F_grd.CurrentRow.Cells(4).Value.ToString + "'"
            Dim cmd As New Odbc.OdbcCommand
            Try
                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                cmd.ExecuteNonQuery()
                F_grd.Rows().RemoveAt(F_grd.CurrentRow.Index)
            Catch
                MsgBox(Err.Description, MsgBoxStyle.Critical)
                Exit Sub
            End Try

            MsgBox("Registro eliminado")
            Txt_F_Valor.Text = " "
            Txt_F_Descripcion.Text = " "
            Cbo_Descripcion.Text = " "
            Txt_F_idtorneo.Text = " "

        End If

    End Sub

    Private Sub Btn_F_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_F_Actualizar.Click
        Dim sSQL As String
        Try
            sSQL = "UPDATE Fondos "
            sSQL = sSQL + "SET "
            sSQL = sSQL + "fec = '" + Date_Fondos.Text + "', "
            sSQL = sSQL + "money = " + Txt_F_Valor.Text + ", "
            sSQL = sSQL + "descripcion = '" + Txt_F_Descripcion.Text + "', "
            sSQL = sSQL + "i_e = '" + Cbo_Descripcion.Text + "' "
            sSQL = sSQL + "WHERE id_torneo = " + Txt_F_idtorneo.Text

            Dim cmd As New Odbc.OdbcCommand
            cmd.CommandText = sSQL
            cmd.Connection = Main.gcn
            cmd.ExecuteNonQuery()
        Catch
            MsgBox("Error --> Funcion btnAgregar_Click:" + Err.Description, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        MsgBox("Registro actualizado")

        F_grd.CurrentRow().Cells(0).Value = Date_Fondos.Text
        F_grd.CurrentRow().Cells(1).Value = Txt_F_Valor.Text
        F_grd.CurrentRow().Cells(2).Value = Txt_F_Descripcion.Text
        F_grd.CurrentRow().Cells(3).Value = Cbo_Descripcion.Text

        Txt_F_Valor.Text = " "
        Txt_F_Descripcion.Text = " "
        Txt_F_idtorneo.Text = " "

    End Sub

    Private Sub Btn_F_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_F_Buscar.Click
        Dim sSQL As String
        sSQL = "SELECT * FROM Fondos where "
        sSQL = sSQL + "i_e = '" + Cbo_Descripcion.Text + "'"
        Dim cmd As New Odbc.OdbcCommand
        Dim dr As Odbc.OdbcDataReader
        cmd.CommandText = sSQL
        cmd.Connection = Main.gcn
        dr = cmd.ExecuteReader()
        F_grd.RowCount = 0
        While dr.Read()
            F_grd.Rows.Add()
            F_grd.Rows(F_grd.RowCount - 1).Cells(0).Value = dr(0)
            F_grd.Rows(F_grd.RowCount - 1).Cells(1).Value = dr(1)
            F_grd.Rows(F_grd.RowCount - 1).Cells(2).Value = dr(2)
            F_grd.Rows(F_grd.RowCount - 1).Cells(3).Value = dr(3)
            F_grd.Rows(F_grd.RowCount - 1).Cells(4).Value = dr(4)
        End While
    End Sub

    Private Sub Fondos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Cbo_Descripcion.Items.Add("Ingreso")
        Cbo_Descripcion.Items.Add("Egreso")

        Dim sSQL As String
        sSQL = "SELECT fec, money, descripcion, i_e, id_torneo FROM Fondos"
        Dim cmd As New Odbc.OdbcCommand
        Dim dr As Odbc.OdbcDataReader
        cmd.CommandText = sSQL
        cmd.Connection = Main.gcn
        dr = cmd.ExecuteReader()
        F_grd.RowCount = 0

        While dr.Read()
            F_grd.Rows.Add()
            F_grd.Rows(F_grd.RowCount - 1).Cells(0).Value = dr(0)
            F_grd.Rows(F_grd.RowCount - 1).Cells(1).Value = dr(1)
            F_grd.Rows(F_grd.RowCount - 1).Cells(2).Value = dr(2)
            F_grd.Rows(F_grd.RowCount - 1).Cells(3).Value = dr(3)
            F_grd.Rows(F_grd.RowCount - 1).Cells(4).Value = dr(4)
        End While
    End Sub


    Private Sub Txt_F_Valor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_F_Valor.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede introducir numeros")
        End If
    End Sub


    Private Sub Txt_F_idtorneo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_F_idtorneo.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede introducir numeros")
        End If
    End Sub


    Private Sub Txt_F_Descripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_F_Descripcion.KeyPress
        If ((Strings.Asc(e.KeyChar) >= 0 And Strings.Asc(e.KeyChar) <= 7) Or (Strings.Asc(e.KeyChar) >= 9 And Strings.Asc(e.KeyChar) <= 31) Or (Strings.Asc(e.KeyChar) >= 33 And Strings.Asc(e.KeyChar) <= 47) Or (Strings.Asc(e.KeyChar) >= 58 And Strings.Asc(e.KeyChar) <= 64) Or (Strings.Asc(e.KeyChar) >= 91 And Strings.Asc(e.KeyChar) <= 96) Or (Strings.Asc(e.KeyChar) >= 124 And Strings.Asc(e.KeyChar) <= 127)) Then
            e.KeyChar = vbNullChar
        End If
    End Sub
End Class