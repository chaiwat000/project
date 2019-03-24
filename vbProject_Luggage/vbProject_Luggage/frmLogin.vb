Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtPassword.Text.Trim = "" Or txtPassword.Text.Trim = "" Then
            MessageBox.Show("กรุณากรอก Username หรือ Password")
            Exit Sub
        End If

        connectionDB()
        sql = "select * from Employee where empID='" & txtUsername.Text & "' and empPassword='" & txtPassword.Text & "'"
        da = New SqlClient.SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "tb")
        If ds.Tables("tb").Rows.Count < 0 Then
            MessageBox.Show("เข้าสู่ระบบล้มเหลว")
            txtUsername.Select()
            Exit Sub
        Else
            frmMain.lblName.Text = ds.Tables("tb").Rows(0)("empName")
            MessageBox.Show("เข้าสู่ระบบสำเร็จ")
        End If

        Me.Close()
        con.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim out As DialogResult
        out = MessageBox.Show("คุณต้องการออกจากระบบหรือไม่", "ยกเลิกการเข้าระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If out = DialogResult.Yes Then
            End
        End If
    End Sub


End Class
