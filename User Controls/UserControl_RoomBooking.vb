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

			Dim counter As Integer = 0
			Dim flag As Boolean = False
			Dim time() As String = {"8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM"}

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
					counter += 1

					If flag.Equals(True) Then
						lvi.SubItems.Add(counter).BackColor = Color.DodgerBlue
						flag = False
					ElseIf IsNothing(GetRoomBooking(searchDate, room, t)) Then
						lvi.SubItems.Add(counter).BackColor = Color.Green
					Else
						lvi.SubItems.Add(counter).BackColor = Color.DodgerBlue
						flag = True
					End If
				Next

			Next

		End Using
	End Sub

	Private Function GetRoomBooking(searchDate As Date, room As Room, time As String) As RoomBooking
		Using db As New LibDBDataContext()
			Try
				'To get the roombooking that is match with the selected date
				Dim roombooked As RoomBooking = db.RoomBookings.First(Function(o) o.Room_ID = room.Room_Id And o.Date_Time.Day = searchDate.Day And o.Date_Time.Month = searchDate.Month And o.Date_Time.Year = searchDate.Year And o.CheckIn_Date.Equals(time))

				GetRoomBooking = roombooked
			Catch ex As Exception
				GetRoomBooking = Nothing
			End Try
		End Using
	End Function

	Private Sub UserControl_RoomBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Using db As New LibDBDataContext()
			SearchRoomByDate(Today)
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
