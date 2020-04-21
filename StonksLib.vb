﻿Public Class Form_StonksLib
    Private Sub ToolStrip_Button_Click(sender As Object, e As EventArgs) Handles Menu_Checkout.Click, Menu_BookList.Click, Menu_NewRoomBooking.Click, Menu_BookingHistory.Click
        Dim New_Control As UserControl

        If (sender.Equals(Menu_BookList)) Then
            New_Control = New BAIT1083_Visual_Programming.UserControl_BookList()
        ElseIf (sender.Equals(Menu_Checkout)) Then
            New_Control = New BAIT1083_Visual_Programming.UserControl_Checkout()
        ElseIf (sender.Equals(Menu_NewRoomBooking)) Then
            New_Control = New BAIT1083_Visual_Programming.UserControl_RoomBooking()
        ElseIf (sender.Equals(Menu_BookingHistory)) Then
            New_Control = New BAIT1083_Visual_Programming.UserControl_RBookingHistory()
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
