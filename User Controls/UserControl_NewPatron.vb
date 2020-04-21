Public Class UserControl_NewPatron

    Private Sub UserControl_NewPatron_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbCourse.Items.Add("RSD")
        cmbCourse.Items.Add("RIS")
        cmbCourse.Items.Add("RST")
        cmbCourse.SelectedItem = "RSD"

    End Sub

End Class
