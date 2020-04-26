Public Class UserControl_BookList

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '' Retrive data from database

        Using database As New LibDBDataContext()

            ' Add distict categories
            Dim categories = (From bk In database.Books Select bk.Category).Distinct()
            For Each record In categories
                ComboBox_Category.Items.Add(record)
            Next

        End Using

        UpdateList()
    End Sub

    Public Sub UpdateList()

        'Clears all items on the list and search boxes
        ListView_Book.Items.Clear()
        TextBox_ID.Text = ""
        TextBox_Title.Text = ""
        TextBox_Author.Text = ""
        ComboBox_Category.Text = ""
        TextBox_Publication.Text = ""
        TextBox_YearPublish.Text = ""
        TextBox_Copies.Text = ""
        TextBox_CallNo.Text = ""
        Label_Search_Message.Text = ""

        'Add items back to the list 
        Using database As New LibDBDataContext()
            'Get all book on the database and insert them onto ListView
            Dim books = From bk In database.Books
            FillBooks(books)
        End Using
    End Sub

    Private Sub ToolStrip_BookDetails_Click(sender As Object, e As EventArgs) Handles Footer_BookList.Click
        If (SplitContainer_BookList.Panel2Collapsed) Then
            SplitContainer_BookList.Panel2Collapsed = False
            Footer_BookList.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_keyboard_arrow_right_black_18dp
        Else
            SplitContainer_BookList.Panel2Collapsed = True
            Footer_BookList.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_keyboard_arrow_left_black_18dp
        End If
    End Sub

    Private Sub ListView_Book_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView_Book.ColumnClick
        If e.Column = 0 Or e.Column = 6 Then
            'Sort by Integer
            ListView_Book.ListViewItemSorter = New ListViewSubItemsCompareTag(e.Column)
        Else
            'Sort by String
            ListView_Book.ListViewItemSorter = New ListViewSubItemsCompareText(e.Column)
        End If
    End Sub

    Public Property BookDetails As UserControl_BookDetails

    Private Sub ListView_Book_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView_Book.MouseDoubleClick

        BookDetails.Fill(ListView_Book.SelectedItems(0).SubItems(0).Tag)
        Me.Hide()
        BookDetails.Show()
        BookDetails.AutoSize = True
        BookDetails.Dock = System.Windows.Forms.DockStyle.Fill
    End Sub

    Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles Button_Search.Click
        Using database As New LibDBDataContext()

            Label_Search_Message.Text = ""

            Dim books = From bk In database.Books

            If Not String.IsNullOrWhiteSpace(TextBox_ID.Text) Then
                Dim bookID As Integer
                If Integer.TryParse(TextBox_ID.Text, bookID) Then
                    books = books.Where(Function(o) o.Book_Id = bookID)
                Else
                    Label_Search_Message.Text = "Invalid Copy ID!"
                    Return
                End If
            End If

            If Not String.IsNullOrWhiteSpace(TextBox_Title.Text) Then
                Dim bookTitle = TextBox_Title.Text
                books = books.Where(Function(o) o.Book_title.Contains(bookTitle))
            End If

            If Not String.IsNullOrWhiteSpace(TextBox_Author.Text) Then
                Dim bookAuthor = TextBox_Author.Text
                books = books.Where(Function(o) o.Author.Contains(bookAuthor))
            End If

            If Not String.IsNullOrWhiteSpace(ComboBox_Category.Text) Then
                Dim bookCategory = ComboBox_Category.Text
                books = books.Where(Function(o) o.Category = bookCategory)
            End If

            If Not String.IsNullOrWhiteSpace(TextBox_Publication.Text) Then
                Dim bookPublication = TextBox_Publication.Text
                books = books.Where(Function(o) o.Publication.Contains(bookPublication))
            End If

            If Not String.IsNullOrWhiteSpace(TextBox_YearPublish.Text) Then
                Dim bookYearPublish As Integer
                If Integer.TryParse(TextBox_YearPublish.Text, bookYearPublish) Then
                    books = books.Where(Function(o) o.Year_Publish = bookYearPublish)
                Else
                    Label_Search_Message.Text = "Invalid Year Publish!"
                    Return
                End If
            End If

            If Not String.IsNullOrWhiteSpace(TextBox_Copies.Text) Then
                Dim bookCopies As Integer
                If Integer.TryParse(TextBox_Copies.Text, bookCopies) Then
                    books = books.Where(Function(o) o.Copies = bookCopies)
                Else
                    Label_Search_Message.Text = "Invalid Copies!"
                    Return
                End If
            End If

            If Not String.IsNullOrWhiteSpace(TextBox_CallNo.Text) Then
                Dim bookCallNo = TextBox_CallNo.Text
                books = books.Where(Function(o) o.Call_no.Contains(bookCallNo))
            End If

            ListView_Book.Items.Clear()
            FillBooks(books)
        End Using
    End Sub

    Private Sub FillBooks(books As IQueryable(Of Book))
        For Each book In books
            Dim row() As String = {
                book.Book_Id,
                book.Book_title,
                book.Author,
                book.Category,
                book.Publication,
                book.Year_Publish,
                book.Copies,
                book.Call_no
            }

            'Insert integers on tag for sorting later
            Dim lvi = New ListViewItem(row)
            lvi.SubItems(0).Tag = book.Book_Id
            lvi.SubItems(6).Tag = book.Copies

            ListView_Book.Items.Add(lvi)
        Next
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        UpdateList()
    End Sub
End Class
Class ListViewSubItemsCompareText : Implements IComparer

    ReadOnly col As Integer

    Public Sub New(col As Integer)
        Me.col = col
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
        Return String.Compare(
            DirectCast(x, ListViewItem).SubItems(col).Text,
            DirectCast(y, ListViewItem).SubItems(col).Text
        )
    End Function
End Class

Class ListViewSubItemsCompareTag : Implements IComparer

    ReadOnly col As Integer

    Public Sub New(col As Integer)
        Me.col = col
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
        Return DirectCast(DirectCast(x, ListViewItem).SubItems(col).Tag, Integer).CompareTo(
            DirectCast(DirectCast(y, ListViewItem).SubItems(col).Tag, Integer)
        )
    End Function
End Class