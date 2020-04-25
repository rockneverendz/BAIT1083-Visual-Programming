Public Class UserControl_ReturnBook
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TextBox_DaysOverDue.Tag = 0
        TextBox_TotalFines.Tag = New Double()
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
        For Each listViewItems In ListView_Copies.Items
            If listViewItems.SubItems(0).Tag = Copy_ID Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub RetriveCopy(copy_ID As Integer)
        Using database As New LibDBDataContext()

            Dim copy = database.Copies.FirstOrDefault(Function(o) o.Copy_ID = copy_ID)

            If IsNothing(copy) Then
                Label_Copy_Message.Text = "Copy ID not found!"
                Return
            End If

            Dim checkout = copy.CheckOut

            If IsNothing(checkout) Then
                Label_Copy_Message.Text = "Copy is not checked out!"
            Else
                Label_Copy_Message.Text = ""


                Dim book = copy.Book
                Dim listViewItem As ListViewItem

                If checkout.Due_Date >= Today Then
                    listViewItem = NewRow(copy, checkout, book)
                Else
                    listViewItem = NewRowWithFines(copy, checkout, book)
                End If

                ListView_Copies.Items.Add(listViewItem)
            End If
        End Using
    End Sub

    Private Shared Function NewRow(copy As Copy, checkout As CheckOut, book As Book) As ListViewItem
        Dim row = {
            copy.Copy_ID,
            book.Book_Id,
            book.Book_title,
            checkout.Chk_ID,
            checkout.Issue_Date,
            checkout.Due_Date,
            "",
            ""
        }

        Dim listViewItem = New ListViewItem(row)
        listViewItem.SubItems(0).Tag = copy.Copy_ID
        listViewItem.SubItems(1).Tag = book.Book_Id
        listViewItem.SubItems(3).Tag = checkout.Chk_ID

        Return listViewItem
    End Function

    Private Function NewRowWithFines(copy As Copy, checkout As CheckOut, book As Book) As ListViewItem
        Dim daysOverdue As Integer = (Today - checkout.Due_Date).TotalDays
        Dim subTotal As Double = (daysOverdue * NumericUpDown_FinePerDay.Value)
        TextBox_DaysOverDue.Tag += daysOverdue
        TextBox_DaysOverDue.Text = TextBox_DaysOverDue.Tag
        TextBox_TotalFines.Tag += subTotal
        TextBox_TotalFines.Text = CDbl(TextBox_TotalFines.Tag).ToString("N2")

        Dim row = {
            copy.Copy_ID,
            book.Book_Id,
            book.Book_title,
            checkout.Chk_ID,
            checkout.Issue_Date,
            checkout.Due_Date,
            daysOverdue,
            subTotal.ToString("N2")
        }

        Dim listViewItem = New ListViewItem(row)
        listViewItem.SubItems(0).Tag = copy.Copy_ID
        listViewItem.SubItems(1).Tag = book.Book_Id
        listViewItem.SubItems(3).Tag = checkout.Chk_ID
        listViewItem.SubItems(6).Tag = daysOverdue
        listViewItem.SubItems(7).Tag = subTotal

        Return listViewItem
    End Function

    Private Sub NumericUpDown_FinePerDay_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_FinePerDay.ValueChanged
        Dim newFinePerDay = NumericUpDown_FinePerDay.Value
        Dim totalFine = New Double
        For Each listViewItems In ListView_Copies.Items
            Dim daysOverdue = listViewItems.SubItems(6).Tag
            If Not IsNothing(daysOverdue) Then
                Dim subtotal As Double = daysOverdue * newFinePerDay
                totalFine += subtotal
                listViewItems.SubItems(7).Tag = subtotal
                listViewItems.SubItems(7).Text = subtotal.ToString("N2")
            End If
        Next

        TextBox_TotalFines.Tag = totalFine
        TextBox_TotalFines.Text = totalFine.ToString("N2")
    End Sub

    Private Sub Button_Return_Click(sender As Object, e As EventArgs) Handles Button_Return.Click

        'TODO: Validate if there's at least one book on the list

        Using database As New LibDBDataContext()

            ' Make a new return record
            Dim totalFines As Integer = TextBox_TotalFines.Tag
            Dim returns As [Return] = New [Return] With {
                .Rtn_Date = Today,
                .Fine_Amount = totalFines
            }

            ' Submit record to get return_id
            database.Returns.InsertOnSubmit(returns)
            database.SubmitChanges()

            ' Using that return_id update checkoutlist of said copy
            For Each listItemView In ListView_Copies.Items
                Dim copy_ID As Integer = listItemView.SubItems(0).Tag
                Dim copy = database.Copies.FirstOrDefault(Function(o) o.Copy_ID = copy_ID)
                Dim checkoutlist = copy.CheckOutLists.First(Function(o) o.Copy_ID = copy_ID)

                copy.Status = "Available"
                copy.CheckOut_ID = Nothing
                checkoutlist.Return_ID = returns.Rtn_ID
            Next

            ' Save changes
            database.SubmitChanges()

            ' Inform user
            MessageBox.Show("Successfully Returned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear form
            Button_Clear_Click(Button_Clear, EventArgs.Empty)

        End Using
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        ListView_Copies.Items.Clear()
        TextBox_CopyID.Text = ""
        Label_Copy_Message.Text = ""
        NumericUpDown_FinePerDay.Value = 1
        TextBox_TotalFines.Tag = New Double
        TextBox_TotalFines.Text = "0.00"
        TextBox_DaysOverDue.Tag = 0
        TextBox_DaysOverDue.Text = "0"
    End Sub
End Class
