Public Class frmSale
    Private Sub btnSelectCus_Click(sender As Object, e As EventArgs)
        frmSelectCus.Show()
        frmSelectCus.TopMost = True
    End Sub

    Private Function getNewBill() As String
        Dim newBillID As String = ""
        Dim lastBillID As String

        Dim curYear As Integer = Format(Date.Now, "yyyy") + 543
        connectionDB()
        sql = "Select Max(saleID) as maxSale from Sale Where saleID Like 'S" & curYear & "%' "
        cmd = New SqlClient.SqlCommand(sql, con)
        cmd.CommandTimeout = 15
        cmd.CommandType = CommandType.Text
        dr = cmd.ExecuteReader
        dr.Read()

        If Not IsDBNull(dr.Item("maxSale")) Then
            'B2562/0000109
            lastBillID = dr.Item("maxSale")
            'lastBillID = Mid(lastBillID, 7)
            lastBillID = lastBillID.Substring(6)

            newBillID = Val(lastBillID) + 1
            Select Case newBillID.Length
                Case 1 : newBillID = "000000" & newBillID
                Case 2 : newBillID = "00000" & newBillID
                Case 3 : newBillID = "0000" & newBillID
                Case 4 : newBillID = "000" & newBillID
                Case 5 : newBillID = "00" & newBillID
                Case 6 : newBillID = "0" & newBillID
            End Select
            newBillID = "S" & curYear & "/" & newBillID
        Else
            newBillID = "S" & curYear & "/0000001"
        End If
        dr.Close()
        con.Close()
        Return newBillID
    End Function

    Private Sub frmSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionDB()
        sql = "select proID,ProName,proPrice from Product"
        dgvPro.DataSource = ReDGV()

        dgvPro.Columns(0).HeaderText = "รหัสสินค้า"
        dgvPro.Columns(1).HeaderText = "ชื่อ"
        dgvPro.Columns(2).HeaderText = "ราคา"

        dgvPro.Columns(0).Width = 80
        dgvPro.Columns(1).Width = 170
        dgvPro.Columns(2).Width = 100

        sql = "select catName from Categories"
        cmd = New SqlClient.SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cboSize.Items.Add(dr.Item("catName"))
            End While
            cboSize.SelectedIndex = 0
            dr.Close()
        End If

        con.Close()

        txtMoney.Enabled = False
        panPro.Enabled = False
        btnSave.Enabled = False
        btnSelectCus.Enabled = False
        btnCancel.Enabled = False
        btnPrint.Enabled = False
    End Sub


    Private Sub cboSize_SelectedIndexChanged(sender As Object, e As EventArgs)
        connectionDB()
        sql = "select proID,ProName,proPrice from Product,Categories where Product.catID = Categories.catID and catName='" & cboSize.SelectedItem & "' "
        dgvPro.DataSource = ReDGV()

        con.Close()
    End Sub

    Private Sub btnOpenSale_Click(sender As Object, e As EventArgs)
        txtSaleID.Text = getNewBill()
        txtDate.Text = Date.Now.ToShortDateString
        txtEmp.Text = frmMain.lblName.Text
        txtMoney.Enabled = True
        panPro.Enabled = True
        btnSave.Enabled = True
        btnSelectCus.Enabled = True
        btnCancel.Enabled = True
        btnPrint.Enabled = True
    End Sub


    Private Sub dgvPro_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        connectionDB()
        Dim i As Integer = dgvPro.CurrentCell.RowIndex
        Dim ID As String = dgvPro.Item(0, i).Value
        sql = "Select * from Product where proID='" & ID & "'"
        cmd = New SqlClient.SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            lblProID.Text = dr.Item("proID")
            lblProName.Text = dr.Item("proName")
            lblProPrice.Text = dr.Item("proPrice")
            dr.Close()
        End If
        con.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs)
        Dim found As Boolean = False
        Dim total, total1 As Double
        Dim sumAmount As Integer = Val(txtAmount.Text)
        Dim proNet As Integer

        If txtAmount.Text = "" Then
            MsgBox("กรุณาใส่จำนวนให้ถูกต้อง")
            txtAmount.Select()
            Exit Sub
        End If

        If Not IsNumeric(txtAmount.Text) Then
            MsgBox("กรุณาใส่จำนวนให้ถูกต้อง")
            txtAmount.Select()
            Exit Sub
        End If

        For i = 0 To dgvSale.RowCount - 1
            If lblProID.Text = dgvSale.Item(0, i).Value Then
                sumAmount = Val(dgvSale.Item(4, i).Value) + sumAmount
                Exit For
            End If
        Next

        connectionDB()
        sql = "select proAmountStock from Product where proID = @pid"
        cmd = New SqlClient.SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("pid", lblProID.Text)
        dr = cmd.ExecuteReader
        dr.Read()
        proNet = Val(dr.Item("proAmountStock"))
        dr.Close()
        If sumAmount > proNet Then
            MessageBox.Show("สินค้าคงเหลือไม่เพียงพอต่อจำนวนขายที่ระบุ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAmount.Select()
            Exit Sub
        End If

        For i = 0 To dgvSale.RowCount - 1
            If lblProID.Text = dgvSale.Item(0, i).Value Then
                dgvSale.Item(4, i).Value = Val(dgvSale.Item(4, i).Value) + Val(txtAmount.Text)
                total = Val(dgvSale.Item(3, i).Value) * Val(dgvSale.Item(4, i).Value)
                dgvSale.Item(5, i).Value = total
                found = True
                Exit For
            End If
        Next

        If found = False Then
            Dim n As Integer
            dgvSale.Rows.Add()
            n = dgvSale.Rows.Count - 1
            dgvSale.Item(0, n).Value = lblProID.Text
            dgvSale.Item(1, n).Value = lblProName.Text
            dgvSale.Item(2, n).Value = "ใบ"
            dgvSale.Item(3, n).Value = lblProPrice.Text
            dgvSale.Item(4, n).Value = txtAmount.Text
            dgvSale.Item(5, n).Value = Val(dgvSale.Item(3, n).Value) * Val(dgvSale.Item(4, n).Value)
        End If

        For i = 0 To dgvSale.RowCount - 1
            total1 = total1 + Val(dgvSale.Item(5, i).Value)
        Next
        lblTotal.Text = FormatNumber(total1, 2)


        lblProID.Text = ""
        lblProName.Text = ""
        lblProPrice.Text = ""

        txtAmount.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        If dgvSale.Rows.Count = 0 Then
            MessageBox.Show("ท่านไม่ได้ระบุรายการขายสินค้าใดๆ ไม่สามารถบันทึกได้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        connectionDB()
        'บันทึกหัวใบเสร็จ

        sql = "insert into Sale(saleID,empID,cusID,saleDate)" &
            " values(@sid,(select empID from Employee where empName=@ename),(select cusID from Customer where cusName=@cname),@sdate)"
        cmd = New SqlClient.SqlCommand(sql, con)
        With cmd.Parameters
            .AddWithValue("sid", txtSaleID.Text)
            .AddWithValue("ename", txtEmp.Text)
            .AddWithValue("cname", txtCus.Text)
            .AddWithValue("sdate", txtDate.Text)
        End With

        cmd.ExecuteNonQuery()

        For i = 0 To dgvSale.Rows.Count - 1
            'บันทึกรายการขาย
            sql = "insert into SaleDetail(saleID,proID,salePrice,saleAmount)" &
                   " values(@sidd,@pid,@sprice,@samount)"

            cmd.Parameters.Clear()
            cmd.CommandText = sql
            With cmd.Parameters
                .AddWithValue("sidd", txtSaleID.Text)
                .AddWithValue("pid", dgvSale.Item(0, i).Value)
                .AddWithValue("sprice", dgvSale.Item(3, i).Value)
                .AddWithValue("samount", dgvSale.Item(4, i).Value)
            End With

            cmd.ExecuteNonQuery()

            'ตัดสต๊อก
            sql = "update Product set proAmountStock = proAmountStock - @samount   " &
                   " Where proID = @pid"
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Next

        con.Close()
        MessageBox.Show("บันทึกการขายสินค้าเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        dgvSale.Rows.Clear()
        txtSaleID.Clear()
        txtEmp.Clear()
        txtCus.Clear()
        txtMoney.Clear()
        lblTotal.Text = "0.00"
        lblMoneyChang.Text = "0.00"
        txtDate.Clear()
        txtMoney.Enabled = False
        panPro.Enabled = False
        btnCancel.Enabled = False
        btnPrint.Enabled = False
        btnSave.Enabled = False

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        dgvSale.Rows.Clear()

        txtMoney.Clear()
        panPro.Enabled = False
        btnCancel.Enabled = False
        btnPrint.Enabled = False
        btnSave.Enabled = False
    End Sub

    Private Sub btnOpenSale_Click_1(sender As Object, e As EventArgs) Handles btnOpenSale.Click
        Call btnOpenSale_Click(sender, e)
    End Sub

    Private Sub btnSelectCus_Click_1(sender As Object, e As EventArgs) Handles btnSelectCus.Click
        Call btnSelectCus_Click(sender, e)
    End Sub

    Private Sub cboSize_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboSize.SelectedIndexChanged
        Call cboSize_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub dgvPro_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPro.CellClick
        Call dgvPro_CellClick(sender, e)
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        Call btnSave_Click(sender, e)
    End Sub

    Private Sub btnSelect_Click_1(sender As Object, e As EventArgs) Handles btnSelect.Click
        Call btnSelect_Click(sender, e)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub

    Private Sub txtMoney_TextChanged(sender As Object, e As EventArgs) Handles txtMoney.TextChanged
        lblMoneyChang.Text = Val(txtMoney.Text) - Val(lblTotal.Text)
        If txtMoney.Text = "" Then
            lblMoneyChang.Text = "0.00"
        End If
    End Sub
End Class