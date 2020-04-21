Public Class UserControl_Profile
    Private Sub UserControl_Profile_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel1.BackColor = Color.FromArgb(100, 192, 192, 192)
        GroupBox1.BackColor = Color.FromArgb(100, 192, 192, 192)
        Label1.BackColor = Color.FromArgb(100, 192, 192, 192)
        Label2.BackColor = Color.FromArgb(100, 192, 192, 192)
        Label6.BackColor = Color.FromArgb(100, 192, 192, 192)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (txtCurrentPass.PasswordChar = "*") Then
            PictureBox1.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.visible
            txtCurrentPass.PasswordChar = ""
        Else
            PictureBox1.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.not_visible
            txtCurrentPass.PasswordChar = "*"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If (txtNewPass.PasswordChar = "*") Then
            PictureBox2.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.visible
            txtNewPass.PasswordChar = ""
        Else
            PictureBox2.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.not_visible
            txtNewPass.PasswordChar = "*"
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If (txtConfirmNewPass.PasswordChar = "*") Then
            PictureBox3.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.visible
            txtConfirmNewPass.PasswordChar = ""
        Else
            PictureBox3.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.not_visible
            txtConfirmNewPass.PasswordChar = "*"
        End If
    End Sub
End Class
