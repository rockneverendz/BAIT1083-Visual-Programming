Public Class UserControl_BookDetails
    Public Sub Fill(bookID As Integer)
        Using database As New LibDBDataContext()
            Dim book = database.Books.First(Function(o) o.Book_Id = bookID)

            TextBox_ID.Text = book.Book_Id
            TextBox_Title.Text = book.Book_title
            TextBox_Author.Text = book.Author
            TextBox_Category.Text = book.Category
            TextBox_Publication.Text = book.Publication
            TextBox_YearPublish.Text = book.Year_Publish
            TextBox_Copies.Text = book.Copies
            TextBox_CallNo.Text = book.Call_no

            Dim copies = database.Copies.Where(Function(o) o.Book_ID = bookID)

            For Each copy In copies

                Dim row() As String = {
                    copy.Copy_ID,
                    copy.Status
                }

                'Insert integers on tag for sorting later
                Dim lvi = New ListViewItem(row)
                lvi.SubItems(0).Tag = copy.Copy_ID

                ListView_Copies.Items.Add(lvi)
            Next

        End Using
    End Sub

    Public Property BookList As UserControl_BookList

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Me.Hide()
        BookList.Show()
    End Sub
End Class
