<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl_Checkout
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
        Me.SplitContainer_Checkout = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel_Input = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel_Patron = New System.Windows.Forms.Panel()
        Me.Label_Patron = New System.Windows.Forms.Label()
        Me.TextBox_PatronID = New System.Windows.Forms.TextBox()
        Me.Button_Search = New System.Windows.Forms.Button()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.Label_Course = New System.Windows.Forms.Label()
        Me.TextBox_Course = New System.Windows.Forms.TextBox()
        Me.Label_PhoneNo = New System.Windows.Forms.Label()
        Me.TextBox_PhoneNo = New System.Windows.Forms.TextBox()
        Me.Label_Address = New System.Windows.Forms.Label()
        Me.TextBox_Address = New System.Windows.Forms.TextBox()
        Me.Label_Email = New System.Windows.Forms.Label()
        Me.TextBox_Email = New System.Windows.Forms.TextBox()
        Me.Panel_Copy = New System.Windows.Forms.Panel()
        Me.Label_Copy = New System.Windows.Forms.Label()
        Me.TextBox_CopyID = New System.Windows.Forms.TextBox()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.TableLayoutPanel_CheckoutDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel_New = New System.Windows.Forms.Panel()
        Me.ListView_New = New System.Windows.Forms.ListView()
        Me.Label_New = New System.Windows.Forms.Label()
        Me.Panel_Confirmation = New System.Windows.Forms.Panel()
        Me.Label_Duration = New System.Windows.Forms.Label()
        Me.NumericUpDown_Weeks = New System.Windows.Forms.NumericUpDown()
        Me.Label_Weeks = New System.Windows.Forms.Label()
        Me.Label_DueDate = New System.Windows.Forms.Label()
        Me.TextBox_DueDate = New System.Windows.Forms.TextBox()
        Me.Button_Confirm = New System.Windows.Forms.Button()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Panel_Current = New System.Windows.Forms.Panel()
        Me.ListView_Current = New System.Windows.Forms.ListView()
        Me.Label_Current = New System.Windows.Forms.Label()
        Me.Label_Copy_Message = New System.Windows.Forms.Label()
        Me.Label_Patron_Message = New System.Windows.Forms.Label()
        Me.Checkout_CopyID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Checkout_Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Checkout_BookID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Checkout_BookTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Checkout_CallNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Current_CopyID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Current_ChkID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Current_IssueDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Current_DueDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.SplitContainer_Checkout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Checkout.Panel1.SuspendLayout()
        Me.SplitContainer_Checkout.Panel2.SuspendLayout()
        Me.SplitContainer_Checkout.SuspendLayout()
        Me.TableLayoutPanel_Input.SuspendLayout()
        Me.Panel_Patron.SuspendLayout()
        Me.Panel_Copy.SuspendLayout()
        Me.TableLayoutPanel_CheckoutDetails.SuspendLayout()
        Me.Panel_New.SuspendLayout()
        Me.Panel_Confirmation.SuspendLayout()
        CType(Me.NumericUpDown_Weeks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Current.SuspendLayout()
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
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.TableLayoutPanel_Input)
        '
        'SplitContainer_Checkout.Panel2
        '
        Me.SplitContainer_Checkout.Panel2.Controls.Add(Me.TableLayoutPanel_CheckoutDetails)
        Me.SplitContainer_Checkout.Size = New System.Drawing.Size(816, 490)
        Me.SplitContainer_Checkout.SplitterDistance = 272
        Me.SplitContainer_Checkout.TabIndex = 0
        '
        'TableLayoutPanel_Input
        '
        Me.TableLayoutPanel_Input.ColumnCount = 1
        Me.TableLayoutPanel_Input.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Input.Controls.Add(Me.Panel_Copy, 0, 0)
        Me.TableLayoutPanel_Input.Controls.Add(Me.Panel_Patron, 0, 1)
        Me.TableLayoutPanel_Input.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_Input.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_Input.Name = "TableLayoutPanel_Input"
        Me.TableLayoutPanel_Input.RowCount = 2
        Me.TableLayoutPanel_Input.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.TableLayoutPanel_Input.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.67!))
        Me.TableLayoutPanel_Input.Size = New System.Drawing.Size(272, 490)
        Me.TableLayoutPanel_Input.TabIndex = 24
        '
        'Panel_Patron
        '
        Me.Panel_Patron.Controls.Add(Me.Label_Patron)
        Me.Panel_Patron.Controls.Add(Me.TextBox_PatronID)
        Me.Panel_Patron.Controls.Add(Me.Label_Patron_Message)
        Me.Panel_Patron.Controls.Add(Me.Button_Search)
        Me.Panel_Patron.Controls.Add(Me.Label_ID)
        Me.Panel_Patron.Controls.Add(Me.TextBox_ID)
        Me.Panel_Patron.Controls.Add(Me.Label_Name)
        Me.Panel_Patron.Controls.Add(Me.TextBox_Name)
        Me.Panel_Patron.Controls.Add(Me.Label_Course)
        Me.Panel_Patron.Controls.Add(Me.TextBox_Course)
        Me.Panel_Patron.Controls.Add(Me.Label_PhoneNo)
        Me.Panel_Patron.Controls.Add(Me.TextBox_PhoneNo)
        Me.Panel_Patron.Controls.Add(Me.Label_Address)
        Me.Panel_Patron.Controls.Add(Me.TextBox_Address)
        Me.Panel_Patron.Controls.Add(Me.Label_Email)
        Me.Panel_Patron.Controls.Add(Me.TextBox_Email)
        Me.Panel_Patron.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Patron.Location = New System.Drawing.Point(0, 163)
        Me.Panel_Patron.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Patron.Name = "Panel_Patron"
        Me.Panel_Patron.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_Patron.Size = New System.Drawing.Size(272, 327)
        Me.Panel_Patron.TabIndex = 1
        '
        'Label_Patron
        '
        Me.Label_Patron.AutoSize = True
        Me.Label_Patron.Location = New System.Drawing.Point(15, 15)
        Me.Label_Patron.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Patron.Name = "Label_Patron"
        Me.Label_Patron.Size = New System.Drawing.Size(52, 13)
        Me.Label_Patron.TabIndex = 0
        Me.Label_Patron.Text = "Patron ID"
        '
        'TextBox_PatronID
        '
        Me.TextBox_PatronID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_PatronID.Location = New System.Drawing.Point(15, 38)
        Me.TextBox_PatronID.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_PatronID.Name = "TextBox_PatronID"
        Me.TextBox_PatronID.Size = New System.Drawing.Size(242, 20)
        Me.TextBox_PatronID.TabIndex = 0
        '
        'Button_Search
        '
        Me.Button_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Search.Location = New System.Drawing.Point(182, 68)
        Me.Button_Search.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Search.Name = "Button_Search"
        Me.Button_Search.Size = New System.Drawing.Size(75, 23)
        Me.Button_Search.TabIndex = 1
        Me.Button_Search.Text = "Search"
        Me.Button_Search.UseVisualStyleBackColor = True
        '
        'Label_ID
        '
        Me.Label_ID.AutoSize = True
        Me.Label_ID.Location = New System.Drawing.Point(52, 104)
        Me.Label_ID.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(18, 13)
        Me.Label_ID.TabIndex = 12
        Me.Label_ID.Text = "ID"
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ID.Location = New System.Drawing.Point(80, 101)
        Me.TextBox_ID.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.ReadOnly = True
        Me.TextBox_ID.Size = New System.Drawing.Size(177, 20)
        Me.TextBox_ID.TabIndex = 4
        Me.TextBox_ID.TabStop = False
        '
        'Label_Name
        '
        Me.Label_Name.AutoSize = True
        Me.Label_Name.Location = New System.Drawing.Point(35, 134)
        Me.Label_Name.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(35, 13)
        Me.Label_Name.TabIndex = 14
        Me.Label_Name.Text = "Name"
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Name.Location = New System.Drawing.Point(80, 131)
        Me.TextBox_Name.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.ReadOnly = True
        Me.TextBox_Name.Size = New System.Drawing.Size(177, 20)
        Me.TextBox_Name.TabIndex = 5
        Me.TextBox_Name.TabStop = False
        '
        'Label_Course
        '
        Me.Label_Course.AutoSize = True
        Me.Label_Course.Location = New System.Drawing.Point(30, 164)
        Me.Label_Course.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Course.Name = "Label_Course"
        Me.Label_Course.Size = New System.Drawing.Size(40, 13)
        Me.Label_Course.TabIndex = 16
        Me.Label_Course.Text = "Course"
        '
        'TextBox_Course
        '
        Me.TextBox_Course.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Course.Location = New System.Drawing.Point(80, 161)
        Me.TextBox_Course.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Course.Name = "TextBox_Course"
        Me.TextBox_Course.ReadOnly = True
        Me.TextBox_Course.Size = New System.Drawing.Size(177, 20)
        Me.TextBox_Course.TabIndex = 6
        Me.TextBox_Course.TabStop = False
        '
        'Label_PhoneNo
        '
        Me.Label_PhoneNo.AutoSize = True
        Me.Label_PhoneNo.Location = New System.Drawing.Point(15, 194)
        Me.Label_PhoneNo.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_PhoneNo.Name = "Label_PhoneNo"
        Me.Label_PhoneNo.Size = New System.Drawing.Size(55, 13)
        Me.Label_PhoneNo.TabIndex = 18
        Me.Label_PhoneNo.Text = "Phone No"
        '
        'TextBox_PhoneNo
        '
        Me.TextBox_PhoneNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_PhoneNo.Location = New System.Drawing.Point(80, 191)
        Me.TextBox_PhoneNo.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_PhoneNo.Name = "TextBox_PhoneNo"
        Me.TextBox_PhoneNo.ReadOnly = True
        Me.TextBox_PhoneNo.Size = New System.Drawing.Size(177, 20)
        Me.TextBox_PhoneNo.TabIndex = 7
        Me.TextBox_PhoneNo.TabStop = False
        '
        'Label_Address
        '
        Me.Label_Address.AutoSize = True
        Me.Label_Address.Location = New System.Drawing.Point(25, 224)
        Me.Label_Address.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Address.Name = "Label_Address"
        Me.Label_Address.Size = New System.Drawing.Size(45, 13)
        Me.Label_Address.TabIndex = 20
        Me.Label_Address.Text = "Address"
        '
        'TextBox_Address
        '
        Me.TextBox_Address.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Address.Location = New System.Drawing.Point(80, 221)
        Me.TextBox_Address.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Address.Name = "TextBox_Address"
        Me.TextBox_Address.ReadOnly = True
        Me.TextBox_Address.Size = New System.Drawing.Size(177, 20)
        Me.TextBox_Address.TabIndex = 8
        Me.TextBox_Address.TabStop = False
        '
        'Label_Email
        '
        Me.Label_Email.AutoSize = True
        Me.Label_Email.Location = New System.Drawing.Point(38, 254)
        Me.Label_Email.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Email.Name = "Label_Email"
        Me.Label_Email.Size = New System.Drawing.Size(32, 13)
        Me.Label_Email.TabIndex = 22
        Me.Label_Email.Text = "Email"
        '
        'TextBox_Email
        '
        Me.TextBox_Email.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Email.Location = New System.Drawing.Point(80, 251)
        Me.TextBox_Email.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Email.Name = "TextBox_Email"
        Me.TextBox_Email.ReadOnly = True
        Me.TextBox_Email.Size = New System.Drawing.Size(177, 20)
        Me.TextBox_Email.TabIndex = 9
        Me.TextBox_Email.TabStop = False
        '
        'Panel_Copy
        '
        Me.Panel_Copy.Controls.Add(Me.Label_Copy)
        Me.Panel_Copy.Controls.Add(Me.TextBox_CopyID)
        Me.Panel_Copy.Controls.Add(Me.Label_Copy_Message)
        Me.Panel_Copy.Controls.Add(Me.Button_Add)
        Me.Panel_Copy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Copy.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Copy.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Copy.Name = "Panel_Copy"
        Me.Panel_Copy.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_Copy.Size = New System.Drawing.Size(272, 163)
        Me.Panel_Copy.TabIndex = 0
        '
        'Label_Copy
        '
        Me.Label_Copy.AutoSize = True
        Me.Label_Copy.Location = New System.Drawing.Point(15, 15)
        Me.Label_Copy.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Copy.Name = "Label_Copy"
        Me.Label_Copy.Size = New System.Drawing.Size(45, 13)
        Me.Label_Copy.TabIndex = 24
        Me.Label_Copy.Text = "Copy ID"
        '
        'TextBox_CopyID
        '
        Me.TextBox_CopyID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_CopyID.Location = New System.Drawing.Point(15, 38)
        Me.TextBox_CopyID.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_CopyID.Name = "TextBox_CopyID"
        Me.TextBox_CopyID.Size = New System.Drawing.Size(242, 20)
        Me.TextBox_CopyID.TabIndex = 0
        '
        'Button_Add
        '
        Me.Button_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Add.Location = New System.Drawing.Point(182, 68)
        Me.Button_Add.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add.TabIndex = 1
        Me.Button_Add.Text = "Add"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_CheckoutDetails
        '
        Me.TableLayoutPanel_CheckoutDetails.AutoSize = True
        Me.TableLayoutPanel_CheckoutDetails.ColumnCount = 1
        Me.TableLayoutPanel_CheckoutDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_CheckoutDetails.Controls.Add(Me.Panel_New, 0, 0)
        Me.TableLayoutPanel_CheckoutDetails.Controls.Add(Me.Panel_Current, 0, 1)
        Me.TableLayoutPanel_CheckoutDetails.Controls.Add(Me.Panel_Confirmation, 0, 2)
        Me.TableLayoutPanel_CheckoutDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_CheckoutDetails.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_CheckoutDetails.Name = "TableLayoutPanel_CheckoutDetails"
        Me.TableLayoutPanel_CheckoutDetails.RowCount = 3
        Me.TableLayoutPanel_CheckoutDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3311!))
        Me.TableLayoutPanel_CheckoutDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33112!))
        Me.TableLayoutPanel_CheckoutDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33778!))
        Me.TableLayoutPanel_CheckoutDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel_CheckoutDetails.Size = New System.Drawing.Size(540, 490)
        Me.TableLayoutPanel_CheckoutDetails.TabIndex = 0
        '
        'Panel_New
        '
        Me.Panel_New.AutoSize = True
        Me.Panel_New.Controls.Add(Me.ListView_New)
        Me.Panel_New.Controls.Add(Me.Label_New)
        Me.Panel_New.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_New.Location = New System.Drawing.Point(0, 0)
        Me.Panel_New.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_New.Name = "Panel_New"
        Me.Panel_New.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_New.Size = New System.Drawing.Size(540, 163)
        Me.Panel_New.TabIndex = 0
        '
        'ListView_New
        '
        Me.ListView_New.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_New.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Checkout_CopyID, Me.Checkout_Status, Me.Checkout_BookID, Me.Checkout_BookTitle, Me.Checkout_CallNo})
        Me.ListView_New.HideSelection = False
        Me.ListView_New.Location = New System.Drawing.Point(15, 38)
        Me.ListView_New.Margin = New System.Windows.Forms.Padding(5)
        Me.ListView_New.Name = "ListView_New"
        Me.ListView_New.Size = New System.Drawing.Size(510, 110)
        Me.ListView_New.TabIndex = 4
        Me.ListView_New.TabStop = False
        Me.ListView_New.UseCompatibleStateImageBehavior = False
        Me.ListView_New.View = System.Windows.Forms.View.Details
        '
        'Label_New
        '
        Me.Label_New.AutoSize = True
        Me.Label_New.Location = New System.Drawing.Point(15, 15)
        Me.Label_New.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_New.Name = "Label_New"
        Me.Label_New.Size = New System.Drawing.Size(75, 13)
        Me.Label_New.TabIndex = 3
        Me.Label_New.Text = "Checkout Cart"
        '
        'Panel_Confirmation
        '
        Me.Panel_Confirmation.AutoSize = True
        Me.Panel_Confirmation.Controls.Add(Me.Label_Duration)
        Me.Panel_Confirmation.Controls.Add(Me.NumericUpDown_Weeks)
        Me.Panel_Confirmation.Controls.Add(Me.Label_Weeks)
        Me.Panel_Confirmation.Controls.Add(Me.Label_DueDate)
        Me.Panel_Confirmation.Controls.Add(Me.TextBox_DueDate)
        Me.Panel_Confirmation.Controls.Add(Me.Button_Confirm)
        Me.Panel_Confirmation.Controls.Add(Me.Button_Clear)
        Me.Panel_Confirmation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Confirmation.Location = New System.Drawing.Point(0, 326)
        Me.Panel_Confirmation.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Confirmation.Name = "Panel_Confirmation"
        Me.Panel_Confirmation.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_Confirmation.Size = New System.Drawing.Size(540, 164)
        Me.Panel_Confirmation.TabIndex = 2
        '
        'Label_Duration
        '
        Me.Label_Duration.AutoSize = True
        Me.Label_Duration.Location = New System.Drawing.Point(15, 15)
        Me.Label_Duration.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Duration.Name = "Label_Duration"
        Me.Label_Duration.Size = New System.Drawing.Size(83, 13)
        Me.Label_Duration.TabIndex = 0
        Me.Label_Duration.Text = "Borrow Duration"
        '
        'NumericUpDown_Weeks
        '
        Me.NumericUpDown_Weeks.Location = New System.Drawing.Point(15, 38)
        Me.NumericUpDown_Weeks.Margin = New System.Windows.Forms.Padding(5)
        Me.NumericUpDown_Weeks.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumericUpDown_Weeks.Name = "NumericUpDown_Weeks"
        Me.NumericUpDown_Weeks.Size = New System.Drawing.Size(37, 20)
        Me.NumericUpDown_Weeks.TabIndex = 0
        Me.NumericUpDown_Weeks.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label_Weeks
        '
        Me.Label_Weeks.AutoSize = True
        Me.Label_Weeks.Location = New System.Drawing.Point(62, 40)
        Me.Label_Weeks.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Weeks.Name = "Label_Weeks"
        Me.Label_Weeks.Size = New System.Drawing.Size(47, 13)
        Me.Label_Weeks.TabIndex = 7
        Me.Label_Weeks.Text = "Week(s)"
        '
        'Label_DueDate
        '
        Me.Label_DueDate.AutoSize = True
        Me.Label_DueDate.Location = New System.Drawing.Point(173, 15)
        Me.Label_DueDate.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_DueDate.Name = "Label_DueDate"
        Me.Label_DueDate.Size = New System.Drawing.Size(53, 13)
        Me.Label_DueDate.TabIndex = 3
        Me.Label_DueDate.Text = "Due Date"
        '
        'TextBox_DueDate
        '
        Me.TextBox_DueDate.Location = New System.Drawing.Point(176, 38)
        Me.TextBox_DueDate.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_DueDate.Name = "TextBox_DueDate"
        Me.TextBox_DueDate.ReadOnly = True
        Me.TextBox_DueDate.Size = New System.Drawing.Size(187, 20)
        Me.TextBox_DueDate.TabIndex = 8
        Me.TextBox_DueDate.TabStop = False
        '
        'Button_Confirm
        '
        Me.Button_Confirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Confirm.Location = New System.Drawing.Point(365, 126)
        Me.Button_Confirm.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Confirm.Name = "Button_Confirm"
        Me.Button_Confirm.Size = New System.Drawing.Size(75, 23)
        Me.Button_Confirm.TabIndex = 1
        Me.Button_Confirm.Text = "Borrow"
        Me.Button_Confirm.UseVisualStyleBackColor = True
        '
        'Button_Clear
        '
        Me.Button_Clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Clear.Location = New System.Drawing.Point(450, 126)
        Me.Button_Clear.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 2
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Panel_Current
        '
        Me.Panel_Current.Controls.Add(Me.Label_Current)
        Me.Panel_Current.Controls.Add(Me.ListView_Current)
        Me.Panel_Current.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Current.Location = New System.Drawing.Point(0, 163)
        Me.Panel_Current.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Current.Name = "Panel_Current"
        Me.Panel_Current.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_Current.Size = New System.Drawing.Size(540, 163)
        Me.Panel_Current.TabIndex = 1
        '
        'ListView_Current
        '
        Me.ListView_Current.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_Current.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Current_CopyID, Me.Current_ChkID, Me.Current_IssueDate, Me.Current_DueDate})
        Me.ListView_Current.HideSelection = False
        Me.ListView_Current.Location = New System.Drawing.Point(15, 38)
        Me.ListView_Current.Margin = New System.Windows.Forms.Padding(5)
        Me.ListView_Current.Name = "ListView_Current"
        Me.ListView_Current.Size = New System.Drawing.Size(510, 110)
        Me.ListView_Current.TabIndex = 3
        Me.ListView_Current.TabStop = False
        Me.ListView_Current.UseCompatibleStateImageBehavior = False
        Me.ListView_Current.View = System.Windows.Forms.View.Details
        '
        'Label_Current
        '
        Me.Label_Current.AutoSize = True
        Me.Label_Current.Location = New System.Drawing.Point(15, 15)
        Me.Label_Current.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Current.Name = "Label_Current"
        Me.Label_Current.Size = New System.Drawing.Size(123, 13)
        Me.Label_Current.TabIndex = 0
        Me.Label_Current.Text = "Parton Current Borrowed"
        '
        'Label_Copy_Message
        '
        Me.Label_Copy_Message.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Copy_Message.ForeColor = System.Drawing.Color.Red
        Me.Label_Copy_Message.Location = New System.Drawing.Point(15, 68)
        Me.Label_Copy_Message.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Copy_Message.Name = "Label_Copy_Message"
        Me.Label_Copy_Message.Size = New System.Drawing.Size(157, 23)
        Me.Label_Copy_Message.TabIndex = 25
        Me.Label_Copy_Message.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Patron_Message
        '
        Me.Label_Patron_Message.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Patron_Message.ForeColor = System.Drawing.Color.Red
        Me.Label_Patron_Message.Location = New System.Drawing.Point(15, 68)
        Me.Label_Patron_Message.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Patron_Message.Name = "Label_Patron_Message"
        Me.Label_Patron_Message.Size = New System.Drawing.Size(157, 23)
        Me.Label_Patron_Message.TabIndex = 26
        Me.Label_Patron_Message.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Checkout_CopyID
        '
        Me.Checkout_CopyID.Text = "Copy ID"
        '
        'Checkout_Status
        '
        Me.Checkout_Status.Text = "Status"
        Me.Checkout_Status.Width = 90
        '
        'Checkout_BookID
        '
        Me.Checkout_BookID.Text = "Book ID"
        '
        'Checkout_BookTitle
        '
        Me.Checkout_BookTitle.Text = "Book Title"
        Me.Checkout_BookTitle.Width = 180
        '
        'Checkout_CallNo
        '
        Me.Checkout_CallNo.Text = "Call No"
        Me.Checkout_CallNo.Width = 90
        '
        'Current_CopyID
        '
        Me.Current_CopyID.Text = "Copy ID"
        '
        'Current_ChkID
        '
        Me.Current_ChkID.Text = "Chk ID"
        '
        'Current_IssueDate
        '
        Me.Current_IssueDate.Text = "Issue Date"
        Me.Current_IssueDate.Width = 120
        '
        'Current_DueDate
        '
        Me.Current_DueDate.Text = "Due Date"
        Me.Current_DueDate.Width = 120
        '
        'UserControl_Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.SplitContainer_Checkout)
        Me.Name = "UserControl_Checkout"
        Me.Size = New System.Drawing.Size(816, 490)
        Me.SplitContainer_Checkout.Panel1.ResumeLayout(False)
        Me.SplitContainer_Checkout.Panel2.ResumeLayout(False)
        Me.SplitContainer_Checkout.Panel2.PerformLayout()
        CType(Me.SplitContainer_Checkout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Checkout.ResumeLayout(False)
        Me.TableLayoutPanel_Input.ResumeLayout(False)
        Me.Panel_Patron.ResumeLayout(False)
        Me.Panel_Patron.PerformLayout()
        Me.Panel_Copy.ResumeLayout(False)
        Me.Panel_Copy.PerformLayout()
        Me.TableLayoutPanel_CheckoutDetails.ResumeLayout(False)
        Me.TableLayoutPanel_CheckoutDetails.PerformLayout()
        Me.Panel_New.ResumeLayout(False)
        Me.Panel_New.PerformLayout()
        Me.Panel_Confirmation.ResumeLayout(False)
        Me.Panel_Confirmation.PerformLayout()
        CType(Me.NumericUpDown_Weeks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Current.ResumeLayout(False)
        Me.Panel_Current.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer_Checkout As SplitContainer
    Friend WithEvents TextBox_PatronID As TextBox
    Friend WithEvents Label_Patron As Label
    Friend WithEvents TableLayoutPanel_CheckoutDetails As TableLayoutPanel
    Friend WithEvents Panel_New As Panel
    Friend WithEvents Panel_Confirmation As Panel
    Friend WithEvents Label_Duration As Label
    Friend WithEvents Label_New As Label
    Friend WithEvents ListView_New As ListView
    Friend WithEvents Label_DueDate As Label
    Friend WithEvents Label_Weeks As Label
    Friend WithEvents NumericUpDown_Weeks As NumericUpDown
    Friend WithEvents Button_Confirm As Button
    Friend WithEvents Button_Clear As Button
    Friend WithEvents Button_Search As Button
    Friend WithEvents Label_ID As Label
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Label_Name As Label
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents Label_Course As Label
    Friend WithEvents TextBox_Course As TextBox
    Friend WithEvents Label_PhoneNo As Label
    Friend WithEvents TextBox_PhoneNo As TextBox
    Friend WithEvents Label_Address As Label
    Friend WithEvents TextBox_Address As TextBox
    Friend WithEvents Label_Email As Label
    Friend WithEvents TextBox_Email As TextBox
    Friend WithEvents TextBox_DueDate As TextBox
    Friend WithEvents TableLayoutPanel_Input As TableLayoutPanel
    Friend WithEvents Panel_Patron As Panel
    Friend WithEvents Panel_Copy As Panel
    Friend WithEvents Label_Copy As Label
    Friend WithEvents TextBox_CopyID As TextBox
    Friend WithEvents Button_Add As Button
    Friend WithEvents Panel_Current As Panel
    Friend WithEvents Label_Current As Label
    Friend WithEvents ListView_Current As ListView
    Friend WithEvents Label_Copy_Message As Label
    Friend WithEvents Label_Patron_Message As Label
    Friend WithEvents Checkout_CopyID As ColumnHeader
    Friend WithEvents Checkout_Status As ColumnHeader
    Friend WithEvents Checkout_BookID As ColumnHeader
    Friend WithEvents Checkout_BookTitle As ColumnHeader
    Friend WithEvents Checkout_CallNo As ColumnHeader
    Friend WithEvents Current_CopyID As ColumnHeader
    Friend WithEvents Current_ChkID As ColumnHeader
    Friend WithEvents Current_IssueDate As ColumnHeader
    Friend WithEvents Current_DueDate As ColumnHeader
End Class
