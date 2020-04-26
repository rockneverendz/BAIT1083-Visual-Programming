<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_RoomBookingReport
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
		Me.components = New System.ComponentModel.Container()
		Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.chartTimeCount = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.panForPrintHeader = New System.Windows.Forms.Panel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.lblPrintedBy = New System.Windows.Forms.Label()
		Me.lbl3 = New System.Windows.Forms.Label()
		Me.lblDateNow = New System.Windows.Forms.Label()
		Me.lblPrint = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.lblChartTitle = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.lblSelectDate = New System.Windows.Forms.Label()
		Me.dtpSelectDate = New System.Windows.Forms.DateTimePicker()
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.lstQueryRpt = New System.Windows.Forms.ListView()
		Me.Time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Count = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.dgvForPrint = New System.Windows.Forms.DataGridView()
		Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.easyRpt = New KimToo.EasyHTMLReports(Me.components)
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.Panel5.SuspendLayout()
		CType(Me.chartTimeCount, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.panForPrintHeader.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel4.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.dgvForPrint, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer1.Name = "SplitContainer1"
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.Panel5)
		Me.SplitContainer1.Panel1.Controls.Add(Me.Panel4)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
		Me.SplitContainer1.Size = New System.Drawing.Size(1067, 523)
		Me.SplitContainer1.SplitterDistance = 787
		Me.SplitContainer1.TabIndex = 2
		'
		'Panel5
		'
		Me.Panel5.Controls.Add(Me.chartTimeCount)
		Me.Panel5.Controls.Add(Me.panForPrintHeader)
		Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel5.Location = New System.Drawing.Point(0, 61)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(787, 462)
		Me.Panel5.TabIndex = 2
		'
		'chartTimeCount
		'
		Me.chartTimeCount.BackSecondaryColor = System.Drawing.Color.LightGray
		Me.chartTimeCount.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke
		ChartArea2.AxisX.Title = "Time"
		ChartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far
		ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		ChartArea2.AxisY.Title = "Count"
		ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		ChartArea2.BackColor = System.Drawing.Color.PaleTurquoise
		ChartArea2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal
		ChartArea2.BackSecondaryColor = System.Drawing.Color.White
		ChartArea2.BorderColor = System.Drawing.Color.Transparent
		ChartArea2.Name = "Time Count Chart "
		Me.chartTimeCount.ChartAreas.Add(ChartArea2)
		Me.chartTimeCount.Dock = System.Windows.Forms.DockStyle.Fill
		Legend2.Name = "Legend1"
		Me.chartTimeCount.Legends.Add(Legend2)
		Me.chartTimeCount.Location = New System.Drawing.Point(0, 0)
		Me.chartTimeCount.Name = "chartTimeCount"
		Series2.BorderWidth = 3
		Series2.ChartArea = "Time Count Chart "
		Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
		Series2.Legend = "Legend1"
		Series2.MarkerSize = 10
		Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
		Series2.Name = "Count"
		Me.chartTimeCount.Series.Add(Series2)
		Me.chartTimeCount.Size = New System.Drawing.Size(787, 462)
		Me.chartTimeCount.TabIndex = 0
		Me.chartTimeCount.Text = "Chart Count Time"
		'
		'panForPrintHeader
		'
		Me.panForPrintHeader.BackColor = System.Drawing.Color.White
		Me.panForPrintHeader.Controls.Add(Me.PictureBox1)
		Me.panForPrintHeader.Controls.Add(Me.lblPrintedBy)
		Me.panForPrintHeader.Controls.Add(Me.lbl3)
		Me.panForPrintHeader.Controls.Add(Me.lblDateNow)
		Me.panForPrintHeader.Controls.Add(Me.lblPrint)
		Me.panForPrintHeader.Controls.Add(Me.Label2)
		Me.panForPrintHeader.Location = New System.Drawing.Point(3, 304)
		Me.panForPrintHeader.Name = "panForPrintHeader"
		Me.panForPrintHeader.Size = New System.Drawing.Size(784, 153)
		Me.panForPrintHeader.TabIndex = 1
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.circle_cropped
		Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(155, 146)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 5
		Me.PictureBox1.TabStop = False
		'
		'lblPrintedBy
		'
		Me.lblPrintedBy.BackColor = System.Drawing.Color.Transparent
		Me.lblPrintedBy.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrintedBy.Location = New System.Drawing.Point(274, 102)
		Me.lblPrintedBy.Name = "lblPrintedBy"
		Me.lblPrintedBy.Size = New System.Drawing.Size(113, 23)
		Me.lblPrintedBy.TabIndex = 4
		'
		'lbl3
		'
		Me.lbl3.BackColor = System.Drawing.Color.Transparent
		Me.lbl3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl3.Location = New System.Drawing.Point(182, 102)
		Me.lbl3.Name = "lbl3"
		Me.lbl3.Size = New System.Drawing.Size(84, 23)
		Me.lbl3.TabIndex = 3
		Me.lbl3.Text = "Printed by:"
		'
		'lblDateNow
		'
		Me.lblDateNow.BackColor = System.Drawing.Color.Transparent
		Me.lblDateNow.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDateNow.Location = New System.Drawing.Point(274, 79)
		Me.lblDateNow.Name = "lblDateNow"
		Me.lblDateNow.Size = New System.Drawing.Size(113, 23)
		Me.lblDateNow.TabIndex = 2
		'
		'lblPrint
		'
		Me.lblPrint.BackColor = System.Drawing.Color.Transparent
		Me.lblPrint.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrint.Location = New System.Drawing.Point(182, 79)
		Me.lblPrint.Name = "lblPrint"
		Me.lblPrint.Size = New System.Drawing.Size(98, 23)
		Me.lblPrint.TabIndex = 1
		Me.lblPrint.Text = "Printed on:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(180, 43)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(269, 32)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Room Booking Report"
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.White
		Me.Panel4.Controls.Add(Me.lblChartTitle)
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Panel4.Location = New System.Drawing.Point(0, 0)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(787, 61)
		Me.Panel4.TabIndex = 1
		'
		'lblChartTitle
		'
		Me.lblChartTitle.AutoSize = True
		Me.lblChartTitle.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblChartTitle.Location = New System.Drawing.Point(102, 17)
		Me.lblChartTitle.Name = "lblChartTitle"
		Me.lblChartTitle.Size = New System.Drawing.Size(538, 32)
		Me.lblChartTitle.TabIndex = 0
		Me.lblChartTitle.Text = "Peak period for patron making room booking" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'Panel1
		'
		Me.Panel1.AutoSize = True
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel1.Controls.Add(Me.Panel3)
		Me.Panel1.Controls.Add(Me.Panel2)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(276, 523)
		Me.Panel1.TabIndex = 0
		'
		'Panel3
		'
		Me.Panel3.Controls.Add(Me.lblSelectDate)
		Me.Panel3.Controls.Add(Me.dtpSelectDate)
		Me.Panel3.Controls.Add(Me.btnPrint)
		Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel3.Location = New System.Drawing.Point(0, 411)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(272, 108)
		Me.Panel3.TabIndex = 2
		'
		'lblSelectDate
		'
		Me.lblSelectDate.AutoSize = True
		Me.lblSelectDate.Location = New System.Drawing.Point(11, 15)
		Me.lblSelectDate.Name = "lblSelectDate"
		Me.lblSelectDate.Size = New System.Drawing.Size(83, 17)
		Me.lblSelectDate.TabIndex = 2
		Me.lblSelectDate.Text = "Select date:"
		'
		'dtpSelectDate
		'
		Me.dtpSelectDate.CustomFormat = "MM/yyyy"
		Me.dtpSelectDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpSelectDate.Location = New System.Drawing.Point(14, 35)
		Me.dtpSelectDate.Name = "dtpSelectDate"
		Me.dtpSelectDate.Size = New System.Drawing.Size(246, 22)
		Me.dtpSelectDate.TabIndex = 1
		'
		'btnPrint
		'
		Me.btnPrint.Location = New System.Drawing.Point(77, 63)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(118, 37)
		Me.btnPrint.TabIndex = 0
		Me.btnPrint.Text = "Print"
		Me.btnPrint.UseVisualStyleBackColor = True
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.lstQueryRpt)
		Me.Panel2.Controls.Add(Me.dgvForPrint)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel2.Location = New System.Drawing.Point(0, 0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(272, 405)
		Me.Panel2.TabIndex = 1
		'
		'lstQueryRpt
		'
		Me.lstQueryRpt.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Time, Me.Count})
		Me.lstQueryRpt.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lstQueryRpt.HideSelection = False
		Me.lstQueryRpt.Location = New System.Drawing.Point(0, 0)
		Me.lstQueryRpt.Name = "lstQueryRpt"
		Me.lstQueryRpt.Size = New System.Drawing.Size(272, 405)
		Me.lstQueryRpt.TabIndex = 0
		Me.lstQueryRpt.UseCompatibleStateImageBehavior = False
		Me.lstQueryRpt.View = System.Windows.Forms.View.Details
		'
		'Time
		'
		Me.Time.Text = "Time"
		Me.Time.Width = 75
		'
		'Count
		'
		Me.Count.Text = "Total Booking"
		Me.Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.Count.Width = 100
		'
		'dgvForPrint
		'
		Me.dgvForPrint.BackgroundColor = System.Drawing.SystemColors.Control
		Me.dgvForPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvForPrint.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNo, Me.colTime, Me.colCount})
		Me.dgvForPrint.Location = New System.Drawing.Point(3, 3)
		Me.dgvForPrint.Name = "dgvForPrint"
		Me.dgvForPrint.RowHeadersWidth = 51
		Me.dgvForPrint.RowTemplate.Height = 24
		Me.dgvForPrint.Size = New System.Drawing.Size(266, 399)
		Me.dgvForPrint.TabIndex = 2
		'
		'colNo
		'
		Me.colNo.HeaderText = "No"
		Me.colNo.MinimumWidth = 6
		Me.colNo.Name = "colNo"
		Me.colNo.Width = 125
		'
		'colTime
		'
		Me.colTime.HeaderText = "Time"
		Me.colTime.MinimumWidth = 6
		Me.colTime.Name = "colTime"
		Me.colTime.Width = 125
		'
		'colCount
		'
		Me.colCount.HeaderText = "Total Booking"
		Me.colCount.MinimumWidth = 6
		Me.colCount.Name = "colCount"
		Me.colCount.Width = 125
		'
		'easyRpt
		'
		Me.easyRpt.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
		Me.easyRpt.AlternativeRowGridColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(65, Byte), Integer))
		Me.easyRpt.HeaderBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(197, Byte), Integer))
		Me.easyRpt.HeaderFontColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(46, Byte), Integer))
		Me.easyRpt.HeaderGridColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(65, Byte), Integer))
		Me.easyRpt.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.easyRpt.RowDefaultFontColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(46, Byte), Integer))
		Me.easyRpt.RowDefaultGridColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(65, Byte), Integer))
		'
		'UserControl_RoomBookingReport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.Controls.Add(Me.SplitContainer1)
		Me.Name = "UserControl_RoomBookingReport"
		Me.Size = New System.Drawing.Size(1067, 523)
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.Panel2.PerformLayout()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		Me.Panel5.ResumeLayout(False)
		CType(Me.chartTimeCount, System.ComponentModel.ISupportInitialize).EndInit()
		Me.panForPrintHeader.ResumeLayout(False)
		Me.panForPrintHeader.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		CType(Me.dgvForPrint, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents lstQueryRpt As ListView
	Friend WithEvents Time As ColumnHeader
	Friend WithEvents Count As ColumnHeader
	Friend WithEvents lblSelectDate As Label
	Friend WithEvents dtpSelectDate As DateTimePicker
	Friend WithEvents btnPrint As Button
	Friend WithEvents chartTimeCount As DataVisualization.Charting.Chart
	Friend WithEvents Panel5 As Panel
	Friend WithEvents Panel4 As Panel
	Friend WithEvents lblChartTitle As Label
	Friend WithEvents easyRpt As KimToo.EasyHTMLReports
	Friend WithEvents panForPrintHeader As Panel
	Friend WithEvents Label2 As Label
	Friend WithEvents lblDateNow As Label
	Friend WithEvents lblPrint As Label
	Friend WithEvents lbl3 As Label
	Friend WithEvents lblPrintedBy As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents dgvForPrint As DataGridView
	Friend WithEvents colNo As DataGridViewTextBoxColumn
	Friend WithEvents colTime As DataGridViewTextBoxColumn
	Friend WithEvents colCount As DataGridViewTextBoxColumn
End Class
