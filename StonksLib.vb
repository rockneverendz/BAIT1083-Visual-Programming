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
        Menu_NewBook.Click, Menu_BookList.Click,
        Menu_Checkout.Click, Menu_MostCheckoutsPatronReport.Click,
        Menu_Return.Click,
        Menu_NewRoomBooking.Click, Menu_ViewBookingHistory.Click,
        Menu_NewPatron.Click, Menu_PatronList.Click, Menu_PatronInsightReport.Click,
        Menu_Profile.Click,
        Menu_RBooking_Report.Click, Menu_MostBorrowedBookReport.Click

        Dim UserControls() As UserControl

        If (sender.Equals(Menu_NewBook)) Then

            ' newBook needs a reference to this form to call Jump_BookDetails
            Dim newBook = New BAIT1083_Visual_Programming.UserControl_NewBook() With {
                .StonkLib = Me
            }
            UserControls = {newBook}

        ElseIf (sender.Equals(Menu_BookList)) Then

            ' BookList is the first control
            ' BookDetails is be second control which requires parameters from BookList
            Dim bookList = New BAIT1083_Visual_Programming.UserControl_BookList()
            Dim bookDetails = New BAIT1083_Visual_Programming.UserControl_BookDetails()
            ' BookList needs a reference to BookDetails to pass down value.
            ' Both need reference to each other to show and hide each other.
            bookList.BookDetails() = bookDetails
            bookDetails.BookList() = bookList

            UserControls = {bookList, bookDetails}

        ElseIf (sender.Equals(Menu_Checkout)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_Checkout()}

        ElseIf (sender.Equals(Menu_Return)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_ReturnBook()}

        ElseIf (sender.Equals(Menu_NewRoomBooking)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_RoomBooking()}

        ElseIf (sender.Equals(Menu_ViewBookingHistory)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_RBookingHistory}

        ElseIf (sender.Equals(Menu_NewPatron)) Then
            Dim newPatron = New BAIT1083_Visual_Programming.UserControl_NewPatron() With {
                .StonkLib = Me
            }
            UserControls = {newPatron}

        ElseIf (sender.Equals(Menu_PatronList)) Then

            Dim patronList = New BAIT1083_Visual_Programming.UserControl_PatronList()
            Dim patronDetails = New BAIT1083_Visual_Programming.UserControl_PatronDetails()
            patronList.PatronDetails() = patronDetails
            patronDetails.PatronList() = patronList

            UserControls = {patronList, patronDetails}

        ElseIf (sender.Equals(Menu_Profile)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_Profile()}

        ElseIf (sender.Equals(Menu_RBooking_Report)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_RoomBookingReport()}

        ElseIf (sender.Equals(Menu_MostBorrowedBookReport)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_MostBorrowedBookReport()}

        ElseIf (sender.Equals(Menu_PatronInsightReport)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_PatronInsightReport()}

        ElseIf (sender.Equals(Menu_MostCheckoutsPatronReport)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_MostChkOutPatronReport()}

        Else
            'User should not reach here'
            UserControls = {New UserControl()}
        End If

        AddControls(UserControls)
    End Sub

    Friend Sub Jump_BookDetails(book_ID As Integer)
        Dim UserControls() As UserControl

        Dim bookList = New BAIT1083_Visual_Programming.UserControl_BookList()
        Dim bookDetails = New BAIT1083_Visual_Programming.UserControl_BookDetails()
        bookList.BookDetails() = bookDetails
        bookDetails.BookList() = bookList
        bookDetails.Fill(book_ID)

        UserControls = {bookDetails, bookList}

        AddControls(UserControls)
    End Sub

    Friend Sub Jump_PatronDetails(patron_ID As Integer)
        Dim UserControls() As UserControl

        Dim patronList = New BAIT1083_Visual_Programming.UserControl_PatronList()
        Dim patronDetails = New BAIT1083_Visual_Programming.UserControl_PatronDetails()
        patronList.PatronDetails() = patronDetails
        patronDetails.PatronList() = patronList
        patronDetails.Fill(patron_ID)

        UserControls = {patronDetails, patronList}

        AddControls(UserControls)
    End Sub

    Private Sub AddControls(UserControls() As UserControl)
        Panel_Main.Controls.Clear()
        Panel_Main.Controls.AddRange(UserControls)
        UserControls(0).AutoSize = True
        UserControls(0).Dock = System.Windows.Forms.DockStyle.Fill
    End Sub
End Class
