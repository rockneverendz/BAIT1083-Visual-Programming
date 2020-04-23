Imports BAIT1083_Visual_Programming.UserControl_BookDetails

Public Class UserControl_Checkout

    Dim Today As Date = Date.Today

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.TextBox_DueDate.Text = Today.ToLongDateString
    End Sub

    Private Sub TextBox_CopyID_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_CopyID.KeyDown
        ' If enter key is press, press the add button.
        If e.KeyCode = Keys.Enter Then
            Button_Add_Click(Button_Add, EventArgs.Empty)
        End If
    End Sub

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        Dim Copy_ID As Integer
        Dim isInteger = Integer.TryParse(TextBox_CopyID.Text, Copy_ID)

        If Not isInteger Then
            Label_Copy_Message.Text = "Invalid Copy ID!"
        ElseIf IsExists(Copy_ID) Then
            Label_Copy_Message.Text = "Copy already added!"
        Else
            RetriveCopy(Copy_ID)
        End If
    End Sub

    Private Function IsExists(Copy_ID As Integer) As Boolean
        ' Loop the each record on the ListView_New and find if it matches
        For Each listViewItems In ListView_New.Items
            If listViewItems.SubItems(0).Tag = Copy_ID Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub RetriveCopy(copy_ID As Integer)
        Using database As New LibDBDataContext()
            Dim copy = database.Copies.FirstOrDefault(Function(o) o.Copy_ID = copy_ID)
            If Not IsNothing(copy) Then
                Label_Copy_Message.Text = ""

                Dim book = copy.Book
                Dim row As String() = {copy.Copy_ID, copy.Status, book.Book_Id, book.Book_title, book.Call_no}
                Dim listViewItem = New ListViewItem(row)
                listViewItem.SubItems(0).Tag = copy.Copy_ID

                ListView_New.Items.Add(listViewItem)
            Else
                Label_Copy_Message.Text = "Copy ID not found!"
            End If
        End Using
    End Sub

    Private Sub TextBox_PatronID_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_PatronID.KeyDown
        ' If enter key is press, press the search button.
        If e.KeyCode = Keys.Enter Then
            Button_Search_Click(Button_Search, EventArgs.Empty)
        End If
    End Sub

    Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles Button_Search.Click
        Dim Patron_ID As Integer
        If Integer.TryParse(TextBox_PatronID.Text, Patron_ID) Then
            RetrivePatron(Patron_ID)
        Else
            Label_Patron_Message.Text = "Invalid Patron ID!"
        End If
    End Sub

    Private Sub RetrivePatron(Patron_ID As Integer)
        Using database As New LibDBDataContext()
            Dim patron = database.Patrons.FirstOrDefault(Function(o) o.Patron_ID = Patron_ID)
            If Not IsNothing(patron) Then
                Label_Patron_Message.Text = ""

                TextBox_ID.Text = patron.Patron_ID
                TextBox_Name.Text = patron.Name
                TextBox_Course.Text = patron.Course
                TextBox_PhoneNo.Text = patron.PhoneNo
                TextBox_Address.Text = patron.Address
                TextBox_Email.Text = patron.Email

                RetriveCurrent(Patron_ID, database)
            Else
                Label_Patron_Message.Text = "Patron ID not found!"
            End If
        End Using
    End Sub

    Private Sub RetriveCurrent(Patron_ID As Integer, database As LibDBDataContext)
        ListView_Current.Items.Clear()

        Dim current = From co In database.CheckOuts
                      Join col In database.CheckOutLists On co.Chk_ID Equals col.Chk_ID
                      Join c In database.Copies On col.Copy_ID Equals c.Copy_ID
                      Where co.Patron_ID = Patron_ID And
                          co.Rtn_ID Is Nothing
                      Order By co.Due_Date Descending
                      Select New HistoryModel(c.Copy_ID, co.Chk_ID, co.Issue_Date, co.Due_Date)

        For Each record In current
            Dim listViewItem = New ListViewItem(record.ToStringArray)
            ListView_Current.Items.Add(listViewItem)
            listViewItem.SubItems(0).Tag = record.Copy_ID
            listViewItem.SubItems(1).Tag = record.Chk_ID
        Next
    End Sub

    Private Sub NumericUpDown_Weeks_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Weeks.ValueChanged
        Me.TextBox_DueDate.Text = Today.AddDays(NumericUpDown_Weeks.Value * 7).ToLongDateString
    End Sub

    Private Sub Button_Confirm_Click(sender As Object, e As EventArgs) Handles Button_Confirm.Click
        Throw New NotImplementedException
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        TextBox_CopyID.Text = ""
        TextBox_PatronID.Text = ""
        TextBox_ID.Text = ""
        TextBox_Name.Text = ""
        TextBox_Course.Text = ""
        TextBox_PhoneNo.Text = ""
        TextBox_Address.Text = ""
        TextBox_Email.Text = ""
        ListView_Current.Items.Clear()
        ListView_New.Items.Clear()
        NumericUpDown_Weeks.Value = 2
    End Sub
End Class
