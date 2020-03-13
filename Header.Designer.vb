<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Header
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
        Me.ToolStrip_Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip_Header
        '
        Me.ToolStrip_Header.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip_Header.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrip_Book, Me.ToolStrip_Checkout, Me.ToolStrip_Return, Me.ToolStrip_Room, Me.ToolStrip_Patron, Me.ToolStrip_Librarian, Me.ToolStrip_Log, Me.ToolStrip_Profile})
        Me.ToolStrip_Header.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_Header.Name = "ToolStrip_Header"
        Me.ToolStrip_Header.Size = New System.Drawing.Size(793, 25)
        Me.ToolStrip_Header.TabIndex = 1
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
        Me.NewBookToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewBookToolStripMenuItem.Text = "New Book"
        '
        'BookListToolStripMenuItem
        '
        Me.BookListToolStripMenuItem.Name = "BookListToolStripMenuItem"
        Me.BookListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
        Me.NewPatronToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewPatronToolStripMenuItem.Text = "New Patron"
        '
        'PatronListToolStripMenuItem
        '
        Me.PatronListToolStripMenuItem.Name = "PatronListToolStripMenuItem"
        Me.PatronListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
        Me.NewLibrarianToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewLibrarianToolStripMenuItem.Text = "New Librarian"
        '
        'LibrarianListToolStripMenuItem
        '
        Me.LibrarianListToolStripMenuItem.Name = "LibrarianListToolStripMenuItem"
        Me.LibrarianListToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
        'Header
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.ToolStrip_Header)
        Me.Name = "Header"
        Me.Size = New System.Drawing.Size(793, 25)
        Me.ToolStrip_Header.ResumeLayout(False)
        Me.ToolStrip_Header.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents ToolStrip_Profile As ToolStripDropDownButton
    Friend WithEvents ToolStrip_Log As ToolStripButton
End Class
