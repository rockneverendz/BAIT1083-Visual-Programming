Public Class UserControl_MostChkOutPatronReport
	Private Sub UserControl_MostChkOutPatronReport_Load(sender As Object, e As EventArgs) Handles Me.Load

		GetQueryReport()
		lblDateNow.Text = String.Format("{0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now)
		lblPrintedBy.Text = "Admin"

	End Sub

	Private Sub GetQueryReport()
		Using db As New LibDBDataContext()
			'Select Case Patron.Name, COUNT(CheckOut.Chk_ID) As MostCheckedOutPatron
			'	From CheckOut
			'	Inner Join Patron ON Patron.Patron_ID = CheckOut.Patron_ID
			'	Group by Patron.Name
			'	Order by MostCheckedOutPatron DESC

			Dim format = "dd/MM/yyyy"
			Dim dateString As String = dtpSelectDate.Value.ToString(format)
			Dim dateValue As Date = Date.ParseExact(dateString, format, Nothing)

			Dim rs = From co In db.CheckOuts
					 Join p In db.Patrons On p.Patron_ID Equals co.Patron_ID
					 Where co.Issue_Date.Month.Equals(dateValue.Month) And
						 co.Issue_Date.Year.Equals(dateValue.Year)
					 Group By PatronName = p.Name
					 Into MostCheckedOutPatron = Group, Count()

			Dim cnt As Integer = 0 ' Keep track of the line count

			For Each record In rs
				cnt += 1
				Dim row() As String = {
					cnt.ToString,
					record.PatronName,
					record.Count
				}
				Dim lvi = New ListViewItem(row)
				'Insert ListView
				lstPatronChkOut.Items.Add(lvi)

				'Insert Chart
				chartPatronChkOuts.Series("Count").Points.AddXY(record.PatronName, record.Count)

			Next
		End Using

	End Sub

	Private Sub dtpSelectDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpSelectDate.ValueChanged
		'Clear all points first and display new record.
		lstPatronChkOut.Items.Clear()
		chartPatronChkOuts.Series("Count").Points.Clear()
		GetQueryReport()
	End Sub

	Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

		'Clear the control 1st to erase previous data
		dgvForPrint.Rows.Clear()
		easyRpt.Clear()

		'---Adding resources to Print Preview---

		' (1) Prepare Header
		easyRpt.AddControl(panForPrintHeader)
		easyRpt.AddHorizontalRule()
		panForPrintHeader.Visible = False

		' (2) Prepare Chart
		easyRpt.AddControl(SplitContainer1.Panel1, "width='100%'")
		panForPrintHeader.Visible = True
		easyRpt.AddLineBreak()
		easyRpt.AddLineBreak()

		'Add ListView
		' (3) Prepare Table View
		Dim cnt As Integer = 0 ' Keep track of the line count
		Dim cnt2 As Integer = 0
		For Each item In lstPatronChkOut.Items
			cnt += 1
			'Retrieve Data frm List View
			Dim bookTitleStr As String = lstPatronChkOut.Items(cnt2).SubItems(1).Text
			Dim countStr As String = lstPatronChkOut.Items(cnt2).SubItems(2).Text
			'Transfer Data to DataGridView
			dgvForPrint.Rows.Add(cnt, bookTitleStr, countStr)
			cnt2 += 1
		Next
		easyRpt.AddDatagridView(dgvForPrint)
		easyRpt.AddLineBreak()
		easyRpt.AddString(cnt & " record(s)")
		easyRpt.AddLineBreak()

		' (4) Show print dialog
		easyRpt.ShowPrintPreviewDialog()


	End Sub


End Class
