Public Class UserControl_BookList
    Private Sub ToolStrip_BookDetails_Click(sender As Object, e As EventArgs) Handles Footer_BookDetails.Click
        If (SplitContainer_BookList.Panel2Collapsed) Then
            SplitContainer_BookList.Panel2Collapsed = False
            Footer_BookDetails.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_keyboard_arrow_right_black_18dp
        Else
            SplitContainer_BookList.Panel2Collapsed = True
            Footer_BookDetails.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.baseline_keyboard_arrow_left_black_18dp
        End If
    End Sub
End Class
