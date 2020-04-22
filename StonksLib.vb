Imports System.Runtime.Remoting.Channels
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form_StonksLib
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '' First UserControl which appear after login
        ToolStrip_Button_Click(Menu_BookList, EventArgs.Empty)
    End Sub

    'TODO: Add instance into each class so we don't have to construct them everytime.
    Private Sub ToolStrip_Button_Click(sender As Object, e As EventArgs) Handles _
        Menu_BookList.Click,
        Menu_Checkout.Click,
        Menu_Return.Click,
        Menu_NewRoomBooking.Click, Menu_ViewBookingHistory.Click, Menu_RBooking_Report.Click,
        Menu_PatronList.Click

        Dim UserControls() As UserControl

        If (sender.Equals(Menu_BookList)) Then

            ' BookList is the first control
            ' BookDetails is be second control which requires parameters from BookList
            Dim bookList As UserControl_BookList = New BAIT1083_Visual_Programming.UserControl_BookList()
            Dim bookDetails As UserControl_BookDetails = New BAIT1083_Visual_Programming.UserControl_BookDetails()
            ' Dim bookReturn As UserControl_ReturnBook = New BAIT1083_Visual_Programming.UserControl_ReturnBook()'
            ' BookList needs a reference to BookDetails to pass down value.
            ' Both need reference to each other to show and hide each other.
            bookList.BookDetails() = bookDetails
            bookDetails.BookList() = bookList
            ' bookDetails.BookList() = bookList'

            UserControls = {bookList, bookDetails}

        ElseIf (sender.Equals(Menu_Checkout)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_Checkout()}

        ElseIf (sender.Equals(Menu_Return)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_ReturnBook()}

        ElseIf (sender.Equals(Menu_NewRoomBooking)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_RoomBooking()}

        ElseIf (sender.Equals(Menu_ViewBookingHistory)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_RBookingHistory}

        ElseIf (sender.Equals(Menu_PatronList)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_PatronList()}

        ElseIf (sender.Equals(Menu_RBooking_Report)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_RoomBookingReport()}
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
