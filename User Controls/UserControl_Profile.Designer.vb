<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Profile
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.txtNewPass = New System.Windows.Forms.TextBox()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.txtCurrentPass = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.txtConfirmNewPass = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnConfirm = New System.Windows.Forms.Button()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.lblCurrentPass = New System.Windows.Forms.Label()
		Me.lblNewPass = New System.Windows.Forms.Label()
		Me.lblIsNull = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'txtName
		'
		Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtName.Location = New System.Drawing.Point(308, 186)
		Me.txtName.Margin = New System.Windows.Forms.Padding(4)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(280, 29)
		Me.txtName.TabIndex = 0
		'
		'txtNewPass
		'
		Me.txtNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNewPass.Location = New System.Drawing.Point(17, 124)
		Me.txtNewPass.Margin = New System.Windows.Forms.Padding(4)
		Me.txtNewPass.Name = "txtNewPass"
		Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtNewPass.Size = New System.Drawing.Size(183, 29)
		Me.txtNewPass.TabIndex = 1
		'
		'txtID
		'
		Me.txtID.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtID.Location = New System.Drawing.Point(308, 118)
		Me.txtID.Margin = New System.Windows.Forms.Padding(4)
		Me.txtID.Name = "txtID"
		Me.txtID.ReadOnly = True
		Me.txtID.Size = New System.Drawing.Size(183, 29)
		Me.txtID.TabIndex = 2
		'
		'txtCurrentPass
		'
		Me.txtCurrentPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCurrentPass.Location = New System.Drawing.Point(17, 55)
		Me.txtCurrentPass.Margin = New System.Windows.Forms.Padding(4)
		Me.txtCurrentPass.Name = "txtCurrentPass"
		Me.txtCurrentPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtCurrentPass.Size = New System.Drawing.Size(183, 29)
		Me.txtCurrentPass.TabIndex = 3
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(304, 92)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(28, 23)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "ID"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.White
		Me.Label2.Location = New System.Drawing.Point(304, 160)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(57, 23)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Name"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(13, 32)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(160, 20)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Current Password"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(13, 101)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(133, 20)
		Me.Label5.TabIndex = 8
		Me.Label5.Text = "New Password"
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
		Me.GroupBox1.Controls.Add(Me.lblIsNull)
		Me.GroupBox1.Controls.Add(Me.lblNewPass)
		Me.GroupBox1.Controls.Add(Me.lblCurrentPass)
		Me.GroupBox1.Controls.Add(Me.PictureBox3)
		Me.GroupBox1.Controls.Add(Me.PictureBox2)
		Me.GroupBox1.Controls.Add(Me.PictureBox1)
		Me.GroupBox1.Controls.Add(Me.txtConfirmNewPass)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.txtCurrentPass)
		Me.GroupBox1.Controls.Add(Me.txtNewPass)
		Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.ForeColor = System.Drawing.Color.White
		Me.GroupBox1.Location = New System.Drawing.Point(37, 214)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox1.Size = New System.Drawing.Size(481, 249)
		Me.GroupBox1.TabIndex = 9
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Change Password"
		'
		'PictureBox3
		'
		Me.PictureBox3.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.not_visible
		Me.PictureBox3.Location = New System.Drawing.Point(209, 197)
		Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(25, 18)
		Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox3.TabIndex = 13
		Me.PictureBox3.TabStop = False
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.not_visible
		Me.PictureBox2.Location = New System.Drawing.Point(209, 129)
		Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(25, 18)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox2.TabIndex = 12
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.not_visible
		Me.PictureBox1.Location = New System.Drawing.Point(209, 60)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(25, 18)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 11
		Me.PictureBox1.TabStop = False
		'
		'txtConfirmNewPass
		'
		Me.txtConfirmNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtConfirmNewPass.Location = New System.Drawing.Point(17, 191)
		Me.txtConfirmNewPass.Margin = New System.Windows.Forms.Padding(4)
		Me.txtConfirmNewPass.Name = "txtConfirmNewPass"
		Me.txtConfirmNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtConfirmNewPass.Size = New System.Drawing.Size(183, 29)
		Me.txtConfirmNewPass.TabIndex = 10
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(13, 168)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(205, 20)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Confirm New Password"
		'
		'btnCancel
		'
		Me.btnCancel.Location = New System.Drawing.Point(925, 464)
		Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(100, 28)
		Me.btnCancel.TabIndex = 10
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnConfirm
		'
		Me.btnConfirm.Location = New System.Drawing.Point(817, 464)
		Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4)
		Me.btnConfirm.Name = "btnConfirm"
		Me.btnConfirm.Size = New System.Drawing.Size(100, 28)
		Me.btnConfirm.TabIndex = 11
		Me.btnConfirm.Text = "Confirm"
		Me.btnConfirm.UseVisualStyleBackColor = True
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.Transparent
		Me.Panel1.Controls.Add(Me.Label6)
		Me.Panel1.Controls.Add(Me.GroupBox1)
		Me.Panel1.Location = New System.Drawing.Point(259, 16)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(537, 476)
		Me.Panel1.TabIndex = 12
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.White
		Me.Label6.Location = New System.Drawing.Point(44, 30)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(174, 32)
		Me.Label6.TabIndex = 0
		Me.Label6.Text = "Admin Profile"
		'
		'lblCurrentPass
		'
		Me.lblCurrentPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCurrentPass.ForeColor = System.Drawing.Color.Red
		Me.lblCurrentPass.Location = New System.Drawing.Point(248, 55)
		Me.lblCurrentPass.Name = "lblCurrentPass"
		Me.lblCurrentPass.Size = New System.Drawing.Size(195, 44)
		Me.lblCurrentPass.TabIndex = 14
		Me.lblCurrentPass.Text = "The current password not match"
		Me.lblCurrentPass.Visible = False
		'
		'lblNewPass
		'
		Me.lblNewPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNewPass.ForeColor = System.Drawing.Color.Red
		Me.lblNewPass.Location = New System.Drawing.Point(250, 179)
		Me.lblNewPass.Name = "lblNewPass"
		Me.lblNewPass.Size = New System.Drawing.Size(195, 43)
		Me.lblNewPass.TabIndex = 15
		Me.lblNewPass.Text = "The new password not match"
		Me.lblNewPass.Visible = False
		'
		'lblIsNull
		'
		Me.lblIsNull.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblIsNull.ForeColor = System.Drawing.Color.Red
		Me.lblIsNull.Location = New System.Drawing.Point(250, 124)
		Me.lblIsNull.Name = "lblIsNull"
		Me.lblIsNull.Size = New System.Drawing.Size(193, 41)
		Me.lblIsNull.TabIndex = 16
		Me.lblIsNull.Text = "The password cannot be blank"
		Me.lblIsNull.Visible = False
		'
		'UserControl_Profile
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.BAIT1083_Visual_Programming.My.Resources.Resources.bike_with_yellow_wall_min
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Controls.Add(Me.btnConfirm)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtID)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.Panel1)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "UserControl_Profile"
		Me.Size = New System.Drawing.Size(1067, 521)
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtName As TextBox
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtCurrentPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtConfirmNewPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents lblNewPass As Label
	Friend WithEvents lblCurrentPass As Label
	Friend WithEvents lblIsNull As Label
End Class
