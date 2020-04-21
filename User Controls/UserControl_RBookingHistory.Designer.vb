<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_RBookingHistory
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.lstRBookingDetails = New System.Windows.Forms.ListView()
		Me.RowNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColRoomID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColRSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColPatronID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColPatronName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColStartTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColEndTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.dtpSearchDate = New System.Windows.Forms.DateTimePicker()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.btnEdit = New System.Windows.Forms.Button()
		Me.txtEndTime = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtDate = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtSize = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtRoomID = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtPatronName = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtPatronID = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtStartTime = New System.Windows.Forms.TextBox()
		Me.cmbStartTime = New System.Windows.Forms.ComboBox()
		Me.btnConfirm = New System.Windows.Forms.Button()
		Me.dtpUpdateDate = New System.Windows.Forms.DateTimePicker()
		Me.Panel1.SuspendLayout()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel1.Controls.Add(Me.lstRBookingDetails)
		Me.Panel1.Location = New System.Drawing.Point(3, 3)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(730, 597)
		Me.Panel1.TabIndex = 0
		'
		'lstRBookingDetails
		'
		Me.lstRBookingDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.RowNumber, Me.ColRoomID, Me.ColRSize, Me.ColPatronID, Me.ColPatronName, Me.ColDate, Me.ColStartTime, Me.ColEndTime})
		Me.lstRBookingDetails.HideSelection = False
		Me.lstRBookingDetails.Location = New System.Drawing.Point(3, 3)
		Me.lstRBookingDetails.Name = "lstRBookingDetails"
		Me.lstRBookingDetails.Size = New System.Drawing.Size(720, 590)
		Me.lstRBookingDetails.TabIndex = 0
		Me.lstRBookingDetails.UseCompatibleStateImageBehavior = False
		Me.lstRBookingDetails.View = System.Windows.Forms.View.Details
		'
		'RowNumber
		'
		Me.RowNumber.Text = "No."
		Me.RowNumber.Width = 35
		'
		'ColRoomID
		'
		Me.ColRoomID.Text = "Room ID"
		Me.ColRoomID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ColRoomID.Width = 70
		'
		'ColRSize
		'
		Me.ColRSize.Text = "Size"
		Me.ColRSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ColRSize.Width = 70
		'
		'ColPatronID
		'
		Me.ColPatronID.Text = "Patron ID"
		Me.ColPatronID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ColPatronID.Width = 70
		'
		'ColPatronName
		'
		Me.ColPatronName.Text = "Patron Name"
		Me.ColPatronName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ColPatronName.Width = 70
		'
		'ColDate
		'
		Me.ColDate.Text = "Date"
		Me.ColDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ColDate.Width = 70
		'
		'ColStartTime
		'
		Me.ColStartTime.Text = "Start Time"
		Me.ColStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ColStartTime.Width = 70
		'
		'ColEndTime
		'
		Me.ColEndTime.Text = "End Time"
		Me.ColEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ColEndTime.Width = 70
		'
		'SplitContainer1
		'
		Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.SplitContainer1.Location = New System.Drawing.Point(734, 3)
		Me.SplitContainer1.Name = "SplitContainer1"
		Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.dtpSearchDate)
		Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.dtpUpdateDate)
		Me.SplitContainer1.Panel2.Controls.Add(Me.btnConfirm)
		Me.SplitContainer1.Panel2.Controls.Add(Me.cmbStartTime)
		Me.SplitContainer1.Panel2.Controls.Add(Me.txtStartTime)
		Me.SplitContainer1.Panel2.Controls.Add(Me.btnDelete)
		Me.SplitContainer1.Panel2.Controls.Add(Me.btnEdit)
		Me.SplitContainer1.Panel2.Controls.Add(Me.txtEndTime)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
		Me.SplitContainer1.Panel2.Controls.Add(Me.txtDate)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
		Me.SplitContainer1.Panel2.Controls.Add(Me.txtSize)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
		Me.SplitContainer1.Panel2.Controls.Add(Me.txtRoomID)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
		Me.SplitContainer1.Panel2.Controls.Add(Me.txtPatronName)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
		Me.SplitContainer1.Panel2.Controls.Add(Me.txtPatronID)
		Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
		Me.SplitContainer1.Size = New System.Drawing.Size(360, 595)
		Me.SplitContainer1.SplitterDistance = 90
		Me.SplitContainer1.TabIndex = 0
		'
		'dtpSearchDate
		'
		Me.dtpSearchDate.Location = New System.Drawing.Point(23, 37)
		Me.dtpSearchDate.Name = "dtpSearchDate"
		Me.dtpSearchDate.Size = New System.Drawing.Size(200, 22)
		Me.dtpSearchDate.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(20, 17)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(110, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Search by Date:"
		'
		'btnDelete
		'
		Me.btnDelete.Location = New System.Drawing.Point(246, 304)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(87, 33)
		Me.btnDelete.TabIndex = 15
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseVisualStyleBackColor = True
		'
		'btnEdit
		'
		Me.btnEdit.Location = New System.Drawing.Point(153, 304)
		Me.btnEdit.Name = "btnEdit"
		Me.btnEdit.Size = New System.Drawing.Size(87, 33)
		Me.btnEdit.TabIndex = 14
		Me.btnEdit.Text = "Edit"
		Me.btnEdit.UseVisualStyleBackColor = True
		'
		'txtEndTime
		'
		Me.txtEndTime.Location = New System.Drawing.Point(177, 258)
		Me.txtEndTime.Name = "txtEndTime"
		Me.txtEndTime.ReadOnly = True
		Me.txtEndTime.Size = New System.Drawing.Size(122, 22)
		Me.txtEndTime.TabIndex = 13
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(151, 261)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(20, 17)
		Me.Label8.TabIndex = 12
		Me.Label8.Text = "to"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(20, 237)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(47, 17)
		Me.Label7.TabIndex = 10
		Me.Label7.Text = "Time: "
		'
		'txtDate
		'
		Me.txtDate.Location = New System.Drawing.Point(23, 184)
		Me.txtDate.Name = "txtDate"
		Me.txtDate.ReadOnly = True
		Me.txtDate.Size = New System.Drawing.Size(173, 22)
		Me.txtDate.TabIndex = 9
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(20, 164)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(46, 17)
		Me.Label6.TabIndex = 8
		Me.Label6.Text = "Date: "
		'
		'txtSize
		'
		Me.txtSize.Location = New System.Drawing.Point(187, 114)
		Me.txtSize.Name = "txtSize"
		Me.txtSize.ReadOnly = True
		Me.txtSize.Size = New System.Drawing.Size(146, 22)
		Me.txtSize.TabIndex = 7
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(184, 94)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(39, 17)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Size:"
		'
		'txtRoomID
		'
		Me.txtRoomID.Location = New System.Drawing.Point(23, 114)
		Me.txtRoomID.Name = "txtRoomID"
		Me.txtRoomID.ReadOnly = True
		Me.txtRoomID.Size = New System.Drawing.Size(146, 22)
		Me.txtRoomID.TabIndex = 5
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(20, 94)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(66, 17)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Room ID:"
		'
		'txtPatronName
		'
		Me.txtPatronName.Location = New System.Drawing.Point(187, 44)
		Me.txtPatronName.Name = "txtPatronName"
		Me.txtPatronName.ReadOnly = True
		Me.txtPatronName.Size = New System.Drawing.Size(146, 22)
		Me.txtPatronName.TabIndex = 3
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(184, 24)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(99, 17)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Patron Name: "
		'
		'txtPatronID
		'
		Me.txtPatronID.Location = New System.Drawing.Point(23, 44)
		Me.txtPatronID.Name = "txtPatronID"
		Me.txtPatronID.ReadOnly = True
		Me.txtPatronID.Size = New System.Drawing.Size(146, 22)
		Me.txtPatronID.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(20, 24)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(71, 17)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Patron ID:"
		'
		'txtStartTime
		'
		Me.txtStartTime.Location = New System.Drawing.Point(24, 258)
		Me.txtStartTime.Name = "txtStartTime"
		Me.txtStartTime.ReadOnly = True
		Me.txtStartTime.Size = New System.Drawing.Size(121, 22)
		Me.txtStartTime.TabIndex = 16
		'
		'cmbStartTime
		'
		Me.cmbStartTime.FormattingEnabled = True
		Me.cmbStartTime.Items.AddRange(New Object() {"8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM"})
		Me.cmbStartTime.Location = New System.Drawing.Point(24, 257)
		Me.cmbStartTime.Name = "cmbStartTime"
		Me.cmbStartTime.Size = New System.Drawing.Size(121, 24)
		Me.cmbStartTime.TabIndex = 17
		Me.cmbStartTime.Visible = False
		'
		'btnConfirm
		'
		Me.btnConfirm.Location = New System.Drawing.Point(23, 304)
		Me.btnConfirm.Name = "btnConfirm"
		Me.btnConfirm.Size = New System.Drawing.Size(87, 33)
		Me.btnConfirm.TabIndex = 18
		Me.btnConfirm.Text = "Confirm"
		Me.btnConfirm.UseVisualStyleBackColor = True
		Me.btnConfirm.Visible = False
		'
		'dtpUpdateDate
		'
		Me.dtpUpdateDate.Location = New System.Drawing.Point(23, 184)
		Me.dtpUpdateDate.Name = "dtpUpdateDate"
		Me.dtpUpdateDate.Size = New System.Drawing.Size(200, 22)
		Me.dtpUpdateDate.TabIndex = 19
		Me.dtpUpdateDate.Visible = False
		'
		'UserControl_RBookingHistory
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.SplitContainer1)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "UserControl_RBookingHistory"
		Me.Size = New System.Drawing.Size(1097, 603)
		Me.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel1.PerformLayout()
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.Panel2.PerformLayout()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents lstRBookingDetails As ListView
	Friend WithEvents Panel1 As Panel
	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents btnDelete As Button
	Friend WithEvents btnEdit As Button
	Friend WithEvents txtEndTime As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents txtDate As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents txtSize As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtRoomID As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents txtPatronName As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtPatronID As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents dtpSearchDate As DateTimePicker
	Friend WithEvents Label1 As Label
	Friend WithEvents RowNumber As ColumnHeader
	Friend WithEvents ColRoomID As ColumnHeader
	Friend WithEvents ColRSize As ColumnHeader
	Friend WithEvents ColPatronID As ColumnHeader
	Friend WithEvents ColPatronName As ColumnHeader
	Friend WithEvents ColDate As ColumnHeader
	Friend WithEvents ColStartTime As ColumnHeader
	Friend WithEvents ColEndTime As ColumnHeader
	Friend WithEvents txtStartTime As TextBox
	Friend WithEvents cmbStartTime As ComboBox
	Friend WithEvents btnConfirm As Button
	Friend WithEvents dtpUpdateDate As DateTimePicker
End Class
