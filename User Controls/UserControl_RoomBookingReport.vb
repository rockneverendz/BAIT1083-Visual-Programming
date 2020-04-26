Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.Remoting.Messaging
Imports System.Text
Imports KimToo

Public Class UserControl_RoomBookingReport
	Private Sub UserControl_RoomBookingReport_Load(sender As Object, e As EventArgs) Handles Me.Load
		GetQueryReport()

		lblDateNow.Text = String.Format("{0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now)
		lblPrintedBy.Text = "Admin"

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

		'Clear the control 1st to erase previous data
		easyRpt.Clear()

		'---Adding resources to Print Preview---

		' (1) Prepare Header
		easyRpt.AddControl(panForPrintHeader, )
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
		For Each item In lstQueryRpt.Items
			cnt += 1
			'Retrieve Data frm List View
			Dim timeStr As String = lstQueryRpt.Items(cnt2).SubItems(0).Text
			Dim countStr As String = lstQueryRpt.Items(cnt2).SubItems(1).Text
			'Transfer Data to DataGridView
			dgvForPrint.Rows.Add(cnt, timeStr, countStr)
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
