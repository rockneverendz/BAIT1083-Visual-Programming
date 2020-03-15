Public Class Form_StonksLib
    Private Sub ToolStrip_Button_Click(sender As Object, e As EventArgs) Handles ToolStrip_Checkout.Click, ToolStrip_BookList.Click
        Dim New_Control As UserControl

        If (sender.Equals(ToolStrip_BookList)) Then
            New_Control = New BAIT1083_Visual_Programming.BookList()
        ElseIf (sender.Equals(ToolStrip_Checkout)) Then
            New_Control = New BAIT1083_Visual_Programming.Checkout()
        Else
            'User should not reach here'
            New_Control = New UserControl()
        End If

        Panel_Main.Controls.Clear()
        Panel_Main.Controls.Add(New_Control)
        New_Control.AutoSize = True
        New_Control.Dock = System.Windows.Forms.DockStyle.Fill
    End Sub
End Class
