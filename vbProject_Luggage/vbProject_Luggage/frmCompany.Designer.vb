<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompany
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
        Me.panRegist = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtSupTel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSupE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsubAdd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSupName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSupid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCompany = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.panBtn.SuspendLayout()
        Me.panRegist.SuspendLayout()
        CType(Me.dgvCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.panBtn)
        Me.Panel1.Controls.Add(Me.panRegist)
        Me.Panel1.Controls.Add(Me.dgvCompany)
        Me.Panel1.Location = New System.Drawing.Point(20, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1138, 473)
        Me.Panel1.TabIndex = 0
        '
        'panBtn
        '
        Me.panBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panBtn.Controls.Add(Me.btnDelete)
        Me.panBtn.Controls.Add(Me.btnEdit)
        Me.panBtn.Controls.Add(Me.btnAdd)
        Me.panBtn.Location = New System.Drawing.Point(716, 369)
        Me.panBtn.Name = "panBtn"
        Me.panBtn.Size = New System.Drawing.Size(361, 93)
        Me.panBtn.TabIndex = 12
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Cancel_48px
        Me.btnDelete.Location = New System.Drawing.Point(247, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 65)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Edit_Row_48px
        Me.btnEdit.Location = New System.Drawing.Point(142, 12)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 65)
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Lime
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Plus_48px
        Me.btnAdd.Location = New System.Drawing.Point(30, 13)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 65)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'panRegist
        '
        Me.panRegist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panRegist.Controls.Add(Me.btnCancel)
        Me.panRegist.Controls.Add(Me.btnSave)
        Me.panRegist.Controls.Add(Me.txtSupTel)
        Me.panRegist.Controls.Add(Me.Label5)
        Me.panRegist.Controls.Add(Me.txtSupE)
        Me.panRegist.Controls.Add(Me.Label4)
        Me.panRegist.Controls.Add(Me.txtsubAdd)
        Me.panRegist.Controls.Add(Me.Label3)
        Me.panRegist.Controls.Add(Me.txtSupName)
        Me.panRegist.Controls.Add(Me.Label2)
        Me.panRegist.Controls.Add(Me.txtSupid)
        Me.panRegist.Controls.Add(Me.Label1)
        Me.panRegist.Location = New System.Drawing.Point(692, 22)
        Me.panRegist.Name = "panRegist"
        Me.panRegist.Size = New System.Drawing.Size(410, 341)
        Me.panRegist.TabIndex = 11
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Close_Window_48px
        Me.btnCancel.Location = New System.Drawing.Point(217, 275)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 52)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = Global.vbProject_Luggage.My.Resources.Resources.icons8_Save_48px
        Me.btnSave.Location = New System.Drawing.Point(131, 275)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 52)
        Me.btnSave.TabIndex = 11
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtSupTel
        '
        Me.txtSupTel.Location = New System.Drawing.Point(131, 235)
        Me.txtSupTel.MaxLength = 10
        Me.txtSupTel.Name = "txtSupTel"
        Me.txtSupTel.Size = New System.Drawing.Size(161, 22)
        Me.txtSupTel.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "เบอร์โทรศัพท์"
        '
        'txtSupE
        '
        Me.txtSupE.Location = New System.Drawing.Point(131, 200)
        Me.txtSupE.Name = "txtSupE"
        Me.txtSupE.Size = New System.Drawing.Size(215, 22)
        Me.txtSupE.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Email"
        '
        'txtsubAdd
        '
        Me.txtsubAdd.Location = New System.Drawing.Point(131, 76)
        Me.txtsubAdd.Multiline = True
        Me.txtsubAdd.Name = "txtsubAdd"
        Me.txtsubAdd.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtsubAdd.Size = New System.Drawing.Size(215, 113)
        Me.txtsubAdd.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ที่อยู่"
        '
        'txtSupName
        '
        Me.txtSupName.Location = New System.Drawing.Point(131, 39)
        Me.txtSupName.Name = "txtSupName"
        Me.txtSupName.Size = New System.Drawing.Size(161, 22)
        Me.txtSupName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ชื่อ"
        '
        'txtSupid
        '
        Me.txtSupid.Location = New System.Drawing.Point(131, 6)
        Me.txtSupid.Name = "txtSupid"
        Me.txtSupid.Size = New System.Drawing.Size(161, 22)
        Me.txtSupid.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "รหัส"
        '
        'dgvCompany
        '
        Me.dgvCompany.AllowUserToAddRows = False
        Me.dgvCompany.AllowUserToDeleteRows = False
        Me.dgvCompany.BackgroundColor = System.Drawing.Color.White
        Me.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompany.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.dgvCompany.Location = New System.Drawing.Point(21, 22)
        Me.dgvCompany.MultiSelect = False
        Me.dgvCompany.Name = "dgvCompany"
        Me.dgvCompany.ReadOnly = True
        Me.dgvCompany.RowTemplate.Height = 24
        Me.dgvCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompany.Size = New System.Drawing.Size(640, 425)
        Me.dgvCompany.TabIndex = 0
        '
        'frmCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1170, 502)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCompany"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "บริษัทคู่ค้า"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.panBtn.ResumeLayout(False)
        Me.panRegist.ResumeLayout(False)
        Me.panRegist.PerformLayout()
        CType(Me.dgvCompany, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panBtn As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents panRegist As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtSupTel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSupE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtsubAdd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSupName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSupid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvCompany As DataGridView
End Class
