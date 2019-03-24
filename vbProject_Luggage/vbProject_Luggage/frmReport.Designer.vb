<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReportBuy = New System.Windows.Forms.Button()
        Me.btnReportSale = New System.Windows.Forms.Button()
        Me.creportsale = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboBuy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbosaleID = New System.Windows.Forms.ComboBox()
        Me.creportbuy = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnReportBuy)
        Me.Panel1.Controls.Add(Me.btnReportSale)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(991, 47)
        Me.Panel1.TabIndex = 2
        '
        'btnReportBuy
        '
        Me.btnReportBuy.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReportBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportBuy.Location = New System.Drawing.Point(170, 7)
        Me.btnReportBuy.Name = "btnReportBuy"
        Me.btnReportBuy.Size = New System.Drawing.Size(153, 33)
        Me.btnReportBuy.TabIndex = 1
        Me.btnReportBuy.Text = "รายงานการซื้อ"
        Me.btnReportBuy.UseVisualStyleBackColor = False
        '
        'btnReportSale
        '
        Me.btnReportSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReportSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportSale.Location = New System.Drawing.Point(11, 7)
        Me.btnReportSale.Name = "btnReportSale"
        Me.btnReportSale.Size = New System.Drawing.Size(153, 33)
        Me.btnReportSale.TabIndex = 0
        Me.btnReportSale.Text = "รายงานการขาย"
        Me.btnReportSale.UseVisualStyleBackColor = False
        '
        'creportsale
        '
        Me.creportsale.ActiveViewIndex = -1
        Me.creportsale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.creportsale.Cursor = System.Windows.Forms.Cursors.Default
        Me.creportsale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.creportsale.Location = New System.Drawing.Point(0, 0)
        Me.creportsale.Name = "creportsale"
        Me.creportsale.ShowLogo = False
        Me.creportsale.Size = New System.Drawing.Size(991, 414)
        Me.creportsale.TabIndex = 0
        Me.creportsale.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cboBuy)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cbosaleID)
        Me.Panel2.Controls.Add(Me.creportbuy)
        Me.Panel2.Controls.Add(Me.creportsale)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(991, 414)
        Me.Panel2.TabIndex = 3
        '
        'cboBuy
        '
        Me.cboBuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBuy.FormattingEnabled = True
        Me.cboBuy.Items.AddRange(New Object() {"ทั้งหมด"})
        Me.cboBuy.Location = New System.Drawing.Point(739, 6)
        Me.cboBuy.Name = "cboBuy"
        Me.cboBuy.Size = New System.Drawing.Size(217, 24)
        Me.cboBuy.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(661, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ดูใบเสร็จ"
        '
        'cbosaleID
        '
        Me.cbosaleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosaleID.FormattingEnabled = True
        Me.cbosaleID.Items.AddRange(New Object() {"ทั้งหมด"})
        Me.cbosaleID.Location = New System.Drawing.Point(739, 6)
        Me.cbosaleID.Name = "cbosaleID"
        Me.cbosaleID.Size = New System.Drawing.Size(217, 24)
        Me.cbosaleID.TabIndex = 2
        '
        'creportbuy
        '
        Me.creportbuy.ActiveViewIndex = -1
        Me.creportbuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.creportbuy.Cursor = System.Windows.Forms.Cursors.Default
        Me.creportbuy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.creportbuy.Location = New System.Drawing.Point(0, 0)
        Me.creportbuy.Name = "creportbuy"
        Me.creportbuy.ShowLogo = False
        Me.creportbuy.Size = New System.Drawing.Size(991, 414)
        Me.creportbuy.TabIndex = 1
        Me.creportbuy.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 461)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmReport"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "รายงาน"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents creportsale As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnReportBuy As Button
    Friend WithEvents btnReportSale As Button
    Friend WithEvents creportbuy As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cboBuy As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbosaleID As ComboBox
End Class
