Public Class frmEmployee
    Dim status As String
    Dim empID As String

    Private Sub clearTextShowPanRegis()
        txtempID.Clear()
        txtempName.Clear()
        txtempPassword.Clear()
        txtempSurName.Clear()
        cboStatus.SelectedIndex = 0
        txtempTel.Clear()
        txtempAdd.Clear()
        panbtn.Enabled = False
        panregis.Enabled = True
    End Sub

    Private Sub clearTextShowPanBtn()
        txtempID.Clear()
        txtempName.Clear()
        txtempPassword.Clear()
        txtempSurName.Clear()
        cboStatus.SelectedIndex = 0
        txtempTel.Clear()
        txtempAdd.Clear()
        panbtn.Enabled = True
        panregis.Enabled = False
    End Sub
    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionDB()
        sql = "select empID,empName,empSurName,empStatus from Employee "
        dgvEmployee.DataSource = ReDGV()

        dgvEmployee.Columns(0).HeaderText = "รหัสพนักงาน"
        dgvEmployee.Columns(1).HeaderText = "ชื่อ"
        dgvEmployee.Columns(2).HeaderText = "นามสกุล"
        dgvEmployee.Columns(3).HeaderText = "ตำแหน่ง"

        dgvEmployee.Columns(0).Width = 110
        dgvEmployee.Columns(1).Width = 100
        dgvEmployee.Columns(2).Width = 100
        dgvEmployee.Columns(3).Width = 80
        con.Close()

        panregis.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        status = "insert"
        Call clearTextShowPanRegis()
        txtempID.Select()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        status = "update"
        panbtn.Enabled = False
        panregis.Enabled = True
        empID = txtempID.Text
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtempID.Text.Trim = "" Or txtempName.Text.Trim = "" Or txtempSurName.Text.Trim = "" Or txtempPassword.Text.Trim = "" Or txtempAdd.Text.Trim = "" Or txtempTel.Text.Trim = "" Then
            MessageBox.Show("ลงทะเบียนพนักงานล้มเหลว กรุณากรอกข้อมูลให้ครบ", "แจ้งเตือนความผิดพลาด")
            Exit Sub
        End If

        connectionDB()
        If status = "insert" Then
            sql = "select empID from Employee where empID='" & txtempID.Text & "'"
            cmd = New SqlClient.SqlCommand(sql, con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("ลงทะเบียนผิดพลาด มีรหัสในระบบแล้ว", "แจ้งเตือนความผิดพลาด")
                dr.Close()
                Exit Sub
            End If
            dr.Close()

            sql = "insert into Employee (empID,empName,empSurName,empPassword,empAddress,empTel,empStatus) " &
                "values(@eid,@ename,@esurname,@epass,@eadd,@etel,@estatus)"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("eid", txtempID.Text)
                .AddWithValue("ename", txtempName.Text)
                .AddWithValue("esurname", txtempSurName.Text)
                .AddWithValue("epass", txtempPassword.Text)
                .AddWithValue("eadd", txtempAdd.Text)
                .AddWithValue("etel", txtempTel.Text)
                .AddWithValue("estatus", cboStatus.SelectedItem)
            End With
            cmd.ExecuteNonQuery()

            Call frmEmployee_Load(sender, e)
            Call clearTextShowPanBtn()

            MessageBox.Show("ลงทะเบียนพนักงานสำเร็จ", "ทำรายการสำเร็จ")

        Else

            If empID <> txtempID.Text Then
                sql = "select empID from Employee where empID='" & txtempID.Text & "'"
                cmd = New SqlClient.SqlCommand(sql, con)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    MessageBox.Show("ลงทะเบียนผิดพลาด มีรหัสในระบบแล้ว", "แจ้งเตือนความผิดพลาด")
                    dr.Close()
                    Exit Sub
                End If
                dr.Close()
            End If

            sql = "update Employee SET empID=@eid,empName=@ename,empSurName=@esurname,empPassword=@epass,empAddress=@eadd,empTel=@etel,empStatus=@estatus where empID=@eidd"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("eid", txtempID.Text)
                .AddWithValue("ename", txtempName.Text)
                .AddWithValue("esurname", txtempSurName.Text)
                .AddWithValue("epass", txtempPassword.Text)
                .AddWithValue("eadd", txtempAdd.Text)
                .AddWithValue("etel", txtempTel.Text)
                .AddWithValue("estatus", cboStatus.SelectedItem)
                .AddWithValue("eidd", empID)
            End With
            cmd.ExecuteNonQuery()
            Call frmEmployee_Load(sender, e)
            Call clearTextShowPanBtn()

            MessageBox.Show("แก้ไขพนักงานสำเร็จ", "ทำรายการสำเร็จ")
        End If

        con.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        connectionDB()
        Dim delete As DialogResult
        delete = MessageBox.Show("ต้องการลบพนักงานหรือไม่", "ลบพนักงาน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If delete = DialogResult.Yes Then
            Dim i As Integer = dgvEmployee.CurrentRow.Index
            Dim ID As String = dgvEmployee.Item(0, i).Value

            sql = "delete from Employee where empID='" & ID & "'"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            Call frmEmployee_Load(sender, e)
            Call clearTextShowPanBtn()
        End If
        con.Close()
    End Sub

    Private Sub dgvEmployee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployee.CellClick
        connectionDB()
        Dim i As Integer = dgvEmployee.CurrentRow.Index
        Dim ID As String = dgvEmployee.Item(0, i).Value
        sql = "select * from Employee where empID='" & ID & "'"
        cmd = New SqlClient.SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            txtempID.Text = dr.Item("empID")
            txtempName.Text = dr.Item("empName")
            txtempSurName.Text = dr.Item("empSurName")
            txtempPassword.Text = dr.Item("empPassword")
            txtempAdd.Text = dr.Item("empAddress")
            txtempTel.Text = dr.Item("empTel")
            cboStatus.SelectedItem = dr.Item("empStatus")
            dr.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        panregis.Enabled = False
        panbtn.Enabled = True
    End Sub
End Class