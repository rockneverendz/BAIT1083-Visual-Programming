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
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_RoomBookingReport))
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.chartTimeCount = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.lblSelectDate = New System.Windows.Forms.Label()
		Me.dtpSelectDate = New System.Windows.Forms.DateTimePicker()
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.lstQueryRpt = New System.Windows.Forms.ListView()
		Me.Time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Count = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.doc = New System.Drawing.Printing.PrintDocument()
		Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.Panel5.SuspendLayout()
		CType(Me.chartTimeCount, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel4.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel2.SuspendLayout()
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
		Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel5.Location = New System.Drawing.Point(0, 61)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(787, 462)
		Me.Panel5.TabIndex = 2
		'
		'chartTimeCount
		'
		Me.chartTimeCount.BackColor = System.Drawing.Color.WhiteSmoke
		Me.chartTimeCount.BackSecondaryColor = System.Drawing.Color.Gray
		Me.chartTimeCount.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke
		ChartArea1.AxisX.Title = "Time"
		ChartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far
		ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		ChartArea1.AxisY.Title = "Count"
		ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		ChartArea1.BackColor = System.Drawing.Color.PaleTurquoise
		ChartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal
		ChartArea1.BackSecondaryColor = System.Drawing.Color.White
		ChartArea1.BorderColor = System.Drawing.Color.Transparent
		ChartArea1.Name = "Time Count Chart "
		Me.chartTimeCount.ChartAreas.Add(ChartArea1)
		Me.chartTimeCount.Dock = System.Windows.Forms.DockStyle.Fill
		Legend1.Name = "Legend1"
		Me.chartTimeCount.Legends.Add(Legend1)
		Me.chartTimeCount.Location = New System.Drawing.Point(0, 0)
		Me.chartTimeCount.Name = "chartTimeCount"
		Series1.BorderWidth = 3
		Series1.ChartArea = "Time Count Chart "
		Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
		Series1.Legend = "Legend1"
		Series1.MarkerSize = 10
		Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
		Series1.Name = "Count"
		Me.chartTimeCount.Series.Add(Series1)
		Me.chartTimeCount.Size = New System.Drawing.Size(787, 462)
		Me.chartTimeCount.TabIndex = 0
		Me.chartTimeCount.Text = "Chart Count Time"
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
		Me.Panel4.Controls.Add(Me.Label1)
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Panel4.Location = New System.Drawing.Point(0, 0)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(787, 61)
		Me.Panel4.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(102, 17)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(533, 29)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Peak period for patron making room booking" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
		Me.btnPrint.Location = New System.Drawing.Point(72, 68)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(130, 37)
		Me.btnPrint.TabIndex = 0
		Me.btnPrint.Text = "Print"
		Me.btnPrint.UseVisualStyleBackColor = True
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.lstQueryRpt)
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
		'doc
		'
		'
		'dlgPreview
		'
		Me.dlgPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
		Me.dlgPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
		Me.dlgPreview.ClientSize = New System.Drawing.Size(400, 300)
		Me.dlgPreview.Enabled = True
		Me.dlgPreview.Icon = CType(resources.GetObject("dlgPreview.Icon"), System.Drawing.Icon)
		Me.dlgPreview.Name = "dlgPreview"
		Me.dlgPreview.Visible = False
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
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel2.ResumeLayout(False)
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
	Friend WithEvents Label1 As Label
	Friend WithEvents doc As Printing.PrintDocument
	Friend WithEvents dlgPreview As PrintPreviewDialog
End Class
