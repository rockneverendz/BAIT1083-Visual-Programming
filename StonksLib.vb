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
        Menu_ViewBookingHistory.Click, Menu_NewRoomBooking.Click,
        Menu_PatronList.Click

        Dim UserControls() As UserControl

        If (sender.Equals(Menu_BookList)) Then
            New_Control = New BAIT1083_Visual_Programming.UserControl_BookList()
            
        ElseIf (sender.Equals(Menu_Checkout)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_Checkout()}

        ElseIf (sender.Equals(Menu_Return)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_ReturnBook()}

        ElseIf (sender.Equals(Menu_Room)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_RoomBooking()}

        ElseIf (sender.Equals(Menu_NewRoomBooking)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_RoomBooking()}

        ElseIf (sender.Equals(Menu_ViewBookingHistory)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_RBookingHistory()}

        ElseIf (sender.Equals(Menu_PatronList)) Then
            UserControls = {New BAIT1083_Visual_Programming.UserControl_PatronList()}

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
