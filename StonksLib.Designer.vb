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
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.Menu_Book = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_NewBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_BookList = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Checkout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Return = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Room = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Patron = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_NewPatron = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_PatronList = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Librarian = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_NewLibrarian = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_LibrarianList = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Log = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Profile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Main
        '
        Me.Panel_Main.AutoSize = True
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Main.Location = New System.Drawing.Point(0, 27)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(800, 423)
        Me.Panel_Main.TabIndex = 5
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Book, Me.Menu_Checkout, Me.Menu_Return, Me.Menu_Room, Me.Menu_Patron, Me.Menu_Librarian, Me.Menu_Log, Me.Menu_Profile})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(800, 27)
        Me.MenuStrip.TabIndex = 6
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'Menu_Book
        '
        Me.Menu_Book.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_NewBook, Me.Menu_BookList})
        Me.Menu_Book.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_book_black_18dp
        Me.Menu_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Menu_Book.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.Menu_Book.Name = "Menu_Book"
        Me.Menu_Book.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Menu_Book.Size = New System.Drawing.Size(64, 20)
        Me.Menu_Book.Text = "&Book"
        '
        'Menu_NewBook
        '
        Me.Menu_NewBook.Name = "Menu_NewBook"
        Me.Menu_NewBook.Size = New System.Drawing.Size(128, 22)
        Me.Menu_NewBook.Text = "New Book"
        '
        'Menu_BookList
        '
        Me.Menu_BookList.Name = "Menu_BookList"
        Me.Menu_BookList.Size = New System.Drawing.Size(128, 22)
        Me.Menu_BookList.Text = "Book List"
        '
        'Menu_Checkout
        '
        Me.Menu_Checkout.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_vertical_align_top_black_18dp
        Me.Menu_Checkout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Menu_Checkout.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.Menu_Checkout.Name = "Menu_Checkout"
        Me.Menu_Checkout.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Menu_Checkout.Size = New System.Drawing.Size(88, 20)
        Me.Menu_Checkout.Text = "&Checkout"
        '
        'Menu_Return
        '
        Me.Menu_Return.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_vertical_align_bottom_black_18dp
        Me.Menu_Return.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Menu_Return.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.Menu_Return.Name = "Menu_Return"
        Me.Menu_Return.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Menu_Return.Size = New System.Drawing.Size(72, 20)
        Me.Menu_Return.Text = "&Return"
        '
        'Menu_Room
        '
        Me.Menu_Room.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.cube_design
        Me.Menu_Room.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Menu_Room.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.Menu_Room.Name = "Menu_Room"
        Me.Menu_Room.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Menu_Room.Size = New System.Drawing.Size(69, 20)
        Me.Menu_Room.Text = "R&oom"
        '
        'Menu_Patron
        '
        Me.Menu_Patron.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_NewPatron, Me.Menu_PatronList})
        Me.Menu_Patron.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_people_black_18dp
        Me.Menu_Patron.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Menu_Patron.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.Menu_Patron.Name = "Menu_Patron"
        Me.Menu_Patron.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Menu_Patron.Size = New System.Drawing.Size(72, 20)
        Me.Menu_Patron.Text = "&Patron"
        '
        'Menu_NewPatron
        '
        Me.Menu_NewPatron.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_person_add_black_18dp
        Me.Menu_NewPatron.Name = "Menu_NewPatron"
        Me.Menu_NewPatron.Size = New System.Drawing.Size(136, 22)
        Me.Menu_NewPatron.Text = "New Patron"
        '
        'Menu_PatronList
        '
        Me.Menu_PatronList.Name = "Menu_PatronList"
        Me.Menu_PatronList.Size = New System.Drawing.Size(136, 22)
        Me.Menu_PatronList.Text = "Patron List"
        '
        'Menu_Librarian
        '
        Me.Menu_Librarian.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_NewLibrarian, Me.Menu_LibrarianList})
        Me.Menu_Librarian.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.vintage_reading_glasses
        Me.Menu_Librarian.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Menu_Librarian.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.Menu_Librarian.Name = "Menu_Librarian"
        Me.Menu_Librarian.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Menu_Librarian.Size = New System.Drawing.Size(83, 20)
        Me.Menu_Librarian.Text = "&Librarian"
        '
        'Menu_NewLibrarian
        '
        Me.Menu_NewLibrarian.Name = "Menu_NewLibrarian"
        Me.Menu_NewLibrarian.Size = New System.Drawing.Size(147, 22)
        Me.Menu_NewLibrarian.Text = "New Librarian"
        '
        'Menu_LibrarianList
        '
        Me.Menu_LibrarianList.Name = "Menu_LibrarianList"
        Me.Menu_LibrarianList.Size = New System.Drawing.Size(147, 22)
        Me.Menu_LibrarianList.Text = "Librarian List"
        '
        'Menu_Log
        '
        Me.Menu_Log.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.empty_paper
        Me.Menu_Log.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Menu_Log.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.Menu_Log.Name = "Menu_Log"
        Me.Menu_Log.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Menu_Log.Size = New System.Drawing.Size(57, 20)
        Me.Menu_Log.Text = "Lo&g"
        '
        'Menu_Profile
        '
        Me.Menu_Profile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Menu_Profile.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_person_black_18dp
        Me.Menu_Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Menu_Profile.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.Menu_Profile.Name = "Menu_Profile"
        Me.Menu_Profile.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Menu_Profile.Size = New System.Drawing.Size(71, 20)
        Me.Menu_Profile.Text = "Pro&file"
        '
        'Form_StonksLib
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Form_StonksLib"
        Me.Text = "StonksLib"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents Menu_Checkout As ToolStripMenuItem
    Friend WithEvents Menu_Return As ToolStripMenuItem
    Friend WithEvents Menu_Room As ToolStripMenuItem
    Friend WithEvents Menu_Book As ToolStripMenuItem
    Friend WithEvents Menu_NewBook As ToolStripMenuItem
    Friend WithEvents Menu_BookList As ToolStripMenuItem
    Friend WithEvents Menu_Patron As ToolStripMenuItem
    Friend WithEvents Menu_NewPatron As ToolStripMenuItem
    Friend WithEvents Menu_PatronList As ToolStripMenuItem
    Friend WithEvents Menu_Librarian As ToolStripMenuItem
    Friend WithEvents Menu_NewLibrarian As ToolStripMenuItem
    Friend WithEvents Menu_LibrarianList As ToolStripMenuItem
    Friend WithEvents Menu_Log As ToolStripMenuItem
    Friend WithEvents Menu_Profile As ToolStripMenuItem
	Friend WithEvents Menu_NewRoomBooking As ToolStripMenuItem
	Friend WithEvents Menu_BookingHistory As ToolStripMenuItem
End Class
