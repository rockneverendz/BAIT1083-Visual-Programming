Public Class Login

    Private _userid As String

    Public Property Userid As String
        Get
            Return _userid
        End Get
        Set(value As String)
            _userid = value
        End Set
    End Property

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Using database As New LibDBDataContext()

            Dim username As String = TextBox_Username.Text
            Dim password As String = TextBox_Passowrd.Text

            Dim chkUser = From a In database.AdminLibs
                          Where a.Name.Equals(username) And
                          a.Password.Equals(password)

            If chkUser.Any() Then
                Label_Message.Text = "Successfully logged in!"
                Label_Message.ForeColor = Color.Green
                Userid = chkUser.First.Admin_ID
                Form_StonksLib.Show()
                Me.Hide()

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