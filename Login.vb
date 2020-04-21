Public Class Login
    Dim db As New LibDBDataContext()

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text


        Dim chkUser = From a In db.AdminLibs
                      Where a.Name.Contains(username) And
                              a.Password.Contains(password)

        If chkUser.Any() Then
            lblMessage.Text = "Successfully logged in!"
            Form_StonksLib.Show()

        Else
            lblMessage.Text = "Invalid user name or password!"
        End If

    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Username.KeyDown, TextBox_Passowrd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Login_Click(Button_Login, EventArgs.Empty)
        End If
    End Sub
End Class