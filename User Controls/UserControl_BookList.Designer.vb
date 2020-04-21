<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl_BookList
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
        Me.MenuStrip_Footer = New System.Windows.Forms.MenuStrip()
        Me.Footer_BookDetails = New System.Windows.Forms.ToolStripButton()
        Me.Footer_ProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.Footer_Status = New System.Windows.Forms.ToolStripLabel()
        CType(Me.SplitContainer_BookList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_BookList.Panel1.SuspendLayout()
        Me.SplitContainer_BookList.Panel2.SuspendLayout()
        Me.SplitContainer_BookList.SuspendLayout()
        Me.MenuStrip_Footer.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer_BookList
        '
        Me.SplitContainer_BookList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_BookList.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer_BookList.IsSplitterFixed = True
        Me.SplitContainer_BookList.Location = New System.Drawing.Point(0, 0)
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
        Me.SplitContainer_BookList.Size = New System.Drawing.Size(816, 462)
        Me.SplitContainer_BookList.SplitterDistance = 612
        Me.SplitContainer_BookList.TabIndex = 3
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Title, Me.Author, Me.Category, Me.Publication, Me.Year_Publish, Me.Copies, Me.Call_no, Me.ISBN})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(612, 462)
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
        'MenuStrip_Footer
        '
        Me.MenuStrip_Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip_Footer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Footer_BookDetails, Me.Footer_ProgressBar, Me.Footer_Status})
        Me.MenuStrip_Footer.Location = New System.Drawing.Point(0, 462)
        Me.MenuStrip_Footer.Name = "MenuStrip_Footer"
        Me.MenuStrip_Footer.Size = New System.Drawing.Size(816, 27)
        Me.MenuStrip_Footer.TabIndex = 5
        Me.MenuStrip_Footer.Text = "MenuStrip1"
        '
        'Footer_BookDetails
        '
        Me.Footer_BookDetails.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Footer_BookDetails.AutoToolTip = False
        Me.Footer_BookDetails.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_keyboard_arrow_right_black_18dp
        Me.Footer_BookDetails.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.Footer_BookDetails.Name = "Footer_BookDetails"
        Me.Footer_BookDetails.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Footer_BookDetails.Size = New System.Drawing.Size(102, 20)
        Me.Footer_BookDetails.Text = "Book Details"
        Me.Footer_BookDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Footer_ProgressBar
        '
        Me.Footer_ProgressBar.AutoSize = False
        Me.Footer_ProgressBar.Name = "Footer_ProgressBar"
        Me.Footer_ProgressBar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Footer_ProgressBar.Size = New System.Drawing.Size(100, 15)
        '
        'Footer_Status
        '
        Me.Footer_Status.Name = "Footer_Status"
        Me.Footer_Status.Size = New System.Drawing.Size(39, 20)
        Me.Footer_Status.Text = "Status"
        '
        'BookList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.SplitContainer_BookList)
        Me.Controls.Add(Me.MenuStrip_Footer)
        Me.Name = "BookList"
        Me.Size = New System.Drawing.Size(816, 489)
        Me.SplitContainer_BookList.Panel1.ResumeLayout(False)
        Me.SplitContainer_BookList.Panel2.ResumeLayout(False)
        Me.SplitContainer_BookList.Panel2.PerformLayout()
        CType(Me.SplitContainer_BookList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_BookList.ResumeLayout(False)
        Me.MenuStrip_Footer.ResumeLayout(False)
        Me.MenuStrip_Footer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitContainer_BookList As SplitContainer
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Title As ColumnHeader
    Friend WithEvents Author As ColumnHeader
    Friend WithEvents Category As ColumnHeader
    Friend WithEvents Publication As ColumnHeader
    Friend WithEvents Year_Publish As ColumnHeader
    Friend WithEvents Copies As ColumnHeader
    Friend WithEvents Call_no As ColumnHeader
    Friend WithEvents ISBN As ColumnHeader
    Friend WithEvents TextBox_ISBN As TextBox
    Friend WithEvents Label_ISBN As Label
    Friend WithEvents TextBox_CallNo As TextBox
    Friend WithEvents Label_CallNo As Label
    Friend WithEvents TextBox_Copies As TextBox
    Friend WithEvents Label_Copies As Label
    Friend WithEvents TextBox_YearPublish As TextBox
    Friend WithEvents Label_YearPublish As Label
    Friend WithEvents TextBox_Publication As TextBox
    Friend WithEvents Label_Publication As Label
    Friend WithEvents TextBox_Category As TextBox
    Friend WithEvents Label_Category As Label
    Friend WithEvents TextBox_Author As TextBox
    Friend WithEvents Label_Author As Label
    Friend WithEvents TextBox_Title As TextBox
    Friend WithEvents Label_Title As Label
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Label_ID As Label
    Friend WithEvents MenuStrip_Footer As MenuStrip
    Friend WithEvents Footer_BookDetails As ToolStripButton
    Friend WithEvents Footer_ProgressBar As ToolStripProgressBar
    Friend WithEvents Footer_Status As ToolStripLabel
End Class
