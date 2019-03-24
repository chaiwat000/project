<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvSale = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSelectCus = New System.Windows.Forms.Button()
        Me.btnOpenSale = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblMoneyChang = New System.Windows.Forms.Label()
        Me.txtMoney = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.panPro = New System.Windows.Forms.Panel()
        Me.lblProPrice = New System.Windows.Forms.Label()
        Me.lblProName = New System.Windows.Forms.Label()
        Me.lblProID = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgvPro = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.txtCus = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaleID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panPro.SuspendLayout()
        CType(Me.dgvPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSale
        '
        Me.dgvSale.AllowUserToAddRows = False
        Me.dgvSale.AllowUserToDeleteRows = False
        Me.dgvSale.BackgroundColor = System.Drawing.Color.White
        Me.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column4, Me.Column6})
        Me.dgvSale.Location = New System.Drawing.Point(42, 280)
        Me.dgvSale.MultiSelect = False
        Me.dgvSale.Name = "dgvSale"
        Me.dgvSale.ReadOnly = True
        Me.dgvSale.RowTemplate.Height = 24
        Me.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSale.Size = New System.Drawing.Size(872, 363)
        Me.dgvSale.TabIndex = 36
        '
        'Column1
        '
        Me.Column1.HeaderText = "รหัสสินค้า"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "รายการ"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "หน่วย"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 60
        '
        'Column5
        '
        Me.Column5.HeaderText = "ราคา"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "จำนวน"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 70
        '
        'Column6
        '
        Me.Column6.HeaderText = "ราคารวม"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 120
        '
        'btnSelectCus
        '
        Me.btnSelectCus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSelectCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectCus.Location = New System.Drawing.Point(404, 168)
        Me.btnSelectCus.Name = "btnSelectCus"
        Me.btnSelectCus.Size = New System.Drawing.Size(40, 35)
        Me.btnSelectCus.TabIndex = 35
        Me.btnSelectCus.Text = "...."
        Me.btnSelectCus.UseVisualStyleBackColor = False
        '
        'btnOpenSale
        '
        Me.btnOpenSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOpenSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenSale.Location = New System.Drawing.Point(395, 26)
        Me.btnOpenSale.Name = "btnOpenSale"
        Me.btnOpenSale.Size = New System.Drawing.Size(113, 32)
        Me.btnOpenSale.TabIndex = 34
        Me.btnOpenSale.Text = "เปิดการขาย"
        Me.btnOpenSale.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Cancel_48px
        Me.btnCancel.Location = New System.Drawing.Point(1330, 554)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 66)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Print_48px_1
        Me.btnPrint.Location = New System.Drawing.Point(1180, 554)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(86, 66)
        Me.btnPrint.TabIndex = 32
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Plus_48px
        Me.btnSave.Location = New System.Drawing.Point(1030, 554)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 66)
        Me.btnSave.TabIndex = 31
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblMoneyChang
        '
        Me.lblMoneyChang.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMoneyChang.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblMoneyChang.ForeColor = System.Drawing.Color.Green
        Me.lblMoneyChang.Location = New System.Drawing.Point(651, 194)
        Me.lblMoneyChang.Name = "lblMoneyChang"
        Me.lblMoneyChang.Size = New System.Drawing.Size(261, 53)
        Me.lblMoneyChang.TabIndex = 30
        Me.lblMoneyChang.Text = "0.00"
        Me.lblMoneyChang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMoney
        '
        Me.txtMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMoney.Location = New System.Drawing.Point(651, 146)
        Me.txtMoney.Multiline = True
        Me.txtMoney.Name = "txtMoney"
        Me.txtMoney.Size = New System.Drawing.Size(261, 45)
        Me.txtMoney.TabIndex = 29
        Me.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotal.Location = New System.Drawing.Point(532, 80)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(380, 59)
        Me.lblTotal.TabIndex = 28
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panPro
        '
        Me.panPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panPro.Controls.Add(Me.lblProPrice)
        Me.panPro.Controls.Add(Me.lblProName)
        Me.panPro.Controls.Add(Me.lblProID)
        Me.panPro.Controls.Add(Me.btnSelect)
        Me.panPro.Controls.Add(Me.txtAmount)
        Me.panPro.Controls.Add(Me.Label17)
        Me.panPro.Controls.Add(Me.Label15)
        Me.panPro.Controls.Add(Me.Label14)
        Me.panPro.Controls.Add(Me.Label13)
        Me.panPro.Controls.Add(Me.dgvPro)
        Me.panPro.Controls.Add(Me.Label5)
        Me.panPro.Controls.Add(Me.cboSize)
        Me.panPro.Location = New System.Drawing.Point(942, 40)
        Me.panPro.Name = "panPro"
        Me.panPro.Size = New System.Drawing.Size(563, 480)
        Me.panPro.TabIndex = 27
        '
        'lblProPrice
        '
        Me.lblProPrice.AutoSize = True
        Me.lblProPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblProPrice.Location = New System.Drawing.Point(102, 340)
        Me.lblProPrice.Name = "lblProPrice"
        Me.lblProPrice.Size = New System.Drawing.Size(25, 20)
        Me.lblProPrice.TabIndex = 18
        Me.lblProPrice.Text = "...."
        '
        'lblProName
        '
        Me.lblProName.AutoSize = True
        Me.lblProName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblProName.Location = New System.Drawing.Point(332, 297)
        Me.lblProName.Name = "lblProName"
        Me.lblProName.Size = New System.Drawing.Size(25, 20)
        Me.lblProName.TabIndex = 17
        Me.lblProName.Text = "...."
        '
        'lblProID
        '
        Me.lblProID.AutoSize = True
        Me.lblProID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblProID.Location = New System.Drawing.Point(102, 297)
        Me.lblProID.Name = "lblProID"
        Me.lblProID.Size = New System.Drawing.Size(25, 20)
        Me.lblProID.TabIndex = 16
        Me.lblProID.Text = "...."
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Add_Shopping_Cart_48px
        Me.btnSelect.Location = New System.Drawing.Point(415, 384)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(84, 64)
        Me.btnSelect.TabIndex = 14
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(144, 402)
        Me.txtAmount.Multiline = True
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(213, 31)
        Me.txtAmount.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(72, 405)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 17)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "จำนวน"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 340)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 20)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "ราคา"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(241, 297)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 20)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "รหัสสินค้า"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 297)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 20)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "ชื่อสินค้า"
        '
        'dgvPro
        '
        Me.dgvPro.AllowUserToAddRows = False
        Me.dgvPro.AllowUserToDeleteRows = False
        Me.dgvPro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPro.Location = New System.Drawing.Point(15, 65)
        Me.dgvPro.MultiSelect = False
        Me.dgvPro.Name = "dgvPro"
        Me.dgvPro.ReadOnly = True
        Me.dgvPro.RowTemplate.Height = 24
        Me.dgvPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPro.Size = New System.Drawing.Size(531, 208)
        Me.dgvPro.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ประเภทสินค้า"
        '
        'cboSize
        '
        Me.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Location = New System.Drawing.Point(119, 16)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(222, 24)
        Me.cboSize.TabIndex = 0
        '
        'txtCus
        '
        Me.txtCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCus.Location = New System.Drawing.Point(172, 168)
        Me.txtCus.Multiline = True
        Me.txtCus.Name = "txtCus"
        Me.txtCus.ReadOnly = True
        Me.txtCus.Size = New System.Drawing.Size(226, 35)
        Me.txtCus.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "ลูกค้า"
        '
        'txtEmp
        '
        Me.txtEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtEmp.Location = New System.Drawing.Point(172, 127)
        Me.txtEmp.Multiline = True
        Me.txtEmp.Name = "txtEmp"
        Me.txtEmp.ReadOnly = True
        Me.txtEmp.Size = New System.Drawing.Size(226, 35)
        Me.txtEmp.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "พนักงาน"
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDate.Location = New System.Drawing.Point(172, 86)
        Me.txtDate.Multiline = True
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(226, 35)
        Me.txtDate.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "วันที่ขาย"
        '
        'txtSaleID
        '
        Me.txtSaleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSaleID.Location = New System.Drawing.Point(143, 23)
        Me.txtSaleID.Multiline = True
        Me.txtSaleID.Name = "txtSaleID"
        Me.txtSaleID.ReadOnly = True
        Me.txtSaleID.Size = New System.Drawing.Size(226, 35)
        Me.txtSaleID.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "เลขที่ใบเสร็จ"
        '
        'frmSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1544, 666)
        Me.Controls.Add(Me.dgvSale)
        Me.Controls.Add(Me.btnSelectCus)
        Me.Controls.Add(Me.btnOpenSale)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblMoneyChang)
        Me.Controls.Add(Me.txtMoney)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.panPro)
        Me.Controls.Add(Me.txtCus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSaleID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSale"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "ขายสินค้า"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panPro.ResumeLayout(False)
        Me.panPro.PerformLayout()
        CType(Me.dgvPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSale As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents btnSelectCus As Button
    Friend WithEvents btnOpenSale As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblMoneyChang As Label
    Friend WithEvents txtMoney As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents panPro As Panel
    Friend WithEvents lblProPrice As Label
    Friend WithEvents lblProName As Label
    Friend WithEvents lblProID As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dgvPro As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents cboSize As ComboBox
    Friend WithEvents txtCus As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSaleID As TextBox
    Friend WithEvents Label1 As Label
End Class
