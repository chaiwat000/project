Public Class frmReport
    Private Sub btnReportSale_Click(sender As Object, e As EventArgs) Handles btnReportSale.Click
        creportsale.Visible = True
        creportbuy.Visible = False
        cboBuy.Visible = False
        cbosaleID.Visible = True
        Label1.Visible = True
    End Sub

    Private Sub btnReportBuy_Click(sender As Object, e As EventArgs) Handles btnReportBuy.Click
        creportbuy.Visible = True
        creportsale.Visible = False
        cboBuy.Visible = True
        cbosaleID.Visible = False
        Label1.Visible = True
    End Sub

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionDB()
        sql = "select * from Sale"
        cmd = New SqlClient.SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cbosaleID.Items.Add(dr.Item("saleID"))
            End While
            dr.Close()
        End If

        sql = "select * from Buy"
        cmd = New SqlClient.SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cboBuy.Items.Add(dr.Item("buyID"))
            End While
            dr.Close()
        End If
        con.Close()

        creportbuy.Visible = False
        creportsale.Visible = False
        cboBuy.Visible = False
        cbosaleID.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub cbosaleID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosaleID.SelectedIndexChanged
        connectionDB()
        If cbosaleID.SelectedItem = "ทั้งหมด" Then
            sql = "select * from Sale,SaleDetail,Product,Employee,Customer,Categories" &
            " where Sale.saleID = SaleDetail.saleID and Sale.empID = Employee.empID and Sale.cusID = Customer.cusID " &
            " and SaleDetail.proID = Product.proID and Product.catID = Categories.catID "
            da = New SqlClient.SqlDataAdapter(sql, con)
            ds = New DataSet
            da.Fill(ds, "dtSale")
            Dim report As New CReportSalerpt
            report.SetDataSource(ds.Tables("dtSale"))
            creportsale.ReportSource = report
            creportsale.Show()
        Else
            sql = "select * from Sale,SaleDetail,Product,Employee,Customer,Categories" &
            " where Sale.saleID = SaleDetail.saleID and Sale.empID = Employee.empID and Sale.cusID = Customer.cusID " &
            " and SaleDetail.proID = Product.proID and Product.catID = Categories.catID and Sale.saleID='" & cbosaleID.SelectedItem & "'"
            da = New SqlClient.SqlDataAdapter(sql, con)
            ds = New DataSet
            da.Fill(ds, "dtSale")
            Dim report As New CReportSalerpt
            report.SetDataSource(ds.Tables("dtSale"))
            creportsale.ReportSource = report
            creportsale.Show()
        End If
        con.Close()
    End Sub

    Private Sub cboBuy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBuy.SelectedIndexChanged
        connectionDB()
        If cboBuy.SelectedItem = "ทั้งหมด" Then
            sql = "select * from Buy,BuyDetail,Product,Employee,Suppiler,Categories" &
            " where Buy.buyID = BuyDetail.buyID and Buy.empID = Employee.empID and BuyDetail.supID = Suppiler.supID " &
            " and BuyDetail.proID = Product.proID and Product.catID = Categories.catID "
            da = New SqlClient.SqlDataAdapter(sql, con)
            ds = New DataSet
            da.Fill(ds, "dtBuy")
            Dim report As New CReportBuy
            report.SetDataSource(ds.Tables("dtBuy"))
            creportbuy.ReportSource = report
            creportbuy.Show()
        Else
            sql = "select * from Buy,BuyDetail,Product,Employee,Suppiler,Categories" &
            " where Buy.buyID = BuyDetail.buyID and Buy.empID = Employee.empID and BuyDetail.supID = Suppiler.supID " &
            " and BuyDetail.proID = Product.proID and Product.catID = Categories.catID and Buy.buyID='" & cboBuy.SelectedItem & "'"
            da = New SqlClient.SqlDataAdapter(sql, con)
            ds = New DataSet
            da.Fill(ds, "dtBuy")
            Dim report As New CReportBuy
            report.SetDataSource(ds.Tables("dtBuy"))
            creportbuy.ReportSource = report
            creportbuy.Show()
        End If
        con.Close()
    End Sub
End Class