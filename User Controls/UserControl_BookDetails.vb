Public Class UserControl_BookDetails
    'Public Sub New(bookID As Integer)

    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.

    '    Using database As New LibDBDataContext()
    '        Dim book As Book = database.Books.First(Function(o) o.Book_Id = bookID)

    '        TextBox_ID.Text = book.Book_Id
    '        TextBox_Title.Text = book.Book_title
    '        TextBox_Author.Text = book.Author
    '        TextBox_Category.Text = book.Category
    '        TextBox_Publication.Text = book.Publication
    '        TextBox_YearPublish.Text = book.Year_Publish
    '        TextBox_Copies.Text = book.Copies
    '        TextBox_CallNo.Text = book.Call_no

    '    End Using

    'End Sub

    Public Sub Fill(bookID As Integer)
        Using database As New LibDBDataContext()
            Dim book As Book = database.Books.First(Function(o) o.Book_Id = bookID)

            TextBox_ID.Text = book.Book_Id
            TextBox_Title.Text = book.Book_title
            TextBox_Author.Text = book.Author
            TextBox_Category.Text = book.Category
            TextBox_Publication.Text = book.Publication
            TextBox_YearPublish.Text = book.Year_Publish
            TextBox_Copies.Text = book.Copies
            TextBox_CallNo.Text = book.Call_no
        End Using
    End Sub

    Public Property BookList As UserControl_BookList

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Me.Hide()
        BookList.Show()
    End Sub
End Class
