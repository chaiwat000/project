<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOderBuy
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
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboCat = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtproID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.cboSup = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnOpenBuy = New System.Windows.Forms.Button()
        Me.txtEmp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuyID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvBuy = New System.Windows.Forms.DataGridView()
        Me.ราคารวม = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btndeletrow = New System.Windows.Forms.Button()
        Me.btnCalcel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBuy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Print_48px_1
        Me.btnPrint.Location = New System.Drawing.Point(1164, 566)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 60)
        Me.btnPrint.TabIndex = 24
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnBuy)
        Me.Panel2.Controls.Add(Me.txtAmount)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.cboCat)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtPrice)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtProName)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtproID)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.dgvProduct)
        Me.Panel2.Controls.Add(Me.cboSup)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(905, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(568, 484)
        Me.Panel2.TabIndex = 22
        '
        'btnBuy
        '
        Me.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuy.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Add_Shopping_Cart_48px
        Me.btnBuy.Location = New System.Drawing.Point(443, 408)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(90, 65)
        Me.btnBuy.TabIndex = 14
        Me.btnBuy.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(144, 442)
        Me.txtAmount.Multiline = True
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(182, 31)
        Me.txtAmount.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(56, 408)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "ราคา"
        '
        'cboCat
        '
        Me.cboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCat.FormattingEnabled = True
        Me.cboCat.Location = New System.Drawing.Point(115, 21)
        Me.cboCat.Name = "cboCat"
        Me.cboCat.Size = New System.Drawing.Size(195, 24)
        Me.cboCat.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "ประเภทสินค้า"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(144, 405)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(182, 31)
        Me.txtPrice.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 442)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "จำนวน"
        '
        'txtProName
        '
        Me.txtProName.Location = New System.Drawing.Point(144, 368)
        Me.txtProName.Multiline = True
        Me.txtProName.Name = "txtProName"
        Me.txtProName.ReadOnly = True
        Me.txtProName.Size = New System.Drawing.Size(182, 31)
        Me.txtProName.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ชื่อสินค้า"
        '
        'txtproID
        '
        Me.txtproID.Location = New System.Drawing.Point(144, 331)
        Me.txtproID.Multiline = True
        Me.txtproID.Name = "txtproID"
        Me.txtproID.ReadOnly = True
        Me.txtproID.Size = New System.Drawing.Size(182, 31)
        Me.txtproID.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "รหัสสินค้า"
        '
        'dgvProduct
        '
        Me.dgvProduct.AllowUserToAddRows = False
        Me.dgvProduct.AllowUserToDeleteRows = False
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Location = New System.Drawing.Point(23, 54)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.ReadOnly = True
        Me.dgvProduct.RowTemplate.Height = 24
        Me.dgvProduct.Size = New System.Drawing.Size(524, 208)
        Me.dgvProduct.TabIndex = 0
        '
        'cboSup
        '
        Me.cboSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSup.FormattingEnabled = True
        Me.cboSup.Location = New System.Drawing.Point(106, 286)
        Me.cboSup.Name = "cboSup"
        Me.cboSup.Size = New System.Drawing.Size(195, 24)
        Me.cboSup.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "บริษัทผู้ผลิต"
        '
        'btnOpenBuy
        '
        Me.btnOpenBuy.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOpenBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenBuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnOpenBuy.Location = New System.Drawing.Point(569, 195)
        Me.btnOpenBuy.Name = "btnOpenBuy"
        Me.btnOpenBuy.Size = New System.Drawing.Size(128, 43)
        Me.btnOpenBuy.TabIndex = 21
        Me.btnOpenBuy.Text = "เปิดการสั่งซื้อ"
        Me.btnOpenBuy.UseVisualStyleBackColor = False
        '
        'txtEmp
        '
        Me.txtEmp.Location = New System.Drawing.Point(205, 128)
        Me.txtEmp.Multiline = True
        Me.txtEmp.Name = "txtEmp"
        Me.txtEmp.ReadOnly = True
        Me.txtEmp.Size = New System.Drawing.Size(182, 31)
        Me.txtEmp.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "พนักงาน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "วันที่สั่งซื้อ"
        '
        'txtBuyID
        '
        Me.txtBuyID.Location = New System.Drawing.Point(172, 25)
        Me.txtBuyID.Multiline = True
        Me.txtBuyID.Name = "txtBuyID"
        Me.txtBuyID.ReadOnly = True
        Me.txtBuyID.Size = New System.Drawing.Size(182, 31)
        Me.txtBuyID.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "หมายเลขใบสั่งซื้อ"
        '
        'dgvBuy
        '
        Me.dgvBuy.AllowUserToAddRows = False
        Me.dgvBuy.AllowUserToDeleteRows = False
        Me.dgvBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuy.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ราคารวม, Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column4, Me.Column6})
        Me.dgvBuy.Location = New System.Drawing.Point(12, 244)
        Me.dgvBuy.Name = "dgvBuy"
        Me.dgvBuy.ReadOnly = True
        Me.dgvBuy.RowTemplate.Height = 24
        Me.dgvBuy.Size = New System.Drawing.Size(840, 357)
        Me.dgvBuy.TabIndex = 14
        '
        'ราคารวม
        '
        Me.ราคารวม.HeaderText = "บริษัท"
        Me.ราคารวม.Name = "ราคารวม"
        Me.ราคารวม.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ประเภทสินค้า"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "รหัสสินค้า"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "รายการ"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 180
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
        '
        'dtDate
        '
        Me.dtDate.Location = New System.Drawing.Point(205, 85)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(245, 22)
        Me.dtDate.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(521, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(351, 64)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "0.00"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btndeletrow
        '
        Me.btndeletrow.BackColor = System.Drawing.Color.Red
        Me.btndeletrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeletrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btndeletrow.Location = New System.Drawing.Point(724, 195)
        Me.btndeletrow.Name = "btndeletrow"
        Me.btndeletrow.Size = New System.Drawing.Size(128, 43)
        Me.btndeletrow.TabIndex = 28
        Me.btndeletrow.Text = "ลบรายการ"
        Me.btndeletrow.UseVisualStyleBackColor = False
        '
        'btnCalcel
        '
        Me.btnCalcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCalcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcel.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Close_Window_48px
        Me.btnCalcel.Location = New System.Drawing.Point(1308, 566)
        Me.btnCalcel.Name = "btnCalcel"
        Me.btnCalcel.Size = New System.Drawing.Size(79, 60)
        Me.btnCalcel.TabIndex = 25
        Me.btnCalcel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Save_48px
        Me.btnSave.Location = New System.Drawing.Point(1012, 566)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 60)
        Me.btnSave.TabIndex = 23
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmOderBuy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1502, 638)
        Me.Controls.Add(Me.btndeletrow)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.btnCalcel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnOpenBuy)
        Me.Controls.Add(Me.txtEmp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuyID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvBuy)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Name = "frmOderBuy"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "สั่งซื้อสินค้า"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBuy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcel As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnBuy As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboCat As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtProName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtproID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvProduct As DataGridView
    Friend WithEvents cboSup As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnOpenBuy As Button
    Friend WithEvents txtEmp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuyID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvBuy As DataGridView
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents ราคารวม As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents btndeletrow As Button
End Class
