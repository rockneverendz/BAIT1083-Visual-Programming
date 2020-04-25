Public Class UserControl_RoomBooking
	'Private time() As String = {"8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM"}
	Private time() As Integer = {8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19}

	Private Sub SearchPatron()
		Using db As New LibDBDataContext()
			Try
				Dim patronID As Integer = Integer.Parse(txtPatronID.Text)

				Dim patron As Patron = db.Patrons.FirstOrDefault(
					Function(e) e.Patron_ID.Equals(patronID)
				)

				If IsNothing(patron) Then
					lblName.Text = ""
					MessageBox.Show("Patron ID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Else
					lblName.Text = patron.Name.ToString()
				End If

			Catch ex As Exception
				MessageBox.Show("Invalid inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End Using
	End Sub

	Private Sub SearchRoomByDate(searchDate As Date)

		lstAvailabilityChart.Items.Clear()
		Using db As New LibDBDataContext()

			'Dim counter As Integer = 0
			Dim flag As Boolean = False


			'Loop Room ID from 1 to 20		ROWS
			For Each room In db.Rooms

				Dim row() As String = {
					"R" & room.Room_Id & " (" & room.Size & ")"
				}

				Dim lvi = New ListViewItem(row) With {
					.UseItemStyleForSubItems = False,   'Disable default style or color for the subitems
					.BackColor = Color.WhiteSmoke
				}
				lstAvailabilityChart.Items.Add(lvi)

				'If the roombooking is not found --> All column green
				'Else the roombooking is found --> 
				'	If the time is match with checkin time 
				'		Blue
				'	Else 
				'		Green

				'Loop Time column
				For Each t In time
					'counter += 1

					If flag.Equals(True) Then
						lvi.SubItems.Add("").BackColor = Color.DodgerBlue
						flag = False
					ElseIf IsNothing(GetRoomBooking(searchDate, room, t)) Then
						lvi.SubItems.Add("").BackColor = Color.Green
					Else
						lvi.SubItems.Add("").BackColor = Color.DodgerBlue
						flag = True
					End If
				Next

			Next

		End Using
	End Sub

	Private Function GetRoomBooking(searchDate As Date, room As Room, time As Integer) As RoomBooking
		Using db As New LibDBDataContext()
			Try
				'To get the roombooking that is match with the selected date
				Dim roombooked As RoomBooking = db.RoomBookings.First(
						Function(o) o.Room_ID = room.Room_Id And
						o.CheckIn_Date.Day = searchDate.Day And
						o.CheckIn_Date.Month = searchDate.Month And
						o.CheckIn_Date.Year = searchDate.Year And
						o.Start_Time.Equals(time)
					)

				GetRoomBooking = roombooked
			Catch ex As Exception
				GetRoomBooking = Nothing
			End Try
		End Using
	End Function

	Private Sub UserControl_RoomBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Cursor = Cursors.WaitCursor
		SearchRoomByDate(Today)
		dtpAddDate.MinDate = Today                      '<-------------Testing--------
		Cursor = Cursors.Default

	End Sub

	Private Sub btnSearchStudent_Click(sender As Object, e As EventArgs) Handles btnSearchStudent.Click
		SearchPatron()
	End Sub

	Private Sub dtpSearch_ValueChanged(sender As Object, e As EventArgs) Handles dtpSearch.ValueChanged
		SearchRoomByDate(dtpSearch.Value)

	End Sub

	Private Sub cmbStartTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStartTime.SelectedIndexChanged

		txtEndTime.Text = parseTimeToString(time(cmbStartTime.SelectedIndex + 2))
	End Sub

	Private Sub lstAvailabilityChart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAvailabilityChart.SelectedIndexChanged
		Using db As New LibDBDataContext()
			Try
				'When the room is selected in availability chart 
				'display Room id And room size to textbox
				Dim selectedRoomID As String = lstAvailabilityChart.Items(lstAvailabilityChart.FocusedItem.Index).SubItems(0).Text.Substring(1, 4)
				Dim selectedRoom As Room = db.Rooms.FirstOrDefault(
						Function(r) r.Room_Id.Equals(selectedRoomID)
					)

				txtRmID.Text = "R" & selectedRoom.Room_Id
				txtPax.Text = selectedRoom.Size

			Catch ex As Exception
				Console.WriteLine(ex.ToString)
				MessageBox.Show("Invalid inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try

		End Using
	End Sub

	Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

		Dim format = "dd/MM/yyyy"
		Dim dateString As String = dtpAddDate.Value.ToString(format)
		Dim dateValue As Date = Date.ParseExact(dateString, format, Nothing)

		Using db As New LibDBDataContext()
			Try
				Dim rb As New RoomBooking
				rb.Patron_ID = Integer.Parse(txtPatronID.Text)
				rb.Room_ID = Integer.Parse(txtRmID.Text.Substring(1, 4))
				rb.CheckIn_Date = dateValue
				rb.Start_Time = parseTimeToInt(cmbStartTime.Text)                       '<-------
				rb.End_Time = parseTimeToInt(txtEndTime.Text)                           '<-------
				'insert record
				db.RoomBookings.InsertOnSubmit(rb)
				db.SubmitChanges()

				SearchRoomByDate(dateValue)

				MessageBox.Show("The room booking details has been successfully added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)


			Catch ex As Exception
				Console.WriteLine(ex.Message)
				MessageBox.Show("Some error has occur due to invalid input or the student has been registered the room booking detail duplicate is not allowed", "An Error has occur!", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try

		End Using

	End Sub

	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click, btnSubmit.Click
		txtPatronID.Text = ""
		lblName.Text = ""
		txtRmID.Text = ""
		txtPax.Text = ""
		dtpAddDate.Hide()
		dtpAddDate.Show()
		cmbStartTime.Text = ""
		txtEndTime.Text = ""


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
