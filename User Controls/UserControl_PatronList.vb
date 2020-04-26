Public Class UserControl_PatronList

    Public Property PatronDetails As UserControl_PatronDetails
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '' Retrive data from database

        Using database As New LibDBDataContext()

            ' Add distict courses
            Dim courses = (From pt In database.Patrons Select pt.Course).Distinct()
            For Each course In courses
                ComboBox_Course.Items.Add(course)
            Next

        End Using

        UpdateList()
    End Sub

    Public Sub UpdateList()

        'Clears all items on the list
        ListView_Patron.Items.Clear()
        TextBox_ID.Text = ""
        TextBox_Name.Text = ""
        ComboBox_Course.Text = ""
        TextBox_PhoneNo.Text = ""
        TextBox_Email.Text = ""
        TextBox_Address.Text = ""
        Label_Search_Message.Text = ""

        'Add items back to the list 
        Using database As New LibDBDataContext()
            'Get all book on the database and insert them onto ListView
            Dim patrons = From pt In database.Patrons
            FillPatrons(patrons)
        End Using
    End Sub

    Private Sub FillPatrons(patrons As IQueryable(Of Patron))
        For Each patron In patrons
            Dim row() As String = {
                patron.Patron_ID,
                patron.Name,
                patron.Course,
                patron.PhoneNo,
                patron.Address,
                patron.Email
            }

            'Insert integers on tag for sorting later
            Dim lvi = New ListViewItem(row)
            lvi.SubItems(0).Tag = patron.Patron_ID

            ListView_Patron.Items.Add(lvi)
        Next
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

    Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles Button_Search.Click
        Using database As New LibDBDataContext()

            Label_Search_Message.Text = ""

            Dim patrons = From pt In database.Patrons

            If Not String.IsNullOrWhiteSpace(TextBox_ID.Text) Then
                Dim patronID As Integer
                If Integer.TryParse(TextBox_ID.Text, patronID) Then
                    patrons = patrons.Where(Function(o) o.Patron_ID = patronID)
                Else
                    Label_Search_Message.Text = "Invalid Patron ID!"
                    Return
                End If
            End If

            If Not String.IsNullOrWhiteSpace(TextBox_Name.Text) Then
                Dim patronName = TextBox_Name.Text
                patrons = patrons.Where(Function(o) o.Name.Contains(patronName))
            End If

            If Not String.IsNullOrWhiteSpace(ComboBox_Course.Text) Then
                Dim patronCourse = ComboBox_Course.Text
                patrons = patrons.Where(Function(o) o.Course = patronCourse)
            End If

            If Not String.IsNullOrWhiteSpace(TextBox_PhoneNo.Text) Then
                Dim patronPhoneNo = TextBox_PhoneNo.Text
                patrons = patrons.Where(Function(o) o.PhoneNo.Contains(patronPhoneNo))
            End If

            If Not String.IsNullOrWhiteSpace(TextBox_Email.Text) Then
                Dim patronEmail = TextBox_Email.Text
                patrons = patrons.Where(Function(o) o.Email.Contains(patronEmail))
            End If

            If Not String.IsNullOrWhiteSpace(TextBox_Address.Text) Then
                Dim patronAddress = TextBox_Address.Text
                patrons = patrons.Where(Function(o) o.Address.Contains(patronAddress))
            End If

            ListView_Patron.Items.Clear()
            FillPatrons(patrons)
        End Using
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        UpdateList()
    End Sub
End Class
