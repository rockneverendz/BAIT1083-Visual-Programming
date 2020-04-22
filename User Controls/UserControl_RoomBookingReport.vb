Public Class UserControl_RoomBookingReport
	Private Sub UserControl_RoomBookingReport_Load(sender As Object, e As EventArgs) Handles Me.Load





		chartTimeCount.Series("Count").Points.AddXY("8.00 AM", 10)
		chartTimeCount.Series("Count").Points.AddXY("9.00 AM", 9)
		chartTimeCount.Series("Count").Points.AddXY("10.00 AM", 8)
		chartTimeCount.Series("Count").Points.AddXY("11.00 AM", 7)


		GetQueryReport()


	End Sub

	Private Sub GetQueryReport()
		Using db As New LibDBDataContext()

			Dim rs = From rb In db.RoomBookings
					 Group By CheckInTime = rb.Start_Time
					 Into CountTime = Group, Count()
			'Order By CheckInTime

			For Each rbookingByTime In rs
				Dim row() As String = {
					rbookingByTime.CheckInTime.ToString("h:mm tt"),
					rbookingByTime.Count
				}
				Dim lvi = New ListViewItem(row)
				lstQueryRpt.Items.Add(lvi)

				Console.WriteLine(rbookingByTime.CheckInTime.ToString("h:mm tt") &
					  " (" & rbookingByTime.Count & ")" & vbCrLf)
			Next


			'Where rb.Date_Time.Day.Equals(14) And
			'			rb.Date_Time.Month.Equals(8) And
			'			rb.Date_Time.Year.Equals(2020)

			'Select Case Count(CheckIn_Date) As MostBookingPeriod , CheckIn_Date
			'         From RoomBooking
			'         Where Date_Time ='2020-04-18'
			'Group by CheckIn_Date
			'Order by COUNT(CheckIn_Date) DESC;

		End Using
	End Sub
End Class
