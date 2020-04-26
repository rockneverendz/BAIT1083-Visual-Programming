Public Class UserControl_NewBook

    Public Property StonkLib As Form_StonksLib

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '' Make default value to this year
        NumericUpDown_YearPublish.Value = Now.Year

        Using database As New LibDBDataContext()

            ' Add distict categories
            Dim categories = (From bk In database.Books Select bk.Category).Distinct()
            For Each category In categories
                ComboBox_Category.Items.Add(category)
            Next

        End Using
    End Sub

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click

        'TODO: Validate Here

        Dim book As Book
        Using database As New LibDBDataContext()

            ' Create a new book
            book = New Book With {
                .Book_title = TextBox_Title.Text,
                .Author = TextBox_Author.Text,
                .Category = ComboBox_Category.Text,
                .Publication = TextBox_Publication.Text,
                .Year_Publish = NumericUpDown_YearPublish.Value,
                .Copies = NumericUpDown_Copies.Value,
                .Call_no = TextBox_CallNo.Text
            }

            ' Insert books into database
            database.Books.InsertOnSubmit(book)
            database.SubmitChanges()

            ' Use the database generated ID on new copy
            Dim copies(book.Copies - 1) As Copy

            ' Insert copies into database
            For Each copy In copies
                copy = New Copy With {
                    .Book_ID = book.Book_Id,
                    .Status = "Available"
                }
                database.Copies.InsertOnSubmit(copy)
            Next
            database.SubmitChanges()
        End Using

        StonkLib.Jump_BookDetails(book.Book_Id)

    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        TextBox_Title.Text = ""
        TextBox_Author.Text = ""
        ComboBox_Category.Text = ""
        TextBox_Publication.Text = ""
        NumericUpDown_YearPublish.Value = 2000
        NumericUpDown_Copies.Value = 1
        TextBox_CallNo.Text = ""
    End Sub
End Class
