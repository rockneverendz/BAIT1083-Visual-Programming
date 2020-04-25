Public Class UserControl_PatronDetails

    Public Property PatronList As UserControl_PatronList
    Dim patronID As Integer

    Friend Sub Fill(patron_ID As Integer)
        Me.patronID = patron_ID
        Using database As New LibDBDataContext()

            ' Get distinct courses
            Dim courses = (From p In database.Patrons Select p.Course).Distinct()
            For Each course In courses
                ComboBox_Course.Items.Add(course)
            Next

            ' Get the book details
            Dim patron = database.Patrons.First(Function(o) o.Patron_ID = patron_ID)
            TextBox_ID.Text = patron.Patron_ID
            TextBox_Name.Text = patron.Name
            ComboBox_Course.Text = patron.Course
            TextBox_PhoneNo.Text = patron.PhoneNo
            TextBox_Email.Text = patron.Email
            TextBox_Address.Text = patron.Address

            GetHistory(database)

        End Using
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Me.Hide()
        PatronList.Show()
        PatronList.AutoSize = True
        PatronList.Dock = System.Windows.Forms.DockStyle.Fill
    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click

        If MessageBox.Show(
                "Confirm Update?",
                "Update Record",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            ) = DialogResult.OK Then

            UpdatePatron()

            'Tell BookList to update the List
            PatronList.UpdateList()

        End If
    End Sub

    Private Sub UpdatePatron()
        Using database As New LibDBDataContext()
            Dim patron = database.Patrons.First(Function(o) o.Patron_ID = patronID)

            patron.Name = TextBox_Name.Text
            patron.Course = ComboBox_Course.Text
            patron.PhoneNo = TextBox_PhoneNo.Text
            patron.Email = TextBox_Email.Text
            patron.Address = TextBox_Address.Text

            database.SubmitChanges()
        End Using
    End Sub

    Private Sub GetHistory(database As LibDBDataContext)
        ' Clear the history list
        ListView_History.Items.Clear()

        ' Get the past loans (of the patron) and insert into listView
        Dim history = From co In database.CheckOuts
                      Join col In database.CheckOutLists On co.Chk_ID Equals col.Chk_ID
                      Join c In database.Copies On col.Copy_ID Equals c.Copy_ID
                      Join b In database.Books On c.Book_ID Equals b.Book_Id
                      Where co.Patron_ID = patronID
                      Order By co.Issue_Date Descending
                      Select New LoansModel(co.Chk_ID, c.Copy_ID, b.Book_Id, b.Book_title, co.Issue_Date, co.Due_Date, col.Return_ID)

        ' Fill the ListView_History
        For Each record In history
            Dim listViewItem = New ListViewItem(record.ToStringArray)
            ListView_History.Items.Add(listViewItem)
            listViewItem.SubItems(0).Tag = record.Chk_ID
            listViewItem.SubItems(1).Tag = record.Copy_ID
            listViewItem.SubItems(2).Tag = record.Book_ID
            listViewItem.SubItems(6).Tag = record.Return_ID
        Next
    End Sub

    Friend Class LoansModel
        Public Sub New(Chk_ID As Integer, Copy_ID As Integer, Book_ID As Integer, Book_Title As String, Issue_Date As Date, Due_Date As Date, Return_ID As Integer?)
            Me.Chk_ID = Chk_ID
            Me.Copy_ID = Copy_ID
            Me.Book_ID = Book_ID
            Me.Book_Title = Book_Title
            Me.Issue_Date = Issue_Date
            Me.Due_Date = Due_Date
            Me.Return_ID = Return_ID

        End Sub

        Public Function ToStringArray() As String()
            Return {
                Chk_ID,
                Copy_ID,
                Book_ID,
                Book_Title,
                Issue_Date,
                Due_Date,
                If(Return_ID, "")
            }
        End Function

        Public Property Chk_ID As Integer
        Public Property Copy_ID As Integer
        Public Property Book_ID As Integer
        Public Property Book_Title As String
        Public Property Issue_Date As Date
        Public Property Due_Date As Date
        Public Property Return_ID As Integer?
    End Class

End Class
