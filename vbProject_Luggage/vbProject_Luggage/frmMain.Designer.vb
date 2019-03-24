<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSale = New System.Windows.Forms.ToolStripButton()
        Me.btnEmployee = New System.Windows.Forms.ToolStripButton()
        Me.btnCustomer = New System.Windows.Forms.ToolStripButton()
        Me.btnProduct = New System.Windows.Forms.ToolStripButton()
        Me.btnBuy = New System.Windows.Forms.ToolStripButton()
        Me.btnCompany = New System.Windows.Forms.ToolStripButton()
        Me.btnReport = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblName = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSale, Me.btnEmployee, Me.btnCustomer, Me.btnProduct, Me.btnBuy, Me.btnCompany, Me.btnReport, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1419, 153)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSale
        '
        Me.btnSale.AutoSize = False
        Me.btnSale.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Sale_96px
        Me.btnSale.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSale.Name = "btnSale"
        Me.btnSale.Size = New System.Drawing.Size(150, 150)
        Me.btnSale.Text = "ขายกระเป๋า"
        Me.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEmployee
        '
        Me.btnEmployee.AutoSize = False
        Me.btnEmployee.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Businessman_96px
        Me.btnEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEmployee.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(150, 150)
        Me.btnEmployee.Text = "จัดการพนักงาน"
        Me.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnCustomer
        '
        Me.btnCustomer.AutoSize = False
        Me.btnCustomer.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_User_Group_96px
        Me.btnCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(150, 150)
        Me.btnCustomer.Text = "จัดการลูกค้า"
        Me.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnProduct
        '
        Me.btnProduct.AutoSize = False
        Me.btnProduct.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Luggage_Trolley_96px
        Me.btnProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnProduct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(150, 150)
        Me.btnProduct.Text = "จัดการกระเป๋า"
        Me.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnBuy
        '
        Me.btnBuy.AutoSize = False
        Me.btnBuy.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Buy_96px
        Me.btnBuy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnBuy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(150, 150)
        Me.btnBuy.Text = "สั่งซื้อสินค้า"
        Me.btnBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnCompany
        '
        Me.btnCompany.AutoSize = False
        Me.btnCompany.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Department_96px
        Me.btnCompany.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCompany.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCompany.Name = "btnCompany"
        Me.btnCompany.Size = New System.Drawing.Size(150, 150)
        Me.btnCompany.Text = "บริษัทผู้ขายสินค้า"
        Me.btnCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnReport
        '
        Me.btnReport.AutoSize = False
        Me.btnReport.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Clipboard_96px
        Me.btnReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(150, 150)
        Me.btnReport.Text = "Report"
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnExit
        '
        Me.btnExit.AutoSize = False
        Me.btnExit.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Export_96px
        Me.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 150)
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.lblName, Me.ToolStripLabel2, Me.lblDate})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 541)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1419, 25)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripLabel1.Text = "ชื่อพนักงาน"
        '
        'lblName
        '
        Me.lblName.ForeColor = System.Drawing.Color.Green
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(37, 22)
        Me.lblName.Text = "xxxx"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripLabel2.Text = "Date"
        '
        'lblDate
        '
        Me.lblDate.ForeColor = System.Drawing.Color.Green
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(37, 22)
        Me.lblDate.Text = "xxxx"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1419, 566)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Text = "จัดการระบบ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSale As ToolStripButton
    Friend WithEvents btnEmployee As ToolStripButton
    Friend WithEvents btnCustomer As ToolStripButton
    Friend WithEvents btnProduct As ToolStripButton
    Friend WithEvents btnBuy As ToolStripButton
    Friend WithEvents btnReport As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents btnCompany As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lblName As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblDate As ToolStripLabel
End Class
