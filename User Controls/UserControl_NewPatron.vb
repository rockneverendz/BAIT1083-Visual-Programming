Public Class UserControl_NewPatron

    Public Property StonkLib As Form_StonksLib

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Using database As New LibDBDataContext()

            ' Get distinct courses
            Dim courses = (From patron In database.Patrons Select patron.Course).Distinct()
            For Each course In courses
                ComboBox_Course.Items.Add(course)
            Next

        End Using
    End Sub

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click

        'TODO: Validate Here

        Dim patron As Patron
        Using database As New LibDBDataContext()

            ' Create a new book
            patron = New Patron With {
                .Name = TextBox_Name.Text,
                .Course = ComboBox_Course.Text,
                .PhoneNo = TextBox_PhoneNo.Text,
                .Email = TextBox_Email.Text,
                .Address = TextBox_Address.Text
            }

            ' Insert books into database
            database.Patrons.InsertOnSubmit(patron)
            database.SubmitChanges()

        End Using

        StonkLib.Jump_PatronDetails(patron.Patron_ID)
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        TextBox_Name.Text = ""
        ComboBox_Course.Text = ""
        TextBox_PhoneNo.Text = ""
        TextBox_Email.Text = ""
        TextBox_Address.Text = ""
    End Sub
End Class
