Public Class UserControl_RBookingHistory
	Private Sub UserControl_RBookingHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
		'Dim format = "dd/MM/yyyy"
		'Dim dateString As String = Today.ToString
		'Dim TodayDate As Date = Date.ParseExact(dateString, format, Nothing)

		lstRBookingDetails.Items.Clear()
		DisplayRoomBookingDetails(Today)
	End Sub

	Private Sub DisplayRoomBookingDetails(searchDate As Date)
		lstRBookingDetails.Items.Clear()
		Using db As New LibDBDataContext()
			Dim counter As Integer = 0
			Dim rs = From rb In db.RoomBookings
					 Where rb.CheckIn_Date.Day = searchDate.Day And
						 rb.CheckIn_Date.Month = searchDate.Month And
						 rb.CheckIn_Date.Year = searchDate.Year
			Dim roombooking() As RoomBooking = rs.ToArray


			For Each rbooking In roombooking
				counter += 1

				Dim row() As String = {
					counter,
					rbooking.Room.Room_Id,
					rbooking.Room.Size,
					rbooking.Patron.Patron_ID,
					rbooking.Patron.Name,
					rbooking.CheckIn_Date,
					parseTimeToString(rbooking.Start_Time),                              '<----
					parseTimeToString(rbooking.End_Time)                                 '<----
				}
				Dim lvi = New ListViewItem(row)
				lstRBookingDetails.Items.Add(lvi)
			Next
		End Using
	End Sub

	Private Sub lstRBookingDetails_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRBookingDetails.SelectedIndexChanged

		'get the list view item details
		Dim sRoomID As Integer = Integer.Parse(lstRBookingDetails.Items(lstRBookingDetails.FocusedItem.Index).SubItems(1).Text)
		Dim sPatronID As Integer = Integer.Parse(lstRBookingDetails.Items(lstRBookingDetails.FocusedItem.Index).SubItems(3).Text)
		Dim sDate As Date = lstRBookingDetails.Items(lstRBookingDetails.FocusedItem.Index).SubItems(5).Text

		Dim rbDate As Date = New Date()

		Using db As New LibDBDataContext()
			Try
				Dim selectedRBooking As RoomBooking = db.RoomBookings.FirstOrDefault(
						Function(rb) rb.Room_ID.Equals(sRoomID) And
						rb.Patron_ID.Equals(sPatronID) And
						rb.CheckIn_Date.Equals(sDate)
					)
				txtRoomID.Text = selectedRBooking.Room_ID
				txtSize.Text = selectedRBooking.Room.Size
				txtPatronID.Text = selectedRBooking.Patron_ID
				txtPatronName.Text = selectedRBooking.Patron.Name
				txtDate.Text = selectedRBooking.CheckIn_Date
				txtStartTime.Text = parseTimeToString(selectedRBooking.Start_Time)     '<----
				txtEndTime.Text = parseTimeToString(selectedRBooking.End_Time)       '<----

			Catch ex As Exception
				Console.WriteLine(ex.ToString)
			End Try
		End Using

	End Sub

	Private Sub dtpSearchDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpSearchDate.ValueChanged

		DisplayRoomBookingDetails(dtpSearchDate.Value)

	End Sub

	Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
		txtStartTime.Hide()
		txtEndTime.Text = ""
		cmbStartTime.Show()
		btnConfirm.Show()
		'dtpUpdateDate.Show()

	End Sub

	Private Sub cmbStartTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStartTime.SelectedIndexChanged
		Dim time() As String = {"8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM"}
		txtEndTime.Text = time(cmbStartTime.SelectedIndex + 2)
	End Sub

	Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
		Using db As New LibDBDataContext()
			Try
				'Get Record
				Dim patronID As Integer = Integer.Parse(txtPatronID.Text)
				Dim roomID As Integer = Integer.Parse(txtRoomID.Text)
				Dim rbDate As Date = txtDate.Text
				Dim selectedRBooking As RoomBooking = db.RoomBookings.First(
						Function(rb) rb.Room_ID.Equals(roomID) And
						rb.Patron_ID.Equals(patronID) And
						rb.CheckIn_Date.Day.Equals(rbDate.Day) And
						rb.CheckIn_Date.Month.Equals(rbDate.Month) And
						rb.CheckIn_Date.Year.Equals(rbDate.Year)
					)
				'Update record
				Dim format = "dd/MM/yyyy"
				'Dim dateString As String = dtpUpdateDate.Value.ToString(format)
				Dim dateValue As Date = Date.ParseExact(dateString, format, Nothing)
				selectedRBooking.CheckIn_Date = dateValue
				selectedRBooking.Start_Time = parseTimeToInt(cmbStartTime.Text)         '<----
				selectedRBooking.End_Time = parseTimeToInt(txtEndTime.Text)             '<----

				db.SubmitChanges()
				DisplayRoomBookingDetails(dtpSearchDate.Value)
				MessageBox.Show("The record has successfully updated!", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

			Catch ex As Exception
				Console.WriteLine(ex.ToString)
				MessageBox.Show("Invalid inputs" & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End Using
	End Sub
	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo)

		If confirmation.Equals(DialogResult.Yes) Then
			Using db As New LibDBDataContext()
				Try
					'Get Record
					Dim patronID As Integer = Integer.Parse(txtPatronID.Text)
					Dim roomID As Integer = Integer.Parse(txtRoomID.Text)
					Dim rbDate As Date = txtDate.Text
					Dim selectedRBooking As RoomBooking = db.RoomBookings.First(
							Function(rb) rb.Room_ID.Equals(roomID) And
							rb.Patron_ID.Equals(patronID) And
							rb.CheckIn_Date.Day.Equals(rbDate.Day) And
							rb.CheckIn_Date.Month.Equals(rbDate.Month) And
							rb.CheckIn_Date.Year.Equals(rbDate.Year)
						)

					'Delete record 
					db.RoomBookings.DeleteOnSubmit(selectedRBooking)
					db.SubmitChanges()
					DisplayRoomBookingDetails(dtpSearchDate.Value)
					MessageBox.Show("The record has successfully deleted.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

				Catch ex As Exception
					Console.WriteLine(ex.ToString)
					MessageBox.Show("Invalid inputs" & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End Try
			End Using
		End If

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

	Private Function parseTimeToInt(time As String) As Integer
		'This function is use to parse string in time to integer
		Dim timeArr() As String = {"8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM"}
		Dim intTimeArr() As Integer = {8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19}
		Dim count As Integer = 0
		Dim result As Integer = 0
		For Each tArr In timeArr
			If time.Equals(tArr) Then
				result = intTimeArr.ElementAt(count)
			End If
			count += 1
		Next
		parseTimeToInt = result
	End Function


End Class
