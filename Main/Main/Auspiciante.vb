Public Class Auspiciante
    Private Sub Btn_A_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_A_Agregar.Click
        Dim sSQL As String
        Dim cmd As New Odbc.OdbcCommand
        Try
            sSQL = "INSERT INTO Auspiciante VALUES ("
            sSQL = sSQL + " " + Txt_A_id.Text + " ,"
            sSQL = sSQL + " '" + Txt_A_Nombre.Text + "', "
            sSQL = sSQL + " '" + Txt_A_Direccion.Text + "', "
            sSQL = sSQL + Txt_A_Telefono.Text + ","
            sSQL = sSQL + " '" + Txt_A_Email.Text + "' "
            sSQL = sSQL + ")"

            cmd.CommandText = sSQL
            cmd.Connection = Main.gcn
            cmd.ExecuteNonQuery()
        Catch
            MsgBox("Error --> Funcion btnAgregar_Click:" + Err.Description, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        MsgBox("Se añadió un auspiciante")


        Dim sSQLa As String
        sSQLa = "SELECT id, nombre, direccion, telefono, email FROM Auspiciante"
        Dim cmda As New Odbc.OdbcCommand
        Dim dra As Odbc.OdbcDataReader
        cmda.CommandText = sSQLa
        cmda.Connection = Main.gcn
        dra = cmda.ExecuteReader()
        A_grd.RowCount = 0

        While dra.Read()
            A_grd.Rows.Add()
            A_grd.Rows(A_grd.RowCount - 1).Cells(0).Value = dra(0)
            A_grd.Rows(A_grd.RowCount - 1).Cells(1).Value = dra(1)
            A_grd.Rows(A_grd.RowCount - 1).Cells(2).Value = dra(2)
            A_grd.Rows(A_grd.RowCount - 1).Cells(3).Value = dra(3)
            A_grd.Rows(A_grd.RowCount - 1).Cells(4).Value = dra(4)
        End While

        Txt_A_id.Text = " "
        Txt_A_Nombre.Text = " "
        Txt_A_Direccion.Text = " "
        Txt_A_Telefono.Text = " "
        Txt_A_Email.Text = " "
    End Sub

    Private Sub A_grd_Click(sender As Object, e As EventArgs) Handles A_grd.Click
        Txt_A_id.Text = A_grd.CurrentRow.Cells(0).Value
        Txt_A_Nombre.Text = A_grd.CurrentRow.Cells(1).Value
        Txt_A_Direccion.Text = A_grd.CurrentRow.Cells(2).Value
        Txt_A_Telefono.Text = A_grd.CurrentRow.Cells(3).Value
        Txt_A_Email.Text = A_grd.CurrentRow.Cells(4).Value

    End Sub

    Private Sub Btn_A_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_A_Buscar.Click
        Dim sSQL As String
        Dim cmd As New Odbc.OdbcCommand
        Dim dr As Odbc.OdbcDataReader
        Try
            sSQL = "SELECT * FROM Auspiciante where "
            sSQL = sSQL + "id = " + Txt_A_id.Text + " "
            cmd.CommandText = sSQL
            cmd.Connection = Main.gcn
            dr = cmd.ExecuteReader()
            A_grd.RowCount = 0
            While dr.Read()
                A_grd.Rows.Add()
                A_grd.Rows(A_grd.RowCount - 1).Cells(0).Value = dr(0)
                A_grd.Rows(A_grd.RowCount - 1).Cells(1).Value = dr(1)
                A_grd.Rows(A_grd.RowCount - 1).Cells(2).Value = dr(2)
                A_grd.Rows(A_grd.RowCount - 1).Cells(3).Value = dr(3)
                A_grd.Rows(A_grd.RowCount - 1).Cells(4).Value = dr(4)
            End While

        Catch
            MsgBox("Error --> Funcion btnBuscar_Click:" + Err.Description, MsgBoxStyle.Critical)
        End Try
        Exit Sub

    End Sub

    Private Sub Btn_A_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_A_Eliminar.Click
        If vbYes = MsgBox("Desea eliminar " + A_grd.CurrentRow.Cells(1).Value.ToString + " " + A_grd.CurrentRow.Cells(3).Value.ToString, vbYesNo) Then

            Dim sSQL As String = "DELETE FROM Auspiciante WHERE id = '" + A_grd.CurrentRow.Cells(0).Value.ToString + "'"
            Dim cmd As New Odbc.OdbcCommand
            Try
                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                cmd.ExecuteNonQuery()
                A_grd.Rows().RemoveAt(A_grd.CurrentRow.Index)
            Catch
                MsgBox(Err.Description, MsgBoxStyle.Critical)
                Exit Sub
            End Try

            MsgBox("Registro eliminado")
            Txt_A_id.Text = " "
            Txt_A_Nombre.Text = " "
            Txt_A_Direccion.Text = " "
            Txt_A_Telefono.Text = " "
            Txt_A_Email.Text = " "
        End If
    End Sub

    Private Sub Btn_A_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_A_Actualizar.Click
        Try
            Dim sSQL As String
            sSQL = "UPDATE Auspiciante "
            sSQL = sSQL + "SET "
            sSQL = sSQL + "nombre = '" + Txt_A_Nombre.Text + "', "
            sSQL = sSQL + "direccion = '" + Txt_A_Direccion.Text + "', "
            sSQL = sSQL + "telefono = " + Txt_A_Telefono.Text + ", "
            sSQL = sSQL + "email = '" + Txt_A_Email.Text + "' "
            sSQL = sSQL + "WHERE id = " + Txt_A_id.Text

            Dim cmd As New Odbc.OdbcCommand
            cmd.CommandText = sSQL
            cmd.Connection = Main.gcn
            cmd.ExecuteNonQuery()
            MsgBox("Registro actualizado")

            A_grd.CurrentRow().Cells(1).Value = Txt_A_Nombre.Text
            A_grd.CurrentRow().Cells(2).Value = Txt_A_Direccion.Text
            A_grd.CurrentRow().Cells(3).Value = Txt_A_Telefono.Text
            A_grd.CurrentRow().Cells(4).Value = Txt_A_Email.Text

            Txt_A_id.Text = " "
            Txt_A_Nombre.Text = " "
            Txt_A_Direccion.Text = " "
            Txt_A_Telefono.Text = " "
            Txt_A_Email.Text = " "
        Catch
            MsgBox("Error --> Funcion btnActualizar_Click:" + Err.Description, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Auspiciante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sSQL As String
        sSQL = "SELECT id, nombre, direccion, telefono, email FROM Auspiciante"
        Dim cmd As New Odbc.OdbcCommand
        Dim dr As Odbc.OdbcDataReader
        cmd.CommandText = sSQL
        cmd.Connection = Main.gcn
        dr = cmd.ExecuteReader()
        A_grd.RowCount = 0

        While dr.Read()
            A_grd.Rows.Add()
            A_grd.Rows(A_grd.RowCount - 1).Cells(0).Value = dr(0)
            A_grd.Rows(A_grd.RowCount - 1).Cells(1).Value = dr(1)
            A_grd.Rows(A_grd.RowCount - 1).Cells(2).Value = dr(2)
            A_grd.Rows(A_grd.RowCount - 1).Cells(3).Value = dr(3)
            A_grd.Rows(A_grd.RowCount - 1).Cells(4).Value = dr(4)
        End While
    End Sub

    Private Sub Txt_A_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_A_id.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede introducir numeros")
        End If
    End Sub


    Private Sub Txt_A_Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_A_Nombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.Keychar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MsgBox("Solo puede introducir letras")
        End If
    End Sub


    Private Sub Txt_A_Telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_A_Telefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede introducir numeros")
        End If
    End Sub


    Private Sub Txt_A_Direccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_A_Direccion.KeyPress
        If ((Strings.Asc(e.KeyChar) >= 0 And Strings.Asc(e.KeyChar) <= 7) Or (Strings.Asc(e.KeyChar) >= 9 And Strings.Asc(e.KeyChar) <= 31) Or (Strings.Asc(e.KeyChar) >= 33 And Strings.Asc(e.KeyChar) <= 47) Or (Strings.Asc(e.KeyChar) >= 58 And Strings.Asc(e.KeyChar) <= 64) Or (Strings.Asc(e.KeyChar) >= 91 And Strings.Asc(e.KeyChar) <= 96) Or (Strings.Asc(e.KeyChar) >= 124 And Strings.Asc(e.KeyChar) <= 127)) Then
            e.KeyChar = vbNullChar
        End If
    End Sub


    Private Sub Txt_A_Email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_A_Email.KeyPress
        If ((Strings.Asc(e.KeyChar) >= 0 And Strings.Asc(e.KeyChar) <= 7) Or (Strings.Asc(e.KeyChar) >= 9 And Strings.Asc(e.KeyChar) <= 31) Or (Strings.Asc(e.KeyChar) >= 33 And Strings.Asc(e.KeyChar) <= 45) Or (Strings.Asc(e.KeyChar) = 47) Or (Strings.Asc(e.KeyChar) >= 58 And Strings.Asc(e.KeyChar) <= 63) Or (Strings.Asc(e.KeyChar) >= 91 And Strings.Asc(e.KeyChar) <= 96) Or (Strings.Asc(e.KeyChar) >= 124 And Strings.Asc(e.KeyChar) <= 127)) Then
            e.KeyChar = vbNullChar
        End If
    End Sub



    Private Sub Btn_A_Buscar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub A_grd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles A_grd.CellContentClick

    End Sub
End Class