Public Class UserControl_BookList

    Private Sub ToolStrip_BookDetails_Click(sender As Object, e As EventArgs) Handles Footer_BookDetails.Click
        If (SplitContainer_BookList.Panel2Collapsed) Then
            SplitContainer_BookList.Panel2Collapsed = False
            Footer_BookDetails.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_keyboard_arrow_right_black_18dp
        Else
            SplitContainer_BookList.Panel2Collapsed = True
            Footer_BookDetails.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_keyboard_arrow_left_black_18dp
        End If
    End Sub

    Private Sub UserControl_BookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New LibDBDataContext()
        For Each book In db.Books
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
            ListView_Book.Items.Add(New ListViewItem(row))
        Next
    End Sub

    Private Sub ListView_Book_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView_Book.ColumnClick
        ListView_Book.ListViewItemSorter = New ListViewItemComparer(e.Column)
    End Sub
End Class
Class ListViewItemComparer : Implements IComparer

    ReadOnly col As Integer

    Public Sub New()
        col = 0
    End Sub

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