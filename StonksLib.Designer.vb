<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_StonksLib
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
        Me.SplitContainer_BookList = New System.Windows.Forms.SplitContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Author = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Publication = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Year_Publish = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Copies = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Call_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ISBN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TextBox_ISBN = New System.Windows.Forms.TextBox()
        Me.Label_ISBN = New System.Windows.Forms.Label()
        Me.TextBox_CallNo = New System.Windows.Forms.TextBox()
        Me.Label_CallNo = New System.Windows.Forms.Label()
        Me.TextBox_Copies = New System.Windows.Forms.TextBox()
        Me.Label_Copies = New System.Windows.Forms.Label()
        Me.TextBox_YearPublish = New System.Windows.Forms.TextBox()
        Me.Label_YearPublish = New System.Windows.Forms.Label()
        Me.TextBox_Publication = New System.Windows.Forms.TextBox()
        Me.Label_Publication = New System.Windows.Forms.Label()
        Me.TextBox_Category = New System.Windows.Forms.TextBox()
        Me.Label_Category = New System.Windows.Forms.Label()
        Me.TextBox_Author = New System.Windows.Forms.TextBox()
        Me.Label_Author = New System.Windows.Forms.Label()
        Me.TextBox_Title = New System.Windows.Forms.TextBox()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.ToolStrip_Footer = New System.Windows.Forms.ToolStrip()
        Me.ToolStrip_BookDetails = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_ProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStrip_Status = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip_Header = New System.Windows.Forms.ToolStrip()
        Me.ToolStrip_Book = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NewBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip_Checkout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_Return = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_Room = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_Patron = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NewPatronToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatronListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip_Librarian = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NewLibrarianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrarianListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip_Log = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_Profile = New System.Windows.Forms.ToolStripDropDownButton()
        CType(Me.SplitContainer_BookList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_BookList.Panel1.SuspendLayout()
        Me.SplitContainer_BookList.Panel2.SuspendLayout()
        Me.SplitContainer_BookList.SuspendLayout()
        Me.ToolStrip_Footer.SuspendLayout()
        Me.ToolStrip_Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer_BookList
        '
        Me.SplitContainer_BookList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_BookList.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer_BookList.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer_BookList.Name = "SplitContainer_BookList"
        '
        'SplitContainer_BookList.Panel1
        '
        Me.SplitContainer_BookList.Panel1.Controls.Add(Me.ListView1)
        '
        'SplitContainer_BookList.Panel2
        '
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.TextBox_ISBN)
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.Label_ISBN)
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.TextBox_CallNo)
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.Label_CallNo)
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.TextBox_Copies)
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.Label_Copies)
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.TextBox_YearPublish)
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.Label_YearPublish)
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.TextBox_Publication)
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.Label_Publication)
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.TextBox_Category)
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.Label_Category)
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.TextBox_Author)
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.Label_Author)
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.TextBox_Title)
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.Label_Title)
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.TextBox_ID)
        Me.SplitContainer_BookList.Panel2.Controls.Add(Me.Label_ID)
        Me.SplitContainer_BookList.Panel2MinSize = 200
        Me.SplitContainer_BookList.Size = New System.Drawing.Size(800, 400)
        Me.SplitContainer_BookList.SplitterDistance = 595
        Me.SplitContainer_BookList.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Title, Me.Author, Me.Category, Me.Publication, Me.Year_Publish, Me.Copies, Me.Call_no, Me.ISBN})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(595, 400)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'Title
        '
        Me.Title.Text = "Title"
        Me.Title.Width = 240
        '
        'Author
        '
        Me.Author.Text = "Author"
        Me.Author.Width = 120
        '
        'Category
        '
        Me.Category.Text = "Category"
        Me.Category.Width = 120
        '
        'Publication
        '
        Me.Publication.Text = "Publication"
        Me.Publication.Width = 120
        '
        'Year_Publish
        '
        Me.Year_Publish.Text = "Year Publish"
        Me.Year_Publish.Width = 120
        '
        'Copies
        '
        Me.Copies.Text = "Copies"
        '
        'Call_no
        '
        Me.Call_no.Text = "Call number"
        Me.Call_no.Width = 90
        '
        'ISBN
        '
        Me.ISBN.Text = "ISBN"
        Me.ISBN.Width = 120
        '
        'TextBox_ISBN
        '
        Me.TextBox_ISBN.Enabled = False
        Me.TextBox_ISBN.Location = New System.Drawing.Point(87, 214)
        Me.TextBox_ISBN.Name = "TextBox_ISBN"
        Me.TextBox_ISBN.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_ISBN.TabIndex = 17
        '
        'Label_ISBN
        '
        Me.Label_ISBN.AutoSize = True
        Me.Label_ISBN.Location = New System.Drawing.Point(42, 217)
        Me.Label_ISBN.Name = "Label_ISBN"
        Me.Label_ISBN.Size = New System.Drawing.Size(32, 13)
        Me.Label_ISBN.TabIndex = 16
        Me.Label_ISBN.Text = "ISBN"
        '
        'TextBox_CallNo
        '
        Me.TextBox_CallNo.Enabled = False
        Me.TextBox_CallNo.Location = New System.Drawing.Point(87, 188)
        Me.TextBox_CallNo.Name = "TextBox_CallNo"
        Me.TextBox_CallNo.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_CallNo.TabIndex = 15
        '
        'Label_CallNo
        '
        Me.Label_CallNo.AutoSize = True
        Me.Label_CallNo.Location = New System.Drawing.Point(32, 191)
        Me.Label_CallNo.Name = "Label_CallNo"
        Me.Label_CallNo.Size = New System.Drawing.Size(42, 13)
        Me.Label_CallNo.TabIndex = 14
        Me.Label_CallNo.Text = "Call no."
        '
        'TextBox_Copies
        '
        Me.TextBox_Copies.Enabled = False
        Me.TextBox_Copies.Location = New System.Drawing.Point(87, 162)
        Me.TextBox_Copies.Name = "TextBox_Copies"
        Me.TextBox_Copies.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Copies.TabIndex = 13
        '
        'Label_Copies
        '
        Me.Label_Copies.AutoSize = True
        Me.Label_Copies.Location = New System.Drawing.Point(35, 165)
        Me.Label_Copies.Name = "Label_Copies"
        Me.Label_Copies.Size = New System.Drawing.Size(39, 13)
        Me.Label_Copies.TabIndex = 12
        Me.Label_Copies.Text = "Copies"
        '
        'TextBox_YearPublish
        '
        Me.TextBox_YearPublish.Location = New System.Drawing.Point(87, 136)
        Me.TextBox_YearPublish.Name = "TextBox_YearPublish"
        Me.TextBox_YearPublish.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_YearPublish.TabIndex = 11
        '
        'Label_YearPublish
        '
        Me.Label_YearPublish.AutoSize = True
        Me.Label_YearPublish.Location = New System.Drawing.Point(8, 139)
        Me.Label_YearPublish.Name = "Label_YearPublish"
        Me.Label_YearPublish.Size = New System.Drawing.Size(66, 13)
        Me.Label_YearPublish.TabIndex = 10
        Me.Label_YearPublish.Text = "Year Publish"
        '
        'TextBox_Publication
        '
        Me.TextBox_Publication.Location = New System.Drawing.Point(87, 110)
        Me.TextBox_Publication.Name = "TextBox_Publication"
        Me.TextBox_Publication.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Publication.TabIndex = 9
        '
        'Label_Publication
        '
        Me.Label_Publication.AutoSize = True
        Me.Label_Publication.Location = New System.Drawing.Point(15, 113)
        Me.Label_Publication.Name = "Label_Publication"
        Me.Label_Publication.Size = New System.Drawing.Size(59, 13)
        Me.Label_Publication.TabIndex = 8
        Me.Label_Publication.Text = "Publication"
        '
        'TextBox_Category
        '
        Me.TextBox_Category.Location = New System.Drawing.Point(87, 84)
        Me.TextBox_Category.Name = "TextBox_Category"
        Me.TextBox_Category.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Category.TabIndex = 7
        '
        'Label_Category
        '
        Me.Label_Category.AutoSize = True
        Me.Label_Category.Location = New System.Drawing.Point(25, 87)
        Me.Label_Category.Name = "Label_Category"
        Me.Label_Category.Size = New System.Drawing.Size(49, 13)
        Me.Label_Category.TabIndex = 6
        Me.Label_Category.Text = "Category"
        '
        'TextBox_Author
        '
        Me.TextBox_Author.Location = New System.Drawing.Point(87, 58)
        Me.TextBox_Author.Name = "TextBox_Author"
        Me.TextBox_Author.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Author.TabIndex = 5
        '
        'Label_Author
        '
        Me.Label_Author.AutoSize = True
        Me.Label_Author.Location = New System.Drawing.Point(36, 61)
        Me.Label_Author.Name = "Label_Author"
        Me.Label_Author.Size = New System.Drawing.Size(38, 13)
        Me.Label_Author.TabIndex = 4
        Me.Label_Author.Text = "Author"
        '
        'TextBox_Title
        '
        Me.TextBox_Title.Location = New System.Drawing.Point(87, 32)
        Me.TextBox_Title.Name = "TextBox_Title"
        Me.TextBox_Title.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Title.TabIndex = 3
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Location = New System.Drawing.Point(47, 35)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(27, 13)
        Me.Label_Title.TabIndex = 2
        Me.Label_Title.Text = "Title"
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Enabled = False
        Me.TextBox_ID.Location = New System.Drawing.Point(87, 6)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_ID.TabIndex = 1
        '
        'Label_ID
        '
        Me.Label_ID.AutoSize = True
        Me.Label_ID.Location = New System.Drawing.Point(56, 9)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(18, 13)
        Me.Label_ID.TabIndex = 0
        Me.Label_ID.Text = "ID"
        '
        'ToolStrip_Footer
        '
        Me.ToolStrip_Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip_Footer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip_Footer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrip_BookDetails, Me.ToolStrip_ProgressBar, Me.ToolStrip_Status})
        Me.ToolStrip_Footer.Location = New System.Drawing.Point(0, 425)
        Me.ToolStrip_Footer.Name = "ToolStrip_Footer"
        Me.ToolStrip_Footer.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip_Footer.TabIndex = 3
        Me.ToolStrip_Footer.Text = "ToolStrip1"
        '
        'ToolStrip_BookDetails
        '
        Me.ToolStrip_BookDetails.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStrip_BookDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStrip_BookDetails.Name = "ToolStrip_BookDetails"
        Me.ToolStrip_BookDetails.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStrip_BookDetails.Size = New System.Drawing.Size(96, 22)
        Me.ToolStrip_BookDetails.Text = "Book Details"
        '
        'ToolStrip_ProgressBar
        '
        Me.ToolStrip_ProgressBar.AutoSize = False
        Me.ToolStrip_ProgressBar.Name = "ToolStrip_ProgressBar"
        Me.ToolStrip_ProgressBar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStrip_ProgressBar.Size = New System.Drawing.Size(100, 15)
        '
        'ToolStrip_Status
        '
        Me.ToolStrip_Status.Name = "ToolStrip_Status"
        Me.ToolStrip_Status.Size = New System.Drawing.Size(39, 22)
        Me.ToolStrip_Status.Text = "Status"
        '
        'ToolStrip_Header
        '
        Me.ToolStrip_Header.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip_Header.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrip_Book, Me.ToolStrip_Checkout, Me.ToolStrip_Return, Me.ToolStrip_Room, Me.ToolStrip_Patron, Me.ToolStrip_Librarian, Me.ToolStrip_Log, Me.ToolStrip_Profile})
        Me.ToolStrip_Header.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_Header.Name = "ToolStrip_Header"
        Me.ToolStrip_Header.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip_Header.TabIndex = 4
        Me.ToolStrip_Header.Text = "ToolStrip1"
        '
        'ToolStrip_Book
        '
        Me.ToolStrip_Book.AutoToolTip = False
        Me.ToolStrip_Book.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewBookToolStripMenuItem, Me.BookListToolStripMenuItem})
        Me.ToolStrip_Book.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.agenda_with_bookmark
        Me.ToolStrip_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStrip_Book.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.ToolStrip_Book.Name = "ToolStrip_Book"
        Me.ToolStrip_Book.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStrip_Book.Size = New System.Drawing.Size(73, 22)
        Me.ToolStrip_Book.Text = "&Book"
        '
        'NewBookToolStripMenuItem
        '
        Me.NewBookToolStripMenuItem.Name = "NewBookToolStripMenuItem"
        Me.NewBookToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.NewBookToolStripMenuItem.Text = "New Book"
        '
        'BookListToolStripMenuItem
        '
        Me.BookListToolStripMenuItem.Name = "BookListToolStripMenuItem"
        Me.BookListToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.BookListToolStripMenuItem.Text = "Book List"
        '
        'ToolStrip_Checkout
        '
        Me.ToolStrip_Checkout.AutoToolTip = False
        Me.ToolStrip_Checkout.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.move_folder
        Me.ToolStrip_Checkout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStrip_Checkout.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.ToolStrip_Checkout.Name = "ToolStrip_Checkout"
        Me.ToolStrip_Checkout.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStrip_Checkout.Size = New System.Drawing.Size(88, 22)
        Me.ToolStrip_Checkout.Text = "&Checkout"
        '
        'ToolStrip_Return
        '
        Me.ToolStrip_Return.AutoToolTip = False
        Me.ToolStrip_Return.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.move_folder_reflected
        Me.ToolStrip_Return.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStrip_Return.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.ToolStrip_Return.Name = "ToolStrip_Return"
        Me.ToolStrip_Return.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStrip_Return.Size = New System.Drawing.Size(72, 22)
        Me.ToolStrip_Return.Text = "&Return"
        '
        'ToolStrip_Room
        '
        Me.ToolStrip_Room.AutoToolTip = False
        Me.ToolStrip_Room.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.cube_design
        Me.ToolStrip_Room.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStrip_Room.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.ToolStrip_Room.Name = "ToolStrip_Room"
        Me.ToolStrip_Room.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStrip_Room.Size = New System.Drawing.Size(69, 22)
        Me.ToolStrip_Room.Text = "R&oom"
        '
        'ToolStrip_Patron
        '
        Me.ToolStrip_Patron.AutoToolTip = False
        Me.ToolStrip_Patron.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewPatronToolStripMenuItem, Me.PatronListToolStripMenuItem})
        Me.ToolStrip_Patron.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.user_profile_in_a_square
        Me.ToolStrip_Patron.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStrip_Patron.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.ToolStrip_Patron.Name = "ToolStrip_Patron"
        Me.ToolStrip_Patron.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStrip_Patron.Size = New System.Drawing.Size(81, 22)
        Me.ToolStrip_Patron.Text = "&Patron"
        '
        'NewPatronToolStripMenuItem
        '
        Me.NewPatronToolStripMenuItem.Name = "NewPatronToolStripMenuItem"
        Me.NewPatronToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.NewPatronToolStripMenuItem.Text = "New Patron"
        '
        'PatronListToolStripMenuItem
        '
        Me.PatronListToolStripMenuItem.Name = "PatronListToolStripMenuItem"
        Me.PatronListToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.PatronListToolStripMenuItem.Text = "Patron List"
        '
        'ToolStrip_Librarian
        '
        Me.ToolStrip_Librarian.AutoToolTip = False
        Me.ToolStrip_Librarian.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewLibrarianToolStripMenuItem, Me.LibrarianListToolStripMenuItem})
        Me.ToolStrip_Librarian.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.vintage_reading_glasses
        Me.ToolStrip_Librarian.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStrip_Librarian.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.ToolStrip_Librarian.Name = "ToolStrip_Librarian"
        Me.ToolStrip_Librarian.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStrip_Librarian.Size = New System.Drawing.Size(92, 22)
        Me.ToolStrip_Librarian.Text = "&Librarian"
        '
        'NewLibrarianToolStripMenuItem
        '
        Me.NewLibrarianToolStripMenuItem.Name = "NewLibrarianToolStripMenuItem"
        Me.NewLibrarianToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.NewLibrarianToolStripMenuItem.Text = "New Librarian"
        '
        'LibrarianListToolStripMenuItem
        '
        Me.LibrarianListToolStripMenuItem.Name = "LibrarianListToolStripMenuItem"
        Me.LibrarianListToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.LibrarianListToolStripMenuItem.Text = "Librarian List"
        '
        'ToolStrip_Log
        '
        Me.ToolStrip_Log.AutoToolTip = False
        Me.ToolStrip_Log.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.empty_paper
        Me.ToolStrip_Log.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStrip_Log.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.ToolStrip_Log.Name = "ToolStrip_Log"
        Me.ToolStrip_Log.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStrip_Log.Size = New System.Drawing.Size(57, 22)
        Me.ToolStrip_Log.Text = "Lo&g"
        '
        'ToolStrip_Profile
        '
        Me.ToolStrip_Profile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStrip_Profile.AutoToolTip = False
        Me.ToolStrip_Profile.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.dart_board
        Me.ToolStrip_Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStrip_Profile.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.ToolStrip_Profile.Name = "ToolStrip_Profile"
        Me.ToolStrip_Profile.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStrip_Profile.Size = New System.Drawing.Size(80, 22)
        Me.ToolStrip_Profile.Text = "Pro&file"
        '
        'Form_StonksLib
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer_BookList)
        Me.Controls.Add(Me.ToolStrip_Footer)
        Me.Controls.Add(Me.ToolStrip_Header)
        Me.Name = "Form_StonksLib"
        Me.Text = "StonksLib"
        Me.SplitContainer_BookList.Panel1.ResumeLayout(False)
        Me.SplitContainer_BookList.Panel2.ResumeLayout(False)
        Me.SplitContainer_BookList.Panel2.PerformLayout()
        CType(Me.SplitContainer_BookList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_BookList.ResumeLayout(False)
        Me.ToolStrip_Footer.ResumeLayout(False)
        Me.ToolStrip_Footer.PerformLayout()
        Me.ToolStrip_Header.ResumeLayout(False)
        Me.ToolStrip_Header.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer_BookList As SplitContainer
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Title As ColumnHeader
    Friend WithEvents Author As ColumnHeader
    Friend WithEvents ISBN As ColumnHeader
    Friend WithEvents Copies As ColumnHeader
    Friend WithEvents ToolStrip_Footer As ToolStrip
    Friend WithEvents ToolStrip_BookDetails As ToolStripButton
    Friend WithEvents ToolStrip_ProgressBar As ToolStripProgressBar
    Friend WithEvents ToolStrip_Status As ToolStripLabel
    Friend WithEvents Label_ID As Label
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents TextBox_Publication As TextBox
    Friend WithEvents Label_Publication As Label
    Friend WithEvents TextBox_Category As TextBox
    Friend WithEvents Label_Category As Label
    Friend WithEvents TextBox_Author As TextBox
    Friend WithEvents Label_Author As Label
    Friend WithEvents TextBox_Title As TextBox
    Friend WithEvents Label_Title As Label
    Friend WithEvents TextBox_ISBN As TextBox
    Friend WithEvents Label_ISBN As Label
    Friend WithEvents TextBox_CallNo As TextBox
    Friend WithEvents Label_CallNo As Label
    Friend WithEvents TextBox_Copies As TextBox
    Friend WithEvents Label_Copies As Label
    Friend WithEvents TextBox_YearPublish As TextBox
    Friend WithEvents Label_YearPublish As Label
    Friend WithEvents Category As ColumnHeader
    Friend WithEvents Publication As ColumnHeader
    Friend WithEvents Year_Publish As ColumnHeader
    Friend WithEvents Call_no As ColumnHeader
    Friend WithEvents ToolStrip_Header As ToolStrip
    Friend WithEvents ToolStrip_Book As ToolStripDropDownButton
    Friend WithEvents NewBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip_Checkout As ToolStripButton
    Friend WithEvents ToolStrip_Return As ToolStripButton
    Friend WithEvents ToolStrip_Room As ToolStripButton
    Friend WithEvents ToolStrip_Patron As ToolStripDropDownButton
    Friend WithEvents NewPatronToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatronListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip_Librarian As ToolStripDropDownButton
    Friend WithEvents NewLibrarianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrarianListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip_Log As ToolStripButton
    Friend WithEvents ToolStrip_Profile As ToolStripDropDownButton
End Class
