
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


			Dim format = "dd/MM/yyyy"
			Dim dateString As String = dtpSelectDate.Value.ToString(format)
			Dim dateValue As Date = Date.ParseExact(dateString, format, Nothing)

			Dim rs = From r In db.Returns
					 Where r.Rtn_Date.Value.Date.Month.Equals(dateValue.Month) And
						 r.Rtn_Date.Value.Date.Year.Equals(dateValue.Year)

			Dim cnt As Integer = 0 ' Keep track of the line count

			For Each record In rs
				cnt += 1
				Dim row() As String = {
					cnt.ToString,
					record.Rtn_ID,
					record.Rtn_Date,
					String.Format(record.Fine_Amount, "N2")
				}
				Dim lvi = New ListViewItem(row)
				'Insert ListView
				lstFineReport.Items.Add(lvi)
			Next

			'Display Total Amount of Fines
			'Select Case SUM([Return].Fine_Amount) As Total
			'From [Return]
			'ProductList.Sum(Function(item) item.Cost)

			Dim totalFineAmount As Decimal = db.Returns.Sum(
					Function(r) r.Fine_Amount And
					r.Rtn_Date.Value.Month.Equals(dateValue.Month) And
					r.Rtn_Date.Value.Year.Equals(dateValue.Year)
			)

			lblTotalFineAmount.Text = String.Format(totalFineAmount, "N2")

		End Using
	End Sub

	Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

		'Clear the control 1st to erase previous data
		easyRpt.Clear()
		dgvFineRpt.Rows.Clear()

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
			Dim rID As String = lstFineReport.Items(cnt2).SubItems(1).Text
			Dim rDate As String = lstFineReport.Items(cnt2).SubItems(2).Text
			Dim rAmount As String = lstFineReport.Items(cnt2).SubItems(3).Text

			'Transfer Data to DataGridView
			dgvFineRpt.Rows.Add(cnt, rID, rDate, rAmount)

			cnt2 += 1
		Next
		easyRpt.AddDatagridView(dgvFineRpt)
		easyRpt.AddLineBreak()
		easyRpt.AddString(cnt & " record(s)")
		easyRpt.AddLineBreak()
		easyRpt.AddLineBreak()
		easyRpt.AddString("<h3>" & Label1.Text & "&nbsp;&nbsp;&nbsp;" & lblTotalFineAmount.Text & "</h3>")
		easyRpt.AddLineBreak()

		' (4) Show print dialog
		easyRpt.ShowPrintPreviewDialog()



	End Sub

	Private Sub dtpSelectDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpSelectDate.ValueChanged

		lstFineReport.Items.Clear()
		GetQueryReport()


	End Sub
End Class
