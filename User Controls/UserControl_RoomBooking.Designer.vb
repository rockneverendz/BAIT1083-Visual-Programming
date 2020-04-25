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
		Me.txtRmID = New System.Windows.Forms.TextBox()
		Me.txtEndTime = New System.Windows.Forms.TextBox()
		Me.btnSearchStudent = New System.Windows.Forms.Button()
		Me.Splitter1 = New System.Windows.Forms.Splitter()
		Me.lblName = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtPatronID = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtPax = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.btnReset = New System.Windows.Forms.Button()
		Me.btnSubmit = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.cmbStartTime = New System.Windows.Forms.ComboBox()
		Me.dtpAddDate = New System.Windows.Forms.DateTimePicker()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.lstAvailabilityChart = New System.Windows.Forms.ListView()
		Me.RoomID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time800 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time900 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time1000 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time1100 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time1200 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time100 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time200 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time300 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time400 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time500 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time600 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.time700 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.dtpSearch = New System.Windows.Forms.DateTimePicker()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Panel4 = New System.Windows.Forms.Panel()
		CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RoomBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel2.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
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
		Me.Panel2.Controls.Add(Me.txtRmID)
		Me.Panel2.Controls.Add(Me.txtEndTime)
		Me.Panel2.Controls.Add(Me.btnSearchStudent)
		Me.Panel2.Controls.Add(Me.Splitter1)
		Me.Panel2.Controls.Add(Me.lblName)
		Me.Panel2.Controls.Add(Me.Label6)
		Me.Panel2.Controls.Add(Me.txtPatronID)
		Me.Panel2.Controls.Add(Me.Label1)
		Me.Panel2.Controls.Add(Me.txtPax)
		Me.Panel2.Controls.Add(Me.Label2)
		Me.Panel2.Controls.Add(Me.btnReset)
		Me.Panel2.Controls.Add(Me.btnSubmit)
		Me.Panel2.Controls.Add(Me.Label5)
		Me.Panel2.Controls.Add(Me.cmbStartTime)
		Me.Panel2.Controls.Add(Me.dtpAddDate)
		Me.Panel2.Controls.Add(Me.Label4)
		Me.Panel2.Controls.Add(Me.Label3)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel2.Location = New System.Drawing.Point(0, 44)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(1067, 161)
		Me.Panel2.TabIndex = 4
		'
		'txtRmID
		'
		Me.txtRmID.Location = New System.Drawing.Point(503, 29)
		Me.txtRmID.Name = "txtRmID"
		Me.txtRmID.ReadOnly = True
		Me.txtRmID.Size = New System.Drawing.Size(253, 22)
		Me.txtRmID.TabIndex = 20
		'
		'txtEndTime
		'
		Me.txtEndTime.Location = New System.Drawing.Point(935, 84)
		Me.txtEndTime.Name = "txtEndTime"
		Me.txtEndTime.ReadOnly = True
		Me.txtEndTime.Size = New System.Drawing.Size(124, 22)
		Me.txtEndTime.TabIndex = 19
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
		Me.Splitter1.Size = New System.Drawing.Size(3, 157)
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
		'txtPax
		'
		Me.txtPax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtPax.Location = New System.Drawing.Point(794, 29)
		Me.txtPax.Name = "txtPax"
		Me.txtPax.ReadOnly = True
		Me.txtPax.Size = New System.Drawing.Size(265, 22)
		Me.txtPax.TabIndex = 11
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
		'cmbStartTime
		'
		Me.cmbStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbStartTime.FormattingEnabled = True
		Me.cmbStartTime.Items.AddRange(New Object() {"8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM"})
		Me.cmbStartTime.Location = New System.Drawing.Point(794, 84)
		Me.cmbStartTime.Name = "cmbStartTime"
		Me.cmbStartTime.Size = New System.Drawing.Size(121, 24)
		Me.cmbStartTime.TabIndex = 3
		'
		'dtpAddDate
		'
		Me.dtpAddDate.Location = New System.Drawing.Point(503, 86)
		Me.dtpAddDate.MinDate = New Date(2020, 4, 19, 20, 17, 14, 0)
		Me.dtpAddDate.Name = "dtpAddDate"
		Me.dtpAddDate.Size = New System.Drawing.Size(253, 22)
		Me.dtpAddDate.TabIndex = 2
		Me.dtpAddDate.Value = New Date(2020, 4, 19, 20, 17, 14, 0)
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
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1067, 320)
		Me.Panel1.TabIndex = 3
		'
		'lstAvailabilityChart
		'
		Me.lstAvailabilityChart.BackColor = System.Drawing.SystemColors.ControlLight
		Me.lstAvailabilityChart.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.RoomID, Me.time800, Me.time900, Me.time1000, Me.time1100, Me.time1200, Me.time100, Me.time200, Me.time300, Me.time400, Me.time500, Me.time600, Me.time700})
		Me.lstAvailabilityChart.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lstAvailabilityChart.GridLines = True
		Me.lstAvailabilityChart.HideSelection = False
		Me.lstAvailabilityChart.Location = New System.Drawing.Point(0, 0)
		Me.lstAvailabilityChart.Name = "lstAvailabilityChart"
		Me.lstAvailabilityChart.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstAvailabilityChart.Size = New System.Drawing.Size(1063, 316)
		Me.lstAvailabilityChart.TabIndex = 0
		Me.lstAvailabilityChart.UseCompatibleStateImageBehavior = False
		Me.lstAvailabilityChart.View = System.Windows.Forms.View.Details
		'
		'RoomID
		'
		Me.RoomID.Text = "Room Number"
		Me.RoomID.Width = 100
		'
		'time800
		'
		Me.time800.Text = "8.00 AM"
		Me.time800.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.time800.Width = 70
		'
		'time900
		'
		Me.time900.Text = "9.00 AM"
		Me.time900.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.time900.Width = 70
		'
		'time1000
		'
		Me.time1000.Text = "10.00 AM"
		Me.time1000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.time1000.Width = 70
		'
		'time1100
		'
		Me.time1100.Text = "11.00 AM"
		Me.time1100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.time1100.Width = 70
		'
		'time1200
		'
		Me.time1200.Text = "12.00 PM"
		Me.time1200.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.time1200.Width = 70
		'
		'time100
		'
		Me.time100.Text = "1.00 PM"
		Me.time100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.time100.Width = 70
		'
		'time200
		'
		Me.time200.Text = "2.00 PM"
		Me.time200.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.time200.Width = 70
		'
		'time300
		'
		Me.time300.Text = "3.00 PM"
		Me.time300.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.time300.Width = 70
		'
		'time400
		'
		Me.time400.Text = "4.00 PM"
		Me.time400.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.time400.Width = 70
		'
		'time500
		'
		Me.time500.Text = "5.00 PM"
		Me.time500.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.time500.Width = 70
		'
		'time600
		'
		Me.time600.Text = "6.00 PM"
		Me.time600.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.time600.Width = 70
		'
		'time700
		'
		Me.time700.Text = "7.00 PM"
		Me.time700.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.time700.Width = 70
		'
		'dtpSearch
		'
		Me.dtpSearch.Location = New System.Drawing.Point(139, 9)
		Me.dtpSearch.Name = "dtpSearch"
		Me.dtpSearch.Size = New System.Drawing.Size(200, 22)
		Me.dtpSearch.TabIndex = 5
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(23, 12)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(110, 17)
		Me.Label7.TabIndex = 6
		Me.Label7.Text = "Search by Date:"
		'
		'Panel3
		'
		Me.Panel3.Controls.Add(Me.dtpSearch)
		Me.Panel3.Controls.Add(Me.Label7)
		Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel3.Location = New System.Drawing.Point(0, 0)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(1067, 44)
		Me.Panel3.TabIndex = 1
		'
		'Panel4
		'
		Me.Panel4.Controls.Add(Me.Panel2)
		Me.Panel4.Controls.Add(Me.Panel3)
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel4.Location = New System.Drawing.Point(0, 320)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(1067, 205)
		Me.Panel4.TabIndex = 5
		'
		'UserControl_RoomBooking
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "UserControl_RoomBooking"
		Me.Size = New System.Drawing.Size(1067, 525)
		CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RoomBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel4.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
	Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
	Friend WithEvents RoomBindingSource As BindingSource
	Friend WithEvents RoomBindingSource1 As BindingSource
	Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
	Friend WithEvents txtPatronID As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents txtPax As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents btnReset As Button
	Friend WithEvents btnSubmit As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents cmbStartTime As ComboBox
	Friend WithEvents dtpAddDate As DateTimePicker
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents lblName As Label
	Friend WithEvents Panel2 As Panel
	Friend WithEvents btnSearchStudent As Button
	Friend WithEvents Splitter1 As Splitter
	Friend WithEvents Panel1 As Panel
	Friend WithEvents dtpSearch As DateTimePicker
	Friend WithEvents Label7 As Label
	Friend WithEvents txtEndTime As TextBox
	Friend WithEvents txtRmID As TextBox
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Panel4 As Panel
	Friend WithEvents lstAvailabilityChart As ListView
	Friend WithEvents RoomID As ColumnHeader
	Friend WithEvents time800 As ColumnHeader
	Friend WithEvents time900 As ColumnHeader
	Friend WithEvents time1000 As ColumnHeader
	Friend WithEvents time1100 As ColumnHeader
	Friend WithEvents time1200 As ColumnHeader
	Friend WithEvents time100 As ColumnHeader
	Friend WithEvents time200 As ColumnHeader
	Friend WithEvents time300 As ColumnHeader
	Friend WithEvents time400 As ColumnHeader
	Friend WithEvents time500 As ColumnHeader
	Friend WithEvents time600 As ColumnHeader
	Friend WithEvents time700 As ColumnHeader
End Class
