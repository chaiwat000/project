Public Class frmMain
    Private Sub btnSale_Click(sender As Object, e As EventArgs) Handles btnSale.Click
        frmSale.Show()
        frmSale.MdiParent = Me
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        frmEmployee.Show()
        frmEmployee.MdiParent = Me
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmCustomer.Show()
        frmCustomer.MdiParent = Me
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        frmProduct.Show()
        frmProduct.MdiParent = Me
    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        frmOderBuy.Show()
        frmOderBuy.MdiParent = Me
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        frmReport.Show()
        frmReport.MdiParent = Me
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim delete As DialogResult
        delete = MessageBox.Show("ต้องการออกจากระบบหรือไม่", "ออกจากระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If delete = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin.ShowDialog()
        lblDate.Text = Date.Now.ToShortDateString
    End Sub

    Private Sub btnCompany_Click(sender As Object, e As EventArgs) Handles btnCompany.Click
        frmCompany.Show()
        frmCompany.MdiParent = Me
    End Sub
End Class