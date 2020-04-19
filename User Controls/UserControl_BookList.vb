Public Class UserControl_BookList
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '' Retrive data from database
        Using database As New LibDBDataContext()
            'Get all book on the database and insert them onto ListView
            For Each book In database.Books
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
        End Using
    End Sub

    Private Sub ToolStrip_BookDetails_Click(sender As Object, e As EventArgs) Handles Footer_BookDetails.Click
        If (SplitContainer_BookList.Panel2Collapsed) Then
            SplitContainer_BookList.Panel2Collapsed = False
            Footer_BookDetails.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_keyboard_arrow_right_black_18dp
        Else
            SplitContainer_BookList.Panel2Collapsed = True
            Footer_BookDetails.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_keyboard_arrow_left_black_18dp
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