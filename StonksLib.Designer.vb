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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_StonksLib))
		Me.Panel_Main = New System.Windows.Forms.Panel()
		Me.MenuStrip = New System.Windows.Forms.MenuStrip()
		Me.Menu_Book = New System.Windows.Forms.ToolStripMenuItem()
		Me.Menu_NewBook = New System.Windows.Forms.ToolStripMenuItem()
		Me.Menu_BookList = New System.Windows.Forms.ToolStripMenuItem()
		Me.Menu_Checkout = New System.Windows.Forms.ToolStripMenuItem()
		Me.Menu_Return = New System.Windows.Forms.ToolStripMenuItem()
		Me.Menu_Room = New System.Windows.Forms.ToolStripMenuItem()
		Me.Menu_NewRoomBooking = New System.Windows.Forms.ToolStripMenuItem()
		Me.Menu_ViewBookingHistory = New System.Windows.Forms.ToolStripMenuItem()
		Me.Menu_Patron = New System.Windows.Forms.ToolStripMenuItem()
		Me.Menu_NewPatron = New System.Windows.Forms.ToolStripMenuItem()
		Me.Menu_PatronList = New System.Windows.Forms.ToolStripMenuItem()
		Me.Menu_Librarian = New System.Windows.Forms.ToolStripMenuItem()
		Me.Menu_NewLibrarian = New System.Windows.Forms.ToolStripMenuItem()
		Me.Menu_LibrarianList = New System.Windows.Forms.ToolStripMenuItem()
		Me.Menu_Log = New System.Windows.Forms.ToolStripMenuItem()
		Me.Menu_RBooking_Report = New System.Windows.Forms.ToolStripMenuItem()
		Me.Menu_Profile = New System.Windows.Forms.ToolStripMenuItem()
		Me.Menu_MostBorrowedBookReport = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuStrip.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel_Main
		'
		Me.Panel_Main.AutoSize = True
		Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel_Main.Location = New System.Drawing.Point(0, 31)
		Me.Panel_Main.Margin = New System.Windows.Forms.Padding(4)
		Me.Panel_Main.Name = "Panel_Main"
		Me.Panel_Main.Size = New System.Drawing.Size(1067, 523)
		Me.Panel_Main.TabIndex = 5
		'
		'MenuStrip
		'
		Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Book, Me.Menu_Checkout, Me.Menu_Return, Me.Menu_Room, Me.Menu_Patron, Me.Menu_Librarian, Me.Menu_Log, Me.Menu_Profile})
		Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip.Name = "MenuStrip"
		Me.MenuStrip.Size = New System.Drawing.Size(1067, 31)
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
		Me.Menu_Book.Size = New System.Drawing.Size(77, 24)
		Me.Menu_Book.Text = "&Book"
		'
		'Menu_NewBook
		'
		Me.Menu_NewBook.Name = "Menu_NewBook"
		Me.Menu_NewBook.Size = New System.Drawing.Size(160, 26)
		Me.Menu_NewBook.Text = "New Book"
		'
		'Menu_BookList
		'
		Me.Menu_BookList.Name = "Menu_BookList"
		Me.Menu_BookList.Size = New System.Drawing.Size(160, 26)
		Me.Menu_BookList.Text = "Book List"
		'
		'Menu_Checkout
		'
		Me.Menu_Checkout.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_vertical_align_top_black_18dp
		Me.Menu_Checkout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Menu_Checkout.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
		Me.Menu_Checkout.Name = "Menu_Checkout"
		Me.Menu_Checkout.Size = New System.Drawing.Size(104, 24)
		Me.Menu_Checkout.Text = "&Checkout"
		'
		'Menu_Return
		'
		Me.Menu_Return.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_vertical_align_bottom_black_18dp
		Me.Menu_Return.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Menu_Return.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
		Me.Menu_Return.Name = "Menu_Return"
		Me.Menu_Return.Size = New System.Drawing.Size(86, 24)
		Me.Menu_Return.Text = "&Return"
		'
		'Menu_Room
		'
		Me.Menu_Room.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_NewRoomBooking, Me.Menu_ViewBookingHistory})
		Me.Menu_Room.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.cube_design
		Me.Menu_Room.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Menu_Room.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
		Me.Menu_Room.Name = "Menu_Room"
		Me.Menu_Room.Size = New System.Drawing.Size(83, 24)
		Me.Menu_Room.Text = "R&oom"
		'
		'Menu_NewRoomBooking
		'
		Me.Menu_NewRoomBooking.Name = "Menu_NewRoomBooking"
		Me.Menu_NewRoomBooking.Size = New System.Drawing.Size(234, 26)
		Me.Menu_NewRoomBooking.Text = "New Room Booking"
		'
		'Menu_ViewBookingHistory
		'
		Me.Menu_ViewBookingHistory.Name = "Menu_ViewBookingHistory"
		Me.Menu_ViewBookingHistory.Size = New System.Drawing.Size(234, 26)
		Me.Menu_ViewBookingHistory.Text = "View Booking History"
		'
		'Menu_Patron
		'
		Me.Menu_Patron.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_NewPatron, Me.Menu_PatronList})
		Me.Menu_Patron.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_people_black_18dp
		Me.Menu_Patron.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Menu_Patron.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
		Me.Menu_Patron.Name = "Menu_Patron"
		Me.Menu_Patron.Size = New System.Drawing.Size(85, 24)
		Me.Menu_Patron.Text = "&Patron"
		'
		'Menu_NewPatron
		'
		Me.Menu_NewPatron.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_person_add_black_18dp
		Me.Menu_NewPatron.Name = "Menu_NewPatron"
		Me.Menu_NewPatron.Size = New System.Drawing.Size(168, 26)
		Me.Menu_NewPatron.Text = "New Patron"
		'
		'Menu_PatronList
		'
		Me.Menu_PatronList.Name = "Menu_PatronList"
		Me.Menu_PatronList.Size = New System.Drawing.Size(168, 26)
		Me.Menu_PatronList.Text = "Patron List"
		'
		'Menu_Librarian
		'
		Me.Menu_Librarian.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_NewLibrarian, Me.Menu_LibrarianList})
		Me.Menu_Librarian.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.vintage_reading_glasses
		Me.Menu_Librarian.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Menu_Librarian.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
		Me.Menu_Librarian.Name = "Menu_Librarian"
		Me.Menu_Librarian.Size = New System.Drawing.Size(101, 24)
		Me.Menu_Librarian.Text = "&Librarian"
		'
		'Menu_NewLibrarian
		'
		Me.Menu_NewLibrarian.Name = "Menu_NewLibrarian"
		Me.Menu_NewLibrarian.Size = New System.Drawing.Size(184, 26)
		Me.Menu_NewLibrarian.Text = "New Librarian"
		'
		'Menu_LibrarianList
		'
		Me.Menu_LibrarianList.Name = "Menu_LibrarianList"
		Me.Menu_LibrarianList.Size = New System.Drawing.Size(184, 26)
		Me.Menu_LibrarianList.Text = "Librarian List"
		'
		'Menu_Log
		'
		Me.Menu_Log.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_RBooking_Report, Me.Menu_MostBorrowedBookReport})
		Me.Menu_Log.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.empty_paper
		Me.Menu_Log.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Menu_Log.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
		Me.Menu_Log.Name = "Menu_Log"
		Me.Menu_Log.Size = New System.Drawing.Size(88, 24)
		Me.Menu_Log.Text = "R&eport"
		'
		'Menu_RBooking_Report
		'
		Me.Menu_RBooking_Report.Name = "Menu_RBooking_Report"
		Me.Menu_RBooking_Report.Size = New System.Drawing.Size(281, 26)
		Me.Menu_RBooking_Report.Text = "Room Booking Report"
		'
		'Menu_Profile
		'
		Me.Menu_Profile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.Menu_Profile.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_person_black_18dp
		Me.Menu_Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Menu_Profile.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
		Me.Menu_Profile.Name = "Menu_Profile"
		Me.Menu_Profile.Size = New System.Drawing.Size(86, 24)
		Me.Menu_Profile.Text = "Pro&file"
		'
		'Menu_MostBorrowedBookReport
		'
		Me.Menu_MostBorrowedBookReport.Name = "Menu_MostBorrowedBookReport"
		Me.Menu_MostBorrowedBookReport.Size = New System.Drawing.Size(281, 26)
		Me.Menu_MostBorrowedBookReport.Text = "Most Borrowed Book Report"
		'
		'Form_StonksLib
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1067, 554)
		Me.Controls.Add(Me.Panel_Main)
		Me.Controls.Add(Me.MenuStrip)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.MenuStrip
		Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents Menu_ViewBookingHistory As ToolStripMenuItem
    Friend WithEvents Menu_RBooking_Report As ToolStripMenuItem
	Friend WithEvents Menu_MostBorrowedBookReport As ToolStripMenuItem
End Class
