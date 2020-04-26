Public Class Login

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Using database As New LibDBDataContext()

            Dim username As String = TextBox_Username.Text
            Dim password As String = TextBox_Passowrd.Text

            Dim chkUser = From a In database.AdminLibs
                          Where a.Name.Equals(username) And
                          a.Password.Equals(password)

            If chkUser.Any() Then
                Label_Message.Text = "Successfully logged in!"
                Form_StonksLib.Show()

            Else
                Label_Message.Text = "Invalid user name or password!"
            End If
        End Using
    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Username.KeyDown, TextBox_Passowrd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Login_Click(Button_Login, EventArgs.Empty)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (TextBox_Passowrd.PasswordChar = "*") Then
            PictureBox1.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.visible
            TextBox_Passowrd.PasswordChar = ""
        Else
            PictureBox1.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.not_visible
            TextBox_Passowrd.PasswordChar = "*"
        End If
    End Sub
End Class