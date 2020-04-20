Public Class UserControl_ReturnBook
    Private Sub NumericUpDown_Weeks_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker_DueDate_ValueChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub txtFeesPaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFeesPaid.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                        AndAlso (Not Char.IsDigit(e.KeyChar) _
                        AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If

        ' only allow one decimal point
        If ((e.KeyChar = Microsoft.VisualBasic.ChrW(46)) _
                    AndAlso (CType(sender, TextBox).Text.IndexOf(Microsoft.VisualBasic.ChrW(46)) > -1)) Then
            e.Handled = True
        End If
    End Sub
End Class
