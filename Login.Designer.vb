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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label_Username = New System.Windows.Forms.Label()
        Me.Label_Password = New System.Windows.Forms.Label()
        Me.TextBox_Username = New System.Windows.Forms.TextBox()
        Me.TextBox_Passowrd = New System.Windows.Forms.TextBox()
        Me.Button_Login = New System.Windows.Forms.Button()
        Me.Panel_Login = New System.Windows.Forms.Panel()
        Me.Label_Message = New System.Windows.Forms.Label()
        Me.Panel_Login.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Username
        '
        Me.Label_Username.AutoSize = True
        Me.Label_Username.BackColor = System.Drawing.Color.Transparent
        Me.Label_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Username.ForeColor = System.Drawing.Color.White
        Me.Label_Username.Location = New System.Drawing.Point(15, 15)
        Me.Label_Username.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Label_Username.Name = "Label_Username"
        Me.Label_Username.Size = New System.Drawing.Size(102, 24)
        Me.Label_Username.TabIndex = 0
        Me.Label_Username.Text = "Username:"
        '
        'Label_Password
        '
        Me.Label_Password.AutoSize = True
        Me.Label_Password.BackColor = System.Drawing.Color.Transparent
        Me.Label_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Password.ForeColor = System.Drawing.Color.White
        Me.Label_Password.Location = New System.Drawing.Point(20, 49)
        Me.Label_Password.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Label_Password.Name = "Label_Password"
        Me.Label_Password.Size = New System.Drawing.Size(97, 24)
        Me.Label_Password.TabIndex = 1
        Me.Label_Password.Text = "Password:"
        '
        'TextBox_Username
        '
        Me.TextBox_Username.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Username.Location = New System.Drawing.Point(127, 16)
        Me.TextBox_Username.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TextBox_Username.Name = "TextBox_Username"
        Me.TextBox_Username.Size = New System.Drawing.Size(156, 24)
        Me.TextBox_Username.TabIndex = 2
        '
        'TextBox_Passowrd
        '
        Me.TextBox_Passowrd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Passowrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Passowrd.Location = New System.Drawing.Point(127, 50)
        Me.TextBox_Passowrd.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TextBox_Passowrd.Name = "TextBox_Passowrd"
        Me.TextBox_Passowrd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Passowrd.Size = New System.Drawing.Size(156, 24)
        Me.TextBox_Passowrd.TabIndex = 3
        Me.TextBox_Passowrd.UseSystemPasswordChar = True
        '
        'Button_Login
        '
        Me.Button_Login.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Login.Location = New System.Drawing.Point(127, 84)
        Me.Button_Login.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Button_Login.Name = "Button_Login"
        Me.Button_Login.Size = New System.Drawing.Size(96, 33)
        Me.Button_Login.TabIndex = 4
        Me.Button_Login.Text = "Login"
        Me.Button_Login.UseVisualStyleBackColor = True
        '
        'Panel_Login
        '
        Me.Panel_Login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel_Login.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Login.Controls.Add(Me.Label_Username)
        Me.Panel_Login.Controls.Add(Me.TextBox_Username)
        Me.Panel_Login.Controls.Add(Me.Label_Password)
        Me.Panel_Login.Controls.Add(Me.TextBox_Passowrd)
        Me.Panel_Login.Controls.Add(Me.Button_Login)
        Me.Panel_Login.Controls.Add(Me.Label_Message)
        Me.Panel_Login.Location = New System.Drawing.Point(194, 201)
        Me.Panel_Login.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Login.Name = "Panel_Login"
        Me.Panel_Login.Padding = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.Panel_Login.Size = New System.Drawing.Size(298, 152)
        Me.Panel_Login.TabIndex = 6
        '
        'Label_Message
        '
        Me.Label_Message.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Message.BackColor = System.Drawing.Color.Transparent
        Me.Label_Message.ForeColor = System.Drawing.Color.Red
        Me.Label_Message.Location = New System.Drawing.Point(15, 84)
        Me.Label_Message.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Label_Message.Name = "Label_Message"
        Me.Label_Message.Size = New System.Drawing.Size(102, 33)
        Me.Label_Message.TabIndex = 5
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BAIT1083_Visual_Programming.My.Resources.Resources.LibBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(690, 381)
        Me.Controls.Add(Me.Panel_Login)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Panel_Login.ResumeLayout(False)
        Me.Panel_Login.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_Username As Label
    Friend WithEvents Label_Password As Label
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents TextBox_Passowrd As TextBox
    Friend WithEvents Button_Login As Button
    Friend WithEvents Panel_Login As Panel
    Friend WithEvents Label_Message As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
