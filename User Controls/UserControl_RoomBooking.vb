Public Class UserControl_RoomBooking

	Private Sub SearchPatron()
		Using db As New LibDBDataContext()
			Try
				Dim patronID As Integer = Integer.Parse(txtPatronID.Text)

				Dim patron As Patron = db.Patrons.FirstOrDefault(Function(e) e.Patron_ID.Equals(patronID))

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
		Using db As New LibDBDataContext()

			Dim flag As Boolean = False
			Dim time() As String = {"8:00 AM", "8:30 AM", "9:00 AM", "9:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "12:00 PM", "12:30 PM", "1:00 PM", "1:30 PM", "2:00 PM", "2:30 PM", "3:00 PM", "3:30 PM", "4:00 PM", "4:30 PM", "5:00 PM", "5:30 PM", "6:00 PM", "6:30 PM", "7:00 PM"}

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


				If GetRoomBooking(searchDate, room) Is Nothing Then
					'Loop Time column
					For Each t In time
						lvi.SubItems.Add("").BackColor = Color.Green
					Next
				Else
					'Loop Time column
					For Each t In time
						If GetRoomBooking(searchDate, room).CheckIn_Date.Equals(t) Then
							lvi.SubItems.Add("").BackColor = Color.DodgerBlue
							lvi.SubItems.Add("").BackColor = Color.DodgerBlue
						Else
							lvi.SubItems.Add("").BackColor = Color.Green
						End If


					Next
				End If
			Next

		End Using
	End Sub

	Private Function GetRoomBooking(searchDate As Date, room As Room) As RoomBooking
		Using db As New LibDBDataContext()
			Try
				'To get the roombooking that is match with the selected date
				Dim roombooked As RoomBooking = db.RoomBookings.First(Function(o) o.Room_ID = room.Room_Id And o.Date_Time.Day = searchDate.Day And o.Date_Time.Month = searchDate.Month And o.Date_Time.Year = searchDate.Year)

				GetRoomBooking = roombooked
			Catch ex As Exception
				GetRoomBooking = Nothing
			End Try
		End Using
	End Function

	Private Sub UserControl_RoomBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Using db As New LibDBDataContext()

			SearchRoomByDate(Today)


			'Dim item1 As ListViewItem = lstAvailabilityChart.Items.Add("R1001")
			''Disable default style or color for the subitems
			'item1.UseItemStyleForSubItems = False
			''Add color to subitems
			'item1.SubItems.Add("").BackColor = Color.Green
			'item1.SubItems.Add("").BackColor = Color.Green

			'Dim item2 As ListViewItem = lstAvailabilityChart.Items.Add("R1002")
			''Disable default style or color for the subitems
			'item2.UseItemStyleForSubItems = False
			''Add color to subitems
			'item2.SubItems.Add("").BackColor = Color.Green
			'item2.SubItems.Add("").BackColor = Color.Green
		End Using
	End Sub

	Private Sub btnSearchStudent_Click(sender As Object, e As EventArgs) Handles btnSearchStudent.Click
		SearchPatron()
	End Sub

	Private Sub dtpSearch_ValueChanged(sender As Object, e As EventArgs) Handles dtpSearch.ValueChanged
		lstAvailabilityChart.Items.Clear()
		SearchRoomByDate(dtpSearch.Value)
	End Sub

End Class
