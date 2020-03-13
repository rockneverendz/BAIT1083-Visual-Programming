Public Class Form_StonksLib
    Private Sub ToolStrip_BookDetails_Click(sender As Object, e As EventArgs) Handles ToolStrip_BookDetails.Click
        If (SplitContainer_BookList.Panel2Collapsed) Then
            SplitContainer_BookList.Panel2Collapsed = False
        Else
            SplitContainer_BookList.Panel2Collapsed = True
        End If
    End Sub
End Class
