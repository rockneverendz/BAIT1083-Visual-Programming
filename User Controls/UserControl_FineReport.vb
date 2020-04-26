Public Class UserControl_FineReport
	Private Sub UserControl_FineReport_Load(sender As Object, e As EventArgs) Handles Me.Load

		GetQueryReport()
		lblDateNow.Text = String.Format("{0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now)
		lblPrintedBy.Text = "Admin"

	End Sub

	Private Sub GetQueryReport()
		'Clears all items on the list
		lstFineReport.Items.Clear()

		'Add items to the list 
		Using db As New LibDBDataContext()

			'Select Case [Patron].Patron_ID, [Patron].[Name], COUNT([Return].Fine_Amount) As [Number Of Fines Record], SUM([Return].Fine_Amount) As Total_Fine
			'From CheckOutList
			'INNER Join [Return] ON [Return].Rtn_ID = CheckOutList.Return_ID
			'INNER Join [CheckOut] ON [CheckOut].Chk_ID = CheckOutList.Chk_ID
			'INNER Join [Patron] ON [Patron].Patron_ID = [CheckOut].Patron_ID
			'Group By [Patron].Patron_ID, [Patron].[Name]

			Dim rs = From cl In db.CheckOutLists
					 Join r In db.Returns On r.Rtn_ID Equals cl.Return_ID
					 Join co In db.CheckOuts On co.Chk_ID Equals cl.Chk_ID
					 Join p In db.Patrons On p.Patron_ID Equals co.Patron_ID
					 Group By PatronID = p.Patron_ID, PatronName = p.Name
					 Into FineRpt = Group, Count(r.Fine_Amount), Sum(r.Fine_Amount)

			Dim cnt As Integer = 0 ' Keep track of the line count

			For Each record In rs
				cnt += 1
				Dim row() As String = {
					cnt.ToString,
					record.PatronID,
					record.PatronName,
					record.Count,
					record.Sum.ToString
				}
				Dim lvi = New ListViewItem(row)
				'Insert ListView
				lstFineReport.Items.Add(lvi)
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
		For Each item In lstFineReport.Items
			cnt += 1
			'Retrieve Data frm List View
			Dim pID As String = lstFineReport.Items(cnt2).SubItems(1).Text
			Dim pName As String = lstFineReport.Items(cnt2).SubItems(2).Text
			Dim pTotalFineRecords As String = lstFineReport.Items(cnt2).SubItems(3).Text
			Dim pTotalFines As String = lstFineReport.Items(cnt2).SubItems(4).Text

			'Transfer Data to DataGridView
			dgvFineRpt.Rows.Add(cnt, pID, pName, pTotalFineRecords, pTotalFines)

			cnt2 += 1
		Next
		easyRpt.AddDatagridView(dgvFineRpt)
		easyRpt.AddLineBreak()
		easyRpt.AddString(cnt & " record(s)")
		easyRpt.AddLineBreak()

		' (4) Show print dialog
		easyRpt.ShowPrintPreviewDialog()



	End Sub
End Class
