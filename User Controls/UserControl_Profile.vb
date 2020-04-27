Public Class UserControl_Profile

    Private Sub GetAdmin()
        Dim useridStr As String = Login.Userid

        Using db As New LibDBDataContext()
            Dim admin As AdminLib = db.AdminLibs.First(Function(a) a.Admin_ID.Equals(useridStr))
            txtID.Text = admin.Admin_ID
            txtName.Text = admin.Name
        End Using

    End Sub

    Private Sub UserControl_Profile_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel1.BackColor = Color.FromArgb(100, 192, 192, 192)
        GroupBox1.BackColor = Color.FromArgb(100, 192, 192, 192)
        Label1.BackColor = Color.FromArgb(100, 192, 192, 192)
        Label2.BackColor = Color.FromArgb(100, 192, 192, 192)
        Label6.BackColor = Color.FromArgb(100, 192, 192, 192)

        'Get Admin Profile
        GetAdmin()
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

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim useridStr As String = Login.Userid

        Try
            Using db As New LibDBDataContext()
                Dim admin As AdminLib = db.AdminLibs.First(Function(a) a.Admin_ID.Equals(useridStr))

                If txtCurrentPass.Text.Equals(admin.Password) Then
                    lblCurrentPass.Visible = False
                    If txtNewPass.Text IsNot "" Then
                        lblIsNull.Visible = False
                        If txtNewPass.Text.Equals(txtConfirmNewPass.Text) Then
                            lblNewPass.Visible = False

                            'Get New Profile Details
                            admin.Name = txtName.Text
                            admin.Password = txtConfirmNewPass.Text
                            'Update Profile
                            db.SubmitChanges()
                            MessageBox.Show("The profile has successfully updated!", "Profile Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            'Clear all
                            GetAdmin()
                            txtConfirmNewPass.Text = ""
                            txtCurrentPass.Text = ""
                            txtNewPass.Text = ""

                        Else
                            lblNewPass.Visible = True
                        End If
                    Else
                        lblIsNull.Visible = True
                    End If
                Else
                    lblCurrentPass.Visible = True
                End If
            End Using
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtConfirmNewPass.Text = ""
        txtCurrentPass.Text = ""
        txtNewPass.Text = ""
        lblCurrentPass.Visible = False
        lblNewPass.Visible = False
        lblIsNull.Visible = False
    End Sub
End Class
