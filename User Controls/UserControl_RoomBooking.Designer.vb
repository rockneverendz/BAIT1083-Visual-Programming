<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl_RoomBooking
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.RoomBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.btnSearchStudent = New System.Windows.Forms.Button()
		Me.Splitter1 = New System.Windows.Forms.Splitter()
		Me.lblName = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtPatronID = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnReset = New System.Windows.Forms.Button()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.cmbEndTime = New System.Windows.Forms.ComboBox()
		Me.cmbStartTime = New System.Windows.Forms.ComboBox()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.lstAvailabilityChart = New System.Windows.Forms.ListView()
		Me.RoomID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time800 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time830 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time900 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time930 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time1000 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time1030 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time1100 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time1130 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time1200 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time1230 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time100 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time130 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time200 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time230 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time300 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time330 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time400 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time430 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time500 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time530 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time600 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time630 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time700 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.dtpSearch = New System.Windows.Forms.DateTimePicker()
		Me.Label7 = New System.Windows.Forms.Label()
		CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RoomBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel2.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
		'
		'ContextMenuStrip2
		'
		Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
		Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
		'
		'RoomBindingSource
		'
		Me.RoomBindingSource.DataSource = GetType(BAIT1083_Visual_Programming.Room)
		'
		'RoomBindingSource1
		'
		Me.RoomBindingSource1.DataSource = GetType(BAIT1083_Visual_Programming.Room)
		'
		'ContextMenuStrip3
		'
		Me.ContextMenuStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
		Me.ContextMenuStrip3.Size = New System.Drawing.Size(61, 4)
		'
		'Panel2
		'
		Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel2.Controls.Add(Me.btnSearchStudent)
		Me.Panel2.Controls.Add(Me.Splitter1)
		Me.Panel2.Controls.Add(Me.lblName)
		Me.Panel2.Controls.Add(Me.Label6)
		Me.Panel2.Controls.Add(Me.txtPatronID)
		Me.Panel2.Controls.Add(Me.Label1)
		Me.Panel2.Controls.Add(Me.TextBox2)
		Me.Panel2.Controls.Add(Me.TextBox1)
		Me.Panel2.Controls.Add(Me.Label2)
		Me.Panel2.Controls.Add(Me.btnReset)
		Me.Panel2.Controls.Add(Me.btnSubmit)
		Me.Panel2.Controls.Add(Me.Label5)
		Me.Panel2.Controls.Add(Me.cmbEndTime)
		Me.Panel2.Controls.Add(Me.cmbStartTime)
		Me.Panel2.Controls.Add(Me.DateTimePicker1)
		Me.Panel2.Controls.Add(Me.Label4)
		Me.Panel2.Controls.Add(Me.Label3)
		Me.Panel2.Location = New System.Drawing.Point(3, 435)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(1082, 165)
		Me.Panel2.TabIndex = 4
		'
		'btnSearchStudent
		'
		Me.btnSearchStudent.Location = New System.Drawing.Point(283, 29)
		Me.btnSearchStudent.Name = "btnSearchStudent"
		Me.btnSearchStudent.Size = New System.Drawing.Size(75, 23)
		Me.btnSearchStudent.TabIndex = 17
		Me.btnSearchStudent.Text = "Search"
		Me.btnSearchStudent.UseVisualStyleBackColor = True
		'
		'Splitter1
		'
		Me.Splitter1.Location = New System.Drawing.Point(0, 0)
		Me.Splitter1.Name = "Splitter1"
		Me.Splitter1.Size = New System.Drawing.Size(3, 161)
		Me.Splitter1.TabIndex = 16
		Me.Splitter1.TabStop = False
		'
		'lblName
		'
		Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblName.Location = New System.Drawing.Point(24, 90)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(253, 23)
		Me.lblName.TabIndex = 15
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(21, 65)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(98, 17)
		Me.Label6.TabIndex = 14
		Me.Label6.Text = "Student Name"
		'
		'txtPatronID
		'
		Me.txtPatronID.Location = New System.Drawing.Point(24, 30)
		Me.txtPatronID.Name = "txtPatronID"
		Me.txtPatronID.Size = New System.Drawing.Size(253, 22)
		Me.txtPatronID.TabIndex = 13
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(21, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(74, 17)
		Me.Label1.TabIndex = 12
		Me.Label1.Text = "Student ID"
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(794, 30)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(265, 22)
		Me.TextBox2.TabIndex = 11
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(503, 30)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(253, 22)
		Me.TextBox1.TabIndex = 10
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(500, 9)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(62, 17)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "Room ID"
		'
		'btnReset
		'
		Me.btnReset.Location = New System.Drawing.Point(863, 123)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Size = New System.Drawing.Size(95, 32)
		Me.btnReset.TabIndex = 8
		Me.btnReset.Text = "Clear"
		Me.btnReset.UseVisualStyleBackColor = True
		'
		'btnSubmit
		'
		Me.btnSubmit.Location = New System.Drawing.Point(964, 123)
		Me.btnSubmit.Name = "btnSubmit"
		Me.btnSubmit.Size = New System.Drawing.Size(95, 32)
		Me.btnSubmit.TabIndex = 7
		Me.btnSubmit.Text = "Submit"
		Me.btnSubmit.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(791, 9)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(101, 17)
		Me.Label5.TabIndex = 5
		Me.Label5.Text = "Number of Pax"
		'
		'cmbEndTime
		'
		Me.cmbEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbEndTime.FormattingEnabled = True
		Me.cmbEndTime.Location = New System.Drawing.Point(938, 84)
		Me.cmbEndTime.Name = "cmbEndTime"
		Me.cmbEndTime.Size = New System.Drawing.Size(121, 24)
		Me.cmbEndTime.TabIndex = 4
		'
		'cmbStartTime
		'
		Me.cmbStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbStartTime.FormattingEnabled = True
		Me.cmbStartTime.Items.AddRange(New Object() {"Start Time", "8.00 AM", "8.30 AM", "9.00 AM", "9.30 AM", "10.00 AM", "10.30 AM", "11.00 AM", "11.30 AM", "12.00 PM", "12.30 PM", "1.00 PM", "1.30 PM", "2.00 PM", "2.30 PM", "3.00 PM", "3.30 PM", "4.00 PM", "4.30 PM", "5.00 PM", "5.30 PM", "6.00 PM"})
		Me.cmbStartTime.Location = New System.Drawing.Point(794, 84)
		Me.cmbStartTime.Name = "cmbStartTime"
		Me.cmbStartTime.Size = New System.Drawing.Size(121, 24)
		Me.cmbStartTime.TabIndex = 3
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Location = New System.Drawing.Point(503, 86)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(253, 22)
		Me.DateTimePicker1.TabIndex = 2
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(791, 65)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(97, 17)
		Me.Label4.TabIndex = 1
		Me.Label4.Text = "Time Duration"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(500, 65)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(93, 17)
		Me.Label3.TabIndex = 0
		Me.Label3.Text = "Booking Date"
		'
		'Panel1
		'
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel1.Controls.Add(Me.lstAvailabilityChart)
		Me.Panel1.Location = New System.Drawing.Point(3, 3)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1082, 380)
		Me.Panel1.TabIndex = 3
		'
		'lstAvailabilityChart
		'
		Me.lstAvailabilityChart.BackColor = System.Drawing.SystemColors.ControlLight
		Me.lstAvailabilityChart.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.RoomID, Me.time800, Me.time830, Me.time900, Me.time930, Me.time1000, Me.time1030, Me.time1100, Me.time1130, Me.time1200, Me.time1230, Me.time100, Me.time130, Me.time200, Me.time230, Me.time300, Me.time330, Me.time400, Me.time430, Me.time500, Me.time530, Me.time600, Me.time630, Me.time700})
		Me.lstAvailabilityChart.GridLines = True
		Me.lstAvailabilityChart.HideSelection = False
		Me.lstAvailabilityChart.Location = New System.Drawing.Point(3, 3)
		Me.lstAvailabilityChart.Name = "lstAvailabilityChart"
		Me.lstAvailabilityChart.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstAvailabilityChart.Size = New System.Drawing.Size(1072, 375)
		Me.lstAvailabilityChart.TabIndex = 0
		Me.lstAvailabilityChart.UseCompatibleStateImageBehavior = False
		Me.lstAvailabilityChart.View = System.Windows.Forms.View.Details
		'
		'RoomID
		'
		Me.RoomID.Text = "Room Number"
		Me.RoomID.Width = 119
		'
		'time800
		'
		Me.time800.Text = "8.00 AM"
		Me.time800.Width = 70
		'
		'time830
		'
		Me.time830.Text = "8.30 AM"
		Me.time830.Width = 70
		'
		'time900
		'
		Me.time900.Text = "9.00 AM"
		Me.time900.Width = 70
		'
		'time930
		'
		Me.time930.Text = "9.30 AM"
		Me.time930.Width = 70
		'
		'time1000
		'
		Me.time1000.Text = "10.00 AM"
		Me.time1000.Width = 70
		'
		'time1030
		'
		Me.time1030.Text = "10.30 AM"
		Me.time1030.Width = 70
		'
		'time1100
		'
		Me.time1100.Text = "11.00 AM"
		Me.time1100.Width = 70
		'
		'time1130
		'
		Me.time1130.Text = "11.30 AM"
		Me.time1130.Width = 70
		'
		'time1200
		'
		Me.time1200.Text = "12.00 PM"
		Me.time1200.Width = 70
		'
		'time1230
		'
		Me.time1230.Text = "12.30 PM"
		Me.time1230.Width = 70
		'
		'time100
		'
		Me.time100.Text = "1.00 PM"
		Me.time100.Width = 70
		'
		'time130
		'
		Me.time130.Text = "1.30 PM"
		Me.time130.Width = 70
		'
		'time200
		'
		Me.time200.Text = "2.00 PM"
		Me.time200.Width = 70
		'
		'time230
		'
		Me.time230.Text = "2.30 PM"
		Me.time230.Width = 70
		'
		'time300
		'
		Me.time300.Text = "3.00 PM"
		Me.time300.Width = 70
		'
		'time330
		'
		Me.time330.Text = "3.30 PM"
		Me.time330.Width = 70
		'
		'time400
		'
		Me.time400.Text = "4.00 PM"
		Me.time400.Width = 70
		'
		'time430
		'
		Me.time430.Text = "4.30 PM"
		Me.time430.Width = 70
		'
		'time500
		'
		Me.time500.Text = "5.00 PM"
		Me.time500.Width = 70
		'
		'time530
		'
		Me.time530.Text = "5.30 PM"
		Me.time530.Width = 70
		'
		'time600
		'
		Me.time600.Text = "6.00 PM"
		Me.time600.Width = 70
		'
		'time630
		'
		Me.time630.Text = "6.30 PM"
		Me.time630.Width = 70
		'
		'time700
		'
		Me.time700.Text = "7.00 PM"
		Me.time700.Width = 70
		'
		'dtpSearch
		'
		Me.dtpSearch.Location = New System.Drawing.Point(137, 394)
		Me.dtpSearch.Name = "dtpSearch"
		Me.dtpSearch.Size = New System.Drawing.Size(200, 22)
		Me.dtpSearch.TabIndex = 5
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(21, 397)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(110, 17)
		Me.Label7.TabIndex = 6
		Me.Label7.Text = "Search by Date:"
		'
		'UserControl_RoomBooking
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.dtpSearch)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "UserControl_RoomBooking"
		Me.Size = New System.Drawing.Size(1097, 603)
		CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RoomBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
	Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
	Friend WithEvents RoomBindingSource As BindingSource
	Friend WithEvents RoomBindingSource1 As BindingSource
	Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
	Friend WithEvents txtPatronID As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents btnReset As Button
	Friend WithEvents btnSubmit As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents cmbEndTime As ComboBox
	Friend WithEvents cmbStartTime As ComboBox
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents lstAvailabilityChart As ListView
	Friend WithEvents RoomID As ColumnHeader
	Friend WithEvents time800 As ColumnHeader
	Friend WithEvents time830 As ColumnHeader
	Friend WithEvents time900 As ColumnHeader
	Friend WithEvents time930 As ColumnHeader
	Friend WithEvents time1000 As ColumnHeader
	Friend WithEvents time1030 As ColumnHeader
	Friend WithEvents time1100 As ColumnHeader
	Friend WithEvents time1130 As ColumnHeader
	Friend WithEvents time1200 As ColumnHeader
	Friend WithEvents time1230 As ColumnHeader
	Friend WithEvents time100 As ColumnHeader
	Friend WithEvents time130 As ColumnHeader
	Friend WithEvents time200 As ColumnHeader
	Friend WithEvents time230 As ColumnHeader
	Friend WithEvents time300 As ColumnHeader
	Friend WithEvents time330 As ColumnHeader
	Friend WithEvents time400 As ColumnHeader
	Friend WithEvents time430 As ColumnHeader
	Friend WithEvents time500 As ColumnHeader
	Friend WithEvents time530 As ColumnHeader
	Friend WithEvents time600 As ColumnHeader
	Friend WithEvents time630 As ColumnHeader
	Friend WithEvents time700 As ColumnHeader
	Friend WithEvents Label6 As Label
	Friend WithEvents lblName As Label
	Friend WithEvents Panel2 As Panel
	Friend WithEvents btnSearchStudent As Button
	Friend WithEvents Splitter1 As Splitter
	Friend WithEvents Panel1 As Panel
	Friend WithEvents dtpSearch As DateTimePicker
	Friend WithEvents Label7 As Label
End Class
