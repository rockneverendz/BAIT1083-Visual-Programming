<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl_PatronList
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.SplitContainer_PatronList = New System.Windows.Forms.SplitContainer()
        Me.ListView_Patron = New System.Windows.Forms.ListView()
        Me.Patron_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Patron_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Patron_Course = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Patron_PhoneNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Patron_Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Patron_Email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.Label_Search_Message = New System.Windows.Forms.Label()
        Me.Button_Search = New System.Windows.Forms.Button()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.MenuStrip_Footer = New System.Windows.Forms.MenuStrip()
        Me.Footer_PatronList = New System.Windows.Forms.ToolStripButton()
        Me.Footer_Status = New System.Windows.Forms.ToolStripLabel()
        CType(Me.SplitContainer_PatronList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_PatronList.Panel1.SuspendLayout()
        Me.SplitContainer_PatronList.Panel2.SuspendLayout()
        Me.SplitContainer_PatronList.SuspendLayout()
        Me.MenuStrip_Footer.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer_PatronList
        '
        Me.SplitContainer_PatronList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_PatronList.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer_PatronList.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_PatronList.Name = "SplitContainer_PatronList"
        '
        'SplitContainer_PatronList.Panel1
        '
        Me.SplitContainer_PatronList.Panel1.Controls.Add(Me.ListView_Patron)
        '
        'SplitContainer_PatronList.Panel2
        '
        Me.SplitContainer_PatronList.Panel2.Controls.Add(Me.Label_ID)
        Me.SplitContainer_PatronList.Panel2.Controls.Add(Me.TextBox_ID)
        Me.SplitContainer_PatronList.Panel2.Controls.Add(Me.Label_Name)
        Me.SplitContainer_PatronList.Panel2.Controls.Add(Me.TextBox_Name)
        Me.SplitContainer_PatronList.Panel2.Controls.Add(Me.Label_Course)
        Me.SplitContainer_PatronList.Panel2.Controls.Add(Me.ComboBox_Course)
        Me.SplitContainer_PatronList.Panel2.Controls.Add(Me.Label_PhoneNo)
        Me.SplitContainer_PatronList.Panel2.Controls.Add(Me.TextBox_PhoneNo)
        Me.SplitContainer_PatronList.Panel2.Controls.Add(Me.Label_Email)
        Me.SplitContainer_PatronList.Panel2.Controls.Add(Me.TextBox_Email)
        Me.SplitContainer_PatronList.Panel2.Controls.Add(Me.Label_Address)
        Me.SplitContainer_PatronList.Panel2.Controls.Add(Me.TextBox_Address)
        Me.SplitContainer_PatronList.Panel2.Controls.Add(Me.Label_Search_Message)
        Me.SplitContainer_PatronList.Panel2.Controls.Add(Me.Button_Search)
        Me.SplitContainer_PatronList.Panel2.Controls.Add(Me.Button_Clear)
        Me.SplitContainer_PatronList.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.SplitContainer_PatronList.Panel2MinSize = 200
        Me.SplitContainer_PatronList.Size = New System.Drawing.Size(816, 462)
        Me.SplitContainer_PatronList.SplitterDistance = 612
        Me.SplitContainer_PatronList.TabIndex = 3
        '
        'ListView_Patron
        '
        Me.ListView_Patron.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Patron_ID, Me.Patron_Name, Me.Patron_Course, Me.Patron_PhoneNo, Me.Patron_Address, Me.Patron_Email})
        Me.ListView_Patron.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_Patron.FullRowSelect = True
        Me.ListView_Patron.GridLines = True
        Me.ListView_Patron.HideSelection = False
        Me.ListView_Patron.Location = New System.Drawing.Point(0, 0)
        Me.ListView_Patron.MultiSelect = False
        Me.ListView_Patron.Name = "ListView_Patron"
        Me.ListView_Patron.Size = New System.Drawing.Size(612, 462)
        Me.ListView_Patron.TabIndex = 0
        Me.ListView_Patron.UseCompatibleStateImageBehavior = False
        Me.ListView_Patron.View = System.Windows.Forms.View.Details
        '
        'Patron_ID
        '
        Me.Patron_ID.Text = "ID"
        '
        'Patron_Name
        '
        Me.Patron_Name.Text = "Name"
        Me.Patron_Name.Width = 240
        '
        'Patron_Course
        '
        Me.Patron_Course.Text = "Course"
        Me.Patron_Course.Width = 120
        '
        'Patron_PhoneNo
        '
        Me.Patron_PhoneNo.Text = "PhoneNo"
        Me.Patron_PhoneNo.Width = 120
        '
        'Patron_Address
        '
        Me.Patron_Address.Text = "Address"
        Me.Patron_Address.Width = 120
        '
        'Patron_Email
        '
        Me.Patron_Email.Text = "Email"
        Me.Patron_Email.Width = 120
        '
        'Label_ID
        '
        Me.Label_ID.AutoSize = True
        Me.Label_ID.Location = New System.Drawing.Point(57, 18)
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
        Me.TextBox_ID.Location = New System.Drawing.Point(85, 15)
        Me.TextBox_ID.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_ID.TabIndex = 0
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Location = New System.Drawing.Point(40, 48)
        Me.Label_Name.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(35, 13)
        Me.Label_Name.TabIndex = 2
        Me.Label_Name.Text = "Name"
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Name.Location = New System.Drawing.Point(85, 45)
        Me.TextBox_Name.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Name.TabIndex = 1
        '
        'Label_Course
        '
        Me.Label_Course.AutoSize = True
        Me.Label_Course.Location = New System.Drawing.Point(35, 78)
        Me.Label_Course.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Course.Name = "Label_Course"
        Me.Label_Course.Size = New System.Drawing.Size(40, 13)
        Me.Label_Course.TabIndex = 4
        Me.Label_Course.Text = "Course"
        '
        'ComboBox_Course
        '
        Me.ComboBox_Course.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Course.FormattingEnabled = True
        Me.ComboBox_Course.Location = New System.Drawing.Point(85, 75)
        Me.ComboBox_Course.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBox_Course.Name = "ComboBox_Course"
        Me.ComboBox_Course.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox_Course.TabIndex = 2
        '
        'Label_PhoneNo
        '
        Me.Label_PhoneNo.AutoSize = True
        Me.Label_PhoneNo.Location = New System.Drawing.Point(20, 109)
        Me.Label_PhoneNo.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_PhoneNo.Name = "Label_PhoneNo"
        Me.Label_PhoneNo.Size = New System.Drawing.Size(55, 13)
        Me.Label_PhoneNo.TabIndex = 6
        Me.Label_PhoneNo.Text = "Phone No"
        '
        'TextBox_PhoneNo
        '
        Me.TextBox_PhoneNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_PhoneNo.Location = New System.Drawing.Point(85, 106)
        Me.TextBox_PhoneNo.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_PhoneNo.Name = "TextBox_PhoneNo"
        Me.TextBox_PhoneNo.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_PhoneNo.TabIndex = 3
        '
        'Label_Email
        '
        Me.Label_Email.AutoSize = True
        Me.Label_Email.Location = New System.Drawing.Point(43, 139)
        Me.Label_Email.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Email.Name = "Label_Email"
        Me.Label_Email.Size = New System.Drawing.Size(32, 13)
        Me.Label_Email.TabIndex = 10
        Me.Label_Email.Text = "Email"
        '
        'TextBox_Email
        '
        Me.TextBox_Email.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Email.Location = New System.Drawing.Point(85, 136)
        Me.TextBox_Email.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Email.Name = "TextBox_Email"
        Me.TextBox_Email.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Email.TabIndex = 4
        '
        'Label_Address
        '
        Me.Label_Address.AutoSize = True
        Me.Label_Address.Location = New System.Drawing.Point(30, 169)
        Me.Label_Address.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Address.Name = "Label_Address"
        Me.Label_Address.Size = New System.Drawing.Size(45, 13)
        Me.Label_Address.TabIndex = 8
        Me.Label_Address.Text = "Address"
        '
        'TextBox_Address
        '
        Me.TextBox_Address.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Address.Location = New System.Drawing.Point(85, 166)
        Me.TextBox_Address.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Address.Multiline = True
        Me.TextBox_Address.Name = "TextBox_Address"
        Me.TextBox_Address.Size = New System.Drawing.Size(100, 80)
        Me.TextBox_Address.TabIndex = 5
        '
        'Label_Search_Message
        '
        Me.Label_Search_Message.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Search_Message.ForeColor = System.Drawing.Color.Red
        Me.Label_Search_Message.Location = New System.Drawing.Point(25, 391)
        Me.Label_Search_Message.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Search_Message.Name = "Label_Search_Message"
        Me.Label_Search_Message.Size = New System.Drawing.Size(160, 23)
        Me.Label_Search_Message.TabIndex = 27
        Me.Label_Search_Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_Search
        '
        Me.Button_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Search.Location = New System.Drawing.Point(25, 424)
        Me.Button_Search.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Search.Name = "Button_Search"
        Me.Button_Search.Size = New System.Drawing.Size(75, 23)
        Me.Button_Search.TabIndex = 6
        Me.Button_Search.Text = "Search"
        Me.Button_Search.UseVisualStyleBackColor = True
        '
        'Button_Clear
        '
        Me.Button_Clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Clear.Location = New System.Drawing.Point(110, 424)
        Me.Button_Clear.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 7
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'MenuStrip_Footer
        '
        Me.MenuStrip_Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip_Footer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Footer_PatronList, Me.Footer_Status})
        Me.MenuStrip_Footer.Location = New System.Drawing.Point(0, 462)
        Me.MenuStrip_Footer.Name = "MenuStrip_Footer"
        Me.MenuStrip_Footer.Size = New System.Drawing.Size(816, 27)
        Me.MenuStrip_Footer.TabIndex = 5
        Me.MenuStrip_Footer.Text = "MenuStrip1"
        '
        'Footer_PatronList
        '
        Me.Footer_PatronList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Footer_PatronList.AutoToolTip = False
        Me.Footer_PatronList.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_keyboard_arrow_right_black_18dp
        Me.Footer_PatronList.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.Footer_PatronList.Name = "Footer_PatronList"
        Me.Footer_PatronList.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Footer_PatronList.Size = New System.Drawing.Size(72, 20)
        Me.Footer_PatronList.Text = "Search"
        Me.Footer_PatronList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Footer_Status
        '
        Me.Footer_Status.Name = "Footer_Status"
        Me.Footer_Status.Size = New System.Drawing.Size(0, 20)
        '
        'UserControl_PatronList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.SplitContainer_PatronList)
        Me.Controls.Add(Me.MenuStrip_Footer)
        Me.Name = "UserControl_PatronList"
        Me.Size = New System.Drawing.Size(816, 489)
        Me.SplitContainer_PatronList.Panel1.ResumeLayout(False)
        Me.SplitContainer_PatronList.Panel2.ResumeLayout(False)
        Me.SplitContainer_PatronList.Panel2.PerformLayout()
        CType(Me.SplitContainer_PatronList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_PatronList.ResumeLayout(False)
        Me.MenuStrip_Footer.ResumeLayout(False)
        Me.MenuStrip_Footer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitContainer_PatronList As SplitContainer
    Friend WithEvents ListView_Patron As ListView
    Friend WithEvents Patron_ID As ColumnHeader
    Friend WithEvents Patron_Name As ColumnHeader
    Friend WithEvents Patron_Course As ColumnHeader
    Friend WithEvents Patron_PhoneNo As ColumnHeader
    Friend WithEvents Patron_Address As ColumnHeader
    Friend WithEvents Patron_Email As ColumnHeader
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Label_ID As Label
    Friend WithEvents MenuStrip_Footer As MenuStrip
    Friend WithEvents Footer_PatronList As ToolStripButton
    Friend WithEvents Footer_Status As ToolStripLabel
    Friend WithEvents Label_Name As Label
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents Label_Course As Label
    Friend WithEvents Label_PhoneNo As Label
    Friend WithEvents TextBox_PhoneNo As TextBox
    Friend WithEvents Label_Address As Label
    Friend WithEvents TextBox_Address As TextBox
    Friend WithEvents Label_Email As Label
    Friend WithEvents TextBox_Email As TextBox
    Friend WithEvents Button_Search As Button
    Friend WithEvents Button_Clear As Button
    Friend WithEvents ComboBox_Course As ComboBox
    Friend WithEvents Label_Search_Message As Label
End Class
