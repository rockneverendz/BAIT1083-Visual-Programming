Public Class UserControl_RoomBooking

	Private Sub BindData()
		Dim db As New LibDBDataContext()
		Try
			Dim patronID As Integer = Integer.Parse(txtPatronID.Text)
			'Dim rs = From p In db.Patrons
			'Where p.Patron_ID = patronID
			'Select Case p.Patron_ID, p.Name

			Dim patron As Patron = db.Patrons.FirstOrDefault(Function(e) e.Patron_ID.Equals(patronID))

			'Console.WriteLine(rs)

			'dgvPatron.DataSource = rs    //DataGridView to Patron
			lblName.Text = patron.Name.ToString()

		Catch ex As Exception
			Console.WriteLine(ex.ToString)
		End Try


	End Sub

	Private Sub UserControl_RoomBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		'Testing
		Dim db As New LibDBDataContext()

		Try
			Dim rs = From rb In db.RoomBookings
					 Where rb.Room_ID = "1001"

			dgvTest.DataSource = rs
		Catch ex As Exception

		End Try
		'End Testing




		Dim item1 As ListViewItem = lstAvailabilityChart.Items.Add("R1001")
		'Disable default style or color for the subitems
		item1.UseItemStyleForSubItems = False
		'Add color to subitems
		item1.SubItems.Add("").BackColor = Color.Green
		item1.SubItems.Add("").BackColor = Color.Green

		Dim item2 As ListViewItem = lstAvailabilityChart.Items.Add("R1002")
		'Disable default style or color for the subitems
		item2.UseItemStyleForSubItems = False
		'Add color to subitems
		item2.SubItems.Add("").BackColor = Color.Green
		item2.SubItems.Add("").BackColor = Color.Green

	End Sub

	Private Sub btnSearchStudent_Click(sender As Object, e As EventArgs) Handles btnSearchStudent.Click
		BindData()
	End Sub
End Class
