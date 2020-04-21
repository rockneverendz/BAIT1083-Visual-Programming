Public Class UserControl_BookDetails

    Dim bookID As Integer

    Public Sub Fill(bookID As Integer)

        ' Clear the list
        ListView_Copies.Items.Clear()
        ListView_History.Items.Clear()

        Me.bookID = bookID
        Using database As New LibDBDataContext()

            ' Get the book details
            Dim book = database.Books.First(Function(o) o.Book_Id = bookID)
            TextBox_ID.Text = book.Book_Id
            TextBox_Title.Text = book.Book_title
            TextBox_Author.Text = book.Author
            ComboBox_Category.Text = book.Category
            TextBox_Publication.Text = book.Publication
            NumericUpDown_YearPublish.Value = book.Year_Publish
            NumericUpDown_Copies.Value = book.Copies
            TextBox_CallNo.Text = book.Call_no

            ' Get the copies (of the book) details and insert into listView
            Dim copies = From c In database.Copies
                         Where c.Book_ID = bookID
                         Order By c.Copy_ID

            For Each copy In copies

                Dim row(4) As String
                Dim checkout_ID = copy.CheckOut_ID

                If IsNothing(checkout_ID) Then
                    row = {copy.Copy_ID, copy.Status, "", ""}
                Else
                    Dim duedate = database.CheckOuts.First(Function(o) o.Chk_ID = checkout_ID).Due_Date
                    row = {copy.Copy_ID, copy.Status, copy.CheckOut_ID, duedate}
                End If

                ' Insert integers on tag for sorting later
                Dim lvi = New ListViewItem(row)
                lvi.SubItems(0).Tag = copy.Copy_ID

                ListView_Copies.Items.Add(lvi)
            Next

            ' Get the history (of the book) and insert into listView
            Dim history = From co In database.CheckOuts
                          Join col In database.CheckOutLists On co.Chk_ID Equals col.Chk_ID
                          Join c In database.Copies On col.Copy_ID Equals c.Copy_ID
                          Where c.Book_ID = bookID
                          Order By co.Due_Date Descending
                          Select New HistoryModel(c.Copy_ID, co.Chk_ID, co.Issue_Date, co.Due_Date)

            For Each record In history
                Dim listViewItem = New ListViewItem(record.ToStringArray)
                ListView_History.Items.Add(listViewItem)
            Next

        End Using
    End Sub

    Public Property BookList As UserControl_BookList

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Me.Hide()
        BookList.Show()
        BookList.AutoSize = True
        BookList.Dock = System.Windows.Forms.DockStyle.Fill
    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click

        If MessageBox.Show(
                "Confirm Update?",
                "Update Record",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            ) = DialogResult.OK Then

            UpdateBook()

            'Tell BookList to update the List
            BookList.UpdateList()

        End If
    End Sub

    Private Sub UpdateBook()
        Using database As New LibDBDataContext()
            Dim book = database.Books.First(Function(o) o.Book_Id = bookID)

            book.Book_title = TextBox_Title.Text
            book.Author = TextBox_Author.Text
            book.Category = ComboBox_Category.Text
            book.Publication = TextBox_Publication.Text
            book.Year_Publish = NumericUpDown_YearPublish.Value
            book.Call_no = TextBox_CallNo.Text

            database.SubmitChanges()
        End Using
    End Sub

    Private Class HistoryModel
        Public Sub New(Copy_ID As Integer, Chk_ID As Integer, Issue_Date As Date, Due_Date As Date)
            Me.Copy_ID = Copy_ID
            Me.Chk_ID = Chk_ID
            Me.Issue_Date = Issue_Date
            Me.Due_Date = Due_Date
        End Sub

        Public Function ToStringArray() As String()
            Return {Copy_ID, Chk_ID, Issue_Date, Due_Date}
        End Function

        Public Property Copy_ID As Integer
        Public Property Chk_ID As Integer
        Public Property Issue_Date As Date
        Public Property Due_Date As Date
    End Class
End Class
