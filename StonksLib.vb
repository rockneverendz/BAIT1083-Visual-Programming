Public Class Form_StonksLib
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '' First UserControl which appear after login
        ToolStrip_Button_Click(Menu_BookList, EventArgs.Empty)
    End Sub

    'TODO: Add instance into each class so we don't have to construct them everytime.
    Private Sub ToolStrip_Button_Click(sender As Object, e As EventArgs) Handles Menu_Checkout.Click, Menu_BookList.Click
        Dim UserControls() As UserControl

        If (sender.Equals(Menu_BookList)) Then

            ' BookList is the first control
            ' BookDetails is be second control which requires parameters from BookList
            Dim bookList As UserControl_BookList = New BAIT1083_Visual_Programming.UserControl_BookList()
            Dim bookDetails As UserControl_BookDetails = New BAIT1083_Visual_Programming.UserControl_BookDetails()

            ' BookList needs a reference to BookDetails to pass down value.
            ' Both need reference to each other to show and hide each other.
            bookList.BookDetails() = bookDetails
            bookDetails.BookList() = bookList

            UserControls = {bookList, bookDetails}

        ElseIf (sender.Equals(Menu_Checkout)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_Checkout()}
        Else
            'User should not reach here'
            UserControls = {New UserControl()}
        End If

        Panel_Main.Controls.Clear()
        Panel_Main.Controls.AddRange(UserControls)
        UserControls(0).AutoSize = True
        UserControls(0).Dock = System.Windows.Forms.DockStyle.Fill
    End Sub
End Class
