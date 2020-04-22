<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_NewBook
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
        Me.History_Due_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.History_Chk_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.History_Copy_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RadioButton_Select = New System.Windows.Forms.RadioButton()
        Me.RadioButton_All = New System.Windows.Forms.RadioButton()
        Me.Label_Panel_History = New System.Windows.Forms.Label()
        Me.ListView_History = New System.Windows.Forms.ListView()
        Me.History_Issue_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel_History = New System.Windows.Forms.Panel()
        Me.Label_Panel_Copies = New System.Windows.Forms.Label()
        Me.Panel_Copies = New System.Windows.Forms.Panel()
        Me.ListView_Copies = New System.Windows.Forms.ListView()
        Me.Copies_Copy_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Copies_Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Copies_Chk_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Copies_Due_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel_CheckoutDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.SplitContainer_Checkout = New System.Windows.Forms.SplitContainer()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.TextBox_Title = New System.Windows.Forms.TextBox()
        Me.Label_Author = New System.Windows.Forms.Label()
        Me.TextBox_Author = New System.Windows.Forms.TextBox()
        Me.Label_Category = New System.Windows.Forms.Label()
        Me.ComboBox_Category = New System.Windows.Forms.ComboBox()
        Me.Label_Publication = New System.Windows.Forms.Label()
        Me.TextBox_Publication = New System.Windows.Forms.TextBox()
        Me.Label_YearPublish = New System.Windows.Forms.Label()
        Me.NumericUpDown_YearPublish = New System.Windows.Forms.NumericUpDown()
        Me.Label_Copies = New System.Windows.Forms.Label()
        Me.NumericUpDown_Copies = New System.Windows.Forms.NumericUpDown()
        Me.Label_CallNo = New System.Windows.Forms.Label()
        Me.TextBox_CallNo = New System.Windows.Forms.TextBox()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Panel_History.SuspendLayout()
        Me.Panel_Copies.SuspendLayout()
        Me.TableLayoutPanel_CheckoutDetails.SuspendLayout()
        CType(Me.SplitContainer_Checkout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Checkout.Panel1.SuspendLayout()
        Me.SplitContainer_Checkout.Panel2.SuspendLayout()
        Me.SplitContainer_Checkout.SuspendLayout()
        CType(Me.NumericUpDown_YearPublish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Copies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'History_Due_Date
        '
        Me.History_Due_Date.Text = "Due Date"
        Me.History_Due_Date.Width = 120
        '
        'History_Chk_ID
        '
        Me.History_Chk_ID.Text = "ChkOut ID"
        Me.History_Chk_ID.Width = 90
        '
        'History_Copy_ID
        '
        Me.History_Copy_ID.Text = "Copy ID"
        '
        'RadioButton_Select
        '
        Me.RadioButton_Select.AutoSize = True
        Me.RadioButton_Select.Enabled = False
        Me.RadioButton_Select.Location = New System.Drawing.Point(456, 13)
        Me.RadioButton_Select.Margin = New System.Windows.Forms.Padding(5)
        Me.RadioButton_Select.Name = "RadioButton_Select"
        Me.RadioButton_Select.Size = New System.Drawing.Size(69, 17)
        Me.RadioButton_Select.TabIndex = 2
        Me.RadioButton_Select.TabStop = True
        Me.RadioButton_Select.Text = "Selection"
        Me.RadioButton_Select.UseVisualStyleBackColor = True
        '
        'RadioButton_All
        '
        Me.RadioButton_All.AutoSize = True
        Me.RadioButton_All.Enabled = False
        Me.RadioButton_All.Location = New System.Drawing.Point(410, 13)
        Me.RadioButton_All.Margin = New System.Windows.Forms.Padding(5)
        Me.RadioButton_All.Name = "RadioButton_All"
        Me.RadioButton_All.Size = New System.Drawing.Size(36, 17)
        Me.RadioButton_All.TabIndex = 1
        Me.RadioButton_All.TabStop = True
        Me.RadioButton_All.Text = "All"
        Me.RadioButton_All.UseVisualStyleBackColor = True
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
        Me.ListView_History.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.History_Copy_ID, Me.History_Chk_ID, Me.History_Issue_Date, Me.History_Due_Date})
        Me.ListView_History.Enabled = False
        Me.ListView_History.HideSelection = False
        Me.ListView_History.Location = New System.Drawing.Point(15, 38)
        Me.ListView_History.Margin = New System.Windows.Forms.Padding(5)
        Me.ListView_History.Name = "ListView_History"
        Me.ListView_History.Size = New System.Drawing.Size(510, 192)
        Me.ListView_History.TabIndex = 3
        Me.ListView_History.UseCompatibleStateImageBehavior = False
        Me.ListView_History.View = System.Windows.Forms.View.Details
        '
        'History_Issue_Date
        '
        Me.History_Issue_Date.Text = "Issue Date"
        Me.History_Issue_Date.Width = 120
        '
        'Panel_History
        '
        Me.Panel_History.AutoSize = True
        Me.Panel_History.Controls.Add(Me.RadioButton_Select)
        Me.Panel_History.Controls.Add(Me.RadioButton_All)
        Me.Panel_History.Controls.Add(Me.Label_Panel_History)
        Me.Panel_History.Controls.Add(Me.ListView_History)
        Me.Panel_History.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_History.Location = New System.Drawing.Point(0, 245)
        Me.Panel_History.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_History.Name = "Panel_History"
        Me.Panel_History.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_History.Size = New System.Drawing.Size(540, 245)
        Me.Panel_History.TabIndex = 1
        '
        'Label_Panel_Copies
        '
        Me.Label_Panel_Copies.AutoSize = True
        Me.Label_Panel_Copies.Location = New System.Drawing.Point(15, 15)
        Me.Label_Panel_Copies.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Panel_Copies.Name = "Label_Panel_Copies"
        Me.Label_Panel_Copies.Size = New System.Drawing.Size(39, 13)
        Me.Label_Panel_Copies.TabIndex = 0
        Me.Label_Panel_Copies.Text = "Copies"
        '
        'Panel_Copies
        '
        Me.Panel_Copies.AutoSize = True
        Me.Panel_Copies.Controls.Add(Me.Label_Panel_Copies)
        Me.Panel_Copies.Controls.Add(Me.ListView_Copies)
        Me.Panel_Copies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Copies.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Copies.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Copies.Name = "Panel_Copies"
        Me.Panel_Copies.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_Copies.Size = New System.Drawing.Size(540, 245)
        Me.Panel_Copies.TabIndex = 0
        '
        'ListView_Copies
        '
        Me.ListView_Copies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_Copies.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Copies_Copy_ID, Me.Copies_Status, Me.Copies_Chk_ID, Me.Copies_Due_Date})
        Me.ListView_Copies.Enabled = False
        Me.ListView_Copies.HideSelection = False
        Me.ListView_Copies.Location = New System.Drawing.Point(15, 38)
        Me.ListView_Copies.Margin = New System.Windows.Forms.Padding(5)
        Me.ListView_Copies.Name = "ListView_Copies"
        Me.ListView_Copies.Size = New System.Drawing.Size(510, 192)
        Me.ListView_Copies.TabIndex = 1
        Me.ListView_Copies.UseCompatibleStateImageBehavior = False
        Me.ListView_Copies.View = System.Windows.Forms.View.Details
        '
        'Copies_Copy_ID
        '
        Me.Copies_Copy_ID.Text = "Copy ID"
        '
        'Copies_Status
        '
        Me.Copies_Status.Text = "Status"
        Me.Copies_Status.Width = 120
        '
        'Copies_Chk_ID
        '
        Me.Copies_Chk_ID.Text = "Checkout ID"
        Me.Copies_Chk_ID.Width = 120
        '
        'Copies_Due_Date
        '
        Me.Copies_Due_Date.Text = "Due Date"
        Me.Copies_Due_Date.Width = 120
        '
        'TableLayoutPanel_CheckoutDetails
        '
        Me.TableLayoutPanel_CheckoutDetails.ColumnCount = 1
        Me.TableLayoutPanel_CheckoutDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_CheckoutDetails.Controls.Add(Me.Panel_Copies, 0, 0)
        Me.TableLayoutPanel_CheckoutDetails.Controls.Add(Me.Panel_History, 0, 1)
        Me.TableLayoutPanel_CheckoutDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_CheckoutDetails.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_CheckoutDetails.Name = "TableLayoutPanel_CheckoutDetails"
        Me.TableLayoutPanel_CheckoutDetails.RowCount = 2
        Me.TableLayoutPanel_CheckoutDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_CheckoutDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_CheckoutDetails.Size = New System.Drawing.Size(540, 490)
        Me.TableLayoutPanel_CheckoutDetails.TabIndex = 0
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
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Label_Title)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.TextBox_Title)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Label_Author)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.TextBox_Author)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Label_Category)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.ComboBox_Category)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Label_Publication)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.TextBox_Publication)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Label_YearPublish)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.NumericUpDown_YearPublish)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Label_Copies)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.NumericUpDown_Copies)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Label_CallNo)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.TextBox_CallNo)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Button_Add)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Button_Clear)
        Me.SplitContainer_Checkout.Panel1.Padding = New System.Windows.Forms.Padding(10)
        '
        'SplitContainer_Checkout.Panel2
        '
        Me.SplitContainer_Checkout.Panel2.Controls.Add(Me.TableLayoutPanel_CheckoutDetails)
        Me.SplitContainer_Checkout.Size = New System.Drawing.Size(816, 490)
        Me.SplitContainer_Checkout.SplitterDistance = 272
        Me.SplitContainer_Checkout.TabIndex = 0
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
        'Label_Title
        '
        Me.Label_Title.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Location = New System.Drawing.Point(54, 48)
        Me.Label_Title.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(27, 13)
        Me.Label_Title.TabIndex = 1
        Me.Label_Title.Text = "Title"
        '
        'TextBox_Title
        '
        Me.TextBox_Title.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Title.Location = New System.Drawing.Point(91, 45)
        Me.TextBox_Title.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Title.Name = "TextBox_Title"
        Me.TextBox_Title.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_Title.TabIndex = 1
        '
        'Label_Author
        '
        Me.Label_Author.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Author.AutoSize = True
        Me.Label_Author.Location = New System.Drawing.Point(43, 78)
        Me.Label_Author.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Author.Name = "Label_Author"
        Me.Label_Author.Size = New System.Drawing.Size(38, 13)
        Me.Label_Author.TabIndex = 2
        Me.Label_Author.Text = "Author"
        '
        'TextBox_Author
        '
        Me.TextBox_Author.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Author.Location = New System.Drawing.Point(91, 75)
        Me.TextBox_Author.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Author.Name = "TextBox_Author"
        Me.TextBox_Author.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_Author.TabIndex = 2
        '
        'Label_Category
        '
        Me.Label_Category.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Category.AutoSize = True
        Me.Label_Category.Location = New System.Drawing.Point(32, 108)
        Me.Label_Category.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Category.Name = "Label_Category"
        Me.Label_Category.Size = New System.Drawing.Size(49, 13)
        Me.Label_Category.TabIndex = 3
        Me.Label_Category.Text = "Category"
        '
        'ComboBox_Category
        '
        Me.ComboBox_Category.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Category.FormattingEnabled = True
        Me.ComboBox_Category.Location = New System.Drawing.Point(91, 105)
        Me.ComboBox_Category.Margin = New System.Windows.Forms.Padding(5)
        Me.ComboBox_Category.Name = "ComboBox_Category"
        Me.ComboBox_Category.Size = New System.Drawing.Size(166, 21)
        Me.ComboBox_Category.TabIndex = 3
        '
        'Label_Publication
        '
        Me.Label_Publication.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Publication.AutoSize = True
        Me.Label_Publication.Location = New System.Drawing.Point(22, 138)
        Me.Label_Publication.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Publication.Name = "Label_Publication"
        Me.Label_Publication.Size = New System.Drawing.Size(59, 13)
        Me.Label_Publication.TabIndex = 4
        Me.Label_Publication.Text = "Publication"
        '
        'TextBox_Publication
        '
        Me.TextBox_Publication.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Publication.Location = New System.Drawing.Point(91, 135)
        Me.TextBox_Publication.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_Publication.Name = "TextBox_Publication"
        Me.TextBox_Publication.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_Publication.TabIndex = 4
        '
        'Label_YearPublish
        '
        Me.Label_YearPublish.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_YearPublish.AutoSize = True
        Me.Label_YearPublish.Location = New System.Drawing.Point(15, 167)
        Me.Label_YearPublish.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_YearPublish.Name = "Label_YearPublish"
        Me.Label_YearPublish.Size = New System.Drawing.Size(66, 13)
        Me.Label_YearPublish.TabIndex = 5
        Me.Label_YearPublish.Text = "Year Publish"
        '
        'NumericUpDown_YearPublish
        '
        Me.NumericUpDown_YearPublish.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown_YearPublish.Location = New System.Drawing.Point(91, 165)
        Me.NumericUpDown_YearPublish.Margin = New System.Windows.Forms.Padding(5)
        Me.NumericUpDown_YearPublish.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.NumericUpDown_YearPublish.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown_YearPublish.Name = "NumericUpDown_YearPublish"
        Me.NumericUpDown_YearPublish.Size = New System.Drawing.Size(166, 20)
        Me.NumericUpDown_YearPublish.TabIndex = 5
        Me.NumericUpDown_YearPublish.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.NumericUpDown_YearPublish.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'Label_Copies
        '
        Me.Label_Copies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Copies.AutoSize = True
        Me.Label_Copies.Location = New System.Drawing.Point(42, 197)
        Me.Label_Copies.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Copies.Name = "Label_Copies"
        Me.Label_Copies.Size = New System.Drawing.Size(39, 13)
        Me.Label_Copies.TabIndex = 6
        Me.Label_Copies.Text = "Copies"
        '
        'NumericUpDown_Copies
        '
        Me.NumericUpDown_Copies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown_Copies.Location = New System.Drawing.Point(91, 195)
        Me.NumericUpDown_Copies.Margin = New System.Windows.Forms.Padding(5)
        Me.NumericUpDown_Copies.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NumericUpDown_Copies.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_Copies.Name = "NumericUpDown_Copies"
        Me.NumericUpDown_Copies.Size = New System.Drawing.Size(166, 20)
        Me.NumericUpDown_Copies.TabIndex = 6
        Me.NumericUpDown_Copies.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.NumericUpDown_Copies.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label_CallNo
        '
        Me.Label_CallNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_CallNo.AutoSize = True
        Me.Label_CallNo.Location = New System.Drawing.Point(39, 228)
        Me.Label_CallNo.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_CallNo.Name = "Label_CallNo"
        Me.Label_CallNo.Size = New System.Drawing.Size(42, 13)
        Me.Label_CallNo.TabIndex = 7
        Me.Label_CallNo.Text = "Call no."
        '
        'TextBox_CallNo
        '
        Me.TextBox_CallNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_CallNo.Location = New System.Drawing.Point(91, 225)
        Me.TextBox_CallNo.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_CallNo.MaxLength = 15
        Me.TextBox_CallNo.Name = "TextBox_CallNo"
        Me.TextBox_CallNo.Size = New System.Drawing.Size(166, 20)
        Me.TextBox_CallNo.TabIndex = 7
        '
        'Button_Add
        '
        Me.Button_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Add.Location = New System.Drawing.Point(97, 452)
        Me.Button_Add.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add.TabIndex = 8
        Me.Button_Add.Text = "Add"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Button_Clear
        '
        Me.Button_Clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Clear.Location = New System.Drawing.Point(182, 452)
        Me.Button_Clear.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 9
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'UserControl_NewBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer_Checkout)
        Me.Name = "UserControl_NewBook"
        Me.Size = New System.Drawing.Size(816, 490)
        Me.Panel_History.ResumeLayout(False)
        Me.Panel_History.PerformLayout()
        Me.Panel_Copies.ResumeLayout(False)
        Me.Panel_Copies.PerformLayout()
        Me.TableLayoutPanel_CheckoutDetails.ResumeLayout(False)
        Me.TableLayoutPanel_CheckoutDetails.PerformLayout()
        Me.SplitContainer_Checkout.Panel1.ResumeLayout(False)
        Me.SplitContainer_Checkout.Panel1.PerformLayout()
        Me.SplitContainer_Checkout.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Checkout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Checkout.ResumeLayout(False)
        CType(Me.NumericUpDown_YearPublish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Copies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents History_Due_Date As ColumnHeader
    Friend WithEvents History_Chk_ID As ColumnHeader
    Friend WithEvents History_Copy_ID As ColumnHeader
    Friend WithEvents RadioButton_Select As RadioButton
    Friend WithEvents RadioButton_All As RadioButton
    Friend WithEvents Label_Panel_History As Label
    Friend WithEvents ListView_History As ListView
    Friend WithEvents History_Issue_Date As ColumnHeader
    Friend WithEvents Panel_History As Panel
    Friend WithEvents Label_Panel_Copies As Label
    Friend WithEvents Panel_Copies As Panel
    Friend WithEvents TableLayoutPanel_CheckoutDetails As TableLayoutPanel
    Friend WithEvents SplitContainer_Checkout As SplitContainer
    Friend WithEvents NumericUpDown_Copies As NumericUpDown
    Friend WithEvents Label_ID As Label
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Label_Title As Label
    Friend WithEvents TextBox_Title As TextBox
    Friend WithEvents Label_Author As Label
    Friend WithEvents TextBox_Author As TextBox
    Friend WithEvents Label_Category As Label
    Friend WithEvents Label_Publication As Label
    Friend WithEvents TextBox_Publication As TextBox
    Friend WithEvents Label_YearPublish As Label
    Friend WithEvents Label_Copies As Label
    Friend WithEvents Label_CallNo As Label
    Friend WithEvents TextBox_CallNo As TextBox
    Friend WithEvents Button_Add As Button
    Friend WithEvents Button_Clear As Button
    Friend WithEvents NumericUpDown_YearPublish As NumericUpDown
    Friend WithEvents ComboBox_Category As ComboBox
    Friend WithEvents ListView_Copies As ListView
    Friend WithEvents Copies_Copy_ID As ColumnHeader
    Friend WithEvents Copies_Status As ColumnHeader
    Friend WithEvents Copies_Chk_ID As ColumnHeader
    Friend WithEvents Copies_Due_Date As ColumnHeader
End Class
