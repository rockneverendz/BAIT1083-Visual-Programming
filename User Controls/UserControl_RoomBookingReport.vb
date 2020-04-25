Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.Remoting.Messaging
Imports System.Text
Imports KimToo

Public Class UserControl_RoomBookingReport
	Private Sub UserControl_RoomBookingReport_Load(sender As Object, e As EventArgs) Handles Me.Load
		GetQueryReport()

	End Sub

	Private Sub GetQueryReport()
		Using db As New LibDBDataContext()
			'Select Case Count(CheckIn_Date) As MostBookingPeriod , CheckIn_Date
			'         From RoomBooking
			'         Where Date_Time ='2020-04-18'
			'Group by CheckIn_Date
			'Order by COUNT(CheckIn_Date) DESC;

			Dim format = "dd/MM/yyyy"
			Dim dateString As String = dtpSelectDate.Value.ToString(format)
			Dim dateValue As Date = Date.ParseExact(dateString, format, Nothing)

			Dim rs = From rb In db.RoomBookings
					 Where rb.CheckIn_Date.Month.Equals(dateValue.Month) And
						 rb.CheckIn_Date.Year.Equals(dateValue.Year)
					 Group By StartTime = rb.Start_Time
					 Into CountTime = Group, Count()
					 Order By StartTime

			For Each rbookingByTime In rs
				Dim row() As String = {
					parseTimeToString(rbookingByTime.StartTime),
					rbookingByTime.Count
				}
				Dim lvi = New ListViewItem(row)
				lstQueryRpt.Items.Add(lvi)

				'Add Chart
				chartTimeCount.Series("Count").Points.AddXY(parseTimeToString(rbookingByTime.StartTime), rbookingByTime.Count)
				'Console.WriteLine(rbookingByTime.CheckInTime & " (" & rbookingByTime.Count & ")" & vbCrLf)
			Next
		End Using
	End Sub

	Private Function parseTimeToString(time As Integer) As String
		'This function is use to parse integer in time to string
		If time < 12 Then
			parseTimeToString = time & ":00 AM"
		ElseIf time.Equals(12) Then
			parseTimeToString = time & ":00 PM"
		Else
			parseTimeToString = (time - 12) & ":00 PM"
		End If
	End Function

	Private Sub dtpSelectDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpSelectDate.ValueChanged
		'Clear all points first and display new record.
		lstQueryRpt.Items.Clear()
		chartTimeCount.Series("Count").Points.Clear()
		GetQueryReport()
	End Sub

	Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

		dlgPreview.Document = doc
		dlgPreview.ShowDialog(Me)

	End Sub

	Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage

		' (1) Fonts
		Dim fontHeader As New Font("Roboto Mono", 24, FontStyle.Bold)
		Dim fontSubHeader As New Font("Calibri", 12)
		Dim fontBody As New Font("Arial", 11)

		' (2) Prepare header and sub-header
		Dim header As String = "Room Booking Report"
		Dim subHeader As String = String.Format(
			"Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
			"Prepared by Admin", DateTime.Now
		)

		' (3) Prepare body
		Dim body As New StringBuilder()

		Dim headerStr() As String = {"No", "Time", "Count"}
		Dim headerStr2() As String = {"--", "----", "-----"}

		body.AppendFormat("{0,-5}   {1, 20}   {2, 10}" & vbNewLine,
						  headerStr(0), headerStr(1), headerStr(2))
		body.AppendFormat("{0,-5}   {1, 20}   {2, 10}" & vbNewLine,
						  headerStr2(0), headerStr2(1), headerStr2(2))

		Dim cnt As Integer = 0 ' Keep track of the line count
		Dim cnt2 As Integer = 0
		For Each item In lstQueryRpt.Items
			cnt += 1

			'parts = CStr(lstItem).Split(CChar(vbTab)) ' parts(0) is Time Column, parts(1) is Count Column
			'lstQueryRpt.Items(0).SubItems.ToString()
			Dim timeStr As String = lstQueryRpt.Items(cnt2).SubItems(0).Text
			Dim countStr As String = lstQueryRpt.Items(cnt2).SubItems(1).Text

			body.AppendFormat("{0, -5}{1, 20}{2, 10}" & vbNewLine, cnt, timeStr, countStr)
			Console.WriteLine("{0, -5}{1, 20}{2, 10}" & vbNewLine, cnt, timeStr, countStr)

			cnt2 += 1
		Next

		body.AppendLine()
		body.AppendFormat("{0,2} record(s)", cnt)

		' (4) Print
		With e.Graphics
			.DrawImage(My.Resources.circle_cropped, 0, 0, 100, 100) ' Print the image with smaller size 100 x 100
			.DrawString(header, fontHeader, Brushes.Black, 150, 0)
			.DrawString(subHeader, fontSubHeader, Brushes.Black, 150, 40)
			.DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
		End With


	End Sub

	Private Sub btnEasyRpt_Click(sender As Object, e As EventArgs) Handles btnEasyRpt.Click


		' (3) Prepare body
		Dim body As New StringBuilder()

		Dim headerStr() As String = {"No", "Time", "Count"}
		Dim headerStr2() As String = {"--", "----", "-----"}

		body.AppendFormat("{0,-5}   {1, 20}   {2, 10}" & vbNewLine,
						  headerStr(0), headerStr(1), headerStr(2))
		body.AppendFormat("{0,-5}   {1, 20}   {2, 10}" & vbNewLine,
						  headerStr2(0), headerStr2(1), headerStr2(2))

		Dim cnt As Integer = 0 ' Keep track of the line count
		Dim cnt2 As Integer = 0
		For Each item In lstQueryRpt.Items
			cnt += 1

			'parts = CStr(lstItem).Split(CChar(vbTab)) ' parts(0) is Time Column, parts(1) is Count Column
			'lstQueryRpt.Items(0).SubItems.ToString()
			Dim timeStr As String = lstQueryRpt.Items(cnt2).SubItems(0).Text
			Dim countStr As String = lstQueryRpt.Items(cnt2).SubItems(1).Text

			body.AppendFormat("{0, -5}{1, 20}{2, 10}" & vbNewLine, cnt, timeStr, countStr)
			Console.WriteLine("{0, -5}{1, 20}{2, 10}" & vbNewLine, cnt, timeStr, countStr)

			cnt2 += 1
		Next

		body.AppendLine()
		body.AppendFormat("{0,2} record(s)", cnt)

		'---Adding resources to Print Preview---

		'Add logo
		Dim header As String = "Room Booking Report"
		Dim subHeader As String = String.Format(
			"Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & "</br>" &
			"Prepared by Admin", DateTime.Now
		)
		easyRpt.AddImage(My.Resources.circle_cropped, "width='120' float: left")
		easyRpt.AddString("<h2>Room Booking Report</h2>", "float: left")
		easyRpt.AddString("<h2>" & subHeader & "</h2>", "float: left")


		easyRpt.AddString("</div>")

		'Add Chart
		easyRpt.AddControl(chartTimeCount)

		'Add ListView
		easyRpt.AddString(body.ToString)
		easyRpt.ShowPrintPreviewDialog()
	End Sub
End Class
