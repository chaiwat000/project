Public Class frmSelectCus
    Private Sub frmSelectCus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionDB()
        sql = "Select cusID,cusName,cusSurName from Customer"
        dgvSelectCus.DataSource = ReDGV()
        dgvSelectCus.Columns(0).HeaderText = "รหัสลูกค้า"
        dgvSelectCus.Columns(1).HeaderText = "ชื่อ"
        dgvSelectCus.Columns(2).HeaderText = "นามสกุล"

        dgvSelectCus.Columns(0).Width = 150
        dgvSelectCus.Columns(1).Width = 150
        dgvSelectCus.Columns(2).Width = 150
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        connectionDB()
        Dim i As Integer = dgvSelectCus.CurrentCell.RowIndex
        Dim ID As String = dgvSelectCus.Item(0, i).Value

        sql = "select * from Customer where cusID='" & ID & "'"
        cmd = New SqlClient.SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            frmSale.txtCus.Text = dr.Item("cusName")
            dr.Close()
        End If
        Me.Close()
        con.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class