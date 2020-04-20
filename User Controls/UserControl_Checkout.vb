Public Class UserControl_Checkout

    Dim Today As Date = Date.Today

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.TextBox_DueDate.Text = Today.ToLongDateString
    End Sub

    Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles Button_Search.Click
        Dim Patron_ID As Integer
        If Integer.TryParse(TextBox_PatronID.Text, Patron_ID) Then
            RetrivePatron(Patron_ID)
        Else
            MessageBox.Show("Invalid Patron ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub RetrivePatron(Patron_ID As Integer)
        Using database As New LibDBDataContext()
            Dim patron = database.Patrons.FirstOrDefault(Function(o) o.Patron_ID = Patron_ID)
            If Not IsNothing(patron) Then
                TextBox_ID.Text = patron.Patron_ID
                TextBox_Name.Text = patron.Name
                TextBox_Course.Text = patron.Course
                TextBox_PhoneNo.Text = patron.PhoneNo
                TextBox_Address.Text = patron.Address
                TextBox_Email.Text = patron.Email
            Else
                MessageBox.Show("Patron ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub NumericUpDown_Weeks_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Weeks.ValueChanged
        Me.TextBox_DueDate.Text = Today.AddDays(NumericUpDown_Weeks.Value * 7).ToLongDateString
    End Sub


End Class
