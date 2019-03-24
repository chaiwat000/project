Public Class frmOderBuy
    Private Sub frmOderBuy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionDB()
        sql = "select * from Categories"
        cmd = New SqlClient.SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cboCat.Items.Add(dr.Item("catName"))
            End While
            dr.Close()
        End If

        sql = "select * from Suppiler"
        cmd = New SqlClient.SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cboSup.Items.Add(dr.Item("supName"))
            End While
            dr.Close()
        End If

        sql = "select proID,proName from Product"
        dgvProduct.DataSource = ReDGV()

        dgvProduct.Columns(0).HeaderText = "รหัสสินค้า"
        dgvProduct.Columns(1).HeaderText = "ชื่อสินค้า"

        dgvProduct.Columns(0).Width = 200
        dgvProduct.Columns(1).Width = 200

        con.Close()
        Panel2.Enabled = False
        btnSave.Enabled = False
        btnPrint.Enabled = False
        btnCalcel.Enabled = False
        cboCat.SelectedIndex = 0
        cboSup.SelectedIndex = 0
    End Sub

    Private Function getNewBill() As String
        Dim newBillID As String = ""
        Dim lastBillID As String

        Dim curYear As Integer = Format(Date.Now, "yyyy") + 543
        connectionDB()
        sql = "Select Max(buyID) as maxBuy from Buy Where BuyID Like 'B" & curYear & "%' "
        cmd = New SqlClient.SqlCommand(sql, con)
        cmd.CommandTimeout = 15
        cmd.CommandType = CommandType.Text
        dr = cmd.ExecuteReader
        dr.Read()

        If Not IsDBNull(dr.Item("maxBuy")) Then
            'B2562/0000109
            lastBillID = dr.Item("maxBuy")
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
            newBillID = "B" & curYear & "/" & newBillID
        Else
            newBillID = "B" & curYear & "/0000001"
        End If
        dr.Close()
        con.Close()
        Return newBillID
    End Function

    Private Sub cboCat_SelectedIndexChanged(sender As Object, e As EventArgs)
        connectionDB()
        sql = "select proID,ProName,proPrice from Product,Categories where Product.catID = Categories.catID and catName='" & cboCat.SelectedItem & "' "
        dgvProduct.DataSource = ReDGV()

        con.Close()
    End Sub

    Private Sub dgvProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellClick
        connectionDB()
        Dim i As Integer = dgvProduct.CurrentCell.RowIndex
        Dim ID As String = dgvProduct.Item(0, i).Value

        sql = "Select * from product where proID='" & ID & "'"
        cmd = New SqlClient.SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        txtproID.Text = dr.Item("proID")
        txtProName.Text = dr.Item("proName")
        dr.Close()
        con.Close()
    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        Dim found As Boolean = False
        Dim total, total1 As Double
        Dim sumAmount As Integer = Val(txtAmount.Text)

        If txtAmount.Text.Trim = "" Or txtPrice.Text.Trim = "" Or txtproID.Text.Trim = "" Or txtProName.Text.Trim = "" Then
            MsgBox("กรุณาใส่ข้อมูลให้ถูกต้อง")
            txtAmount.Select()
            Exit Sub
        End If

        If Not IsNumeric(txtAmount.Text) Or Not IsNumeric(txtPrice.Text) Then
            MsgBox("กรุณาใส่จำนวนให้ถูกต้อง")
            txtAmount.Select()
            Exit Sub
        End If

        For i = 0 To dgvBuy.RowCount - 1
            If txtproID.Text = dgvBuy.Item(1, i).Value Then
                sumAmount = Val(dgvBuy.Item(4, i).Value) + sumAmount
                Exit For
            End If
        Next

        connectionDB()

        For i = 0 To dgvBuy.RowCount - 1
            If txtproID.Text = dgvBuy.Item(1, i).Value Then
                dgvBuy.Item(5, i).Value = Val(dgvBuy.Item(5, i).Value) + Val(txtAmount.Text)
                total = Val(dgvBuy.Item(4, i).Value) * Val(dgvBuy.Item(5, i).Value)
                dgvBuy.Item(6, i).Value = total
                found = True
                Exit For
            End If
        Next

        If found = False Then
            Dim n As Integer
            dgvBuy.Rows.Add()
            n = dgvBuy.Rows.Count - 1
            dgvBuy.Item(0, n).Value = cboSup.SelectedItem
            dgvBuy.Item(1, n).Value = cboCat.SelectedItem
            dgvBuy.Item(2, n).Value = txtproID.Text
            dgvBuy.Item(3, n).Value = txtProName.Text
            dgvBuy.Item(4, n).Value = txtPrice.Text
            dgvBuy.Item(5, n).Value = txtAmount.Text
            dgvBuy.Item(6, n).Value = Val(dgvBuy.Item(4, n).Value) * Val(dgvBuy.Item(5, n).Value)
        End If

        For i = 0 To dgvBuy.RowCount - 1
            total1 = total1 + Val(dgvBuy.Item(6, i).Value)
        Next
        Label10.Text = FormatNumber(total1, 2)


        txtproID.Text = ""
        txtProName.Text = ""
        txtPrice.Text = ""

        txtAmount.Clear()
    End Sub

    Private Sub btnOpenBuy_Click(sender As Object, e As EventArgs) Handles btnOpenBuy.Click
        Panel2.Enabled = True
        btnSave.Enabled = True
        btnPrint.Enabled = True
        btnCalcel.Enabled = True
        txtEmp.Text = frmMain.lblName.Text
        txtBuyID.Text = getNewBill()
    End Sub

    Private Sub cboCat_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboCat.SelectedIndexChanged
        Call cboCat_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub btnCalcel_Click(sender As Object, e As EventArgs) Handles btnCalcel.Click
        dgvBuy.Rows.Clear()
        txtproID.Text = ""
        txtProName.Text = ""
        txtPrice.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dgvBuy.RowCount = 0 Then
            MessageBox.Show("ท่านไม่ได้ระบุรายการขายสินค้าใดๆ ไม่สามารถบันทึกได้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        connectionDB()
        'บันทึกหัวใบเสร็จ

        sql = "insert into Buy(buyID,empID,buyDate)" &
            " values(@bid,(select empID from employee where empName='" & txtEmp.Text & "'),@bdate)"
        cmd = New SqlClient.SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("bid", txtBuyID.Text)
        cmd.Parameters.AddWithValue("bdate", dtDate.Value)
        cmd.ExecuteNonQuery()

        For i = 0 To dgvBuy.RowCount - 1
            'บันทึกรายการขาย
            sql = "insert into BuyDetail(buyID,supID,catID,proID,buyPrice,buyAmount)" &
                   " values(@bidd,(select supID from Suppiler where supName=@sname),(select catID from Categories where catName=@cname),@pid,@bprice,@bamount)"
            cmd.Parameters.Clear()
            cmd.CommandText = sql

            cmd.Parameters.AddWithValue("bidd", txtBuyID.Text)
            cmd.Parameters.AddWithValue("sname", dgvBuy.Item(0, i).Value)
            cmd.Parameters.AddWithValue("cname", dgvBuy.Item(1, i).Value)
            cmd.Parameters.AddWithValue("pid", dgvBuy.Item(2, i).Value)
            cmd.Parameters.AddWithValue("bprice", dgvBuy.Item(4, i).Value)
            cmd.Parameters.AddWithValue("bamount", dgvBuy.Item(5, i).Value)
            cmd.ExecuteNonQuery()

            'ตัดสต๊อก
            sql = "update Product set proAmountStock = proAmountStock + @bamount   " &
                   " Where proID = @pid"
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Next
        con.Close()
        MessageBox.Show("บันทึกการซื้อสินค้าเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        txtBuyID.Clear()
        txtEmp.Clear()
        dgvBuy.Rows.Clear()

    End Sub

    Private Sub btndeletrow_Click(sender As Object, e As EventArgs) Handles btndeletrow.Click
        dgvBuy.Rows.RemoveAt(dgvBuy.SelectedRows(0).Index)
        Dim total As Decimal
        For i = 0 To dgvBuy.RowCount - 1
            total = Val(dgvBuy.Item(6, i).Value) - total
        Next
        Label10.Text = FormatNumber(total, 2)
    End Sub
End Class