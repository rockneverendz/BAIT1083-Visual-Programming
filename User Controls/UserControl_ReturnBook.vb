Public Class UserControl_ReturnBook
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '' Retrive data from database
        Using database As New LibDBDataContext()

            ' Dim rs = From co In database.CheckOuts
            ' Dim checkOut() As CheckOut = rs.ToArray
            'Dim rs = From co In database.CheckOuts
            '         Join c In database.Copies
            '         Join b In database.Books On b.Book_Id Equals c.Book_ID
            '             Dim checkOut() As CheckOut = rs.ToArray
            'Select b.Book_title, co.Issue_Date, co.Due_Date
            'For Each bkReturn In checkOut
            '    Dim row() As String = {
            '        bkReturn.
            '    }

            'For Each ReturnBook In rs
            '    Dim row() As String = {
            '        CheckOut.
            '    }

            '    'Insert integers on tag for sorting later
            '    Dim lvi = New ListViewItem(row)
            '    lvi.SubItems(0).Tag = Book.Book_Id
            '    lvi.SubItems(6).Tag = Book.Copies

            '    ListView_Book.Items.Add(lvi)
            'Next
        End Using
    End Sub


    Private Sub txtFeesPaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFeesPaid.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                        AndAlso (Not Char.IsDigit(e.KeyChar) _
                        AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If

        ' only allow one decimal point
        If ((e.KeyChar = Microsoft.VisualBasic.ChrW(46)) _
                    AndAlso (CType(sender, TextBox).Text.IndexOf(Microsoft.VisualBasic.ChrW(46)) > -1)) Then
            e.Handled = True
        End If
    End Sub
End Class
