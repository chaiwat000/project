Public Class frmCompany
    Dim status As String
    Dim supID As String
    Private Sub frmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionDB()
        sql = "Select * from Suppiler"
        dgvCompany.DataSource = ReDGV()

        dgvCompany.Columns(0).HeaderText = "รหัส"
        dgvCompany.Columns(1).HeaderText = "ชื่อบริษัท"
        dgvCompany.Columns(2).HeaderText = "ที่อยู่"
        dgvCompany.Columns(3).HeaderText = "อีเมลล์"
        dgvCompany.Columns(4).HeaderText = "เบอร์โทร"

        dgvCompany.Columns(0).Width = 80
        dgvCompany.Columns(1).Width = 100
        dgvCompany.Columns(2).Width = 100
        dgvCompany.Columns(3).Width = 80
        dgvCompany.Columns(4).Width = 80

        con.Close()
        panRegist.Enabled = False
    End Sub

    Private Sub clearTextShowpanBtn()
        txtSupid.Clear()
        txtSupName.Clear()
        txtsubAdd.Clear()
        txtSupTel.Clear()
        txtSupE.Clear()
        panBtn.Enabled = True
        panRegist.Enabled = False
    End Sub

    Private Sub clearTextShowpanRegis()
        txtSupid.Clear()
        txtSupName.Clear()
        txtsubAdd.Clear()
        txtSupTel.Clear()
        txtSupE.Clear()
        panBtn.Enabled = False
        panRegist.Enabled = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        status = "insert"
        Call clearTextShowpanRegis()
        txtSupid.Select()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        status = "update"
        supID = txtSupid.Text
        panBtn.Enabled = False
        panRegist.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtsubAdd.Text.Trim = "" Or txtSupE.Text.Trim = "" Or txtSupid.Text.Trim = "" Or txtSupName.Text.Trim = "" Or txtSupTel.Text.Trim = "" Then
            MessageBox.Show("ลงทะเบียนล้มเหลว กรุณากรอกข้อมูลให้ครบ")
            Exit Sub
        End If

        connectionDB()
        If status = "insert" Then
            sql = "select supID from Suppiler where supID='" & txtSupid.Text & "'"
            cmd = New SqlClient.SqlCommand(sql, con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("บันทึกล้มเหลว มีรหัสนี้แล้ว")
                dr.Close()
                Exit Sub
            End If
            dr.Close()


            sql = "insert into Suppiler (supID,supName,supAddress,supEmail,supTel) values(@sid,@sname,@sadd,@semail,@stel)"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("sid", txtSupid.Text)
            cmd.Parameters.AddWithValue("sname", txtSupName.Text)
            cmd.Parameters.AddWithValue("sadd", txtsubAdd.Text)
            cmd.Parameters.AddWithValue("semail", txtSupE.Text)
            cmd.Parameters.AddWithValue("stel", txtSupTel.Text)
            cmd.ExecuteNonQuery()
            Call frmCompany_Load(sender, e)
            MessageBox.Show("ลงทะเบียนสำเร็จ")
            Call clearTextShowpanBtn()

        Else
            If supID <> txtSupid.Text Then
                sql = "select supID from Suppiler where supID='" & txtSupid.Text & "'"
                cmd = New SqlClient.SqlCommand(sql, con)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    MessageBox.Show("บันทึกล้มเหลว มีรหัสนี้แล้ว")
                    dr.Close()
                    Exit Sub
                End If
                dr.Close()
            End If

            sql = "update Suppiler SET supID=@sidd,supName=@sname,supAddress=@sadd,supEmail=@semail,supTel=@stel where supID=@newsid"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("sidd", txtSupid.Text)
            cmd.Parameters.AddWithValue("sname", txtSupName.Text)
            cmd.Parameters.AddWithValue("sadd", txtsubAdd.Text)
            cmd.Parameters.AddWithValue("semail", txtSupE.Text)
            cmd.Parameters.AddWithValue("stel", txtSupTel.Text)
            cmd.Parameters.AddWithValue("newsid", supID)
            cmd.ExecuteNonQuery()
            Call frmCompany_Load(sender, e)
            MessageBox.Show("แก้ไขสำเร็จ")
            Call clearTextShowpanBtn()
        End If
        con.Close()
    End Sub

    Private Sub dgvCompany_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCompany.CellClick
        connectionDB()
        Dim i As Integer = dgvCompany.CurrentCell.RowIndex
        Dim ID As String = dgvCompany.Item(0, i).Value

        sql = "select * from Suppiler"
        cmd = New SqlClient.SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        txtSupid.Text = dr.Item("supID")
        txtSupName.Text = dr.Item("supName")
        txtsubAdd.Text = dr.Item("supAddress")
        txtSupE.Text = dr.Item("supEmail")
        txtSupTel.Text = dr.Item("supTel")
        dr.Close()
        con.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        connectionDB()
        Dim delete As DialogResult
        delete = MessageBox.Show("ต้องการลบบริษัทหรือไม่", "ลบบริษัท", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If delete = DialogResult.Yes Then
            Dim i As Integer = dgvCompany.CurrentCell.RowIndex
            Dim ID As String = dgvCompany.Item(0, i).Value

            sql = "delete from Suppiler where supID='" & ID & "'"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("ลบสำเร็จ")
            Call clearTextShowpanBtn()
        End If

    End Sub
End Class