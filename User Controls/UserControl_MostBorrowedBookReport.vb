Imports System.Runtime.InteropServices

Public Class UserControl_MostBorrowedBookReport

	Private Sub UserControl_MostBorrowedBookReport_Load(sender As Object, e As EventArgs) Handles Me.Load

		GetQueryReport()

		lblDateNow.Text = String.Format("{0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now)
		lblPrintedBy.Text = "Admin"
	End Sub

	Private Sub GetQueryReport()
		Using db As New LibDBDataContext()
			'Select Case Copies.Book_ID, Book.Book_title, COUNT(CheckOut.Chk_ID) As MostCheckedOutBook
			'From CheckOutList
			'Inner Join CheckOut ON CheckOutList.Chk_ID = CheckOut.Chk_ID
			'Inner Join Copies ON CheckOutList.Copy_ID = Copies.Copy_ID 
			'Inner Join Book On Copies.Book_ID = Book.Book_ID
			'Group by Copies.Book_ID, Book.Book_title

			Dim format = "dd/MM/yyyy"
			Dim dateString As String = dtpSelectDate.Value.ToString(format)
			Dim dateValue As Date = Date.ParseExact(dateString, format, Nothing)

			Dim rs = From ckl In db.CheckOutLists
					 Join co In db.CheckOuts On co.Chk_ID Equals ckl.Chk_ID
					 Join cp In db.Copies On cp.Copy_ID Equals ckl.Copy_ID
					 Join bk In db.Books On bk.Book_Id Equals cp.Book_ID
					 Where co.Issue_Date.Month.Equals(dateValue.Month) And
						 co.Issue_Date.Year.Equals(dateValue.Year)
					 Group By BookID = cp.Book_ID, BookName = bk.Book_title
					 Into MostCheckedOutBook = Group, Count()
			'Order By MostCheckedOutBook Descending

			Dim cnt As Integer = 0 ' Keep track of the line count

			For Each record In rs
				cnt += 1
				Dim row() As String = {
					cnt.ToString,
					record.BookName,
					record.Count
				}
				Dim lvi = New ListViewItem(row)
				'Insert ListView
				lstMostBorrowedBook.Items.Add(lvi)

				'Insert Chart
				chartMostBorrowedBook.Series("Count").Points.AddXY(cnt.ToString, record.Count)

			Next
		End Using
	End Sub

	Private Sub dtpSelectDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpSelectDate.ValueChanged
		'Clear all points first and display new record.
		lstMostBorrowedBook.Items.Clear()
		chartMostBorrowedBook.Series("Count").Points.Clear()
		GetQueryReport()
	End Sub


	Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

		'Clear the control 1st to erase previous data
		dgvForPrint.Rows.Clear()
		easyRpt.Clear()

		'---Adding resources to Print Preview---

		' (1) Prepare Header
		easyRpt.AddControl(panForPrintHeader, "width='100%'")
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
		For Each item In lstMostBorrowedBook.Items
			cnt += 1
			'Retrieve Data frm List View
			Dim bookTitleStr As String = lstMostBorrowedBook.Items(cnt2).SubItems(1).Text
			Dim countStr As String = lstMostBorrowedBook.Items(cnt2).SubItems(2).Text
			'Transfer Data to DataGridView
			dgvForPrint.Rows.Add(cnt, bookTitleStr, countStr)
			'Console.WriteLine("{0, -5}{1, 20}{2, 10}" & vbNewLine, cnt, timeStr, countStr)
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
