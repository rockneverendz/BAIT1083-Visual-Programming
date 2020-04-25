<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_PatronDetails
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
        Me.SplitContainer_Checkout = New System.Windows.Forms.SplitContainer()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.Label_Course = New System.Windows.Forms.Label()
        Me.ComboBox_Course = New System.Windows.Forms.ComboBox()
        Me.Label_PhoneNo = New System.Windows.Forms.Label()
        Me.TextBox_PhoneNo = New System.Windows.Forms.TextBox()
        Me.Label_Email = New System.Windows.Forms.Label()
        Me.TextBox_Email = New System.Windows.Forms.TextBox()
        Me.Label_Address = New System.Windows.Forms.Label()
        Me.TextBox_Address = New System.Windows.Forms.TextBox()
        Me.Button_Update = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Panel_History = New System.Windows.Forms.Panel()
        Me.Label_Panel_History = New System.Windows.Forms.Label()
        Me.ListView_History = New System.Windows.Forms.ListView()
        Me.History_Chk_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.History_Copy_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.History_BookID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.History_Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.History_Issue_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.History_Due_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.History_ReturnID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.SplitContainer_Checkout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Checkout.Panel1.SuspendLayout()
        Me.SplitContainer_Checkout.Panel2.SuspendLayout()
        Me.SplitContainer_Checkout.SuspendLayout()
        Me.Panel_History.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer_Checkout
        '
        Me.SplitContainer_Checkout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Checkout.IsSplitterFixed = True
        Me.SplitContainer_Checkout.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Checkout.Name = "SplitContainer_Checkout"
        '
        'SplitContainer_Checkout.Panel1
        '
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Label_ID)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.TextBox_ID)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Label_Name)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.TextBox_Name)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Label_Course)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.ComboBox_Course)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Label_PhoneNo)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.TextBox_PhoneNo)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Label_Email)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.TextBox_Email)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Label_Address)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.TextBox_Address)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Button_Update)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Button_Cancel)
        Me.SplitContainer_Checkout.Panel1.Padding = New System.Windows.Forms.Padding(10)
        '
        'SplitContainer_Checkout.Panel2
        '
        Me.SplitContainer_Checkout.Panel2.Controls.Add(Me.Panel_History)
        Me.SplitContainer_Checkout.Size = New System.Drawing.Size(816, 490)
        Me.SplitContainer_Checkout.SplitterDistance = 272
        Me.SplitContainer_Checkout.TabIndex = 2
        '
        'Label_ID
        '
        Me.Label_ID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_ID.AutoSize = True
        Me.Label_ID.Location = New System.Drawing.Point(63, 18)
        Me.Label_ID.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(18, 13)
        Me.Label_ID.TabIndex = 0
        Me.Label_ID.Text = "ID"
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ID.Location = New System.Drawing.Point(91, 15)
        Me.TextBox_ID.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.ReadOnly = True
        Me.TextBox_ID.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_ID.TabIndex = 0
        '
        'Label_Name
        '
        Me.Label_Name.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Location = New System.Drawing.Point(46, 48)
        Me.Label_Name.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(35, 13)
        Me.Label_Name.TabIndex = 1
        Me.Label_Name.Text = "Name"
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Name.Location = New System.Drawing.Point(91, 45)
        Me.TextBox_Name.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_Name.TabIndex = 1
        '
        'Label_Course
        '
        Me.Label_Course.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Course.AutoSize = True
        Me.Label_Course.Location = New System.Drawing.Point(41, 78)
        Me.Label_Course.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Course.Name = "Label_Course"
        Me.Label_Course.Size = New System.Drawing.Size(40, 13)
        Me.Label_Course.TabIndex = 3
        Me.Label_Course.Text = "Course"
        '
        'ComboBox_Course
        '
        Me.ComboBox_Course.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Course.FormattingEnabled = True
        Me.ComboBox_Course.Location = New System.Drawing.Point(91, 75)
        Me.ComboBox_Course.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBox_Course.Name = "ComboBox_Course"
        Me.ComboBox_Course.Size = New System.Drawing.Size(166, 21)
        Me.ComboBox_Course.TabIndex = 3
        '
        'Label_PhoneNo
        '
        Me.Label_PhoneNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_PhoneNo.AutoSize = True
        Me.Label_PhoneNo.Location = New System.Drawing.Point(26, 109)
        Me.Label_PhoneNo.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_PhoneNo.Name = "Label_PhoneNo"
        Me.Label_PhoneNo.Size = New System.Drawing.Size(55, 13)
        Me.Label_PhoneNo.TabIndex = 12
        Me.Label_PhoneNo.Text = "Phone No"
        '
        'TextBox_PhoneNo
        '
        Me.TextBox_PhoneNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_PhoneNo.Location = New System.Drawing.Point(91, 106)
        Me.TextBox_PhoneNo.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_PhoneNo.Name = "TextBox_PhoneNo"
        Me.TextBox_PhoneNo.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_PhoneNo.TabIndex = 13
        '
        'Label_Email
        '
        Me.Label_Email.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Email.AutoSize = True
        Me.Label_Email.Location = New System.Drawing.Point(49, 139)
        Me.Label_Email.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Email.Name = "Label_Email"
        Me.Label_Email.Size = New System.Drawing.Size(32, 13)
        Me.Label_Email.TabIndex = 16
        Me.Label_Email.Text = "Email"
        '
        'TextBox_Email
        '
        Me.TextBox_Email.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Email.Location = New System.Drawing.Point(91, 136)
        Me.TextBox_Email.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Email.Name = "TextBox_Email"
        Me.TextBox_Email.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_Email.TabIndex = 17
        '
        'Label_Address
        '
        Me.Label_Address.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Address.AutoSize = True
        Me.Label_Address.Location = New System.Drawing.Point(36, 169)
        Me.Label_Address.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Address.Name = "Label_Address"
        Me.Label_Address.Size = New System.Drawing.Size(45, 13)
        Me.Label_Address.TabIndex = 14
        Me.Label_Address.Text = "Address"
        '
        'TextBox_Address
        '
        Me.TextBox_Address.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Address.Location = New System.Drawing.Point(91, 166)
        Me.TextBox_Address.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Address.Multiline = True
        Me.TextBox_Address.Name = "TextBox_Address"
        Me.TextBox_Address.Size = New System.Drawing.Size(166, 80)
        Me.TextBox_Address.TabIndex = 15
        '
        'Button_Update
        '
        Me.Button_Update.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Update.Location = New System.Drawing.Point(97, 452)
        Me.Button_Update.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Update.Name = "Button_Update"
        Me.Button_Update.Size = New System.Drawing.Size(75, 23)
        Me.Button_Update.TabIndex = 8
        Me.Button_Update.Text = "Update"
        Me.Button_Update.UseVisualStyleBackColor = True
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Cancel.Location = New System.Drawing.Point(182, 452)
        Me.Button_Cancel.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Button_Cancel.TabIndex = 9
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Panel_History
        '
        Me.Panel_History.AutoSize = True
        Me.Panel_History.Controls.Add(Me.Label_Panel_History)
        Me.Panel_History.Controls.Add(Me.ListView_History)
        Me.Panel_History.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_History.Location = New System.Drawing.Point(0, 0)
        Me.Panel_History.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_History.Name = "Panel_History"
        Me.Panel_History.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_History.Size = New System.Drawing.Size(540, 490)
        Me.Panel_History.TabIndex = 2
        '
        'Label_Panel_History
        '
        Me.Label_Panel_History.AutoSize = True
        Me.Label_Panel_History.Location = New System.Drawing.Point(15, 15)
        Me.Label_Panel_History.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Panel_History.Name = "Label_Panel_History"
        Me.Label_Panel_History.Size = New System.Drawing.Size(39, 13)
        Me.Label_Panel_History.TabIndex = 0
        Me.Label_Panel_History.Text = "History"
        '
        'ListView_History
        '
        Me.ListView_History.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_History.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.History_Chk_ID, Me.History_Copy_ID, Me.History_BookID, Me.History_Title, Me.History_Issue_Date, Me.History_Due_Date, Me.History_ReturnID})
        Me.ListView_History.GridLines = True
        Me.ListView_History.HideSelection = False
        Me.ListView_History.Location = New System.Drawing.Point(15, 38)
        Me.ListView_History.Margin = New System.Windows.Forms.Padding(5)
        Me.ListView_History.Name = "ListView_History"
        Me.ListView_History.Size = New System.Drawing.Size(510, 437)
        Me.ListView_History.TabIndex = 3
        Me.ListView_History.UseCompatibleStateImageBehavior = False
        Me.ListView_History.View = System.Windows.Forms.View.Details
        '
        'History_Chk_ID
        '
        Me.History_Chk_ID.Text = "Chk ID"
        '
        'History_Copy_ID
        '
        Me.History_Copy_ID.Text = "Copy ID"
        '
        'History_BookID
        '
        Me.History_BookID.Text = "Book ID"
        '
        'History_Title
        '
        Me.History_Title.Text = "Title"
        Me.History_Title.Width = 120
        '
        'History_Issue_Date
        '
        Me.History_Issue_Date.Text = "Issue Date"
        Me.History_Issue_Date.Width = 90
        '
        'History_Due_Date
        '
        Me.History_Due_Date.Text = "Due Date"
        Me.History_Due_Date.Width = 90
        '
        'History_ReturnID
        '
        Me.History_ReturnID.Text = "Return ID"
        '
        'UserControl_PatronDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer_Checkout)
        Me.Name = "UserControl_PatronDetails"
        Me.Size = New System.Drawing.Size(816, 490)
        Me.SplitContainer_Checkout.Panel1.ResumeLayout(False)
        Me.SplitContainer_Checkout.Panel1.PerformLayout()
        Me.SplitContainer_Checkout.Panel2.ResumeLayout(False)
        Me.SplitContainer_Checkout.Panel2.PerformLayout()
        CType(Me.SplitContainer_Checkout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Checkout.ResumeLayout(False)
        Me.Panel_History.ResumeLayout(False)
        Me.Panel_History.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer_Checkout As SplitContainer
    Friend WithEvents Label_ID As Label
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Label_Name As Label
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents Label_Course As Label
    Friend WithEvents ComboBox_Course As ComboBox
    Friend WithEvents Label_PhoneNo As Label
    Friend WithEvents TextBox_PhoneNo As TextBox
    Friend WithEvents Label_Email As Label
    Friend WithEvents TextBox_Email As TextBox
    Friend WithEvents Label_Address As Label
    Friend WithEvents TextBox_Address As TextBox
    Friend WithEvents Button_Update As Button
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Panel_History As Panel
    Friend WithEvents Label_Panel_History As Label
    Friend WithEvents ListView_History As ListView
    Friend WithEvents History_Copy_ID As ColumnHeader
    Friend WithEvents History_Chk_ID As ColumnHeader
    Friend WithEvents History_Issue_Date As ColumnHeader
    Friend WithEvents History_Due_Date As ColumnHeader
    Friend WithEvents History_ReturnID As ColumnHeader
    Friend WithEvents History_BookID As ColumnHeader
    Friend WithEvents History_Title As ColumnHeader
End Class
