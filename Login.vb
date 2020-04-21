Public Class Login
    Dim database As New LibDBDataContext()

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Dim username As String = TextBox_Username.Text
        Dim password As String = TextBox_Passowrd.Text

        Dim chkUser = From a In database.AdminLibs
                      Where a.Name.Contains(username) And
                          a.Password.Contains(password)

        If chkUser.Any() Then
            Label_Message.Text = "Successfully logged in!"
            Form_StonksLib.Show()

        Else
            Label_Message.Text = "Invalid user name or password!"
        End If

    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Username.KeyDown, TextBox_Passowrd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Login_Click(Button_Login, EventArgs.Empty)
        End If
    End Sub

End Class