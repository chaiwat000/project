Public Class frmCustomer
    Dim status As String
    Dim cusID As String

    Private Sub ClearTextAndPanBtnShow()
        txtCusID.Clear()
        txtCusName.Clear()
        txtSurName.Clear()
        txtCusTel.Clear()
        txtCusAdd.Clear()
        panBtn.Enabled = True
        panRegis.Enabled = False
    End Sub

    Private Sub ClearTextAndPanRegisShow()
        txtCusID.Clear()
        txtCusName.Clear()
        txtSurName.Clear()
        txtCusTel.Clear()
        txtCusAdd.Clear()
        panBtn.Enabled = False
        panRegis.Enabled = True
    End Sub
    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionDB()
        sql = "Select cusID,cusName,cusSurName from Customer"
        dgvCustomer.DataSource = ReDGV()
        dgvCustomer.Columns(0).HeaderText = "รหัสลูกค้า"
        dgvCustomer.Columns(1).HeaderText = "ชื่อ"
        dgvCustomer.Columns(2).HeaderText = "นามสกุล"

        dgvCustomer.Columns(0).Width = 125
        dgvCustomer.Columns(1).Width = 150
        dgvCustomer.Columns(2).Width = 150

        panRegis.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        status = "insert"
        Call ClearTextAndPanRegisShow()
        txtCusID.Select()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        status = "update"
        cusID = txtCusID.Text
        panRegis.Enabled = True
        panBtn.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCusID.Text.Trim = "" Or txtCusName.Text.Trim = "" Or txtSurName.Text.Trim = "" Or txtCusAdd.Text.Trim = "" Or txtCusTel.Text.Trim = "" Then
            MessageBox.Show("ลงทะเบียนผิดพลาด กรุณากรอกข้อมูลให้ครบ", "แจ้งเตือนความผิดพลาด")
            Exit Sub
        End If

        connectionDB()
        If status = "insert" Then
            sql = "select cusID from Customer where cusID='" & txtCusID.Text & "'"
            cmd = New SqlClient.SqlCommand(sql, con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("ลงทะเบียนผิดพลาด มีรหัสในระบบแล้ว", "แจ้งเตือนความผิดพลาด")
                dr.Close()
                Exit Sub
            End If
            dr.Close()

            sql = "insert into Customer (cusID,cusName,cusSurName,cusAddress,cusTel) values(@cid,@cname,@csurname,@caddress,@ctel)"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("cid", txtCusID.Text)
                .AddWithValue("cname", txtCusName.Text)
                .AddWithValue("csurname", txtSurName.Text)
                .AddWithValue("caddress", txtCusAdd.Text)
                .AddWithValue("ctel", txtCusTel.Text)
            End With
            cmd.ExecuteNonQuery()

            sql = "Select cusID,cusName,cusSurName from Customer"

            dgvCustomer.DataSource = ReDGV()

            dgvCustomer.Columns(0).HeaderText = "รหัสลูกค้า"
            dgvCustomer.Columns(1).HeaderText = "ชื่อ"
            dgvCustomer.Columns(2).HeaderText = "นามสกุล"

            dgvCustomer.Columns(0).Width = 125
            dgvCustomer.Columns(1).Width = 150
            dgvCustomer.Columns(2).Width = 150

            MessageBox.Show("ลงทะเบียนพนักงานสำเร็จ", "ทำรายการสำเร็จ")
            Call ClearTextAndPanBtnShow()

        Else

            If cusID <> txtCusID.Text Then
                sql = "select cusID from Customer where cusID='" & txtCusID.Text & "'"
                cmd = New SqlClient.SqlCommand(sql, con)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    MessageBox.Show("แก้ไขผิดพลาด มีรหัสในระบบแล้ว", "แจ้งเตือนความผิดพลาด")
                    dr.Close()
                    Exit Sub
                End If
                dr.Close()
            End If

            sql = "update Customer SET cusID=@cid,cusName=@cname,cusSurName=@csurname,cusAddress=@caddress,cusTel=@ctel where cusID=@cnewid"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("cid", txtCusID.Text)
                .AddWithValue("cname", txtCusName.Text)
                .AddWithValue("csurname", txtSurName.Text)
                .AddWithValue("caddress", txtCusAdd.Text)
                .AddWithValue("ctel", txtCusTel.Text)
                .AddWithValue("cnewid", cusID)
            End With
            cmd.ExecuteNonQuery()
            sql = "Select cusID,cusName,cusSurName from Customer"

            dgvCustomer.DataSource = ReDGV()

            dgvCustomer.Columns(0).HeaderText = "รหัสลูกค้า"
            dgvCustomer.Columns(1).HeaderText = "ชื่อ"
            dgvCustomer.Columns(2).HeaderText = "นามสกุล"

            dgvCustomer.Columns(0).Width = 125
            dgvCustomer.Columns(1).Width = 150
            dgvCustomer.Columns(2).Width = 150

            MessageBox.Show("แก้ไขพนักงานสำเร็จ", "ทำรายการสำเร็จ")
            Call ClearTextAndPanBtnShow()
        End If
    End Sub

    Private Sub dgvCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellClick
        connectionDB()
        Dim i As Integer = dgvCustomer.CurrentCell.RowIndex
        Dim ID As String = dgvCustomer.Item(0, i).Value

        sql = "select * from Customer where cusID='" & ID & "'"
        cmd = New SqlClient.SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            txtCusID.Text = dr.Item("cusID")
            txtCusName.Text = dr.Item("cusName")
            txtSurName.Text = dr.Item("cusSurName")
            txtCusAdd.Text = dr.Item("cusAddress")
            txtCusTel.Text = dr.Item("cusTel")
            dr.Close()
        End If

        con.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        connectionDB()
        Dim delete As DialogResult
        delete = MessageBox.Show("ต้องการลบลูกค้าหรือไม่", "ลบลูกค้า", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If delete = DialogResult.Yes Then
            Dim i As Integer = dgvCustomer.CurrentRow.Index
            Dim ID As String = dgvCustomer.Item(0, i).Value

            sql = "delete from Customer where cusID='" & ID & "'"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            sql = "Select cusID,cusName,cusSurName from Customer"

            dgvCustomer.DataSource = ReDGV()
            dgvCustomer.Columns(0).HeaderText = "รหัสลูกค้า"
            dgvCustomer.Columns(1).HeaderText = "ชื่อ"
            dgvCustomer.Columns(2).HeaderText = "นามสกุล"

            dgvCustomer.Columns(0).Width = 125
            dgvCustomer.Columns(1).Width = 150
            dgvCustomer.Columns(2).Width = 150

            MessageBox.Show("ลบพนักงานสำเร็จ", "ทำรายการสำเร็จ")
            Call ClearTextAndPanBtnShow()
        End If
        con.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        panRegis.Enabled = False
        panBtn.Enabled = True
    End Sub
End Class