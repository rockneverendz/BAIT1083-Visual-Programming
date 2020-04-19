Public Class UserControl_Checkout

    Dim Today As Date = Date.Today

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DateTimePicker_DueDate.MinDate = Today
        Me.DateTimePicker_DueDate.Value = Today.AddDays(NumericUpDown_Weeks.Value * 7)
    End Sub

    Private Sub NumericUpDown_Weeks_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_Weeks.ValueChanged
        Me.DateTimePicker_DueDate.Value = Today.AddDays(NumericUpDown_Weeks.Value * 7)
    End Sub

    Private Sub DateTimePicker_DueDate_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_DueDate.ValueChanged

    End Sub
End Class
