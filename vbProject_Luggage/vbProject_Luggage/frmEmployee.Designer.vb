<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Me.panbtn = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.panregis = New System.Windows.Forms.Panel()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtempTel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtempAdd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtempPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtempSurName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtempName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtempID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvEmployee = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.panbtn.SuspendLayout()
        Me.panregis.SuspendLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.panbtn)
        Me.Panel1.Controls.Add(Me.panregis)
        Me.Panel1.Controls.Add(Me.dgvEmployee)
        Me.Panel1.Location = New System.Drawing.Point(22, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1412, 521)
        Me.Panel1.TabIndex = 0
        '
        'panbtn
        '
        Me.panbtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panbtn.Controls.Add(Me.btnDelete)
        Me.panbtn.Controls.Add(Me.btnEdit)
        Me.panbtn.Controls.Add(Me.btnAdd)
        Me.panbtn.Location = New System.Drawing.Point(790, 413)
        Me.panbtn.Name = "panbtn"
        Me.panbtn.Size = New System.Drawing.Size(408, 88)
        Me.panbtn.TabIndex = 2
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Cancel_48px
        Me.btnDelete.Location = New System.Drawing.Point(294, 14)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 59)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Edit_Row_48px
        Me.btnEdit.Location = New System.Drawing.Point(165, 14)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 59)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Plus_48px
        Me.btnAdd.Location = New System.Drawing.Point(29, 14)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 59)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'panregis
        '
        Me.panregis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panregis.Controls.Add(Me.cboStatus)
        Me.panregis.Controls.Add(Me.Label8)
        Me.panregis.Controls.Add(Me.btnCancel)
        Me.panregis.Controls.Add(Me.btnSave)
        Me.panregis.Controls.Add(Me.txtempTel)
        Me.panregis.Controls.Add(Me.Label7)
        Me.panregis.Controls.Add(Me.txtempAdd)
        Me.panregis.Controls.Add(Me.Label5)
        Me.panregis.Controls.Add(Me.txtempPassword)
        Me.panregis.Controls.Add(Me.Label4)
        Me.panregis.Controls.Add(Me.txtempSurName)
        Me.panregis.Controls.Add(Me.Label3)
        Me.panregis.Controls.Add(Me.txtempName)
        Me.panregis.Controls.Add(Me.Label2)
        Me.panregis.Controls.Add(Me.txtempID)
        Me.panregis.Controls.Add(Me.Label1)
        Me.panregis.Location = New System.Drawing.Point(591, 17)
        Me.panregis.Name = "panregis"
        Me.panregis.Size = New System.Drawing.Size(783, 390)
        Me.panregis.TabIndex = 1
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"ผู้จัดการ", "พนักงาน"})
        Me.cboStatus.Location = New System.Drawing.Point(528, 17)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(191, 24)
        Me.cboStatus.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(426, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "ตำแหน่ง"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Close_Window_48px
        Me.btnCancel.Location = New System.Drawing.Point(661, 297)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 59)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Save_48px
        Me.btnSave.Location = New System.Drawing.Point(561, 297)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 59)
        Me.btnSave.TabIndex = 14
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtempTel
        '
        Me.txtempTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtempTel.Location = New System.Drawing.Point(158, 338)
        Me.txtempTel.MaxLength = 10
        Me.txtempTel.Multiline = True
        Me.txtempTel.Name = "txtempTel"
        Me.txtempTel.Size = New System.Drawing.Size(191, 31)
        Me.txtempTel.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 341)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "เบอร์โทรศัพท์"
        '
        'txtempAdd
        '
        Me.txtempAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtempAdd.Location = New System.Drawing.Point(158, 214)
        Me.txtempAdd.Multiline = True
        Me.txtempAdd.Name = "txtempAdd"
        Me.txtempAdd.Size = New System.Drawing.Size(281, 118)
        Me.txtempAdd.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ที่อยู่"
        '
        'txtempPassword
        '
        Me.txtempPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtempPassword.Location = New System.Drawing.Point(158, 166)
        Me.txtempPassword.Multiline = True
        Me.txtempPassword.Name = "txtempPassword"
        Me.txtempPassword.Size = New System.Drawing.Size(212, 31)
        Me.txtempPassword.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password"
        '
        'txtempSurName
        '
        Me.txtempSurName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtempSurName.Location = New System.Drawing.Point(158, 115)
        Me.txtempSurName.Multiline = True
        Me.txtempSurName.Name = "txtempSurName"
        Me.txtempSurName.Size = New System.Drawing.Size(212, 31)
        Me.txtempSurName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "นามสกุล"
        '
        'txtempName
        '
        Me.txtempName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtempName.Location = New System.Drawing.Point(158, 64)
        Me.txtempName.Multiline = True
        Me.txtempName.Name = "txtempName"
        Me.txtempName.Size = New System.Drawing.Size(212, 31)
        Me.txtempName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ชื่อ"
        '
        'txtempID
        '
        Me.txtempID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtempID.Location = New System.Drawing.Point(158, 14)
        Me.txtempID.Multiline = True
        Me.txtempID.Name = "txtempID"
        Me.txtempID.Size = New System.Drawing.Size(212, 31)
        Me.txtempID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสพนักงาน"
        '
        'dgvEmployee
        '
        Me.dgvEmployee.AllowUserToAddRows = False
        Me.dgvEmployee.AllowUserToDeleteRows = False
        Me.dgvEmployee.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployee.Location = New System.Drawing.Point(22, 17)
        Me.dgvEmployee.MultiSelect = False
        Me.dgvEmployee.Name = "dgvEmployee"
        Me.dgvEmployee.ReadOnly = True
        Me.dgvEmployee.RowTemplate.Height = 24
        Me.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployee.Size = New System.Drawing.Size(563, 484)
        Me.dgvEmployee.TabIndex = 0
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1446, 563)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEmployee"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "จัดการพนักงาน"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.panbtn.ResumeLayout(False)
        Me.panregis.ResumeLayout(False)
        Me.panregis.PerformLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panbtn As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents panregis As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtempTel As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtempAdd As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtempPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtempSurName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtempName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtempID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvEmployee As DataGridView
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label8 As Label
End Class
