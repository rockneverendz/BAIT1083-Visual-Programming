<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtUsername = New System.Windows.Forms.TextBox()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.lblMessage = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(60, 63)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(81, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Username: "
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(64, 109)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(77, 17)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Password: "
		'
		'txtUsername
		'
		Me.txtUsername.Location = New System.Drawing.Point(139, 62)
		Me.txtUsername.Name = "txtUsername"
		Me.txtUsername.Size = New System.Drawing.Size(100, 22)
		Me.txtUsername.TabIndex = 2
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(139, 108)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(100, 22)
		Me.txtPassword.TabIndex = 3
		Me.txtPassword.UseSystemPasswordChar = True
		'
		'btnLogin
		'
		Me.btnLogin.Location = New System.Drawing.Point(164, 155)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(75, 31)
		Me.btnLogin.TabIndex = 4
		Me.btnLogin.Text = "Login"
		Me.btnLogin.UseVisualStyleBackColor = True
		'
		'lblMessage
		'
		Me.lblMessage.AutoSize = True
		Me.lblMessage.Location = New System.Drawing.Point(89, 213)
		Me.lblMessage.Name = "lblMessage"
		Me.lblMessage.Size = New System.Drawing.Size(0, 17)
		Me.lblMessage.TabIndex = 5
		'
		'Login
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(310, 280)
		Me.Controls.Add(Me.lblMessage)
		Me.Controls.Add(Me.btnLogin)
		Me.Controls.Add(Me.txtPassword)
		Me.Controls.Add(Me.txtUsername)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Login"
		Me.Text = "Login"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents txtUsername As TextBox
	Friend WithEvents txtPassword As TextBox
	Friend WithEvents btnLogin As Button
	Friend WithEvents lblMessage As Label
End Class
