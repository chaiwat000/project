<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Me.panBtn = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.panRegis = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtCusTel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCusAdd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSurName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCusID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.panBtn.SuspendLayout()
        Me.panRegis.SuspendLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.panBtn)
        Me.Panel1.Controls.Add(Me.panRegis)
        Me.Panel1.Controls.Add(Me.dgvCustomer)
        Me.Panel1.Location = New System.Drawing.Point(12, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1299, 541)
        Me.Panel1.TabIndex = 0
        '
        'panBtn
        '
        Me.panBtn.BackColor = System.Drawing.Color.Aqua
        Me.panBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panBtn.Controls.Add(Me.btnDelete)
        Me.panBtn.Controls.Add(Me.btnEdit)
        Me.panBtn.Controls.Add(Me.btnAdd)
        Me.panBtn.Location = New System.Drawing.Point(721, 423)
        Me.panBtn.Name = "panBtn"
        Me.panBtn.Size = New System.Drawing.Size(512, 97)
        Me.panBtn.TabIndex = 2
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Tomato
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Cancel_48px
        Me.btnDelete.Location = New System.Drawing.Point(327, 14)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 62)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Edit_Row_48px
        Me.btnEdit.Location = New System.Drawing.Point(211, 14)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(85, 62)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.YellowGreen
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Plus_48px
        Me.btnAdd.Location = New System.Drawing.Point(91, 14)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(85, 62)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'panRegis
        '
        Me.panRegis.BackColor = System.Drawing.Color.Aqua
        Me.panRegis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panRegis.Controls.Add(Me.btnCancel)
        Me.panRegis.Controls.Add(Me.btnSave)
        Me.panRegis.Controls.Add(Me.txtCusTel)
        Me.panRegis.Controls.Add(Me.Label5)
        Me.panRegis.Controls.Add(Me.txtCusAdd)
        Me.panRegis.Controls.Add(Me.Label4)
        Me.panRegis.Controls.Add(Me.txtSurName)
        Me.panRegis.Controls.Add(Me.Label3)
        Me.panRegis.Controls.Add(Me.txtCusName)
        Me.panRegis.Controls.Add(Me.Label2)
        Me.panRegis.Controls.Add(Me.txtCusID)
        Me.panRegis.Controls.Add(Me.Label1)
        Me.panRegis.Location = New System.Drawing.Point(677, 26)
        Me.panRegis.Name = "panRegis"
        Me.panRegis.Size = New System.Drawing.Size(593, 382)
        Me.panRegis.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Close_Window_48px
        Me.btnCancel.Location = New System.Drawing.Point(509, 309)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 59)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Save_48px
        Me.btnSave.Location = New System.Drawing.Point(422, 309)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 59)
        Me.btnSave.TabIndex = 10
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtCusTel
        '
        Me.txtCusTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCusTel.Location = New System.Drawing.Point(167, 289)
        Me.txtCusTel.MaxLength = 10
        Me.txtCusTel.Multiline = True
        Me.txtCusTel.Name = "txtCusTel"
        Me.txtCusTel.Size = New System.Drawing.Size(247, 39)
        Me.txtCusTel.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "เบอร์โทรศัพท์"
        '
        'txtCusAdd
        '
        Me.txtCusAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCusAdd.Location = New System.Drawing.Point(167, 182)
        Me.txtCusAdd.Multiline = True
        Me.txtCusAdd.Name = "txtCusAdd"
        Me.txtCusAdd.Size = New System.Drawing.Size(320, 92)
        Me.txtCusAdd.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ที่อยู่"
        '
        'txtSurName
        '
        Me.txtSurName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSurName.Location = New System.Drawing.Point(167, 128)
        Me.txtSurName.Multiline = True
        Me.txtSurName.Name = "txtSurName"
        Me.txtSurName.Size = New System.Drawing.Size(320, 39)
        Me.txtSurName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "นามสกุล"
        '
        'txtCusName
        '
        Me.txtCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCusName.Location = New System.Drawing.Point(167, 73)
        Me.txtCusName.Multiline = True
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(320, 39)
        Me.txtCusName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ชื่อ"
        '
        'txtCusID
        '
        Me.txtCusID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCusID.Location = New System.Drawing.Point(167, 16)
        Me.txtCusID.Multiline = True
        Me.txtCusID.Name = "txtCusID"
        Me.txtCusID.Size = New System.Drawing.Size(320, 39)
        Me.txtCusID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสลูกค้า "
        '
        'dgvCustomer
        '
        Me.dgvCustomer.AllowUserToAddRows = False
        Me.dgvCustomer.AllowUserToDeleteRows = False
        Me.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Location = New System.Drawing.Point(30, 20)
        Me.dgvCustomer.MultiSelect = False
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.ReadOnly = True
        Me.dgvCustomer.RowTemplate.Height = 24
        Me.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomer.Size = New System.Drawing.Size(625, 500)
        Me.dgvCustomer.TabIndex = 0
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1323, 584)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCustomer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "จัดการลูกค้า"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.panBtn.ResumeLayout(False)
        Me.panRegis.ResumeLayout(False)
        Me.panRegis.PerformLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panBtn As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents panRegis As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtCusTel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCusAdd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSurName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCusName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCusID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvCustomer As DataGridView
End Class
