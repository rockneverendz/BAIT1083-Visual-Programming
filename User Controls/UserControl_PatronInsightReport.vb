Public Class UserControl_PatronInsightReport
	Private Sub UserControl_PatronInsightReport_Load(sender As Object, e As EventArgs) Handles Me.Load

		GetPatronList()
        lblDateNow.Text = String.Format("{0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now)
        lblPrintedBy.Text = "Admin"

    End Sub

	Private Sub GetPatronList()
        'Clears all items on the list
        lstPatronList.Items.Clear()

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

                lstPatronList.Items.Add(lvi)
            Next
        End Using
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Clear the control 1st to erase previous data
        easyRpt.Clear()

        '---Adding resources to Print Preview---

        ' (1) Prepare Header
        easyRpt.AddControl(panForPrintHeader)
        easyRpt.AddHorizontalRule()
        panForPrintHeader.Visible = False


        ' (3) Prepare Table View
        Dim cnt As Integer = 0 ' Keep track of the line count
        Dim cnt2 As Integer = 0
        For Each item In lstPatronList.Items
            cnt += 1
            'Retrieve Data frm List View
            Dim pID As String = lstPatronList.Items(cnt2).SubItems(0).Text
            Dim pName As String = lstPatronList.Items(cnt2).SubItems(1).Text
            Dim pCourse As String = lstPatronList.Items(cnt2).SubItems(2).Text
            Dim pHpNum As String = lstPatronList.Items(cnt2).SubItems(3).Text
            Dim pAddress As String = lstPatronList.Items(cnt2).SubItems(4).Text
            Dim pEmail As String = lstPatronList.Items(cnt2).SubItems(5).Text

            'Transfer Data to DataGridView
            dgvPatronList.Rows.Add(pID, pName, pCourse, pHpNum, pAddress, pEmail)

            cnt2 += 1
        Next
        easyRpt.AddDatagridView(dgvPatronList)
        easyRpt.AddLineBreak()
        easyRpt.AddString(cnt & " record(s)")
        easyRpt.AddLineBreak()

        ' (4) Show print dialog
        easyRpt.ShowPrintPreviewDialog()
    End Sub
End Class
