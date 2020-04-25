Public Class UserControl_PatronList

    Public Property PatronDetails As UserControl_PatronDetails
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '' Retrive data from database
        UpdateList()
    End Sub

    Public Sub UpdateList()

        'Clears all items on the list
        ListView_Patron.Items.Clear()

        'Add items back to the list 
        Using database As New LibDBDataContext()
            'Get all book on the database and insert them onto ListView
            For Each patrons In database.Patrons
                Dim row() As String = {
                    patrons.Patron_ID,
                    patrons.Name,
                    patrons.Course,
                    patrons.PhoneNo,
                    patrons.Address,
                    patrons.Email
                }

                'Insert integers on tag for sorting later
                Dim lvi = New ListViewItem(row)
                lvi.SubItems(0).Tag = patrons.Patron_ID

                ListView_Patron.Items.Add(lvi)
            Next
        End Using
    End Sub

    Private Sub Footer_PatronList_Click(sender As Object, e As EventArgs) Handles Footer_PatronList.Click
        If (SplitContainer_PatronList.Panel2Collapsed) Then
            SplitContainer_PatronList.Panel2Collapsed = False
            Footer_PatronList.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_keyboard_arrow_right_black_18dp
        Else
            SplitContainer_PatronList.Panel2Collapsed = True
            Footer_PatronList.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_keyboard_arrow_left_black_18dp
        End If
    End Sub

    Private Sub ListView_Patron_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView_Patron.ColumnClick
        If e.Column = 0 Then
            'Sort by Integer
            ListView_Patron.ListViewItemSorter = New ListViewSubItemsCompareTag(e.Column)
        Else
            'Sort by String
            ListView_Patron.ListViewItemSorter = New ListViewSubItemsCompareText(e.Column)
        End If
    End Sub

    Private Sub ListView_Patron_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView_Patron.MouseDoubleClick
        PatronDetails.Fill(ListView_Patron.SelectedItems(0).SubItems(0).Tag)
        Me.Hide()
        PatronDetails.Show()
        PatronDetails.AutoSize = True
        PatronDetails.Dock = System.Windows.Forms.DockStyle.Fill
    End Sub

End Class
