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
        Me.ToolStrip_Header = New System.Windows.Forms.ToolStrip()
        Me.ToolStrip_Book = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TooStrip_NewBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip_BookList = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip_Checkout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_Return = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_Room = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_Patron = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStrip_NewPatron = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip_PatronList = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip_Librarian = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStrip_NewLibrarian = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip_LibrarianList = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip_Log = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_Profile = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Form_Control = New BAIT1083_Visual_Programming.BookList()
        Me.ToolStrip_Header.SuspendLayout()
        Me.Panel_Main.SuspendLayout()
        Me.SuspendLayout()
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
        Me.ToolStrip_Book.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TooStrip_NewBook, Me.ToolStrip_BookList})
        Me.ToolStrip_Book.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_book_black_18dp
        Me.ToolStrip_Book.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStrip_Book.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.ToolStrip_Book.Name = "ToolStrip_Book"
        Me.ToolStrip_Book.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStrip_Book.Size = New System.Drawing.Size(73, 22)
        Me.ToolStrip_Book.Text = "&Book"
        '
        'TooStrip_NewBook
        '
        Me.TooStrip_NewBook.Name = "TooStrip_NewBook"
        Me.TooStrip_NewBook.Size = New System.Drawing.Size(128, 22)
        Me.TooStrip_NewBook.Text = "New Book"
        '
        'ToolStrip_BookList
        '
        Me.ToolStrip_BookList.Name = "ToolStrip_BookList"
        Me.ToolStrip_BookList.Size = New System.Drawing.Size(128, 22)
        Me.ToolStrip_BookList.Text = "Book List"
        '
        'ToolStrip_Checkout
        '
        Me.ToolStrip_Checkout.AutoToolTip = False
        Me.ToolStrip_Checkout.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_vertical_align_top_black_18dp
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
        Me.ToolStrip_Return.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_vertical_align_bottom_black_18dp
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
        Me.ToolStrip_Patron.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrip_NewPatron, Me.ToolStrip_PatronList})
        Me.ToolStrip_Patron.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_people_black_18dp
        Me.ToolStrip_Patron.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStrip_Patron.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.ToolStrip_Patron.Name = "ToolStrip_Patron"
        Me.ToolStrip_Patron.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStrip_Patron.Size = New System.Drawing.Size(81, 22)
        Me.ToolStrip_Patron.Text = "&Patron"
        '
        'ToolStrip_NewPatron
        '
        Me.ToolStrip_NewPatron.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_person_add_black_18dp
        Me.ToolStrip_NewPatron.Name = "ToolStrip_NewPatron"
        Me.ToolStrip_NewPatron.Size = New System.Drawing.Size(136, 22)
        Me.ToolStrip_NewPatron.Text = "New Patron"
        '
        'ToolStrip_PatronList
        '
        Me.ToolStrip_PatronList.Name = "ToolStrip_PatronList"
        Me.ToolStrip_PatronList.Size = New System.Drawing.Size(136, 22)
        Me.ToolStrip_PatronList.Text = "Patron List"
        '
        'ToolStrip_Librarian
        '
        Me.ToolStrip_Librarian.AutoToolTip = False
        Me.ToolStrip_Librarian.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrip_NewLibrarian, Me.ToolStrip_LibrarianList})
        Me.ToolStrip_Librarian.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.vintage_reading_glasses
        Me.ToolStrip_Librarian.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStrip_Librarian.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.ToolStrip_Librarian.Name = "ToolStrip_Librarian"
        Me.ToolStrip_Librarian.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStrip_Librarian.Size = New System.Drawing.Size(92, 22)
        Me.ToolStrip_Librarian.Text = "&Librarian"
        '
        'ToolStrip_NewLibrarian
        '
        Me.ToolStrip_NewLibrarian.Name = "ToolStrip_NewLibrarian"
        Me.ToolStrip_NewLibrarian.Size = New System.Drawing.Size(147, 22)
        Me.ToolStrip_NewLibrarian.Text = "New Librarian"
        '
        'ToolStrip_LibrarianList
        '
        Me.ToolStrip_LibrarianList.Name = "ToolStrip_LibrarianList"
        Me.ToolStrip_LibrarianList.Size = New System.Drawing.Size(147, 22)
        Me.ToolStrip_LibrarianList.Text = "Librarian List"
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
        Me.ToolStrip_Profile.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_person_black_18dp
        Me.ToolStrip_Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStrip_Profile.Margin = New System.Windows.Forms.Padding(5, 1, 5, 2)
        Me.ToolStrip_Profile.Name = "ToolStrip_Profile"
        Me.ToolStrip_Profile.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ToolStrip_Profile.Size = New System.Drawing.Size(80, 22)
        Me.ToolStrip_Profile.Text = "Pro&file"
        '
        'Panel_Main
        '
        Me.Panel_Main.AutoSize = True
        Me.Panel_Main.Controls.Add(Me.Form_Control)
        Me.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Main.Location = New System.Drawing.Point(0, 25)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(800, 425)
        Me.Panel_Main.TabIndex = 5
        '
        'Form_Control
        '
        Me.Form_Control.AutoSize = True
        Me.Form_Control.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Form_Control.Location = New System.Drawing.Point(0, 0)
        Me.Form_Control.Name = "Form_Control"
        Me.Form_Control.Size = New System.Drawing.Size(800, 425)
        Me.Form_Control.TabIndex = 6
        '
        'Form_StonksLib
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.ToolStrip_Header)
        Me.Name = "Form_StonksLib"
        Me.Text = "StonksLib"
        Me.ToolStrip_Header.ResumeLayout(False)
        Me.ToolStrip_Header.PerformLayout()
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_Main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip_Header As ToolStrip
    Friend WithEvents ToolStrip_Book As ToolStripDropDownButton
    Friend WithEvents TooStrip_NewBook As ToolStripMenuItem
    Friend WithEvents ToolStrip_BookList As ToolStripMenuItem
    Friend WithEvents ToolStrip_Checkout As ToolStripButton
    Friend WithEvents ToolStrip_Return As ToolStripButton
    Friend WithEvents ToolStrip_Room As ToolStripButton
    Friend WithEvents ToolStrip_Patron As ToolStripDropDownButton
    Friend WithEvents ToolStrip_NewPatron As ToolStripMenuItem
    Friend WithEvents ToolStrip_PatronList As ToolStripMenuItem
    Friend WithEvents ToolStrip_Librarian As ToolStripDropDownButton
    Friend WithEvents ToolStrip_NewLibrarian As ToolStripMenuItem
    Friend WithEvents ToolStrip_LibrarianList As ToolStripMenuItem
    Friend WithEvents ToolStrip_Log As ToolStripButton
    Friend WithEvents ToolStrip_Profile As ToolStripDropDownButton
    Friend WithEvents Panel_Main As Panel
    Friend WithEvents Form_Control As BookList
End Class
