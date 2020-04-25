Imports System.Runtime.InteropServices

Public Class UserControl_MostBorrowedBookReport

	Private Sub UserControl_MostBorrowedBookReport_Load(sender As Object, e As EventArgs) Handles Me.Load

		GetQueryReport()
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
					 Group By BookID = cp.Book_ID, BookName = bk.Book_title
					 Into MostCheckedOutBook = Group, Count()
			'Order By MostCheckedOutBook Descending

			For Each record In rs
				Dim row() As String = {
					record.BookName,
					record.Count
				}
				Dim lvi = New ListViewItem(row)
				'Insert ListView
				lstMostBorrowedBook.Items.Add(lvi)

				'Insert Chart
				chartMostBorrowedBook.Series("Count").Points.AddXY(record.BookName, record.Count)

			Next
		End Using
	End Sub

	Private Sub dtpSelectDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpSelectDate.ValueChanged
		'Clear all points first and display new record.
		lstMostBorrowedBook.Items.Clear()
		chartMostBorrowedBook.Series("Count").Points.Clear()
		GetQueryReport()
	End Sub

	Private Sub btnEasyRpt_Click(sender As Object, e As EventArgs) Handles btnEasyRpt.Click


		easyRpt.ShowPrintPreviewDialog()
	End Sub
End Class
