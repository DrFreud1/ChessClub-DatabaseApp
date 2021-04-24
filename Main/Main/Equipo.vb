
Public Class frm_equ
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        e_cb_nam.Items.Add("Reloj")
        e_cb_nam.Items.Add("Tablero")
        e_cb_tip.Items.Add("Incremento")
        e_cb_tip.Items.Add("Sin incremento")
        e_cb_tip.Items.Add("Oficial")
        e_cb_tip.Items.Add("No oficial")
        '        e_add.Enabled = False
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub e_add_Click(sender As Object, e As EventArgs) Handles e_add.Click
        Dim sSQL As String
        Dim cmd As New Odbc.OdbcCommand
        Try
            If ((e_cb_nam.Text = "Reloj" And (e_cb_tip.Text = "Incremento" Or e_cb_tip.Text = "Sin incremento")) Or (e_cb_nam.Text = "Tablero" And (e_cb_tip.Text = "No oficial" Or e_cb_tip.Text = "Oficial"))) Then

                sSQL = "INSERT INTO recurso VALUES ("
                sSQL = sSQL + " default ,"
                sSQL = sSQL + " '" + e_cb_nam.Text + "', "
                sSQL = sSQL + " '" + e_cb_tip.Text + "', "
                sSQL = sSQL + " '" + lblFile.Text + "' "
                sSQL = sSQL + ")"
                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                cmd.ExecuteNonQuery()
                MsgBox("Se añadió un equipo")

            Else
                MsgBox("No coicide Nombre con tipo")
            End If
        Catch

            MsgBox("Error --> Agregar:" + Err.Description, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub

    Private Sub e_buscar_Click(sender As Object, e As EventArgs) Handles e_buscar.Click

        Try
            Dim sSQL As String
            sSQL = "select *from recurso"
            Dim cmd As New Odbc.OdbcCommand
            Dim dr As Odbc.OdbcDataReader
            cmd.CommandText = sSQL
            cmd.Connection = Main.gcn
            dr = cmd.ExecuteReader()
            e_grd.RowCount = 0
            While dr.Read()
                e_grd.Rows.Add()
                e_grd.Rows(e_grd.RowCount - 1).Cells(0).Value = dr(0)
                e_grd.Rows(e_grd.RowCount - 1).Cells(1).Value = dr(1)
                e_grd.Rows(e_grd.RowCount - 1).Cells(2).Value = dr(2)
                e_grd.Rows(e_grd.RowCount - 1).Cells(3).Value = dr(3)
            End While

            Dim sSQL1 As String
            sSQL1 = "select nombre,tipo,count(*) from recurso group by(tipo,nombre)"
            Dim cmd1 As New Odbc.OdbcCommand
            Dim dr1 As Odbc.OdbcDataReader
            cmd1.CommandText = sSQL1
            cmd1.Connection = Main.gcn
            dr1 = cmd1.ExecuteReader()
            e_grd2.RowCount = 0
            While dr1.Read()
                e_grd2.Rows.Add()
                e_grd2.Rows(e_grd2.RowCount - 1).Cells(0).Value = dr1(0)
                e_grd2.Rows(e_grd2.RowCount - 1).Cells(1).Value = dr1(1)
                e_grd2.Rows(e_grd2.RowCount - 1).Cells(2).Value = dr1(2)
            End While

        Catch
        End Try
    End Sub

    Private Sub e_elim_Click(sender As Object, e As EventArgs) Handles e_elim.Click
        Try
            If vbYes = MsgBox("Desea eliminar " + e_grd.CurrentRow.Cells(1).Value.ToString + " " + e_grd.CurrentRow.Cells(2).Value.ToString, vbYesNo) Then

                Dim sSQL As String = "DELETE FROM recurso WHERE id = '" + e_grd.CurrentRow.Cells(0).Value.ToString + "'"
                Dim cmd As New Odbc.OdbcCommand
                cmd.CommandText = sSQL
                cmd.Connection = Main.gcn
                cmd.ExecuteNonQuery()
                e_grd.Rows().RemoveAt(e_grd.CurrentRow.Index)

                MsgBox("Registro eliminado")
            End If
        Catch
            MsgBox(Err.Description, MsgBoxStyle.Critical)
            Exit Sub


        End Try


    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub e_ima_Click(sender As Object, e As EventArgs) Handles e_ima.Click
        OpenFileDialog1.ShowDialog()
        lblFile.Text = OpenFileDialog1.FileName
        'lb_sin.Text = "sin incre"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            PictureBox1.Image = Image.FromFile(e_grd.CurrentRow.Cells(3).Value.ToString)
        Catch
        End Try
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub e_grd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles e_grd.CellContentClick

    End Sub
End Class